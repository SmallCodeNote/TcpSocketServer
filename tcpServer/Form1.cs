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

using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

using LiteDB;

using WinFormStringCnvClass;

namespace tcpserver
{
    public partial class Form1 : Form
    {
        TcpSocketServer tcp;
        DateTime LastCheckTime;
        string thisExeDirPath;
        string datebasePath;
        int portNumber;

        public Form1()
        {
            InitializeComponent();

            tcp = new TcpSocketServer();

            thisExeDirPath = Path.GetDirectoryName(Application.ExecutablePath);
            datebasePath = Path.Combine(thisExeDirPath, "lite.db");
            LastCheckTime = DateTime.Now;
            portNumber = -1;

            this.panel_StatusListFrame.MouseWheel += new MouseEventHandler(this.panel_StatusListFrame_MouseWheel);
            this.tabPage_Status.MouseWheel += new MouseEventHandler(this.panel_StatusListFrame_MouseWheel);

        }

        //=====================
        #region topForm Event
        //=====================
        async private void Form1_Load(object sender, EventArgs e)
        {
            string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");

            if (File.Exists(paramFilename))
            {
                WinFormStringCnv.setControlFromString(this, File.ReadAllText(paramFilename));
            }

            try
            {
                portNumber = int.Parse(textBox_portNumber.Text);

                button_Start.Text = "Stop";
                timer_UpdateList.Start();


                if (!await tcp.StartListening(portNumber))
                {
                    toolStripStatusLabel1.Text = "TCP Listening Start Error";
                    button_Start.Text = "Start";
                    return;
                }



            }
            catch { }
        }

        async private void button_Start_Click(object sender, EventArgs e)
        {
            if (button_Start.Text == "Start")
            {
                button_Start.Text = "Stop";
                timer_UpdateList.Start();

                if (!await tcp.StartListening(portNumber))
                {
                    toolStripStatusLabel1.Text = "TCP Listening Start Error";
                    return;
                }

            }
            else
            {
                tcp.StopListening();
                button_Start.Text = "Start";

            }

        }

        private void timer_UpdateList_Tick(object sender, EventArgs e)
        {
            timer_UpdateList.Stop();

            if ((tcp.LastReceiveTime - LastCheckTime).TotalSeconds > 0 && tcp.messageQueue.Count > 0)
            {
                string message = "";

                while (tcp.messageQueue.TryDequeue(out message))
                {
                    string[] cols = message.Split('\t');

                    if (cols.Length >= 4)
                    {
                        try
                        {
                            DateTime connectTime = DateTime.Parse(cols[0]);
                            string key = cols[1] + "_" + cols[0];
                            SocketMessage socketMessage = new SocketMessage(connectTime, cols[1], cols[2], cols[3]);

                            using (LiteDatabase litedb = new LiteDatabase(textBox_DataBaseFilePath.Text))
                            {
                                ILiteCollection<SocketMessage> col = litedb.GetCollection<SocketMessage>("table_Message");

                                col.Insert(key, socketMessage);
                            }

                        }
                        catch
                        {

                        }

                    }

                }

                LastCheckTime = DateTime.Now;

            }


            if (tabControl1.SelectedTab == tabPage_Status)
            {
                updateStatusList();

            }


            if (button_Start.Text != "Start")
            {
                toolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                timer_UpdateList.Start();
            }
            else
            {
                toolStripStatusLabel1.Text = "Stop TCP Listener.";
            }

        }

        #endregion
        //=====================


        //=====================
        #region tabPage_Status Event
        //=====================
        private void panel_StatusList_SizeChanged(object sender, EventArgs e)
        {
            vScrollBar_StatusList.Enabled = panel_StatusList.Height > panel_StatusListFrame.Height;

            vScrollBar_StatusList.Maximum = panel_StatusList.Height;
            vScrollBar_StatusList_valueMax = vScrollBar_StatusList.Maximum - vScrollBar_StatusList.LargeChange;


            panel_StatusListFrame.Height = 500;
            vScrollBar_StatusList.LargeChange = panel_StatusListFrame.Height;
            vScrollBar_StatusList.LargeChange = 500; //panel_StatusListFrame.Height;

        }

        private void vScrollBar_StatusList_Scroll(object sender, ScrollEventArgs e)
        {
            panel_StatusList.Top = -vScrollBar_StatusList.Value;
        }

        private void vScrollBar_StatusList_ValueChanged(object sender, EventArgs e)
        {
            panel_StatusList.Top = -vScrollBar_StatusList.Value;
        }

        int vScrollBar_StatusList_valueMin = 0;
        int vScrollBar_StatusList_valueMax = 0;

        private void panel_StatusListFrame_MouseWheel(object sender, MouseEventArgs e)
        {
            //マウスのホイールが動いた場合にイベントが発生する

            int targetValue = vScrollBar_StatusList.Value - e.Delta ;
            targetValue = targetValue >= vScrollBar_StatusList_valueMin ? targetValue : vScrollBar_StatusList_valueMin;
            targetValue = targetValue <= vScrollBar_StatusList_valueMax ? targetValue: vScrollBar_StatusList_valueMax;

            vScrollBar_StatusList.Value = targetValue;
        }


        #endregion
        //=====================



        //=====================
        #region tabPage_Setting Event
        //=====================
        private void button_getDataBaseFilePath_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "LiteDB File|*.db";
            if (sfd.ShowDialog() != DialogResult.OK) return;

            textBox_DataBaseFilePath.Text = sfd.FileName;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string FormContents = WinFormStringCnv.ToString(this);
            string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
            File.WriteAllText(paramFilename, FormContents);
        }


        private void tabPage_Status_Enter(object sender, EventArgs e)
        {

            int ClientCount = dataGridView1.Rows.Count - 1;
            panel_StatusList.Height = ClientCount * 100;

            if (panel_StatusList.Controls.Count != ClientCount)
            {

                clearControlCollection(panel_StatusList.Controls);

                int TopBuff = 0;
                for (int i = 0; i < ClientCount; i++)
                {
                    panel_StatusList.Controls.Add(new MessageItemView());
                    panel_StatusList.Controls[i].Top = TopBuff;
                    ((MessageItemView)panel_StatusList.Controls[i]).groupBox_GroupName.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();

                    TopBuff += panel_StatusList.Controls[i].Height;

                }

                updateStatusList();

            }


        }


        #endregion
        //=====================

        private void clearControlCollection(System.Windows.Forms.Control.ControlCollection cc)
        {
            for (int i = 0; i < cc.Count; i++)
            {
                cc[i].Dispose();

            }
            cc.Clear();

        }


        private void updateStatusList()
        {
            using (LiteDatabase litedb = new LiteDatabase(textBox_DataBaseFilePath.Text))
            {
                var col = litedb.GetCollection<SocketMessage>("table_Message");

                foreach (MessageItemView messageItemView in panel_StatusList.Controls)
                {
                    string groupName = messageItemView.groupBox_GroupName.Text;
                    try
                    {
                        SocketMessage socketMessage = col.Query().Where(x => x.groupName == groupName).OrderBy(x => x.connectTime, 0).First();
                        messageItemView.setItems(socketMessage);

                    }
                    catch { }

                }

            }

        }

    }
}
