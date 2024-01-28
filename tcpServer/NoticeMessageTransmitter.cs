using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Net.Http;
using System.Collections.Concurrent;
using System.Diagnostics;

using System.Xml;

namespace tcpserver
{
    public class NoticeTransmitter
    {
        /// <summary>
        /// Received Notice Queue.
        /// </summary>
        public ConcurrentQueue<NoticeMessage> NoticeQueue;

        /// <summary>
        /// Running Notice.
        /// </summary>
        public ConcurrentDictionary<string, NoticeMessageHandling> NoticeRunning;

        private bool _noticeCheckContinueFlag = false;
        public int _threadSleepLength = 100;

        public int httpTimeout = 3;


        public NoticeTransmitter(bool _debug = false)
        {
            NoticeQueue = new ConcurrentQueue<NoticeMessage>();
            NoticeRunning = new ConcurrentDictionary<string, NoticeMessageHandling>();

        }

        public bool AddNotice(NoticeMessage notice)
        {
            if (!NoticeRunning.ContainsKey(notice.Key))
            {
                NoticeQueue.Enqueue(notice);
                return true;
            };

            return false;

        }

        public bool AddNotice(ClientData targetClient, SocketMessage socketMessage)
        {
            bool result = true;

            foreach (var address in targetClient.addressList)
            {
                NoticeMessage item = new NoticeMessage(address.address, socketMessage);

                result = result && AddNotice(item);
            }

            return result;
        }

        public void StartNoticeCheck()
        {
            if (!_noticeCheckContinueFlag)
            {
                _noticeCheckContinueFlag = true;

                Task.Run(() =>
                {
                    while (_noticeCheckContinueFlag)
                    {
                        try
                        {
                            if (NoticeRunning.Count > 0)
                            {
                                foreach (var item in NoticeRunning)
                                {
                                    if (item.Value.FinishNotice)
                                    {
                                        NoticeMessageHandling h;
                                        if (NoticeRunning.TryRemove(item.Key, out h)) { h.Dispose(); };
                                    }
                                }
                            }

                            if (NoticeQueue.Count > 0)
                            {
                                NoticeMessage b;
                                if (NoticeQueue.TryDequeue(out b))
                                {
                                    NoticeMessageHandling handling = new NoticeMessageHandling(b, httpTimeout);

                                    if (NoticeRunning.TryAdd(b.Key, handling))
                                    {
                                        handling.StartNotice();
                                    }
                                }
                            }

                            Thread.Sleep(_threadSleepLength);

                        }
                        catch (Exception ex)
                        {
                            Debug.Write(DateTime.Now.ToString("HH:mm:ss") + " " + GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " ");
                            Debug.WriteLine(ex.ToString());

                        }
                    }

                });

            }

        }

        public void StopCheck()
        {
            _noticeCheckContinueFlag = false;
            return;
        }

    }

    public class NoticeMessageHandling : IDisposable
    {
        private HttpClient httpClient;
        public NoticeMessage notice;

        public bool FinishNotice = false;
        public int WaitNoticeFinish_Timeout = 30;

        public int _threadSleepLength = 100;
        public bool _debug = true;


        public int timeout
        {
            get { return (int)httpClient.Timeout.TotalSeconds; }
            set { httpClient.Timeout = new TimeSpan(0, 0, value); }
        }


        public NoticeMessageHandling(NoticeMessage notice, int timeout = 3)
        {
            this.notice = notice;
            httpClient = new HttpClient();
            httpClient.Timeout = new TimeSpan(0, 0, timeout);
        }


        public Task StartNotice()
        {
            return Task.Run(() =>
            {
                FinishNotice = false;

                if (!WaitNoticeFinish())
                {
                    FinishNotice = true;
                    return; //notice continue check error
                }

                SendNotice();
                Thread.Sleep(timeout * 1000);
                WaitNoticeFinish();
                FinishNotice = true;

            });

        }

        private string SendNotice()
        {
            string speech = (notice.message != null && notice.message.Length > 0) ? "speech=" + notice.message : "";
            string parameter = (notice.parameter != null && notice.parameter.Length > 0) ?  notice.parameter : "";
            string separator = (speech.Length > 0 && parameter.Length > 0) ? "&" : "";

            if (speech.Length == 0 && parameter.Length == 0) return "";
           
            string url = @"http://" + notice.address + @"/api/control?" + speech + separator + parameter;

            Debug.Write(DateTime.Now.ToString("HH:mm:ss") + " " + GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " ");
            Debug.WriteLine(url);

            if (_debug) { return ""; }

            try
            {
                HttpResponseMessage m = httpClient.GetAsync(url).Result;
                return m.Content.ToString();
            }
            catch (Exception ex)
            {
                Debug.Write(DateTime.Now.ToString("HH:mm:ss") + " " + GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " ");
                Debug.WriteLine(ex.ToString());
            }

            return "";
        }

        private bool WaitNoticeFinish()
        {
            DateTime startTime = DateTime.Now;

            if (_debug)
            {
                Debug.WriteLine("WaitStart_Debug " + DateTime.Now.ToString("HH:mm:ss") + " " + GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " ");
                Thread.Sleep(10000);
                Debug.WriteLine("WaitEnd_Debug " + DateTime.Now.ToString("HH:mm:ss") + " " + GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " ");
                
                return true;
            }

            do
            {
                try
                {
                    string url = @"http://" + notice.address + @"/api/status?format=xml";
                    Debug.Write("WaitStart " + DateTime.Now.ToString("HH:mm:ss") + " " + GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " ");
                    Debug.WriteLine(url);

                    HttpResponseMessage m = httpClient.GetAsync(url).Result;

                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(m.Content.ToString());

                    XmlNode soundNode = doc.SelectSingleNode("//sound[@name='SOUND']");
                    string soundValue = soundNode.Attributes["value"].Value;

                    bool waitContinue = soundValue != "0";
                    if (!waitContinue)
                    {
                        Debug.Write("WaitEnd " + DateTime.Now.ToString("HH:mm:ss") + " " + GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " ");
                        Debug.WriteLine(url);
                        return true;
                    }

                    Thread.Sleep(_threadSleepLength);

                }
                catch (Exception ex)
                {
                    Debug.Write("WaitEnd_ERROR " + DateTime.Now.ToString("HH:mm:ss") + " " + GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]]");
                    Debug.WriteLine(ex.ToString());
                    return false;
                }

            } while ((DateTime.Now - startTime).TotalSeconds > WaitNoticeFinish_Timeout);

            Debug.WriteLine("WaitEnd_TimeOut " + DateTime.Now.ToString("HH:mm:ss") + " " + GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]]");

            return false;
        }

        public void Dispose()
        {
            httpClient.Dispose();
            GC.SuppressFinalize(this);
        }

    }

    public class NoticeMessage
    {
        public string address;
        public string message;
        public string parameter;
        public DateTime keyTime;

        public string Key
        {
            get { return this.address + "_" + keyTime.ToString("yyyy/MM/dd HH:mm:ss.fff") + "_" + message; }
        }
        
        public NoticeMessage(string address, SocketMessage socket)
        {
            this.address = address;
            this.message = socket.message;
            this.parameter = socket.parameter;
            this.keyTime = socket.connectTime;
        }

        public static bool operator ==(NoticeMessage c1, NoticeMessage c2)
        {
            return c1.Key == c2.Key;
        }

        public static bool operator !=(NoticeMessage c1, NoticeMessage c2)
        {
            return c1.Key != c2.Key;

        }

    }

}
