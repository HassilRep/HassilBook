using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HassilBook
{
    public partial class FrmAgencySearchEngine : Form
    {
        private int m_noADL = 0;
        private int m_noCHD = 0;
        private int m_noINF = 0;
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
                    if (RbtnOneway.Checked)
                    {
                        if (DtFrom.Value.Date < DateTime.Now.Date)
                        {
                            MessageBox.Show("Invalid departure date, please check.", "date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Flight search = new Flight();
                            var flights = search.SearchEconomyFromSingleAirline(TxtFrom.Text, TxtTo.Text, DtFrom.Value.ToString("yyyy/MM/dd"));

                            FlpFlightSearchResults.Controls.Clear();
                            if (flights.Count > 0)
                            {
                                UcOnewayDirectFlights[] ucDirect = new UcOnewayDirectFlights[flights.Count];
                                UcOnewayStopFlights[] ucStop = new UcOnewayStopFlights[flights.Count];

                                // FLIGHT LIST AND IT'S INDEX TO SELECT FROM THE USER
                                List<Tuple<FlightModel, int>> directFlightList = new List<Tuple<FlightModel, int>>();
                                List<Tuple<FlightModel, int>> StopFlightList = new List<Tuple<FlightModel, int>>();
                                UcOnewayDirectFlights direct = new UcOnewayDirectFlights();

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

                                        m_noADL = (CmbAdult.SelectedIndex == 0 ? 0 : int.Parse(CmbAdult.Text));
                                        m_noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                                        m_noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));

                                        // DETAILS
                                        ucDirect[i].LblDayDate.Text = flights[i].DepartureDate.ToString("ddd, dd MMM");
                                        ucDirect[i].LblAirlines.Text = $"{flights[i].FlightNo}-{flights[i].Airlines.ToString()}";
                                        ucDirect[i].LblAirType.Text = flights[i].Model.ToString();
                                        ucDirect[i].LblOriginAirport.Text = $"{flights[i].DepartureTime.ToString().Substring(0, 5)} - {flights[i].From.Substring(6)}";
                                        ucDirect[i].LblDestinationAirport.Text = $"{flights[i].ArrivalTime.ToString().Substring(0, 5)} - {flights[i].To.Substring(6)}";
                                        ucDirect[i].LblSeatsAvailable.Text = $"{flights[i].EconomySeats} Seats available";

                                        // Price break down
                                        ucDirect[i].LblAdultPrice.Text = $"ADULT     x  {m_noADL}   {adultsTotal} USD";
                                        ucDirect[i].LblChildPrice.Text = $"CHILD     x  {m_noCHD}   {childTotal} USD";
                                        ucDirect[i].LblInfantPrice.Text = $"INFANT   x  {m_noINF}   {infantTotal} USD";
                                        ucDirect[i].LblTotalPrice.Text = $"TOTAL: {total}";


                                        ucDirect[i].LblPrice.Text = $"USD {total.ToString()}";

                                        // ADD FLIGHTS TO DIRECT LIST
                                        directFlightList.Add(new Tuple<FlightModel, int>(flights[i], i));
                                        ucDirect[i].Tag = i;
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

                                        m_noADL = (CmbAdult.SelectedIndex == 0 ? 0 : int.Parse(CmbAdult.Text));
                                        m_noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                                        m_noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));

                                        // DETAILS
                                        ucStop[i].LblDayDate.Text = flights[i].DepartureDate.ToString("ddd, dd MMM");
                                        ucStop[i].LblAirlines.Text = $"{flights[i].FlightNo}-{flights[i].Airlines.ToString()}";
                                        ucStop[i].LblAirType.Text = flights[i].Model.ToString();
                                        ucStop[i].LblOriginAirport.Text = $"{flights[i].DepartureTime.ToString().Substring(0, 5)} - {flights[i].From.Substring(6)}";
                                        ucStop[i].LblStopAirport.Text = $"Connection - {flights[i].Stops.Substring(6)}";
                                        ucStop[i].LblDestinationAirport.Text = $"{flights[i].ArrivalTime.ToString().Substring(0, 5)} - {flights[i].To.Substring(6)}";
                                        ucStop[i].LblSeatsAvailable.Text = $"{flights[i].EconomySeats} Seats available";

                                        // Price break down

                                        ucStop[i].LblAdultPrice.Text = $"ADULT     x  {m_noADL}   {adultsTotal} USD";
                                        ucStop[i].LblChildPrice.Text = $"CHILD     x  {m_noCHD}   {childTotal} USD";
                                        ucStop[i].LblInfantPrice.Text = $"INFANT   x  {m_noINF}   {infantTotal} USD";
                                        ucStop[i].LblTotalPrice.Text = $"TOTAL: {total}";


                                        ucStop[i].LblPrice.Text = $"USD {total.ToString()}";

                                        FlpFlightSearchResults.Controls.Add(ucStop[i]);
                                    }
                                }
                                direct.Book(directFlightList, "ECONOMY", m_noADL, m_noCHD, m_noINF);
                            }
                            else
                            {
                                MessageBox.Show("No flights are available from the airlines we searched.", "no flight", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    // ROUNDTRIP ECONOMY
                    else
                    {
                        if (DtFrom.Value.Date < DateTime.Now.Date || DtTo.Value.Date < DateTime.Now.Date)
                        {
                            MessageBox.Show("Invalid departure or return date, please check.", "date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Flight search = new Flight();
                            var Goflights = search.SearchEconomyFromSingleAirline(TxtFrom.Text, TxtTo.Text, DtFrom.Value.ToString("yyyy/MM/dd"));
                            var Returnflights = search.SearchEconomyFromSingleAirline(TxtTo.Text, TxtFrom.Text, DtTo.Value.ToString("yyyy/MM/dd"));

                            FlpFlightSearchResults.Controls.Clear();
                            if (Goflights.Count > 0)
                            {
                                if(Returnflights.Count > 0)
                                {
                                    UcReturnDirectFlights[] ucDirect = new UcReturnDirectFlights[10];
                                    UcReturnGoStopFlights[] ucGoStop = new UcReturnGoStopFlights[10];
                                    UcReturnBackStopFlights[] ucBackStop = new UcReturnBackStopFlights[10];
                                    UcReturnStopFlights[] ucStop = new UcReturnStopFlights[10];

                                    for (int i = 0; i < Goflights.Count; i++)
                                    {
                                        for (int j = 0; j < Returnflights.Count; j++)
                                        {
                                            // BOTH FLIGHT ARE DIRECT
                                            if (Goflights[i].Stops == "Direct" && Returnflights[j].Stops == "Direct")
                                            {
                                                // <--------- GO ------------>
                                                // TOP PART
                                                ucDirect[j] = new UcReturnDirectFlights();
                                                ucDirect[j].LblDepartureTime.Text = Goflights[i].DepartureTime.ToString().Substring(0, 5);
                                                ucDirect[j].LblArrivalTime.Text = Goflights[i].ArrivalTime.ToString().Substring(0, 5);
                                                ucDirect[j].LblFromAndDepDate.Text = $"{Goflights[i].From.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucDirect[j].LblToAndArrDate.Text = $"{Goflights[i].To.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucDirect[j].LblFrom.Text = Goflights[i].CityFrom.ToUpper();
                                                ucDirect[j].LblTo.Text = Goflights[i].CityTo.ToUpper();
                                                ucDirect[j].LblStops.Text = Goflights[i].Stops.ToUpper();
                                                ucDirect[j].LblClass.Text = "ECONOMY";
                                                if (Goflights[i].Logo != null)
                                                {
                                                    MemoryStream ms = new MemoryStream(Goflights[i].Logo);
                                                    ucDirect[j].PbLogo1.Image = Image.FromStream(ms);
                                                    ucDirect[j].PbLogo2.Image = Image.FromStream(ms);
                                                    ucDirect[j].PbLogo3.Image = Image.FromStream(ms);
                                                    ucDirect[j].PbLogo4.Image = Image.FromStream(ms);
                                                }

                                                // Flight duration and intervals will be calculated here.
                                                var interval = Goflights[i].ArrivalTime - Goflights[i].DepartureTime;
                                                ucDirect[j].LblDuration.Text = $"{interval.Hours.ToString()}h {interval.Minutes.ToString()}m";


                                                // DETAILS
                                                ucDirect[j].LblDayDate.Text = Goflights[i].DepartureDate.ToString("ddd, dd MMM");
                                                ucDirect[j].LblAirlines.Text = $"{Goflights[i].FlightNo}-{Goflights[i].Airlines.ToString()}";
                                                ucDirect[j].LblAirType.Text = Goflights[i].Model.ToString();
                                                ucDirect[j].LblOriginAirport.Text = $"{Goflights[i].DepartureTime.ToString().Substring(0, 5)} - {Goflights[i].From.Substring(6)}";
                                                ucDirect[j].LblDestinationAirport.Text = $"{Goflights[i].ArrivalTime.ToString().Substring(0, 5)} - {Goflights[i].To.Substring(6)}";
                                                ucDirect[j].LblSeatsAvailable.Text = $"{Goflights[i].EconomySeats} Seats available";

                                                // <---------- RETURN -------------->

                                                ucDirect[j].LblDayDateR.Text = Returnflights[j].DepartureDate.ToString("ddd, dd MMM");
                                                ucDirect[j].LblAirlinesR.Text = $"{Returnflights[j].FlightNo}-{Returnflights[j].Airlines.ToString()}";
                                                ucDirect[j].LblAirTypeR.Text = Returnflights[j].Model.ToString();
                                                ucDirect[j].LblOriginAirportR.Text = $"{Returnflights[j].DepartureTime.ToString().Substring(0, 5)} - {Returnflights[j].From.Substring(6)}";
                                                ucDirect[j].LblDestinationAirportR.Text = $"{Returnflights[j].ArrivalTime.ToString().Substring(0, 5)} - {Returnflights[j].To.Substring(6)}";
                                                ucDirect[j].LblSeatsAvailableR.Text = $"{Returnflights[j].EconomySeats} Seats available";

                                                // Price of the travelling people will be calculated here.
                                                decimal Gototal = 0;
                                                decimal Backtotal = 0;
                                                decimal GrandTotal = 0;

                                                decimal adultsTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Goflights[i].AdultEconomyPrice;
                                                decimal childTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Goflights[i].ChildEconomyPrice;
                                                decimal infantTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Goflights[i].InfantEconomyPrice;
                                                Gototal = adultsTotal + childTotal + infantTotal;

                                                decimal adultsBackTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Returnflights[j].AdultEconomyPrice;
                                                decimal childBackTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Returnflights[j].ChildEconomyPrice;
                                                decimal infantBackTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Returnflights[j].InfantEconomyPrice;
                                                Backtotal = adultsBackTotal + childBackTotal + infantBackTotal;
                                                GrandTotal = Gototal + Backtotal;


                                                m_noADL = (CmbAdult.SelectedIndex == 0 ? 0 : int.Parse(CmbAdult.Text));
                                                m_noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                                                m_noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));

                                                // Price break down
                                                ucDirect[j].LblAdultPrice.Text = $"ADULT     x  {m_noADL}   {adultsTotal + adultsBackTotal} USD";
                                                ucDirect[j].LblChildPrice.Text = $"CHILD     x  {m_noCHD}   {childTotal + childBackTotal} USD";
                                                ucDirect[j].LblInfantPrice.Text = $"INFANT   x  {m_noINF}   {infantTotal + infantBackTotal} USD";
                                                ucDirect[j].LblTotalPrice.Text = $"TOTAL: {GrandTotal}";


                                                ucDirect[j].LblPrice.Text = $"USD {GrandTotal.ToString()}";

                                                FlpFlightSearchResults.Controls.Add(ucDirect[j]);
                                            }
                                            // DEPARTURE HAS STOP AND RETURN IS DIRECT
                                            else if (Goflights[i].Stops != "Direct" && Returnflights[j].Stops == "Direct")
                                            {
                                                // <--------- GO ------------>
                                                // TOP PART
                                                ucGoStop[j] = new UcReturnGoStopFlights();
                                                ucGoStop[j].LblDepartureTime.Text = Goflights[i].DepartureTime.ToString().Substring(0, 5);
                                                ucGoStop[j].LblArrivalTime.Text = Goflights[i].ArrivalTime.ToString().Substring(0, 5);
                                                ucGoStop[j].LblFromAndDepDate.Text = $"{Goflights[i].From.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucGoStop[j].LblToAndArrDate.Text = $"{Goflights[i].To.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucGoStop[j].LblFrom.Text = Goflights[i].CityFrom.ToUpper();
                                                ucGoStop[j].LblTo.Text = Goflights[i].CityTo.ToUpper();
                                                ucGoStop[j].LblStops.Text = Goflights[i].Stops.ToUpper();
                                                ucGoStop[j].LblClass.Text = "ECONOMY";
                                                if (Goflights[i].Logo != null)
                                                {
                                                    MemoryStream ms = new MemoryStream(Goflights[i].Logo);
                                                    ucGoStop[j].PbLogo1.Image = Image.FromStream(ms);
                                                    ucGoStop[j].PbLogo2.Image = Image.FromStream(ms);
                                                    ucGoStop[j].PbLogo3.Image = Image.FromStream(ms);
                                                    ucGoStop[j].PbLogo4.Image = Image.FromStream(ms);
                                                }

                                                ucGoStop[j].LblStops.Text = Goflights[i].Stops.ToString().Substring(0, 3);
                                                ucGoStop[j].LblNumberOfStops.Text = "1 Stop";

                                                // Flight duration and intervals will be calculated here.
                                                var interval = Goflights[i].ArrivalTime - Goflights[i].DepartureTime;
                                                ucGoStop[j].LblDuration.Text = $"{interval.Hours.ToString()}h {interval.Minutes.ToString()}m";


                                                // DETAILS
                                                ucGoStop[j].LblDayDate.Text = Goflights[i].DepartureDate.ToString("ddd, dd MMM");
                                                ucGoStop[j].LblAirlines.Text = $"{Goflights[i].FlightNo}-{Returnflights[j].Airlines.ToString()}";
                                                ucGoStop[j].LblAirType.Text = Goflights[i].Model.ToString();
                                                ucGoStop[j].LblOriginAirport.Text = $"{Goflights[i].DepartureTime.ToString().Substring(0, 5)} - {Goflights[i].From.Substring(6)}";
                                                ucGoStop[j].LblConnectionAirport.Text = $"Connection - {Goflights[i].Stops.Substring(6)}";
                                                ucGoStop[j].LblDestinationAirport.Text = $"{Goflights[i].ArrivalTime.ToString().Substring(0, 5)} - {Goflights[i].To.Substring(6)}";
                                                ucGoStop[j].LblSeatsAvailable.Text = $"{Goflights[i].EconomySeats} Seats available";

                                                // <---------- RETURN -------------->

                                                ucGoStop[j].LblDayDateR.Text = Returnflights[j].DepartureDate.ToString("ddd, dd MMM");
                                                ucGoStop[j].LblAirlinesR.Text = $"{Returnflights[j].FlightNo}-{Returnflights[j].Airlines.ToString()}";
                                                ucGoStop[j].LblAirTypeR.Text = Returnflights[j].Model.ToString();
                                                ucGoStop[j].LblOriginAirportR.Text = $"{Returnflights[j].DepartureTime.ToString().Substring(0, 5)} - {Returnflights[j].From.Substring(6)}";
                                                ucGoStop[j].LblDestinationAirportR.Text = $"{Returnflights[j].ArrivalTime.ToString().Substring(0, 5)} - {Returnflights[j].To.Substring(6)}";
                                                ucGoStop[j].LblSeatsAvailableR.Text = $"{Returnflights[j].EconomySeats} Seats available";



                                                // Price of the travelling people will be calculated here.
                                                decimal Gototal = 0;
                                                decimal Backtotal = 0;
                                                decimal GrandTotal = 0;

                                                decimal adultsTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Goflights[i].AdultEconomyPrice;
                                                decimal childTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Goflights[i].ChildEconomyPrice;
                                                decimal infantTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Goflights[i].InfantEconomyPrice;
                                                Gototal = adultsTotal + childTotal + infantTotal;

                                                decimal adultsBackTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Returnflights[j].AdultEconomyPrice;
                                                decimal childBackTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Returnflights[j].ChildEconomyPrice;
                                                decimal infantBackTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Returnflights[j].InfantEconomyPrice;
                                                Backtotal = adultsBackTotal + childBackTotal + infantBackTotal;
                                                GrandTotal = Gototal + Backtotal;


                                                m_noADL = (CmbAdult.SelectedIndex == 0 ? 0 : int.Parse(CmbAdult.Text));
                                                m_noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                                                m_noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));

                                                // Price break down
                                                ucGoStop[j].LblAdultPrice.Text = $"ADULT     x  {m_noADL}   {adultsTotal + adultsBackTotal} USD";
                                                ucGoStop[j].LblChildPrice.Text = $"CHILD     x  {m_noCHD}   {childTotal + childBackTotal} USD";
                                                ucGoStop[j].LblInfantPrice.Text = $"INFANT   x  {m_noINF}   {infantTotal + infantBackTotal} USD";
                                                ucGoStop[j].LblTotalPrice.Text = $"TOTAL: {GrandTotal}";


                                                ucGoStop[j].LblPrice.Text = $"USD {GrandTotal.ToString()}";

                                                FlpFlightSearchResults.Controls.Add(ucGoStop[j]);
                                            }
                                            // DEPARTURE IS DIRECT AND RETURN HAS STOP
                                            else if (Goflights[i].Stops == "Direct" && Returnflights[j].Stops != "Direct")
                                            {
                                                // <--------- GO ------------>
                                                // TOP PART
                                                ucBackStop[j] = new UcReturnBackStopFlights();
                                                ucBackStop[j].LblDepartureTime.Text = Goflights[i].DepartureTime.ToString().Substring(0, 5);
                                                ucBackStop[j].LblArrivalTime.Text = Goflights[i].ArrivalTime.ToString().Substring(0, 5);
                                                ucBackStop[j].LblFromAndDepDate.Text = $"{Goflights[i].From.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucBackStop[j].LblToAndArrDate.Text = $"{Goflights[i].To.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucBackStop[j].LblFrom.Text = Goflights[i].CityFrom.ToUpper();
                                                ucBackStop[j].LblTo.Text = Goflights[i].CityTo.ToUpper();
                                                ucBackStop[j].LblStops.Text = Goflights[i].Stops.ToUpper();
                                                ucBackStop[j].LblClass.Text = "ECONOMY";
                                                if (Goflights[i].Logo != null)
                                                {
                                                    MemoryStream ms = new MemoryStream(Goflights[i].Logo);
                                                    ucBackStop[j].PbLogo1.Image = Image.FromStream(ms);
                                                    ucBackStop[j].PbLogo2.Image = Image.FromStream(ms);
                                                    ucBackStop[j].PbLogo3.Image = Image.FromStream(ms);
                                                    ucBackStop[j].PbLogo4.Image = Image.FromStream(ms);
                                                }

                                                // Flight duration and intervals will be calculated here.
                                                var interval = Goflights[i].ArrivalTime - Goflights[i].DepartureTime;
                                                ucBackStop[j].LblDuration.Text = $"{interval.Hours.ToString()}h {interval.Minutes.ToString()}m";


                                                // DETAILS
                                                ucBackStop[j].LblDayDate.Text = Goflights[i].DepartureDate.ToString("ddd, dd MMM");
                                                ucBackStop[j].LblAirlines.Text = $"{Goflights[i].FlightNo}-{Goflights[i].Airlines.ToString()}";
                                                ucBackStop[j].LblAirType.Text = Goflights[i].Model.ToString();
                                                ucBackStop[j].LblOriginAirport.Text = $"{Goflights[i].DepartureTime.ToString().Substring(0, 5)} - {Goflights[i].From.Substring(6)}";
                                                ucBackStop[j].LblDestinationAirport.Text = $"{Goflights[i].ArrivalTime.ToString().Substring(0, 5)} - {Goflights[i].To.Substring(6)}";
                                                ucBackStop[j].LblSeatsAvailable.Text = $"{Goflights[i].EconomySeats} Seats available";

                                                // <---------- RETURN -------------->

                                                ucBackStop[j].LblDayDateR.Text = Returnflights[j].DepartureDate.ToString("ddd, dd MMM");
                                                ucBackStop[j].LblAirlinesR.Text = $"{Returnflights[j].FlightNo}-{Returnflights[j].Airlines.ToString()}";
                                                ucBackStop[j].LblAirTypeR.Text = Returnflights[j].Model.ToString();
                                                ucBackStop[j].LblOriginAirportR.Text = $"{Returnflights[j].DepartureTime.ToString().Substring(0, 5)} - {Returnflights[j].From.Substring(6)}";
                                                ucBackStop[j].LblConnectionAirport.Text = $"Connection - {Returnflights[j].Stops.Substring(6)}";
                                                ucBackStop[j].LblDestinationAirportR.Text = $"{Returnflights[j].ArrivalTime.ToString().Substring(0, 5)} - {Returnflights[j].To.Substring(6)}";
                                                ucBackStop[j].LblSeatsAvailableR.Text = $"{Returnflights[j].EconomySeats} Seats available";

                                                // Price of the travelling people will be calculated here.
                                                decimal Gototal = 0;
                                                decimal Backtotal = 0;
                                                decimal GrandTotal = 0;

                                                decimal adultsTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Goflights[i].AdultEconomyPrice;
                                                decimal childTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Goflights[i].ChildEconomyPrice;
                                                decimal infantTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Goflights[i].InfantEconomyPrice;
                                                Gototal = adultsTotal + childTotal + infantTotal;

                                                decimal adultsBackTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Returnflights[j].AdultEconomyPrice;
                                                decimal childBackTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Returnflights[j].ChildEconomyPrice;
                                                decimal infantBackTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Returnflights[j].InfantEconomyPrice;
                                                Backtotal = adultsBackTotal + childBackTotal + infantBackTotal;
                                                GrandTotal = Gototal + Backtotal;


                                                m_noADL = (CmbAdult.SelectedIndex == 0 ? 0 : int.Parse(CmbAdult.Text));
                                                m_noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                                                m_noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));

                                                // Price break down
                                                ucBackStop[j].LblAdultPrice.Text = $"ADULT     x  {m_noADL}   {adultsTotal + adultsBackTotal} USD";
                                                ucBackStop[j].LblChildPrice.Text = $"CHILD     x  {m_noCHD}   {childTotal + childBackTotal} USD";
                                                ucBackStop[j].LblInfantPrice.Text = $"INFANT   x  {m_noINF}   {infantTotal + infantBackTotal} USD";
                                                ucBackStop[j].LblTotalPrice.Text = $"TOTAL: {GrandTotal}";


                                                ucBackStop[j].LblPrice.Text = $"USD {GrandTotal.ToString()}";

                                                FlpFlightSearchResults.Controls.Add(ucBackStop[j]);
                                            }
                                            // BOTH FLIGHTS HAVE STOPS
                                            else
                                            {
                                                // <--------- GO ------------>
                                                // TOP PART
                                                ucStop[j] = new UcReturnStopFlights();
                                                ucStop[j].LblDepartureTime.Text = Goflights[i].DepartureTime.ToString().Substring(0, 5);
                                                ucStop[j].LblArrivalTime.Text = Goflights[i].ArrivalTime.ToString().Substring(0, 5);
                                                ucStop[j].LblFromAndDepDate.Text = $"{Goflights[i].From.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucStop[j].LblToAndArrDate.Text = $"{Goflights[i].To.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucStop[j].LblFrom.Text = Goflights[i].CityFrom.ToUpper();
                                                ucStop[j].LblTo.Text = Goflights[i].CityTo.ToUpper();
                                                ucStop[j].LblStops.Text = Goflights[i].Stops.ToUpper();
                                                ucStop[j].LblClass.Text = "ECONOMY";
                                                if (Goflights[i].Logo != null)
                                                {
                                                    MemoryStream ms = new MemoryStream(Goflights[i].Logo);
                                                    ucStop[j].PbLogo1.Image = Image.FromStream(ms);
                                                    ucStop[j].PbLogo2.Image = Image.FromStream(ms);
                                                    ucStop[j].PbLogo3.Image = Image.FromStream(ms);
                                                    ucStop[j].PbLogo4.Image = Image.FromStream(ms);
                                                }

                                                ucStop[j].LblStops.Text = Goflights[i].Stops.ToString().Substring(0, 3);
                                                ucStop[j].LblNumberOfStops.Text = "2 Stop";

                                                // Flight duration and intervals will be calculated here.
                                                var interval = Goflights[i].ArrivalTime - Goflights[i].DepartureTime;
                                                ucStop[j].LblDuration.Text = $"{interval.Hours.ToString()}h {interval.Minutes.ToString()}m";


                                                // DETAILS
                                                ucStop[j].LblDayDate.Text = Goflights[i].DepartureDate.ToString("ddd, dd MMM");
                                                ucStop[j].LblAirlines.Text = $"{Goflights[i].FlightNo}-{Returnflights[j].Airlines.ToString()}";
                                                ucStop[j].LblAirType.Text = Goflights[i].Model.ToString();
                                                ucStop[j].LblOriginAirport.Text = $"{Goflights[i].DepartureTime.ToString().Substring(0, 5)} - {Goflights[i].From.Substring(6)}";
                                                ucStop[j].LblConnectionAirport.Text = $"Connection - {Goflights[i].Stops.Substring(6)}";
                                                ucStop[j].LblDestinationAirport.Text = $"{Goflights[i].ArrivalTime.ToString().Substring(0, 5)} - {Goflights[i].To.Substring(6)}";
                                                ucStop[j].LblSeatsAvailable.Text = $"{Goflights[i].EconomySeats} Seats available";

                                                // <---------- RETURN -------------->

                                                ucStop[j].LblDayDateR.Text = Returnflights[j].DepartureDate.ToString("ddd, dd MMM");
                                                ucStop[j].LblAirlinesR.Text = $"{Returnflights[j].FlightNo}-{Returnflights[j].Airlines.ToString()}";
                                                ucStop[j].LblAirTypeR.Text = Returnflights[j].Model.ToString();
                                                ucStop[j].LblOriginAirportR.Text = $"{Returnflights[j].DepartureTime.ToString().Substring(0, 5)} - {Returnflights[j].From.Substring(6)}";
                                                ucStop[j].LblConnectionAirportR.Text = $"Connection - {Returnflights[j].Stops.Substring(6)}";
                                                ucStop[j].LblDestinationAirportR.Text = $"{Returnflights[j].ArrivalTime.ToString().Substring(0, 5)} - {Returnflights[j].To.Substring(6)}";
                                                ucStop[j].LblSeatsAvailableR.Text = $"{Returnflights[j].EconomySeats} Seats available";

                                                // Price of the travelling people will be calculated here.
                                                decimal Gototal = 0;
                                                decimal Backtotal = 0;
                                                decimal GrandTotal = 0;

                                                decimal adultsTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Goflights[i].AdultEconomyPrice;
                                                decimal childTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Goflights[i].ChildEconomyPrice;
                                                decimal infantTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Goflights[i].InfantEconomyPrice;
                                                Gototal = adultsTotal + childTotal + infantTotal;

                                                decimal adultsBackTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Returnflights[j].AdultEconomyPrice;
                                                decimal childBackTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Returnflights[j].ChildEconomyPrice;
                                                decimal infantBackTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Returnflights[j].InfantEconomyPrice;
                                                Backtotal = adultsBackTotal + childBackTotal + infantBackTotal;
                                                GrandTotal = Gototal + Backtotal;


                                                m_noADL = (CmbAdult.SelectedIndex == 0 ? 0 : int.Parse(CmbAdult.Text));
                                                m_noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                                                m_noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));

                                                // Price break down
                                                ucStop[j].LblAdultPrice.Text = $"ADULT     x  {m_noADL}   {adultsTotal + adultsBackTotal} USD";
                                                ucStop[j].LblChildPrice.Text = $"CHILD     x  {m_noCHD}   {childTotal + childBackTotal} USD";
                                                ucStop[j].LblInfantPrice.Text = $"INFANT   x  {m_noINF}   {infantTotal + infantBackTotal} USD";
                                                ucStop[j].LblTotalPrice.Text = $"TOTAL: {GrandTotal}";


                                                ucStop[j].LblPrice.Text = $"USD {GrandTotal.ToString()}";

                                                FlpFlightSearchResults.Controls.Add(ucStop[j]);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No return flights are available from the selected date.", "no flight", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No departure flights are available from the selected date.", "no flight", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                else
                {
                    // ONEWAY BUSINESS
                    if (RbtnOneway.Checked)
                    {
                        if (DtFrom.Value.Date < DateTime.Now.Date)
                        {
                            MessageBox.Show("Invalid departure date, please check.", "date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Flight search = new Flight();
                            var flights = search.SearchBusinessFromSingleAirline(TxtFrom.Text, TxtTo.Text, DtFrom.Value.ToString("yyyy/MM/dd"));

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
                                        ucDirect[i].LblClass.Text = "BUSINESS";
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
                                        decimal adultsTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * flights[i].AdultBusinessPrice;
                                        decimal childTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * flights[i].ChildBusinessPrice;
                                        decimal infantTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * flights[i].InfantBusinessPrice;
                                        total = adultsTotal + childTotal + infantTotal;
                                        ucDirect[i].LblPrice.Text = $"USD {total.ToString()}";

                                        m_noADL = (CmbAdult.SelectedIndex == 0 ? 0 : int.Parse(CmbAdult.Text));
                                        m_noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                                        m_noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));

                                        // DETAILS
                                        ucDirect[i].LblDayDate.Text = flights[i].DepartureDate.ToString("ddd, dd MMM");
                                        ucDirect[i].LblAirlines.Text = $"{flights[i].FlightNo}-{flights[i].Airlines.ToString()}";
                                        ucDirect[i].LblAirType.Text = flights[i].Model.ToString();
                                        ucDirect[i].LblOriginAirport.Text = $"{flights[i].DepartureTime.ToString().Substring(0, 5)} - {flights[i].From.Substring(6)}";
                                        ucDirect[i].LblDestinationAirport.Text = $"{flights[i].ArrivalTime.ToString().Substring(0, 5)} - {flights[i].To.Substring(6)}";
                                        ucDirect[i].LblSeatsAvailable.Text = $"{flights[i].BusinessSeats} Seats available";

                                        // Price break down
                                        ucDirect[i].LblAdultPrice.Text = $"ADULT     x  {m_noADL}   {adultsTotal} USD";
                                        ucDirect[i].LblChildPrice.Text = $"CHILD     x  {m_noCHD}   {childTotal} USD";
                                        ucDirect[i].LblInfantPrice.Text = $"INFANT   x  {m_noINF}   {infantTotal} USD";
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
                                        ucStop[i].LblClass.Text = "BUSINESS";
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
                                        decimal adultsTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * flights[i].AdultBusinessPrice;
                                        decimal childTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * flights[i].ChildBusinessPrice;
                                        decimal infantTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * flights[i].InfantBusinessPrice;
                                        total = adultsTotal + childTotal + infantTotal;
                                        ucStop[i].LblPrice.Text = $"USD {total.ToString()}";

                                        m_noADL = (CmbAdult.SelectedIndex == 0 ? 0 : int.Parse(CmbAdult.Text));
                                        m_noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                                        m_noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));

                                        // DETAILS
                                        ucStop[i].LblDayDate.Text = flights[i].DepartureDate.ToString("ddd, dd MMM");
                                        ucStop[i].LblAirlines.Text = $"{flights[i].FlightNo}-{flights[i].Airlines.ToString()}";
                                        ucStop[i].LblAirType.Text = flights[i].Model.ToString();
                                        ucStop[i].LblOriginAirport.Text = $"{flights[i].DepartureTime.ToString().Substring(0, 5)} - {flights[i].From.Substring(6)}";
                                        ucStop[i].LblStopAirport.Text = $"Connection - {flights[i].Stops.Substring(6)}";
                                        ucStop[i].LblDestinationAirport.Text = $"{flights[i].ArrivalTime.ToString().Substring(0, 5)} - {flights[i].To.Substring(6)}";
                                        ucStop[i].LblSeatsAvailable.Text = $"{flights[i].BusinessSeats} Seats available";

                                        // Price break down

                                        ucStop[i].LblAdultPrice.Text = $"ADULT     x  {m_noADL}   {adultsTotal} USD";
                                        ucStop[i].LblChildPrice.Text = $"CHILD     x  {m_noCHD}   {childTotal} USD";
                                        ucStop[i].LblInfantPrice.Text = $"INFANT   x  {m_noINF}   {infantTotal} USD";
                                        ucStop[i].LblTotalPrice.Text = $"TOTAL: {total}";


                                        ucStop[i].LblPrice.Text = $"USD {total.ToString()}";

                                        FlpFlightSearchResults.Controls.Add(ucStop[i]);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No flights are available from the airlines we searched.", "no flight", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    // ROUNDTRIP BUSINESS
                    else
                    {
                        if (DtFrom.Value.Date < DateTime.Now.Date || DtTo.Value.Date < DateTime.Now.Date)
                        {
                            MessageBox.Show("Invalid departure or return date, please check.", "date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Flight search = new Flight();
                            var Goflights = search.SearchBusinessFromSingleAirline(TxtFrom.Text, TxtTo.Text, DtFrom.Value.ToString("yyyy/MM/dd"));
                            var Returnflights = search.SearchBusinessFromSingleAirline(TxtTo.Text, TxtFrom.Text, DtTo.Value.ToString("yyyy/MM/dd"));

                            FlpFlightSearchResults.Controls.Clear();
                            if (Goflights.Count > 0)
                            {
                                if (Returnflights.Count > 0)
                                {
                                    UcReturnDirectFlights[] ucDirect = new UcReturnDirectFlights[10];
                                    UcReturnGoStopFlights[] ucGoStop = new UcReturnGoStopFlights[10];
                                    UcReturnBackStopFlights[] ucBackStop = new UcReturnBackStopFlights[10];
                                    UcReturnStopFlights[] ucStop = new UcReturnStopFlights[10];

                                    for (int i = 0; i < Goflights.Count; i++)
                                    {
                                        for (int j = 0; j < Returnflights.Count; j++)
                                        {
                                            // BOTH FLIGHT ARE DIRECT
                                            if (Goflights[i].Stops == "Direct" && Returnflights[j].Stops == "Direct")
                                            {
                                                // <--------- GO ------------>
                                                // TOP PART
                                                ucDirect[j] = new UcReturnDirectFlights();
                                                ucDirect[j].LblDepartureTime.Text = Goflights[i].DepartureTime.ToString().Substring(0, 5);
                                                ucDirect[j].LblArrivalTime.Text = Goflights[i].ArrivalTime.ToString().Substring(0, 5);
                                                ucDirect[j].LblFromAndDepDate.Text = $"{Goflights[i].From.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucDirect[j].LblToAndArrDate.Text = $"{Goflights[i].To.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucDirect[j].LblFrom.Text = Goflights[i].CityFrom.ToUpper();
                                                ucDirect[j].LblTo.Text = Goflights[i].CityTo.ToUpper();
                                                ucDirect[j].LblStops.Text = Goflights[i].Stops.ToUpper();
                                                ucDirect[j].LblClass.Text = "BUSINESS";
                                                if (Goflights[i].Logo != null)
                                                {
                                                    MemoryStream ms = new MemoryStream(Goflights[i].Logo);
                                                    ucDirect[i].PbLogo1.Image = Image.FromStream(ms);
                                                    ucDirect[i].PbLogo2.Image = Image.FromStream(ms);
                                                    ucDirect[i].PbLogo3.Image = Image.FromStream(ms);
                                                    ucDirect[i].PbLogo4.Image = Image.FromStream(ms);
                                                }

                                                // Flight duration and intervals will be calculated here.
                                                var interval = Goflights[i].ArrivalTime - Goflights[i].DepartureTime;
                                                ucDirect[j].LblDuration.Text = $"{interval.Hours.ToString()}h {interval.Minutes.ToString()}m";


                                                // DETAILS
                                                ucDirect[j].LblDayDate.Text = Goflights[i].DepartureDate.ToString("ddd, dd MMM");
                                                ucDirect[j].LblAirlines.Text = $"{Goflights[i].FlightNo}-{Goflights[i].Airlines.ToString()}";
                                                ucDirect[j].LblAirType.Text = Goflights[i].Model.ToString();
                                                ucDirect[j].LblOriginAirport.Text = $"{Goflights[i].DepartureTime.ToString().Substring(0, 5)} - {Goflights[i].From.Substring(6)}";
                                                ucDirect[j].LblDestinationAirport.Text = $"{Goflights[i].ArrivalTime.ToString().Substring(0, 5)} - {Goflights[i].To.Substring(6)}";
                                                ucDirect[j].LblSeatsAvailable.Text = $"{Goflights[i].BusinessSeats} Seats available";

                                                // <---------- RETURN -------------->

                                                ucDirect[j].LblDayDateR.Text = Returnflights[j].DepartureDate.ToString("ddd, dd MMM");
                                                ucDirect[j].LblAirlinesR.Text = $"{Returnflights[j].FlightNo}-{Returnflights[j].Airlines.ToString()}";
                                                ucDirect[j].LblAirTypeR.Text = Returnflights[j].Model.ToString();
                                                ucDirect[j].LblOriginAirportR.Text = $"{Returnflights[j].DepartureTime.ToString().Substring(0, 5)} - {Returnflights[j].From.Substring(6)}";
                                                ucDirect[j].LblDestinationAirportR.Text = $"{Returnflights[j].ArrivalTime.ToString().Substring(0, 5)} - {Returnflights[j].To.Substring(6)}";
                                                ucDirect[j].LblSeatsAvailableR.Text = $"{Returnflights[j].BusinessSeats} Seats available";

                                                // Price of the travelling people will be calculated here.
                                                decimal Gototal = 0;
                                                decimal Backtotal = 0;
                                                decimal GrandTotal = 0;

                                                decimal adultsTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Goflights[i].AdultBusinessPrice;
                                                decimal childTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Goflights[i].ChildBusinessPrice;
                                                decimal infantTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Goflights[i].InfantBusinessPrice;
                                                Gototal = adultsTotal + childTotal + infantTotal;

                                                decimal adultsBackTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Returnflights[j].AdultBusinessPrice;
                                                decimal childBackTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Returnflights[j].ChildBusinessPrice;
                                                decimal infantBackTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Returnflights[j].InfantBusinessPrice;
                                                Backtotal = adultsBackTotal + childBackTotal + infantBackTotal;
                                                GrandTotal = Gototal + Backtotal;


                                                m_noADL = (CmbAdult.SelectedIndex == 0 ? 0 : int.Parse(CmbAdult.Text));
                                                m_noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                                                m_noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));

                                                // Price break down
                                                ucDirect[j].LblAdultPrice.Text = $"ADULT     x  {m_noADL}   {adultsTotal + adultsBackTotal} USD";
                                                ucDirect[j].LblChildPrice.Text = $"CHILD     x  {m_noCHD}   {childTotal + childBackTotal} USD";
                                                ucDirect[j].LblInfantPrice.Text = $"INFANT   x  {m_noINF}   {infantTotal + infantBackTotal} USD";
                                                ucDirect[j].LblTotalPrice.Text = $"TOTAL: {GrandTotal}";


                                                ucDirect[j].LblPrice.Text = $"USD {GrandTotal.ToString()}";

                                                FlpFlightSearchResults.Controls.Add(ucDirect[j]);
                                            }
                                            // DEPARTURE HAS STOP AND RETURN IS DIRECT
                                            else if (Goflights[i].Stops != "Direct" && Returnflights[j].Stops == "Direct")
                                            {
                                                // <--------- GO ------------>
                                                // TOP PART
                                                ucGoStop[j] = new UcReturnGoStopFlights();
                                                ucGoStop[j].LblDepartureTime.Text = Goflights[i].DepartureTime.ToString().Substring(0, 5);
                                                ucGoStop[j].LblArrivalTime.Text = Goflights[i].ArrivalTime.ToString().Substring(0, 5);
                                                ucGoStop[j].LblFromAndDepDate.Text = $"{Goflights[i].From.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucGoStop[j].LblToAndArrDate.Text = $"{Goflights[i].To.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucGoStop[j].LblFrom.Text = Goflights[i].CityFrom.ToUpper();
                                                ucGoStop[j].LblTo.Text = Goflights[i].CityTo.ToUpper();
                                                ucGoStop[j].LblStops.Text = Goflights[i].Stops.ToUpper();
                                                ucGoStop[j].LblClass.Text = "BUSINESS";
                                                if (Goflights[i].Logo != null)
                                                {
                                                    MemoryStream ms = new MemoryStream(Goflights[i].Logo);
                                                    ucGoStop[j].PbLogo1.Image = Image.FromStream(ms);
                                                    ucGoStop[j].PbLogo2.Image = Image.FromStream(ms);
                                                    ucGoStop[j].PbLogo3.Image = Image.FromStream(ms);
                                                    ucGoStop[j].PbLogo4.Image = Image.FromStream(ms);
                                                }

                                                ucGoStop[j].LblStops.Text = Goflights[i].Stops.ToString().Substring(0, 3);
                                                ucGoStop[j].LblNumberOfStops.Text = "1 Stop";

                                                // Flight duration and intervals will be calculated here.
                                                var interval = Goflights[i].ArrivalTime - Goflights[i].DepartureTime;
                                                ucGoStop[j].LblDuration.Text = $"{interval.Hours.ToString()}h {interval.Minutes.ToString()}m";


                                                // DETAILS
                                                ucGoStop[j].LblDayDate.Text = Goflights[i].DepartureDate.ToString("ddd, dd MMM");
                                                ucGoStop[j].LblAirlines.Text = $"{Goflights[i].FlightNo}-{Returnflights[j].Airlines.ToString()}";
                                                ucGoStop[j].LblAirType.Text = Goflights[i].Model.ToString();
                                                ucGoStop[j].LblOriginAirport.Text = $"{Goflights[i].DepartureTime.ToString().Substring(0, 5)} - {Goflights[i].From.Substring(6)}";
                                                ucGoStop[j].LblConnectionAirport.Text = $"Connection - {Goflights[i].Stops.Substring(6)}";
                                                ucGoStop[j].LblDestinationAirport.Text = $"{Goflights[i].ArrivalTime.ToString().Substring(0, 5)} - {Goflights[i].To.Substring(6)}";
                                                ucGoStop[j].LblSeatsAvailable.Text = $"{Goflights[i].BusinessSeats} Seats available";

                                                // <---------- RETURN -------------->

                                                ucGoStop[j].LblDayDateR.Text = Returnflights[j].DepartureDate.ToString("ddd, dd MMM");
                                                ucGoStop[j].LblAirlinesR.Text = $"{Returnflights[j].FlightNo}-{Returnflights[j].Airlines.ToString()}";
                                                ucGoStop[j].LblAirTypeR.Text = Returnflights[j].Model.ToString();
                                                ucGoStop[j].LblOriginAirportR.Text = $"{Returnflights[j].DepartureTime.ToString().Substring(0, 5)} - {Returnflights[j].From.Substring(6)}";
                                                ucGoStop[j].LblDestinationAirportR.Text = $"{Returnflights[j].ArrivalTime.ToString().Substring(0, 5)} - {Returnflights[j].To.Substring(6)}";
                                                ucGoStop[j].LblSeatsAvailableR.Text = $"{Returnflights[j].EconomySeats} Seats available";



                                                // Price of the travelling people will be calculated here.
                                                decimal Gototal = 0;
                                                decimal Backtotal = 0;
                                                decimal GrandTotal = 0;

                                                decimal adultsTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Goflights[i].AdultBusinessPrice;
                                                decimal childTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Goflights[i].ChildBusinessPrice;
                                                decimal infantTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Goflights[i].InfantBusinessPrice;
                                                Gototal = adultsTotal + childTotal + infantTotal;

                                                decimal adultsBackTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Returnflights[j].AdultBusinessPrice;
                                                decimal childBackTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Returnflights[j].ChildBusinessPrice;
                                                decimal infantBackTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Returnflights[j].InfantBusinessPrice;
                                                Backtotal = adultsBackTotal + childBackTotal + infantBackTotal;
                                                GrandTotal = Gototal + Backtotal;


                                                m_noADL = (CmbAdult.SelectedIndex == 0 ? 0 : int.Parse(CmbAdult.Text));
                                                m_noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                                                m_noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));

                                                // Price break down
                                                ucGoStop[j].LblAdultPrice.Text = $"ADULT     x  {m_noADL}   {adultsTotal + adultsBackTotal} USD";
                                                ucGoStop[j].LblChildPrice.Text = $"CHILD     x  {m_noCHD}   {childTotal + childBackTotal} USD";
                                                ucGoStop[j].LblInfantPrice.Text = $"INFANT   x  {m_noINF}   {infantTotal + infantBackTotal} USD";
                                                ucGoStop[j].LblTotalPrice.Text = $"TOTAL: {GrandTotal}";


                                                ucGoStop[j].LblPrice.Text = $"USD {GrandTotal.ToString()}";

                                                FlpFlightSearchResults.Controls.Add(ucGoStop[j]);
                                            }
                                            // DEPARTURE IS DIRECT AND RETURN HAS STOP
                                            else if (Goflights[i].Stops == "Direct" && Returnflights[j].Stops != "Direct")
                                            {
                                                // <--------- GO ------------>
                                                // TOP PART
                                                ucBackStop[j] = new UcReturnBackStopFlights();
                                                ucBackStop[j].LblDepartureTime.Text = Goflights[i].DepartureTime.ToString().Substring(0, 5);
                                                ucBackStop[j].LblArrivalTime.Text = Goflights[i].ArrivalTime.ToString().Substring(0, 5);
                                                ucBackStop[j].LblFromAndDepDate.Text = $"{Goflights[i].From.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucBackStop[j].LblToAndArrDate.Text = $"{Goflights[i].To.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucBackStop[j].LblFrom.Text = Goflights[i].CityFrom.ToUpper();
                                                ucBackStop[j].LblTo.Text = Goflights[i].CityTo.ToUpper();
                                                ucBackStop[j].LblStops.Text = Goflights[i].Stops.ToUpper();
                                                ucBackStop[j].LblClass.Text = "BUSINESS";
                                                if (Goflights[i].Logo != null)
                                                {
                                                    MemoryStream ms = new MemoryStream(Goflights[i].Logo);
                                                    ucBackStop[j].PbLogo1.Image = Image.FromStream(ms);
                                                    ucBackStop[j].PbLogo2.Image = Image.FromStream(ms);
                                                    ucBackStop[j].PbLogo3.Image = Image.FromStream(ms);
                                                    ucBackStop[j].PbLogo4.Image = Image.FromStream(ms);
                                                }

                                                // Flight duration and intervals will be calculated here.
                                                var interval = Goflights[i].ArrivalTime - Goflights[i].DepartureTime;
                                                ucBackStop[j].LblDuration.Text = $"{interval.Hours.ToString()}h {interval.Minutes.ToString()}m";


                                                // DETAILS
                                                ucBackStop[j].LblDayDate.Text = Goflights[i].DepartureDate.ToString("ddd, dd MMM");
                                                ucBackStop[j].LblAirlines.Text = $"{Goflights[i].FlightNo}-{Goflights[i].Airlines.ToString()}";
                                                ucBackStop[j].LblAirType.Text = Goflights[i].Model.ToString();
                                                ucBackStop[j].LblOriginAirport.Text = $"{Goflights[i].DepartureTime.ToString().Substring(0, 5)} - {Goflights[i].From.Substring(6)}";
                                                ucBackStop[j].LblDestinationAirport.Text = $"{Goflights[i].ArrivalTime.ToString().Substring(0, 5)} - {Goflights[i].To.Substring(6)}";
                                                ucBackStop[j].LblSeatsAvailable.Text = $"{Goflights[i].BusinessSeats} Seats available";

                                                // <---------- RETURN -------------->

                                                ucBackStop[j].LblDayDateR.Text = Returnflights[j].DepartureDate.ToString("ddd, dd MMM");
                                                ucBackStop[j].LblAirlinesR.Text = $"{Returnflights[j].FlightNo}-{Returnflights[j].Airlines.ToString()}";
                                                ucBackStop[j].LblAirTypeR.Text = Returnflights[j].Model.ToString();
                                                ucBackStop[j].LblOriginAirportR.Text = $"{Returnflights[j].DepartureTime.ToString().Substring(0, 5)} - {Returnflights[j].From.Substring(6)}";
                                                ucBackStop[j].LblConnectionAirport.Text = $"Connection - {Returnflights[j].Stops.Substring(6)}";
                                                ucBackStop[j].LblDestinationAirportR.Text = $"{Returnflights[j].ArrivalTime.ToString().Substring(0, 5)} - {Returnflights[j].To.Substring(6)}";
                                                ucBackStop[j].LblSeatsAvailableR.Text = $"{Returnflights[j].BusinessSeats} Seats available";

                                                // Price of the travelling people will be calculated here.
                                                decimal Gototal = 0;
                                                decimal Backtotal = 0;
                                                decimal GrandTotal = 0;

                                                decimal adultsTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Goflights[i].AdultBusinessPrice;
                                                decimal childTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Goflights[i].ChildBusinessPrice;
                                                decimal infantTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Goflights[i].InfantBusinessPrice;
                                                Gototal = adultsTotal + childTotal + infantTotal;

                                                decimal adultsBackTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Returnflights[j].AdultBusinessPrice;
                                                decimal childBackTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Returnflights[j].ChildBusinessPrice;
                                                decimal infantBackTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Returnflights[j].InfantBusinessPrice;
                                                Backtotal = adultsBackTotal + childBackTotal + infantBackTotal;
                                                GrandTotal = Gototal + Backtotal;


                                                m_noADL = (CmbAdult.SelectedIndex == 0 ? 0 : int.Parse(CmbAdult.Text));
                                                m_noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                                                m_noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));

                                                // Price break down
                                                ucBackStop[j].LblAdultPrice.Text = $"ADULT     x  {m_noADL}   {adultsTotal + adultsBackTotal} USD";
                                                ucBackStop[j].LblChildPrice.Text = $"CHILD     x  {m_noCHD}   {childTotal + childBackTotal} USD";
                                                ucBackStop[j].LblInfantPrice.Text = $"INFANT   x  {m_noINF}   {infantTotal + infantBackTotal} USD";
                                                ucBackStop[j].LblTotalPrice.Text = $"TOTAL: {GrandTotal}";


                                                ucBackStop[j].LblPrice.Text = $"USD {GrandTotal.ToString()}";

                                                FlpFlightSearchResults.Controls.Add(ucBackStop[j]);
                                            }
                                            // BOTH FLIGHTS HAVE STOPS
                                            else
                                            {
                                                // <--------- GO ------------>
                                                // TOP PART
                                                ucStop[j] = new UcReturnStopFlights();
                                                ucStop[j].LblDepartureTime.Text = Goflights[i].DepartureTime.ToString().Substring(0, 5);
                                                ucStop[j].LblArrivalTime.Text = Goflights[i].ArrivalTime.ToString().Substring(0, 5);
                                                ucStop[j].LblFromAndDepDate.Text = $"{Goflights[i].From.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucStop[j].LblToAndArrDate.Text = $"{Goflights[i].To.ToString().Substring(0, 3)} - {Goflights[i].DepartureDate.ToString("dd MMM")}";
                                                ucStop[j].LblFrom.Text = Goflights[i].CityFrom.ToUpper();
                                                ucStop[j].LblTo.Text = Goflights[i].CityTo.ToUpper();
                                                ucStop[j].LblStops.Text = Goflights[i].Stops.ToUpper();
                                                ucStop[j].LblClass.Text = "BUSINESS";
                                                if (Goflights[i].Logo != null)
                                                {
                                                    MemoryStream ms = new MemoryStream(Goflights[i].Logo);
                                                    ucStop[j].PbLogo1.Image = Image.FromStream(ms);
                                                    ucStop[j].PbLogo2.Image = Image.FromStream(ms);
                                                    ucStop[j].PbLogo3.Image = Image.FromStream(ms);
                                                    ucStop[j].PbLogo4.Image = Image.FromStream(ms);
                                                }

                                                ucStop[j].LblStops.Text = Goflights[i].Stops.ToString().Substring(0, 3);
                                                ucStop[j].LblNumberOfStops.Text = "1 Stop";

                                                // Flight duration and intervals will be calculated here.
                                                var interval = Goflights[i].ArrivalTime - Goflights[i].DepartureTime;
                                                ucStop[j].LblDuration.Text = $"{interval.Hours.ToString()}h {interval.Minutes.ToString()}m";


                                                // DETAILS
                                                ucStop[j].LblDayDate.Text = Goflights[i].DepartureDate.ToString("ddd, dd MMM");
                                                ucStop[j].LblAirlines.Text = $"{Goflights[i].FlightNo}-{Returnflights[j].Airlines.ToString()}";
                                                ucStop[j].LblAirType.Text = Goflights[i].Model.ToString();
                                                ucStop[j].LblOriginAirport.Text = $"{Goflights[i].DepartureTime.ToString().Substring(0, 5)} - {Goflights[i].From.Substring(6)}";
                                                ucStop[j].LblConnectionAirport.Text = $"Connection - {Goflights[i].Stops.Substring(6)}";
                                                ucStop[j].LblDestinationAirport.Text = $"{Goflights[i].ArrivalTime.ToString().Substring(0, 5)} - {Goflights[i].To.Substring(6)}";
                                                ucStop[j].LblSeatsAvailable.Text = $"{Goflights[i].BusinessSeats} Seats available";

                                                // <---------- RETURN -------------->

                                                ucStop[j].LblDayDateR.Text = Returnflights[j].DepartureDate.ToString("ddd, dd MMM");
                                                ucStop[j].LblAirlinesR.Text = $"{Returnflights[j].FlightNo}-{Returnflights[j].Airlines.ToString()}";
                                                ucStop[j].LblAirTypeR.Text = Returnflights[j].Model.ToString();
                                                ucStop[j].LblOriginAirportR.Text = $"{Returnflights[j].DepartureTime.ToString().Substring(0, 5)} - {Returnflights[j].From.Substring(6)}";
                                                ucStop[j].LblConnectionAirportR.Text = $"Connection - {Returnflights[j].Stops.Substring(6)}";
                                                ucStop[j].LblDestinationAirportR.Text = $"{Returnflights[j].ArrivalTime.ToString().Substring(0, 5)} - {Returnflights[j].To.Substring(6)}";
                                                ucStop[j].LblSeatsAvailableR.Text = $"{Returnflights[j].BusinessSeats} Seats available";

                                                // Price of the travelling people will be calculated here.
                                                decimal Gototal = 0;
                                                decimal Backtotal = 0;
                                                decimal GrandTotal = 0;

                                                decimal adultsTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Goflights[i].AdultBusinessPrice;
                                                decimal childTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Goflights[i].ChildBusinessPrice;
                                                decimal infantTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Goflights[i].InfantBusinessPrice;
                                                Gototal = adultsTotal + childTotal + infantTotal;

                                                decimal adultsBackTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * Returnflights[j].AdultBusinessPrice;
                                                decimal childBackTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * Returnflights[j].ChildBusinessPrice;
                                                decimal infantBackTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * Returnflights[j].InfantBusinessPrice;
                                                Backtotal = adultsBackTotal + childBackTotal + infantBackTotal;
                                                GrandTotal = Gototal + Backtotal;


                                                m_noADL = (CmbAdult.SelectedIndex == 0 ? 0 : int.Parse(CmbAdult.Text));
                                                m_noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                                                m_noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));

                                                // Price break down
                                                ucStop[j].LblAdultPrice.Text = $"ADULT     x  {m_noADL}   {adultsTotal + adultsBackTotal} USD";
                                                ucStop[j].LblChildPrice.Text = $"CHILD     x  {m_noCHD}   {childTotal + childBackTotal} USD";
                                                ucStop[j].LblInfantPrice.Text = $"INFANT   x  {m_noINF}   {infantTotal + infantBackTotal} USD";
                                                ucStop[j].LblTotalPrice.Text = $"TOTAL: {GrandTotal}";


                                                ucStop[j].LblPrice.Text = $"USD {GrandTotal.ToString()}";

                                                FlpFlightSearchResults.Controls.Add(ucStop[j]);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No return flights are available from the selected date.", "no flight", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No departure flights are available from the selected date.", "no flight", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            if(TxtFrom.Text == string.Empty && TxtTo.Text == string.Empty)
            {
                MessageBox.Show("No route available to switch.","switch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (TxtFrom.Text != string.Empty || TxtTo.Text != string.Empty)
            {
                var temp = TxtFrom.Text;
                TxtFrom.Text = TxtTo.Text;
                TxtTo.Text = temp;
            }
            else
            {
                var temp = TxtFrom.Text;
                TxtFrom.Text = TxtTo.Text;
                TxtTo.Text = temp;
            }
        }
    }
}
