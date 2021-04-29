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
    public partial class FrmAgencyDashboard : Form
    {
        private bool m_IsHidden;
        public FrmAgencyDashboard()
        {
            InitializeComponent();
            m_IsHidden = false;

            // COPYRIGHT © [Year] Hassil Technology
            LblCopyright.Text = $"© {DateTime.Now.Year.ToString()} Hassil Technology";
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
