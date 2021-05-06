using Guna.UI2.WinForms;
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
    public partial class FrmCoupons : Form
    {
        public FrmCoupons()
        {
            InitializeComponent();
            LoadCouponID();
            BtnAllCoupons.PerformClick();
            DtExpirationDate.Text = DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// Load client coupon ID
        /// </summary>
        private void LoadCouponID()
        {
            IDGenerator ID = new IDGenerator();
            ID.ClientCouponID(FrmLogin.m_client.ClientID);
            TxtCouponID.Text = ID.M_ClientCouponID;
        }

        /// <summary>
        /// Load saved coupons from the database
        /// </summary>
        private void LoadCoupons(Guna2Button btn)
        {
            try
            {
                if(btn.Text == "ACTIVE" || btn.Text == "INACTIVE")
                {
                    DGClientCoupon.Rows.Clear();
                    int i = 1;
                    DatabaseConnection con = new DatabaseConnection();
                    MySqlCommand cmd;
                    cmd = con.ActiveConnection().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM tbl_ClientCoupons WHERE Status = '"+btn.Text+"' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DGClientCoupon.Rows.Add(i, dr["CouponID"].ToString(), dr["CouponCode"].ToString(), dr["MaxUses"].ToString(), dr["Used"].ToString(), Convert.ToDateTime(dr["ExpiryDate"]).ToString("ddd, dd MMMM yyyy"), dr["Status"].ToString());
                        i++;
                    }
                    dr.Close();
                    con.ActiveConnection().Close();
                }
                else
                {
                    DGClientCoupon.Rows.Clear();
                    int i = 1;
                    DatabaseConnection con = new DatabaseConnection();
                    MySqlCommand cmd;
                    cmd = con.ActiveConnection().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM tbl_ClientCoupons WHERE OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DGClientCoupon.Rows.Add(i, dr["CouponID"].ToString(), dr["CouponCode"].ToString(), dr["MaxUses"].ToString(), dr["Used"].ToString(), Convert.ToDateTime(dr["ExpiryDate"]).ToString("ddd, dd MMMM yyyy"), dr["Status"].ToString());
                        i++;
                    }
                    dr.Close();
                    con.ActiveConnection().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCouponGenerator_Click(object sender, EventArgs e)
        {
            CouponGenerator coupon = new CouponGenerator();
            TxtCouponCode.Text = coupon.GenerateCoupon();
        }

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            if(TxtCouponID.Text == string.Empty || TxtCouponCode.Text == string.Empty || TxtRate.Text == string.Empty || TxtMaxUses.Text == string.Empty || CmbStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Sorry, coupon information is not complete","incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DatabaseConnection con = new DatabaseConnection();

                    if(BtnAddEdit.Text == "ADD NEW COUPON")
                    {
                        int used = 0;
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_ClientCoupons(OfficeID, CouponID, CouponCode, ExpiryDate, Rate, MaxUses,Used, Status) VALUES('"+FrmLogin.m_client.ClientID+"','"+TxtCouponID.Text+"','"+TxtCouponCode.Text+"','"+DtExpirationDate.Value.ToString("yyyy/MM/dd")+"','"+decimal.Parse(TxtRate.Text)+"','"+TxtMaxUses.Text+"','"+used+"','"+CmbStatus.Text+"')", con.ActiveConnection());
                        cmd.ExecuteReader();
                        MessageBox.Show($"Congratulation, a new coupon {TxtCouponID.Text} has been successfully created.", "created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCouponID();
                        BtnAllCoupons.PerformClick();
                        con.ActiveConnection().Close();
                        TxtCouponCode.Text = string.Empty;
                        TxtRate.Text = string.Empty;
                        CmbStatus.SelectedIndex = 0;
                        TxtMaxUses.Text = string.Empty;
                        DtExpirationDate.Text = DateTime.Now.ToShortDateString();
                    }
                    else
                    {
                        MySqlCommand cmd;
                        cmd = con.ActiveConnection().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE tbl_ClientCoupons SET CouponCode = '"+TxtCouponCode.Text+"', ExpiryDate = '"+DtExpirationDate.Value.ToString("yyyy/MM/dd")+"', Rate = '"+decimal.Parse(TxtRate.Text)+"', MaxUses = '"+TxtMaxUses.Text+"', Status = '"+CmbStatus.Text+ "' WHERE CouponID = '"+TxtCouponID.Text+"' AND OfficeID = '"+FrmLogin.m_client.ClientID+"' ";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Congratulation, coupon {TxtCouponID.Text} has been successfully updated.","updated",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCouponID();
                        BtnAllCoupons.PerformClick();
                        con.ActiveConnection().Close();
                        TxtCouponCode.Text = string.Empty;
                        TxtRate.Text = string.Empty;
                        CmbStatus.SelectedIndex = 0;
                        TxtMaxUses.Text = string.Empty;
                        DtExpirationDate.Text = DateTime.Now.ToShortDateString();
                        BtnAddEdit.Text = "ADD NEW COUPON";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DGClientCoupon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cel = DGClientCoupon.Columns[e.ColumnIndex].Name;

            try
            {
                DatabaseConnection con = new DatabaseConnection();

                if(cel == "EDIT")
                {
                    MySqlCommand cmd;
                    cmd = con.ActiveConnection().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM tbl_ClientCoupons WHERE CouponID = '"+DGClientCoupon[1, e.RowIndex].Value.ToString()+"' AND OfficeID = '"+FrmLogin.m_client.ClientID+"'";
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        TxtCouponID.Text = dr["CouponID"].ToString();
                        TxtCouponCode.Text = dr["CouponCode"].ToString();
                        DtExpirationDate.Text = dr["ExpiryDate"].ToString();
                        TxtRate.Text = dr["Rate"].ToString();
                        TxtMaxUses.Text = dr["MaxUses"].ToString();
                        CmbStatus.Text = dr["Status"].ToString();

                        BtnAddEdit.Text = "UPDATE COUPON";
                    }
                    dr.Close();
                    con.ActiveConnection().Close();
                }
                else if(cel == "DEL")
                {
                    if(MessageBox.Show($"Do you want to delete this coupon '{DGClientCoupon[1, e.RowIndex].Value.ToString()}'?","delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MySqlCommand cmd;
                        cmd = con.ActiveConnection().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM tbl_ClientCoupons WHERE CouponID = '" + DGClientCoupon[1, e.RowIndex].Value.ToString() + "' AND OfficeID = '" + FrmLogin.m_client.ClientID + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Congratulation, coupon {TxtCouponID.Text} has been successfully deleted.", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCouponID();
                        BtnAllCoupons.PerformClick();
                        con.ActiveConnection().Close();
                        TxtCouponCode.Text = string.Empty;
                        TxtRate.Text = string.Empty;
                        CmbStatus.SelectedIndex = 0;
                        TxtMaxUses.Text = string.Empty;
                        DtExpirationDate.Text = DateTime.Now.ToShortDateString();
                        BtnAddEdit.Text = "ADD NEW COUPON";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAllCoupons_Click(object sender, EventArgs e)
        {
            LoadCoupons(BtnAllCoupons);
        }

        private void BtnActiveCoupons_Click(object sender, EventArgs e)
        {
            LoadCoupons(BtnActiveCoupons);
        }

        private void BtnInactiveCoupons_Click(object sender, EventArgs e)
        {
            LoadCoupons(BtnInactiveCoupons);
        }
    }
}
