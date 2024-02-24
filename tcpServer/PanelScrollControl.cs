using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace PanelScroll
{
    public class PanelScrollControl
    {
        public VScrollBar vScrollBar;
        public Label vValue;

        public HScrollBar hScrollBar;
        public Label hValue;

        public Panel panel;
        public Panel panelFrame;

        private int vScrollBar_valueMax;
        private int hScrollBar_valueMax;


        private bool MouseButtonRightDown = false;

        public PanelScrollControl(Panel panelFrame, Panel panel, VScrollBar vScrollBar, HScrollBar hScrollBar = null, Label vValue = null, Label hValue = null)
        {
            this.panelFrame = panelFrame;
            this.panel = panel;

            this.vScrollBar = vScrollBar;
            this.vScrollBar.Scroll += new ScrollEventHandler(ScrollBar_Scroll);
            this.vScrollBar.ValueChanged += new EventHandler(ScrollBar_ValueChanged);
            this.vScrollBar.LargeChange = vScrollBar.Maximum;
            this.vScrollBar.Enabled = false;

            this.vValue = vValue;

            this.hScrollBar = hScrollBar;
            if (this.hScrollBar != null)
            {
                this.hScrollBar.Scroll += new ScrollEventHandler(ScrollBar_Scroll);
                this.hScrollBar.ValueChanged += new EventHandler(ScrollBar_ValueChanged);
                this.hValue = hValue;
                this.hScrollBar.LargeChange = hScrollBar.Maximum;
                this.hScrollBar.Enabled = false;
            }

            this.panel.SizeChanged += new EventHandler(this.panel_SizeChanged);
            this.panel.MouseWheel += new MouseEventHandler(this.panel_MouseWheel);
            this.panel.MouseDown += new MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseUp += new MouseEventHandler(this.panel_MouseUp);

            this.panelFrame.MouseDown += new MouseEventHandler(this.panel_MouseDown);
            this.panelFrame.MouseUp += new MouseEventHandler(this.panel_MouseUp);


        }

        private void panel_SizeChanged(object sender, EventArgs e)
        {
            vScrollBar.Enabled = panel.Height > panelFrame.Height;
            vScrollBar.Maximum = panel.Height;
            vScrollBar.LargeChange = panelFrame.Height;
            vScrollBar_valueMax = vScrollBar.Maximum - vScrollBar.LargeChange;

            if (hScrollBar != null)
            {
                hScrollBar.Enabled = panel.Width > panelFrame.Width;
                hScrollBar.Maximum = panel.Width;
                hScrollBar.LargeChange = panelFrame.Width;
                hScrollBar_valueMax = hScrollBar.Maximum - hScrollBar.LargeChange;
            }

        }

        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBar_Operation();
        }

        private void ScrollBar_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar_Operation();
        }

        private void ScrollBar_Operation()
        {
            panel.Top = -vScrollBar.Value;

            if (hScrollBar != null)
            {
                panel.Left = -hScrollBar.Value;
            }

            if (vValue != null)
            {
                vValue.Text = vScrollBar.Value.ToString(); vValue.Refresh();
            }
            if (hValue != null && hScrollBar != null)
            {
                hValue.Text = hScrollBar.Value.ToString(); hValue.Refresh();
            }

            panel.Refresh();
        }


        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseButtonRightDown = true;
            }

        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseButtonRightDown = false;
            }
        }

        private void panel_MouseWheel(object sender, MouseEventArgs e)
        {
            if (MouseButtonRightDown && hScrollBar != null)
            {
                int targetValue = hScrollBar.Value - e.Delta;

                targetValue = targetValue > hScrollBar.Minimum ? targetValue : hScrollBar.Minimum;
                targetValue = targetValue < hScrollBar_valueMax ? targetValue : hScrollBar_valueMax;

                hScrollBar.Value = targetValue > 0 ? targetValue : 0;
            }
            else
            {
                int targetValue = vScrollBar.Value - e.Delta;

                targetValue = targetValue > vScrollBar.Minimum ? targetValue : vScrollBar.Minimum;
                targetValue = targetValue < vScrollBar_valueMax ? targetValue : vScrollBar_valueMax;

                vScrollBar.Value = targetValue > 0 ? targetValue : 0;
            }

            ScrollBar_Operation();

        }

    }

}
