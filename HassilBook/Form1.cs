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
    }
}
