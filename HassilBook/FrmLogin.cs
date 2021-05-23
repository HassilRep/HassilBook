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
    public partial class FrmLogin : Form
    {
        public static ClientModel m_client;
        public static EmployeeModel m_employee;
        public static AgencyModel m_agency;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnAirlineLogin_Click(object sender, EventArgs e)
        {
            LoginTabForm.SelectTab("AirlineLoginPage");
        }

        private void BtnAgencyLogin_Click(object sender, EventArgs e)
        {
            LoginTabForm.SelectTab("AgencyLoginPage");
        }

        private void BtnAirLogin_Click(object sender, EventArgs e)
        {
            AirlineAccessPoint accessPoint = new AirlineAccessPoint();
            var result = accessPoint.Login(TxtOfficeID.Text, TxtAirUsername.Text, TxtAirPassword.Text);
            if (result.Count > 0)
            {
                if (result[1].ToString() == "Admin")
                {
                    // profile information
                    m_client = accessPoint.ClientProfile(TxtOfficeID.Text);
                    m_employee = accessPoint.ClientEmployeeProfile(TxtOfficeID.Text, TxtAirUsername.Text);

                    // admin control panel
                    FrmAirlinesControlPanel F = new FrmAirlinesControlPanel();
                    this.Hide();
                    F.Show();
                }
                else if (result[1].ToString() == "Financial")
                {
                    MessageBox.Show("Financial coming soon");
                }
                else if (result[1].ToString() == "Consulting")
                {
                    MessageBox.Show("Consulting coming soon");
                }
                else
                {
                    MessageBox.Show("Counter coming soon");
                }
            }
        }

        private void BtnLoginAgency_Click(object sender, EventArgs e)
        {
            AgencyAccessPoint accessPoint = new AgencyAccessPoint();
            AirlineAccessPoint access = new AirlineAccessPoint();
            var agencies = accessPoint.Login(TxtAgencyID.Text, TxtAgencyUsername.Text, TxtAgencyPassword.Text);

            if(agencies.Count == 1)
            {
                foreach (var agency in agencies)
                {
                    // current agency
                    m_agency = agency;
                    if (agency.Status != "Active")
                    {
                        MessageBox.Show("This user is no more active.");
                    }
                    else
                    {
                        FrmAgencyDashboard F = new FrmAgencyDashboard();
                        // profile information
                        m_client = access.ClientProfile(TxtOfficeID.Text);
                        this.Hide();
                        F.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("You are using this login information more than 1 airlines.");
            }
        }
    }
}
