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
    public partial class FrmAgency : Form
    {
        public FrmAgency()
        {
            InitializeComponent();
            LoadAgencyID();
            LoadClientAgencies();
        }

        /// <summary>
        /// Load agency ID
        /// </summary>
        private void LoadAgencyID()
        {
            try
            {
                IDGenerator ID = new IDGenerator();
                ID.ClientAgencyID(FrmLogin.m_client.ClientID);
                TxtAgencyID.Text = ID.M_ClientAgencyID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Load airline agencies
        /// </summary>
        private void LoadClientAgencies()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                DGClientFlights.Rows.Clear();
                int i = 1;
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tbl_ClientAgencies WHERE OfficeID = '"+FrmLogin.m_client.ClientID+"'";
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    DGClientFlights.Rows.Add(i, dr["AgencyID"].ToString(), dr["Company"].ToString(), dr["OwnerName"].ToString(), dr["Email"].ToString(), dr["Telephone"].ToString(), dr["AgencyType"].ToString(), dr["Status"].ToString());
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

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            if (TxtAgencyID.Text == string.Empty || TxtCompany.Text == string.Empty || TxtOwnerName.Text == string.Empty || CmbGender.SelectedIndex == 0 || TxtStreet.Text == string.Empty || TxtPostalCode.Text == string.Empty || TxtCity.Text == string.Empty || CmbCountry.SelectedIndex == 0 || TxtTelephone.Text == string.Empty || TxtEmail.Text == string.Empty || CmbAgencyType.SelectedIndex == 0 || CmbStatus.SelectedIndex == 0)
            {
               MessageBox.Show("Agency information is incompleted.", "Please check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DatabaseConnection con = new DatabaseConnection();
                    if (BtnAddEdit.Text == "ADD NEW AGENCY")
                    {
                        MySqlCommand cmdAgencyChecker = new MySqlCommand("SELECT * FROM tbl_ClientAgencies WHERE Company = '" + TxtCompany.Text + "' AND OfficeID = '" + FrmLogin.m_client.ClientID + "' OR Email = '" + TxtEmail.Text + "' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'", con.ActiveConnection());
                        MySqlDataAdapter sda = new MySqlDataAdapter(cmdAgencyChecker);
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        int i = ds.Tables[0].Rows.Count;
                        if (i > 0)
                        {
                            MessageBox.Show("This agency name " + TxtCompany.Text + " or email " + TxtEmail.Text + " exists in our Database", "Multiple agency detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ds.Clear();
                            con.ActiveConnection().Close();
                        }
                        else
                        {
                            Random random = new Random();
                            int initialPassword = random.Next(100000, 999999);
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_ClientAgencies(OfficeID,AgencyID,JoinedDate,Company,OwnerName,Gender,Street,PostalCode,City,Country,Telephone,Email, Password ,AgencyType)VALUES('" + FrmLogin.m_client.ClientID + "','" + TxtAgencyID.Text + "','" + DtJoinDate.Value.ToString("yyyy/MM/dd") + "','" + TxtCompany.Text + "','" + TxtOwnerName.Text + "','" + CmbGender.Text + "','" + TxtStreet.Text + "','" + TxtPostalCode.Text + "','" + TxtCity.Text + "','" + CmbCountry.Text + "','" + TxtTelephone.Text + "','" + TxtEmail.Text + "','"+initialPassword+"','" + CmbAgencyType.Text + "')", con.ActiveConnection());
                            cmd.ExecuteNonQuery();

                            LoadClientAgencies();
                            TxtAgencyID.Text = string.Empty;
                            DtJoinDate.Text = DateTime.Now.ToShortDateString();
                            TxtCompany.Text = string.Empty;
                            TxtOwnerName.Text = string.Empty;
                            CmbGender.SelectedIndex = 0;
                            TxtStreet.Text = string.Empty;
                            TxtPostalCode.Text = string.Empty;
                            TxtCity.Text = string.Empty;
                            CmbCountry.SelectedIndex = 0;
                            TxtTelephone.Text = string.Empty;
                            TxtEmail.Text = string.Empty;
                            CmbAgencyType.SelectedIndex = 0;
                            CmbStatus.SelectedIndex = 0;
                            LoadAgencyID();
                            con.ActiveConnection().Close();
                        }
                    }
                    else if (BtnAddEdit.Text == "UPDATE AGENCY")
                    {
                        MySqlCommand cmd;
                        cmd = con.ActiveConnection().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE tbl_ClientAgencies SET JoinedDate = '"+DtJoinDate.Value.ToString("yyyy/MM/dd")+"', Company = '" + TxtCompany.Text + "',OwnerName = '" + TxtOwnerName.Text + "',Gender = '" + CmbGender.Text + "',Street = '" + TxtStreet.Text + "',PostalCode = '" + TxtPostalCode.Text + "',City = '" + TxtCity.Text + "',Country = '" + CmbCountry.Text + "',Telephone = '" + TxtTelephone.Text + "',Email = '" + TxtEmail.Text + "',AgencyType = '" + CmbAgencyType.Text + "', Status = '"+CmbStatus.Text+"' WHERE AgencyID = '" + TxtAgencyID.Text + "' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Agency information '{TxtAgencyID.Text}' has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadClientAgencies();
                        TxtAgencyID.Text = string.Empty;
                        DtJoinDate.Text = DateTime.Now.ToShortDateString();
                        TxtCompany.Text = string.Empty;
                        TxtOwnerName.Text = string.Empty;
                        CmbGender.SelectedIndex = 0;
                        TxtStreet.Text = string.Empty;
                        TxtPostalCode.Text = string.Empty;
                        TxtCity.Text = string.Empty;
                        CmbCountry.SelectedIndex = 0;
                        TxtTelephone.Text = string.Empty;
                        TxtEmail.Text = string.Empty;
                        CmbAgencyType.SelectedIndex = 0;
                        CmbStatus.SelectedIndex = 0;
                        LoadAgencyID();
                        con.ActiveConnection().Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DGClientAgencies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string cel = DGClientFlights.Columns[e.ColumnIndex].Name;
                DatabaseConnection con = new DatabaseConnection();

                if (cel == "EDIT")
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_ClientAgencies WHERE AgencyID = '" + DGClientFlights[1, e.RowIndex].Value.ToString() + "' AND OfficeID = '" +FrmLogin.m_client.ClientID + "'", con.ActiveConnection());
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        TxtAgencyID.Text = dr["AgencyID"].ToString();
                        DtJoinDate.Text = dr.GetDateTime("JoinedDate").ToString();
                        TxtCompany.Text = dr["Company"].ToString();
                        TxtOwnerName.Text = dr["OwnerName"].ToString();
                        CmbGender.Text = dr["Gender"].ToString();
                        TxtStreet.Text = dr["Street"].ToString();
                        TxtPostalCode.Text = dr["PostalCode"].ToString();
                        TxtCity.Text = dr["City"].ToString();
                        CmbCountry.Text = dr["Country"].ToString();
                        TxtTelephone.Text = dr["Telephone"].ToString();
                        TxtEmail.Text = dr["Email"].ToString();
                        CmbAgencyType.Text = dr["AgencyType"].ToString();
                        CmbStatus.Text = dr["Status"].ToString();

                        BtnAddEdit.Text = "UPDATE AGENCY";
                    }
                    dr.Close();
                    con.ActiveConnection().Close();
                }
                else if (cel == "DEL")
                {
                    if (MessageBox.Show($"Do you want to delete this agency '{DGClientFlights[1, e.RowIndex].Value.ToString()}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand cmd;
                        cmd = con.ActiveConnection().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM tbl_ClientAgencies WHERE AgencyID = '" + DGClientFlights[1, e.RowIndex].Value.ToString() + "' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Agency '{DGClientFlights[1, e.RowIndex].Value.ToString()}' has been successfully deleted from the database", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        con.ActiveConnection().Close();
                        LoadClientAgencies();
                        TxtAgencyID.Text = string.Empty;
                        DtJoinDate.Text = DateTime.Now.ToShortDateString();
                        TxtCompany.Text = string.Empty;
                        TxtOwnerName.Text = string.Empty;
                        CmbGender.SelectedIndex = 0;
                        TxtStreet.Text = string.Empty;
                        TxtPostalCode.Text = string.Empty;
                        TxtCity.Text = string.Empty;
                        CmbCountry.SelectedIndex = 0;
                        TxtTelephone.Text = string.Empty;
                        TxtEmail.Text = string.Empty;
                        CmbAgencyType.SelectedIndex = 0;
                        CmbStatus.SelectedIndex = 0;
                        LoadAgencyID();
                        BtnAddEdit.Text = "ADD NEW AGENCY";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// searchs agency information with the given keyword
        /// </summary>
        private void SearchAgency()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                DGClientFlights.Rows.Clear();
                int i = 1;
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tbl_ClientAgencies WHERE AgencyID LIKE '%" + TxtSearchWith.Text + "%' AND OfficeID = '" + FrmLogin.m_client.ClientID + "' OR Company LIKE '%" + TxtSearchWith.Text + "%' AND OfficeID = '" + FrmLogin.m_client.ClientID + "' OR OwnerName LIKE '%" + TxtSearchWith.Text + "%' AND OfficeID = '" + FrmLogin.m_client.ClientID + "' OR Email LIKE '%" + TxtSearchWith.Text + "%' AND OfficeID = '" + FrmLogin.m_client.ClientID + "' OR Telephone LIKE '%" + TxtSearchWith.Text + "%' AND OfficeID = '" + FrmLogin.m_client.ClientID + "' OR AgencyType LIKE '%" + TxtSearchWith.Text + "%' AND OfficeID = '" + FrmLogin.m_client.ClientID + "' OR Status LIKE '%" + TxtSearchWith.Text + "%' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DGClientFlights.Rows.Add(i, dr["AgencyID"].ToString(), dr["Company"].ToString(), dr["OwnerName"].ToString(), dr["Email"].ToString(), dr["Telephone"].ToString(), dr["AgencyType"].ToString(),dr["Status"].ToString());
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

        private void TxtSearchWith_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchAgency();
            }
        }
    }
}
