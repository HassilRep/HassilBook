using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HassilBook
{
    public class DatabaseConnection
    {
        /// <summary>
        /// Establishing the connection between the server database and the application
        /// </summary>
        MySqlConnection con = new MySqlConnection("Server=82.165.185.88;Port=3306;Database=HassilBookDB;Uid=hassilbook;Pwd=Hassilbook**1;");
        public MySqlConnection ActiveConnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return con;
            }
        }
    }
}
