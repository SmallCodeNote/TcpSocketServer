using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FluentScheduler;

using WinFormStringCnvClass;

namespace tcpClient
{
    public partial class Form1 : Form
    {
        string thisExeDirPath;
        TcpSocketClient tcp;

        public Form1()
        {
            InitializeComponent();
            thisExeDirPath = Path.GetDirectoryName(Application.ExecutablePath);
            tcp = new TcpSocketClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
            if (File.Exists(paramFilename))
            {
                WinFormStringCnv.setControlFromString(this, File.ReadAllText(paramFilename));
            }

            this.panel_StatusListFrame.MouseWheel += new MouseEventHandler(this.panel_StatusListFrame_MouseWheel);
            this.tabPage_Edit.MouseWheel += new MouseEventHandler(this.panel_StatusListFrame_MouseWheel);

            this.panel_StatusListFrame.Controls.Add(this.panel_StatusList);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string FormContents = WinFormStringCnv.ToString(this);
            string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
            File.WriteAllText(paramFilename, FormContents);
        }

        private void button_SchedulerList_Click(object sender, EventArgs e)
        {
            SchedulerInitialize();
        }


        private async void button_SendMessage_Click(object sender, EventArgs e)
        {

            //JobManager.AddJob();
            string sendMessage = textBox_ClientName.Text + "\t" + comboBox_Status.Text + "\t" + textBox_Message.Text + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "\t" + textBox_Parameter.Text + "\t" + comboBox_checkStyle.Text;

            var responce = await tcp.StartClient(textBox_Address.Text, int.Parse(textBox_PortNumber.Text), sendMessage);
            label_Return.Text = responce;

        }

        private void button_AddSchedule_Click(object sender, EventArgs e)
        {
            SchedulerInitialize();

        }
        /*
        public void SendMessage()
        {
            string sendMessage = textBox_ClientName.Text + "\t" + comboBox_Status.Text + "\t" + textBox_Message.Text + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "\t" + textBox_Parameter.Text + "\t" + checkBox_CheckStyle.Checked.ToString();

            var responce = tcp.StartClient(textBox_Address.Text, int.Parse(textBox_PortNumber.Text), sendMessage).Result;
            label_Return.Text = responce;

        }
*/
        private void SchedulerInitialize()
        {
            JobManager.StopAndBlock();

            List<string> Lines = new List<string>();

            string Address = textBox_Address.Text;
            string PortNumber = textBox_PortNumber.Text;

            string JobName = textBox_JobName.Text;
            string ScheduleUnit = comboBox_ScheduleUnit.Text;
            string ScheduleUnitParam = textBox_ScheduleUnitParam.Text;
            string ClientName = textBox_ClientName.Text;
            string Status = comboBox_Status.Text;
            string Message = textBox_Message.Text;
            string Parameter = textBox_Parameter.Text;
            string CheckStyle = comboBox_checkStyle.Text;

            List<string> ColList = new List<string>();
            ColList.Add(Address);
            ColList.Add(PortNumber);

            ColList.Add(JobName);
            ColList.Add(ScheduleUnit);
            ColList.Add(ScheduleUnitParam);
            ColList.Add(ClientName);
            ColList.Add(Status);
            ColList.Add(Message);
            ColList.Add(Parameter);
            ColList.Add(CheckStyle.ToString());

            Lines.Add(String.Join("\t", ColList.ToArray()));

            var job = new FluentSchedulerRegistry(tcp, Lines.ToArray());

            JobManager.Initialize(job);

        }

        public void tabPage_View_Enter(object sender = null, EventArgs e = null)
        {
            if(sender!=null) timer_ClientViewUpdate.Start();

            var allSchedules = JobManager.AllSchedules;

            List<string> scheduleList = new List<string>();

            foreach (var schedule in allSchedules)
            {
                List<string> Cols = new List<string>();

                Cols.Add(schedule.Name);
                Cols.Add(schedule.NextRun.Second.ToString());
                Cols.Add(schedule.ToString());

                scheduleList.Add(string.Join("\t", Cols.ToArray()));

            }

            updateStatusList();

        }


        //=====================
        #region tabPage_Status Event
        //=====================
        private void panel_StatusList_SizeChanged(object sender, EventArgs e)
        {
            vScrollBar_StatusList.Enabled = panel_StatusList.Height > panel_StatusListFrame.Height;

            vScrollBar_StatusList.Maximum = panel_StatusList.Height;
            vScrollBar_StatusList_valueMax = vScrollBar_StatusList.Maximum - vScrollBar_StatusList.LargeChange;

            vScrollBar_StatusList.LargeChange = panel_StatusListFrame.Height;


        }

        private void vScrollBar_StatusList_Scroll(object sender, ScrollEventArgs e)
        {
            panel_StatusList.Top = -vScrollBar_StatusList.Value;
            Debug.WriteLine(panel_StatusList.Top.ToString());
            panel_StatusListFrame.Refresh();
        }

        private void vScrollBar_StatusList_ValueChanged(object sender, EventArgs e)
        {
            panel_StatusList.Top = -vScrollBar_StatusList.Value;
            Debug.WriteLine(panel_StatusList.Top.ToString());
            panel_StatusListFrame.Refresh();
        }

        int vScrollBar_StatusList_valueMin = 0;
        int vScrollBar_StatusList_valueMax = 0;

        private void panel_StatusListFrame_MouseWheel(object sender, MouseEventArgs e)
        {
            //マウスのホイールが動いた場合にイベントが発生する

            int targetValue = vScrollBar_StatusList.Value - e.Delta;
            targetValue = targetValue >= vScrollBar_StatusList_valueMin ? targetValue : vScrollBar_StatusList_valueMin;
            targetValue = targetValue <= vScrollBar_StatusList_valueMax ? targetValue : vScrollBar_StatusList_valueMax;

            vScrollBar_StatusList.Value = targetValue;
        }


        #endregion
        //=====================


        List<JobItemView> jobItemViews = new List<JobItemView>();

        private void updateStatusList()
        {
            try
            {
                panel_StatusList.Controls.Clear();

                //var allSchedules = JobManager.AllSchedules;
                List<Schedule> sortedSchedules = JobManager.AllSchedules.OrderBy(schedule => schedule.NextRun).ToList();

                int topLocation = 0;

                foreach (var schedule in sortedSchedules)
                {

                    List<string> Cols = new List<string>();

                    var jobItemView = new JobItemView();
                    jobItemView.Top = topLocation;
                    jobItemView.Left = 0;

                    jobItemView.setLabel(schedule, this);

                    panel_StatusList.Controls.Add(jobItemView);

                    topLocation += jobItemView.Height;

                }

                panel_StatusList.Height = topLocation;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " EX:" + ex.ToString());
            }


        }

        int JobManager_AllSchedules_Count_Buff = 0;
        private void timer_ClientViewUpdate_Tick(object sender, EventArgs e)
        {
            int jobCount = JobManager.AllSchedules.Count();
            if (JobManager_AllSchedules_Count_Buff != jobCount)
            {
                JobManager_AllSchedules_Count_Buff = jobCount;
                tabPage_View_Enter();
            }
        }

        private void tabPage_View_Leave(object sender, EventArgs e)
        {
            timer_ClientViewUpdate.Stop();
        }
    }
}
