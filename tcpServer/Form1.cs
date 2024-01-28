using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

using FluentScheduler;

using LiteDB;

using WinFormStringCnvClass;

namespace tcpserver
{
    public partial class Form1 : Form
    {
        TcpSocketServer tcp;
        NoticeTransmitter noticeTransmitter;
        List<ClientData> clientList;
        AddressBook addressBook;

        DateTime LastCheckTime;
        string thisExeDirPath;
        string datebasePath;
        int portNumber;

        ConnectionString _LiteDBconnectionString;
        static int _dbOpenRetryCount = 10;


        public Form1()
        {
            InitializeComponent();
            JobManager.Initialize();

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

            ClientListInitialize();
            AddressListInitialize();
            SchedulerInitialize();

            int.TryParse(textBox_httpTimeout.Text, out noticeTransmitter.httpTimeout);

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
            catch (Exception ex)
            {
                Debug.WriteLine(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " EX:" + ex.ToString());
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
                string receivedSocketMessage = "";

                while (tcp.ReceivedSocketQueue.TryDequeue(out receivedSocketMessage))
                {
                    string[] cols = receivedSocketMessage.Split('\t');

                    if (cols.Length >= 4)
                    {
                        DateTime connectTime;
                        if (DateTime.TryParse(cols[0], out connectTime)) { connectTime = DateTime.Now; };

                        string clientName = cols[1];
                        string status = cols[2];
                        string message = cols[3];
                        string parameter = cols.Length > 4 ? cols[4] : "";
                        bool needCheck = false;
                        if (cols.Length > 5) bool.TryParse(cols[5], out needCheck);

                        try
                        {
                            SocketMessage socketMessage = new SocketMessage(connectTime, clientName, status, message, parameter, needCheck);
                            string key = socketMessage.Key();

                            _LiteDBconnectionString.Filename = textBox_DataBaseFilePath.Text;

                            using (LiteDatabase litedb = new LiteDatabase(_LiteDBconnectionString))
                            {
                                ILiteCollection<SocketMessage> col = litedb.GetCollection<SocketMessage>("table_Message");
                                col.Insert(key, socketMessage);
                            }

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " EX:" + ex.ToString());
                        }

                    }

                }

                //========================
                // NoticeCheck
                //========================
                for (int retryIndex = 0; retryIndex < _dbOpenRetryCount; retryIndex++)
                {
                    try
                    {
                        _LiteDBconnectionString.Filename = textBox_DataBaseFilePath.Text;
                        using (LiteDatabase litedb = new LiteDatabase(_LiteDBconnectionString))
                        {
                            ILiteCollection<SocketMessage> col = litedb.GetCollection<SocketMessage>("table_Message");

                            foreach (var target in clientList)
                            {
                                var latestNoticeRecord = col.Query()
                                    .Where(x => x.needCheck == false && x.clientName == target.clientName)
                                    .OrderByDescending(x => x.connectTime)
                                    .FirstOrDefault();

                                var latestNeedCheckRecord = col.Query()
                                    .Where(x => x.needCheck == true && x.check == false && x.clientName == target.clientName)
                                    .OrderByDescending(x => x.connectTime)
                                    .FirstOrDefault();


                                if (latestNeedCheckRecord != null && latestNoticeRecord != null && latestNoticeRecord.connectTime > latestNeedCheckRecord.connectTime)
                                {
                                    noticeTransmitter.AddNotice(target, latestNeedCheckRecord);
                                    noticeTransmitter.AddNotice(target, latestNoticeRecord);

                                }

                            }

                        }

                        break;

                    }
                    catch (Exception ex)
                    {
                        Debug.Write(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " retry:" + retryIndex.ToString());
                        Debug.WriteLine(ex.ToString());
                        Thread.Sleep(100);

                        if (retryIndex == _dbOpenRetryCount - 1) throw;

                    }
                }

                LastCheckTime = DateTime.Now;

            }


            //========================
            // TimeoutCheck
            //========================

