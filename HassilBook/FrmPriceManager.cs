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
                DGClientPrice.Rows.Clear();
                int i = 1;
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tbl_ClientFlightPrices WHERE OfficeID = '"+FrmLogin.m_client.ClientID+"'";
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    DGClientPrice.Rows.Add(i, dr["PriceID"].ToString(), dr["PriceType"].ToString(), dr["AdultEconomy"].ToString(), dr["AdultBusiness"].ToString(), dr["ChildEconomy"].ToString(), dr["ChildBusiness"].ToString(), dr["InfantEconomy"].ToString(), dr["InfantBusiness"].ToString());
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

        /// <summary>
        /// search client saved prices with given keyword
        /// </summary>
        private void SearchPrices()
        {
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                DGClientPrice.Rows.Clear();
                int i = 1;
                MySqlCommand cmd;
                cmd = con.ActiveConnection().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tbl_ClientFlightPrices WHERE PriceID LIKE '%"+TxtSearchWith.Text+"%' AND OfficeID = '" + FrmLogin.m_client.ClientID + "' OR PriceType LIKE '%" + TxtSearchWith.Text + "%' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DGClientPrice.Rows.Add(i, dr["PriceID"].ToString(), dr["PriceType"].ToString(), dr["AdultEconomy"].ToString(), dr["AdultBusiness"].ToString(), dr["ChildEconomy"].ToString(), dr["ChildBusiness"].ToString(), dr["InfantEconomy"].ToString(), dr["InfantBusiness"].ToString());
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

        private void DGClientPriceID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cel = DGClientPrice.Columns[e.ColumnIndex].Name;
            try
            {
                DatabaseConnection con = new DatabaseConnection();
                if(cel =="EDIT")
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_ClientFlightPrices WHERE PriceID = '" + DGClientPrice[1, e.RowIndex].Value.ToString() + "' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'", con.ActiveConnection());
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        TxtPriceID.Text = dr["PriceID"].ToString();
                        TxtPriceType.Text = dr["PriceType"].ToString();
                        TxtAdultEconomy.Text = dr["AdultEconomy"].ToString();
                        TxtAdultBusiness.Text = dr["AdultBusiness"].ToString();
                        TxtChildEcomony.Text = dr["ChildEconomy"].ToString();
                        TxtChildBusiness.Text = dr["ChildBusiness"].ToString();
                        TxtInfantEconomy.Text = dr["InfantEconomy"].ToString();
                        TxtInfantBusiness.Text = dr["InfantBusiness"].ToString();
                        BtnAddEdit.Text = "UPDATE PRICE";
                    }
                    dr.Close();
                    con.ActiveConnection().Close();

                }
                else if (cel == "DEL")
                {
                    if(MessageBox.Show($"Do you want to delete this price tag '{DGClientPrice[1, e.RowIndex].Value.ToString()}'?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM tbl_ClientFlightPrices WHERE PriceID = '" + DGClientPrice[1, e.RowIndex].Value.ToString() + "' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'", con.ActiveConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Congratulation, price tag has been successfully deleted", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtSearchWith_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchPrices();
            }
        }
    }
}
