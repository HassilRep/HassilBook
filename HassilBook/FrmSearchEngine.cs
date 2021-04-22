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
    }
}