            for (int retryIndex = 0; retryIndex < _dbOpenRetryCount; retryIndex++)
            {
                try
                {
                    _LiteDBconnectionString.Filename = textBox_DataBaseFilePath.Text;
                    using (LiteDatabase litedb = new LiteDatabase(_LiteDBconnectionString))
                    {
                        ILiteCollection<SocketMessage> col = litedb.GetCollection<SocketMessage>("table_Message");

                        foreach (var target in clientList)
                        {
                            var latestRecord = col.Query()
                                .Where(x => x.clientName == target.clientName)
                                .OrderByDescending(x => x.connectTime)
                                .FirstOrDefault();

                            if (target.lastAccessTime == null)
                            {
                                target.lastAccessTime = DateTime.MinValue;
                            };
                            if (latestRecord != null && target.lastAccessTime < latestRecord.connectTime) { target.lastAccessTime = latestRecord.connectTime; };

                            bool flag1 = (DateTime.Now - target.lastAccessTime).TotalSeconds > target.timeoutLength;
                            bool flag2 = (DateTime.Now - target.lastTimeoutDetectedTime).TotalSeconds > target.timeoutLength;

                            if (target.timeoutCheck && flag1 && flag2)
                            {
                                SocketMessage timeoutMessage = new SocketMessage(target.lastAccessTime, target.clientName, "Timeout", target.timeoutMessage, "", true);
                                noticeTransmitter.AddNotice(target, timeoutMessage);
                                target.lastTimeoutDetectedTime = DateTime.Now;

                            }

                        }

                    }

                    break;

                }
                catch (Exception ex)
                {
                    Debug.Write(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " retry:" + retryIndex.ToString());
                    Debug.WriteLine(ex.ToString());
                    Thread.Sleep(100);

                    if (retryIndex == _dbOpenRetryCount - 1) throw;

                }
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
                    panel_StatusList.Controls.Add(new MessageItemView(noticeTransmitter, _LiteDBconnectionString));
                    panel_StatusList.Controls[i].Top = TopBuff;
                    ((MessageItemView)panel_StatusList.Controls[i]).groupBox_ClientName.Text = dataGridView_ClientList.Rows[i].Cells[0].Value.ToString();

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

                using (LiteDatabase litedb = new LiteDatabase(_LiteDBconnectionString))
                {
                    var col = litedb.GetCollection<SocketMessage>("table_Message");

                    foreach (MessageItemView messageItemView in panel_StatusList.Controls)
                    {
                        string clientName = messageItemView.groupBox_ClientName.Text;

                        try
                        {
                            ILiteQueryable<SocketMessage> query = col.Query().Where(x => x.clientName == clientName).OrderBy(x => x.connectTime, 0);

                            if (query.Count() > 0)
                            {
                                SocketMessage socketMessage = query.First();

                                messageItemView.setItems(socketMessage);

                            }

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " EX:" + ex.ToString());
                        }


                    }

                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " EX:" + ex.ToString());
            }


        }


        private void tabPage_Log_Enter(object sender, EventArgs e)
        {
            try
            {
                _LiteDBconnectionString.Filename = textBox_DataBaseFilePath.Text;

                using (LiteDatabase litedb = new LiteDatabase(_LiteDBconnectionString))
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
                    catch (Exception ex)
                    {
                        Debug.WriteLine(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " EX:" + ex.ToString());
                    }

                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " EX:" + ex.ToString());
            }

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
            ClientListInitialize();


        }

        private void button_AddressListLoad_Click(object sender, EventArgs e)
        {
            AddressListInitialize();
        }

        private void button_SchedulerList_Click(object sender, EventArgs e)
        {
            SchedulerInitialize();
        }

        private void ClientListInitialize()
        {
            clientList.Clear();

            button_AddressListLoad_Click(null, null);

            for (int i = 0; i < dataGridView_ClientList.RowCount - 1; i++)
            {
                try
                {
                    var cells = dataGridView_ClientList.Rows[i].Cells;

                    string clientName = cells[0].Value.ToString();
                    string addressKeys = cells[1].Value.ToString();
                    string timeoutCheck = cells[2].Value.ToString();
                    string timeoutLength = cells[3].Value.ToString();
                    string timeoutMessage = cells[4].Value.ToString();

                    string code = clientName + "\t" + timeoutCheck + "\t" + timeoutLength + "\t" + timeoutMessage;

                    ClientData cd = new ClientData(code, addressBook.getAddress(addressKeys));

                    if (cd.clientName != "") clientList.Add(cd);

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(GetType().Name + "::" + System.Reflection.MethodBase.GetCurrentMethod().Name + " EX:" + ex.ToString());
                }

            }

            ButtonEnable(button_ClientListLoad, false);

        }

        private void AddressListInitialize()
        {
            List<string> addressList = new List<string>();

            for (int i = 0; i < dataGridView_AddressList.RowCount - 1; i++)
            {
                var cells = dataGridView_AddressList.Rows[i].Cells;
                string code = cells[0].Value.ToString();
                code += cells.Count > 1 && cells[1].Value != null ? "\t" + cells[1].Value.ToString() : "\t";

                if (code != "") addressList.Add(code);

            }

            addressBook = new AddressBook(addressList.ToArray());

            ButtonEnable(button_AddressListLoad, false);

        }

        private void SchedulerInitialize()
        {
            JobManager.StopAndBlock();

            List<string> Lines = new List<string>();
            for (int i = 0; i < dataGridView_SchedulerList.RowCount - 1; i++)
            {
                var cells = dataGridView_SchedulerList.Rows[i].Cells;
                string code = cells[0].Value.ToString();
                code += cells.Count > 1 && cells[1].Value != null ? "\t" + cells[1].Value.ToString() : "\t";
                code += cells.Count > 2 && cells[2].Value != null ? "\t" + cells[2].Value.ToString() : "\t";
                code += cells.Count > 3 && cells[3].Value != null ? "\t" + cells[3].Value.ToString() : "\t";

                if (code != "") Lines.Add(code);

            }

            var job = new FluentSchedulerRegistry(textBox_DataBaseFilePath.Text, noticeTransmitter, Lines.ToArray(), clientList);

            JobManager.Initialize(job);

            ButtonEnable(button_SchedulerList, false);

        }

        private void textBox_httpTimeout_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox_httpTimeout.Text, out noticeTransmitter.httpTimeout);

        }

        private void button_CreateDammyData_Click(object sender, EventArgs e)
        {
            TimeSpan TP = new TimeSpan(0, 8, 0, 0);

            _LiteDBconnectionString.Filename = textBox_DataBaseFilePath.Text;
            using (LiteDatabase litedb = new LiteDatabase(_LiteDBconnectionString))
            {
                for (DateTime connectTime = DateTime.Parse("2020/01/01"); connectTime < DateTime.Parse("2024/01/31"); connectTime += TP)
                {
                    SocketMessage socketMessage = new SocketMessage(connectTime, "Test", "Test", "Test", "parameterTest");
                    ILiteCollection<SocketMessage> col = litedb.GetCollection<SocketMessage>("table_Message");

                    col.Insert(socketMessage.Key(), socketMessage);

                }
            }
        }

        private void button_BreakupDatabasefile_Click(object sender, EventArgs e)
        {
            BreakupLightDBFile job = new BreakupLightDBFile(textBox_DataBaseFilePath.Text, int.Parse(textBox_PostTime.Text));
            job.BreakupLightDBFile_byMonthFile(textBox_DataBaseFilePath.Text, int.Parse(textBox_PostTime.Text));
        }

        private void dataGridView_ClientList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            button_ClientListLoad.Enabled = true;
            button_ClientListLoad.BackColor = Color.GreenYellow;
        }

        private void dataGridView_ClientList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            ButtonEnable(button_ClientListLoad, true);
        }

        private void dataGridView_AddressList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ButtonEnable(button_AddressListLoad, true);
        }

        private void dataGridView_SchedulerList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ButtonEnable(button_SchedulerList, true);
        }

        private void ButtonEnable(Button button, bool enable)
        {
            if (enable)
            {
                button.Enabled = true;
                button.BackColor = Color.GreenYellow;
            }
            else
            {
                button.Enabled = false;
                button.BackColor = Color.Transparent;
            }


        }

    }

}
