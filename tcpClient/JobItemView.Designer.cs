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
            this.groupBox_Job.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Job
            // 
            this.groupBox_Job.Controls.Add(this.label_Next);
            this.groupBox_Job.Controls.Add(this.button_DeleteJob);
            this.groupBox_Job.Controls.Add(this.label1);
            this.groupBox_Job.Controls.Add(this.label_NeedCheck);
            this.groupBox_Job.Controls.Add(this.label_Parameter);
            this.groupBox_Job.Controls.Add(this.label_Message);
            this.groupBox_Job.Controls.Add(this.label_Status);
            this.groupBox_Job.Controls.Add(this.label_ClientName);
            this.groupBox_Job.Controls.Add(this.label_Address);
            this.groupBox_Job.Controls.Add(this.label_ScheduleUnitParam);
            this.groupBox_Job.Controls.Add(this.label_ScheduleUnit);
            this.groupBox_Job.Controls.Add(this.label_PortNumber);
            this.groupBox_Job.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Job.Name = "groupBox_Job";
            this.groupBox_Job.Size = new System.Drawing.Size(400, 175);
            this.groupBox_Job.TabIndex = 0;
            this.groupBox_Job.TabStop = false;
            this.groupBox_Job.Text = "JobName";
            // 
            // label_Next
            // 
            this.label_Next.AutoSize = true;
            this.label_Next.Location = new System.Drawing.Point(309, 15);
            this.label_Next.Name = "label_Next";
            this.label_Next.Size = new System.Drawing.Size(11, 12);
            this.label_Next.TabIndex = 2;
            this.label_Next.Text = "...";
            // 
            // button_DeleteJob
            // 
            this.button_DeleteJob.Location = new System.Drawing.Point(373, 10);
            this.button_DeleteJob.Name = "button_DeleteJob";
            this.button_DeleteJob.Size = new System.Drawing.Size(22, 22);
            this.button_DeleteJob.TabIndex = 1;
            this.button_DeleteJob.Text = "X";
            this.button_DeleteJob.UseVisualStyleBackColor = true;
            this.button_DeleteJob.Click += new System.EventHandler(this.button_DeleteJob_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "CheckStyle";
            // 
            // label_NeedCheck
            // 
            this.label_NeedCheck.AutoSize = true;
            this.label_NeedCheck.Location = new System.Drawing.Point(230, 59);
            this.label_NeedCheck.Name = "label_NeedCheck";
            this.label_NeedCheck.Size = new System.Drawing.Size(63, 12);
            this.label_NeedCheck.TabIndex = 0;
            this.label_NeedCheck.Text = "NeedCheck";
            // 
            // label_Parameter
            // 
            this.label_Parameter.AutoSize = true;
            this.label_Parameter.Location = new System.Drawing.Point(6, 82);
            this.label_Parameter.Name = "label_Parameter";
            this.label_Parameter.Size = new System.Drawing.Size(57, 12);
            this.label_Parameter.TabIndex = 0;
            this.label_Parameter.Text = "Parameter";
            // 
            // label_Message
            // 
            this.label_Message.Location = new System.Drawing.Point(6, 103);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(389, 65);
            this.label_Message.TabIndex = 0;
            this.label_Message.Text = "Message";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(110, 60);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(38, 12);
            this.label_Status.TabIndex = 0;
            this.label_Status.Text = "Status";
            // 
            // label_ClientName
            // 
            this.label_ClientName.AutoSize = true;
            this.label_ClientName.Location = new System.Drawing.Point(6, 60);
            this.label_ClientName.Name = "label_ClientName";
            this.label_ClientName.Size = new System.Drawing.Size(64, 12);
            this.label_ClientName.TabIndex = 0;
            this.label_ClientName.Text = "ClientName";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(6, 36);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(47, 12);
            this.label_Address.TabIndex = 0;
            this.label_Address.Text = "Address";
            // 
            // label_ScheduleUnitParam
            // 
            this.label_ScheduleUnitParam.AutoSize = true;
            this.label_ScheduleUnitParam.Location = new System.Drawing.Point(94, 15);
            this.label_ScheduleUnitParam.Name = "label_ScheduleUnitParam";
            this.label_ScheduleUnitParam.Size = new System.Drawing.Size(104, 12);
            this.label_ScheduleUnitParam.TabIndex = 0;
            this.label_ScheduleUnitParam.Text = "ScheduleUnitParam";
            // 
            // label_ScheduleUnit
            // 
            this.label_ScheduleUnit.AutoSize = true;
            this.label_ScheduleUnit.Location = new System.Drawing.Point(6, 15);
            this.label_ScheduleUnit.Name = "label_ScheduleUnit";
            this.label_ScheduleUnit.Size = new System.Drawing.Size(72, 12);
            this.label_ScheduleUnit.TabIndex = 0;
            this.label_ScheduleUnit.Text = "ScheduleUnit";
            // 
            // label_PortNumber
            // 
            this.label_PortNumber.AutoSize = true;
            this.label_PortNumber.Location = new System.Drawing.Point(110, 36);
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
            // JobItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Job);
            this.Name = "JobItemView";
            this.Size = new System.Drawing.Size(400, 180);
            this.groupBox_Job.ResumeLayout(false);
            this.groupBox_Job.PerformLayout();
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
    }
}
