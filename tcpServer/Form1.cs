using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace tcpserver
{
    public partial class Form1 : Form
    {
        TcpSocketServer tcp = new TcpSocketServer();

        public Form1()
        {
            InitializeComponent();
        }

        async private void button_Start_Click(object sender, EventArgs e)
        {
            if (button_Start.Text == "Start")
            {
                if (!await tcp.StartListening(int.Parse(textBox_portNumber.Text)))
                {
                    button_Start.Text = "Stop";
                }
            }
            else {

                button_Start.Text = "Start";

            }

        }

    }
}
