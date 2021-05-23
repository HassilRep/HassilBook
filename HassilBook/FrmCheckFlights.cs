using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HassilBook
{
    public partial class FrmCheckFlights : Form
    {
        #region MEMBERS

        DatabaseConnection con = new DatabaseConnection();
        int m_noADL;
        int m_noCHD;
        int m_noINF;

        #endregion

        #region CONSTRUCTOR
        public FrmCheckFlights()
        {
            InitializeComponent();
            DtFrom.Text = DateTime.Now.ToString();
            DtTo.Text = DateTime.Now.ToString();
            CheckRadionButton();
        }
        #endregion
        private void DGClientAirplanes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cel = DGClientAirplanes.Columns[e.ColumnIndex].Name;

            if(cel == "BOOK")
            {
                FrmBookingCart cart = new FrmBookingCart();
                cart.ShowDialog();
            }
            else if(cel == "DETAILS")
            {
                MessageBox.Show("Booking details is on the way");
            }
        }

        private void BtnSearchFlight_Click(object sender, EventArgs e)
        {
            if (TxtFrom.Text == string.Empty || TxtTo.Text == string.Empty)
            {
                MessageBox.Show("Select the route you want to search please.", "route", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DGClientAirplanes.Rows.Clear();
                m_noADL = (CmbAdult.SelectedIndex == 0 ? 1 : int.Parse(CmbAdult.Text));
                m_noCHD = (CmbChild.SelectedIndex == 0 ? 0 : int.Parse(CmbChild.Text));
                m_noINF = (CmbInfant.SelectedIndex == 0 ? 0 : int.Parse(CmbInfant.Text));
                
                // NO OF SEATS TO BOOK
                int totalSeats = m_noADL + m_noCHD + m_noINF;

                // ECONOMY TICKET
                if (CmbClass.SelectedIndex == 0 || CmbClass.SelectedIndex == 1)
                {
                    CmbClass.SelectedIndex = 1;
                    // ONEWAY ROUTE
                    if (RbtnOneway.Checked)
                    {
                        // CHECK IF THE DATE IS VALID
                        if (DtFrom.Value.Date < DateTime.Now.Date)
                        {
                            MessageBox.Show("Invalid departure date, please check.", "date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Flight search = new Flight();
                            var flights = search.SearchEconomyFromSingleAirline(TxtFrom.Text, TxtTo.Text, DtFrom.Value.ToString("yyyy/MM/dd"), FrmLogin.m_client.ClientID, totalSeats);

                            if (flights.Count > 0)
                            {
                                int i = 0;
                                foreach (var item in flights)
                                {
                                    i += 1;

                                    // LOAD FLIGHT IMAGE
                                    MemoryStream ms = new MemoryStream(item.Logo);
                                    Image img = null;
                                    img = Image.FromStream(ms);

                                    // CALCULATE TICKET PRISES
                                    decimal total = (item.AdultEconomyPrice * m_noADL) + (item.ChildEconomyPrice * m_noCHD) + (item.InfantEconomyPrice * m_noINF);
                                    
                                    // ADD FLIGHT TO THE LIST
                                    DGClientAirplanes.Rows.Add(i, img, item.From, item.To, item.DepartureTime, item.ArrivalTime, item.EconomySeats, total, CmbClass.Text);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sorry, no flights are availaibe for the selected date.", "no flights", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
        }

        #region ONEWAY OR ROUNDTRIP
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

        #endregion

        #region AIRPORT SELECTION
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

        #region CURSOR ANIMATION
        private void DGClientAirplanes_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            string cel = DGClientAirplanes.Columns[e.ColumnIndex].Name;
            if (cel == "BOOK")
            {
                DGClientAirplanes.Cursor = Cursors.Hand;
            }
            else if (cel == "DETAILS")
            {
                DGClientAirplanes.Cursor = Cursors.Hand;
            }
        }

        private void DGClientAirplanes_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            string cel = DGClientAirplanes.Columns[e.ColumnIndex].Name;
            if (cel == "BOOK")
            {
                DGClientAirplanes.Cursor = Cursors.Default;
            }
            else if (cel == "DETAILS")
            {
                DGClientAirplanes.Cursor = Cursors.Default;
            }
        }
        #endregion
    }
}
