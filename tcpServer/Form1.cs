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
        NoticeTransmitter noticeTransmitter;
        List<ClientData> clientList;
        AddressNote addressNote;


        DateTime LastCheckTime;
        string thisExeDirPath;
        string datebasePath;
        int portNumber;

        ConnectionString _LiteDBconnectionString;

        public Form1()
        {
            InitializeComponent();

            tcp = new TcpSocketServer();

            noticeTransmitter = new NoticeTransmitter();
            noticeTransmitter.StartNoticeCheck();

            thisExeDirPath = Path.GetDirectoryName(Application.ExecutablePath);
            datebasePath = Path.Combine(thisExeDirPath, "lite.db");
            LastCheckTime = DateTime.Now;
            portNumber = -1;

            this.panel_StatusListFrame.MouseWheel += new MouseEventHandler(this.panel_StatusListFrame_MouseWheel);
            this.tabPage_Status.MouseWheel += new MouseEventHandler(this.panel_StatusListFrame_MouseWheel);

            _LiteDBconnectionString = new ConnectionString();
            _LiteDBconnectionString.Connection = ConnectionType.Shared;

            clientList = new List<ClientData>();

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
            catch
            {

            }
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

            if ((tcp.LastReceiveTime - LastCheckTime).TotalSeconds > 0 && tcp.ReceivedSocketQueue.Count > 0)
            {
                string message = "";

                while (tcp.ReceivedSocketQueue.TryDequeue(out message))
                {
                    string[] cols = message.Split('\t');

                    if (cols.Length >= 4)
                    {
                        //try
                        {
                            DateTime connectTime = DateTime.Parse(cols[0]);
                            SocketMessage socketMessage = new SocketMessage(connectTime, cols[1], cols[2], cols[3]);
                            string key = socketMessage.Key();

                            foreach (DataGridViewRow Row in dataGridView_StatusList.Rows)
                            {
                                if (Row.Cells.Count >= 3 && Row.Cells[0].Value != null && Row.Cells[0].Value.ToString() == cols[2])
                                {
                                    socketMessage.needCheck = bool.Parse(Row.Cells[2].Value.ToString());

                                }
                            }

                            _LiteDBconnectionString.Filename = textBox_DataBaseFilePath.Text;
                            using (LiteDatabase litedb = new LiteDatabase(_LiteDBconnectionString.Filename))
                            {
                                ILiteCollection<SocketMessage> col = litedb.GetCollection<SocketMessage>("table_Message");
                                col.Insert(key, socketMessage);
                            }

                        }
                        //catch
                        {

                        }

                    }

                }

                //NoticeCheck

                List<string> groupNameList = new List<string>();


                using (LiteDatabase litedb = new LiteDatabase(_LiteDBconnectionString.Filename))
                {
                    ILiteCollection<SocketMessage> col = litedb.GetCollection<SocketMessage>("table_Message");

                    foreach (var targetName in groupNameList)
                    {
                        var latestNoticeRecord = col.Query().Where(x => x.status == "Notice" && x.groupName == targetName).OrderByDescending(x => x.connectTime).FirstOrDefault();
                        var latestWarningRecord = col.Query().Where(x => x.status == "Warning" && x.check == false && x.groupName == targetName).OrderByDescending(x => x.connectTime).FirstOrDefault();

                        if (latestWarningRecord != null && latestNoticeRecord != null && latestNoticeRecord.connectTime > latestWarningRecord.connectTime)
                        {

                            List<NoticeMessage> notices = new List<NoticeMessage>();



                            foreach (var add in notices)
                            {
                                noticeTransmitter.AddNotice(add);
                            }

                        }


                    }

                }




                LastCheckTime = DateTime.Now;

            }


            if (tabControl_Top.SelectedTab == tabPage_Status)
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

            int targetValue = vScrollBar_StatusList.Value - e.Delta;
            targetValue = targetValue >= vScrollBar_StatusList_valueMin ? targetValue : vScrollBar_StatusList_valueMin;
            targetValue = targetValue <= vScrollBar_StatusList_valueMax ? targetValue : vScrollBar_StatusList_valueMax;

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

            int ClientCount = dataGridView_ClientList.Rows.Count - 1;
            panel_StatusList.Height = ClientCount * 100;

            if (panel_StatusList.Controls.Count != ClientCount)
            {

                clearControlCollection(panel_StatusList.Controls);

                int TopBuff = 0;
                for (int i = 0; i < ClientCount; i++)
                {
                    panel_StatusList.Controls.Add(new MessageItemView(noticeTransmitter));
                    panel_StatusList.Controls[i].Top = TopBuff;
                    ((MessageItemView)panel_StatusList.Controls[i]).groupBox_GroupName.Text = dataGridView_ClientList.Rows[i].Cells[0].Value.ToString();

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
            try
            {
                _LiteDBconnectionString.Filename = textBox_DataBaseFilePath.Text;

                using (LiteDatabase litedb = new LiteDatabase(_LiteDBconnectionString.Filename))
                {
                    var col = litedb.GetCollection<SocketMessage>("table_Message");

                    foreach (MessageItemView messageItemView in panel_StatusList.Controls)
                    {
                        string groupName = messageItemView.groupBox_GroupName.Text;

                        try
                        {
                            ILiteQueryable<SocketMessage> query = col.Query().Where(x => x.groupName == groupName).OrderBy(x => x.connectTime, 0);

                            if (query.Count() > 0)
                            {
                                SocketMessage socketMessage = query.First();

                                messageItemView.setItems(socketMessage, textBox_DataBaseFilePath.Text);

                            }

                        }
                        catch { }

                    }

                }

            }
            catch { }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TimeSpan TP = new TimeSpan(0, 8, 0, 0);

            _LiteDBconnectionString.Filename = textBox_DataBaseFilePath.Text;
            using (LiteDatabase litedb = new LiteDatabase(_LiteDBconnectionString.Filename))
            {


                for (DateTime connectTime = DateTime.Parse("2020/01/01"); connectTime < DateTime.Parse("2024/01/31"); connectTime += TP)
                {
                    SocketMessage socketMessage = new SocketMessage(connectTime, "Test", "Test", "Test");
                    string key = socketMessage.Key();

                    ILiteCollection<SocketMessage> col = litedb.GetCollection<SocketMessage>("table_Message");
                    col.Insert(key, socketMessage);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BreakupLightDBFile job = new BreakupLightDBFile(textBox_DataBaseFilePath.Text, int.Parse(textBox_PostTime.Text));
            job.BreakupLightDBFile_byMonthFile(textBox_DataBaseFilePath.Text, int.Parse(textBox_PostTime.Text));

        }

        private void tabPage_Log_Enter(object sender, EventArgs e)
        {
            try
            {
                _LiteDBconnectionString.Filename = textBox_DataBaseFilePath.Text;

                using (LiteDatabase litedb = new LiteDatabase(_LiteDBconnectionString.Filename))
                {
                    var col = litedb.GetCollection<SocketMessage>("table_Message");


                    try
                    {
                        ILiteQueryable<SocketMessage> query = col.Query().OrderBy(x => x.connectTime, 0);

                        if (query.Count() > 0)
                        {
                            List<string> Lines = new List<string>();
                            foreach (SocketMessage socketMessage in query.ToArray())
                            {

                                Lines.Add(socketMessage.ToString());

                            }

                            textBox_Log.Text = String.Join("\r\n", Lines.ToArray());

                        }

                        label_LogUpdateTime.Text = "Log Update ... " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                    }
                    catch { }


                }

            }
            catch { }
        }

        private void button_LogReload_Click(object sender, EventArgs e)
        {
            tabPage_Log_Enter(null, null);
        }


        private void DataGridView_CellPainting_AddRowIndex(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex < 0 && e.RowIndex >= 0 && e.RowIndex < ((DataGridView)sender).RowCount - 1)
            {
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All);

                Rectangle indexRect = e.CellBounds;
                indexRect.Inflate(-2, -2);
                TextRenderer.DrawText(e.Graphics,
                    (e.RowIndex + 1).ToString(),
                    e.CellStyle.Font,
                    indexRect,
                    e.CellStyle.ForeColor,
                    TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
                e.Handled = true;
            }
        }

        private void button_ClientListLoad_Click(object sender, EventArgs e)
        {
            clientList.Clear();

            button_AddressListLoad_Click(null, null);

            for (int i = 0; i < dataGridView_ClientList.RowCount - 2; i++)
            {
                var cells = dataGridView_ClientList.Rows[i].Cells;
                string code = cells[0].Value.ToString();
                code += cells.Count > 1 && cells[1].Value != null ? "\t" + cells[1].Value.ToString() : "\t";
                code += cells.Count > 2 && cells[2].Value != null ? "\t" + cells[2].Value.ToString() : "\t";

                ClientData cd = new ClientData(code, addressNote);
                if (cd.ClientName != "") clientList.Add(cd);

            }

        }

        private void button_AddressListLoad_Click(object sender, EventArgs e)
        {
            List<string> addressList = new List<string>();

            for (int i = 0; i < dataGridView_AddressList.RowCount - 2; i++)
            {
                var cells = dataGridView_AddressList.Rows[i].Cells;
                string code = cells[0].Value.ToString();
                code += cells.Count > 1 && cells[1].Value != null ? "\t" + cells[1].Value.ToString() : "\t";

                if (code != "") addressList.Add(code);

            }
            addressNote = new AddressNote(addressList.ToArray());
        }

        private void button_NotifySettingLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
