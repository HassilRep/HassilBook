using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HassilBook
{
    public partial class FrmFlights : Form
    {
        public FrmFlights()
        {
            InitializeComponent();
            LoadAirports();

            DtFrom.Text = DateTime.Now.ToString();
            DtTo.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// Load Airports from the database
        /// </summary>
        private void LoadAirports()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                CmbFrom.Items.Clear();
                CmbTo.Items.Clear();
                DataTable dtFrom = new DataTable();
                DataTable dtTo = new DataTable();
                dtFrom.Columns.Add("ID");
                dtFrom.Columns.Add("Airport");
                dtFrom.Rows.Add("0", "- Origin -");

                dtTo.Columns.Add("ID");
                dtTo.Columns.Add("Airport");
                dtTo.Rows.Add("0", "- Destination -");

                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT ID, Airport FROM tbl_Airports", con.ActiveConnection());
                DataTable table = new DataTable();
                sda.Fill(table);
                if (dtFrom.Rows.Count > 0)
                {
                    foreach (DataRow item in table.Rows)
                    {
                        dtFrom.Rows.Add(item["ID"], item["Airport"]);
                        dtTo.Rows.Add(item["ID"], item["Airport"]);
                    }
                }
                CmbFrom.DataSource = dtFrom;
                CmbFrom.ValueMember = "ID";
                CmbFrom.DisplayMember = "Airport";

                CmbTo.DataSource = dtTo;
                CmbTo.ValueMember = "ID";
                CmbTo.DisplayMember = "Airport";

                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
