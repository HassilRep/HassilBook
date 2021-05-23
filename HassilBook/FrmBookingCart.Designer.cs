
namespace HassilBook
{
    partial class FrmBookingCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookingCart));
            this.DGClientCoupon = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewImageColumn();
            this.DEL = new System.Windows.Forms.DataGridViewImageColumn();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.CmbManager = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtDepartment = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtDepartmentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblInvoiceAmount = new System.Windows.Forms.Label();
            this.BtnAllCoupons = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientCoupon)).BeginInit();
            this.bunifuGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGClientCoupon
            // 
            this.DGClientCoupon.AllowUserToAddRows = false;
            this.DGClientCoupon.AllowUserToResizeColumns = false;
            this.DGClientCoupon.AllowUserToResizeRows = false;
            this.DGClientCoupon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGClientCoupon.BackgroundColor = System.Drawing.Color.White;
            this.DGClientCoupon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGClientCoupon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(162)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGClientCoupon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGClientCoupon.ColumnHeadersHeight = 25;
            this.DGClientCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGClientCoupon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column9,
            this.Column1,
            this.Column6,
            this.Column7,
            this.EDIT,
            this.DEL});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGClientCoupon.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGClientCoupon.EnableHeadersVisualStyles = false;
            this.DGClientCoupon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DGClientCoupon.Location = new System.Drawing.Point(12, 351);
            this.DGClientCoupon.Margin = new System.Windows.Forms.Padding(0);
            this.DGClientCoupon.Name = "DGClientCoupon";
            this.DGClientCoupon.ReadOnly = true;
            this.DGClientCoupon.RowHeadersVisible = false;
            this.DGClientCoupon.RowHeadersWidth = 61;
            this.DGClientCoupon.RowTemplate.Height = 25;
            this.DGClientCoupon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGClientCoupon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGClientCoupon.Size = new System.Drawing.Size(945, 281);
            this.DGClientCoupon.TabIndex = 52;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "#";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 54;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "ID";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 61;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "COUPON CODE";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "MAX. USES";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 130;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "USED SO FAR";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 148;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "EXP. DATE";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "STATUS";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 101;
            // 
            // EDIT
            // 
            this.EDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EDIT.HeaderText = "EDIT";
            this.EDIT.Image = ((System.Drawing.Image)(resources.GetObject("EDIT.Image")));
            this.EDIT.MinimumWidth = 8;
            this.EDIT.Name = "EDIT";
            this.EDIT.ReadOnly = true;
            this.EDIT.Width = 49;
            // 
            // DEL
            // 
            this.DEL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DEL.HeaderText = "DEL";
            this.DEL.Image = ((System.Drawing.Image)(resources.GetObject("DEL.Image")));
            this.DEL.MinimumWidth = 8;
            this.DEL.Name = "DEL";
            this.DEL.ReadOnly = true;
            this.DEL.Width = 43;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.CmbManager);
            this.bunifuGroupBox1.Controls.Add(this.TxtDepartment);
            this.bunifuGroupBox1.Controls.Add(this.TxtDepartmentID);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(12, 75);
            this.bunifuGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGroupBox1.Size = new System.Drawing.Size(945, 211);
            this.bunifuGroupBox1.TabIndex = 53;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Personal information";
            // 
            // CmbManager
            // 
            this.CmbManager.BackColor = System.Drawing.Color.Transparent;
            this.CmbManager.BorderRadius = 5;
            this.CmbManager.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbManager.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbManager.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbManager.FocusedState.Parent = this.CmbManager;
            this.CmbManager.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbManager.ForeColor = System.Drawing.Color.Black;
            this.CmbManager.HoverState.Parent = this.CmbManager;
            this.CmbManager.ItemHeight = 23;
            this.CmbManager.Items.AddRange(new object[] {
            "- Manager -"});
            this.CmbManager.ItemsAppearance.Parent = this.CmbManager;
            this.CmbManager.Location = new System.Drawing.Point(9, 145);
            this.CmbManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbManager.Name = "CmbManager";
            this.CmbManager.ShadowDecoration.Parent = this.CmbManager;
            this.CmbManager.Size = new System.Drawing.Size(485, 29);
            this.CmbManager.StartIndex = 0;
            this.CmbManager.TabIndex = 40;
            this.CmbManager.Visible = false;
            // 
            // TxtDepartment
            // 
            this.TxtDepartment.BorderRadius = 5;
            this.TxtDepartment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDepartment.DefaultText = "";
            this.TxtDepartment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDepartment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDepartment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDepartment.DisabledState.Parent = this.TxtDepartment;
            this.TxtDepartment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDepartment.FocusedState.Parent = this.TxtDepartment;
            this.TxtDepartment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtDepartment.ForeColor = System.Drawing.Color.Black;
            this.TxtDepartment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDepartment.HoverState.Parent = this.TxtDepartment;
            this.TxtDepartment.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtDepartment.IconLeft")));
            this.TxtDepartment.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtDepartment.Location = new System.Drawing.Point(9, 92);
            this.TxtDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDepartment.Name = "TxtDepartment";
            this.TxtDepartment.PasswordChar = '\0';
            this.TxtDepartment.PlaceholderText = "Department";
            this.TxtDepartment.SelectedText = "";
            this.TxtDepartment.ShadowDecoration.Parent = this.TxtDepartment;
            this.TxtDepartment.Size = new System.Drawing.Size(487, 43);
            this.TxtDepartment.TabIndex = 39;
            this.TxtDepartment.Visible = false;
            // 
            // TxtDepartmentID
            // 
            this.TxtDepartmentID.BorderRadius = 5;
            this.TxtDepartmentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDepartmentID.DefaultText = "";
            this.TxtDepartmentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDepartmentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDepartmentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDepartmentID.DisabledState.Parent = this.TxtDepartmentID;
            this.TxtDepartmentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDepartmentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDepartmentID.FocusedState.Parent = this.TxtDepartmentID;
            this.TxtDepartmentID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtDepartmentID.ForeColor = System.Drawing.Color.Black;
            this.TxtDepartmentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDepartmentID.HoverState.Parent = this.TxtDepartmentID;
            this.TxtDepartmentID.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtDepartmentID.IconLeft")));
            this.TxtDepartmentID.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtDepartmentID.Location = new System.Drawing.Point(9, 42);
            this.TxtDepartmentID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDepartmentID.Name = "TxtDepartmentID";
            this.TxtDepartmentID.PasswordChar = '\0';
            this.TxtDepartmentID.PlaceholderText = "Department ID";
            this.TxtDepartmentID.SelectedText = "";
            this.TxtDepartmentID.ShadowDecoration.Parent = this.TxtDepartmentID;
            this.TxtDepartmentID.Size = new System.Drawing.Size(487, 43);
            this.TxtDepartmentID.TabIndex = 35;
            this.TxtDepartmentID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.LblInvoiceAmount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 72);
            this.panel1.TabIndex = 55;
            // 
            // LblInvoiceAmount
            // 
            this.LblInvoiceAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblInvoiceAmount.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvoiceAmount.Location = new System.Drawing.Point(687, 0);
            this.LblInvoiceAmount.Name = "LblInvoiceAmount";
            this.LblInvoiceAmount.Size = new System.Drawing.Size(282, 72);
            this.LblInvoiceAmount.TabIndex = 1;
            this.LblInvoiceAmount.Text = "0.00";
            this.LblInvoiceAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnAllCoupons
            // 
            this.BtnAllCoupons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAllCoupons.BorderRadius = 5;
            this.BtnAllCoupons.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnAllCoupons.CheckedState.Parent = this.BtnAllCoupons;
            this.BtnAllCoupons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAllCoupons.CustomImages.Parent = this.BtnAllCoupons;
            this.BtnAllCoupons.CustomizableEdges.BottomRight = false;
            this.BtnAllCoupons.CustomizableEdges.TopRight = false;
            this.BtnAllCoupons.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnAllCoupons.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAllCoupons.ForeColor = System.Drawing.Color.White;
            this.BtnAllCoupons.HoverState.Parent = this.BtnAllCoupons;
            this.BtnAllCoupons.Location = new System.Drawing.Point(669, 303);
            this.BtnAllCoupons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAllCoupons.Name = "BtnAllCoupons";
            this.BtnAllCoupons.ShadowDecoration.Parent = this.BtnAllCoupons;
            this.BtnAllCoupons.Size = new System.Drawing.Size(288, 43);
            this.BtnAllCoupons.TabIndex = 56;
            this.BtnAllCoupons.Text = "ADD TO CART";
            // 
            // FrmBookingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 641);
            this.Controls.Add(this.BtnAllCoupons);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.DGClientCoupon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBookingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your booking cart";
            ((System.ComponentModel.ISupportInitialize)(this.DGClientCoupon)).EndInit();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGClientCoupon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn EDIT;
        private System.Windows.Forms.DataGridViewImageColumn DEL;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        public Guna.UI2.WinForms.Guna2ComboBox CmbManager;
        public Guna.UI2.WinForms.Guna2TextBox TxtDepartment;
        public Guna.UI2.WinForms.Guna2TextBox TxtDepartmentID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblInvoiceAmount;
        private Guna.UI2.WinForms.Guna2Button BtnAllCoupons;
    }
}