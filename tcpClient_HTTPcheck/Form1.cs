using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinFormStringCnvClass;

namespace tcpClient_HTTPcheck
{
    public partial class Form1 : Form
    {
        string thisExeDirPath;
        public Form1()
        {
            InitializeComponent();
            thisExeDirPath = Path.GetDirectoryName(Application.ExecutablePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TEXT|*.txt";
            if (false && ofd.ShowDialog() == DialogResult.OK)
            {
                WinFormStringCnv.setControlFromString(this, File.ReadAllText(ofd.FileName));
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                if (File.Exists(paramFilename))
                {
                    WinFormStringCnv.setControlFromString(this, File.ReadAllText(paramFilename));
                }
            }
            updateClientListView();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string FormContents = WinFormStringCnv.ToString(this);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TEXT|*.txt";

            if (false && sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, FormContents);
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                File.WriteAllText(paramFilename, FormContents);
            }

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            tabControl_Main.Height = this.Height - 60;
        }

        private void updateClientListView()
        {
            string[] Lines = textBox_ClientList.Text.Replace("\r\n", "\n").Trim('\n').Split('\n');

            int panelTop = 0;

            panel_ClietListView_Form.Controls.Clear();
            foreach (var Line in Lines)
            {
                ClientListView clientListView = new ClientListView(Line);
                clientListView.Top = panelTop;
                panel_ClietListView_Form.Controls.Add(clientListView);

                panelTop += clientListView.Height;

            }
            panel_ClietListView_Form.Height = panelTop;
        }

        private void tabPage_ClientListView_Enter(object sender, EventArgs e)
        {
            updateClientListView();
        }

        private void label_Key1_Click(object sender, EventArgs e)
        {
            Label src = (Label)sender;
            Clipboard.SetText(src.Text);
        }
        private void label_Key_Click(object sender, EventArgs e)
        {
            Label src = (Label)sender;
            Clipboard.SetText(src.Text);
        }
    }
}
