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
    public partial class FrmBookingCart : Form
    {
        private FlightModel m_flight = new FlightModel();
        private string m_booking = null;
        public FrmBookingCart(FlightModel fmodel, string Refrence)
        {
            InitializeComponent();
            m_flight = fmodel;
            m_booking = Refrence;
            TxtBookingRef.Text = m_booking;
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            CouponGenerator coupon = new CouponGenerator();
            var test = coupon.GenerateEticketNo();
            
            if(TxtBookingRef.Text == string.Empty || TxtPassengername.Text == string.Empty || CmbGender.SelectedIndex == 0 || CmbPaymentType.SelectedIndex == 0)
            {
                MessageBox.Show("fill");
            }
            else if(DtIssuedDate.Value.Date < DateTime.Now.Date || DtIssuedDate.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("date");
            }
            else
            {
                DatabaseConnection con = new DatabaseConnection();
                if(BtnAddToCart.Text == "")
                {
                    //using(MySqlCommand cmd = new MySqlCommand(@"INSERT INTO tbl_ClientTickets(OfficeID, AgencyID, BookingRef, IssuedDate, Passenger, Gender, DepartureDateTime, ArrivalDateTime, ReturnDepDateTime, ReturnArrDateTime, Duration, Origin, Destination, Transit, Class, Status, Price, Airplane, Model, FlightNo, User, Comment) VALUES 
                    //                                                                        ('"+FrmLogin.m_client.ClientID+"','"++"''"+TxtBookingRef.Text+"''"+DtIssuedDate.Value.ToString("yyyy/MM/dd")+"''"+TxtPassengername.Text+"''"+CmbGender.Text+"''"+m_flight.d+"''"++"''"++"''"++"''"++"''"++"''"++"''"++"''"++"''"++"''"++"''"++"''"++"''"++"''"++"''"++"')", con.ActiveConnection()))
                    //{

                    //}
                }
                else
                {

                }
            }
        }
    }
}
