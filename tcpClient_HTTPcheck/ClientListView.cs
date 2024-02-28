using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcpClient_HTTPcheck
{
    public partial class ClientListView : UserControl
    {
        public ClientListView(string Line)
        {
            InitializeComponent();
            LockReleaseTime = DateTime.Now;
            setContents(Line);

            timer_TimeLabelUpdate.Start();
        }
        
        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            this.groupBox_ClientListViewTitle.Text = textBox_Name.Text;
        }

        public DateTime LockReleaseTime;
        public DateTime LockTime;

        public string SignalSourceName = "";

        public void setContents(string Line)
        {
            string[] cols = Line.Split('\t');

            if (cols.Length > 2)
            {
                textBox_Address.Text = cols[0];
                textBox_Name.Text = cols[1];
                textBox_LockTime.Text = cols[2];
            }
        }

        public string getContets()
        {
            string address = textBox_Address.Text;
            string name = textBox_Name.Text;
            string lockTime = textBox_LockTime.Text;

            return address + "\t" + name + "\t" + LockTime;
        }

        private void LockClient()
        {
            if (int.TryParse(textBox_LockTime.Text, out int Minutes))
            {
                LockClient(Minutes);
            }
        }

        private void LockClient(int Minutes)
        {
            LockTime = DateTime.Now;
            LockReleaseTime = DateTime.Now + new TimeSpan(0, Minutes, 0);
            LabelUpdate();
        }

        private void timer_TimeLabelUpdate_Tick(object sender, EventArgs e)
        {
            LabelUpdate();
        }

        private void LabelUpdate()
        {
            if ((DateTime.Now - LockReleaseTime).TotalSeconds > 0)
            {
                label_LockedFrom.Text = "- Release -";
                label_LockedTime.Text = "- Release -";
                label_ResetTime.Text = "- Release -";
                button_Lock.Text = "";
                button_Lock.BackColor = Color.YellowGreen;

            }
            else
            {
                label_LockedFrom.Text = SignalSourceName;
                label_LockedTime.Text = LockTime.ToString("yyyy/MM/dd HH:mm:ss");
                label_ResetTime.Text = LockReleaseTime.ToString("yyyy/MM/dd HH:mm:ss");
                label_RemainingTime.Text = getElapsedTimeString(LockReleaseTime - DateTime.Now);

                button_Lock.Text = "";
                button_Lock.BackColor = Color.Red;
            }
        }

        private void button_Lock_Click(object sender, EventArgs e)
        {
            if ((DateTime.Now - LockReleaseTime).TotalSeconds > 0)
            {
                SignalSourceName = "this panel";
                LockClient();
                LabelUpdate();
            }
            else
            {
                LockReleaseTime = DateTime.Now;
                label_LockedFrom.Text = "- Release -";
                label_LockedTime.Text = "- Release -";
                label_ResetTime.Text = "- Release -";
                button_Lock.Text = "";
                button_Lock.BackColor = Color.YellowGreen;
                label_RemainingTime.Text = "...";
            }
            
        }

        private void button_PanelShift_Click(object sender, EventArgs e)
        {
            if (panel_Form.Top == 0)
            {
                panel_Form.Top = -panel_Frame.Height;
                button_PanelShift.Text = ">";
            }
            else
            {
                panel_Form.Top = 0;
                button_PanelShift.Text = "<";
            }
        }

        public string getElapsedTimeString(TimeSpan elapsedTime)
        {
            if (elapsedTime.TotalDays >= 365) { return (elapsedTime.TotalDays / 365.2425).ToString("0") + " year"; }
            if (elapsedTime.TotalDays >= 30) { return (elapsedTime.TotalDays / 30.436875).ToString("0") + " month"; }
            if (elapsedTime.TotalDays >= 7) { return (elapsedTime.TotalDays / 7).ToString("0") + " week"; }
            if (elapsedTime.TotalDays >= 1) { return (elapsedTime.TotalDays / 7).ToString("0") + " day"; }
            if (elapsedTime.TotalHours >= 1) { return (elapsedTime.TotalHours).ToString("0") + " hour"; }
            if (elapsedTime.TotalMinutes >= 1) { return (elapsedTime.TotalMinutes).ToString("0") + " minute"; }
            if (elapsedTime.TotalSeconds >= 1) { return (elapsedTime.TotalSeconds).ToString("0") + " sec."; }
            return "now";
        }
    }
}
