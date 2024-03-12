﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;
using WinFormStringCnvClass;

using tcpserver;
using tcpClient;

namespace tcpClient_HTTPcheck
{
    public partial class Form1 : Form
    {
        TcpSocketServer tcp_srv;
        int portNumber_srv;
        DateTime LastCheckTime;

        TcpSocketClient tcp_clt;
        int portNumber_clt;

        private bool isCtrlPressed = false;


        string thisExeDirPath;
        public Form1()
        {
            InitializeComponent();
            thisExeDirPath = Path.GetDirectoryName(Application.ExecutablePath);

            tcp_srv = new TcpSocketServer();
            tcp_clt = new TcpSocketClient();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TEXT|*.txt";
            if (false && ofd.ShowDialog() == DialogResult.OK)
            {
                WinFormStringCnv.setControlFromString(this, File.ReadAllText(ofd.FileName));
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                if (File.Exists(paramFilename))
                {
                    WinFormStringCnv.setControlFromString(this, File.ReadAllText(paramFilename));
                }
            }

            updateClientListView();
            timer_WebAPIcheck.Start();

            if (!await tcp_srv.StartListening(portNumber_srv, "UTF8"))
            {
                toolStripStatusLabel1.Text = "TCP Listening Start Error";
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string FormContents = WinFormStringCnv.ToString(this);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TEXT|*.txt";

            if (false && sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, FormContents);
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                File.WriteAllText(paramFilename, FormContents);
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                isCtrlPressed = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                isCtrlPressed = false;
            }
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            tabControl_Main.Height = this.Height - 60;
        }

        private void updateClientListView()
        {
            string[] Lines = textBox_ClientList.Text.Replace("\r\n", "\n").Trim('\n').Split('\n');

            int panelTop = 0;

            panel_ClietListView_Form.Controls.Clear();
            foreach (var Line in Lines)
            {
                ClientListView clientListView = new ClientListView(Line, tcp_clt, portNumber_clt);
                clientListView.Top = panelTop;
                panel_ClietListView_Form.Controls.Add(clientListView);

                panelTop += clientListView.Height;

            }
            panel_ClietListView_Form.Height = panelTop;
        }

        private void label_Key_Click(object sender, EventArgs e)
        {
            Label src = (Label)sender;
            Clipboard.SetText(src.Text);
        }

        private void tabPage_ClientListView_Enter(object sender, EventArgs e)
        {
            //updateClientListView();
        }

        private void tabControl_ClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_ClientList.SelectedTab == tabPage_ClientListView)
            {
                updateClientListView();
            }
        }

        private void textBox_HTTPPortNumber_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox_HTTPPortNumber.Text, out portNumber_srv);
        }

        private void textBox_LockEventPortNumber_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox_LockEventPortNumber.Text, out portNumber_clt);
        }

        private void timer_WebAPIcheck_Tick(object sender, EventArgs e)
        {
            timer_WebAPIcheck.Stop();
            toolStripStatusLabel2.Text = DateTime.Now.ToString("HH:mm:ss") + " " + tcp_srv.ReceivedSocketQueue.Count.ToString();

            //============
            // New data check from Queue
            //============
            if ((tcp_srv.LastReceiveTime - LastCheckTime).TotalSeconds > 0 && tcp_srv.ReceivedSocketQueue.Count > 0)
            {
                List<string> queueList = new List<string>();

                string receivedSocketMessage = "";

                //============
                // ReadQueue and Entry dataBase file
                //============
                while (tcp_srv.ReceivedSocketQueue.TryDequeue(out receivedSocketMessage))
                {
                    string[] lines = receivedSocketMessage.Replace("\r\n", "\n").Trim('\n').Split('\n');
                    string[] cols = lines[0].Split('\t');

                    if (cols.Length > 1)
                    {
                        string getCom = lines[0].Split('\t')[1];
                        //queueList.Add(receivedSocketMessage);
                        string[] colsCom = getCom.Split(' ');
                        if (colsCom.Length > 1 && colsCom[1].IndexOf("/api/Reset?") == 0)
                        {
                            ResetAction(colsCom);
                        }
                        else if (colsCom.Length > 1 && colsCom[1].IndexOf("/api/LockIfErrorFrom") == 0)
                        {
                            LockIfErrorAction(colsCom);
                        }
                    }
                }
            }

            timer_WebAPIcheck.Start();
        }

        private void ResetAction(string[] colsCom)
        {
            if (textBox_Queue.Text.Length > 0) textBox_Queue.Text += "\r\n";
            string urlDec = HttpUtility.UrlDecode(colsCom[1]);
            textBox_Queue.Text += urlDec;

            string[] options = colsCom[1].Replace("/api/Reset?", "").Split('&');

            foreach (var item in options)
            {
                if (item == "all")
                {
                    foreach (var ctrl in panel_ClietListView_Form.Controls)
                    {
                        if (ctrl is ClientListView)
                        {
                            ((ClientListView)ctrl).unLock();
                        }
                    }
                }
                else if (item.IndexOf("target=") == 0)
                {
                    foreach (var ctrl in panel_ClietListView_Form.Controls)
                    {
                        if (ctrl is ClientListView
                            && ((ClientListView)ctrl).ClientName.IndexOf(item.Replace("target=", "")) >= 0)
                        {
                            ((ClientListView)ctrl).unLock();
                        }
                    }
                }
            }
        }

        private void LockIfErrorAction(string[] colsCom)
        {
            if (textBox_Queue.Text.Length > 0) textBox_Queue.Text += "\r\n";
            string urlDec = HttpUtility.UrlDecode(colsCom[1]);
            textBox_Queue.Text += urlDec;

            string[] options = colsCom[1].Replace("/api/LockIfErrorFrom", "").Split('&');

            string SignalSourceName = options[0].Split('?')[0];
            options[0] = options[0].Replace(SignalSourceName + "?", "");
            foreach (var item in options)
            {
                if (item == "all")
                {
                    foreach (var ctrl in panel_ClietListView_Form.Controls)
                    {
                        if (ctrl is ClientListView
                            && ((ClientListView)ctrl).Error)
                        {
                            ((ClientListView)ctrl).unLock();
                        }
                    }
                }
                else if (item.IndexOf("target=") == 0)
                {
                    foreach (var ctrl in panel_ClietListView_Form.Controls)
                    {
                        if (ctrl is ClientListView
                            && ((ClientListView)ctrl).ClientName.IndexOf(item.Replace("target=", "")) >= 0
                            && ((ClientListView)ctrl).Error)
                        {
                            ((ClientListView)ctrl).Lock(SignalSourceName);
                        }
                    }
                }
            }
        }
    }
}
