using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassilBook
{
    public partial class FrmEmployees : Form
    {
        private int m_roleID;
        private int m_userID;
        private string m_Username;
        private string m_Employee;
        public FrmEmployees()
        {
            InitializeComponent();
            LoadDepartments();
            LoadEmployees();
            LoadEmployee();
            LoadRoles();
            ClearEmployeeComponents();
        }

        /// <summary>
        /// Load employees of the client
        /// </summary>
        private void LoadEmployees()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                int i = 0;
                DGClientEmployee.Rows.Clear();
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT E.EmployeeID, E.Firstname, E.Lastname, E.Email, E.Telephone, D.Description FROM tbl_ClientEmployees E INNER JOIN tbl_ClientDepartment D ON E.DepartmentID = D.ID WHERE E.OfficeID = '" + FrmLogin.OfficeID + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    DGClientEmployee.Rows.Add(i, dr["EmployeeID"].ToString(), dr["Firstname"].ToString(), dr["Lastname"].ToString(), dr["Email"].ToString(), dr["Telephone"].ToString(), dr["Description"].ToString());
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
        /// searchs employee information with the given keyword
        /// </summary>
        private void SearchEmployees()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                DGClientEmployee.Rows.Clear();
                int i = 0;
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT E.EmployeeID, E.Firstname, E.Lastname, E.Email, E.Telephone, D.Description FROM tbl_ClientEmployees E INNER JOIN tbl_ClientDepartment D ON E.DepartmentID = D.ID WHERE E.EmployeeID LIKE '%" + TxtSearchWith.Text + "%' AND E.OfficeID = '" + FrmLogin.OfficeID + "' OR E.Firstname LIKE '%" + TxtSearchWith.Text + "%' AND E.OfficeID = '" + FrmLogin.OfficeID + "' OR E.Lastname LIKE '%" + TxtSearchWith.Text + "%' AND E.OfficeID = '" + FrmLogin.OfficeID + "' OR E.Email LIKE '%" + TxtSearchWith.Text + "%' AND E.OfficeID = '" + FrmLogin.OfficeID + "' OR E.Telephone LIKE '%" + TxtSearchWith.Text + "%' AND E.OfficeID = '" + FrmLogin.OfficeID + "' OR D.Description LIKE '%" + TxtSearchWith.Text + "%' AND E.OfficeID = '" + FrmLogin.OfficeID + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    DGClientEmployee.Rows.Add(i, dr["EmployeeID"].ToString(), dr["Firstname"].ToString(), dr["Lastname"].ToString(), dr["Email"].ToString(), dr["Telephone"].ToString(), dr["Description"].ToString());
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
        /// Load departments of the client
        /// </summary>
        private void LoadDepartments()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                CmbDepartment.Items.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Description");
                dt.Rows.Add("0", "- Assign Department -");
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT ID, Description FROM tbl_ClientDepartment WHERE OfficeID = '" + FrmLogin.OfficeID + "'", con.ActiveConnection());
                DataTable table = new DataTable();
                sda.Fill(table);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in table.Rows)
                    {
                        dt.Rows.Add(item["ID"], item["Description"]);
                    }
                }
                CmbDepartment.DataSource = dt;
                CmbDepartment.ValueMember = "ID";
                CmbDepartment.DisplayMember = "Description";

                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /// <summary>
        /// Generated new employee ID
        /// </summary>
        private void LoadEmployeeID()
        {
            try
            {
                IDGenerator ID = new IDGenerator();
                ID.ClientEmployeeID(FrmLogin.OfficeID);
                TxtEmployeeID.Text = ID.M_ClientEmployeeID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Clears components of the employee
        /// </summary>
        private void ClearEmployeeComponents()
        {
            LoadEmployeeID();
            pcUserImage.Image = Properties.Resources.placeholder;
            TxtFirstname.Text = string.Empty;
            TxtLastname.Text = string.Empty;
            CmbGender.SelectedIndex = 0;
            TxtEmail.Text = string.Empty;
            TxtTelephone.Text = string.Empty;
            DtBirthdate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            DtHiredDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            CmbDepartment.SelectedIndex = 0;
            BtnAddEdit.Text = "ADD NEW EMPLOYEE";
        }

        /// <summary>
        /// Clears components of the Role
        /// </summary>
        private void ClearRoleComponents()
        {
            LoadUserRoles();
            TxtRole.Text = string.Empty;
            CmbRoleType.SelectedIndex = 0;
            BtnAddEdit.Text = "ADD NEW ROLE";
        }

        /// <summary>
        /// Clears components of the User
        /// </summary>
        private void ClearUserComponents()
        {
            LoadUsers();
            BtnAddEditUser.Text = "ADD NEW USER";
            TxtUsername.Text = string.Empty;
            CmbEmployee.SelectedIndex = 0;
            CmbRoles.SelectedIndex = 0;
            CmbStatus.SelectedIndex = 0;
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            EmployeePage.SelectTab("Employees");
            ClearEmployeeComponents();
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            ClearUserComponents();
            EmployeePage.SelectTab("Users");
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            ClearRoleComponents();
            EmployeePage.SelectTab("Roles");
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            Stream MyStream = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image File(*.jpe; *.jpeg; *.bmp; *.png) | *.jpg; *.jpeg; *.bmp; *.png";
            if (openFile.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((MyStream = openFile.OpenFile()) != null)
                    {
                        string FileName = openFile.FileName;
                        if (MyStream.Length > 512000)
                        {
                            MessageBox.Show("The data has exceeded it's limit. Max. allowance size is '512KB'", "Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            pcUserImage.Load(FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtSearchWith_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchEmployees();
            }
        }

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            if (TxtEmployeeID.Text == string.Empty || TxtFirstname.Text == string.Empty || TxtLastname.Text == string.Empty || CmbGender.SelectedIndex == 0 || TxtEmail.Text == string.Empty || TxtTelephone.Text == string.Empty || CmbDepartment.SelectedIndex == 0)
            {
                MessageBox.Show("To create or update employee profile, please fill the empty places.", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DatabaseConnection con = new DatabaseConnection();

                    if (BtnAddEdit.Text == "ADD NEW EMPLOYEE")
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_ClientEmployees(OfficeID, EmployeeID, Firstname, Lastname, Gender, Email, Telephone, Birthdate, HiredDate, DepartmentID, Image)VALUES('" + FrmLogin.OfficeID + "','" + TxtEmployeeID.Text + "','" + TxtFirstname.Text + "','" + TxtLastname.Text + "','" + CmbGender.Text + "','" + TxtEmail.Text + "','" + TxtTelephone.Text + "','" + DtBirthdate.Value.ToString("yyyy/MM/dd") + "','" + DtHiredDate.Value.ToString("yyyy/MM/dd") + "','" + CmbDepartment.SelectedValue + "',@img)", con.ActiveConnection());
                        MemoryStream ms = new MemoryStream();
                        pcUserImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] pic = ms.ToArray();
                        cmd.Parameters.AddWithValue("@img", pic);
                        cmd.ExecuteNonQuery();
                        LoadEmployeeID();
                        LoadEmployees();
                        con.ActiveConnection().Close();

                        ClearEmployeeComponents();
                    }
                    else
                    {
                        MySqlCommand cmd;
                        cmd = con.ActiveConnection().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE tbl_ClientEmployees SET Firstname = '" + TxtFirstname.Text + "', Lastname = '" + TxtLastname.Text + "', Gender = '" + CmbGender.Text + "', Email = '" + TxtEmail.Text + "', Telephone = '" + TxtTelephone.Text + "', Birthdate = '" + DtBirthdate.Value.ToString("yyyy/MM/dd") + "', HiredDate = '" + DtHiredDate.Value.ToString("yyyy/MM/dd") + "', DepartmentID = '" + CmbDepartment.SelectedValue + "', Image = @img WHERE EmployeeID = '" + TxtEmployeeID.Text + "' AND OfficeID = '" + FrmLogin.OfficeID + "'";
                        MemoryStream ms = new MemoryStream();
                        pcUserImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] pic = ms.ToArray();
                        cmd.Parameters.AddWithValue("@img", pic);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Employee '{TxtEmployeeID.Text}' has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmployeeID();
                        LoadEmployees();
                        con.ActiveConnection().Close();

                        ClearEmployeeComponents();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DGClientEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cel = DGClientEmployee.Columns[e.ColumnIndex].Name;
            DatabaseConnection con = new DatabaseConnection();
            try
            {
                if (cel == "EDIT")
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT E.EmployeeID, E.Firstname, E.Lastname, E.Gender, E.Email, E.Telephone, E.Birthdate, E.HiredDate, D.Description, E.Image  FROM tbl_ClientEmployees E INNER JOIN tbl_ClientDepartment D ON E.DepartmentID = D.ID WHERE E.EmployeeID = '" + this.DGClientEmployee[1, e.RowIndex].Value.ToString() + "' AND E.OfficeID = '" + FrmLogin.OfficeID + "'", con.ActiveConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    TxtEmployeeID.Text = dt.Rows[0]["EmployeeID"].ToString();
                    TxtFirstname.Text = dt.Rows[0]["Firstname"].ToString();
                    TxtLastname.Text = dt.Rows[0]["Lastname"].ToString();
                    CmbGender.Text = dt.Rows[0]["Gender"].ToString();
                    TxtEmail.Text = dt.Rows[0]["Email"].ToString();
                    TxtTelephone.Text = dt.Rows[0]["Telephone"].ToString();
                    DtBirthdate.Text = dt.Rows[0]["Birthdate"].ToString();
                    DtHiredDate.Text = dt.Rows[0]["HiredDate"].ToString();
                    CmbDepartment.Text = dt.Rows[0]["Description"].ToString();

                    byte[] UserImage = Convert.IsDBNull(dt.Rows[0]["Image"]) ? null : (byte[])dt.Rows[0]["Image"];

                    if (Convert.IsDBNull(dt.Rows[0]["Image"] == DBNull.Value))
                    {
                        pcUserImage.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(UserImage);
                        pcUserImage.Image = Image.FromStream(ms);
                    }
                    da.Dispose();
                    con.ActiveConnection().Close();
                    BtnAddEdit.Text = "UPDATE EMPLOYEE";
                }
                else if (cel == "DEL")
                {
                    if (MessageBox.Show($"Do you want to delete this employee '{DGClientEmployee[1, e.RowIndex].Value.ToString()}' from the list?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //if (DGClientEmployee[1, e.RowIndex].Value.ToString() == FrmLogin.EmployeeProfile[1].ToString())
                        //{
                        //    MessageBox.Show($"Sorry you can't remove your self from the list. Please contact your adminstrator for more info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                        //else
                        //{
                        //    MySqlCommand cmd;
                        //    cmd = con.ActiveConnection().CreateCommand();
                        //    cmd.CommandType = CommandType.Text;
                        //    cmd.CommandText = "DELETE FROM tbl_ClientEmployees WHERE EmployeeID = '" + this.DGClientEmployee[1, e.RowIndex].Value.ToString() + "' AND OfficeID = '" + FrmLogin.OfficeID + "'";
                        //    cmd.ExecuteNonQuery();
                        //    MessageBox.Show($"Employee '{DGClientEmployee[1, e.RowIndex].Value.ToString()}' has been delete from the list.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //    LoadEmployeeID();
                        //    LoadEmployees();
                        //    LoadDepartments();
                        //    con.ActiveConnection().Close();

                        //    ClearEmployeeComponents();
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // USER ROLES

        /// <summary>
        /// Load user roles of the client
        /// </summary>
        private void LoadUserRoles()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                int i = 0;
                DGClientUserRoles.Rows.Clear();
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tbl_ClientUserRoles WHERE OfficeID = '" + FrmLogin.OfficeID + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    DGClientUserRoles.Rows.Add(i, dr["Role"].ToString(), dr["RoleType"].ToString());
                }
                dr.Close();
                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddEditRole_Click(object sender, EventArgs e)
        {
            if (TxtRole.Text == string.Empty || CmbRoleType.SelectedIndex == 0)
            {
                MessageBox.Show("To create or update user roles, please fill the empty places.", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DatabaseConnection con = new DatabaseConnection();

                    if (BtnAddEditRole.Text == "ADD NEW ROLE")
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_ClientUserRoles(OfficeID,Role,RoleType)VALUES('" + FrmLogin.OfficeID + "','" + TxtRole.Text + "','" + CmbRoleType.Text + "')", con.ActiveConnection());
                        cmd.ExecuteReader();
                        LoadUserRoles();
                        con.ActiveConnection().Close();
                        TxtRole.Text = string.Empty;
                        CmbRoleType.SelectedIndex = 0;
                    }
                    else
                    {
                        MySqlCommand cmd;
                        cmd = con.ActiveConnection().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE tbl_ClientUserRoles SET Role = '" + TxtRole.Text + "',RoleType = '" + CmbRoleType.Text + "' WHERE ID = '" + m_roleID + "' AND OfficeID = '" + FrmLogin.OfficeID + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Role '{TxtRole.Text}' has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUserRoles();
                        con.ActiveConnection().Close();
                        TxtRole.Text = string.Empty;
                        CmbRoleType.SelectedIndex = 0;
                        BtnAddEdit.Text = "ADD NEW ROLE";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DGClientUserRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cel = DGClientUserRoles.Columns[e.ColumnIndex].Name;
            DatabaseConnection con = new DatabaseConnection();
            try
            {
                if (cel == "UPDATE")
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tbl_ClientUserRoles WHERE Role = '" + this.DGClientUserRoles[1, e.RowIndex].Value.ToString() + "' AND OfficeID = '" + FrmLogin.OfficeID + "'", con.ActiveConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    m_roleID = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
                    TxtRole.Text = dt.Rows[0]["Role"].ToString();
                    CmbRoleType.Text = dt.Rows[0]["RoleType"].ToString();
                    da.Dispose();
                    con.ActiveConnection().Close();
                    BtnAddEditRole.Text = "UPDATE ROLE";
                }
                else if (cel == "DELETE")
                {
                    if (MessageBox.Show($"Do you want to delete this role '{DGClientUserRoles[1, e.RowIndex].Value.ToString()}' from the list?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand cmd;
                        cmd = con.ActiveConnection().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM tbl_ClientUserRoles WHERE Role = '" + DGClientUserRoles[1, e.RowIndex].Value.ToString() + "' AND OfficeID = '" + FrmLogin.OfficeID + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Role '{DGClientUserRoles[1, e.RowIndex].Value.ToString()}' has been delete from the list.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadUserRoles();
                        con.ActiveConnection().Close();

                        ClearRoleComponents();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // USERS


        /// <summary>
        /// Load users of the client
        /// </summary>
        private void LoadUsers()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                int i = 0;
                DGClientUsers.Rows.Clear();
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT E.EmployeeID, U.Username, R.Role, U.Status FROM tbl_ClientUsers U INNER JOIN tbl_ClientEmployees E ON U.EmployeeID = E.ID INNER JOIN tbl_ClientUserRoles R ON U.RoleID = R.ID WHERE U.OfficeID = '" + FrmLogin.OfficeID + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    DGClientUsers.Rows.Add(i, dr["EmployeeID"].ToString(), dr["Username"].ToString(), dr["Role"].ToString(), dr["Status"].ToString());
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
        /// searchs user information with the given keyword
        /// </summary>
        private void SearchUsers()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                DGClientUsers.Rows.Clear();
                int i = 0;
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT E.EmployeeID, U.Username, R.Role, U.Status FROM tbl_ClientUsers U INNER JOIN tbl_ClientEmployees E ON U.EmployeeID = E.ID INNER JOIN tbl_ClientUserRoles R ON U.RoleID = R.ID WHERE E.EmployeeID LIKE '%" + TxtSearchWithKeyword.Text + "%' AND U.OfficeID = '" + FrmLogin.OfficeID + "' OR U.Username LIKE '%" + TxtSearchWithKeyword.Text + "%' AND U.OfficeID = '" + FrmLogin.OfficeID + "' OR R.Role LIKE '%" + TxtSearchWithKeyword.Text + "%' AND U.OfficeID = '" + FrmLogin.OfficeID + "' OR U.Status LIKE '%" + TxtSearchWithKeyword.Text + "%' AND U.OfficeID = '" + FrmLogin.OfficeID + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    DGClientUsers.Rows.Add(i, dr["EmployeeID"].ToString(), dr["Username"].ToString(), dr["Role"].ToString(), dr["Status"].ToString());
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
        /// Load the roles of the client users
        /// </summary>
        private void LoadRoles()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                CmbRoles.Items.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Role");
                dt.Rows.Add("0", "- Assign Role -");
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT ID, Role FROM tbl_ClientUserRoles WHERE OfficeID = '" + FrmLogin.OfficeID + "'", con.ActiveConnection());
                DataTable table = new DataTable();
                sda.Fill(table);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in table.Rows)
                    {
                        dt.Rows.Add(item["ID"], item["Role"]);
                    }
                }
                CmbRoles.DataSource = dt;
                CmbRoles.ValueMember = "ID";
                CmbRoles.DisplayMember = "Role";

                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Load the employee of the user
        /// </summary>
        private void LoadEmployee()
        {
            try
            {
                
                DatabaseConnection con = new DatabaseConnection();
                CmbEmployee.Items.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Firstname");
                dt.Rows.Add("0", "- Assign Employee -");
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT ID, Firstname FROM tbl_ClientEmployees WHERE OfficeID = '" + FrmLogin.OfficeID + "'", con.ActiveConnection());
                DataTable table = new DataTable();
                sda.Fill(table);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in table.Rows)
                    {
                        dt.Rows.Add(item["ID"], item["Firstname"]);
                    }
                }
                CmbEmployee.DataSource = dt;
                CmbEmployee.ValueMember = "ID";
                CmbEmployee.DisplayMember = "Firstname";

                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtSearchWithKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchUsers();
            }
        }

        private void BtnAddEditUser_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == string.Empty || CmbEmployee.SelectedIndex == 0 || CmbRoles.SelectedIndex == 0 || CmbStatus.SelectedIndex == 0)
            {
                MessageBox.Show("To create or update user, please fill the empty places.", "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DatabaseConnection con = new DatabaseConnection();
                    if (BtnAddEditUser.Text == "ADD NEW USER")
                    {
                        MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM tbl_ClientUsers WHERE Username = '" + TxtUsername.Text + "' AND OfficeID = '" + FrmLogin.OfficeID + "'", con.ActiveConnection());
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            MessageBox.Show("The username '" + TxtUsername.Text + "' is already taken", "Already taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ds.Clear();
                        }
                        else
                        {
                            MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM tbl_ClientUsers WHERE EmployeeID = '" + CmbEmployee.SelectedValue + "' AND OfficeID = '" + FrmLogin.OfficeID + "'", con.ActiveConnection());
                            DataSet ds1 = new DataSet();
                            sda1.Fill(ds1);
                            if (ds1.Tables[0].Rows.Count > 0)
                            {
                                MessageBox.Show("The employee '" + CmbEmployee.Text + "' is already assigned a user", "Already taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ds1.Clear();
                            }
                            else
                            {
                                string InitialPassword = "hassilbook";
                                MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_ClientUsers(OfficeID, EmployeeID, Username, Password, RoleID,Status)VALUES('" + FrmLogin.OfficeID + "','" + CmbEmployee.SelectedValue + "','" + TxtUsername.Text + "','" + InitialPassword + "','" + CmbRoles.SelectedValue + "','" + CmbStatus.Text + "')", con.ActiveConnection());
                                cmd.ExecuteNonQuery();
                                MessageBox.Show($"User '{TxtUsername.Text}' has been created.", "created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                con.ActiveConnection().Close();
                                ClearUserComponents();
                            }
                        }
                    }
                    else
                    {
                        if (TxtUsername.Text.ToLower() != m_Username.ToLower())
                        {
                            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM tbl_ClientUsers WHERE Username = '" + TxtUsername.Text + "' AND OfficeID = '" + FrmLogin.OfficeID + "'", con.ActiveConnection());
                            DataSet ds = new DataSet();
                            sda.Fill(ds);
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                MessageBox.Show("The username '" + TxtUsername.Text + "' is already taken", "Already taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ds.Clear();
                            }
                            else
                            {
                                if(CmbEmployee.Text.ToLower() != m_Employee.ToLower())
                                {
                                    MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM tbl_ClientUsers WHERE EmployeeID = '" + CmbEmployee.SelectedValue + "' AND OfficeID = '" + FrmLogin.OfficeID + "'", con.ActiveConnection());
                                    DataSet ds1 = new DataSet();
                                    sda1.Fill(ds1);
                                    if (ds1.Tables[0].Rows.Count > 0)
                                    {
                                        MessageBox.Show("The employee '" + CmbEmployee.Text + "' is already assigned a user", "Already taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        ds1.Clear();
                                    }
                                    else
                                    {
                                        MySqlCommand cmd;
                                        cmd = con.ActiveConnection().CreateCommand();
                                        cmd.CommandType = CommandType.Text;
                                        cmd.CommandText = "UPDATE tbl_ClientUsers SET Username = '" + TxtUsername.Text + "', RoleID = '" + CmbRoles.SelectedValue + "',Status = '" + CmbStatus.Text + "' WHERE ID = '" + m_userID + "' AND OfficeID = '" + FrmLogin.OfficeID + "'";
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show($"User '{TxtUsername.Text}' has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        con.ActiveConnection().Close();
                                        ClearUserComponents();
                                    }
                                }
                                else
                                {
                                    MySqlCommand cmd;
                                    cmd = con.ActiveConnection().CreateCommand();
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = "UPDATE tbl_ClientUsers SET Username = '" + TxtUsername.Text + "', RoleID = '" + CmbRoles.SelectedValue + "',Status = '" + CmbStatus.Text + "' WHERE ID = '" + m_userID + "' AND OfficeID = '" + FrmLogin.OfficeID + "'";
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show($"User '{TxtUsername.Text}' has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    con.ActiveConnection().Close();
                                    ClearUserComponents();
                                }
                            }
                        }
                        else
                        {
                            if (CmbEmployee.Text.ToLower() != m_Employee.ToLower())
                            {
                                MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM tbl_ClientUsers WHERE EmployeeID = '" + CmbEmployee.SelectedValue + "' AND OfficeID = '" + FrmLogin.OfficeID + "'", con.ActiveConnection());
                                DataSet ds1 = new DataSet();
                                sda1.Fill(ds1);
                                if (ds1.Tables[0].Rows.Count > 0)
                                {
                                    MessageBox.Show("The employee '" + CmbEmployee.Text + "' is already assigned a user", "Already taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    ds1.Clear();
                                }
                                else
                                {
                                    MySqlCommand cmd;
                                    cmd = con.ActiveConnection().CreateCommand();
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = "UPDATE tbl_ClientUsers SET Username = '" + TxtUsername.Text + "', RoleID = '" + CmbRoles.SelectedValue + "',Status = '" + CmbStatus.Text + "' WHERE ID = '" + m_userID + "' AND OfficeID = '" + FrmLogin.OfficeID + "'";
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show($"User '{TxtUsername.Text}' has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    con.ActiveConnection().Close();
                                    ClearUserComponents();
                                }
                            }
                            else
                            {
                                MySqlCommand cmd;
                                cmd = con.ActiveConnection().CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "UPDATE tbl_ClientUsers SET Username = '" + TxtUsername.Text + "', RoleID = '" + CmbRoles.SelectedValue + "',Status = '" + CmbStatus.Text + "' WHERE ID = '" + m_userID + "' AND OfficeID = '" + FrmLogin.OfficeID + "'";
                                cmd.ExecuteNonQuery();
                                MessageBox.Show($"User '{TxtUsername.Text}' has been updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                con.ActiveConnection().Close();
                                ClearUserComponents();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DGClientUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cel = DGClientUsers.Columns[e.ColumnIndex].Name;
            DatabaseConnection con = new DatabaseConnection();
            try
            {
                if (cel == "EDT")
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT U.ID, U.Username, E.Firstname, R.Role, U.Status FROM tbl_ClientUsers U INNER JOIN tbl_ClientEmployees E ON U.EmployeeID = E.ID INNER JOIN tbl_ClientUserRoles R ON U.RoleID = R.ID WHERE U.Username = '" + this.DGClientUsers[2, e.RowIndex].Value.ToString() + "' AND U.OfficeID = '" + FrmLogin.OfficeID + "'", con.ActiveConnection());
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    m_userID = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
                    TxtUsername.Text = dt.Rows[0]["Username"].ToString();
                    m_Username = dt.Rows[0]["Username"].ToString();
                    CmbEmployee.Text = dt.Rows[0]["Firstname"].ToString();
                    m_Employee = dt.Rows[0]["Firstname"].ToString();
                    CmbRoles.Text = dt.Rows[0]["Role"].ToString();
                    CmbStatus.Text = dt.Rows[0]["Status"].ToString();
                    da.Dispose();
                    con.ActiveConnection().Close();
                    BtnAddEditUser.Text = "UPDATE USER";
                }
                else if (cel == "DL")
                {
                    if (MessageBox.Show($"Do you want to delete this user '{DGClientUsers[2, e.RowIndex].Value.ToString()}' from the list?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //if (DGClientUsers[2, e.RowIndex].Value.ToString().ToLower() == FrmLogin.OfficeID)
                        //{
                        //    MessageBox.Show($"Sorry you can't remove your self from the list. Please contact your adminstrator for more info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                        //else
                        //{
                        //    MySqlCommand cmd;
                        //    cmd = con.ActiveConnection().CreateCommand();
                        //    cmd.CommandType = CommandType.Text;
                        //    cmd.CommandText = "DELETE FROM tbl_ClientUsers WHERE Username = '" + DGClientUsers[2, e.RowIndex].Value.ToString() + "' AND OfficeID = '" + FrmClientLogin.ClientProfile[0] + "'";
                        //    cmd.ExecuteNonQuery();
                        //    MessageBox.Show($"User '{DGClientUsers[2, e.RowIndex].Value.ToString()}' has been delete from the list.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //    LoadRoles();
                        //    LoadUsers();
                        //    LoadEmployees();
                        //    con.ActiveConnection().Close();

                        //    TxtUsername.Text = string.Empty;
                        //    CmbEmployee.SelectedIndex = 0;
                        //    CmbRoles.SelectedIndex = 0;
                        //    CmbStatus.SelectedIndex = 0;
                        //    BtnAddEdit.Text = "ADD NEW USER";
                        //}
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
