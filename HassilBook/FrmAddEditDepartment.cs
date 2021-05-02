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
        //private int m_employeeID;
        FrmDepartments F;
        public FrmAddEditDepartment(FrmDepartments f)
        {
            InitializeComponent();
            F = f;
            LoadEmployees();
        }

        private void LoadDepartmentID()
        {
            try
            {
                IDGenerator ID = new IDGenerator();
                ID.ClientDepartmentID(FrmLogin.m_client.ClientID);
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
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Firstname");
                dt.Rows.Add("0","- Assign Manager -");
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT ID, Firstname FROM tbl_ClientEmployees WHERE OfficeID = '" + FrmLogin.m_client.ClientID + "'", con.ActiveConnection());
                DataTable table = new DataTable();
                sda.Fill(table);
                if(dt.Rows.Count > 0)
                {
                    foreach (DataRow item in table.Rows)
                    {
                        dt.Rows.Add(item["ID"], item["Firstname"]);
                    }
                }
                CmbManager.DataSource = dt;
                CmbManager.ValueMember = "ID";
                CmbManager.DisplayMember = "Firstname";

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
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_ClientDepartment(OfficeID,DepartmentID,Description)VALUES('" + FrmLogin.m_client.ClientID + "','" + TxtDepartmentID.Text + "','" + TxtDepartment.Text + "')", con.ActiveConnection());
                            cmd.ExecuteNonQuery();
                            F.LoadDepartments();
                            TxtDepartment.Text = string.Empty;
                            MessageBox.Show($"New department '{TxtDepartmentID.Text}' has been added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDepartmentID();
                            con.ActiveConnection().Close();
                        }
                        else
                        {
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_ClientDepartment(OfficeID,DepartmentID,Description,ManagerID)VALUES('" + FrmLogin.m_client.ClientID + "','" + TxtDepartmentID.Text + "','" + TxtDepartment.Text + "','" + CmbManager.SelectedValue + "')", con.ActiveConnection());
                            cmd.ExecuteNonQuery();
                            F.LoadDepartments();
                            TxtDepartment.Text = string.Empty;
                            MessageBox.Show($"New department '{TxtDepartmentID.Text}' has been added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDepartmentID();
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
                            cmd.CommandText = "UPDATE tbl_ClientDepartment SET Description = '" + TxtDepartment.Text + "', ManagerID = NULL WHERE DepartmentID = '" + TxtDepartmentID.Text + "' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show($"Department '{TxtDepartmentID.Text}' has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            F.LoadDepartments();
                            LoadDepartmentID();
                            BtnAddEdit.Text = "ADD NEW DEPARTMENT";
                            TxtDepartment.Text = string.Empty;
                        }
                        else
                        {
                            MySqlCommand cmd;
                            cmd = con.ActiveConnection().CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE tbl_ClientDepartment SET Description = '" + TxtDepartment.Text + "', ManagerID = '" + CmbManager.SelectedValue + "' WHERE DepartmentID = '" + TxtDepartmentID.Text + "' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show($"Department '{TxtDepartmentID.Text}' has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            F.LoadDepartments();
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
