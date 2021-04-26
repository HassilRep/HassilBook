using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassilBook
{
    public partial class FrmSearchEngine : Form
    {
        public FrmSearchEngine()
        {
            InitializeComponent();
            CheckRadionButton();

            DtFrom.Text = DateTime.Now.ToString();
            DtTo.Text = DateTime.Now.ToString();
        }

        private void BtnFindFlights_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab("tabPage1");
        }

        private void BtnFindBookings_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab("tabPage2");
        }

        private void RbtnOneway_CheckedChanged(object sender, EventArgs e)
        {
            CheckRadionButton();
        }

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

        private void TxtFrom_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;
            if (e.KeyCode != Keys.Enter)
            {
                try
                {
                    Task.Factory.StartNew(() =>
                    {
                        DatabaseConnection con = new DatabaseConnection();
                        MySqlCommand cmd;
                        cmd = con.ActiveConnection().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM tbl_Airports WHERE Airport like('%" + TxtFrom.Text + "%')";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                        sda.Fill(dt);
                        count = Convert.ToInt32(dt.Rows.Count.ToString());

                        this.Invoke(new Action(() =>
                        {
                            if (count > 0)
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
                        }));
                    });
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
            int count = 0;
            if (e.KeyCode != Keys.Enter)
            {
                try
                {
                    Task.Factory.StartNew(() =>
                    {
                        DatabaseConnection con = new DatabaseConnection();
                        MySqlCommand cmd;
                        cmd = con.ActiveConnection().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM tbl_Airports WHERE Airport like('%" + TxtTo.Text + "%')";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                        sda.Fill(dt);
                        count = Convert.ToInt32(dt.Rows.Count.ToString());

                        this.Invoke(new Action(() =>
                        {
                            if (count > 0)
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
                        }));
                    });
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
                if (lstDropDownFrom.SelectedItem != null)
                {
                    if (TxtFrom.Text != string.Empty)
                    {
                        if (TxtFrom.Text == TxtTo.Text)
                        {
                            MessageBox.Show("Origin and destination can't be the same. Please change one of them.", "same destination detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            lstDropDownTo.Focus();
                            lstDropDownTo.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void lstDropDownTo_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstDropDownTo.SelectedItem != null)
            {
                TxtTo.Text = lstDropDownTo.SelectedItem.ToString();
                if (TxtFrom.Text == TxtTo.Text)
                {
                    MessageBox.Show("Origin and destination can't be the same. Please change one of them.", "same destination detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtTo.Text = string.Empty;
                    lstDropDownTo.Visible = false;
                }
                else
                {
                    lstDropDownTo.Visible = false;
                }
            }
        }

        private void lstDropDownTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstDropDownTo.SelectedItem != null)
            {
                TxtTo.Text = lstDropDownTo.SelectedItem.ToString();
                if (e.KeyCode == Keys.Enter)
                {
                    if (TxtFrom.Text == TxtTo.Text)
                    {
                        MessageBox.Show("Origin and destination can't be the same. Please change one of them.", "same destination detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtTo.Text = string.Empty;
                        lstDropDownTo.Visible = false;
                    }
                    else
                    {
                        lstDropDownTo.Visible = false;
                    }
                }
            }
        }

        private void BtnSearchFlight_Click(object sender, EventArgs e)
        {
            if (TxtFrom.Text == string.Empty || TxtTo.Text == string.Empty || CmbClass.SelectedIndex == 0)
            {

            }
            else
            {
                if (RbtnOneway.Checked)
                {
                    if (CmbClass.SelectedIndex == 1)
                    {
                        // ECONOMY SEARCH RESULTS

                        FlpFlightSearchResults.Controls.Clear();
                        Flight f = new Flight();
                        var flight = f.EconomySearch(TxtFrom.Text, TxtTo.Text, DtFrom.Value.ToString("yyyy/MM/dd"));
                        UcFoundFlights[] uc = new UcFoundFlights[flight.Count];
                        for (int i = 0; i < uc.Length; i++)
                        {
                            uc[i] = new UcFoundFlights();
                            uc[i].LblDepartureTime.Text = flight[i].DepartureTime.ToString().Substring(0, 5);
                            uc[i].LblDetailDepTime.Text = flight[i].DepartureTime.ToString().Substring(0, 5);
                            uc[i].LblArrivalTime.Text = flight[i].ArrivalTime.ToString().Substring(0, 5);
                            uc[i].LblDetailArrTime.Text = flight[i].ArrivalTime.ToString().Substring(0, 5);
                            uc[i].LblFromAndDepDate.Text = $"{flight[i].From.ToString().Substring(0, 3)} - {flight[i].DepartureDate.ToString("dd MMM")}";
                            uc[i].LblToAndArrDate.Text = $"{flight[i].To.ToString().Substring(0, 3)} - {flight[i].DepartureDate.ToString("dd MMM")}";
                            uc[i].LblFrom.Text = flight[i].CityFrom.ToUpper();
                            uc[i].LblOrigin.Text = $"{flight[i].CityFrom} ({flight[i].From.ToString().Substring(0, 3)})";
                            uc[i].LblTo.Text = flight[i].CityTo.ToUpper();
                            uc[i].LblDestination.Text = $"{flight[i].CityTo} ({flight[i].To.ToString().Substring(0, 3)})";
                            uc[i].LblFlightID.Text = flight[i].FlightID.ToUpper();
                            uc[i].LblAirlines.Text = flight[i].Airlines;
                            uc[i].LblOriginAirport.Text = flight[i].From.ToString().Substring(5).Trim();
                            uc[i].LblDestinationAirport.Text = flight[i].To.ToString().Substring(5).Trim();
                            uc[i].LblClass.Text = $"Class: {CmbClass.Text}";

                            if (flight[i].Stops == "Direct")
                            {
                                uc[i].LblStops.Text = flight[i].Stops.ToUpper();
                                uc[i].LblNumberOfStops.Visible = false;
                                uc[i].LblStopover.Visible = false;
                            }
                            else
                            {
                                uc[i].LblNumberOfStops.Visible = true;
                                uc[i].LblNumberOfStops.Text = "1 Stop";
                                uc[i].LblStops.Text = flight[i].Stops.ToString().Substring(0, 3);
                                uc[i].LblStopover.Visible = true;
                                uc[i].LblStopover.Text = $"Stopover ({flight[i].Stops})";
                            }

                            if (Convert.IsDBNull(flight[i].Logo == null))
                            {
                                uc[i].PbLogo1.Image = null;
                                uc[i].PbLogo2.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(flight[i].Logo);
                                uc[i].PbLogo1.Image = Image.FromStream(ms);
                                uc[i].PbLogo2.Image = Image.FromStream(ms);
                                uc[i].PbLogo3.Image = Image.FromStream(ms);
                            }

                            // Flight duration and intervals will be calculated here.
                            var interval = flight[i].ArrivalTime - flight[i].DepartureTime;
                            uc[i].LblDuration.Text = $"{interval.Hours.ToString()}h {interval.Minutes.ToString()}m";

                            // Price of the travelling people will be calculated here.
                            decimal total = 0;
                            decimal adultsTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * flight[i].AdultEconomyPrice;
                            decimal childTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * flight[i].ChildEconomyPrice;
                            decimal infantTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * flight[i].InfantEconomyPrice;
                            total = adultsTotal + childTotal + infantTotal;

                            // Price break down
                            uc[i].LblAdultPrice.Text = $"ADL - {CmbAdult.Text} x {flight[i].AdultEconomyPrice} USD";
                            uc[i].LblChildPrice.Text = $"CHD - {CmbChild.Text} x {flight[i].ChildEconomyPrice} USD";
                            uc[i].LblInfantPrice.Text = $"INF - {CmbInfant.Text} x {flight[i].InfantEconomyPrice} USD";
                            uc[i].LblTotalPrice.Text = $"TOTAL: {total}";


                            uc[i].LblPrice.Text = $"USD {total.ToString()}";
                            uc[i].Width = FlpFlightSearchResults.Width - 21;
                            FlpFlightSearchResults.Controls.Add(uc[i]);
                        }
                    }
                    else
                    {
                        // BUSINESS SEARCH RESULTS

                        FlpFlightSearchResults.Controls.Clear();
                        Flight f = new Flight();
                        var flight = f.BusinessSearch(TxtFrom.Text, TxtTo.Text, DtFrom.Value.ToString("yyyy/MM/dd"));
                        UcFoundFlights[] uc = new UcFoundFlights[flight.Count];
                        for (int i = 0; i < uc.Length; i++)
                        {
                            uc[i] = new UcFoundFlights();
                            uc[i].LblDepartureTime.Text = flight[i].DepartureTime.ToString().Substring(0, 5);
                            uc[i].LblDetailDepTime.Text = flight[i].DepartureTime.ToString().Substring(0, 5);
                            uc[i].LblArrivalTime.Text = flight[i].ArrivalTime.ToString().Substring(0, 5);
                            uc[i].LblDetailArrTime.Text = flight[i].ArrivalTime.ToString().Substring(0, 5);
                            uc[i].LblFromAndDepDate.Text = $"{flight[i].From.ToString().Substring(0, 3)} - {flight[i].DepartureDate.ToString("dd MMM")}";
                            uc[i].LblToAndArrDate.Text = $"{flight[i].To.ToString().Substring(0, 3)} - {flight[i].DepartureDate.ToString("dd MMM")}";
                            uc[i].LblFrom.Text = flight[i].CityFrom.ToUpper();
                            uc[i].LblOrigin.Text = $"{flight[i].CityFrom} ({flight[i].From.ToString().Substring(0, 3)})";
                            uc[i].LblTo.Text = flight[i].CityTo.ToUpper();
                            uc[i].LblDestination.Text = $"{flight[i].CityTo} ({flight[i].To.ToString().Substring(0, 3)})";
                            uc[i].LblFlightID.Text = flight[i].FlightID.ToUpper();
                            uc[i].LblAirlines.Text = flight[i].Airlines;
                            uc[i].LblOriginAirport.Text = flight[i].From.ToString().Substring(5).Trim();
                            uc[i].LblDestinationAirport.Text = flight[i].To.ToString().Substring(5).Trim();
                            uc[i].LblClass.Text = $"Class: {CmbClass.Text}";

                            if (flight[i].Stops == "Direct")
                            {
                                uc[i].LblStops.Text = flight[i].Stops.ToUpper();
                                uc[i].LblNumberOfStops.Visible = false;
                                uc[i].LblStopover.Visible = false;
                            }
                            else
                            {
                                uc[i].LblNumberOfStops.Visible = true;
                                uc[i].LblNumberOfStops.Text = "1 Stop";
                                uc[i].LblStops.Text = flight[i].Stops.ToString().Substring(0, 3);
                                uc[i].LblStopover.Visible = true;
                                uc[i].LblStopover.Text = $"Stopover ({flight[i].Stops})";
                            }

                            if (Convert.IsDBNull(flight[i].Logo == null))
                            {
                                uc[i].PbLogo1.Image = null;
                                uc[i].PbLogo2.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(flight[i].Logo);
                                uc[i].PbLogo1.Image = Image.FromStream(ms);
                                uc[i].PbLogo2.Image = Image.FromStream(ms);
                                uc[i].PbLogo3.Image = Image.FromStream(ms);
                            }

                            // Flight duration and intervals will be calculated here.
                            var interval = flight[i].ArrivalTime - flight[i].DepartureTime;
                            uc[i].LblDuration.Text = $"{interval.Hours.ToString()}h {interval.Minutes.ToString()}m";

                            // Price of the travelling people will be calculated here.
                            decimal total = 0;
                            decimal adultsTotal = (CmbAdult.SelectedIndex == 0 ? CmbAdult.SelectedIndex = 1 : int.Parse(CmbAdult.Text)) * flight[i].AdultBusinessPrice;
                            decimal childTotal = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text)) * flight[i].ChildBusinessPrice;
                            decimal infantTotal = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text)) * flight[i].InfantBusinessPrice;
                            total = adultsTotal + childTotal + infantTotal;

                            // Price break down
                            uc[i].LblAdultPrice.Text = $"ADL - {CmbAdult.Text} x {flight[i].AdultBusinessPrice} USD";
                            uc[i].LblChildPrice.Text = $"CHD - {CmbChild.Text} x {flight[i].ChildBusinessPrice} USD";
                            uc[i].LblInfantPrice.Text = $"INF - {CmbInfant.Text} x {flight[i].InfantBusinessPrice} USD";
                            uc[i].LblTotalPrice.Text = $"TOTAL: {total}";


                            uc[i].LblPrice.Text = $"USD {total.ToString()}";
                            uc[i].Width = FlpFlightSearchResults.Width - 21;
                            FlpFlightSearchResults.Controls.Add(uc[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Currently not available.");
                }
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            UcOnewayDirectFlights[] uc = new UcOnewayDirectFlights[1];
            UcFoundFlights[] t = new UcFoundFlights[1];
            for (int i = 0; i < uc.Length; i++)
            {
                uc[i] = new UcOnewayDirectFlights();
                FlpFlightSearchResults.Controls.Add(uc[i]);
            }


            UcOnewayStopFlights[] uc1 = new UcOnewayStopFlights[1];
            UcFoundFlights[] t1 = new UcFoundFlights[1];
            for (int i = 0; i < uc1.Length; i++)
            {
                uc1[i] = new UcOnewayStopFlights();
                FlpFlightSearchResults.Controls.Add(uc1[i]);
            }


            UcReturnBackStopFlights[] uc2 = new UcReturnBackStopFlights[1];
            UcFoundFlights[] t2 = new UcFoundFlights[1];
            for (int i = 0; i < uc1.Length; i++)
            {
                uc2[i] = new UcReturnBackStopFlights();
                FlpFlightSearchResults.Controls.Add(uc2[i]);
            }


            UcReturnDirectFlights[] uc3 = new UcReturnDirectFlights[1];
            UcFoundFlights[] t3 = new UcFoundFlights[1];
            for (int i = 0; i < uc1.Length; i++)
            {
                uc3[i] = new UcReturnDirectFlights();
                FlpFlightSearchResults.Controls.Add(uc3[i]);
            }


            UcReturnGoStopFlights[] uc4 = new UcReturnGoStopFlights[1];
            UcFoundFlights[] t4 = new UcFoundFlights[1];
            for (int i = 0; i < uc1.Length; i++)
            {
                uc4[i] = new UcReturnGoStopFlights();
                FlpFlightSearchResults.Controls.Add(uc4[i]);
            }

            UcReturnStopFlights[] uc5 = new UcReturnStopFlights[1];
            UcFoundFlights[] t5 = new UcFoundFlights[1];
            for (int i = 0; i < uc1.Length; i++)
            {
                uc5[i] = new UcReturnStopFlights();
                FlpFlightSearchResults.Controls.Add(uc5[i]);
            }

            PnlFilter.Visible = true;
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //LblToPrice.Text = $"{guna2TrackBar1.Value.ToString()} USD";
        }
    }
}
