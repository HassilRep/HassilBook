using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HassilBook
{
    public partial class FrmAgencySearchEngine : Form
    {
        DatabaseConnection con = new DatabaseConnection();
        public FrmAgencySearchEngine()
        {
            InitializeComponent();
            CheckRadionButton();

            DtFrom.Text = DateTime.Now.ToString();
            DtTo.Text = DateTime.Now.ToString();
        }

        private void RbtnOneway_CheckedChanged(object sender, EventArgs e)
        {
            CheckRadionButton();
        }

        /// <summary>
        /// Checks which setting is currently active oneway or return
        /// </summary>
        private void CheckRadionButton()
        {
            if (RbtnOneway.Checked == true)
            {
                CmbClass.Location = new Point(CmbClass.Location.X, CmbClass.Location.Y - 37);
                CmbAdult.Location = new Point(CmbAdult.Location.X, CmbAdult.Location.Y - 37);
                CmbChild.Location = new Point(CmbChild.Location.X, CmbChild.Location.Y - 37);
                CmbInfant.Location = new Point(CmbInfant.Location.X, CmbInfant.Location.Y - 37);
                BtnSearchFlight.Location = new Point(BtnSearchFlight.Location.X, BtnSearchFlight.Location.Y - 37);
            }
            else
            {
                CmbClass.Location = new Point(CmbClass.Location.X, CmbClass.Location.Y + 37);
                CmbAdult.Location = new Point(CmbAdult.Location.X, CmbAdult.Location.Y + 37);
                CmbChild.Location = new Point(CmbChild.Location.X, CmbChild.Location.Y + 37);
                CmbInfant.Location = new Point(CmbInfant.Location.X, CmbInfant.Location.Y + 37);
                BtnSearchFlight.Location = new Point(BtnSearchFlight.Location.X, BtnSearchFlight.Location.Y + 37);
                DtTo.Visible = true;
            }
        }

        #region search fields
        private void TxtFrom_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                try
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM tbl_Airports WHERE Airport like('%" + TxtFrom.Text + "%')", con.ActiveConnection()))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            lstDropDownFrom.Visible = true;
                            lstDropDownFrom.Items.Clear();
                            foreach (DataRow dr in dt.Rows)
                            {
                                lstDropDownFrom.Items.Add(dr["Airport"].ToString());
                            }
                        }
                        else
                        {
                            lstDropDownFrom.Visible = false;
                        }
                        dt.Clear();
                        con.ActiveConnection().Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (TxtFrom.Text != string.Empty)
                {
                    lstDropDownFrom.Focus();
                    lstDropDownFrom.SelectedIndex = 0;
                }
            }
        }

        private void lstDropDownFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstDropDownFrom.SelectedItem != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TxtFrom.Text = lstDropDownFrom.SelectedItem.ToString();
                    lstDropDownFrom.Visible = false;
                }
            }
        }

        private void lstDropDownFrom_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstDropDownFrom.SelectedItem != null)
            {
                TxtFrom.Text = lstDropDownFrom.SelectedItem.ToString();
                lstDropDownFrom.Visible = false;
            }
        }

        private void TxtTo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                try
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM tbl_Airports WHERE Airport like('%" + TxtTo.Text + "%')", con.ActiveConnection()))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            lstDropDownTo.Visible = true;
                            lstDropDownTo.Items.Clear();
                            foreach (DataRow dr in dt.Rows)
                            {
                                lstDropDownTo.Items.Add(dr["Airport"].ToString());
                            }
                        }
                        else
                        {
                            lstDropDownTo.Visible = false;
                        }
                        dt.Clear();
                        con.ActiveConnection().Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (TxtTo.Text != string.Empty)
                {
                    lstDropDownTo.Focus();
                    lstDropDownTo.SelectedIndex = 0;
                }
            }
        }

        private void lstDropDownTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstDropDownTo.SelectedItem != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TxtTo.Text = lstDropDownTo.SelectedItem.ToString();
                    lstDropDownTo.Visible = false;
                }
            }
        }

        private void lstDropDownTo_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstDropDownTo.SelectedItem != null)
            {
                TxtTo.Text = lstDropDownTo.SelectedItem.ToString();
                lstDropDownTo.Visible = false;
            }
        }
        #endregion

        private void BtnSearchFlight_Click(object sender, EventArgs e)
        {
            if (TxtFrom.Text == string.Empty || TxtTo.Text == string.Empty)
            {
                MessageBox.Show("Select the route you want to search please.", "route", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CmbClass.SelectedIndex == 0 || CmbClass.SelectedIndex == 1)
                {
                    // ONEWAY ECONOMY
                    if(RbtnOneway.Checked)
                    {
                        Flight search = new Flight();
                        var flights = search.SearchEconomyFromSingleAirline(TxtFrom.Text, TxtTo.Text, DtFrom.Value.ToString("yyyy/MM/dd"));
                        
                        FlpFlightSearchResults.Controls.Clear();
                        if (flights.Count > 0)
                        {
                            UcOnewayDirectFlights[] ucDirect = new UcOnewayDirectFlights[flights.Count];
                            UcOnewayStopFlights[] ucStop = new UcOnewayStopFlights[flights.Count];

                            for (int i = 0; i < flights.Count; i++)
                            {
                                // DIRECT FLIGHTS
                                if (flights[i].Stops == "Direct")
                                {
                                    // TOP PART
                                    ucDirect[i] = new UcOnewayDirectFlights();
                                    ucDirect[i].LblDepartureTime.Text = flights[i].DepartureTime.ToString().Substring(0, 5);
                                    ucDirect[i].LblArrivalTime.Text = flights[i].ArrivalTime.ToString().Substring(0, 5);
                                    ucDirect[i].LblFromAndDepDate.Text = $"{flights[i].From.ToString().Substring(0, 3)} - {flights[i].DepartureDate.ToString("dd MMM")}";
                                    ucDirect[i].LblToAndArrDate.Text = $"{flights[i].To.ToString().Substring(0, 3)} - {flights[i].DepartureDate.ToString("dd MMM")}";
                                    ucDirect[i].LblFrom.Text = flights[i].CityFrom.ToUpper();
                                    ucDirect[i].LblTo.Text = flights[i].CityTo.ToUpper();
                                    ucDirect[i].LblStops.Text = flights[i].Stops.ToUpper();
                                    ucDirect[i].LblClass.Text = "ECONOMY";
                                    if (flights[i].Logo != null)
                                    {
                                        MemoryStream ms = new MemoryStream(flights[i].Logo);
                                        ucDirect[i].PbLogo1.Image = Image.FromStream(ms);
                                        ucDirect[i].PbLogo2.Image = Image.FromStream(ms);
                                        ucDirect[i].PbLogo3.Image = Image.FromStream(ms);
                                    }

                                    // Flight duration and intervals will be calculated here.
                                    var interval = flights[i].ArrivalTime - flights[i].DepartureTime;
                                    ucDirect[i].LblDuration.Text = $"{interval.Hours.ToString()}h {interval.Minutes.ToString()}m";

                                    // Price of the travelling people will be calculated here.
                                    decimal total = 0;
                                    decimal adultsTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * flights[i].AdultEconomyPrice;
                                    decimal childTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * flights[i].ChildEconomyPrice;
                                    decimal infantTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * flights[i].InfantEconomyPrice;
                                    total = adultsTotal + childTotal + infantTotal;
                                    ucDirect[i].LblPrice.Text = $"USD {total.ToString()}";

                                    int noADL = (CmbAdult.SelectedIndex == 0 ? 0 : int.Parse(CmbAdult.Text));
                                    int noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                                    int noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));

                                    // DETAILS
                                    ucDirect[i].LblDayDate.Text = flights[i].DepartureDate.ToString("ddd, dd MMM");
                                    ucDirect[i].LblAirlines.Text = $"{flights[i].FlightNo}-{flights[i].Airlines.ToString()}";
                                    ucDirect[i].LblAirType.Text = flights[i].Model.ToString();
                                    ucDirect[i].LblOriginAirport.Text = $"{flights[i].DepartureTime.ToString().Substring(0, 5)} - {flights[i].From.Substring(6)}";
                                    ucDirect[i].LblDestinationAirport.Text = $"{flights[i].ArrivalTime.ToString().Substring(0, 5)} - {flights[i].To.Substring(6)}";
                                    ucDirect[i].LblSeatsAvailable.Text = $"{flights[i].EconomySeats} Seats available";

                                    // Price break down

                                    ucDirect[i].LblAdultPrice.Text = $"ADULT     x  {noADL}   {adultsTotal} USD";
                                    ucDirect[i].LblChildPrice.Text = $"CHILD     x  {noCHD}   {childTotal} USD";
                                    ucDirect[i].LblInfantPrice.Text = $"INFANT   x  {noINF}   {infantTotal} USD";
                                    ucDirect[i].LblTotalPrice.Text = $"TOTAL: {total}";


                                    ucDirect[i].LblPrice.Text = $"USD {total.ToString()}";

                                    FlpFlightSearchResults.Controls.Add(ucDirect[i]);

                                }
                                  // STOP FLIGHTS
                                else
                                {
                                    // TOP PART
                                    ucStop[i] = new UcOnewayStopFlights();
                                    ucStop[i].LblDepartureTime.Text = flights[i].DepartureTime.ToString().Substring(0, 5);
                                    ucStop[i].LblArrivalTime.Text = flights[i].ArrivalTime.ToString().Substring(0, 5);
                                    ucStop[i].LblFromAndDepDate.Text = $"{flights[i].From.ToString().Substring(0, 3)} - {flights[i].DepartureDate.ToString("dd MMM")}";
                                    ucStop[i].LblToAndArrDate.Text = $"{flights[i].To.ToString().Substring(0, 3)} - {flights[i].DepartureDate.ToString("dd MMM")}";
                                    ucStop[i].LblFrom.Text = flights[i].CityFrom.ToUpper();
                                    ucStop[i].LblTo.Text = flights[i].CityTo.ToUpper();
                                    ucStop[i].LblClass.Text = "ECONOMY";
                                    if (flights[i].Logo != null)
                                    {
                                        MemoryStream ms = new MemoryStream(flights[i].Logo);
                                        ucStop[i].PbLogo1.Image = Image.FromStream(ms);
                                        ucStop[i].PbLogo2.Image = Image.FromStream(ms);
                                        ucStop[i].PbLogo3.Image = Image.FromStream(ms);
                                    }

                                    ucStop[i].LblStops.Text = flights[i].Stops.ToString().Substring(0, 3);
                                    ucStop[i].LblNumberOfStops.Text = "1 Stop";

                                    // Flight duration and intervals will be calculated here.
                                    var interval = flights[i].ArrivalTime - flights[i].DepartureTime;
                                    ucStop[i].LblDuration.Text = $"{interval.Hours.ToString()}h {interval.Minutes.ToString()}m";

                                    // Price of the travelling people will be calculated here.
                                    decimal total = 0;
                                    decimal adultsTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * flights[i].AdultEconomyPrice;
                                    decimal childTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * flights[i].ChildEconomyPrice;
                                    decimal infantTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * flights[i].InfantEconomyPrice;
                                    total = adultsTotal + childTotal + infantTotal;
                                    ucStop[i].LblPrice.Text = $"USD {total.ToString()}";

                                    int noADL = (CmbAdult.SelectedIndex == 0 ? 0 : int.Parse(CmbAdult.Text));
                                    int noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                                    int noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));

                                    // DETAILS
                                    ucStop[i].LblDayDate.Text = flights[i].DepartureDate.ToString("ddd, dd MMM");
                                    ucStop[i].LblAirlines.Text = $"{flights[i].FlightNo}-{flights[i].Airlines.ToString()}";
                                    ucStop[i].LblAirType.Text = flights[i].Model.ToString(); 
                                    ucStop[i].LblOriginAirport.Text = $"{flights[i].DepartureTime.ToString().Substring(0, 5)} - {flights[i].From.Substring(6)}";
                                    ucStop[i].LblStopAirport.Text = $"Connection - {flights[i].Stops.Substring(6)}";
                                    ucStop[i].LblDestinationAirport.Text = $"{flights[i].ArrivalTime.ToString().Substring(0,5)} - {flights[i].To.Substring(6)}";
                                    ucStop[i].LblSeatsAvailable.Text = $"{flights[i].EconomySeats} Seats available";

                                    // Price break down

                                    ucStop[i].LblAdultPrice.Text = $"ADULT     x  {noADL}   {adultsTotal} USD";
                                    ucStop[i].LblChildPrice.Text = $"CHILD     x  {noCHD}   {childTotal} USD";
                                    ucStop[i].LblInfantPrice.Text = $"INFANT   x  {noINF}   {infantTotal} USD";
                                    ucStop[i].LblTotalPrice.Text = $"TOTAL: {total}";


                                    ucStop[i].LblPrice.Text = $"USD {total.ToString()}";

                                    FlpFlightSearchResults.Controls.Add(ucStop[i]);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No flights are available from the airlines we searched.","no flight", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    // ROUNDTRIP ECONOMY
                    else
                    {

                    }
                }
                else
                {

                }
            }
        }
    }
}
