using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassilBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyTooltip();

            DtFrom.Text = DateTime.Now.ToString();
            DtTo.Text = DateTime.Now.ToString();
        }


        /// <summary>
        /// Gives the user a hint of the current components
        /// </summary>
        private void MyTooltip()
        {
            var Mytip = new Guna2HtmlToolTip();

            Mytip.ToolTipIcon = ToolTipIcon.Info;
            //Mytip.IsBalloon = true;
            Mytip.ShowAlways = true;
            Mytip.ForeColor = Color.Red;

            Mytip.SetToolTip(DtFrom, "Departure date");
            Mytip.SetToolTip(DtTo, "Return date");
        }


        private void BtnFindFlight_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab("FindFlight");
        }

        private void BtnCheckBooking_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab("CheckBooking");
        }

        private void BtnSearchFlight_Click(object sender, EventArgs e)
        {
            if(TxtFrom.Text == string.Empty || TxtTo.Text == string.Empty || CmbClass.SelectedIndex == 0)
            {

            }
            else
            {
                if(RbtnOneway.Checked)
                {
                    if(CmbClass.SelectedIndex == 1)
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
                            uc[i].LblInfantPrice.Text =$"INF - {CmbInfant.Text} x {flight[i].InfantEconomyPrice} USD";
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
                if(TxtFrom.Text != string.Empty)
                {
                    lstDropDownFrom.Focus();
                    lstDropDownFrom.SelectedIndex = 0;
                }
            }
        }

        private void lstDropDown_KeyDown(object sender, KeyEventArgs e)
        {
            if(lstDropDownFrom.SelectedItem !=null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TxtFrom.Text = lstDropDownFrom.SelectedItem.ToString();
                    lstDropDownFrom.Visible = false;
                }
            }
        }

        private void lstDropDown_MouseClick(object sender, MouseEventArgs e)
        {
            if(lstDropDownFrom.SelectedItem !=null)
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
                if(lstDropDownFrom.SelectedItem != null)
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
            if(lstDropDownTo.SelectedItem != null)
            {
                TxtTo.Text = lstDropDownTo.SelectedItem.ToString();
                if (TxtFrom.Text == TxtTo.Text)
                {
                    MessageBox.Show("Origin and destination can't be the same. Please change one of them.","same destination detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(lstDropDownTo.SelectedItem != null)
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

        private void BtnAirlinesLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"H{this.Height.ToString()} W{this.Width.ToString()}");
        }

        private void RbtnOneway_CheckedChanged(object sender, EventArgs e)
        {
            if(RbtnOneway.Checked == true)
            {
                DtTo.Visible = false;
                DtFrom.Width += DtTo.Width + 6;

            }
            else
            {
                DtTo.Visible = true;
                DtFrom.Width = TxtFrom.Width;
            }
        }
    }
}
