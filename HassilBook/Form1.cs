using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassilBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            UcFoundFlights[] uc = new UcFoundFlights[10];

            for (int i = 0; i < uc.Length; i++)
            {
                uc[i] = new UcFoundFlights();
                uc[i].LblStops.Text = $"{i} Stops";
                if (FlpFlightSearchResults.Controls.Count < 0)
                {
                    FlpFlightSearchResults.Controls.Clear();
                }
                else
                {
                    uc[i].Width = FlpFlightSearchResults.Width - 25;
                    FlpFlightSearchResults.Controls.Add(uc[i]);
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
                        cmd.CommandText = "SELECT * FROM tbl_Routes WHERE Airport like('%" + TxtFrom.Text + "%')";
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
            if (e.KeyCode == Keys.Enter)
            {
                TxtFrom.Text = lstDropDownFrom.SelectedItem.ToString();
                lstDropDownFrom.Visible = false;
            }
        }

        private void lstDropDown_MouseClick(object sender, MouseEventArgs e)
        {
            TxtFrom.Text = lstDropDownFrom.SelectedItem.ToString();
            lstDropDownFrom.Visible = false;
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
                        cmd.CommandText = "SELECT * FROM tbl_Routes WHERE Airport like('%" + TxtTo.Text + "%')";
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
                if (TxtFrom.Text != string.Empty)
                {
                    if (TxtFrom.Text == TxtTo.Text)
                    {
                        MessageBox.Show("Nop");
                    }
                    else
                    {
                        lstDropDownTo.Focus();
                        lstDropDownTo.SelectedIndex = 0;
                    }
                }
            }
        }

        private void lstDropDownTo_MouseClick(object sender, MouseEventArgs e)
        {
            TxtTo.Text = lstDropDownTo.SelectedItem.ToString();
            if (TxtFrom.Text == TxtTo.Text)
            {
                MessageBox.Show("Nop");
                TxtTo.Text = string.Empty;
                lstDropDownTo.Visible = false;
            }
            else
            {
                lstDropDownTo.Visible = false;
            }
        }

        private void lstDropDownTo_KeyDown(object sender, KeyEventArgs e)
        {
            TxtTo.Text = lstDropDownTo.SelectedItem.ToString();
            if (e.KeyCode == Keys.Enter)
            {
                if(TxtFrom.Text == TxtTo.Text)
                {
                    MessageBox.Show("Nop");
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
}
