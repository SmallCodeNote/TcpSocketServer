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

using LiteDB;


namespace tcpserver
{
    public partial class Form1 : Form
    {
        TcpSocketServer tcp = new TcpSocketServer();
        DateTime LastCheckTime;

        public Form1()
        {
            InitializeComponent();

            LastCheckTime = DateTime.Now;
        }



        //=====================
        #region topForm Event
        //=====================
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        async private void button_Start_Click(object sender, EventArgs e)
        {
            if (button_Start.Text == "Start")
            {
                if (!await tcp.StartListening(int.Parse(textBox_portNumber.Text)))
                {
                    button_Start.Text = "Stop";
                }

                timer_UpdateList.Start();

            }
            else
            {
                button_Start.Text = "Start";

                timer_UpdateList.Stop() ;

            }

        }

        private void timer_UpdateList_Tick(object sender, EventArgs e)
        {
            timer_UpdateList.Stop();

            if((LastCheckTime-tcp.LastReceiveTime).TotalSeconds > 0 && tcp.messageQueue.Count>0)
            {
                foreach(var message in tcp.messageQueue)
                {



                }

                LastCheckTime = DateTime.Now;
            }


            timer_UpdateList.Start();
        }

        #endregion
        //=====================


        //=====================
        #region tabPage_Status Event
        //=====================
        private void panel_StatusList_SizeChanged(object sender, EventArgs e)
        {
            vScrollBar_StatusList.Enabled = panel_StatusList.Height > panel_StatusListFrame.Height;
            vScrollBar_StatusList.Maximum = panel_StatusList.Height - panel_StatusListFrame.Height;
        }

        private void vScrollBar_StatusList_Scroll(object sender, ScrollEventArgs e)
        {
            panel_StatusList.Top = vScrollBar_StatusList.Value;
        }


        #endregion
        //=====================





        //=====================
        #region tabPage_Setting Event
        //=====================
        private void button_getDataBaseFilePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() != DialogResult.OK) return;

            textBox_DataBaseFilePath.Text = sfd.FileName;

        }

       
        #endregion
        //=====================


    }
}
