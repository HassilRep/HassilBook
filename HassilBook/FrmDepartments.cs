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
    public partial class FrmDepartments : Form
    {
        public FrmDepartments()
        {
            InitializeComponent();
            LoadDepartments();
        }

        /// <summary>
        /// Load departments of the client
        /// </summary>
        public void LoadDepartments()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                int i = 0;
                DGClientDepartments.Rows.Clear();
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT D.DepartmentID, D.Description, CASE WHEN D.ManagerID IS NOT NULL THEN E.Firstname ELSE 'No Manager assigned yet' END AS Manager FROM tbl_ClientDepartment D LEFT JOIN tbl_ClientEmployees E ON D.ManagerID = E.ID WHERE D.OfficeID = '" + FrmLogin.m_client.ClientID + "' ORDER BY D.ID ASC";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    DGClientDepartments.Rows.Add(i, dr["DepartmentID"].ToString(), dr["Description"].ToString(), dr["Manager"].ToString());
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
            FrmAddEditDepartment F = new FrmAddEditDepartment(this);
            IDGenerator ID = new IDGenerator();
            ID.ClientDepartmentID(FrmLogin.m_client.ClientID);
            F.TxtDepartmentID.Text = ID.M_ClientDepartmentID;
            F.ShowDialog();
        }

        private void DGClientDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cel = DGClientDepartments.Columns[e.ColumnIndex].Name;
            DatabaseConnection con = new DatabaseConnection();
            FrmAddEditDepartment F = new FrmAddEditDepartment(this);

            try
            {
                if (cel == "EDIT")
                {
                    MySqlCommand cmd;
                    cmd = con.ActiveConnection().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT D.DepartmentID, D.Description, CASE WHEN D.ManagerID IS NOT NULL THEN E.Firstname ELSE 'No Manager assigned yet' END AS Manager FROM tbl_ClientDepartment D LEFT JOIN tbl_ClientEmployees E ON D.ManagerID = E.ID WHERE D.DepartmentID = '" + DGClientDepartments[1, e.RowIndex].Value.ToString() + "' AND D.OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        F.TxtDepartmentID.Text = dr["DepartmentID"].ToString();
                        F.TxtDepartment.Text = dr["Description"].ToString();
                        if (dr["Manager"].ToString() == "No Manager assigned yet")
                        {
                           F.CmbManager.SelectedIndex = 0;
                        }
                        else
                        {
                           F.CmbManager.Text = dr["Manager"].ToString();
                        }
                    }
                    F.BtnAddEdit.Text = "UPDATE DEPARTMENT";
                    F.ShowDialog();
                    dr.Close();
                    con.ActiveConnection().Close();
                }
                else if (cel == "DEL")
                {
                    if (MessageBox.Show($"Do you want to delete this department '{DGClientDepartments[1, e.RowIndex].Value.ToString()}' from the list?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand cmd;
                        cmd = con.ActiveConnection().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM tbl_ClientDepartment WHERE DepartmentID = '" + DGClientDepartments[1, e.RowIndex].Value.ToString() + "' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Department '{DGClientDepartments[1, e.RowIndex].Value.ToString()}' has been delete from the list.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDepartments();
                        con.ActiveConnection().Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// searchs department information with the given keyword
        /// </summary>
        private void SearchDepartment()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                DGClientDepartments.Rows.Clear();
                int i = 0;
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT D.DepartmentID, D.Description, CASE WHEN D.ManagerID IS NOT NULL THEN E.Firstname ELSE 'No Manager assigned yet' END AS Manager FROM tbl_ClientDepartment D LEFT JOIN tbl_ClientEmployees E ON D.ManagerID = E.ID WHERE D.DepartmentID LIKE '%" + TxtSearchWith.Text + "%' AND D.OfficeID = '" + FrmLogin.m_client.ClientID + "' OR D.Description LIKE '%" + TxtSearchWith.Text + "%' AND D.OfficeID = '" + FrmLogin.m_client.ClientID + "' OR E.Firstname LIKE '%" + TxtSearchWith.Text + "%' AND D.OfficeID = '" + FrmLogin.m_client.ClientID + "' ORDER BY D.ID ASC";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    DGClientDepartments.Rows.Add(i, dr["DepartmentID"].ToString(), dr["Description"].ToString(), dr["Manager"].ToString());
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
                SearchDepartment();
            }
        }
    }
}
