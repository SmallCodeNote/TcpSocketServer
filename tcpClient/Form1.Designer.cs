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
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_PortNumber = new System.Windows.Forms.TextBox();
            this.button_SendMessage = new System.Windows.Forms.Button();
            this.label_Return = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Message
            // 
            this.textBox_Message.Location = new System.Drawing.Point(12, 12);
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(319, 22);
            this.textBox_Message.TabIndex = 0;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(12, 53);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(132, 22);
            this.textBox_Address.TabIndex = 1;
            // 
            // textBox_PortNumber
            // 
            this.textBox_PortNumber.Location = new System.Drawing.Point(150, 53);
            this.textBox_PortNumber.Name = "textBox_PortNumber";
            this.textBox_PortNumber.Size = new System.Drawing.Size(100, 22);
            this.textBox_PortNumber.TabIndex = 1;
            // 
            // button_SendMessage
            // 
            this.button_SendMessage.Location = new System.Drawing.Point(256, 52);
            this.button_SendMessage.Name = "button_SendMessage";
            this.button_SendMessage.Size = new System.Drawing.Size(75, 23);
            this.button_SendMessage.TabIndex = 2;
            this.button_SendMessage.Text = "Send";
            this.button_SendMessage.UseVisualStyleBackColor = true;
            this.button_SendMessage.Click += new System.EventHandler(this.button_SendMessage_Click);
            // 
            // label_Return
            // 
            this.label_Return.AutoSize = true;
            this.label_Return.Location = new System.Drawing.Point(12, 95);
            this.label_Return.Name = "label_Return";
            this.label_Return.Size = new System.Drawing.Size(16, 15);
            this.label_Return.TabIndex = 3;
            this.label_Return.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.label_Return);
            this.Controls.Add(this.button_SendMessage);
            this.Controls.Add(this.textBox_PortNumber);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_Message);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_PortNumber;
        private System.Windows.Forms.Button button_SendMessage;
        private System.Windows.Forms.Label label_Return;
    }
}

