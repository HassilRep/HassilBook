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
    public partial class FrmAddEditDepartment : Form
    {
        FrmDepartments F;
        public FrmAddEditDepartment(FrmDepartments f)
        {
            InitializeComponent();
            F = f;
        }

        private void LoadDepartmentID()
        {
            try
            {
                IDGenerator ID = new IDGenerator();
                ID.ClientDepartmentID(FrmLogin.OfficeID);
                TxtDepartmentID.Text = ID.M_ClientDepartmentID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Load the employees of the client
        /// </summary>
        private void LoadEmployees()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                CmbManager.Items.Clear();
                CmbManager.Items.Add("- Assign Manager -");
                CmbManager.SelectedIndex = 0;
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT E.Firstname FROM tbl_ClientEmployees E WHERE E.OfficeID = '" + FrmLogin.OfficeID + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CmbManager.Items.Add(dr["Firstname"].ToString());
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
            if (TxtDepartmentID.Text == string.Empty || TxtDepartment.Text == string.Empty)
            {
                MessageBox.Show("To create or update department, please fill the empty places.", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DatabaseConnection con = new DatabaseConnection();

                    if (BtnAddEdit.Text == "ADD NEW DEPARTMENT")
                    {
                        if (CmbManager.SelectedIndex == 0)
                        {
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_ClientDepartment(OfficeID,DepartmentID,Description)VALUES('" + FrmLogin.OfficeID + "','" + TxtDepartmentID.Text + "','" + TxtDepartment.Text + "')", con.ActiveConnection());
                            cmd.ExecuteNonQuery();
                            LoadDepartmentID();
                            F.LoadDepartments();
                            LoadEmployees();
                            TxtDepartment.Text = string.Empty;
                            MessageBox.Show($"New department '{TxtDepartmentID.Text}' has been added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.ActiveConnection().Close();
                        }
                        else
                        {
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_ClientDepartment(OfficeID,DepartmentID,Description,ManagerID)VALUES('" + FrmLogin.OfficeID + "','" + TxtDepartmentID.Text + "','" + TxtDepartment.Text + "','" + m_employeeID + "')", con.ActiveConnection());
                            cmd.ExecuteNonQuery();
                            LoadDepartmentID();
                            F.LoadDepartments();
                            LoadEmployees();
                            TxtDepartment.Text = string.Empty;
                            MessageBox.Show($"New department '{TxtDepartmentID.Text}' has been added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.ActiveConnection().Close();
                        }
                    }
                    else
                    {
                        if (CmbManager.SelectedIndex == 0)
                        {
                            MySqlCommand cmd;
                            cmd = con.ActiveConnection().CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE tbl_ClientDepartment SET Description = '" + TxtDepartment.Text + "', ManagerID = NULL WHERE DepartmentID = '" + TxtDepartmentID.Text + "' AND OfficeID = '" + FrmLogin.OfficeID + "'";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show($"Department '{TxtDepartmentID.Text}' has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            F.LoadDepartments();
                            LoadEmployees();
                            LoadDepartmentID();
                            BtnAddEdit.Text = "ADD NEW DEPARTMENT";
                            TxtDepartment.Text = string.Empty;
                        }
                        else
                        {
                            MySqlCommand cmd;
                            cmd = con.ActiveConnection().CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE tbl_ClientDepartment SET Description = '" + TxtDepartment.Text + "', ManagerID = '" +  + "' WHERE DepartmentID = '" + TxtDepartmentID.Text + "' AND OfficeID = '" + FrmLogin.OfficeID + "'";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show($"Department '{TxtDepartmentID.Text}' has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            F.LoadDepartments();
                            LoadEmployees();
                            LoadDepartmentID();
                            BtnAddEdit.Text = "ADD NEW DEPARTMENT";
                            TxtDepartment.Text = string.Empty;
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
}
