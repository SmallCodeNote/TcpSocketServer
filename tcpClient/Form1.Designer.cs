namespace tcpClient
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
            this.label_Return = new System.Windows.Forms.Label();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Edit = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_JobName = new System.Windows.Forms.TextBox();
            this.tabPage_View = new System.Windows.Forms.TabPage();
            this.vScrollBar_StatusList = new System.Windows.Forms.VScrollBar();
            this.panel_StatusListFrame = new System.Windows.Forms.Panel();
            this.panel_StatusList = new System.Windows.Forms.Panel();
            this.timer_ClientViewUpdate = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_checkStyle = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_Edit.SuspendLayout();
            this.tabPage_View.SuspendLayout();
            this.panel_StatusListFrame.SuspendLayout();
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
            this.textBox_Address.Size = new System.Drawing.Size(220, 19);
            this.textBox_Address.TabIndex = 1;
            // 
            // textBox_PortNumber
            // 
            this.textBox_PortNumber.Location = new System.Drawing.Point(355, 115);
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
            // label_Return
            // 
            this.label_Return.Location = new System.Drawing.Point(132, 157);
            this.label_Return.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Return.Name = "label_Return";
            this.label_Return.Size = new System.Drawing.Size(359, 69);
            this.label_Return.TabIndex = 3;
            this.label_Return.Text = "...";
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
            this.label2.Location = new System.Drawing.Point(353, 102);
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
            this.button_AddSchedule.Location = new System.Drawing.Point(435, 115);
            this.button_AddSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddSchedule.Name = "button_AddSchedule";
            this.button_AddSchedule.Size = new System.Drawing.Size(56, 41);
            this.button_AddSchedule.TabIndex = 2;
            this.button_AddSchedule.Text = "Add";
            this.button_AddSchedule.UseVisualStyleBackColor = true;
            this.button_AddSchedule.Click += new System.EventHandler(this.button_AddSchedule_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Edit);
            this.tabControl1.Controls.Add(this.tabPage_View);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 394);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage_Edit
            // 
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
            this.tabPage_Edit.Controls.Add(this.button_AddSchedule);
            this.tabPage_Edit.Controls.Add(this.label_Return);
            this.tabPage_Edit.Controls.Add(this.label8);
            this.tabPage_Edit.Controls.Add(this.label1);
            this.tabPage_Edit.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Edit.Name = "tabPage_Edit";
            this.tabPage_Edit.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Edit.Size = new System.Drawing.Size(502, 368);
            this.tabPage_Edit.TabIndex = 0;
            this.tabPage_Edit.Text = "Edit";
            this.tabPage_Edit.UseVisualStyleBackColor = true;
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
            // tabPage_View
            // 
            this.tabPage_View.Controls.Add(this.vScrollBar_StatusList);
            this.tabPage_View.Controls.Add(this.panel_StatusListFrame);
            this.tabPage_View.Location = new System.Drawing.Point(4, 22);
            this.tabPage_View.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_View.Name = "tabPage_View";
            this.tabPage_View.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_View.Size = new System.Drawing.Size(502, 368);
            this.tabPage_View.TabIndex = 1;
            this.tabPage_View.Text = "View";
            this.tabPage_View.UseVisualStyleBackColor = true;
            this.tabPage_View.Enter += new System.EventHandler(this.tabPage_View_Enter);
            this.tabPage_View.Leave += new System.EventHandler(this.tabPage_View_Leave);
            // 
            // vScrollBar_StatusList
            // 
            this.vScrollBar_StatusList.Location = new System.Drawing.Point(411, 5);
            this.vScrollBar_StatusList.Name = "vScrollBar_StatusList";
            this.vScrollBar_StatusList.Size = new System.Drawing.Size(26, 358);
            this.vScrollBar_StatusList.TabIndex = 2;
            this.vScrollBar_StatusList.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_StatusList_Scroll);
            this.vScrollBar_StatusList.ValueChanged += new System.EventHandler(this.vScrollBar_StatusList_ValueChanged);
            // 
            // panel_StatusListFrame
            // 
            this.panel_StatusListFrame.Controls.Add(this.panel_StatusList);
            this.panel_StatusListFrame.Location = new System.Drawing.Point(8, 5);
            this.panel_StatusListFrame.Name = "panel_StatusListFrame";
            this.panel_StatusListFrame.Size = new System.Drawing.Size(400, 358);
            this.panel_StatusListFrame.TabIndex = 1;
            // 
            // panel_StatusList
            // 
            this.panel_StatusList.Location = new System.Drawing.Point(0, 0);
            this.panel_StatusList.Name = "panel_StatusList";
            this.panel_StatusList.Size = new System.Drawing.Size(400, 180);
            this.panel_StatusList.TabIndex = 0;
            this.panel_StatusList.SizeChanged += new System.EventHandler(this.panel_StatusList_SizeChanged);
            // 
            // timer_ClientViewUpdate
            // 
            this.timer_ClientViewUpdate.Tick += new System.EventHandler(this.timer_ClientViewUpdate_Tick);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 402);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Edit.ResumeLayout(false);
            this.tabPage_Edit.PerformLayout();
            this.tabPage_View.ResumeLayout(false);
            this.panel_StatusListFrame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ClientName;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_PortNumber;
        private System.Windows.Forms.Button button_SendMessage;
        private System.Windows.Forms.Label label_Return;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Edit;
        private System.Windows.Forms.TabPage tabPage_View;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_JobName;
        private System.Windows.Forms.VScrollBar vScrollBar_StatusList;
        private System.Windows.Forms.Panel panel_StatusListFrame;
        private System.Windows.Forms.Panel panel_StatusList;
        private System.Windows.Forms.Timer timer_ClientViewUpdate;
        private System.Windows.Forms.ComboBox comboBox_checkStyle;
        private System.Windows.Forms.Label label10;
    }
}

