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
    public partial class FrmAgencyHaWallet : Form
    {
        public FrmAgencyHaWallet()
        {
            InitializeComponent();

            DtFrom.Text = DateTime.Now.ToString();
            DtTo.Text = DateTime.Now.ToString();

            LoadAgencyHaWalletHistory();
        }

        /// <summary>
        /// Load agency wallet history
        /// </summary>
        private void LoadAgencyHaWalletHistory()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();

                DGClientAgencyHaWallet.Rows.Clear();
                int i = 1;
                using (MySqlCommand cmd = new MySqlCommand(@"SELECT W.Date, W.Refrence, A.Company, W.Description, W.Debit, W.Credit, SUM(W.Credit - W.Debit) OVER(ORDER BY W.ID) RunningBalance FROM tbl_ClientHaWallet W 
                                    INNER JOIN tbl_Clients C ON W.OfficeID = C.ID 
                                    INNER JOIN tbl_ClientAgencies A ON W.Agency = A.ID
                                    WHERE W.Agency = '" + FrmLogin.m_agency.ID + "' AND W.OfficeID = '" + FrmLogin.m_agency.OfficeID + "'",con.ActiveConnection()))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        // agency view CR DR
                        DGClientAgencyHaWallet.Rows.Add(i, dr["Refrence"].ToString(), Convert.ToDateTime(dr["Date"]).ToString("dd/MM/yyyy"), dr["Company"].ToString(), dr["Description"].ToString(), dr["Credit"].ToString(), dr["Debit"].ToString(), dr["RunningBalance"].ToString());
                        i++;
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();

                DGClientAgencyHaWallet.Rows.Clear();
                int i = 1;
                using (MySqlCommand cmd = new MySqlCommand(@"SELECT W.Date, W.Refrence, A.Company, W.Description, W.Debit, W.Credit, SUM(W.Credit - W.Debit) OVER(ORDER BY W.ID) RunningBalance FROM tbl_ClientHaWallet W 
                                    INNER JOIN tbl_Clients C ON W.OfficeID = C.ID 
                                    INNER JOIN tbl_ClientAgencies A ON W.Agency = A.ID
                                    WHERE W.Date BETWEEN '"+DtFrom.Value.ToString("yyyy/MM/dd")+"' AND '"+ DtTo.Value.ToString("yyyy/MM/dd") + "' AND W.Agency = '" + FrmLogin.m_agency.ID + "' AND W.OfficeID = '" + FrmLogin.m_agency.OfficeID + "'", con.ActiveConnection()))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        // agency view CR DR
                        DGClientAgencyHaWallet.Rows.Add(i, dr["Refrence"].ToString(), Convert.ToDateTime(dr["Date"]).ToString("dd/MM/yyyy"), dr["Company"].ToString(), dr["Description"].ToString(), dr["Credit"].ToString(), dr["Debit"].ToString(), dr["RunningBalance"].ToString());
                        i++;
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
    }
}
