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
    public partial class FrmCompany : Form
    {
        public FrmCompany()
        {
            InitializeComponent();
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            CompanyPage.SelectTab("Profile");
        }

        private void BtnEmail_Click(object sender, EventArgs e)
        {
            CompanyPage.SelectTab("Email");
        }

        private void BtnTexts_Click(object sender, EventArgs e)
        {
            CompanyPage.SelectTab("Texts");
        }
    }
}
