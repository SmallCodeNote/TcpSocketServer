﻿namespace tcpClient_HTTPcheck
{
    partial class ClientListView
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
            this.groupBox_ClientListViewTitle = new System.Windows.Forms.GroupBox();
            this.panel_Frame = new System.Windows.Forms.Panel();
            this.button_PanelShift = new System.Windows.Forms.Button();
            this.panel_Form = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Lock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_LockedTime = new System.Windows.Forms.Label();
            this.label_ResetTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_LockedFrom = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.timer_TimeLabelUpdate = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_LockTime = new System.Windows.Forms.TextBox();
            this.label_RemainingTime = new System.Windows.Forms.Label();
            this.groupBox_ClientListViewTitle.SuspendLayout();
            this.panel_Frame.SuspendLayout();
            this.panel_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ClientListViewTitle
            // 
            this.groupBox_ClientListViewTitle.Controls.Add(this.button_PanelShift);
            this.groupBox_ClientListViewTitle.Controls.Add(this.panel_Frame);
            this.groupBox_ClientListViewTitle.Location = new System.Drawing.Point(3, 3);
            this.groupBox_ClientListViewTitle.Name = "groupBox_ClientListViewTitle";
            this.groupBox_ClientListViewTitle.Size = new System.Drawing.Size(431, 90);
            this.groupBox_ClientListViewTitle.TabIndex = 0;
            this.groupBox_ClientListViewTitle.TabStop = false;
            this.groupBox_ClientListViewTitle.Text = "Title";
            // 
            // panel_Frame
            // 
            this.panel_Frame.Controls.Add(this.panel_Form);
            this.panel_Frame.Location = new System.Drawing.Point(39, 18);
            this.panel_Frame.Name = "panel_Frame";
            this.panel_Frame.Size = new System.Drawing.Size(376, 67);
            this.panel_Frame.TabIndex = 0;
            // 
            // button_PanelShift
            // 
            this.button_PanelShift.Location = new System.Drawing.Point(9, 18);
            this.button_PanelShift.Name = "button_PanelShift";
            this.button_PanelShift.Size = new System.Drawing.Size(24, 67);
            this.button_PanelShift.TabIndex = 1;
            this.button_PanelShift.Text = "<";
            this.button_PanelShift.UseVisualStyleBackColor = true;
            this.button_PanelShift.Click += new System.EventHandler(this.button_PanelShift_Click);
            // 
            // panel_Form
            // 
            this.panel_Form.Controls.Add(this.textBox_Name);
            this.panel_Form.Controls.Add(this.textBox_LockTime);
            this.panel_Form.Controls.Add(this.textBox_Address);
            this.panel_Form.Controls.Add(this.button_Lock);
            this.panel_Form.Controls.Add(this.label_LockedFrom);
            this.panel_Form.Controls.Add(this.label5);
            this.panel_Form.Controls.Add(this.label_RemainingTime);
            this.panel_Form.Controls.Add(this.label_ResetTime);
            this.panel_Form.Controls.Add(this.label6);
            this.panel_Form.Controls.Add(this.label4);
            this.panel_Form.Controls.Add(this.label3);
            this.panel_Form.Controls.Add(this.label_LockedTime);
            this.panel_Form.Controls.Add(this.label2);
            this.panel_Form.Controls.Add(this.label1);
            this.panel_Form.Location = new System.Drawing.Point(0, 0);
            this.panel_Form.Name = "panel_Form";
            this.panel_Form.Size = new System.Drawing.Size(361, 157);
            this.panel_Form.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "LockedTime";
            // 
            // button_Lock
            // 
            this.button_Lock.Location = new System.Drawing.Point(6, 3);
            this.button_Lock.Name = "button_Lock";
            this.button_Lock.Size = new System.Drawing.Size(45, 64);
            this.button_Lock.TabIndex = 1;
            this.button_Lock.UseVisualStyleBackColor = true;
            this.button_Lock.Click += new System.EventHandler(this.button_Lock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ResetTime";
            // 
            // label_LockedTime
            // 
            this.label_LockedTime.AutoSize = true;
            this.label_LockedTime.Location = new System.Drawing.Point(136, 10);
            this.label_LockedTime.Name = "label_LockedTime";
            this.label_LockedTime.Size = new System.Drawing.Size(66, 12);
            this.label_LockedTime.TabIndex = 0;
            this.label_LockedTime.Text = "LockedTime";
            // 
            // label_ResetTime
            // 
            this.label_ResetTime.AutoSize = true;
            this.label_ResetTime.Location = new System.Drawing.Point(136, 29);
            this.label_ResetTime.Name = "label_ResetTime";
            this.label_ResetTime.Size = new System.Drawing.Size(60, 12);
            this.label_ResetTime.TabIndex = 0;
            this.label_ResetTime.Text = "ResetTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "LockedFrom";
            // 
            // label_LockedFrom
            // 
            this.label_LockedFrom.AutoSize = true;
            this.label_LockedFrom.Location = new System.Drawing.Point(136, 48);
            this.label_LockedFrom.Name = "label_LockedFrom";
            this.label_LockedFrom.Size = new System.Drawing.Size(67, 12);
            this.label_LockedFrom.TabIndex = 0;
            this.label_LockedFrom.Text = "LockedFrom";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(15, 89);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(143, 19);
            this.textBox_Address.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(164, 89);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(192, 19);
            this.textBox_Name.TabIndex = 2;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // timer_TimeLabelUpdate
            // 
            this.timer_TimeLabelUpdate.Interval = 1000;
            this.timer_TimeLabelUpdate.Tick += new System.EventHandler(this.timer_TimeLabelUpdate_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "LockTime";
            // 
            // textBox_LockTime
            // 
            this.textBox_LockTime.Location = new System.Drawing.Point(73, 112);
            this.textBox_LockTime.Name = "textBox_LockTime";
            this.textBox_LockTime.Size = new System.Drawing.Size(85, 19);
            this.textBox_LockTime.TabIndex = 2;
            this.textBox_LockTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_RemainingTime
            // 
            this.label_RemainingTime.AutoSize = true;
            this.label_RemainingTime.Location = new System.Drawing.Point(275, 27);
            this.label_RemainingTime.Name = "label_RemainingTime";
            this.label_RemainingTime.Size = new System.Drawing.Size(11, 12);
            this.label_RemainingTime.TabIndex = 0;
            this.label_RemainingTime.Text = "...";
            // 
            // ClientListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_ClientListViewTitle);
            this.Name = "ClientListView";
            this.Size = new System.Drawing.Size(449, 100);
            this.groupBox_ClientListViewTitle.ResumeLayout(false);
            this.panel_Frame.ResumeLayout(false);
            this.panel_Form.ResumeLayout(false);
            this.panel_Form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ClientListViewTitle;
        private System.Windows.Forms.Button button_PanelShift;
        private System.Windows.Forms.Panel panel_Frame;
        private System.Windows.Forms.Panel panel_Form;
        private System.Windows.Forms.Button button_Lock;
        private System.Windows.Forms.Label label_LockedFrom;
        private System.Windows.Forms.Label label_ResetTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_LockedTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer_TimeLabelUpdate;
        private System.Windows.Forms.TextBox textBox_LockTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_RemainingTime;
    }
}
