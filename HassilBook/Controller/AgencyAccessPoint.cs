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
    public class AgencyAccessPoint
    {
        public List<AgencyModel> Login(string AgencyID, string Email, string Password)
        {
            AgencyModel model = new AgencyModel();
            List<AgencyModel> userInfo = new List<AgencyModel>();

            DatabaseConnection con = new DatabaseConnection();
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM tbl_ClientAgencies WHERE AgencyID = '" + AgencyID + "' AND Email = '" + Email + "' AND Password = '" + Password + "'", con.ActiveConnection()))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            model.ID = int.Parse(item.ItemArray[0].ToString());
                            model.OfficeID = int.Parse(item.ItemArray[1].ToString());
                            model.AgencyID = item.ItemArray[2].ToString();
                            model.JoinedDate = Convert.ToDateTime(item.ItemArray[3].ToString());
                            model.Company = item.ItemArray[4].ToString();
                            model.CompanyOwner = item.ItemArray[5].ToString();
                            model.Gender = item.ItemArray[6].ToString();
                            model.Street = item.ItemArray[7].ToString();
                            model.PostalCode = item.ItemArray[8].ToString();
                            model.City = item.ItemArray[9].ToString();
                            model.Country = item.ItemArray[10].ToString();
                            model.Telephone = item.ItemArray[11].ToString();
                            model.Email = item.ItemArray[12].ToString();
                            model.AgencyType = item.ItemArray[14].ToString();
                            model.Status = item.ItemArray[15].ToString();

                            userInfo.Add(model);
                        }
                        con.ActiveConnection();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials.");
                        con.ActiveConnection();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return userInfo;
        }
    }
}
