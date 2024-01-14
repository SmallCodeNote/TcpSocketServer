using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LiteDB;

namespace tcpserver
{
    public partial class MessageItemView : UserControl
    {
        private SocketMessage _message;
        private string _dbPath;
        public MessageItemView()
        {
            InitializeComponent();

            this.label_Status.Text = "";
            this.label_LastConnectTime.Text = "";
            this.label_ElapsedTime.Text = "";
            this.label_LastMessage.Text = "";
        }

        private void button_Log_Click(object sender, EventArgs e)
        {

        }

        public void setItems(SocketMessage message, string dbPath)
        {
            _message = message;
            _dbPath = dbPath;

            this.groupBox_GroupName.Text = message.groupName;
            this.label_Status.Text = message.status.ToString();
            this.label_LastConnectTime.Text = message.connectTime.ToString("yyyy/MM/dd HH:mm:ss");
            this.label_ElapsedTime.Text = getElapsedTimeString(DateTime.Now - message.connectTime);
            this.label_LastMessage.Text = message.message;
            this.checkBox_check.Checked = message.check;
            this.checkBox_check.Enabled = true;

        }

        public string getElapsedTimeString(TimeSpan elapsedTime)
        {
            if (elapsedTime.TotalDays >= 365) { return (elapsedTime.TotalDays / 365.2425).ToString("0") + " year"; }
            if (elapsedTime.TotalDays >= 30) { return (elapsedTime.TotalDays / 30.436875).ToString("0") + " month"; }
            if (elapsedTime.TotalDays >= 7) { return (elapsedTime.TotalDays / 7).ToString("0") + " week"; }
            if (elapsedTime.TotalDays >= 1) { return (elapsedTime.TotalDays / 7).ToString("0") + " day"; }
            if (elapsedTime.TotalHours >= 1) { return (elapsedTime.TotalHours).ToString("0") + " hour"; }
            if (elapsedTime.TotalMinutes >= 1) { return (elapsedTime.TotalMinutes).ToString("0") + " minute"; }
            return "now";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _message.check = checkBox_check.Checked;

            using (LiteDatabase litedb = new LiteDatabase(_dbPath))
            {
                var col = litedb.GetCollection<SocketMessage>("table_Message");

                try
                {
                    var record = col.FindOne(x => x.connectTime == this._message.connectTime && x.groupName == this._message.groupName && x.status == this._message.status);
                    string key = this._message.groupName + "_" + this._message.connectTime.ToString("yyyy/MM/dd HH:mm:ss.fff");
                    record.check = checkBox_check.Checked;
                    col.Update(key,record);
                }
                catch
                {

                }

            }
        }
    }
}
