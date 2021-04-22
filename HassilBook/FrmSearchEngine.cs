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
                NAdult.Location = new Point(NAdult.Location.X, NAdult.Location.Y - 37);
                NChild.Location = new Point(NChild.Location.X, NChild.Location.Y - 37);
                NInfant.Location = new Point(NInfant.Location.X, NInfant.Location.Y - 37);
                BtnSearchFlight.Location = new Point(BtnSearchFlight.Location.X, BtnSearchFlight.Location.Y - 37);
            }
            else
            {
                CmbClass.Location = new Point(CmbClass.Location.X, CmbClass.Location.Y + 37);
                NAdult.Location = new Point(NAdult.Location.X, NAdult.Location.Y + 37);
                NChild.Location = new Point(NChild.Location.X, NChild.Location.Y + 37);
                NInfant.Location = new Point(NInfant.Location.X, NInfant.Location.Y + 37);
                BtnSearchFlight.Location = new Point(BtnSearchFlight.Location.X, BtnSearchFlight.Location.Y + 37);
                DtTo.Visible = true;
            }
        }
    }
}
