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
    public partial class FrmAddEditAirplane : Form
    {
        FrmClientAirplanes F;
        public FrmAddEditAirplane(FrmClientAirplanes f)
        {
            InitializeComponent();
            F = f;
            DtRegistrationDate.Text = DateTime.Now.ToString();
        }

        private void ClearComponents()
        {
            DtRegistrationDate.Text = DateTime.Now.ToString();
            TxtRegistrationNumber.Text = string.Empty;
            TxtModel.Text = string.Empty;
            TxtManufacturer.Text = string.Empty;
            TxtSeats.Text = string.Empty;
            CmbCategory.SelectedIndex = 0;
            CmbStatus.SelectedIndex = 0;
            BtnAddEdit.Text = "ADD NEW AIRPLANE";
        }

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            if(TxtRegistrationNumber.Text == string.Empty || TxtManufacturer.Text == string.Empty || TxtModel.Text == string.Empty || TxtSeats.Text == string.Empty || CmbCategory.SelectedIndex == 0 || CmbStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Sorry, airplane information is incomplete.", "incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if(BtnAddEdit.Text == "ADD NEW AIRPLANE")
                    {
                        Airplane air = new Airplane();
                        AirplaneModel model = new AirplaneModel()
                        {
                            OfficeID = FrmLogin.m_client.ClientID,
                            RegistrationNumber = TxtRegistrationNumber.Text,
                            RegisteredDate = DtRegistrationDate.Value,
                            Manufacturer = TxtManufacturer.Text,
                            Model = TxtModel.Text,
                            Seats = int.Parse(TxtSeats.Text),
                            Category = CmbCategory.Text,
                            Status = CmbStatus.Text,
                        };
                        air.Add(model);
                        F.LoadAirplanes();
                        ClearComponents();
                    }
                    else
                    {
                        Airplane air = new Airplane();
                        AirplaneModel model = new AirplaneModel()
                        {
                            OfficeID = FrmLogin.m_client.ClientID,
                            RegistrationNumber = TxtRegistrationNumber.Text,
                            RegisteredDate = DtRegistrationDate.Value,
                            Manufacturer = TxtManufacturer.Text,
                            Model = TxtModel.Text,
                            Seats = int.Parse(TxtSeats.Text),
                            Category = CmbCategory.Text,
                            Status = CmbStatus.Text,
                        };
                        air.Edit(model, F.m_airplaneID);
                        F.LoadAirplanes();
                        ClearComponents();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
