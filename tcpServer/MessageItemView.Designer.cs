namespace tcpserver
{
    partial class MessageItemView
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
            this.groupBox_ClientName = new System.Windows.Forms.GroupBox();
            this.checkBox_check = new System.Windows.Forms.CheckBox();
            this.button_AllCheck = new System.Windows.Forms.Button();
            this.label_LastMessage = new System.Windows.Forms.Label();
            this.label_ElapsedTime = new System.Windows.Forms.Label();
            this.label_LastConnectTime = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.groupBox_ClientName.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ClientName
            // 
            this.groupBox_ClientName.Controls.Add(this.checkBox_check);
            this.groupBox_ClientName.Controls.Add(this.button_AllCheck);
            this.groupBox_ClientName.Controls.Add(this.label_LastMessage);
            this.groupBox_ClientName.Controls.Add(this.label_ElapsedTime);
            this.groupBox_ClientName.Controls.Add(this.label_LastConnectTime);
            this.groupBox_ClientName.Controls.Add(this.label_Status);
            this.groupBox_ClientName.Location = new System.Drawing.Point(5, 5);
            this.groupBox_ClientName.Name = "groupBox_ClientName";
            this.groupBox_ClientName.Size = new System.Drawing.Size(490, 95);
            this.groupBox_ClientName.TabIndex = 0;
            this.groupBox_ClientName.TabStop = false;
            this.groupBox_ClientName.Text = "ClientName";
            // 
            // checkBox_check
            // 
            this.checkBox_check.AutoSize = true;
            this.checkBox_check.Enabled = false;
            this.checkBox_check.Location = new System.Drawing.Point(9, 36);
            this.checkBox_check.Name = "checkBox_check";
            this.checkBox_check.Size = new System.Drawing.Size(68, 19);
            this.checkBox_check.TabIndex = 3;
            this.checkBox_check.Text = "check";
            this.checkBox_check.UseVisualStyleBackColor = true;
            this.checkBox_check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_AllCheck
            // 
            this.button_AllCheck.Location = new System.Drawing.Point(86, 34);
            this.button_AllCheck.Name = "button_AllCheck";
            this.button_AllCheck.Size = new System.Drawing.Size(77, 23);
            this.button_AllCheck.TabIndex = 2;
            this.button_AllCheck.Text = "AllCheck";
            this.button_AllCheck.UseVisualStyleBackColor = true;
            this.button_AllCheck.Click += new System.EventHandler(this.button_AllCheck_Click);
            // 
            // label_LastMessage
            // 
            this.label_LastMessage.Location = new System.Drawing.Point(169, 17);
            this.label_LastMessage.Name = "label_LastMessage";
            this.label_LastMessage.Size = new System.Drawing.Size(290, 72);
            this.label_LastMessage.TabIndex = 1;
            this.label_LastMessage.Text = "Message";
            // 
            // label_ElapsedTime
            // 
            this.label_ElapsedTime.AutoSize = true;
            this.label_ElapsedTime.Location = new System.Drawing.Point(6, 72);
            this.label_ElapsedTime.Name = "label_ElapsedTime";
            this.label_ElapsedTime.Size = new System.Drawing.Size(85, 15);
            this.label_ElapsedTime.TabIndex = 0;
            this.label_ElapsedTime.Text = "ElapsedTime";
            // 
            // label_LastConnectTime
            // 
            this.label_LastConnectTime.AutoSize = true;
            this.label_LastConnectTime.Location = new System.Drawing.Point(6, 57);
            this.label_LastConnectTime.Name = "label_LastConnectTime";
            this.label_LastConnectTime.Size = new System.Drawing.Size(120, 15);
            this.label_LastConnectTime.TabIndex = 0;
            this.label_LastConnectTime.Text = "LastConnectTime";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(6, 18);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(48, 15);
            this.label_Status.TabIndex = 0;
            this.label_Status.Text = "Status";
            // 
            // MessageItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_ClientName);
            this.Name = "MessageItemView";
            this.Size = new System.Drawing.Size(500, 100);
            this.groupBox_ClientName.ResumeLayout(false);
            this.groupBox_ClientName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_ElapsedTime;
        private System.Windows.Forms.Button button_AllCheck;
        public System.Windows.Forms.GroupBox groupBox_ClientName;
        public System.Windows.Forms.Label label_Status;
        public System.Windows.Forms.Label label_LastConnectTime;
        public System.Windows.Forms.Label label_LastMessage;
        private System.Windows.Forms.CheckBox checkBox_check;
    }
}
