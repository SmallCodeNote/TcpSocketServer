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

        public NoticeTransmitter()
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
                                    NoticeMessageHandling handling = new NoticeMessageHandling(b);

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

        public int timeout
        {
            get { return (int)httpClient.Timeout.TotalSeconds; }
            set { httpClient.Timeout = new TimeSpan(0, 0, value); }
        }

        public int _threadSleepLength = 100;

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
            string parameter = new FormUrlEncodedContent(notice.parameters).ReadAsStringAsync().Result;
            string url = @"http://" + notice.address + @"/api/control?" + parameter;
            HttpResponseMessage m = httpClient.GetAsync(url).Result;
            return m.Content.ToString();
        }

        private bool WaitNoticeFinish()
        {
            bool noticeContinue = true;

            do
            {
                try
                {
                    string url = @"http://" + notice.address + @"/api/status?format=xml";
                    HttpResponseMessage m = httpClient.GetAsync(url).Result;

                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(m.Content.ToString());

                    XmlNode soundNode = doc.SelectSingleNode("//sound[@name='SOUND']");
                    string soundValue = soundNode.Attributes["value"].Value;

                    noticeContinue = soundValue != "0";
                    Thread.Sleep(_threadSleepLength);

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    return false;
                }

            } while (noticeContinue);

            return true;
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
        public Dictionary<string, string> parameters;

        public string Key
        {
            get { return this.address + new FormUrlEncodedContent(this.parameters).ReadAsStringAsync().Result; }
        }

        public NoticeMessage(string address, Dictionary<string, string> parameters)
        {
            this.address = address;
            this.parameters = parameters;

        }

        public NoticeMessage(string address, string[] parameters)
        {
            this.address = address;
            this.parameters = new Dictionary<string, string>();

            for (int i = 0; i < parameters.Length - 1; i += 2)
            {
                this.parameters.Add(parameters[i], parameters[i + 1]);
            }

        }

        public NoticeMessage(string address, string message, string parameters = "")
        {
            this.address = address;

            this.parameters = new Dictionary<string, string>();

            if (message.Length > 0) this.parameters.Add("speech", message);

            string[] cols = parameters.Split('\t');

            for (int i = 0; i < cols.Length - 1; i += 2)
            {
                this.parameters.Add(cols[i], cols[i + 1]);
            }

        }

        public static bool operator ==(NoticeMessage c1, NoticeMessage c2)
        {
            string p1 = new FormUrlEncodedContent(c1.parameters).ReadAsStringAsync().Result;
            string p2 = new FormUrlEncodedContent(c2.parameters).ReadAsStringAsync().Result;

            return c1.address == c2.address && p1 == p2;
        }

        public static bool operator !=(NoticeMessage c1, NoticeMessage c2)
        {
            if (c1.address != c2.address) return true;

            string p1 = new FormUrlEncodedContent(c1.parameters).ReadAsStringAsync().Result;
            string p2 = new FormUrlEncodedContent(c2.parameters).ReadAsStringAsync().Result;

            return p1 != p2;

        }

    }

}
