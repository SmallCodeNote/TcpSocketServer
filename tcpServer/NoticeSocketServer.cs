using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Net.Http;
using System.Collections.Concurrent;
using System.Diagnostics;


namespace tcpserver
{
    public class NoticeSocketServer : IDisposable
    {
        /// <summary>
        /// Received TcpSocket Queue.
        /// </summary>
        public ConcurrentQueue<NoticeMessage> NoticeQueue;


        private bool _noticeCheckContinueFlag = false;

        private HttpClient httpClient;

        public NoticeSocketServer(int TimeoutSec = 3)
        {
            _initialize(TimeoutSec);
        }

        public NoticeSocketServer(TimeSpan Timeout)
        {
            _initialize(Timeout);
        }

        private void _initialize(int TimeoutSec = 3)
        {
            if (TimeoutSec < 1) { TimeoutSec = 1; };

            _initialize(new TimeSpan(0, 0, 0, TimeoutSec));
        }

        private void _initialize(TimeSpan Timeout)
        {
            if (Timeout.TotalSeconds < 1) { Timeout = new TimeSpan(0, 0, 0, 1); };

            httpClient = new HttpClient();
            httpClient.Timeout = Timeout;
        }

        public void StartNoticeCheck()
        {
            if (!_noticeCheckContinueFlag)
            {
                _noticeCheckContinueFlag = true;

                try
                {
                    Task.Run(() =>
                    {
                        while (_noticeCheckContinueFlag)
                        {
                            if (NoticeQueue.Count > 0)
                            {
                                NoticeMessage b;
                                if (NoticeQueue.TryDequeue(out b))
                                {
                                    sendNoticeMessage(b);
                                }

                            }

                            Thread.Sleep(100);

                        }

                    });

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }

        public void StopCheck()
        {
            _noticeCheckContinueFlag = false;
            return;
        }

        public void sendNoticeMessage(NoticeMessage noticeMessage)
        {

            List<Task> taskList = new List<Task>();

            foreach (string address in noticeMessage.addressList)
            {
                taskList.Add(Task.Run(() => httpClient.GetStringAsync(address + noticeMessage.message)));

            }

            Task.WaitAll(taskList.ToArray());

        }


        public void Dispose()
        {
            httpClient.Dispose();
            GC.SuppressFinalize(this);
        }

    }

    public class NoticeMessage
    {
        public List<string> addressList;
        public string message;

        public NoticeMessage(string addressListup, string message)
        {
            this.addressList = new List<string>(addressListup.Split(','));
            this.message = message;

        }

    }


}
