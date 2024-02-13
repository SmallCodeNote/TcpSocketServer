using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentScheduler;
using System.Diagnostics;

namespace tcpClient
{
    public class FluentSchedulerRegistry : Registry
    {
        public TcpSocketClient tcp;
        public List<string> ScheduleList;
        public string DataBaseFilePath;

        public List<FluentSchedulerJob> ScheduleJobList;

        public string[] ScheduleUnitList = new string[] { "EveryDays", "EveryHours", "EverySeconds" };


        public FluentSchedulerRegistry(TcpSocketClient tcp, string[] Lines)
        {
            ScheduleList = new List<string>();
            this.tcp = tcp;
            ScheduleJobList = new List<FluentSchedulerJob>();

            foreach (string Line in Lines)
            {
                FluentSchedulerJobParam param = new FluentSchedulerJobParam(tcp, Line);

                if (param.ScheduleUnit == "EveryDays")
                {
                    try
                    {
                        string[] atinfo = param.ScheduleUnitParam.Split(',');
                        foreach (string t in atinfo)
                        {
                            int[] hm = Array.ConvertAll(t.Split(':'), s => int.Parse(s));
                            int h = hm[0];
                            int m = hm[1];

                            FluentSchedulerJob job = new FluentSchedulerJob(param);
                            Schedule(job.Execute()).ToRunEvery(1).Days().At(h, m);
                            ScheduleList.Add("EveryDays at " + t);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " " + ex.ToString());

                        ScheduleList.Add("ERROR: " + Line);
                    }

                }
                else if (param.ScheduleUnit == "EveryHours")
                {
                    try
                    {
                        int[] atinfo = Array.ConvertAll(param.ScheduleUnitParam.Split(','), s => int.Parse(s));
                        foreach (int m in atinfo)
                        {
                            FluentSchedulerJob job = new FluentSchedulerJob(param);
                            Schedule(job.Execute()).ToRunEvery(1).Hours().At(m);
                            ScheduleList.Add("EveryHours at " + m.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " " + ex.ToString());

                        ScheduleList.Add("ERROR: " + Line);
                    }

                }
                else if (param.ScheduleUnit == "EverySeconds")
                {
                    try
                    {
                        int[] atinfo = Array.ConvertAll(param.ScheduleUnitParam.Split(','), s => int.Parse(s));
                        foreach (int s in atinfo)
                        {
                            FluentSchedulerJob job = new FluentSchedulerJob(param);
                            Schedule(job.Execute()).ToRunEvery(s).Seconds();
                            ScheduleList.Add("EverySeconds at " + s.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " " + ex.ToString());

                        ScheduleList.Add("ERROR: " + Line);
                    }

                }

            }

        }
    }

    public class FluentSchedulerJobParam
    {
        public TcpSocketClient tcp;

        public string Address = "";
        public int PortNumber = 1024;

        public string ScheduleUnit = "";
        public string ScheduleUnitParam = "";
        public string ClientName = "";
        public string Status = "";
        public string Message = "";
        public string Parameter = "";
        public bool NeedCheck = false;

        public FluentSchedulerJobParam(TcpSocketClient tcp, string address, int portNumber, string scheduleUnit, string scheduleUnitParam, string clientName, string status, string message, string parameter, bool needCheck)
        {
            this.tcp = tcp;

            this.Address = address;
            this.PortNumber = portNumber;
            this.ScheduleUnit = scheduleUnit;
            this.ScheduleUnitParam = scheduleUnitParam;
            this.ClientName = clientName;
            this.Status = status;
            this.Message = message;
            this.Parameter = parameter;
            this.NeedCheck = needCheck;

        }

        public FluentSchedulerJobParam(TcpSocketClient tcp, string Line)
        {

            string[] cols = Line.Split('\t');

            this.tcp = tcp;
            int i = 0;

            this.Address = cols[i]; i++;
            this.PortNumber = int.Parse(cols[i]); i++;
            this.ScheduleUnit = cols[i]; i++;
            this.ScheduleUnitParam = cols[i]; i++;
            this.ClientName = cols[i]; i++;
            this.Status = cols[i]; i++;
            this.Message = cols[i]; i++;
            this.Parameter = cols[i]; i++;
            this.NeedCheck = bool.Parse(cols[i]);

        }


    }


    public class FluentSchedulerJob
    {
        public FluentSchedulerJobParam param;

        private string _Responce = "";
        public string Responce { get { return _Responce; } }

        public FluentSchedulerJob(FluentSchedulerJobParam param)
        {
            this.param = param;
        }

        public FluentSchedulerJob(TcpSocketClient tcp, string address, int portNumber, string scheduleUnit, string clientName, string status, string message, string parameter, bool needCheck)
        {
            param.tcp = tcp;

            param.Address = address;
            param.PortNumber = portNumber;
            param.ScheduleUnit = scheduleUnit;
            param.ClientName = clientName;
            param.Status = status;
            param.Message = message;
            param.Parameter = parameter;
            param.NeedCheck = needCheck;

        }

        public Action Execute()
        {
            return new Action(delegate ()
            {
                string sendMessage = param.ClientName + "\t" + param.Status + "\t" + param.Message + "\t"
                + param.Parameter + "\t" + param.NeedCheck.ToString();

                _Responce = param.tcp.StartClient(param.Address, param.PortNumber, sendMessage).Result;

            });

        }



    }
}
