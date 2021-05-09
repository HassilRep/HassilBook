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
    public partial class UcOnewayDirectFlights : UserControl
    {
        private List<Tuple<FlightModel, int>> m_flightmodel;
        private string m_flightClass;
        private int m_adult;
        private int m_child;
        private int m_infant;

        private int m_panelHeight;
        private bool m_toggleStatus;
        public UcOnewayDirectFlights()
        {
            InitializeComponent();
            // animation
            m_toggleStatus = false;
            m_panelHeight = this.Height;
        }

        public void Book(List<Tuple<FlightModel, int>> flightWithIndex, string Flightclass, int adl, int chd, int inf)
        {
            m_flightmodel = flightWithIndex;
            m_flightClass = Flightclass;
            m_adult = adl;
            m_child = chd;
            m_infant = inf;
        }
        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            if (m_toggleStatus)
            {
                this.Height -= 10;
                if (this.Height <= this.MinimumSize.Height)
                {
                    this.tmrAnimation.Stop();
                    this.m_toggleStatus = false;
                    this.Refresh();
                }
            }
            else
            {
                this.Height += 10;
                if (this.Height >= this.MaximumSize.Height)
                {
                    this.tmrAnimation.Stop();
                    this.m_toggleStatus = true;
                    this.Refresh();
                }
            }
        }

        private void UcDirectFlights_Click(object sender, EventArgs e)
        {
            tmrAnimation.Start();
        }

        private void BtnSelectFlight_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Tag.ToString());
        }
    }
}
