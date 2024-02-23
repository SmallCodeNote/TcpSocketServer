using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace tcpClient
{
    public class PanelScrollControl
    {
        public VScrollBar vScrollBar;
        public HScrollBar hScrollBar;
        public Panel panel;
        public Panel panelFrame;

        private int vScrollBar_valueMax;
        private int hScrollBar_valueMax;

        public PanelScrollControl(Panel panelFrame, Panel panel, VScrollBar vScrollBar, HScrollBar hScrollBar = null)
        {
            this.panelFrame = panelFrame;
            this.panel = panel;
            this.vScrollBar = vScrollBar;
            this.hScrollBar = hScrollBar;

            this.vScrollBar.Scroll += new ScrollEventHandler(this.vScrollBar_Scroll);
            this.vScrollBar.ValueChanged += new EventHandler(this.vScrollBar_ValueChanged);

            this.panel.SizeChanged += new EventHandler(this.panel_SizeChanged);
            this.panel.MouseWheel += new MouseEventHandler(this.panel_MouseWheel);

            this.vScrollBar.LargeChange = vScrollBar.Maximum;
            this.vScrollBar.Enabled = false;

            if (hScrollBar != null)
            {
                this.vScrollBar.LargeChange = vScrollBar.Maximum;
                this.vScrollBar.Enabled = false;
            }
        }

        private void panel_SizeChanged(object sender, EventArgs e)
        {
            vScrollBar.Enabled = panel.Height > panelFrame.Height;
            vScrollBar.Maximum = panel.Height;
            vScrollBar.LargeChange = panelFrame.Height;
            vScrollBar_valueMax = vScrollBar.Maximum - vScrollBar.LargeChange;

            if (hScrollBar != null)
            {
                hScrollBar.Enabled = panel.Height > panelFrame.Height;
                hScrollBar.Maximum = panel.Height;
                hScrollBar.LargeChange = panelFrame.Height;
                hScrollBar_valueMax = hScrollBar.Maximum - hScrollBar.LargeChange;
            }

        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar_Operation();
        }

        private void vScrollBar_ValueChanged(object sender, EventArgs e)
        {
            vScrollBar_Operation();
        }

        private void vScrollBar_Operation()
        {
            panel.Top = -vScrollBar.Value;
            if (hScrollBar != null) panel.Left = -hScrollBar.Value;
            panel.Refresh();
        }

        private void panel_MouseWheel(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && hScrollBar != null)
            {
                int targetValue = hScrollBar.Value - e.Delta;

                targetValue = targetValue >= hScrollBar.Minimum ? targetValue : hScrollBar.Minimum;
                targetValue = targetValue <= hScrollBar.Maximum ? targetValue : hScrollBar.Maximum;

                hScrollBar.Value = targetValue;
            }
            else
            {
                int targetValue = vScrollBar.Value - e.Delta;

                targetValue = targetValue >= vScrollBar.Minimum ? targetValue : vScrollBar.Minimum;
                targetValue = targetValue <= vScrollBar_valueMax ? targetValue : vScrollBar_valueMax;

                vScrollBar.Value = targetValue;
            }

        }

    }

}
