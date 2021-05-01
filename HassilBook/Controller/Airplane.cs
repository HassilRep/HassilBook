using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HassilBook
{
    /// <summary>
    /// Client airplane management
    /// </summary>
    public class Airplane
    {
        /// <summary>
        /// Adds new airplane on the database.
        /// </summary>
        /// <param name="airplane"></param>
        public void Add(AirplaneModel airplane)
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                var isRegistered = CheckAirplane(airplane.OfficeID, airplane.RegistrationNumber);
                if(isRegistered)
                {
                    MessageBox.Show("Sorry, this airplane has been already registered.","registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand(@"INSERT INTO tbl_ClientAirplanes(OfficeID, RegDate, RegNumber, Manufacturer, Model, Seats, Category, Status)
                                                          VALUES('"+ airplane.OfficeID + "','"+airplane.RegisteredDate.ToString("yyyy/MM/dd")+ "','"+airplane.RegistrationNumber+"','" + airplane.Manufacturer+"','"+airplane.Model+"','"+airplane.Seats+"','"+airplane.Category+"','"+airplane.Status+"')", con.ActiveConnection());
                    
                    MessageBox.Show("Congratulation, new airplane has been successfully registered.", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.ExecuteReader();
                    con.ActiveConnection().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /// <summary>
        /// updates selected airplane information
        /// </summary>
        /// <param name="air">current airplane</param>
        /// <param name="ID">current airplane ID</param>
        public void Edit(AirplaneModel air, int ID)
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE tbl_ClientAirplanes SET RegDate = '"+air.RegisteredDate.ToString("yyyy/MM/dd")+ "', RegNumber = '"+air.RegistrationNumber+ "', Manufacturer = '"+air.Manufacturer+ "', Model = '"+air.Model+ "', Seats = '"+air.Seats+ "', Category = '"+air.Category+ "', Status = '"+air.Status+ "' WHERE ID = '"+ID+"' AND OfficeID = '" + air.OfficeID+"'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Congratulation, airplane has been successfully updated.", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /// <summary>
        /// Deletes airplane from the Database.
        /// </summary>
        /// <param name="officeID">current officeID</param>
        /// <param name="regNumber">current airplane</param>
        public void Delete(int officeID, string regNumber)
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM tbl_ClientAirplanes WHERE RegNumber = '" + regNumber + "' AND OfficeID = '" + officeID + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Congratulation, airplane has been successfully deleted from the list.", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        
        /// <summary>
        /// Checks if the airplane already registered or not.
        /// </summary>
        /// <param name="officeID">current office ID</param>
        /// <param name="regNumber">current airplane</param>
        /// <returns></returns>
        private bool CheckAirplane(int officeID, string regNumber)
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM tbl_ClientAirplanes WHERE RegNumber = '" + regNumber + "' AND OfficeID = '" + officeID + "'", con.ActiveConnection());
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if(ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                    con.ActiveConnection().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
