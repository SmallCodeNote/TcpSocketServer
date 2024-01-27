using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Diagnostics;

using FluentScheduler;
using LiteDB;


namespace tcpserver
{
    public class FluentSchedulerRegistry : Registry
    {
        public List<string> ScheduleList;
        public string DataBaseFilePath;

        private ConnectionString _LiteDBconnectionString;
        private NoticeTransmitter noticeTransmitter;

        List<ClientData> clientList;

        private int idxName = 0;
        private int idxCheck = 1;
        private int idxUnit = 2;
        private int idxAt = 3;

        public FluentSchedulerRegistry(string DataBaseFilePath, NoticeTransmitter noticeTransmitter, string[] Lines, List<ClientData> clientList)
        {
            _LiteDBconnectionString = new ConnectionString();
            _LiteDBconnectionString.Connection = ConnectionType.Shared;
            _LiteDBconnectionString.Filename = DataBaseFilePath;

            this.noticeTransmitter = noticeTransmitter;
            this.clientList = clientList;

            ScheduleList = new List<string>();

            foreach (string Line in Lines)
            {
                string[] cols = Line.Split('\t');

                if (cols[idxUnit] == "EveryDays")
                {
                    try
                    {
                        string[] atinfo = cols[idxAt].Split(',');
                        foreach (string t in atinfo)
                        {
                            int[] hm = Array.ConvertAll(t.Split(':'), s => int.Parse(s));
                            int h = hm[0];
                            int m = hm[1];
                            FluentSchedulerJob job = new FluentSchedulerJob(_LiteDBconnectionString, noticeTransmitter, cols[idxName], cols[idxCheck], new TimeSpan(24, 0, 0), clientList);
                            Schedule(job.Execute()).ToRunEvery(1).Days().At(h, m);
                            ScheduleList.Add("EveryDays at " + t);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("[[" + GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]]");
                        Debug.WriteLine(ex.ToString());

                        ScheduleList.Add("ERROR: " + Line);
                    }
                }
                else if (cols[idxUnit] == "EveryHours")
                {
                    try
                    {
                        int[] atinfo = Array.ConvertAll(cols[idxAt].Split(','), s => int.Parse(s));
                        foreach (int m in atinfo)
                        {
                            FluentSchedulerJob job = new FluentSchedulerJob(_LiteDBconnectionString, noticeTransmitter, cols[idxName], cols[idxCheck], new TimeSpan(1, 0, 0), clientList);
                            Schedule(job.Execute()).ToRunEvery(1).Hours().At(m);
                            ScheduleList.Add("EveryHours at " + m.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("[[" + GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]]");
                        Debug.WriteLine(ex.ToString());

                        ScheduleList.Add("ERROR: " + Line);
                    }

                }
                else if (cols[idxUnit] == "EverySeconds")
                {
                    try
                    {
                        int[] atinfo = Array.ConvertAll(cols[idxAt].Split(','), s => int.Parse(s));
                        foreach (int s in atinfo)
                        {
                            FluentSchedulerJob job = new FluentSchedulerJob(_LiteDBconnectionString, noticeTransmitter, cols[idxName], cols[idxCheck], new TimeSpan(0, 0, s), clientList);
                            Schedule(job.Execute()).ToRunEvery(s).Seconds();
                            ScheduleList.Add("EverySeconds at " + s.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("[[" + GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + "]]");
                        Debug.WriteLine(ex.ToString());

                        ScheduleList.Add("ERROR: " + Line);
                    }

                }

            }

        }

    }

    public class FluentSchedulerJob
    {
        public string StatusName;
        public bool CheckNeed;
        public string IntervalInfo;

        public string EveryIntervalUnit;

        private ConnectionString _LiteDBconnectionString;

        public DateTime LastRunTime;

        private NoticeTransmitter noticeTransmitter;
        List<ClientData> clientList;


        public FluentSchedulerJob(ConnectionString _LiteDBconnectionString, NoticeTransmitter noticeTransmitter, string StatusName, string CheckNeed, TimeSpan IntervalLine, List<ClientData> clientList)
        {
            this._LiteDBconnectionString = _LiteDBconnectionString;
            this.noticeTransmitter = noticeTransmitter;
            this.StatusName = StatusName;

            if (bool.TryParse(CheckNeed, out this.CheckNeed))
            {
                this.CheckNeed = false;
            }

            this.LastRunTime = DateTime.Now - IntervalLine;
            this.clientList = clientList;

        }

        public Action Execute()
        {
            return new Action(delegate ()
            {
                int _retryCount = 10;

                for (int i = 0; i < _retryCount; i++)
                {
                    try
                    {

                        using (LiteDatabase litedb = new LiteDatabase(_LiteDBconnectionString.Filename))
                        {
                            ILiteCollection<SocketMessage> col = litedb.GetCollection<SocketMessage>("table_Message");

                            foreach (var targetClient in clientList)
                            {

                                var latestTargetClientRecord =

                                    col.Query().Where(x => x.clientName == targetClient.ClientName)
                                               .OrderByDescending(x => x.connectTime)
                                               .FirstOrDefault();


                                var latestTargetClientRecord_OnSameStatusName =

                                    col.Query().Where(x => x.clientName == targetClient.ClientName && x.status == StatusName && !x.check && x.needCheck)
                                               .OrderByDescending(x => x.connectTime)
                                               .FirstOrDefault();


                                if (latestTargetClientRecord != null && latestTargetClientRecord_OnSameStatusName != null)
                                {
                                    if (latestTargetClientRecord.connectTime > latestTargetClientRecord_OnSameStatusName.connectTime)
                                    {
                                        noticeTransmitter.AddNotice(targetClient, latestTargetClientRecord);
                                        noticeTransmitter.AddNotice(targetClient, latestTargetClientRecord_OnSameStatusName);
                                    }
                                    else
                                    {
                                        noticeTransmitter.AddNotice(targetClient, latestTargetClientRecord_OnSameStatusName);
                                    }

                                }
                                else if (latestTargetClientRecord_OnSameStatusName != null)
                                {
                                    noticeTransmitter.AddNotice(targetClient, latestTargetClientRecord_OnSameStatusName);
                                }

                            }


                        }

                        LastRunTime = DateTime.Now;
                        break;

                    }
                    catch (Exception ex)
                    {
                        Debug.Write(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " retry:" + i.ToString());
                        Debug.WriteLine(ex.ToString());
                        Thread.Sleep(100);

                        if (i == _retryCount - 1)
                        {
                            throw;
                        }
                    }
                }

            });

        }

    }

}
