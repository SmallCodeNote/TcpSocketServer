using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcpClient
{
    public partial class Form1 : Form
    {
        TcpSocketClient tcp = new TcpSocketClient();

        public Form1()
        {
            InitializeComponent();
        }

        async private void button_SendMessage_Click(object sender, EventArgs e)
        {
            var responce = await tcp.StartClient(textBox_Address.Text, int.Parse(textBox_PortNumber.Text), textBox_Message.Text);
            label_Return.Text = responce;
        }
    }
}
