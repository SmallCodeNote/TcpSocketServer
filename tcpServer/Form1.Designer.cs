namespace tcpserver
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Start = new System.Windows.Forms.Button();
            this.textBox_portNumber = new System.Windows.Forms.TextBox();
            this.panel_StatusListFrame = new System.Windows.Forms.Panel();
            this.panel_StatusList = new System.Windows.Forms.Panel();
            this.vScrollBar_StatusList = new System.Windows.Forms.VScrollBar();
            this.tabControl_Top = new System.Windows.Forms.TabControl();
            this.tabPage_Setting = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_StatusList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView_ClientList = new System.Windows.Forms.DataGridView();
            this.textBox_PostTime = new System.Windows.Forms.TextBox();
            this.button_getDataBaseFilePath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DataBaseFilePath = new System.Windows.Forms.TextBox();
            this.tabPage_Status = new System.Windows.Forms.TabPage();
            this.tabPage_Log = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer_UpdateList = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Column_ClientList_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TimeOutMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_VoiceSetting = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_AddressName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_StatusListFrame.SuspendLayout();
            this.tabControl_Top.SuspendLayout();
            this.tabPage_Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StatusList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClientList)).BeginInit();
            this.tabPage_Status.SuspendLayout();
            this.tabPage_Log.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage_VoiceSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(466, 61);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(115, 30);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // textBox_portNumber
            // 
            this.textBox_portNumber.Location = new System.Drawing.Point(345, 66);
            this.textBox_portNumber.Name = "textBox_portNumber";
            this.textBox_portNumber.Size = new System.Drawing.Size(115, 22);
            this.textBox_portNumber.TabIndex = 1;
            // 
            // panel_StatusListFrame
            // 
            this.panel_StatusListFrame.Controls.Add(this.panel_StatusList);
            this.panel_StatusListFrame.Location = new System.Drawing.Point(6, 6);
            this.panel_StatusListFrame.Name = "panel_StatusListFrame";
            this.panel_StatusListFrame.Size = new System.Drawing.Size(500, 500);
            this.panel_StatusListFrame.TabIndex = 2;
            // 
            // panel_StatusList
            // 
            this.panel_StatusList.Location = new System.Drawing.Point(0, 0);
            this.panel_StatusList.Name = "panel_StatusList";
            this.panel_StatusList.Size = new System.Drawing.Size(500, 100);
            this.panel_StatusList.TabIndex = 0;
            this.panel_StatusList.SizeChanged += new System.EventHandler(this.panel_StatusList_SizeChanged);
            // 
            // vScrollBar_StatusList
            // 
            this.vScrollBar_StatusList.LargeChange = 100;
            this.vScrollBar_StatusList.Location = new System.Drawing.Point(509, 6);
            this.vScrollBar_StatusList.Name = "vScrollBar_StatusList";
            this.vScrollBar_StatusList.Size = new System.Drawing.Size(21, 500);
            this.vScrollBar_StatusList.TabIndex = 3;
            this.vScrollBar_StatusList.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_StatusList_Scroll);
            this.vScrollBar_StatusList.ValueChanged += new System.EventHandler(this.vScrollBar_StatusList_ValueChanged);
            // 
            // tabControl_Top
            // 
            this.tabControl_Top.Controls.Add(this.tabPage_Setting);
            this.tabControl_Top.Controls.Add(this.tabPage_VoiceSetting);
            this.tabControl_Top.Controls.Add(this.tabPage_Status);
            this.tabControl_Top.Controls.Add(this.tabPage_Log);
            this.tabControl_Top.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Top.Name = "tabControl_Top";
            this.tabControl_Top.SelectedIndex = 0;
            this.tabControl_Top.Size = new System.Drawing.Size(606, 546);
            this.tabControl_Top.TabIndex = 4;
            // 
            // tabPage_Setting
            // 
            this.tabPage_Setting.Controls.Add(this.label5);
            this.tabPage_Setting.Controls.Add(this.label2);
            this.tabPage_Setting.Controls.Add(this.button_Start);
            this.tabPage_Setting.Controls.Add(this.dataGridView_StatusList);
            this.tabPage_Setting.Controls.Add(this.dataGridView_ClientList);
            this.tabPage_Setting.Controls.Add(this.textBox_PostTime);
            this.tabPage_Setting.Controls.Add(this.textBox_portNumber);
            this.tabPage_Setting.Controls.Add(this.button_getDataBaseFilePath);
            this.tabPage_Setting.Controls.Add(this.label4);
            this.tabPage_Setting.Controls.Add(this.label3);
            this.tabPage_Setting.Controls.Add(this.label1);
            this.tabPage_Setting.Controls.Add(this.textBox_DataBaseFilePath);
            this.tabPage_Setting.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Setting.Name = "tabPage_Setting";
            this.tabPage_Setting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Setting.Size = new System.Drawing.Size(598, 517);
            this.tabPage_Setting.TabIndex = 2;
            this.tabPage_Setting.Text = "Setting";
            this.tabPage_Setting.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "BackupTime(minute)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // dataGridView_StatusList
            // 
            this.dataGridView_StatusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StatusList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column_Interval,
            this.Column_check});
            this.dataGridView_StatusList.Location = new System.Drawing.Point(24, 336);
            this.dataGridView_StatusList.Name = "dataGridView_StatusList";
            this.dataGridView_StatusList.RowTemplate.Height = 24;
            this.dataGridView_StatusList.Size = new System.Drawing.Size(557, 163);
            this.dataGridView_StatusList.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "StatusName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // Column_Interval
            // 
            this.Column_Interval.HeaderText = "Interval(sec.)";
            this.Column_Interval.Name = "Column_Interval";
            // 
            // Column_check
            // 
            this.Column_check.HeaderText = "NeedCheck";
            this.Column_check.Name = "Column_check";
            // 
            // dataGridView_ClientList
            // 
            this.dataGridView_ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ClientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ClientList_Name,
            this.Column_Timeout,
            this.Column_TimeOutMessage});
            this.dataGridView_ClientList.Location = new System.Drawing.Point(24, 102);
            this.dataGridView_ClientList.Name = "dataGridView_ClientList";
            this.dataGridView_ClientList.RowTemplate.Height = 24;
            this.dataGridView_ClientList.Size = new System.Drawing.Size(557, 213);
            this.dataGridView_ClientList.TabIndex = 3;
            // 
            // textBox_PostTime
            // 
            this.textBox_PostTime.Location = new System.Drawing.Point(487, 7);
            this.textBox_PostTime.Name = "textBox_PostTime";
            this.textBox_PostTime.Size = new System.Drawing.Size(94, 22);
            this.textBox_PostTime.TabIndex = 1;
            this.textBox_PostTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_getDataBaseFilePath
            // 
            this.button_getDataBaseFilePath.Location = new System.Drawing.Point(543, 33);
            this.button_getDataBaseFilePath.Name = "button_getDataBaseFilePath";
            this.button_getDataBaseFilePath.Size = new System.Drawing.Size(38, 22);
            this.button_getDataBaseFilePath.TabIndex = 2;
            this.button_getDataBaseFilePath.Text = "...";
            this.button_getDataBaseFilePath.UseVisualStyleBackColor = true;
            this.button_getDataBaseFilePath.Click += new System.EventHandler(this.button_getDataBaseFilePath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "StatusList";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "ClientList";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "DataBaseFilePath";
            // 
            // textBox_DataBaseFilePath
            // 
            this.textBox_DataBaseFilePath.Location = new System.Drawing.Point(24, 33);
            this.textBox_DataBaseFilePath.Name = "textBox_DataBaseFilePath";
            this.textBox_DataBaseFilePath.Size = new System.Drawing.Size(513, 22);
            this.textBox_DataBaseFilePath.TabIndex = 0;
            // 
            // tabPage_Status
            // 
            this.tabPage_Status.Controls.Add(this.panel_StatusListFrame);
            this.tabPage_Status.Controls.Add(this.vScrollBar_StatusList);
            this.tabPage_Status.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Status.Name = "tabPage_Status";
            this.tabPage_Status.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Status.Size = new System.Drawing.Size(598, 517);
            this.tabPage_Status.TabIndex = 0;
            this.tabPage_Status.Text = "Status";
            this.tabPage_Status.UseVisualStyleBackColor = true;
            this.tabPage_Status.Enter += new System.EventHandler(this.tabPage_Status_Enter);
            // 
            // tabPage_Log
            // 
            this.tabPage_Log.Controls.Add(this.button2);
            this.tabPage_Log.Controls.Add(this.button1);
            this.tabPage_Log.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Log.Name = "tabPage_Log";
            this.tabPage_Log.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Log.Size = new System.Drawing.Size(598, 517);
            this.tabPage_Log.TabIndex = 1;
            this.tabPage_Log.Text = "Log";
            this.tabPage_Log.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer_UpdateList
            // 
            this.timer_UpdateList.Interval = 1000;
            this.timer_UpdateList.Tick += new System.EventHandler(this.timer_UpdateList_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(622, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(18, 20);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // Column_ClientList_Name
            // 
            this.Column_ClientList_Name.HeaderText = "ClientName";
            this.Column_ClientList_Name.Name = "Column_ClientList_Name";
            this.Column_ClientList_Name.Width = 150;
            // 
            // Column_Timeout
            // 
            this.Column_Timeout.HeaderText = "Timeout(sec.)";
            this.Column_Timeout.Name = "Column_Timeout";
            this.Column_Timeout.Width = 50;
            // 
            // Column_TimeOutMessage
            // 
            this.Column_TimeOutMessage.HeaderText = "TimeOutMessage";
            this.Column_TimeOutMessage.Name = "Column_TimeOutMessage";
            this.Column_TimeOutMessage.Width = 250;
            // 
            // tabPage_VoiceSetting
            // 
            this.tabPage_VoiceSetting.Controls.Add(this.label6);
            this.tabPage_VoiceSetting.Controls.Add(this.dataGridView1);
            this.tabPage_VoiceSetting.Location = new System.Drawing.Point(4, 25);
            this.tabPage_VoiceSetting.Name = "tabPage_VoiceSetting";
            this.tabPage_VoiceSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_VoiceSetting.Size = new System.Drawing.Size(598, 517);
            this.tabPage_VoiceSetting.TabIndex = 3;
            this.tabPage_VoiceSetting.Text = "VoiceSetting";
            this.tabPage_VoiceSetting.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAddress,
            this.Column_AddressName});
            this.dataGridView1.Location = new System.Drawing.Point(31, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.Name = "ColumnAddress";
            // 
            // Column_AddressName
            // 
            this.Column_AddressName.HeaderText = "Name";
            this.Column_AddressName.Name = "Column_AddressName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "SpeakerAddressList";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 613);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_StatusListFrame.ResumeLayout(false);
            this.tabControl_Top.ResumeLayout(false);
            this.tabPage_Setting.ResumeLayout(false);
            this.tabPage_Setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StatusList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClientList)).EndInit();
            this.tabPage_Status.ResumeLayout(false);
            this.tabPage_Log.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage_VoiceSetting.ResumeLayout(false);
            this.tabPage_VoiceSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.TextBox textBox_portNumber;
        private System.Windows.Forms.Panel panel_StatusListFrame;
        private System.Windows.Forms.Panel panel_StatusList;
        private System.Windows.Forms.VScrollBar vScrollBar_StatusList;
        private System.Windows.Forms.TabControl tabControl_Top;
        private System.Windows.Forms.TabPage tabPage_Status;
        private System.Windows.Forms.TabPage tabPage_Log;
        private System.Windows.Forms.TabPage tabPage_Setting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DataBaseFilePath;
        private System.Windows.Forms.Button button_getDataBaseFilePath;
        private System.Windows.Forms.Timer timer_UpdateList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_ClientList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView_StatusList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_PostTime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Interval;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ClientList_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Timeout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TimeOutMessage;
        private System.Windows.Forms.TabPage tabPage_VoiceSetting;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_AddressName;
        private System.Windows.Forms.Label label6;
    }
}

