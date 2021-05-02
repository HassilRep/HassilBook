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
    public partial class FrmClientAirplanes : Form
    {
        public int m_airplaneID;
        public FrmClientAirplanes()
        {
            InitializeComponent();
            LoadAirplanes();
        }

        /// <summary>
        /// Loads airplane list from the database.
        /// </summary>
        public void LoadAirplanes()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                DGClientAirplanes.Rows.Clear();
                int i = 1;
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tbl_ClientAirplanes WHERE OfficeID = '" + FrmLogin.m_client.ClientID + "' ORDER BY ID ASC";
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    DGClientAirplanes.Rows.Add(i, Convert.ToDateTime(dr["RegDate"]).ToString("dd/MM/yyyy"), dr["RegNumber"].ToString(), dr["Manufacturer"].ToString(), dr["Model"].ToString(), dr["Seats"].ToString(), dr["Category"].ToString(), dr["Status"].ToString());
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
        /// Searches an airplane with the given criteria
        /// </summary>
        /// <param name="keyword">criteria of the search</param>
        public void SearchAirplane(string keyword)
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                DGClientAirplanes.Rows.Clear();
                int i = 1;
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tbl_ClientAirplanes WHERE RegNumber LIKE '%" + keyword + "%' AND OfficeID = '" + FrmLogin.m_client.ClientID + "' OR Manufacturer LIKE '%" + keyword + "%' AND OfficeID = '" + FrmLogin.m_client.ClientID + "' OR Model LIKE '%" + keyword + "%' AND OfficeID = '" + FrmLogin.m_client.ClientID + "' OR Status LIKE '%" + keyword + "%' AND OfficeID = '" + FrmLogin.m_client.ClientID + "' OR Category LIKE '%" + keyword + "%' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DGClientAirplanes.Rows.Add(i, Convert.ToDateTime(dr["RegDate"]).ToString("dd/MM/yyyy"), dr["RegNumber"].ToString(), dr["Manufacturer"].ToString(), dr["Model"].ToString(), dr["Seats"].ToString(), dr["Category"].ToString(), dr["Status"].ToString());
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

        private void DGClientAirplanes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cel = DGClientAirplanes.Columns[e.ColumnIndex].Name;
            try
            {
                if(cel == "EDIT")
                {
                    FrmAddEditAirplane F = new FrmAddEditAirplane(this);
                    DatabaseConnection con = new DatabaseConnection();
                    MySqlCommand cmd;
                    cmd = con.ActiveConnection().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM tbl_ClientAirplanes WHERE RegNumber = '"+DGClientAirplanes[2, e.RowIndex].Value.ToString()+"' AND OfficeID = '"+FrmLogin.m_client.ClientID+"'";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        m_airplaneID = int.Parse(dr["ID"].ToString());
                        F.TxtRegistrationNumber.Text = dr["RegNumber"].ToString();
                        F.DtRegistrationDate.Text = dr["RegDate"].ToString();
                        F.TxtManufacturer.Text = dr["Manufacturer"].ToString();
                        F.TxtModel.Text = dr["Model"].ToString();
                        F.TxtSeats.Text = dr["Seats"].ToString();
                        F.CmbCategory.Text = dr["Category"].ToString();
                        F.CmbStatus.Text = dr["Status"].ToString();
                        F.BtnAddEdit.Text = "UPDATE AIRPLANE";
                        F.ShowDialog();
                    }
                    dr.Close();
                    con.ActiveConnection().Close();
                }
                else if(cel == "DEL")
                {
                    if(MessageBox.Show($"Do you want to delete this airplane {DGClientAirplanes[2, e.RowIndex].Value.ToString()}?","delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Airplane airplane = new Airplane();
                        airplane.Delete(FrmLogin.m_client.ClientID, DGClientAirplanes[2, e.RowIndex].Value.ToString());
                        LoadAirplanes();
                    }
                }
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
                SearchAirplane(TxtSearchWith.Text);
            }
        }

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            FrmAddEditAirplane F = new FrmAddEditAirplane(this);
            F.ShowDialog();
        }
    }
}
