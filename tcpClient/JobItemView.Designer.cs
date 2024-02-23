namespace tcpClient
{
    partial class JobItemView
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_Job = new System.Windows.Forms.GroupBox();
            this.label_Next = new System.Windows.Forms.Label();
            this.button_DeleteJob = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_NeedCheck = new System.Windows.Forms.Label();
            this.label_Parameter = new System.Windows.Forms.Label();
            this.label_Message = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_ClientName = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_ScheduleUnitParam = new System.Windows.Forms.Label();
            this.label_ScheduleUnit = new System.Windows.Forms.Label();
            this.label_PortNumber = new System.Windows.Forms.Label();
            this.timer_update = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox_Job.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Job
            // 
            this.groupBox_Job.Controls.Add(this.tabControl1);
            this.groupBox_Job.Controls.Add(this.label_Next);
            this.groupBox_Job.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox_Job.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Job.Name = "groupBox_Job";
            this.groupBox_Job.Size = new System.Drawing.Size(400, 100);
            this.groupBox_Job.TabIndex = 0;
            this.groupBox_Job.TabStop = false;
            this.groupBox_Job.Text = "JobName";
            // 
            // label_Next
            // 
            this.label_Next.AutoSize = true;
            this.label_Next.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Next.Location = new System.Drawing.Point(321, 0);
            this.label_Next.Name = "label_Next";
            this.label_Next.Size = new System.Drawing.Size(19, 15);
            this.label_Next.TabIndex = 2;
            this.label_Next.Text = "...";
            // 
            // button_DeleteJob
            // 
            this.button_DeleteJob.Location = new System.Drawing.Point(332, -2);
            this.button_DeleteJob.Name = "button_DeleteJob";
            this.button_DeleteJob.Size = new System.Drawing.Size(51, 22);
            this.button_DeleteJob.TabIndex = 1;
            this.button_DeleteJob.Text = "X";
            this.button_DeleteJob.UseVisualStyleBackColor = true;
            this.button_DeleteJob.Click += new System.EventHandler(this.button_DeleteJob_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "CheckStyle";
            // 
            // label_NeedCheck
            // 
            this.label_NeedCheck.AutoSize = true;
            this.label_NeedCheck.Location = new System.Drawing.Point(230, 12);
            this.label_NeedCheck.Name = "label_NeedCheck";
            this.label_NeedCheck.Size = new System.Drawing.Size(63, 12);
            this.label_NeedCheck.TabIndex = 0;
            this.label_NeedCheck.Text = "NeedCheck";
            // 
            // label_Parameter
            // 
            this.label_Parameter.AutoSize = true;
            this.label_Parameter.Location = new System.Drawing.Point(7, 31);
            this.label_Parameter.Name = "label_Parameter";
            this.label_Parameter.Size = new System.Drawing.Size(57, 12);
            this.label_Parameter.TabIndex = 0;
            this.label_Parameter.Text = "Parameter";
            // 
            // label_Message
            // 
            this.label_Message.Location = new System.Drawing.Point(6, 19);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(294, 26);
            this.label_Message.TabIndex = 0;
            this.label_Message.Text = "Message";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(111, 16);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(38, 12);
            this.label_Status.TabIndex = 0;
            this.label_Status.Text = "Status";
            // 
            // label_ClientName
            // 
            this.label_ClientName.AutoSize = true;
            this.label_ClientName.Location = new System.Drawing.Point(7, 16);
            this.label_ClientName.Name = "label_ClientName";
            this.label_ClientName.Size = new System.Drawing.Size(64, 12);
            this.label_ClientName.TabIndex = 0;
            this.label_ClientName.Text = "ClientName";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(6, 0);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(47, 12);
            this.label_Address.TabIndex = 0;
            this.label_Address.Text = "Address";
            // 
            // label_ScheduleUnitParam
            // 
            this.label_ScheduleUnitParam.AutoSize = true;
            this.label_ScheduleUnitParam.Location = new System.Drawing.Point(118, 3);
            this.label_ScheduleUnitParam.Name = "label_ScheduleUnitParam";
            this.label_ScheduleUnitParam.Size = new System.Drawing.Size(104, 12);
            this.label_ScheduleUnitParam.TabIndex = 0;
            this.label_ScheduleUnitParam.Text = "ScheduleUnitParam";
            // 
            // label_ScheduleUnit
            // 
            this.label_ScheduleUnit.AutoSize = true;
            this.label_ScheduleUnit.Location = new System.Drawing.Point(6, 3);
            this.label_ScheduleUnit.Name = "label_ScheduleUnit";
            this.label_ScheduleUnit.Size = new System.Drawing.Size(72, 12);
            this.label_ScheduleUnit.TabIndex = 0;
            this.label_ScheduleUnit.Text = "ScheduleUnit";
            // 
            // label_PortNumber
            // 
            this.label_PortNumber.AutoSize = true;
            this.label_PortNumber.Location = new System.Drawing.Point(110, 0);
            this.label_PortNumber.Name = "label_PortNumber";
            this.label_PortNumber.Size = new System.Drawing.Size(65, 12);
            this.label_PortNumber.TabIndex = 0;
            this.label_PortNumber.Text = "PortNumber";
            // 
            // timer_update
            // 
            this.timer_update.Interval = 1000;
            this.timer_update.Tick += new System.EventHandler(this.timer_update_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl1.Location = new System.Drawing.Point(5, 18);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(391, 76);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_DeleteJob);
            this.tabPage1.Controls.Add(this.label_ScheduleUnitParam);
            this.tabPage1.Controls.Add(this.label_ScheduleUnit);
            this.tabPage1.Controls.Add(this.label_Message);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(383, 50);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label_Parameter);
            this.tabPage2.Controls.Add(this.label_NeedCheck);
            this.tabPage2.Controls.Add(this.label_Address);
            this.tabPage2.Controls.Add(this.label_Status);
            this.tabPage2.Controls.Add(this.label_PortNumber);
            this.tabPage2.Controls.Add(this.label_ClientName);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(383, 50);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // JobItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Job);
            this.Name = "JobItemView";
            this.Size = new System.Drawing.Size(400, 105);
            this.groupBox_Job.ResumeLayout(false);
            this.groupBox_Job.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Job;
        private System.Windows.Forms.Label label_PortNumber;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_NeedCheck;
        private System.Windows.Forms.Label label_Parameter;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_ClientName;
        private System.Windows.Forms.Label label_ScheduleUnitParam;
        private System.Windows.Forms.Label label_ScheduleUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_DeleteJob;
        private System.Windows.Forms.Timer timer_update;
        private System.Windows.Forms.Label label_Next;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
