using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassilBook
{
    public class IDGenerator
    {
        public string M_ClientDepartmentID;


        DatabaseConnection con = new DatabaseConnection();
        /// <summary>
        /// This generates airline department office ID
        /// </summary>
        public void ClientDepartmentID(int OfficeID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(MAX(CAST(RIGHT(DepartmentID, 7) AS INT)), 0) + 1 FROM tbl_ClientDepartment WHERE OfficeID = '" + OfficeID + "'", con.ActiveConnection());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string GeneratedID = "000000" + dr.GetInt32(0);
                    M_ClientDepartmentID = "DEP" + GeneratedID.Substring(GeneratedID.Length - 7, 7);
                }
                dr.Close();
                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
