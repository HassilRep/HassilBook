using MySql.Data.MySqlClient;
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

        DatabaseConnection con = new DatabaseConnection();
        public FrmAgencyDashboard()
        {
            InitializeComponent();
            m_IsHidden = false;

            // COPYRIGHT © [Year] Hassil Technology
            LblCopyright.Text = $"© {DateTime.Now.Year.ToString()} Hassil Technology";

            LoadCurrentWalletBalance();
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

        /// <summary>
        /// Load agency current wallet balance
        /// </summary>
        private void LoadCurrentWalletBalance()
        {
            try
            {
                using(MySqlCommand cmd = new MySqlCommand("SELECT COALESCE(SUM(W.Credit - W.Debit),0) AS Balance FROM tbl_ClientHaWallet W INNER JOIN tbl_ClientAgencies A ON W.Agency = A.ID WHERE A.ID = '" + FrmLogin.m_agency.ID + "' AND A.OfficeID = '" + FrmLogin.m_agency.OfficeID + "'", con.ActiveConnection()))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var balance = decimal.Parse(dr["Balance"].ToString());

                        if (FrmLogin.m_agency.AgencyType == "Postpaid")
                        {
                            LblWalletBalance.ForeColor = Color.FromArgb(115, 191, 133);
                        }
                        else
                        {
                            LblWalletBalance.Text = $"HA-WALLET CURRENT BALANCE : {balance} USD";
                        }                     
                    }
                    dr.Close();
                    con.ActiveConnection().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        #region copyright
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
        #endregion

        private void BtnMyHaWallet_Click(object sender, EventArgs e)
        {
            MyContainer(new FrmAgencyHaWallet());
        }

        private void BtnSearchFlight_Click(object sender, EventArgs e)
        {
            MyContainer(new FrmAgencySearchEngine());
        }
    }
}
