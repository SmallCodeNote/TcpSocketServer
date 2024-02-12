using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

using FluentScheduler;
/*
Original Code :
 https://marunaka-blog.com/cshap-tcpclient-create/2314/
 code adapt .NetFramework4.8
*/

namespace tcpClient
{
    class TcpSocketClient
    {
        public async Task<string> StartClient(string ipaddress, int port, string request)
        {
            var writeBuffer = new byte[1024];
            var readBuffer = new byte[1024];
            var response = "";

            try
            {
                using (var tcpclient = new TcpClient())
                {
                    tcpclient.SendTimeout = 1000;
                    tcpclient.ReceiveTimeout = 1000;

                    await tcpclient.ConnectAsync(ipaddress, port);
                    Debug.WriteLine("Server connected.");
                    using (var stream = tcpclient.GetStream())
                    {
                        writeBuffer = System.Text.Encoding.ASCII.GetBytes(request);
                        await stream.WriteAsync(writeBuffer, 0, writeBuffer.Length);
                        Debug.WriteLine($"Send [{request}] to server.");

                        var length = await stream.ReadAsync(readBuffer, 0, readBuffer.Length);
                        response = System.Text.Encoding.ASCII.GetString(readBuffer, 0, length);
                        Debug.WriteLine($"Recieved [{response}] from server.");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return response;
        }



    }

    public class FluentSchedulerRegistry : Registry
    {

        public List<string> ScheduleList;
        public string DataBaseFilePath;


        private int idxName = 0;
        //private int idxCheck = 1;
        private int idxUnit = 1;
        private int idxAt = 2;

        public FluentSchedulerRegistry(string[] Lines)
        {

            foreach (string Line in Lines)
            {
                string[] cols = Line.Split('\t');

                string StatusName = cols[idxName];

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

                            FluentSchedulerJob job = new FluentSchedulerJob();
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
                else if (cols[idxUnit] == "EveryHours")
                {
                    try
                    {
                        int[] atinfo = Array.ConvertAll(cols[idxAt].Split(','), s => int.Parse(s));
                        foreach (int m in atinfo)
                        {
                            FluentSchedulerJob job = new FluentSchedulerJob();
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
                else if (cols[idxUnit] == "EverySeconds")
                {
                    try
                    {
                        int[] atinfo = Array.ConvertAll(cols[idxAt].Split(','), s => int.Parse(s));
                        foreach (int s in atinfo)
                        {
                            FluentSchedulerJob job = new FluentSchedulerJob();
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

    public class FluentSchedulerJob
    {

        public FluentSchedulerJob()
        {


        }

        public Action Execute()
        {
            return new Action(delegate ()
            {

            });

        }



    }

}
