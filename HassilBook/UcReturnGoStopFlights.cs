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
    public partial class UcReturnGoStopFlights : UserControl
    {
        private int m_panelHeight;
        private bool m_toggleStatus;
        public UcReturnGoStopFlights()
        {
            InitializeComponent();
            // animation
            m_toggleStatus = false;
            m_panelHeight = this.Height;
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

        private void UcReturnGoStopFlights_Click(object sender, EventArgs e)
        {
            tmrAnimation.Start();
        }
    }
}
