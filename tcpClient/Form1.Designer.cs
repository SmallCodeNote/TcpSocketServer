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
            this.checkBox_NeedCheck = new System.Windows.Forms.CheckBox();
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
            this.tabPage_View = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ClientName
            // 
            this.textBox_ClientName.Location = new System.Drawing.Point(18, 30);
            this.textBox_ClientName.Name = "textBox_ClientName";
            this.textBox_ClientName.Size = new System.Drawing.Size(101, 22);
            this.textBox_ClientName.TabIndex = 0;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(173, 30);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(292, 22);
            this.textBox_Address.TabIndex = 1;
            // 
            // textBox_PortNumber
            // 
            this.textBox_PortNumber.Location = new System.Drawing.Point(471, 30);
            this.textBox_PortNumber.Name = "textBox_PortNumber";
            this.textBox_PortNumber.Size = new System.Drawing.Size(100, 22);
            this.textBox_PortNumber.TabIndex = 1;
            // 
            // button_SendMessage
            // 
            this.button_SendMessage.Location = new System.Drawing.Point(577, 271);
            this.button_SendMessage.Name = "button_SendMessage";
            this.button_SendMessage.Size = new System.Drawing.Size(75, 23);
            this.button_SendMessage.TabIndex = 2;
            this.button_SendMessage.Text = "Send";
            this.button_SendMessage.UseVisualStyleBackColor = true;
            this.button_SendMessage.Click += new System.EventHandler(this.button_SendMessage_Click);
            // 
            // label_Return
            // 
            this.label_Return.Location = new System.Drawing.Point(173, 55);
            this.label_Return.Name = "label_Return";
            this.label_Return.Size = new System.Drawing.Size(479, 86);
            this.label_Return.TabIndex = 3;
            this.label_Return.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "ClientName";
            // 
            // textBox_Message
            // 
            this.textBox_Message.Location = new System.Drawing.Point(18, 144);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(634, 49);
            this.textBox_Message.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status";
            // 
            // checkBox_NeedCheck
            // 
            this.checkBox_NeedCheck.AutoSize = true;
            this.checkBox_NeedCheck.Location = new System.Drawing.Point(18, 102);
            this.checkBox_NeedCheck.Name = "checkBox_NeedCheck";
            this.checkBox_NeedCheck.Size = new System.Drawing.Size(103, 19);
            this.checkBox_NeedCheck.TabIndex = 5;
            this.checkBox_NeedCheck.Text = "NeedCheck";
            this.checkBox_NeedCheck.UseVisualStyleBackColor = true;
            // 
            // textBox_Parameter
            // 
            this.textBox_Parameter.Location = new System.Drawing.Point(18, 216);
            this.textBox_Parameter.Multiline = true;
            this.textBox_Parameter.Name = "textBox_Parameter";
            this.textBox_Parameter.Size = new System.Drawing.Size(634, 49);
            this.textBox_Parameter.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
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
            this.comboBox_Status.Location = new System.Drawing.Point(18, 73);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Status.TabIndex = 6;
            // 
            // comboBox_ScheduleUnit
            // 
            this.comboBox_ScheduleUnit.FormattingEnabled = true;
            this.comboBox_ScheduleUnit.Items.AddRange(new object[] {
            "EveryDays",
            "EveryHours",
            "EverySeconds"});
            this.comboBox_ScheduleUnit.Location = new System.Drawing.Point(18, 311);
            this.comboBox_ScheduleUnit.Name = "comboBox_ScheduleUnit";
            this.comboBox_ScheduleUnit.Size = new System.Drawing.Size(163, 23);
            this.comboBox_ScheduleUnit.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Interval";
            // 
            // textBox_ScheduleUnitParam
            // 
            this.textBox_ScheduleUnitParam.Location = new System.Drawing.Point(187, 312);
            this.textBox_ScheduleUnitParam.Name = "textBox_ScheduleUnitParam";
            this.textBox_ScheduleUnitParam.Size = new System.Drawing.Size(465, 22);
            this.textBox_ScheduleUnitParam.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "At";
            // 
            // button_AddSchedule
            // 
            this.button_AddSchedule.Location = new System.Drawing.Point(577, 12);
            this.button_AddSchedule.Name = "button_AddSchedule";
            this.button_AddSchedule.Size = new System.Drawing.Size(75, 41);
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 418);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage_Edit
            // 
            this.tabPage_Edit.Controls.Add(this.label3);
            this.tabPage_Edit.Controls.Add(this.comboBox_ScheduleUnit);
            this.tabPage_Edit.Controls.Add(this.textBox_ClientName);
            this.tabPage_Edit.Controls.Add(this.comboBox_Status);
            this.tabPage_Edit.Controls.Add(this.textBox_Message);
            this.tabPage_Edit.Controls.Add(this.checkBox_NeedCheck);
            this.tabPage_Edit.Controls.Add(this.textBox_Parameter);
            this.tabPage_Edit.Controls.Add(this.label2);
            this.tabPage_Edit.Controls.Add(this.textBox_Address);
            this.tabPage_Edit.Controls.Add(this.label6);
            this.tabPage_Edit.Controls.Add(this.textBox_ScheduleUnitParam);
            this.tabPage_Edit.Controls.Add(this.label4);
            this.tabPage_Edit.Controls.Add(this.textBox_PortNumber);
            this.tabPage_Edit.Controls.Add(this.label7);
            this.tabPage_Edit.Controls.Add(this.button_SendMessage);
            this.tabPage_Edit.Controls.Add(this.label5);
            this.tabPage_Edit.Controls.Add(this.button_AddSchedule);
            this.tabPage_Edit.Controls.Add(this.label_Return);
            this.tabPage_Edit.Controls.Add(this.label8);
            this.tabPage_Edit.Controls.Add(this.label1);
            this.tabPage_Edit.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Edit.Name = "tabPage_Edit";
            this.tabPage_Edit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Edit.Size = new System.Drawing.Size(672, 389);
            this.tabPage_Edit.TabIndex = 0;
            this.tabPage_Edit.Text = "Edit";
            this.tabPage_Edit.UseVisualStyleBackColor = true;
            // 
            // tabPage_View
            // 
            this.tabPage_View.Location = new System.Drawing.Point(4, 25);
            this.tabPage_View.Name = "tabPage_View";
            this.tabPage_View.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_View.Size = new System.Drawing.Size(672, 389);
            this.tabPage_View.TabIndex = 1;
            this.tabPage_View.Text = "View";
            this.tabPage_View.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 428);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Edit.ResumeLayout(false);
            this.tabPage_Edit.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBox_NeedCheck;
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
    }
}

