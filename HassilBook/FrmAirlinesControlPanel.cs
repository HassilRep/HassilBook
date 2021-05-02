using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            LoadClientLogo();

            // COPYRIGHT © [Year] Hassil Technology
            LblCopyright.Text = $"© {DateTime.Now.Year.ToString()} Hassil Technology";
        }

        /// <summary>
        /// Load current client logo
        /// </summary>
        private void LoadClientLogo()
        {
            try
            {
                byte[] UserImage = Convert.IsDBNull(FrmLogin.m_client.Logo) ? null : FrmLogin.m_client.Logo;
                if(UserImage.Length < 0)
                {
                    PbClientLogo.Image = Properties.Resources.placeholder;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(UserImage);
                    PbClientLogo.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Loads selected user form
        /// </summary>
        /// <param name="changer"></param>
        private void MyContainer(Form changer)
        {
            if (pnlContainer.Controls.Count > 0)
                pnlContainer.Controls.RemoveAt(0);
            Form F = changer as Form;
            changer.TopLevel = false;
            changer.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(changer);
            this.pnlContainer.Tag = F;
            changer.Show();
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

        private void BtnAirplanes_Click(object sender, EventArgs e)
        {
            MyContainer(new FrmClientAirplanes());
        }

        private void BtnDepartments_Click(object sender, EventArgs e)
        {
            MyContainer(new FrmDepartments());
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            MyContainer(new FrmEmployees());
        }

        private void BtnAgencies_Click(object sender, EventArgs e)
        {
            MyContainer(new FrmAgency());
        }
    }
}
