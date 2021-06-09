
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookingCart));
            this.DGClientBookingCart = new System.Windows.Forms.DataGridView();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.CmbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtPassengername = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblInvoiceAmount = new System.Windows.Forms.Label();
            this.BtnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewImageColumn();
            this.DEL = new System.Windows.Forms.DataGridViewImageColumn();
            this.DtIssuedDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TxtBookingRef = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbPaymentType = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientBookingCart)).BeginInit();
            this.bunifuGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGClientBookingCart
            // 
            this.DGClientBookingCart.AllowUserToAddRows = false;
            this.DGClientBookingCart.AllowUserToResizeColumns = false;
            this.DGClientBookingCart.AllowUserToResizeRows = false;
            this.DGClientBookingCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGClientBookingCart.BackgroundColor = System.Drawing.Color.White;
            this.DGClientBookingCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGClientBookingCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(162)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGClientBookingCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGClientBookingCart.ColumnHeadersHeight = 25;
            this.DGClientBookingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGClientBookingCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column9,
            this.Column7,
            this.Column1,
            this.Column6,
            this.EDIT,
            this.DEL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGClientBookingCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGClientBookingCart.EnableHeadersVisualStyles = false;
            this.DGClientBookingCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DGClientBookingCart.Location = new System.Drawing.Point(12, 296);
            this.DGClientBookingCart.Margin = new System.Windows.Forms.Padding(0);
            this.DGClientBookingCart.Name = "DGClientBookingCart";
            this.DGClientBookingCart.ReadOnly = true;
            this.DGClientBookingCart.RowHeadersVisible = false;
            this.DGClientBookingCart.RowHeadersWidth = 61;
            this.DGClientBookingCart.RowTemplate.Height = 25;
            this.DGClientBookingCart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGClientBookingCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGClientBookingCart.Size = new System.Drawing.Size(945, 307);
            this.DGClientBookingCart.TabIndex = 52;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.CmbPaymentType);
            this.bunifuGroupBox1.Controls.Add(this.TxtBookingRef);
            this.bunifuGroupBox1.Controls.Add(this.DtIssuedDate);
            this.bunifuGroupBox1.Controls.Add(this.CmbGender);
            this.bunifuGroupBox1.Controls.Add(this.TxtPassengername);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(12, 75);
            this.bunifuGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGroupBox1.Size = new System.Drawing.Size(945, 164);
            this.bunifuGroupBox1.TabIndex = 53;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Personal information";
            // 
            // CmbGender
            // 
            this.CmbGender.BackColor = System.Drawing.Color.Transparent;
            this.CmbGender.BorderRadius = 5;
            this.CmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbGender.FocusedState.Parent = this.CmbGender;
            this.CmbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbGender.ForeColor = System.Drawing.Color.Black;
            this.CmbGender.HoverState.Parent = this.CmbGender;
            this.CmbGender.ItemHeight = 23;
            this.CmbGender.Items.AddRange(new object[] {
            "- Gender -",
            "MR",
            "MRS",
            "MS",
            "CHD",
            "INF",
            "MR + INF",
            "MRS + INF",
            "PROF",
            "HE",
            "DR"});
            this.CmbGender.ItemsAppearance.Parent = this.CmbGender;
            this.CmbGender.Location = new System.Drawing.Point(426, 96);
            this.CmbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.ShadowDecoration.Parent = this.CmbGender;
            this.CmbGender.Size = new System.Drawing.Size(238, 29);
            this.CmbGender.StartIndex = 0;
            this.CmbGender.TabIndex = 40;
            // 
            // TxtPassengername
            // 
            this.TxtPassengername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassengername.BorderRadius = 5;
            this.TxtPassengername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassengername.DefaultText = "";
            this.TxtPassengername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPassengername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPassengername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassengername.DisabledState.Parent = this.TxtPassengername;
            this.TxtPassengername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassengername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPassengername.FocusedState.Parent = this.TxtPassengername;
            this.TxtPassengername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtPassengername.ForeColor = System.Drawing.Color.Black;
            this.TxtPassengername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPassengername.HoverState.Parent = this.TxtPassengername;
            this.TxtPassengername.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtPassengername.IconLeft")));
            this.TxtPassengername.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtPassengername.Location = new System.Drawing.Point(426, 46);
            this.TxtPassengername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPassengername.Name = "TxtPassengername";
            this.TxtPassengername.PasswordChar = '\0';
            this.TxtPassengername.PlaceholderText = "Passenger name";
            this.TxtPassengername.SelectedText = "";
            this.TxtPassengername.ShadowDecoration.Parent = this.TxtPassengername;
            this.TxtPassengername.Size = new System.Drawing.Size(508, 43);
            this.TxtPassengername.TabIndex = 35;
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
            // BtnAddToCart
            // 
            this.BtnAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddToCart.BorderRadius = 5;
            this.BtnAddToCart.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnAddToCart.CheckedState.Parent = this.BtnAddToCart;
            this.BtnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddToCart.CustomImages.Parent = this.BtnAddToCart;
            this.BtnAddToCart.CustomizableEdges.BottomRight = false;
            this.BtnAddToCart.CustomizableEdges.TopRight = false;
            this.BtnAddToCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnAddToCart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAddToCart.ForeColor = System.Drawing.Color.White;
            this.BtnAddToCart.HoverState.Parent = this.BtnAddToCart;
            this.BtnAddToCart.Location = new System.Drawing.Point(669, 248);
            this.BtnAddToCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.ShadowDecoration.Parent = this.BtnAddToCart;
            this.BtnAddToCart.Size = new System.Drawing.Size(288, 43);
            this.BtnAddToCart.TabIndex = 56;
            this.BtnAddToCart.Text = "ADD TO CART";
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
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
            this.Column3.HeaderText = "BOOKING REF";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 154;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "FLIGHT";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "PASSENGER";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "GENDER";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 110;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "PRICE";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "CLASS";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 92;
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
            // DtIssuedDate
            // 
            this.DtIssuedDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtIssuedDate.BorderRadius = 5;
            this.DtIssuedDate.BorderThickness = 1;
            this.DtIssuedDate.CheckedState.Parent = this.DtIssuedDate;
            this.DtIssuedDate.FillColor = System.Drawing.Color.White;
            this.DtIssuedDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtIssuedDate.ForeColor = System.Drawing.Color.Black;
            this.DtIssuedDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtIssuedDate.HoverState.Parent = this.DtIssuedDate;
            this.DtIssuedDate.Location = new System.Drawing.Point(8, 96);
            this.DtIssuedDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtIssuedDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtIssuedDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtIssuedDate.Name = "DtIssuedDate";
            this.DtIssuedDate.ShadowDecoration.Parent = this.DtIssuedDate;
            this.DtIssuedDate.Size = new System.Drawing.Size(405, 43);
            this.DtIssuedDate.TabIndex = 52;
            this.DtIssuedDate.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
            // 
            // TxtBookingRef
            // 
            this.TxtBookingRef.BorderRadius = 5;
            this.TxtBookingRef.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBookingRef.DefaultText = "";
            this.TxtBookingRef.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBookingRef.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBookingRef.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBookingRef.DisabledState.Parent = this.TxtBookingRef;
            this.TxtBookingRef.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBookingRef.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBookingRef.FocusedState.Parent = this.TxtBookingRef;
            this.TxtBookingRef.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBookingRef.ForeColor = System.Drawing.Color.Black;
            this.TxtBookingRef.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBookingRef.HoverState.Parent = this.TxtBookingRef;
            this.TxtBookingRef.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtBookingRef.IconLeft")));
            this.TxtBookingRef.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtBookingRef.Location = new System.Drawing.Point(8, 46);
            this.TxtBookingRef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBookingRef.Name = "TxtBookingRef";
            this.TxtBookingRef.PasswordChar = '\0';
            this.TxtBookingRef.PlaceholderText = "Booking refrence";
            this.TxtBookingRef.SelectedText = "";
            this.TxtBookingRef.ShadowDecoration.Parent = this.TxtBookingRef;
            this.TxtBookingRef.Size = new System.Drawing.Size(405, 43);
            this.TxtBookingRef.TabIndex = 53;
            // 
            // CmbPaymentType
            // 
            this.CmbPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbPaymentType.BackColor = System.Drawing.Color.Transparent;
            this.CmbPaymentType.BorderRadius = 5;
            this.CmbPaymentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPaymentType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbPaymentType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbPaymentType.FocusedState.Parent = this.CmbPaymentType;
            this.CmbPaymentType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbPaymentType.ForeColor = System.Drawing.Color.Black;
            this.CmbPaymentType.HoverState.Parent = this.CmbPaymentType;
            this.CmbPaymentType.ItemHeight = 23;
            this.CmbPaymentType.Items.AddRange(new object[] {
            "- Payment -",
            "HA-Wallet",
            "Postpaid account"});
            this.CmbPaymentType.ItemsAppearance.Parent = this.CmbPaymentType;
            this.CmbPaymentType.Location = new System.Drawing.Point(672, 96);
            this.CmbPaymentType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbPaymentType.Name = "CmbPaymentType";
            this.CmbPaymentType.ShadowDecoration.Parent = this.CmbPaymentType;
            this.CmbPaymentType.Size = new System.Drawing.Size(262, 29);
            this.CmbPaymentType.StartIndex = 0;
            this.CmbPaymentType.TabIndex = 54;
            // 
            // FrmBookingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 612);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.DGClientBookingCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBookingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your booking cart";
            ((System.ComponentModel.ISupportInitialize)(this.DGClientBookingCart)).EndInit();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGClientBookingCart;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        public Guna.UI2.WinForms.Guna2ComboBox CmbGender;
        public Guna.UI2.WinForms.Guna2TextBox TxtPassengername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblInvoiceAmount;
        private Guna.UI2.WinForms.Guna2Button BtnAddToCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn EDIT;
        private System.Windows.Forms.DataGridViewImageColumn DEL;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtIssuedDate;
        public Guna.UI2.WinForms.Guna2TextBox TxtBookingRef;
        public Guna.UI2.WinForms.Guna2ComboBox CmbPaymentType;
    }
}