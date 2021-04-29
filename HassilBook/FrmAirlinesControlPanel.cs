using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassilBook
{
    public partial class FrmAirlinesControlPanel : Form
    {
        private bool m_IsHidden;
        public FrmAirlinesControlPanel()
        {
            InitializeComponent();
            m_IsHidden = false;

            // COPYRIGHT © [Year] Hassil Technology
            LblCopyright.Text = $"© {DateTime.Now.Year.ToString()} Hassil Technology";
        }

        private void TmrAnimation_Tick(object sender, EventArgs e)
        {
            if(m_IsHidden)
            {
                pnlLeft.Width += 10;
                if(pnlLeft.Width >= pnlLeft.MaximumSize.Width)
                {
                    TmrAnimation.Stop();
                    m_IsHidden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlLeft.Width -= 10;
                if (pnlLeft.Width <= pnlLeft.MinimumSize.Width)
                {
                    TmrAnimation.Stop();
                    m_IsHidden = true;
                    this.Refresh();
                }
            }
        }

        private void BtnHamburgerMenu_Click(object sender, EventArgs e)
        {
            if (m_IsHidden)
            {
                pnlContainer.Width -= (pnlLeft.MaximumSize.Width - pnlLeft.MinimumSize.Width);
                pnlLeft.Width = pnlLeft.MaximumSize.Width;
                pnlContainer.Location = new Point(pnlLeft.Width + 8, pnlContainer.Location.Y);
                m_IsHidden = false;
                pnlMenu.AutoScroll = true;
                LblCopyright.Visible = true;
                this.Refresh();
            }
            else
            {
                pnlContainer.Width += (pnlLeft.MaximumSize.Width - pnlLeft.MinimumSize.Width);
                pnlLeft.Width = pnlLeft.MinimumSize.Width;
                m_IsHidden = true;
                pnlContainer.Location = new Point(pnlLeft.Width + 8, pnlContainer.Location.Y);
                pnlMenu.AutoScroll = false;
                LblCopyright.Visible = false;
                this.Refresh();
            }
        }
    }
}
