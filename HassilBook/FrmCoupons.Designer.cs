
namespace HassilBook
{
    partial class FrmCoupons
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoupons));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DtExpirationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnAddEdit = new Guna.UI2.WinForms.Guna2Button();
            this.DGClientCoupon = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnInactiveCoupons = new Guna.UI2.WinForms.Guna2Button();
            this.BtnActiveCoupons = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAllCoupons = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnCouponGenerator = new Guna.UI2.WinForms.Guna2Button();
            this.TxtMaxUses = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtCouponCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtCouponID = new Guna.UI2.WinForms.Guna2TextBox();
            this.EDIT = new System.Windows.Forms.DataGridViewImageColumn();
            this.DEL = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientCoupon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.guna2Panel1.Controls.Add(this.BtnCouponGenerator);
            this.guna2Panel1.Controls.Add(this.TxtMaxUses);
            this.guna2Panel1.Controls.Add(this.CmbStatus);
            this.guna2Panel1.Controls.Add(this.TxtRate);
            this.guna2Panel1.Controls.Add(this.TxtCouponCode);
            this.guna2Panel1.Controls.Add(this.DtExpirationDate);
            this.guna2Panel1.Controls.Add(this.BtnAddEdit);
            this.guna2Panel1.Controls.Add(this.TxtCouponID);
            this.guna2Panel1.Location = new System.Drawing.Point(14, 57);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(400, 835);
            this.guna2Panel1.TabIndex = 52;
            // 
            // CmbStatus
            // 
            this.CmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.CmbStatus.BorderRadius = 5;
            this.CmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbStatus.FocusedState.Parent = this.CmbStatus;
            this.CmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbStatus.ForeColor = System.Drawing.Color.Black;
            this.CmbStatus.HoverState.Parent = this.CmbStatus;
            this.CmbStatus.ItemHeight = 22;
            this.CmbStatus.Items.AddRange(new object[] {
            "- Status -",
            "Active",
            "Inactive"});
            this.CmbStatus.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbStatus.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbStatus.ItemsAppearance.Parent = this.CmbStatus;
            this.CmbStatus.Location = new System.Drawing.Point(8, 263);
            this.CmbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.ShadowDecoration.Parent = this.CmbStatus;
            this.CmbStatus.Size = new System.Drawing.Size(382, 28);
            this.CmbStatus.StartIndex = 0;
            this.CmbStatus.TabIndex = 24;
            // 
            // DtExpirationDate
            // 
            this.DtExpirationDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtExpirationDate.BorderRadius = 5;
            this.DtExpirationDate.BorderThickness = 1;
            this.DtExpirationDate.CheckedState.Parent = this.DtExpirationDate;
            this.DtExpirationDate.FillColor = System.Drawing.Color.White;
            this.DtExpirationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtExpirationDate.HoverState.Parent = this.DtExpirationDate;
            this.DtExpirationDate.Location = new System.Drawing.Point(8, 111);
            this.DtExpirationDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtExpirationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtExpirationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtExpirationDate.Name = "DtExpirationDate";
            this.DtExpirationDate.ShadowDecoration.Parent = this.DtExpirationDate;
            this.DtExpirationDate.Size = new System.Drawing.Size(384, 43);
            this.DtExpirationDate.TabIndex = 21;
            this.DtExpirationDate.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
            // 
            // BtnAddEdit
            // 
            this.BtnAddEdit.BorderRadius = 5;
            this.BtnAddEdit.CheckedState.Parent = this.BtnAddEdit;
            this.BtnAddEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddEdit.CustomImages.Parent = this.BtnAddEdit;
            this.BtnAddEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(123)))), ((int)(((byte)(253)))));
            this.BtnAddEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAddEdit.ForeColor = System.Drawing.Color.White;
            this.BtnAddEdit.HoverState.Parent = this.BtnAddEdit;
            this.BtnAddEdit.Location = new System.Drawing.Point(8, 314);
            this.BtnAddEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddEdit.Name = "BtnAddEdit";
            this.BtnAddEdit.ShadowDecoration.Parent = this.BtnAddEdit;
            this.BtnAddEdit.Size = new System.Drawing.Size(384, 46);
            this.BtnAddEdit.TabIndex = 35;
            this.BtnAddEdit.Text = "ADD NEW COUPON";
            this.BtnAddEdit.Click += new System.EventHandler(this.BtnAddEdit_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(162)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGClientCoupon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGClientCoupon.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGClientCoupon.EnableHeadersVisualStyles = false;
            this.DGClientCoupon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DGClientCoupon.Location = new System.Drawing.Point(418, 57);
            this.DGClientCoupon.Margin = new System.Windows.Forms.Padding(0);
            this.DGClientCoupon.Name = "DGClientCoupon";
            this.DGClientCoupon.ReadOnly = true;
            this.DGClientCoupon.RowHeadersVisible = false;
            this.DGClientCoupon.RowHeadersWidth = 61;
            this.DGClientCoupon.RowTemplate.Height = 25;
            this.DGClientCoupon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGClientCoupon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGClientCoupon.Size = new System.Drawing.Size(768, 835);
            this.DGClientCoupon.TabIndex = 51;
            this.DGClientCoupon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGClientCoupon_CellContentClick);
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
            // BtnInactiveCoupons
            // 
            this.BtnInactiveCoupons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInactiveCoupons.BorderRadius = 5;
            this.BtnInactiveCoupons.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnInactiveCoupons.CheckedState.Parent = this.BtnInactiveCoupons;
            this.BtnInactiveCoupons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInactiveCoupons.CustomImages.Parent = this.BtnInactiveCoupons;
            this.BtnInactiveCoupons.CustomizableEdges.BottomLeft = false;
            this.BtnInactiveCoupons.CustomizableEdges.TopLeft = false;
            this.BtnInactiveCoupons.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnInactiveCoupons.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnInactiveCoupons.ForeColor = System.Drawing.Color.White;
            this.BtnInactiveCoupons.HoverState.Parent = this.BtnInactiveCoupons;
            this.BtnInactiveCoupons.Location = new System.Drawing.Point(1011, 5);
            this.BtnInactiveCoupons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInactiveCoupons.Name = "BtnInactiveCoupons";
            this.BtnInactiveCoupons.ShadowDecoration.Parent = this.BtnInactiveCoupons;
            this.BtnInactiveCoupons.Size = new System.Drawing.Size(176, 43);
            this.BtnInactiveCoupons.TabIndex = 54;
            this.BtnInactiveCoupons.Text = "INACTIVE";
            this.BtnInactiveCoupons.Click += new System.EventHandler(this.BtnInactiveCoupons_Click);
            // 
            // BtnActiveCoupons
            // 
            this.BtnActiveCoupons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActiveCoupons.BorderRadius = 5;
            this.BtnActiveCoupons.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnActiveCoupons.CheckedState.Parent = this.BtnActiveCoupons;
            this.BtnActiveCoupons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActiveCoupons.CustomImages.Parent = this.BtnActiveCoupons;
            this.BtnActiveCoupons.CustomizableEdges.BottomLeft = false;
            this.BtnActiveCoupons.CustomizableEdges.BottomRight = false;
            this.BtnActiveCoupons.CustomizableEdges.TopLeft = false;
            this.BtnActiveCoupons.CustomizableEdges.TopRight = false;
            this.BtnActiveCoupons.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnActiveCoupons.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnActiveCoupons.ForeColor = System.Drawing.Color.White;
            this.BtnActiveCoupons.HoverState.Parent = this.BtnActiveCoupons;
            this.BtnActiveCoupons.Location = new System.Drawing.Point(828, 5);
            this.BtnActiveCoupons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnActiveCoupons.Name = "BtnActiveCoupons";
            this.BtnActiveCoupons.ShadowDecoration.Parent = this.BtnActiveCoupons;
            this.BtnActiveCoupons.Size = new System.Drawing.Size(184, 43);
            this.BtnActiveCoupons.TabIndex = 53;
            this.BtnActiveCoupons.Text = "ACTIVE";
            this.BtnActiveCoupons.Click += new System.EventHandler(this.BtnActiveCoupons_Click);
            // 
            // BtnAllCoupons
            // 
            this.BtnAllCoupons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAllCoupons.BorderRadius = 5;
            this.BtnAllCoupons.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnAllCoupons.Checked = true;
            this.BtnAllCoupons.CheckedState.Parent = this.BtnAllCoupons;
            this.BtnAllCoupons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAllCoupons.CustomImages.Parent = this.BtnAllCoupons;
            this.BtnAllCoupons.CustomizableEdges.BottomRight = false;
            this.BtnAllCoupons.CustomizableEdges.TopRight = false;
            this.BtnAllCoupons.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnAllCoupons.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAllCoupons.ForeColor = System.Drawing.Color.White;
            this.BtnAllCoupons.HoverState.Parent = this.BtnAllCoupons;
            this.BtnAllCoupons.Location = new System.Drawing.Point(647, 5);
            this.BtnAllCoupons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAllCoupons.Name = "BtnAllCoupons";
            this.BtnAllCoupons.ShadowDecoration.Parent = this.BtnAllCoupons;
            this.BtnAllCoupons.Size = new System.Drawing.Size(184, 43);
            this.BtnAllCoupons.TabIndex = 55;
            this.BtnAllCoupons.Text = "ALL COUPONS";
            this.BtnAllCoupons.Click += new System.EventHandler(this.BtnAllCoupons_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "EDIT";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 49;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "DEL";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 43;
            // 
            // BtnCouponGenerator
            // 
            this.BtnCouponGenerator.BorderRadius = 5;
            this.BtnCouponGenerator.CheckedState.Parent = this.BtnCouponGenerator;
            this.BtnCouponGenerator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCouponGenerator.CustomImages.Parent = this.BtnCouponGenerator;
            this.BtnCouponGenerator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(123)))), ((int)(((byte)(253)))));
            this.BtnCouponGenerator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCouponGenerator.ForeColor = System.Drawing.Color.White;
            this.BtnCouponGenerator.HoverState.Parent = this.BtnCouponGenerator;
            this.BtnCouponGenerator.Image = ((System.Drawing.Image)(resources.GetObject("BtnCouponGenerator.Image")));
            this.BtnCouponGenerator.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnCouponGenerator.Location = new System.Drawing.Point(347, 60);
            this.BtnCouponGenerator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCouponGenerator.Name = "BtnCouponGenerator";
            this.BtnCouponGenerator.ShadowDecoration.Parent = this.BtnCouponGenerator;
            this.BtnCouponGenerator.Size = new System.Drawing.Size(42, 42);
            this.BtnCouponGenerator.TabIndex = 36;
            this.BtnCouponGenerator.Click += new System.EventHandler(this.BtnCouponGenerator_Click);
            // 
            // TxtMaxUses
            // 
            this.TxtMaxUses.BorderRadius = 5;
            this.TxtMaxUses.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMaxUses.DefaultText = "";
            this.TxtMaxUses.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtMaxUses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtMaxUses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMaxUses.DisabledState.Parent = this.TxtMaxUses;
            this.TxtMaxUses.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMaxUses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMaxUses.FocusedState.Parent = this.TxtMaxUses;
            this.TxtMaxUses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtMaxUses.ForeColor = System.Drawing.Color.Black;
            this.TxtMaxUses.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMaxUses.HoverState.Parent = this.TxtMaxUses;
            this.TxtMaxUses.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtMaxUses.IconLeft")));
            this.TxtMaxUses.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtMaxUses.Location = new System.Drawing.Point(8, 212);
            this.TxtMaxUses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMaxUses.Name = "TxtMaxUses";
            this.TxtMaxUses.PasswordChar = '\0';
            this.TxtMaxUses.PlaceholderText = "Maximal uses";
            this.TxtMaxUses.SelectedText = "";
            this.TxtMaxUses.ShadowDecoration.Parent = this.TxtMaxUses;
            this.TxtMaxUses.Size = new System.Drawing.Size(384, 43);
            this.TxtMaxUses.TabIndex = 25;
            // 
            // TxtRate
            // 
            this.TxtRate.BorderRadius = 5;
            this.TxtRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRate.DefaultText = "";
            this.TxtRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRate.DisabledState.Parent = this.TxtRate;
            this.TxtRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRate.FocusedState.Parent = this.TxtRate;
            this.TxtRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtRate.ForeColor = System.Drawing.Color.Black;
            this.TxtRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRate.HoverState.Parent = this.TxtRate;
            this.TxtRate.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtRate.IconLeft")));
            this.TxtRate.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtRate.Location = new System.Drawing.Point(8, 162);
            this.TxtRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRate.Name = "TxtRate";
            this.TxtRate.PasswordChar = '\0';
            this.TxtRate.PlaceholderText = "Rate in %";
            this.TxtRate.SelectedText = "";
            this.TxtRate.ShadowDecoration.Parent = this.TxtRate;
            this.TxtRate.Size = new System.Drawing.Size(384, 43);
            this.TxtRate.TabIndex = 23;
            // 
            // TxtCouponCode
            // 
            this.TxtCouponCode.BorderRadius = 5;
            this.TxtCouponCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCouponCode.DefaultText = "";
            this.TxtCouponCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCouponCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCouponCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCouponCode.DisabledState.Parent = this.TxtCouponCode;
            this.TxtCouponCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCouponCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCouponCode.FocusedState.Parent = this.TxtCouponCode;
            this.TxtCouponCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtCouponCode.ForeColor = System.Drawing.Color.Black;
            this.TxtCouponCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCouponCode.HoverState.Parent = this.TxtCouponCode;
            this.TxtCouponCode.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtCouponCode.IconLeft")));
            this.TxtCouponCode.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtCouponCode.Location = new System.Drawing.Point(8, 60);
            this.TxtCouponCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCouponCode.Name = "TxtCouponCode";
            this.TxtCouponCode.PasswordChar = '\0';
            this.TxtCouponCode.PlaceholderText = "Coupon code";
            this.TxtCouponCode.SelectedText = "";
            this.TxtCouponCode.ShadowDecoration.Parent = this.TxtCouponCode;
            this.TxtCouponCode.Size = new System.Drawing.Size(332, 43);
            this.TxtCouponCode.TabIndex = 22;
            // 
            // TxtCouponID
            // 
            this.TxtCouponID.BorderRadius = 5;
            this.TxtCouponID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCouponID.DefaultText = "";
            this.TxtCouponID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCouponID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCouponID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCouponID.DisabledState.Parent = this.TxtCouponID;
            this.TxtCouponID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCouponID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCouponID.FocusedState.Parent = this.TxtCouponID;
            this.TxtCouponID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtCouponID.ForeColor = System.Drawing.Color.Black;
            this.TxtCouponID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCouponID.HoverState.Parent = this.TxtCouponID;
            this.TxtCouponID.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtCouponID.IconLeft")));
            this.TxtCouponID.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtCouponID.Location = new System.Drawing.Point(8, 9);
            this.TxtCouponID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCouponID.Name = "TxtCouponID";
            this.TxtCouponID.PasswordChar = '\0';
            this.TxtCouponID.PlaceholderText = "Coupon ID";
            this.TxtCouponID.ReadOnly = true;
            this.TxtCouponID.SelectedText = "";
            this.TxtCouponID.ShadowDecoration.Parent = this.TxtCouponID;
            this.TxtCouponID.Size = new System.Drawing.Size(384, 43);
            this.TxtCouponID.TabIndex = 20;
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
            // FrmCoupons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 906);
            this.Controls.Add(this.BtnAllCoupons);
            this.Controls.Add(this.BtnInactiveCoupons);
            this.Controls.Add(this.BtnActiveCoupons);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.DGClientCoupon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCoupons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCoupons";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGClientCoupon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox TxtMaxUses;
        private Guna.UI2.WinForms.Guna2ComboBox CmbStatus;
        private Guna.UI2.WinForms.Guna2TextBox TxtRate;
        private Guna.UI2.WinForms.Guna2TextBox TxtCouponCode;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtExpirationDate;
        private Guna.UI2.WinForms.Guna2Button BtnAddEdit;
        private Guna.UI2.WinForms.Guna2TextBox TxtCouponID;
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
        private Guna.UI2.WinForms.Guna2Button BtnCouponGenerator;
        private Guna.UI2.WinForms.Guna2Button BtnInactiveCoupons;
        private Guna.UI2.WinForms.Guna2Button BtnActiveCoupons;
        private Guna.UI2.WinForms.Guna2Button BtnAllCoupons;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}