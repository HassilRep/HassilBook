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
    public partial class FrmPriceManager : Form
    {
        public FrmPriceManager()
        {
            InitializeComponent();
            LoadPriceID();
            LoadPrices();
        }

        /// <summary>
        /// Loads client price ID
        /// </summary>
        private void LoadPriceID()
        {
            try
            {
                IDGenerator ID = new IDGenerator();
                ID.ClientPriceID(FrmLogin.m_client.ClientID);
                TxtPriceID.Text = ID.M_ClientPriceID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Load client saved prices
        /// </summary>
        private void LoadPrices()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                DGClientPriceID.Rows.Clear();
                int i = 1;
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tbl_ClientFlightPrices WHERE OfficeID = '"+FrmLogin.m_client.ClientID+"'";
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    DGClientPriceID.Rows.Add(i, dr["PriceID"].ToString(), dr["PriceType"].ToString(), dr["AdultEconomy"].ToString(), dr["AdultBusiness"].ToString(), dr["ChildEconomy"].ToString(), dr["ChildBusiness"].ToString(), dr["InfantEconomy"].ToString(), dr["InfantBusiness"].ToString());
                    i++;
                }
                dr.Close();
                con.ActiveConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            if(TxtPriceID.Text == string.Empty || TxtPriceType.Text == string.Empty || TxtAdultEconomy.Text == string.Empty || TxtAdultBusiness.Text == string.Empty || TxtChildEcomony.Text == string.Empty || TxtChildBusiness.Text == string.Empty || TxtInfantEconomy.Text == string.Empty || TxtInfantBusiness.Text == string.Empty)
            {
                MessageBox.Show("Price information is not completed.", "incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if(BtnAddEdit.Text == "ADD NEW PRICE")
                    {
                        DatabaseConnection con = new DatabaseConnection();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_ClientFlightPrices(OfficeID, PriceID, PriceType, AdultEconomy, AdultBusiness, ChildEconomy, ChildBusiness, InfantEconomy, InfantBusiness)VALUES('" + FrmLogin.m_client.ClientID + "','" + TxtPriceID.Text + "','"+TxtPriceType.Text+"','" + decimal.Parse(TxtAdultEconomy.Text) + "','" + decimal.Parse(TxtAdultBusiness.Text) + "','" + decimal.Parse(TxtChildEcomony.Text) + "','" + decimal.Parse(TxtChildBusiness.Text) + "','" + decimal.Parse(TxtInfantEconomy.Text) + "','" + decimal.Parse(TxtInfantBusiness.Text) + "')", con.ActiveConnection());
                        cmd.ExecuteReader();
                        MessageBox.Show("Congratulation, new price has been successfully created.", "created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPriceID();
                        LoadPrices();
                        con.ActiveConnection().Close();
                        TxtPriceType.Text = string.Empty;
                        TxtAdultEconomy.Text = string.Empty;
                        TxtAdultBusiness.Text = string.Empty;
                        TxtChildEcomony.Text = string.Empty;
                        TxtChildBusiness.Text = string.Empty;
                        TxtInfantEconomy.Text = string.Empty;
                        TxtInfantBusiness.Text = string.Empty;
                    }
                    else
                    {
                        DatabaseConnection con = new DatabaseConnection();
                        MySqlCommand cmd;
                        cmd = con.ActiveConnection().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE tbl_ClientFlightPrices SET PriceType = '"+TxtPriceType.Text+"', AdultEconomy = '"+decimal.Parse(TxtAdultEconomy.Text)+ "', AdultBusiness = '" + decimal.Parse(TxtAdultBusiness.Text) + "', ChildEconomy = '" + decimal.Parse(TxtChildEcomony.Text) + "', ChildBusiness = '" + decimal.Parse(TxtChildBusiness.Text) + "', InfantEconomy = '" + decimal.Parse(TxtInfantEconomy.Text) + "', InfantBusiness = '" + decimal.Parse(TxtInfantEconomy.Text) + "' WHERE PriceID = '"+TxtPriceID.Text+"' AND OfficeID = '"+FrmLogin.m_client.ClientID+"'";
                        cmd.ExecuteNonQuery();
                        LoadPriceID();
                        LoadPrices();
                        con.ActiveConnection().Close();
                        TxtPriceType.Text = string.Empty;
                        TxtAdultEconomy.Text = string.Empty;
                        TxtAdultBusiness.Text = string.Empty;
                        TxtChildEcomony.Text = string.Empty;
                        TxtChildBusiness.Text = string.Empty;
                        TxtInfantEconomy.Text = string.Empty;
                        TxtInfantBusiness.Text = string.Empty;
                        BtnAddEdit.Text = "ADD NEW PRICE";
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
