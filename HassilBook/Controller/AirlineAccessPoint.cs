using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassilBook
{
    public class AirlineAccessPoint
    {
        public List<string> Login(string OfficeID, string UsernameOrEmail, string Password)
        {
            List<string> userInfo = new List<string>();
            DatabaseConnection con = new DatabaseConnection();
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT C.OfficeID, U.Username, E.Email, U.Password, C.Status AS ClientStatus, U.Status AS UserStatus, R.Role, R.RoleType FROM tbl_ClientUsers U INNER JOIN tbl_Clients C ON U.OfficeID = C.ID INNER JOIN tbl_ClientEmployees E ON U.EmployeeID = E.ID INNER JOIN tbl_ClientUserRoles R ON U.RoleID = R.ID WHERE C.OfficeID = '" + OfficeID + "' AND U.Username = '" + UsernameOrEmail + "' AND U.Password = '" + Password + "' OR C.OfficeID = '" + OfficeID + "' AND E.Email = '" + UsernameOrEmail + "' AND U.Password = '" + Password + "'", con.ActiveConnection());
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    var IsLicenseActive = CheckLicense(OfficeID);
                    if (IsLicenseActive)
                    {
                        if(dt.Rows[0]["ClientStatus"].ToString() == "Active")
                        {
                            if (dt.Rows[0]["UserStatus"].ToString() == "Active")
                            {
                                userInfo.Add(dt.Rows[0]["Role"].ToString());
                                userInfo.Add(dt.Rows[0]["RoleType"].ToString());
                            }
                            else
                            {
                                MessageBox.Show("User is not active");
                            }
                        }
                        else
                        {
                            MessageBox.Show("client is not active for somehow");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Access not granted, license in expired");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return userInfo;
        }

        private bool CheckLicense(string OfficeID)
        {
            try
            {
                var clientInfo = ClientProfile(OfficeID);

                if(clientInfo.SubscriptionType != "Lifetime")
                {
                    // License expiration date (9th index)
                    var LisenceDate = Convert.ToDateTime(clientInfo.LicenseExpiry).ToString("yyyy/MM/dd");

                    if (Convert.ToDateTime(DateTime.UtcNow.ToString("yyyy/MM/dd")) > Convert.ToDateTime(LisenceDate))
                    {
                        return false;
                        string status = "Deactivated";
                        DatabaseConnection con = new DatabaseConnection();
                        MySqlCommand cmdupdate = new MySqlCommand("UPDATE tbl_Clients SET Status = '" + status + "'", con.ActiveConnection());
                        cmdupdate.ExecuteNonQuery();
                        con.ActiveConnection().Close();
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Fetch client profile information and subscription type
        /// </summary>
        /// <param name="OfficeID">Client officeID</param>
        /// <returns>List of client information</returns>
        public ClientModel ClientProfile(string OfficeID)
        {
            ClientModel client = new ClientModel();
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT C.ID, C.OfficeID, C.Company, C.JoinDate, C.Email, C.Telephone, C.Street, C.PostalCode, C.City, C.Country, S.SubscriptionType, C.LicenseExpires, C.Status, C.Logo FROM tbl_Clients C INNER JOIN tbl_ClientSubscriptionType S ON C.Subscription_ID = S.ID", con.ActiveConnection());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    client.ClientID = int.Parse(dt.Rows[0]["ID"].ToString());
                    client.OfficeID = dt.Rows[0]["OfficeID"].ToString();
                    client.Company = dt.Rows[0]["Company"].ToString();
                    client.JoinDate = Convert.ToDateTime(dt.Rows[0]["JoinDate"].ToString());
                    client.Email = dt.Rows[0]["Email"].ToString();
                    client.Telephone = dt.Rows[0]["Telephone"].ToString();
                    client.Street = dt.Rows[0]["Street"].ToString();
                    client.PostalCode = dt.Rows[0]["PostalCode"].ToString();
                    client.City = dt.Rows[0]["City"].ToString();
                    client.Country = dt.Rows[0]["Country"].ToString();
                    client.SubscriptionType = dt.Rows[0]["SubscriptionType"].ToString();
                    client.LicenseExpiry = Convert.ToDateTime(dt.Rows[0]["LicenseExpires"].ToString());
                    client.Status = dt.Rows[0]["Status"].ToString();
                    client.Logo = (byte[])dt.Rows[0]["Logo"];
                }
                con.ActiveConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return client;
        }

        /// <summary>
        /// Loads client employee profile information
        /// </summary>
        /// <param name="OfficeID">Client office ID</param>
        /// <param name="Username">Username of the employee</param>
        /// <returns>List of diferent collention info from diff. tables</returns>
        public EmployeeModel ClientEmployeeProfile(string OfficeID, string Username)
        {
            EmployeeModel employee = new EmployeeModel();
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                MySqlDataAdapter sda = new MySqlDataAdapter($@"SELECT E.ID, E.EmployeeID, E.Firstname, E.Lastname, E.Gender, E.Email, E.Telephone, E.Birthdate, E.HiredDate, D.Description, U.Username, R.Role, E.Image FROM tbl_ClientEmployees E 
                                                        INNER JOIN tbl_ClientUsers U ON U.EmployeeID = E.ID
                                                        INNER JOIN tbl_Clients C ON E.OfficeID = C.ID
                                                        INNER JOIN tbl_ClientDepartment D ON E.DepartmentID = D.ID
                                                        INNER JOIN tbl_ClientUserRoles R ON U.RoleID = R.ID
                                                        WHERE U.Username = '" + Username + "' AND C.OfficeID = '" + OfficeID + "'", con.ActiveConnection());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    employee.ID = int.Parse(dt.Rows[0]["ID"].ToString());
                    employee.EmployeeID = dt.Rows[0]["EmployeeID"].ToString();
                    employee.Firstname = dt.Rows[0]["Firstname"].ToString();
                    employee.Lastname = dt.Rows[0]["Lastname"].ToString();
                    employee.Gender = dt.Rows[0]["Gender"].ToString();
                    employee.Email = dt.Rows[0]["Email"].ToString();
                    employee.Telephone = dt.Rows[0]["Telephone"].ToString();
                    employee.Birthdate = Convert.ToDateTime(dt.Rows[0]["Birthdate"].ToString());
                    employee.HiredDate = Convert.ToDateTime(dt.Rows[0]["HiredDate"].ToString());
                    employee.Department = dt.Rows[0]["Description"].ToString();
                    employee.Username = dt.Rows[0]["Username"].ToString();
                    employee.Role = dt.Rows[0]["Role"].ToString();
                    employee.UserImage = (byte[])dt.Rows[0]["Image"];
                }
                con.ActiveConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return employee;
        }
    }
}
