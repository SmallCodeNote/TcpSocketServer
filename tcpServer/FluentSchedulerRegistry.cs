using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private int idxName = 0;
        private int idxCheck = 1;
        private int idxUnit = 2;
        private int idxAt = 3;


        public FluentSchedulerRegistry(string DataBaseFilePath, NoticeTransmitter noticeTransmitter, string[] Lines)
        {
            _LiteDBconnectionString = new ConnectionString();
            _LiteDBconnectionString.Connection = ConnectionType.Shared;
            _LiteDBconnectionString.Filename = DataBaseFilePath;

            this.noticeTransmitter = noticeTransmitter;

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
                            FluentSchedulerJob job = new FluentSchedulerJob(noticeTransmitter, cols[idxName], cols[idxCheck], new TimeSpan(24, 0, 0));
                            Schedule(job.Execute()).ToRunEvery(1).Days().At(h, m);
                            ScheduleList.Add("EveryDays at " + t);
                        }
                    }
                    catch
                    {
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
                            FluentSchedulerJob job = new FluentSchedulerJob(noticeTransmitter, cols[idxName], cols[idxCheck], new TimeSpan(1, 0, 0));
                            Schedule(job.Execute()).ToRunEvery(1).Hours().At(m);
                            ScheduleList.Add("EveryHours at " + m.ToString());
                        }
                    }
                    catch
                    {
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
                            FluentSchedulerJob job = new FluentSchedulerJob(noticeTransmitter, cols[idxName], cols[idxCheck], new TimeSpan(0, 0, s));
                            Schedule(job.Execute()).ToRunEvery(s).Seconds();
                            ScheduleList.Add("EverySeconds at " + s.ToString());
                        }
                    }
                    catch
                    {
                        ScheduleList.Add("ERROR: " + Line);
                    }

                }

            }

        }

    }

    public class FluentSchedulerJob
    {
        public string Name;
        public bool CheckNeed;
        public string IntervalInfo;

        public string EveryIntervalUnit;

        public DateTime LastRunTime;

        private NoticeTransmitter noticeTransmitter;

        public FluentSchedulerJob(NoticeTransmitter noticeTransmitter, string Name, string CheckNeed, TimeSpan IntervalLine)
        {
            this.noticeTransmitter = noticeTransmitter;
            this.Name = Name;

            if (bool.TryParse(CheckNeed, out this.CheckNeed))
            {
                this.CheckNeed = false;
            }

            this.LastRunTime = DateTime.Now - IntervalLine;

        }

        public Action Execute()
        {
            return new Action(delegate ()
            {



            });

        }

    }

}
