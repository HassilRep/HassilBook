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
                cmd.CommandText = "SELECT D.DepartmentID, D.Description, CASE WHEN D.ManagerID IS NOT NULL THEN E.Firstname ELSE 'No Manager assigned yet' END AS Manager FROM tbl_ClientDepartment D LEFT JOIN tbl_ClientEmployees E ON D.ManagerID = E.ID WHERE D.OfficeID = '" + FrmLogin.OfficeID + "' ORDER BY D.ID ASC";
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
            ID.ClientDepartmentID(FrmLogin.OfficeID);
            F.TxtDepartmentID.Text = ID.M_ClientDepartmentID;
            F.ShowDialog();
        }

        private void DGClientDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
