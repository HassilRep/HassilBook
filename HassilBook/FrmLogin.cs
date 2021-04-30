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
        public static int OfficeID = 1;
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
    }
}
