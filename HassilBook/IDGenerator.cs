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
        public string M_ClientEmployeeID;
        public string M_ClientAgencyID;
        public string M_ClientPriceID;
        public string M_ClientFlightID;
        public string M_ClientWalletPaymentID;


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

        /// <summary>
        /// This generates travel agencies employee ID
        /// </summary>
        public void ClientEmployeeID(int OfficeID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(MAX(CAST(RIGHT(EmployeeID, 7) AS INT)), 0) + 1 FROM tbl_ClientEmployees WHERE OfficeID = '" + OfficeID + "'", con.ActiveConnection());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string GeneratedID = "000000" + dr.GetInt32(0);
                    M_ClientEmployeeID = "EMP" + GeneratedID.Substring(GeneratedID.Length - 7, 7);
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
        /// This generates client travel agencies ID
        /// </summary>
        public void ClientAgencyID(int OfficeID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(MAX(CAST(RIGHT(AgencyID, 4) AS INT)), 0) + 1 FROM tbl_ClientAgencies WHERE OfficeID = '" + OfficeID + "'", con.ActiveConnection());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string GeneratedID = "0000" + dr.GetInt32(0);
                    M_ClientAgencyID = "AG" + GeneratedID.Substring(GeneratedID.Length - 4, 4);
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
        /// This generates client price ID
        /// </summary>
        public void ClientPriceID(int OfficeID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(MAX(CAST(RIGHT(PriceID, 7) AS INT)), 0) + 1 FROM tbl_ClientFlightPrices WHERE OfficeID = '" + OfficeID + "'", con.ActiveConnection());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string GeneratedID = "000000" + dr.GetInt32(0);
                    M_ClientPriceID = "PRS" + GeneratedID.Substring(GeneratedID.Length - 7, 7);
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
        /// This generates client flight ID
        /// </summary>
        public void ClientFlightID(int OfficeID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(MAX(CAST(RIGHT(FlightID, 7) AS INT)), 0) + 1 FROM tbl_ClientFlights WHERE OfficeID = '" + OfficeID + "'", con.ActiveConnection());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string GeneratedID = "000000" + dr.GetInt32(0);
                    M_ClientFlightID = "FLT" + GeneratedID.Substring(GeneratedID.Length - 7, 7);
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
        /// This generates client wallet payment ID
        /// </summary>
        public void ClientWalletPaymentID(int OfficeID)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(MAX(CAST(RIGHT(Refrence, 7) AS INT)), 0) + 1 FROM tbl_ClientHaWallet WHERE Refrence LIKE 'WCR%' AND OfficeID = '" + OfficeID + "'", con.ActiveConnection());
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string GeneratedID = "000000" + dr.GetInt32(0);
                    M_ClientWalletPaymentID = "WCR" + GeneratedID.Substring(GeneratedID.Length - 7, 7);
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
