using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcpserver
{
    public partial class MessageItemView : UserControl
    {
        public MessageItemView()
        {
            InitializeComponent();
        }

        private void button_Log_Click(object sender, EventArgs e)
        {

        }

        public void setItems(SocketMessage message)
        {
            this.groupBox_GroupName.Text = message.groupName;
            this.label_FlagStatus.Text = message.messageStatus.ToString();
            this.label_LastConnectTime.Text = message.connectTime.ToString("yyyy/MM/dd HH:mm:ss");
            this.label_ElapsedTime.Text = getElapsedTimeString(DateTime.Now - message.connectTime);
            this.label_LastMessage.Text = message.message;
        }

        public string getElapsedTimeString(TimeSpan elapsedTime)
        {
            if(elapsedTime.TotalDays >= 365) { return (elapsedTime.TotalDays / 365.2425).ToString("0") + "year"; }
            if (elapsedTime.TotalDays >= 30) { return (elapsedTime.TotalDays / 30.436875).ToString("0") + "month"; }
            if (elapsedTime.TotalDays >= 7) { return (elapsedTime.TotalDays / 7).ToString() + "week"; }
            if (elapsedTime.TotalDays >= 1) { return (elapsedTime.TotalDays / 7).ToString() + "day"; }
            if (elapsedTime.TotalHours >= 1) { return (elapsedTime.TotalHours).ToString() + "hour"; }
            if (elapsedTime.TotalMinutes >= 1) { return (elapsedTime.TotalMinutes).ToString() + "minute"; }
            return "now"; 
        }

    }
}
