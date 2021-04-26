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

            //panel1.HorizontalScroll.Maximum = 0;
            //panel1.AutoScroll = false;
            panel1.VerticalScroll.Visible = true;
            panel1.HorizontalScroll.Visible = false;
            //panel1.AutoScroll = true;
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
            TmrAnimation.Start();
        }
    }
}
