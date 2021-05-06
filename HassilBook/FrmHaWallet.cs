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
    public partial class FrmHaWallet : Form
    {
        public FrmHaWallet()
        {
            InitializeComponent();
            DtFrom.Text = DateTime.Now.ToString();
            DtTo.Text = DateTime.Now.ToString();

            LoadWalletID();
            LoadAgencies();
            LoadWalletTransactions();
            LoadWalletPaymentTransactions();
        }

        private void LoadWalletID()
        {
            IDGenerator ID = new IDGenerator();
            ID.ClientWalletPaymentID(FrmLogin.m_client.ClientID);
            TxtWalletID.Text = ID.M_ClientWalletPaymentID;
        }

        /// <summary>
        /// Load agencies from the database
        /// </summary>
        private void LoadAgencies()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                CmbAgencies.Items.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Company");
                dt.Rows.Add("0", "- Agencies -");

                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT ID, Company FROM tbl_ClientAgencies", con.ActiveConnection());
                DataTable table = new DataTable();
                sda.Fill(table);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in table.Rows)
                    {
                        dt.Rows.Add(item["ID"], item["Company"]);
                    }
                }
                CmbAgencies.DataSource = dt;
                CmbAgencies.ValueMember = "ID";
                CmbAgencies.DisplayMember = "Company";

                CmbAgency.DataSource = dt;
                CmbAgency.ValueMember = "ID";
                CmbAgency.DisplayMember = "Company";

                CmbCompanies.DataSource = dt;
                CmbCompanies.ValueMember = "ID";
                CmbCompanies.DisplayMember = "Company";

                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Loads wallet transactions
        /// </summary>
        private void LoadWalletTransactions()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                DGClientAgencyHaWallet.Rows.Clear();
                int i = 1;
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT W.Date, W.Refrence, A.Company, W.Description, W.Debit, W.Credit, SUM(W.Credit - W.Debit) OVER(ORDER BY W.ID) RunningBalance FROM tbl_ClientHaWallet W 
                                    INNER JOIN tbl_Clients C ON W.OfficeID = C.ID 
                                    INNER JOIN tbl_ClientAgencies A ON W.Agency = A.ID
                                    WHERE W.OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DGClientAgencyHaWallet.Rows.Add(i, dr["Refrence"].ToString(), Convert.ToDateTime(dr["Date"]).ToString("dd/MM/yyyy"), dr["Company"].ToString(), dr["Description"].ToString(), dr["Debit"].ToString(), dr["Credit"].ToString(), dr["RunningBalance"].ToString());
                    i++;
                }
                dr.Close();
                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Loads wallet payment transactions
        /// </summary>
        private void LoadWalletPaymentTransactions()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                DGClientWalletPaymentTransactions.Rows.Clear();
                int i = 1;
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT W.Date, W.Refrence, A.Company, W.Description, W.Credit, U.Username FROM tbl_ClientHaWallet W 
                                    INNER JOIN tbl_Clients C ON W.OfficeID = C.ID 
                                    INNER JOIN tbl_ClientAgencies A ON W.Agency = A.ID
                                    INNER JOIN tbl_ClientUsers U ON W.Username = U.ID
                                    WHERE W.Refrence LIKE 'WCR%' AND W.OfficeID = '" + FrmLogin.m_client.ClientID + "' ORDER BY W.ID";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DGClientWalletPaymentTransactions.Rows.Add(i, dr["Refrence"].ToString(), Convert.ToDateTime(dr["Date"]).ToString("dd/MM/yyyy"), dr["Company"].ToString(), dr["Description"].ToString(), dr["Credit"].ToString(),dr["Username"]);
                    i++;
                }
                dr.Close();
                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            LoadWalletTransactions();
            CmbAgencies.SelectedIndex = 0;
            DtFrom.Text = DateTime.Now.ToString();
            DtTo.Text = DateTime.Now.ToString();
            WalletPage.SelectTab("History");
        }

        private void BtnPayments_Click(object sender, EventArgs e)
        {
            CmbCompanies.SelectedIndex = 0;
            CmbAgency.SelectedIndex = 0;
            LoadWalletID();
            LoadWalletPaymentTransactions();
            DtTranFrom.Text = DateTime.Now.ToString();
            DtTranTo.Text = DateTime.Now.ToString();
            DtTransactionDate.Text = DateTime.Now.ToString();
            TxtAmount.Text = string.Empty;
            TxtDescription.Text = string.Empty;
            WalletPage.SelectTab("Payments");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(CmbAgencies.SelectedIndex == 0)
                {
                    MessageBox.Show("Select an agency to load transactions please.", "agency", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DatabaseConnection con = new DatabaseConnection();
                    DGClientAgencyHaWallet.Rows.Clear();
                    int i = 1;
                    MySqlCommand cmd;
                    cmd = con.ActiveConnection().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT W.Date, W.Refrence, A.Company, W.Description, W.Debit, W.Credit, SUM(W.Credit - W.Debit) OVER(ORDER BY W.ID) RunningBalance FROM tbl_ClientHaWallet W 
                                    INNER JOIN tbl_Clients C ON W.OfficeID = C.ID 
                                    INNER JOIN tbl_ClientAgencies A ON W.Agency = A.ID
                                    WHERE A.Company = '" + CmbAgencies.Text + "' AND W.Date BETWEEN '" + DtFrom.Value.ToString("yyyy/MM/dd") + "' AND '" + DtTo.Value.ToString("yyyy/MM/dd") + "' AND W.OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DGClientAgencyHaWallet.Rows.Add(i, dr["Refrence"].ToString(), Convert.ToDateTime(dr["Date"]).ToString("dd/MM/yyyy"), dr["Company"].ToString(), dr["Description"].ToString(), dr["Debit"].ToString(), dr["Credit"].ToString(), dr["RunningBalance"].ToString());
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

        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {
            LblCounter.Text = $"[{TxtDescription.Text.Length.ToString()}/{TxtDescription.MaxLength}]";
        }

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            if(TxtWalletID.Text == string.Empty || CmbCompanies.SelectedIndex == 0 || TxtAmount.Text == string.Empty || TxtDescription.Text == string.Empty)
            {

            }
            else
            {
                try
                {
                    DatabaseConnection con = new DatabaseConnection();
                    if(BtnAddEdit.Text == "ADD NEW PAYMENT")
                    {
                        decimal debit = 0;
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_ClientHaWallet(OfficeID, Date, Refrence, Agency, Description, Debit, Credit, Username) VALUES('"+FrmLogin.m_client.ClientID+"','"+DtTransactionDate.Value.ToString("yyyy/MM/dd")+"','"+TxtWalletID.Text+"','"+CmbCompanies.SelectedValue+ "','"+TxtDescription.Text+"','" + debit+"','"+decimal.Parse(TxtAmount.Text)+ "','"+FrmLogin.m_employee.UsernameID+"')", con.ActiveConnection());
                        cmd.ExecuteReader();
                        MessageBox.Show("Congratulation, a new wallet transaction has been saved.","new transaction",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnPayments.PerformClick();
                        con.ActiveConnection().Close();
                    }
                    else
                    {
                        MySqlCommand cmd;
                        cmd = con.ActiveConnection().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE tbl_ClientHaWallet SET Date = '"+DtTransactionDate.Value.ToString("yyyy/MM/dd")+"', Agency = '"+CmbCompanies.SelectedValue+"', Description = '"+TxtDescription.Text+"', Credit = '"+decimal.Parse(TxtAmount.Text)+"', Username = '"+FrmLogin.m_employee.UsernameID+"' WHERE Refrence = '"+TxtWalletID.Text+"' AND OfficeID = '"+FrmLogin.m_client.ClientID+"'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Congratulation, wallet transaction {TxtWalletID.Text} has been updated.", "transaction updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnPayments.PerformClick();
                        con.ActiveConnection().Close();
                        BtnAddEdit.Text = "ADD NEW PAYMENT";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnSearchPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbAgencies.SelectedIndex == 0)
                {
                    MessageBox.Show("Select an agency to load transactions please.", "agency", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DatabaseConnection con = new DatabaseConnection();
                    DGClientWalletPaymentTransactions.Rows.Clear();
                    int i = 1;
                    MySqlCommand cmd;
                    cmd = con.ActiveConnection().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT W.Date, W.Refrence, A.Company, W.Description, W.Credit, U.Username FROM tbl_ClientHaWallet W 
                                    INNER JOIN tbl_Clients C ON W.OfficeID = C.ID 
                                    INNER JOIN tbl_ClientAgencies A ON W.Agency = A.ID
                                    INNER JOIN tbl_ClientUsers U ON W.Username = U.ID
                                    WHERE W.Refrence LIKE 'WCR%' AND A.Company = '" + CmbAgency.Text + "' AND W.Date BETWEEN '" + DtTranFrom.Value.ToString("yyyy/MM/dd") + "' AND '" + DtTranTo.Value.ToString("yyyy/MM/dd") + "' AND W.OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DGClientWalletPaymentTransactions.Rows.Add(i, dr["Refrence"].ToString(), Convert.ToDateTime(dr["Date"]).ToString("dd/MM/yyyy"), dr["Company"].ToString(), dr["Description"].ToString(), dr["Credit"].ToString(), dr["Username"]);
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

        private void DGClientWalletPaymentTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cel = DGClientWalletPaymentTransactions.Columns[e.ColumnIndex].Name;
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                
                if(cel == "UPDATE")
                {
                    MySqlCommand cmd;
                    cmd = con.ActiveConnection().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT W.Date, W.Refrence, A.Company, W.Description, W.Credit FROM tbl_ClientHaWallet W INNER JOIN tbl_ClientAgencies A ON W.Agency = A.ID
                                        WHERE W.Refrence = '"+DGClientWalletPaymentTransactions[1, e.RowIndex].Value.ToString()+"' AND W.OfficeID = '"+FrmLogin.m_client.ClientID+"'";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        DtTransactionDate.Text = dr["Date"].ToString();
                        TxtWalletID.Text = dr["Refrence"].ToString();
                        CmbCompanies.Text = dr["Company"].ToString();
                        TxtDescription.Text = dr["Description"].ToString();
                        TxtAmount.Text = dr["Credit"].ToString();

                        BtnAddEdit.Text = "UPDATE PAYMENT";
                    }
                    dr.Close();
                    con.ActiveConnection().Close();
                }
                else if(cel == "DELETE")
                {
                    if(MessageBox.Show($"Do you want to delete this wallet transaction '{DGClientWalletPaymentTransactions[1, e.RowIndex].Value.ToString()}'?","delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand cmd;
                        cmd = con.ActiveConnection().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM tbl_ClientHaWallet WHERE Refrence = '" + DGClientWalletPaymentTransactions[1, e.RowIndex].Value.ToString() + "' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Congratulation, transaction {DGClientWalletPaymentTransactions[1, e.RowIndex].Value.ToString()} has been successfully deleted.", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnPayments.PerformClick();
                        con.ActiveConnection().Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
