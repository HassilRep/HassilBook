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
            LoadPrices();
            LoadFlightModels();
            Clear();
        }

        private void Clear()
        {
            DtFrom.Text = DateTime.Now.ToShortDateString();
            DtTo.Text = DateTime.Now.ToShortDateString();
            DtDepDate.Text = DateTime.Now.ToShortDateString();

            LoadFlightID();
            LoadFlights();

            TxtFlightNo.Text = string.Empty;
            CmbAirplaneModel.SelectedIndex = 0;
            CmbFrom.SelectedIndex = 0;
            CmbTo.SelectedIndex = 0;
            CmbPriceType.SelectedIndex = 0;
            CmbOrigin.SelectedIndex = 0;
            CmbDestination.SelectedIndex = 0;
            CmbStatus.SelectedIndex = 0;
            CmbStop.SelectedIndex = 0;
            TxtEconomySeats.Text = string.Empty;
            TxtBusinessSeats.Text = string.Empty;
            TxtDepTime.Text = string.Empty;
            TxtArrTime.Text = string.Empty;
            CbStop.Checked = false;
        }

        /// <summary>
        /// Generates flight ID
        /// </summary>
        private void LoadFlightID()
        {
            IDGenerator ID = new IDGenerator();
            ID.ClientFlightID(FrmLogin.m_client.ClientID);
            TxtFlightID.Text = ID.M_ClientFlightID;
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
                CmbOrigin.Items.Clear();
                CmbDestination.Items.Clear();
                CmbStop.Items.Clear();

                DataTable dtFrom = new DataTable();
                DataTable dtTo = new DataTable();
                DataTable dtOrigin = new DataTable();
                DataTable dtDestination = new DataTable();
                DataTable dtStop = new DataTable();

                dtFrom.Columns.Add("ID");
                dtFrom.Columns.Add("City");
                dtFrom.Rows.Add("0", "- From -");

                dtTo.Columns.Add("ID");
                dtTo.Columns.Add("City");
                dtTo.Rows.Add("0", "- To -");

                dtOrigin.Columns.Add("ID");
                dtOrigin.Columns.Add("Airport");
                dtOrigin.Rows.Add("0", "- Origin -");

                dtDestination.Columns.Add("ID");
                dtDestination.Columns.Add("Airport");
                dtDestination.Rows.Add("0", "- Destination -");

                dtStop.Columns.Add("ID");
                dtStop.Columns.Add("Airport");
                dtStop.Rows.Add("0", "- Stop -");

                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT ID, Airport, City FROM tbl_Airports", con.ActiveConnection());
                DataTable table = new DataTable();
                sda.Fill(table);
                if (dtFrom.Rows.Count > 0)
                {
                    foreach (DataRow item in table.Rows)
                    {
                        dtFrom.Rows.Add(item["ID"], item["City"]);
                        dtTo.Rows.Add(item["ID"], item["City"]);
                        dtOrigin.Rows.Add(item["ID"], item["Airport"]);
                        dtDestination.Rows.Add(item["ID"], item["Airport"]);
                        dtStop.Rows.Add(item["ID"], item["Airport"]);
                    }
                }
                CmbFrom.DataSource = dtFrom;
                CmbFrom.ValueMember = "ID";
                CmbFrom.DisplayMember = "City";

                CmbTo.DataSource = dtTo;
                CmbTo.ValueMember = "ID";
                CmbTo.DisplayMember = "City";

                CmbOrigin.DataSource = dtOrigin;
                CmbOrigin.ValueMember = "ID";
                CmbOrigin.DisplayMember = "Airport";

                CmbDestination.DataSource = dtDestination;
                CmbDestination.ValueMember = "ID";
                CmbDestination.DisplayMember = "Airport";

                CmbStop.DataSource = dtStop;
                CmbStop.ValueMember = "ID";
                CmbStop.DisplayMember = "Airport";

                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Load price type from the database
        /// </summary>
        private void LoadPrices()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                CmbPriceType.Items.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("PriceType");
                dt.Rows.Add("0", "- Price type -");

                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT ID, PriceType FROM tbl_ClientFlightPrices", con.ActiveConnection());
                DataTable table = new DataTable();
                sda.Fill(table);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in table.Rows)
                    {
                        dt.Rows.Add(item["ID"], item["PriceType"]);
                    }
                }
                CmbPriceType.DataSource = dt;
                CmbPriceType.ValueMember = "ID";
                CmbPriceType.DisplayMember = "PriceType";

                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Load flight models from the database
        /// </summary>
        private void LoadFlightModels()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                CmbAirplaneModel.Items.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Model");
                dt.Rows.Add("0", "- Airplane model -");

                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT ID, Model FROM tbl_ClientAirplanes", con.ActiveConnection());
                DataTable table = new DataTable();
                sda.Fill(table);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in table.Rows)
                    {
                        dt.Rows.Add(item["ID"], item["Model"]);
                    }
                }
                CmbAirplaneModel.DataSource = dt;
                CmbAirplaneModel.ValueMember = "ID";
                CmbAirplaneModel.DisplayMember = "Model";

                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Loads airline saved flights
        /// </summary>
        private void LoadFlights()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                DGClientFlights.Rows.Clear();
                int i = 1;
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT F.FlightID, F.FlightNo, P.PriceType, O.City AS Origin, D.City AS Destination, F.EconomySeats, F.BusinessSeats, F.DepartureDate, F.DepartureTime, F.ArrivalTime, F.Status FROM tbl_ClientFlights F INNER JOIN tbl_ClientFlightPrices P ON F.PriceTypeID = P.ID 
                                    INNER JOIN tbl_Airports O ON F.WhereFrom = O.ID
                                    INNER JOIN tbl_Airports D ON F.WhereTo = D.ID WHERE F.DepartureDate >= '"+DateTime.Now.ToString("yyyy/MM/dd")+"' AND F.OfficeID = '" + FrmLogin.m_client.ClientID+"' ORDER BY F.ID";
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    DGClientFlights.Rows.Add(i, dr["FlightID"].ToString(), dr["FlightNo"].ToString(), dr["PriceType"].ToString(), dr["Origin"].ToString(), dr["Destination"].ToString(), dr["EconomySeats"].ToString(), dr["BusinessSeats"].ToString(),Convert.ToDateTime(dr["DepartureDate"]).ToString("dd/MM/yyyy"), dr["DepartureTime"].ToString(), dr["ArrivalTime"].ToString(), dr["Status"].ToString());
                    i++;
                }
                dr.Close();
                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbStop_CheckedChanged(object sender, EventArgs e)
        {
            if(CbStop.Checked)
            {
                CmbStop.Visible = true;
            }
            else
            {
                CmbStop.Visible = false;
            }
        }

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            if(TxtFlightID.Text == string.Empty || TxtFlightNo.Text == string.Empty ||CmbAirplaneModel.SelectedIndex == 0 || CmbPriceType.SelectedIndex == 0 || TxtEconomySeats.Text == string.Empty || TxtBusinessSeats.Text == string.Empty || CmbOrigin.SelectedIndex == 0 || CmbDestination.SelectedIndex == 0 || TxtDepTime.Text == string.Empty || TxtArrTime.Text == string.Empty || CmbStatus.SelectedIndex == 0 || CbStop.Checked && CmbStop.SelectedIndex == 0)
            {
                MessageBox.Show("Your form is incomplete. Please check before trying to save.","incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DatabaseConnection con = new DatabaseConnection();

                    if (BtnAddEdit.Text == "ADD NEW FLIGHT")
                    {
                        if(CmbOrigin.Text == CmbDestination.Text || CmbOrigin.Text == CmbStop.Text || CmbDestination.Text == CmbStop.Text)
                        {
                            MessageBox.Show("Origin and destination can't be the same. Please change one of them.", "same destination detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (CbStop.Checked)
                            {
                                MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_ClientFlights(OfficeID, FlightID, FlightNo, AirplaneID, PriceTypeID, EconomySeats, BusinessSeats, WhereFrom, WhereTo, DepartureDate, DepartureTime, ArrivalTime, Status, Stop) VALUES('" + FrmLogin.m_client.ClientID + "','" + TxtFlightID.Text + "','" + TxtFlightNo.Text + "','" + CmbAirplaneModel.SelectedValue + "','" + CmbPriceType.SelectedValue + "','" + TxtEconomySeats.Text + "','" + TxtBusinessSeats.Text + "','" + CmbOrigin.SelectedValue + "','" + CmbDestination.SelectedValue + "','" + DtDepDate.Value.ToString("yyyy/MM/dd") + "','" + TxtDepTime.Text + "','" + TxtArrTime.Text + "','" + CmbStatus.Text + "','" + CmbStop.SelectedValue + "')", con.ActiveConnection());
                                cmd.ExecuteReader();
                                MessageBox.Show("Congratulation, a new flight has been successfully saved.", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear();
                            }
                            else
                            {
                                MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_ClientFlights(OfficeID, FlightID, FlightNo, AirplaneID, PriceTypeID, EconomySeats, BusinessSeats, WhereFrom, WhereTo, DepartureDate, DepartureTime, ArrivalTime, Status) VALUES('" + FrmLogin.m_client.ClientID + "','" + TxtFlightID.Text + "','" + TxtFlightNo.Text + "','" + CmbAirplaneModel.SelectedValue + "','" + CmbPriceType.SelectedValue + "','" + TxtEconomySeats.Text + "','" + TxtBusinessSeats.Text + "','" + CmbOrigin.SelectedValue + "','" + CmbDestination.SelectedValue + "','" + DtDepDate.Value.ToString("yyyy/MM/dd") + "','" + TxtDepTime.Text + "','" + TxtArrTime.Text + "','" + CmbStatus.Text + "')", con.ActiveConnection());
                                cmd.ExecuteReader();
                                MessageBox.Show("Congratulation, a new flight has been successfully saved.", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear();
                            }
                        }
                    }
                    else
                    {
                        if (CmbOrigin.Text == CmbDestination.Text || CmbOrigin.Text == CmbStop.Text || CmbDestination.Text == CmbStop.Text)
                        {
                            MessageBox.Show("Origin and destination can't be the same. Please change one of them.", "same destination detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (CbStop.Checked)
                            {
                                MySqlCommand cmd;
                                cmd = con.ActiveConnection().CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "UPDATE tbl_ClientFlights SET FlightNo = '" + TxtFlightNo.Text + "', AirplaneID = '" + CmbAirplaneModel.SelectedValue + "', PriceTypeID = '" + CmbPriceType.SelectedValue + "', EconomySeats = '" + TxtEconomySeats.Text + "', BusinessSeats = '" + TxtBusinessSeats.Text + "', WhereFrom = '" + CmbOrigin.SelectedValue + "', WhereTo = '" + CmbDestination.SelectedValue + "', DepartureDate = '" + DtDepDate.Value.ToString("yyyy/MM/dd") + "', DepartureTime = '" + TxtDepTime.Text + "', ArrivalTime = '" + TxtArrTime.Text + "', Status = '" + CmbStatus.Text + "', Stop = '" + CmbStop.SelectedValue + "' WHERE FlightID = '" + TxtFlightID.Text + "' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                                cmd.ExecuteReader();
                                MessageBox.Show($"Congratulation, flight '{TxtFlightID.Text}' has been successfully updated.", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear();
                                con.ActiveConnection().Close();
                                BtnAddEdit.Text = "ADD NEW FLIGHT";
                            }
                            else
                            {
                                MySqlCommand cmd;
                                cmd = con.ActiveConnection().CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "UPDATE tbl_ClientFlights SET FlightNo = '" + TxtFlightNo.Text + "', AirplaneID = '" + CmbAirplaneModel.SelectedValue + "', PriceTypeID = '" + CmbPriceType.SelectedValue + "', EconomySeats = '" + TxtEconomySeats.Text + "', BusinessSeats = '" + TxtBusinessSeats.Text + "', WhereFrom = '" + CmbOrigin.SelectedValue + "', WhereTo = '" + CmbDestination.SelectedValue + "', DepartureDate = '" + DtDepDate.Value.ToString("yyyy/MM/dd") + "', DepartureTime = '" + TxtDepTime.Text + "', ArrivalTime = '" + TxtArrTime.Text + "', Status = '" + CmbStatus.Text + "', Stop = NULL WHERE FlightID = '" + TxtFlightID.Text + "' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                                cmd.ExecuteReader();
                                MessageBox.Show($"Congratulation, flight '{TxtFlightID.Text}' has been successfully updated.", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear();
                                con.ActiveConnection().Close();
                                BtnAddEdit.Text = "ADD NEW FLIGHT";
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

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allowing in the textbox the following signs and numbers according to ASCII
            if (e.KeyChar == 8)
            {

            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                MessageBox.Show("Only numbers are allowed. do not enter any letter or symbols in the field.", "Only numbers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void TxtDepTime_Leave(object sender, EventArgs e)
        {
            try
            {
                if (TxtDepTime.Text != string.Empty)
                {
                    if (int.Parse(TxtDepTime.Text.Substring(0, 1)) > 2 || int.Parse(TxtDepTime.Text.Substring(2, 1)) > 5 || int.Parse(TxtDepTime.Text.Substring(4, 1)) > 5)
                    {
                        MessageBox.Show("Invalid datetime. Please put the time as number without any other letter or symbol.","invalid time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtDepTime.Text = "00:00:00";
                    }
                    else
                    {
                        TxtDepTime.Text = String.Format("{0:00:00:00}", (Int32.Parse(TxtDepTime.Text)));
                    }                   
                }
            }
            catch
            {

            }
        }

        private void TxtArrTime_Leave(object sender, EventArgs e)
        {
            try
            {
                if (TxtArrTime.Text != string.Empty)
                {
                    if (int.Parse(TxtArrTime.Text.Substring(0, 1)) > 2 || int.Parse(TxtArrTime.Text.Substring(2, 1)) > 5 || int.Parse(TxtArrTime.Text.Substring(4, 1)) > 5)
                    {
                        MessageBox.Show("Invalid datetime. Please put the time as number without any other letter or symbol.", "invalid time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtArrTime.Text = "00:00:00";
                    }
                    else
                    {
                        TxtArrTime.Text = String.Format("{0:00:00:00}", (Int32.Parse(TxtArrTime.Text)));
                    }
                }
            }
            catch
            {

            }
        }

        private void DGClientFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cel = DGClientFlights.Columns[e.ColumnIndex].Name;
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                if(cel == "EDIT")
                {
                    MySqlCommand cmd;
                    cmd = con.ActiveConnection().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT F.FlightID, F.FlightNo,A.Model, P.PriceType, O.Airport AS Origin, D.Airport AS Destination, F.EconomySeats, F.BusinessSeats, F.DepartureDate, F.DepartureTime, F.ArrivalTime, F.Status, CASE WHEN F.Stop IS NOT NULL THEN S.Airport ELSE 'Direct' END AS Stops
                                        FROM tbl_ClientFlights F INNER JOIN tbl_ClientFlightPrices P ON F.PriceTypeID = P.ID 
                                        INNER JOIN tbl_Airports O ON F.WhereFrom = O.ID
                                        INNER JOIN tbl_Airports D ON F.WhereTo = D.ID
                                        INNER JOIN tbl_ClientAirplanes A ON F.AirplaneID = A.ID
                                        LEFT JOIN tbl_Airports S ON F.Stop = S.ID
                                        WHERE F.FlightID = '" + DGClientFlights[1, e.RowIndex].Value.ToString()+"' AND F.OfficeID = '"+FrmLogin.m_client.ClientID+"'";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        TxtFlightID.Text = dr["FlightID"].ToString();
                        TxtFlightNo.Text = dr["FlightNo"].ToString();
                        CmbAirplaneModel.Text = dr["Model"].ToString();
                        CmbPriceType.Text = dr["PriceType"].ToString();
                        CmbOrigin.Text = dr["Origin"].ToString();
                        CmbDestination.Text = dr["Destination"].ToString();
                        TxtEconomySeats.Text = dr["EconomySeats"].ToString();
                        TxtBusinessSeats.Text = dr["BusinessSeats"].ToString();
                        DtDepDate.Text = dr["DepartureDate"].ToString();
                        TxtDepTime.Text = dr["DepartureTime"].ToString();
                        TxtArrTime.Text = dr["ArrivalTime"].ToString();
                        CmbStatus.Text = dr["Status"].ToString();

                        if(dr["Stops"].ToString() == "Direct")
                        {
                            CbStop.Checked = false;
                            CmbStop.SelectedIndex = 0;
                        }
                        else
                        {
                            CbStop.Checked = true;
                            CmbStop.Text = dr["Stops"].ToString();
                        }
                        BtnAddEdit.Text = "UPDATE FLIGHT";
                    }
                    dr.Close();
                    con.ActiveConnection().Close();
                }
                else if(cel == "DEL")
                {
                    if(MessageBox.Show($"Do you want to delete this flight '{DGClientFlights[1, e.RowIndex].Value.ToString()}'?","delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand cmd;
                        cmd = con.ActiveConnection().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM tbl_ClientFlights WHERE FlightID = '"+DGClientFlights[1, e.RowIndex].Value.ToString()+"' AND OfficeID = '"+FrmLogin.m_client.ClientID+"'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Congratulation, flight '{DGClientFlights[1, e.RowIndex].Value.ToString()}' has been successfully deleted", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.ActiveConnection().Close();
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(CmbFrom.SelectedIndex == 0 || CmbTo.SelectedIndex == 0)
                {
                    DatabaseConnection con = new DatabaseConnection();
                    DGClientFlights.Rows.Clear();
                    int i = 1;
                    MySqlCommand cmd;
                    cmd = con.ActiveConnection().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT F.FlightID, F.FlightNo, P.PriceType, O.City AS Origin, D.City AS Destination, F.EconomySeats, F.BusinessSeats, F.DepartureDate, F.DepartureTime, F.ArrivalTime, F.Status FROM tbl_ClientFlights F INNER JOIN tbl_ClientFlightPrices P ON F.PriceTypeID = P.ID 
                                    INNER JOIN tbl_Airports O ON F.WhereFrom = O.ID
                                    INNER JOIN tbl_Airports D ON F.WhereTo = D.ID WHERE F.DepartureDate BETWEEN '" + DtFrom.Value.ToString("yyyy/MM/dd") + "'AND '" + DtTo.Value.ToString("yyyy/MM/dd") + "' AND F.OfficeID = '" + FrmLogin.m_client.ClientID + "' ORDER BY F.ID";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DGClientFlights.Rows.Add(i, dr["FlightID"].ToString(), dr["FlightNo"].ToString(), dr["PriceType"].ToString(), dr["Origin"].ToString(), dr["Destination"].ToString(), dr["EconomySeats"].ToString(), dr["BusinessSeats"].ToString(), Convert.ToDateTime(dr["DepartureDate"]).ToString("dd/MM/yyyy"), dr["DepartureTime"].ToString(), dr["ArrivalTime"].ToString(), dr["Status"].ToString());
                        i++;
                    }
                    dr.Close();
                    con.ActiveConnection().Close();
                }
                else
                {
                    DatabaseConnection con = new DatabaseConnection();
                    DGClientFlights.Rows.Clear();
                    int i = 1;
                    MySqlCommand cmd;
                    cmd = con.ActiveConnection().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT F.FlightID, F.FlightNo, P.PriceType, O.City AS Origin, D.City AS Destination, F.EconomySeats, F.BusinessSeats, F.DepartureDate, F.DepartureTime, F.ArrivalTime, F.Status FROM tbl_ClientFlights F INNER JOIN tbl_ClientFlightPrices P ON F.PriceTypeID = P.ID 
                                    INNER JOIN tbl_Airports O ON F.WhereFrom = O.ID
                                    INNER JOIN tbl_Airports D ON F.WhereTo = D.ID WHERE O.City = '" + CmbFrom.Text + "' AND D.City = '" + CmbTo.Text + "' AND F.DepartureDate BETWEEN '" + DtFrom.Value.ToString("yyyy/MM/dd") + "'AND '" + DtTo.Value.ToString("yyyy/MM/dd") + "' AND F.OfficeID = '" + FrmLogin.m_client.ClientID + "' ORDER BY F.ID";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DGClientFlights.Rows.Add(i, dr["FlightID"].ToString(), dr["FlightNo"].ToString(), dr["PriceType"].ToString(), dr["Origin"].ToString(), dr["Destination"].ToString(), dr["EconomySeats"].ToString(), dr["BusinessSeats"].ToString(), Convert.ToDateTime(dr["DepartureDate"]).ToString("dd/MM/yyyy"), dr["DepartureTime"].ToString(), dr["ArrivalTime"].ToString(), dr["Status"].ToString());
                        i++;
                    }
                    dr.Close();
                    con.ActiveConnection().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
