﻿namespace tcpClient
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
            this.textBox_ClientName = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_PortNumber = new System.Windows.Forms.TextBox();
            this.button_SendMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Parameter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.comboBox_ScheduleUnit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ScheduleUnitParam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_AddSchedule = new System.Windows.Forms.Button();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_View = new System.Windows.Forms.TabPage();
            this.tabControl_JobView = new System.Windows.Forms.TabControl();
            this.tabPage_JovView = new System.Windows.Forms.TabPage();
            this.vScrollBar_StatusList = new System.Windows.Forms.VScrollBar();
            this.panel_StatusListFrame = new System.Windows.Forms.Panel();
            this.panel_StatusList = new System.Windows.Forms.Panel();
            this.tabPage_EveryJobStore = new System.Windows.Forms.TabPage();
            this.checkBox_LoadFromStoreAuto = new System.Windows.Forms.CheckBox();
            this.textBox_Store = new System.Windows.Forms.TextBox();
            this.button_LoadFromStore = new System.Windows.Forms.Button();
            this.tabPage_Panel = new System.Windows.Forms.TabPage();
            this.tabControl_OnceJobPanel = new System.Windows.Forms.TabControl();
            this.tabPage_OnceJobPanel = new System.Windows.Forms.TabPage();
            this.vScrollBar_OnceJobList = new System.Windows.Forms.VScrollBar();
            this.panel_OnceJobListFrame = new System.Windows.Forms.Panel();
            this.panel_OnceJobList = new System.Windows.Forms.Panel();
            this.tabPage_OnceJobPanel_Store = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_OnceJobPanelStore = new System.Windows.Forms.TextBox();
            this.tabPage_Edit = new System.Windows.Forms.TabPage();
            this.button_EditContentsFromClipboard = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_JobName = new System.Windows.Forms.TextBox();
            this.comboBox_checkStyle = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_AddOnceJobPanel = new System.Windows.Forms.Button();
            this.tabPage_MessageLog = new System.Windows.Forms.TabPage();
            this.label_Return = new System.Windows.Forms.Label();
            this.timer_ClientViewUpdate = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_StatusListFrame_Sort = new System.Windows.Forms.Button();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_View.SuspendLayout();
            this.tabControl_JobView.SuspendLayout();
            this.tabPage_JovView.SuspendLayout();
            this.panel_StatusListFrame.SuspendLayout();
            this.tabPage_EveryJobStore.SuspendLayout();
            this.tabPage_Panel.SuspendLayout();
            this.tabControl_OnceJobPanel.SuspendLayout();
            this.tabPage_OnceJobPanel.SuspendLayout();
            this.panel_OnceJobListFrame.SuspendLayout();
            this.tabPage_OnceJobPanel_Store.SuspendLayout();
            this.tabPage_Edit.SuspendLayout();
            this.tabPage_MessageLog.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ClientName
            // 
            this.textBox_ClientName.Location = new System.Drawing.Point(16, 115);
            this.textBox_ClientName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ClientName.Name = "textBox_ClientName";
            this.textBox_ClientName.Size = new System.Drawing.Size(77, 19);
            this.textBox_ClientName.TabIndex = 0;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(132, 115);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(191, 19);
            this.textBox_Address.TabIndex = 1;
            // 
            // textBox_PortNumber
            // 
            this.textBox_PortNumber.Location = new System.Drawing.Point(327, 115);
            this.textBox_PortNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_PortNumber.Name = "textBox_PortNumber";
            this.textBox_PortNumber.Size = new System.Drawing.Size(76, 19);
            this.textBox_PortNumber.TabIndex = 1;
            // 
            // button_SendMessage
            // 
            this.button_SendMessage.Location = new System.Drawing.Point(435, 330);
            this.button_SendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.button_SendMessage.Name = "button_SendMessage";
            this.button_SendMessage.Size = new System.Drawing.Size(56, 18);
            this.button_SendMessage.TabIndex = 2;
            this.button_SendMessage.Text = "Send";
            this.button_SendMessage.UseVisualStyleBackColor = true;
            this.button_SendMessage.Click += new System.EventHandler(this.button_SendMessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "ClientName";
            // 
            // textBox_Message
            // 
            this.textBox_Message.Location = new System.Drawing.Point(16, 228);
            this.textBox_Message.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(476, 40);
            this.textBox_Message.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status";
            // 
            // textBox_Parameter
            // 
            this.textBox_Parameter.Location = new System.Drawing.Point(16, 286);
            this.textBox_Parameter.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Parameter.Multiline = true;
            this.textBox_Parameter.Name = "textBox_Parameter";
            this.textBox_Parameter.Size = new System.Drawing.Size(476, 40);
            this.textBox_Parameter.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Parameter";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "Notice",
            "Warning",
            "Error"});
            this.comboBox_Status.Location = new System.Drawing.Point(16, 154);
            this.comboBox_Status.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(77, 20);
            this.comboBox_Status.TabIndex = 6;
            // 
            // comboBox_ScheduleUnit
            // 
            this.comboBox_ScheduleUnit.FormattingEnabled = true;
            this.comboBox_ScheduleUnit.Items.AddRange(new object[] {
            "EveryDays",
            "EveryHours",
            "EverySeconds",
            "OnceAtSeconds",
            "OnceAtMinutes",
            "OnceAtHours"});
            this.comboBox_ScheduleUnit.Location = new System.Drawing.Point(12, 72);
            this.comboBox_ScheduleUnit.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_ScheduleUnit.Name = "comboBox_ScheduleUnit";
            this.comboBox_ScheduleUnit.Size = new System.Drawing.Size(123, 20);
            this.comboBox_ScheduleUnit.TabIndex = 6;
            this.comboBox_ScheduleUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox_ScheduleUnit_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "Interval";
            // 
            // textBox_ScheduleUnitParam
            // 
            this.textBox_ScheduleUnitParam.Location = new System.Drawing.Point(138, 73);
            this.textBox_ScheduleUnitParam.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ScheduleUnitParam.Name = "textBox_ScheduleUnitParam";
            this.textBox_ScheduleUnitParam.Size = new System.Drawing.Size(350, 19);
            this.textBox_ScheduleUnitParam.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "At";
            // 
            // button_AddSchedule
            // 
            this.button_AddSchedule.Location = new System.Drawing.Point(415, 96);
            this.button_AddSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddSchedule.Name = "button_AddSchedule";
            this.button_AddSchedule.Size = new System.Drawing.Size(76, 29);
            this.button_AddSchedule.TabIndex = 2;
            this.button_AddSchedule.Text = "AddJob";
            this.button_AddSchedule.UseVisualStyleBackColor = true;
            this.button_AddSchedule.Click += new System.EventHandler(this.button_AddSchedule_Click);
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_View);
            this.tabControl_Main.Controls.Add(this.tabPage_Panel);
            this.tabControl_Main.Controls.Add(this.tabPage_Edit);
            this.tabControl_Main.Controls.Add(this.tabPage_MessageLog);
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(510, 394);
            this.tabControl_Main.TabIndex = 7;
            // 
            // tabPage_View
            // 
            this.tabPage_View.Controls.Add(this.tabControl_JobView);
            this.tabPage_View.Location = new System.Drawing.Point(4, 22);
            this.tabPage_View.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_View.Name = "tabPage_View";
            this.tabPage_View.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_View.Size = new System.Drawing.Size(502, 368);
            this.tabPage_View.TabIndex = 1;
            this.tabPage_View.Text = "JobView";
            this.tabPage_View.UseVisualStyleBackColor = true;
            this.tabPage_View.Enter += new System.EventHandler(this.tabPage_View_Enter);
            this.tabPage_View.Leave += new System.EventHandler(this.tabPage_View_Leave);
            // 
            // tabControl_JobView
            // 
            this.tabControl_JobView.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl_JobView.Controls.Add(this.tabPage_JovView);
            this.tabControl_JobView.Controls.Add(this.tabPage_EveryJobStore);
            this.tabControl_JobView.Location = new System.Drawing.Point(8, 5);
            this.tabControl_JobView.Name = "tabControl_JobView";
            this.tabControl_JobView.SelectedIndex = 0;
            this.tabControl_JobView.Size = new System.Drawing.Size(486, 356);
            this.tabControl_JobView.TabIndex = 3;
            // 
            // tabPage_JovView
            // 
            this.tabPage_JovView.Controls.Add(this.button_StatusListFrame_Sort);
            this.tabPage_JovView.Controls.Add(this.vScrollBar_StatusList);
            this.tabPage_JovView.Controls.Add(this.panel_StatusListFrame);
            this.tabPage_JovView.Location = new System.Drawing.Point(4, 4);
            this.tabPage_JovView.Name = "tabPage_JovView";
            this.tabPage_JovView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_JovView.Size = new System.Drawing.Size(478, 330);
            this.tabPage_JovView.TabIndex = 0;
            this.tabPage_JovView.Text = "JovView";
            this.tabPage_JovView.UseVisualStyleBackColor = true;
            // 
            // vScrollBar_StatusList
            // 
            this.vScrollBar_StatusList.Location = new System.Drawing.Point(409, 6);
            this.vScrollBar_StatusList.Name = "vScrollBar_StatusList";
            this.vScrollBar_StatusList.Size = new System.Drawing.Size(26, 318);
            this.vScrollBar_StatusList.TabIndex = 2;
            // 
            // panel_StatusListFrame
            // 
            this.panel_StatusListFrame.Controls.Add(this.panel_StatusList);
            this.panel_StatusListFrame.Location = new System.Drawing.Point(6, 6);
            this.panel_StatusListFrame.Name = "panel_StatusListFrame";
            this.panel_StatusListFrame.Size = new System.Drawing.Size(400, 318);
            this.panel_StatusListFrame.TabIndex = 1;
            // 
            // panel_StatusList
            // 
            this.panel_StatusList.Location = new System.Drawing.Point(0, 0);
            this.panel_StatusList.Name = "panel_StatusList";
            this.panel_StatusList.Size = new System.Drawing.Size(400, 180);
            this.panel_StatusList.TabIndex = 0;
            // 
            // tabPage_EveryJobStore
            // 
            this.tabPage_EveryJobStore.Controls.Add(this.checkBox_LoadFromStoreAuto);
            this.tabPage_EveryJobStore.Controls.Add(this.textBox_Store);
            this.tabPage_EveryJobStore.Controls.Add(this.button_LoadFromStore);
            this.tabPage_EveryJobStore.Location = new System.Drawing.Point(4, 4);
            this.tabPage_EveryJobStore.Name = "tabPage_EveryJobStore";
            this.tabPage_EveryJobStore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_EveryJobStore.Size = new System.Drawing.Size(478, 330);
            this.tabPage_EveryJobStore.TabIndex = 1;
            this.tabPage_EveryJobStore.Text = "EveryJobStore";
            this.tabPage_EveryJobStore.UseVisualStyleBackColor = true;
            // 
            // checkBox_LoadFromStoreAuto
            // 
            this.checkBox_LoadFromStoreAuto.AutoSize = true;
            this.checkBox_LoadFromStoreAuto.Location = new System.Drawing.Point(150, 6);
            this.checkBox_LoadFromStoreAuto.Name = "checkBox_LoadFromStoreAuto";
            this.checkBox_LoadFromStoreAuto.Size = new System.Drawing.Size(125, 16);
            this.checkBox_LoadFromStoreAuto.TabIndex = 2;
            this.checkBox_LoadFromStoreAuto.Text = "LoadFromStoreAuto";
            this.checkBox_LoadFromStoreAuto.UseVisualStyleBackColor = true;
            // 
            // textBox_Store
            // 
            this.textBox_Store.Location = new System.Drawing.Point(6, 28);
            this.textBox_Store.Multiline = true;
            this.textBox_Store.Name = "textBox_Store";
            this.textBox_Store.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Store.Size = new System.Drawing.Size(466, 258);
            this.textBox_Store.TabIndex = 0;
            this.textBox_Store.WordWrap = false;
            // 
            // button_LoadFromStore
            // 
            this.button_LoadFromStore.Location = new System.Drawing.Point(2, 2);
            this.button_LoadFromStore.Name = "button_LoadFromStore";
            this.button_LoadFromStore.Size = new System.Drawing.Size(112, 23);
            this.button_LoadFromStore.TabIndex = 1;
            this.button_LoadFromStore.Text = "LoadFromStore";
            this.button_LoadFromStore.UseVisualStyleBackColor = true;
            this.button_LoadFromStore.Click += new System.EventHandler(this.button_LoadFromStore_Click);
            // 
            // tabPage_Panel
            // 
            this.tabPage_Panel.Controls.Add(this.tabControl_OnceJobPanel);
            this.tabPage_Panel.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Panel.Name = "tabPage_Panel";
            this.tabPage_Panel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Panel.Size = new System.Drawing.Size(502, 368);
            this.tabPage_Panel.TabIndex = 3;
            this.tabPage_Panel.Text = "OnceJobPanel";
            this.tabPage_Panel.UseVisualStyleBackColor = true;
            // 
            // tabControl_OnceJobPanel
            // 
            this.tabControl_OnceJobPanel.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl_OnceJobPanel.Controls.Add(this.tabPage_OnceJobPanel);
            this.tabControl_OnceJobPanel.Controls.Add(this.tabPage_OnceJobPanel_Store);
            this.tabControl_OnceJobPanel.Location = new System.Drawing.Point(3, 3);
            this.tabControl_OnceJobPanel.Name = "tabControl_OnceJobPanel";
            this.tabControl_OnceJobPanel.SelectedIndex = 0;
            this.tabControl_OnceJobPanel.Size = new System.Drawing.Size(496, 342);
            this.tabControl_OnceJobPanel.TabIndex = 0;
            // 
            // tabPage_OnceJobPanel
            // 
            this.tabPage_OnceJobPanel.Controls.Add(this.vScrollBar_OnceJobList);
            this.tabPage_OnceJobPanel.Controls.Add(this.panel_OnceJobListFrame);
            this.tabPage_OnceJobPanel.Location = new System.Drawing.Point(4, 4);
            this.tabPage_OnceJobPanel.Name = "tabPage_OnceJobPanel";
            this.tabPage_OnceJobPanel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_OnceJobPanel.Size = new System.Drawing.Size(488, 316);
            this.tabPage_OnceJobPanel.TabIndex = 0;
            this.tabPage_OnceJobPanel.Text = "Panels";
            this.tabPage_OnceJobPanel.UseVisualStyleBackColor = true;
            // 
            // vScrollBar_OnceJobList
            // 
            this.vScrollBar_OnceJobList.Location = new System.Drawing.Point(457, 3);
            this.vScrollBar_OnceJobList.Name = "vScrollBar_OnceJobList";
            this.vScrollBar_OnceJobList.Size = new System.Drawing.Size(28, 284);
            this.vScrollBar_OnceJobList.TabIndex = 1;
            // 
            // panel_OnceJobListFrame
            // 
            this.panel_OnceJobListFrame.Controls.Add(this.panel_OnceJobList);
            this.panel_OnceJobListFrame.Location = new System.Drawing.Point(3, 3);
            this.panel_OnceJobListFrame.Name = "panel_OnceJobListFrame";
            this.panel_OnceJobListFrame.Size = new System.Drawing.Size(451, 284);
            this.panel_OnceJobListFrame.TabIndex = 0;
            // 
            // panel_OnceJobList
            // 
            this.panel_OnceJobList.Location = new System.Drawing.Point(0, 0);
            this.panel_OnceJobList.Name = "panel_OnceJobList";
            this.panel_OnceJobList.Size = new System.Drawing.Size(185, 137);
            this.panel_OnceJobList.TabIndex = 0;
            // 
            // tabPage_OnceJobPanel_Store
            // 
            this.tabPage_OnceJobPanel_Store.Controls.Add(this.checkBox1);
            this.tabPage_OnceJobPanel_Store.Controls.Add(this.button1);
            this.tabPage_OnceJobPanel_Store.Controls.Add(this.textBox_OnceJobPanelStore);
            this.tabPage_OnceJobPanel_Store.Location = new System.Drawing.Point(4, 4);
            this.tabPage_OnceJobPanel_Store.Name = "tabPage_OnceJobPanel_Store";
            this.tabPage_OnceJobPanel_Store.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_OnceJobPanel_Store.Size = new System.Drawing.Size(488, 316);
            this.tabPage_OnceJobPanel_Store.TabIndex = 1;
            this.tabPage_OnceJobPanel_Store.Text = "Store";
            this.tabPage_OnceJobPanel_Store.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(154, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "LoadFromStoreAuto";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "LoadFromStore";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_OnceJobPanelStore
            // 
            this.textBox_OnceJobPanelStore.Location = new System.Drawing.Point(3, 34);
            this.textBox_OnceJobPanelStore.Multiline = true;
            this.textBox_OnceJobPanelStore.Name = "textBox_OnceJobPanelStore";
            this.textBox_OnceJobPanelStore.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_OnceJobPanelStore.Size = new System.Drawing.Size(479, 252);
            this.textBox_OnceJobPanelStore.TabIndex = 0;
            this.textBox_OnceJobPanelStore.WordWrap = false;
            this.textBox_OnceJobPanelStore.TextChanged += new System.EventHandler(this.textBox_OnceJobPanelStore_TextChanged);
            // 
            // tabPage_Edit
            // 
            this.tabPage_Edit.Controls.Add(this.button_EditContentsFromClipboard);
            this.tabPage_Edit.Controls.Add(this.label9);
            this.tabPage_Edit.Controls.Add(this.label3);
            this.tabPage_Edit.Controls.Add(this.comboBox_ScheduleUnit);
            this.tabPage_Edit.Controls.Add(this.textBox_JobName);
            this.tabPage_Edit.Controls.Add(this.textBox_ClientName);
            this.tabPage_Edit.Controls.Add(this.comboBox_checkStyle);
            this.tabPage_Edit.Controls.Add(this.comboBox_Status);
            this.tabPage_Edit.Controls.Add(this.textBox_Message);
            this.tabPage_Edit.Controls.Add(this.textBox_Parameter);
            this.tabPage_Edit.Controls.Add(this.label2);
            this.tabPage_Edit.Controls.Add(this.textBox_Address);
            this.tabPage_Edit.Controls.Add(this.label6);
            this.tabPage_Edit.Controls.Add(this.textBox_ScheduleUnitParam);
            this.tabPage_Edit.Controls.Add(this.label4);
            this.tabPage_Edit.Controls.Add(this.textBox_PortNumber);
            this.tabPage_Edit.Controls.Add(this.label7);
            this.tabPage_Edit.Controls.Add(this.button_SendMessage);
            this.tabPage_Edit.Controls.Add(this.label10);
            this.tabPage_Edit.Controls.Add(this.label5);
            this.tabPage_Edit.Controls.Add(this.button_AddOnceJobPanel);
            this.tabPage_Edit.Controls.Add(this.button_AddSchedule);
            this.tabPage_Edit.Controls.Add(this.label8);
            this.tabPage_Edit.Controls.Add(this.label1);
            this.tabPage_Edit.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Edit.Name = "tabPage_Edit";
            this.tabPage_Edit.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Edit.Size = new System.Drawing.Size(502, 368);
            this.tabPage_Edit.TabIndex = 0;
            this.tabPage_Edit.Text = "JobEdit";
            this.tabPage_Edit.UseVisualStyleBackColor = true;
            // 
            // button_EditContentsFromClipboard
            // 
            this.button_EditContentsFromClipboard.Location = new System.Drawing.Point(371, 3);
            this.button_EditContentsFromClipboard.Name = "button_EditContentsFromClipboard";
            this.button_EditContentsFromClipboard.Size = new System.Drawing.Size(117, 23);
            this.button_EditContentsFromClipboard.TabIndex = 7;
            this.button_EditContentsFromClipboard.Text = "From Clipboard";
            this.button_EditContentsFromClipboard.UseVisualStyleBackColor = true;
            this.button_EditContentsFromClipboard.Click += new System.EventHandler(this.button_EditContentsFromClipboard_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "JobName";
            // 
            // textBox_JobName
            // 
            this.textBox_JobName.Location = new System.Drawing.Point(12, 27);
            this.textBox_JobName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_JobName.Name = "textBox_JobName";
            this.textBox_JobName.Size = new System.Drawing.Size(476, 19);
            this.textBox_JobName.TabIndex = 0;
            // 
            // comboBox_checkStyle
            // 
            this.comboBox_checkStyle.FormattingEnabled = true;
            this.comboBox_checkStyle.Items.AddRange(new object[] {
            "Once",
            "Ever"});
            this.comboBox_checkStyle.Location = new System.Drawing.Point(16, 192);
            this.comboBox_checkStyle.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_checkStyle.Name = "comboBox_checkStyle";
            this.comboBox_checkStyle.Size = new System.Drawing.Size(77, 20);
            this.comboBox_checkStyle.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 178);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "checkStyle";
            // 
            // button_AddOnceJobPanel
            // 
            this.button_AddOnceJobPanel.Location = new System.Drawing.Point(415, 126);
            this.button_AddOnceJobPanel.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddOnceJobPanel.Name = "button_AddOnceJobPanel";
            this.button_AddOnceJobPanel.Size = new System.Drawing.Size(77, 29);
            this.button_AddOnceJobPanel.TabIndex = 2;
            this.button_AddOnceJobPanel.Text = "AddPanel";
            this.button_AddOnceJobPanel.UseVisualStyleBackColor = true;
            this.button_AddOnceJobPanel.Click += new System.EventHandler(this.button_AddOnceJobPanel_Click);
            // 
            // tabPage_MessageLog
            // 
            this.tabPage_MessageLog.Controls.Add(this.label_Return);
            this.tabPage_MessageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPage_MessageLog.Name = "tabPage_MessageLog";
            this.tabPage_MessageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MessageLog.Size = new System.Drawing.Size(502, 368);
            this.tabPage_MessageLog.TabIndex = 4;
            this.tabPage_MessageLog.Text = "Log";
            this.tabPage_MessageLog.UseVisualStyleBackColor = true;
            // 
            // label_Return
            // 
            this.label_Return.Location = new System.Drawing.Point(7, 25);
            this.label_Return.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Return.Name = "label_Return";
            this.label_Return.Size = new System.Drawing.Size(488, 331);
            this.label_Return.TabIndex = 4;
            this.label_Return.Text = "...";
            // 
            // timer_ClientViewUpdate
            // 
            this.timer_ClientViewUpdate.Tick += new System.EventHandler(this.timer_ClientViewUpdate_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Timer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(525, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Timer
            // 
            this.toolStripStatusLabel_Timer.Name = "toolStripStatusLabel_Timer";
            this.toolStripStatusLabel_Timer.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel_Timer.Text = "...";
            // 
            // button_StatusListFrame_Sort
            // 
            this.button_StatusListFrame_Sort.Location = new System.Drawing.Point(444, 6);
            this.button_StatusListFrame_Sort.Name = "button_StatusListFrame_Sort";
            this.button_StatusListFrame_Sort.Size = new System.Drawing.Size(28, 27);
            this.button_StatusListFrame_Sort.TabIndex = 3;
            this.button_StatusListFrame_Sort.Text = "↑";
            this.button_StatusListFrame_Sort.UseVisualStyleBackColor = true;
            this.button_StatusListFrame_Sort.Click += new System.EventHandler(this.button_StatusListFrame_Sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 422);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl_Main);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_View.ResumeLayout(false);
            this.tabControl_JobView.ResumeLayout(false);
            this.tabPage_JovView.ResumeLayout(false);
            this.panel_StatusListFrame.ResumeLayout(false);
            this.tabPage_EveryJobStore.ResumeLayout(false);
            this.tabPage_EveryJobStore.PerformLayout();
            this.tabPage_Panel.ResumeLayout(false);
            this.tabControl_OnceJobPanel.ResumeLayout(false);
            this.tabPage_OnceJobPanel.ResumeLayout(false);
            this.panel_OnceJobListFrame.ResumeLayout(false);
            this.tabPage_OnceJobPanel_Store.ResumeLayout(false);
            this.tabPage_OnceJobPanel_Store.PerformLayout();
            this.tabPage_Edit.ResumeLayout(false);
            this.tabPage_Edit.PerformLayout();
            this.tabPage_MessageLog.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ClientName;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_PortNumber;
        private System.Windows.Forms.Button button_SendMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Parameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.ComboBox comboBox_ScheduleUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ScheduleUnitParam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_AddSchedule;
        private System.Windows.Forms.TabPage tabPage_Edit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_JobName;
        private System.Windows.Forms.VScrollBar vScrollBar_StatusList;
        private System.Windows.Forms.Panel panel_StatusListFrame;
        private System.Windows.Forms.Panel panel_StatusList;
        private System.Windows.Forms.Timer timer_ClientViewUpdate;
        private System.Windows.Forms.ComboBox comboBox_checkStyle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Store;
        private System.Windows.Forms.CheckBox checkBox_LoadFromStoreAuto;
        private System.Windows.Forms.Button button_LoadFromStore;
        private System.Windows.Forms.Button button_EditContentsFromClipboard;
        private System.Windows.Forms.TabPage tabPage_Panel;
        private System.Windows.Forms.Button button_AddOnceJobPanel;
        private System.Windows.Forms.TabPage tabPage_MessageLog;
        private System.Windows.Forms.Label label_Return;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Timer;
        private System.Windows.Forms.TabControl tabControl_OnceJobPanel;
        private System.Windows.Forms.TabPage tabPage_OnceJobPanel;
        private System.Windows.Forms.TabPage tabPage_OnceJobPanel_Store;
        private System.Windows.Forms.TextBox textBox_OnceJobPanelStore;
        private System.Windows.Forms.VScrollBar vScrollBar_OnceJobList;
        private System.Windows.Forms.Panel panel_OnceJobListFrame;
        private System.Windows.Forms.Panel panel_OnceJobList;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TabControl tabControl_Main;
        public System.Windows.Forms.TabPage tabPage_View;
        private System.Windows.Forms.TabControl tabControl_JobView;
        private System.Windows.Forms.TabPage tabPage_JovView;
        private System.Windows.Forms.TabPage tabPage_EveryJobStore;
        private System.Windows.Forms.Button button_StatusListFrame_Sort;
    }
}

