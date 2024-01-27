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

        async private void button_SendMessage_Click(object sender, EventArgs e)
        {
            string sendMessage = textBox_ClientName.Text + "\t" + comboBox_Status.Text + "\t" + textBox_Message.Text + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "\t" + textBox_Parameter.Text + "\t" + checkBox_NeedCheck.Checked.ToString();

            var responce = await tcp.StartClient(textBox_Address.Text, int.Parse(textBox_PortNumber.Text), sendMessage);
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
    }
}
