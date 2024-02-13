using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        TcpSocketClient tcp = new TcpSocketClient();

        public Form1()
        {
            InitializeComponent();
            thisExeDirPath = Path.GetDirectoryName(Application.ExecutablePath);

        }

        public void SendMessage()
        {
            string sendMessage = textBox_ClientName.Text + "\t" + comboBox_Status.Text + "\t" + textBox_Message.Text + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "\t" + textBox_Parameter.Text + "\t" + checkBox_NeedCheck.Checked.ToString();

            var responce = tcp.StartClient(textBox_Address.Text, int.Parse(textBox_PortNumber.Text), sendMessage).Result;
            label_Return.Text = responce;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
            if (File.Exists(paramFilename))
            {
                WinFormStringCnv.setControlFromString(this, File.ReadAllText(paramFilename));
            }
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
        

        private void button_SendMessage_Click(object sender, EventArgs e)
        {
            string sendMessage = textBox_ClientName.Text + "\t" + comboBox_Status.Text + "\t" + textBox_Message.Text + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "\t" + textBox_Parameter.Text + "\t" + checkBox_NeedCheck.Checked.ToString();

            var responce = tcp.StartClient(textBox_Address.Text, int.Parse(textBox_PortNumber.Text), sendMessage).Result;
            label_Return.Text = responce;

        }

        private void button_AddSchedule_Click(object sender, EventArgs e)
        {
            SchedulerInitialize();

        }

        private void SchedulerInitialize()
        {
            JobManager.StopAndBlock();

            List<string> Lines = new List<string>();

            string Address = textBox_Address.Text;
            string PortNumber = textBox_PortNumber.Text;
            string ScheduleUnit = comboBox_ScheduleUnit.Text;
            string ScheduleUnitParam = textBox_ScheduleUnitParam.Text;
            string ClientName = textBox_ClientName.Text;
            string Status = comboBox_Status.Text;
            string Message = textBox_Message.Text;
            string Parameter = textBox_Parameter.Text;
            string NeedCheck = checkBox_NeedCheck.Checked.ToString();

            List<string> ColList = new List<string>();
            ColList.Add(Address);
            ColList.Add(PortNumber.ToString());
            ColList.Add(ScheduleUnit);
            ColList.Add(ScheduleUnitParam);
            ColList.Add(ClientName);
            ColList.Add(Status);
            ColList.Add(Message);
            ColList.Add(Parameter);
            ColList.Add(NeedCheck.ToString());

            Lines.Add(String.Join("\t", ColList.ToArray()));

            var job = new FluentSchedulerRegistry(tcp, Lines.ToArray());

            JobManager.Initialize(job);

        }
    }
}
