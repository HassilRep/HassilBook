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
                cmd.CommandText = "SELECT * FROM tbl_ClientAirplanes WHERE OfficeID = '" + FrmLogin.OfficeID + "' ORDER BY ID ASC";
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
                cmd.CommandText = "SELECT * FROM tbl_ClientAirplanes WHERE RegNumber LIKE '%" + keyword + "%' AND OfficeID = '" + FrmLogin.OfficeID + "' OR Manufacturer LIKE '%" + keyword + "%' AND OfficeID = '" + FrmLogin.OfficeID + "' OR Model LIKE '%" + keyword + "%' AND OfficeID = '" + FrmLogin.OfficeID + "' OR Status LIKE '%" + keyword + "%' AND OfficeID = '" + FrmLogin.OfficeID + "' OR Category LIKE '%" + keyword + "%' AND OfficeID = '" + FrmLogin.OfficeID + "'";
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

                }
                else if(cel == "DEL")
                {
                    if(MessageBox.Show($"Do you want to delete this airplane {DGClientAirplanes[2, e.RowIndex].Value.ToString()}?","delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Airplane airplane = new Airplane();
                        airplane.Delete(FrmLogin.OfficeID, DGClientAirplanes[2, e.RowIndex].Value.ToString());
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
            FrmAddEditAirplane F = new FrmAddEditAirplane();
            F.ShowDialog();
        }
    }
}
