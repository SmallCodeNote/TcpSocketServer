﻿namespace tcpClient_HTTPcheck
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
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_ClientList = new System.Windows.Forms.TabPage();
            this.tabPage_MessageSetting = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl_ClientList = new System.Windows.Forms.TabControl();
            this.tabPage_ClientListView = new System.Windows.Forms.TabPage();
            this.tabPage_ClientListText = new System.Windows.Forms.TabPage();
            this.textBox_ClientList = new System.Windows.Forms.TextBox();
            this.panel_ClietListView_Frame = new System.Windows.Forms.Panel();
            this.panel_ClietListView_Form = new System.Windows.Forms.Panel();
            this.groupBox_KeyList = new System.Windows.Forms.GroupBox();
            this.label_Key1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Message1 = new System.Windows.Forms.TextBox();
            this.textBox_Message2 = new System.Windows.Forms.TextBox();
            this.textBox_Message3 = new System.Windows.Forms.TextBox();
            this.tabPage_SystemSetting = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_ClientList.SuspendLayout();
            this.tabPage_MessageSetting.SuspendLayout();
            this.tabControl_ClientList.SuspendLayout();
            this.tabPage_ClientListView.SuspendLayout();
            this.tabPage_ClientListText.SuspendLayout();
            this.panel_ClietListView_Frame.SuspendLayout();
            this.groupBox_KeyList.SuspendLayout();
            this.tabPage_SystemSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_ClientList);
            this.tabControl_Main.Controls.Add(this.tabPage_MessageSetting);
            this.tabControl_Main.Controls.Add(this.tabPage_SystemSetting);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(536, 425);
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_ClientList
            // 
            this.tabPage_ClientList.Controls.Add(this.tabControl_ClientList);
            this.tabPage_ClientList.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ClientList.Name = "tabPage_ClientList";
            this.tabPage_ClientList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ClientList.Size = new System.Drawing.Size(528, 399);
            this.tabPage_ClientList.TabIndex = 0;
            this.tabPage_ClientList.Text = "ClientList";
            this.tabPage_ClientList.UseVisualStyleBackColor = true;
            // 
            // tabPage_MessageSetting
            // 
            this.tabPage_MessageSetting.Controls.Add(this.textBox_Message3);
            this.tabPage_MessageSetting.Controls.Add(this.textBox_Message2);
            this.tabPage_MessageSetting.Controls.Add(this.textBox_Message1);
            this.tabPage_MessageSetting.Controls.Add(this.groupBox_KeyList);
            this.tabPage_MessageSetting.Location = new System.Drawing.Point(4, 22);
            this.tabPage_MessageSetting.Name = "tabPage_MessageSetting";
            this.tabPage_MessageSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MessageSetting.Size = new System.Drawing.Size(528, 399);
            this.tabPage_MessageSetting.TabIndex = 1;
            this.tabPage_MessageSetting.Text = "MessageSetting";
            this.tabPage_MessageSetting.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(536, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl_ClientList
            // 
            this.tabControl_ClientList.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl_ClientList.Controls.Add(this.tabPage_ClientListView);
            this.tabControl_ClientList.Controls.Add(this.tabPage_ClientListText);
            this.tabControl_ClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_ClientList.Location = new System.Drawing.Point(3, 3);
            this.tabControl_ClientList.Name = "tabControl_ClientList";
            this.tabControl_ClientList.SelectedIndex = 0;
            this.tabControl_ClientList.Size = new System.Drawing.Size(522, 393);
            this.tabControl_ClientList.TabIndex = 0;
            // 
            // tabPage_ClientListView
            // 
            this.tabPage_ClientListView.Controls.Add(this.panel_ClietListView_Frame);
            this.tabPage_ClientListView.Location = new System.Drawing.Point(4, 4);
            this.tabPage_ClientListView.Name = "tabPage_ClientListView";
            this.tabPage_ClientListView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ClientListView.Size = new System.Drawing.Size(514, 367);
            this.tabPage_ClientListView.TabIndex = 0;
            this.tabPage_ClientListView.Text = "View";
            this.tabPage_ClientListView.UseVisualStyleBackColor = true;
            this.tabPage_ClientListView.Enter += new System.EventHandler(this.tabPage_ClientListView_Enter);
            // 
            // tabPage_ClientListText
            // 
            this.tabPage_ClientListText.Controls.Add(this.textBox_ClientList);
            this.tabPage_ClientListText.Location = new System.Drawing.Point(4, 4);
            this.tabPage_ClientListText.Name = "tabPage_ClientListText";
            this.tabPage_ClientListText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ClientListText.Size = new System.Drawing.Size(514, 367);
            this.tabPage_ClientListText.TabIndex = 1;
            this.tabPage_ClientListText.Text = "Text";
            this.tabPage_ClientListText.UseVisualStyleBackColor = true;
            // 
            // textBox_ClientList
            // 
            this.textBox_ClientList.AcceptsReturn = true;
            this.textBox_ClientList.AcceptsTab = true;
            this.textBox_ClientList.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_ClientList.Location = new System.Drawing.Point(3, 3);
            this.textBox_ClientList.Multiline = true;
            this.textBox_ClientList.Name = "textBox_ClientList";
            this.textBox_ClientList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ClientList.Size = new System.Drawing.Size(461, 361);
            this.textBox_ClientList.TabIndex = 0;
            this.textBox_ClientList.WordWrap = false;
            // 
            // panel_ClietListView_Frame
            // 
            this.panel_ClietListView_Frame.AutoScroll = true;
            this.panel_ClietListView_Frame.Controls.Add(this.panel_ClietListView_Form);
            this.panel_ClietListView_Frame.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ClietListView_Frame.Location = new System.Drawing.Point(3, 3);
            this.panel_ClietListView_Frame.Name = "panel_ClietListView_Frame";
            this.panel_ClietListView_Frame.Size = new System.Drawing.Size(465, 361);
            this.panel_ClietListView_Frame.TabIndex = 0;
            // 
            // panel_ClietListView_Form
            // 
            this.panel_ClietListView_Form.Location = new System.Drawing.Point(0, 0);
            this.panel_ClietListView_Form.Name = "panel_ClietListView_Form";
            this.panel_ClietListView_Form.Size = new System.Drawing.Size(419, 97);
            this.panel_ClietListView_Form.TabIndex = 0;
            // 
            // groupBox_KeyList
            // 
            this.groupBox_KeyList.Controls.Add(this.label3);
            this.groupBox_KeyList.Controls.Add(this.label2);
            this.groupBox_KeyList.Controls.Add(this.label1);
            this.groupBox_KeyList.Controls.Add(this.label_Key1);
            this.groupBox_KeyList.Location = new System.Drawing.Point(6, 6);
            this.groupBox_KeyList.Name = "groupBox_KeyList";
            this.groupBox_KeyList.Size = new System.Drawing.Size(514, 37);
            this.groupBox_KeyList.TabIndex = 0;
            this.groupBox_KeyList.TabStop = false;
            this.groupBox_KeyList.Text = "KeyList";
            // 
            // label_Key1
            // 
            this.label_Key1.AutoSize = true;
            this.label_Key1.Location = new System.Drawing.Point(6, 15);
            this.label_Key1.Name = "label_Key1";
            this.label_Key1.Size = new System.Drawing.Size(70, 12);
            this.label_Key1.TabIndex = 0;
            this.label_Key1.Text = "{ClientName}";
            this.label_Key1.Click += new System.EventHandler(this.label_Key_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "{LockTime}";
            this.label1.Click += new System.EventHandler(this.label_Key_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "{LockFrom}";
            this.label2.Click += new System.EventHandler(this.label_Key_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "{ResetTime}";
            this.label3.Click += new System.EventHandler(this.label_Key_Click);
            // 
            // textBox_Message1
            // 
            this.textBox_Message1.Location = new System.Drawing.Point(8, 146);
            this.textBox_Message1.Multiline = true;
            this.textBox_Message1.Name = "textBox_Message1";
            this.textBox_Message1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Message1.Size = new System.Drawing.Size(512, 54);
            this.textBox_Message1.TabIndex = 1;
            // 
            // textBox_Message2
            // 
            this.textBox_Message2.Location = new System.Drawing.Point(8, 237);
            this.textBox_Message2.Multiline = true;
            this.textBox_Message2.Name = "textBox_Message2";
            this.textBox_Message2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Message2.Size = new System.Drawing.Size(512, 54);
            this.textBox_Message2.TabIndex = 1;
            // 
            // textBox_Message3
            // 
            this.textBox_Message3.Location = new System.Drawing.Point(8, 330);
            this.textBox_Message3.Multiline = true;
            this.textBox_Message3.Name = "textBox_Message3";
            this.textBox_Message3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Message3.Size = new System.Drawing.Size(512, 54);
            this.textBox_Message3.TabIndex = 1;
            // 
            // tabPage_SystemSetting
            // 
            this.tabPage_SystemSetting.Controls.Add(this.textBox1);
            this.tabPage_SystemSetting.Controls.Add(this.label4);
            this.tabPage_SystemSetting.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SystemSetting.Name = "tabPage_SystemSetting";
            this.tabPage_SystemSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SystemSetting.Size = new System.Drawing.Size(528, 399);
            this.tabPage_SystemSetting.TabIndex = 2;
            this.tabPage_SystemSetting.Text = "SystemSetting";
            this.tabPage_SystemSetting.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "PortNumber";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl_Main);
            this.Name = "Form1";
            this.Text = "tcpClient_HTTPcheck";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_ClientList.ResumeLayout(false);
            this.tabPage_MessageSetting.ResumeLayout(false);
            this.tabPage_MessageSetting.PerformLayout();
            this.tabControl_ClientList.ResumeLayout(false);
            this.tabPage_ClientListView.ResumeLayout(false);
            this.tabPage_ClientListText.ResumeLayout(false);
            this.tabPage_ClientListText.PerformLayout();
            this.panel_ClietListView_Frame.ResumeLayout(false);
            this.groupBox_KeyList.ResumeLayout(false);
            this.groupBox_KeyList.PerformLayout();
            this.tabPage_SystemSetting.ResumeLayout(false);
            this.tabPage_SystemSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_ClientList;
        private System.Windows.Forms.TabPage tabPage_MessageSetting;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl_ClientList;
        private System.Windows.Forms.TabPage tabPage_ClientListView;
        private System.Windows.Forms.Panel panel_ClietListView_Frame;
        private System.Windows.Forms.TabPage tabPage_ClientListText;
        private System.Windows.Forms.TextBox textBox_ClientList;
        private System.Windows.Forms.Panel panel_ClietListView_Form;
        private System.Windows.Forms.GroupBox groupBox_KeyList;
        private System.Windows.Forms.Label label_Key1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Message3;
        private System.Windows.Forms.TextBox textBox_Message2;
        private System.Windows.Forms.TextBox textBox_Message1;
        private System.Windows.Forms.TabPage tabPage_SystemSetting;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}
