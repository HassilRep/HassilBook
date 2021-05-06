
namespace HassilBook
{
    partial class FrmFlights
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFlights));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtDepTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtArrTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtEconomySeats = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtBusinessSeats = new Guna.UI2.WinForms.Guna2TextBox();
            this.DtDepDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnAddEdit = new Guna.UI2.WinForms.Guna2Button();
            this.TxtFlightNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.DGClientFlights = new System.Windows.Forms.DataGridView();
            this.CmbTo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbFrom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DtTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.CmbDestination = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbOrigin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CbStop = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbStop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbAirplaneModel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbPriceType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtFlightID = new Guna.UI2.WinForms.Guna2TextBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewImageColumn();
            this.DEL = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.guna2Panel1.Controls.Add(this.TxtFlightID);
            this.guna2Panel1.Controls.Add(this.CmbPriceType);
            this.guna2Panel1.Controls.Add(this.CmbAirplaneModel);
            this.guna2Panel1.Controls.Add(this.CmbStop);
            this.guna2Panel1.Controls.Add(this.CbStop);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.CmbDestination);
            this.guna2Panel1.Controls.Add(this.CmbStatus);
            this.guna2Panel1.Controls.Add(this.CmbOrigin);
            this.guna2Panel1.Controls.Add(this.TxtDepTime);
            this.guna2Panel1.Controls.Add(this.TxtArrTime);
            this.guna2Panel1.Controls.Add(this.TxtEconomySeats);
            this.guna2Panel1.Controls.Add(this.DtDepDate);
            this.guna2Panel1.Controls.Add(this.TxtBusinessSeats);
            this.guna2Panel1.Controls.Add(this.BtnAddEdit);
            this.guna2Panel1.Controls.Add(this.TxtFlightNo);
            this.guna2Panel1.Location = new System.Drawing.Point(14, 57);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(400, 835);
            this.guna2Panel1.TabIndex = 0;
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
            "Full",
            "Available"});
            this.CmbStatus.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbStatus.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbStatus.ItemsAppearance.Parent = this.CmbStatus;
            this.CmbStatus.Location = new System.Drawing.Point(8, 570);
            this.CmbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.ShadowDecoration.Parent = this.CmbStatus;
            this.CmbStatus.Size = new System.Drawing.Size(382, 28);
            this.CmbStatus.StartIndex = 0;
            this.CmbStatus.TabIndex = 11;
            // 
            // TxtDepTime
            // 
            this.TxtDepTime.BorderRadius = 5;
            this.TxtDepTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDepTime.DefaultText = "";
            this.TxtDepTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDepTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDepTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDepTime.DisabledState.Parent = this.TxtDepTime;
            this.TxtDepTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDepTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDepTime.FocusedState.Parent = this.TxtDepTime;
            this.TxtDepTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtDepTime.ForeColor = System.Drawing.Color.Black;
            this.TxtDepTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDepTime.HoverState.Parent = this.TxtDepTime;
            this.TxtDepTime.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtDepTime.IconLeft")));
            this.TxtDepTime.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtDepTime.Location = new System.Drawing.Point(8, 468);
            this.TxtDepTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDepTime.MaxLength = 6;
            this.TxtDepTime.Name = "TxtDepTime";
            this.TxtDepTime.PasswordChar = '\0';
            this.TxtDepTime.PlaceholderText = "Departure time";
            this.TxtDepTime.SelectedText = "";
            this.TxtDepTime.ShadowDecoration.Parent = this.TxtDepTime;
            this.TxtDepTime.Size = new System.Drawing.Size(382, 43);
            this.TxtDepTime.TabIndex = 9;
            this.TxtDepTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            this.TxtDepTime.Leave += new System.EventHandler(this.TxtDepTime_Leave);
            // 
            // TxtArrTime
            // 
            this.TxtArrTime.BorderRadius = 5;
            this.TxtArrTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtArrTime.DefaultText = "";
            this.TxtArrTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtArrTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtArrTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtArrTime.DisabledState.Parent = this.TxtArrTime;
            this.TxtArrTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtArrTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtArrTime.FocusedState.Parent = this.TxtArrTime;
            this.TxtArrTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtArrTime.ForeColor = System.Drawing.Color.Black;
            this.TxtArrTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtArrTime.HoverState.Parent = this.TxtArrTime;
            this.TxtArrTime.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtArrTime.IconLeft")));
            this.TxtArrTime.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtArrTime.Location = new System.Drawing.Point(8, 519);
            this.TxtArrTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtArrTime.MaxLength = 6;
            this.TxtArrTime.Name = "TxtArrTime";
            this.TxtArrTime.PasswordChar = '\0';
            this.TxtArrTime.PlaceholderText = "Arrival time";
            this.TxtArrTime.SelectedText = "";
            this.TxtArrTime.ShadowDecoration.Parent = this.TxtArrTime;
            this.TxtArrTime.Size = new System.Drawing.Size(382, 43);
            this.TxtArrTime.TabIndex = 10;
            this.TxtArrTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            this.TxtArrTime.Leave += new System.EventHandler(this.TxtArrTime_Leave);
            // 
            // TxtEconomySeats
            // 
            this.TxtEconomySeats.BorderRadius = 5;
            this.TxtEconomySeats.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEconomySeats.DefaultText = "";
            this.TxtEconomySeats.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtEconomySeats.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtEconomySeats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEconomySeats.DisabledState.Parent = this.TxtEconomySeats;
            this.TxtEconomySeats.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEconomySeats.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEconomySeats.FocusedState.Parent = this.TxtEconomySeats;
            this.TxtEconomySeats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtEconomySeats.ForeColor = System.Drawing.Color.Black;
            this.TxtEconomySeats.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEconomySeats.HoverState.Parent = this.TxtEconomySeats;
            this.TxtEconomySeats.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtEconomySeats.IconLeft")));
            this.TxtEconomySeats.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtEconomySeats.Location = new System.Drawing.Point(8, 213);
            this.TxtEconomySeats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEconomySeats.Name = "TxtEconomySeats";
            this.TxtEconomySeats.PasswordChar = '\0';
            this.TxtEconomySeats.PlaceholderText = "Available eonomy seats";
            this.TxtEconomySeats.SelectedText = "";
            this.TxtEconomySeats.ShadowDecoration.Parent = this.TxtEconomySeats;
            this.TxtEconomySeats.Size = new System.Drawing.Size(382, 43);
            this.TxtEconomySeats.TabIndex = 4;
            this.TxtEconomySeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // TxtBusinessSeats
            // 
            this.TxtBusinessSeats.BorderRadius = 5;
            this.TxtBusinessSeats.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBusinessSeats.DefaultText = "";
            this.TxtBusinessSeats.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBusinessSeats.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBusinessSeats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBusinessSeats.DisabledState.Parent = this.TxtBusinessSeats;
            this.TxtBusinessSeats.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBusinessSeats.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBusinessSeats.FocusedState.Parent = this.TxtBusinessSeats;
            this.TxtBusinessSeats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtBusinessSeats.ForeColor = System.Drawing.Color.Black;
            this.TxtBusinessSeats.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBusinessSeats.HoverState.Parent = this.TxtBusinessSeats;
            this.TxtBusinessSeats.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtBusinessSeats.IconLeft")));
            this.TxtBusinessSeats.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtBusinessSeats.Location = new System.Drawing.Point(8, 264);
            this.TxtBusinessSeats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBusinessSeats.Name = "TxtBusinessSeats";
            this.TxtBusinessSeats.PasswordChar = '\0';
            this.TxtBusinessSeats.PlaceholderText = "Available business seats";
            this.TxtBusinessSeats.SelectedText = "";
            this.TxtBusinessSeats.ShadowDecoration.Parent = this.TxtBusinessSeats;
            this.TxtBusinessSeats.Size = new System.Drawing.Size(382, 43);
            this.TxtBusinessSeats.TabIndex = 5;
            this.TxtBusinessSeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // DtDepDate
            // 
            this.DtDepDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtDepDate.BorderRadius = 5;
            this.DtDepDate.BorderThickness = 1;
            this.DtDepDate.CheckedState.Parent = this.DtDepDate;
            this.DtDepDate.FillColor = System.Drawing.Color.White;
            this.DtDepDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtDepDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtDepDate.HoverState.Parent = this.DtDepDate;
            this.DtDepDate.Location = new System.Drawing.Point(8, 417);
            this.DtDepDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtDepDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtDepDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtDepDate.Name = "DtDepDate";
            this.DtDepDate.ShadowDecoration.Parent = this.DtDepDate;
            this.DtDepDate.Size = new System.Drawing.Size(382, 43);
            this.DtDepDate.TabIndex = 8;
            this.DtDepDate.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
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
            this.BtnAddEdit.Location = new System.Drawing.Point(8, 675);
            this.BtnAddEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddEdit.Name = "BtnAddEdit";
            this.BtnAddEdit.ShadowDecoration.Parent = this.BtnAddEdit;
            this.BtnAddEdit.Size = new System.Drawing.Size(384, 46);
            this.BtnAddEdit.TabIndex = 14;
            this.BtnAddEdit.Text = "ADD NEW FLIGHT";
            this.BtnAddEdit.Click += new System.EventHandler(this.BtnAddEdit_Click);
            // 
            // TxtFlightNo
            // 
            this.TxtFlightNo.BorderRadius = 5;
            this.TxtFlightNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFlightNo.DefaultText = "";
            this.TxtFlightNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtFlightNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtFlightNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFlightNo.DisabledState.Parent = this.TxtFlightNo;
            this.TxtFlightNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFlightNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFlightNo.FocusedState.Parent = this.TxtFlightNo;
            this.TxtFlightNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtFlightNo.ForeColor = System.Drawing.Color.Black;
            this.TxtFlightNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFlightNo.HoverState.Parent = this.TxtFlightNo;
            this.TxtFlightNo.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtFlightNo.IconLeft")));
            this.TxtFlightNo.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtFlightNo.Location = new System.Drawing.Point(8, 60);
            this.TxtFlightNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFlightNo.Name = "TxtFlightNo";
            this.TxtFlightNo.PasswordChar = '\0';
            this.TxtFlightNo.PlaceholderText = "Flight No.";
            this.TxtFlightNo.SelectedText = "";
            this.TxtFlightNo.ShadowDecoration.Parent = this.TxtFlightNo;
            this.TxtFlightNo.Size = new System.Drawing.Size(382, 43);
            this.TxtFlightNo.TabIndex = 1;
            // 
            // DGClientFlights
            // 
            this.DGClientFlights.AllowUserToAddRows = false;
            this.DGClientFlights.AllowUserToResizeColumns = false;
            this.DGClientFlights.AllowUserToResizeRows = false;
            this.DGClientFlights.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGClientFlights.BackgroundColor = System.Drawing.Color.White;
            this.DGClientFlights.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGClientFlights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(162)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGClientFlights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGClientFlights.ColumnHeadersHeight = 25;
            this.DGClientFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGClientFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column12,
            this.Column3,
            this.Column5,
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column8,
            this.Column10,
            this.Column11,
            this.Column7,
            this.EDIT,
            this.DEL});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGClientFlights.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGClientFlights.EnableHeadersVisualStyles = false;
            this.DGClientFlights.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DGClientFlights.Location = new System.Drawing.Point(418, 57);
            this.DGClientFlights.Margin = new System.Windows.Forms.Padding(0);
            this.DGClientFlights.Name = "DGClientFlights";
            this.DGClientFlights.ReadOnly = true;
            this.DGClientFlights.RowHeadersVisible = false;
            this.DGClientFlights.RowHeadersWidth = 61;
            this.DGClientFlights.RowTemplate.Height = 25;
            this.DGClientFlights.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGClientFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGClientFlights.Size = new System.Drawing.Size(852, 835);
            this.DGClientFlights.TabIndex = 6;
            this.DGClientFlights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGClientFlights_CellContentClick);
            // 
            // CmbTo
            // 
            this.CmbTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbTo.BackColor = System.Drawing.Color.Transparent;
            this.CmbTo.BorderRadius = 5;
            this.CmbTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbTo.FocusedState.Parent = this.CmbTo;
            this.CmbTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbTo.ForeColor = System.Drawing.Color.Black;
            this.CmbTo.HoverState.Parent = this.CmbTo;
            this.CmbTo.ItemHeight = 22;
            this.CmbTo.Items.AddRange(new object[] {
            "- To -"});
            this.CmbTo.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbTo.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbTo.ItemsAppearance.Parent = this.CmbTo;
            this.CmbTo.Location = new System.Drawing.Point(501, 9);
            this.CmbTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbTo.Name = "CmbTo";
            this.CmbTo.ShadowDecoration.Parent = this.CmbTo;
            this.CmbTo.Size = new System.Drawing.Size(237, 28);
            this.CmbTo.StartIndex = 0;
            this.CmbTo.TabIndex = 2;
            // 
            // CmbFrom
            // 
            this.CmbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbFrom.BackColor = System.Drawing.Color.Transparent;
            this.CmbFrom.BorderRadius = 5;
            this.CmbFrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbFrom.FocusedState.Parent = this.CmbFrom;
            this.CmbFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbFrom.ForeColor = System.Drawing.Color.Black;
            this.CmbFrom.HoverState.Parent = this.CmbFrom;
            this.CmbFrom.ItemHeight = 22;
            this.CmbFrom.Items.AddRange(new object[] {
            "- From -"});
            this.CmbFrom.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbFrom.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbFrom.ItemsAppearance.Parent = this.CmbFrom;
            this.CmbFrom.Location = new System.Drawing.Point(418, 9);
            this.CmbFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbFrom.Name = "CmbFrom";
            this.CmbFrom.ShadowDecoration.Parent = this.CmbFrom;
            this.CmbFrom.Size = new System.Drawing.Size(75, 28);
            this.CmbFrom.StartIndex = 0;
            this.CmbFrom.TabIndex = 1;
            // 
            // DtFrom
            // 
            this.DtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtFrom.BorderRadius = 5;
            this.DtFrom.BorderThickness = 1;
            this.DtFrom.CheckedState.Parent = this.DtFrom;
            this.DtFrom.FillColor = System.Drawing.Color.White;
            this.DtFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtFrom.HoverState.Parent = this.DtFrom;
            this.DtFrom.Location = new System.Drawing.Point(746, 9);
            this.DtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.ShadowDecoration.Parent = this.DtFrom;
            this.DtFrom.Size = new System.Drawing.Size(226, 43);
            this.DtFrom.TabIndex = 3;
            this.DtFrom.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
            // 
            // DtTo
            // 
            this.DtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtTo.BorderRadius = 5;
            this.DtTo.BorderThickness = 1;
            this.DtTo.CheckedState.Parent = this.DtTo;
            this.DtTo.FillColor = System.Drawing.Color.White;
            this.DtTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtTo.HoverState.Parent = this.DtTo;
            this.DtTo.Location = new System.Drawing.Point(982, 9);
            this.DtTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtTo.Name = "DtTo";
            this.DtTo.ShadowDecoration.Parent = this.DtTo;
            this.DtTo.Size = new System.Drawing.Size(238, 43);
            this.DtTo.TabIndex = 4;
            this.DtTo.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.BorderRadius = 5;
            this.BtnSearch.CheckedState.Parent = this.BtnSearch;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.CustomImages.Parent = this.BtnSearch;
            this.BtnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(123)))), ((int)(((byte)(253)))));
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.HoverState.Parent = this.BtnSearch;
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnSearch.Location = new System.Drawing.Point(1227, 7);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.ShadowDecoration.Parent = this.BtnSearch;
            this.BtnSearch.Size = new System.Drawing.Size(43, 43);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // CmbDestination
            // 
            this.CmbDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbDestination.BackColor = System.Drawing.Color.Transparent;
            this.CmbDestination.BorderRadius = 5;
            this.CmbDestination.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDestination.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbDestination.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbDestination.FocusedState.Parent = this.CmbDestination;
            this.CmbDestination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbDestination.ForeColor = System.Drawing.Color.Black;
            this.CmbDestination.HoverState.Parent = this.CmbDestination;
            this.CmbDestination.ItemHeight = 22;
            this.CmbDestination.Items.AddRange(new object[] {
            "- To -"});
            this.CmbDestination.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbDestination.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbDestination.ItemsAppearance.Parent = this.CmbDestination;
            this.CmbDestination.Location = new System.Drawing.Point(8, 366);
            this.CmbDestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbDestination.Name = "CmbDestination";
            this.CmbDestination.ShadowDecoration.Parent = this.CmbDestination;
            this.CmbDestination.Size = new System.Drawing.Size(382, 28);
            this.CmbDestination.StartIndex = 0;
            this.CmbDestination.TabIndex = 7;
            // 
            // CmbOrigin
            // 
            this.CmbOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbOrigin.BackColor = System.Drawing.Color.Transparent;
            this.CmbOrigin.BorderRadius = 5;
            this.CmbOrigin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOrigin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbOrigin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbOrigin.FocusedState.Parent = this.CmbOrigin;
            this.CmbOrigin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbOrigin.ForeColor = System.Drawing.Color.Black;
            this.CmbOrigin.HoverState.Parent = this.CmbOrigin;
            this.CmbOrigin.ItemHeight = 22;
            this.CmbOrigin.Items.AddRange(new object[] {
            "- From -"});
            this.CmbOrigin.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbOrigin.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbOrigin.ItemsAppearance.Parent = this.CmbOrigin;
            this.CmbOrigin.Location = new System.Drawing.Point(8, 315);
            this.CmbOrigin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbOrigin.Name = "CmbOrigin";
            this.CmbOrigin.ShadowDecoration.Parent = this.CmbOrigin;
            this.CmbOrigin.Size = new System.Drawing.Size(382, 28);
            this.CmbOrigin.StartIndex = 0;
            this.CmbOrigin.TabIndex = 6;
            // 
            // CbStop
            // 
            this.CbStop.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(138)))));
            this.CbStop.CheckedState.BorderRadius = 2;
            this.CbStop.CheckedState.BorderThickness = 0;
            this.CbStop.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(200)))), ((int)(((byte)(138)))));
            this.CbStop.CheckedState.Parent = this.CbStop;
            this.CbStop.Location = new System.Drawing.Point(10, 631);
            this.CbStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbStop.Name = "CbStop";
            this.CbStop.ShadowDecoration.Parent = this.CbStop;
            this.CbStop.Size = new System.Drawing.Size(22, 23);
            this.CbStop.TabIndex = 12;
            this.CbStop.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(235)))));
            this.CbStop.UncheckedState.BorderRadius = 2;
            this.CbStop.UncheckedState.BorderThickness = 0;
            this.CbStop.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(235)))));
            this.CbStop.UncheckedState.Parent = this.CbStop;
            this.CbStop.CheckedChanged += new System.EventHandler(this.CbStop_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(40, 633);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Stop";
            // 
            // CmbStop
            // 
            this.CmbStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbStop.BackColor = System.Drawing.Color.Transparent;
            this.CmbStop.BorderRadius = 5;
            this.CmbStop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStop.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbStop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbStop.FocusedState.Parent = this.CmbStop;
            this.CmbStop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbStop.ForeColor = System.Drawing.Color.Black;
            this.CmbStop.HoverState.Parent = this.CmbStop;
            this.CmbStop.ItemHeight = 22;
            this.CmbStop.Items.AddRange(new object[] {
            "- Stop -"});
            this.CmbStop.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbStop.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbStop.ItemsAppearance.Parent = this.CmbStop;
            this.CmbStop.Location = new System.Drawing.Point(91, 622);
            this.CmbStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbStop.Name = "CmbStop";
            this.CmbStop.ShadowDecoration.Parent = this.CmbStop;
            this.CmbStop.Size = new System.Drawing.Size(299, 28);
            this.CmbStop.StartIndex = 0;
            this.CmbStop.TabIndex = 13;
            this.CmbStop.Visible = false;
            // 
            // CmbAirplaneModel
            // 
            this.CmbAirplaneModel.BackColor = System.Drawing.Color.Transparent;
            this.CmbAirplaneModel.BorderRadius = 5;
            this.CmbAirplaneModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbAirplaneModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAirplaneModel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbAirplaneModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbAirplaneModel.FocusedState.Parent = this.CmbAirplaneModel;
            this.CmbAirplaneModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbAirplaneModel.ForeColor = System.Drawing.Color.Black;
            this.CmbAirplaneModel.HoverState.Parent = this.CmbAirplaneModel;
            this.CmbAirplaneModel.ItemHeight = 22;
            this.CmbAirplaneModel.Items.AddRange(new object[] {
            "- Airplane model -"});
            this.CmbAirplaneModel.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbAirplaneModel.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbAirplaneModel.ItemsAppearance.Parent = this.CmbAirplaneModel;
            this.CmbAirplaneModel.Location = new System.Drawing.Point(8, 111);
            this.CmbAirplaneModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbAirplaneModel.Name = "CmbAirplaneModel";
            this.CmbAirplaneModel.ShadowDecoration.Parent = this.CmbAirplaneModel;
            this.CmbAirplaneModel.Size = new System.Drawing.Size(382, 28);
            this.CmbAirplaneModel.StartIndex = 0;
            this.CmbAirplaneModel.TabIndex = 2;
            // 
            // CmbPriceType
            // 
            this.CmbPriceType.BackColor = System.Drawing.Color.Transparent;
            this.CmbPriceType.BorderRadius = 5;
            this.CmbPriceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbPriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPriceType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbPriceType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbPriceType.FocusedState.Parent = this.CmbPriceType;
            this.CmbPriceType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbPriceType.ForeColor = System.Drawing.Color.Black;
            this.CmbPriceType.HoverState.Parent = this.CmbPriceType;
            this.CmbPriceType.ItemHeight = 22;
            this.CmbPriceType.Items.AddRange(new object[] {
            "- Price type -"});
            this.CmbPriceType.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbPriceType.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbPriceType.ItemsAppearance.Parent = this.CmbPriceType;
            this.CmbPriceType.Location = new System.Drawing.Point(8, 162);
            this.CmbPriceType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbPriceType.Name = "CmbPriceType";
            this.CmbPriceType.ShadowDecoration.Parent = this.CmbPriceType;
            this.CmbPriceType.Size = new System.Drawing.Size(382, 28);
            this.CmbPriceType.StartIndex = 0;
            this.CmbPriceType.TabIndex = 3;
            // 
            // TxtFlightID
            // 
            this.TxtFlightID.BorderRadius = 5;
            this.TxtFlightID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFlightID.DefaultText = "";
            this.TxtFlightID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtFlightID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtFlightID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFlightID.DisabledState.Parent = this.TxtFlightID;
            this.TxtFlightID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFlightID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFlightID.FocusedState.Parent = this.TxtFlightID;
            this.TxtFlightID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtFlightID.ForeColor = System.Drawing.Color.Black;
            this.TxtFlightID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFlightID.HoverState.Parent = this.TxtFlightID;
            this.TxtFlightID.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtFlightID.IconLeft")));
            this.TxtFlightID.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtFlightID.Location = new System.Drawing.Point(8, 9);
            this.TxtFlightID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFlightID.Name = "TxtFlightID";
            this.TxtFlightID.PasswordChar = '\0';
            this.TxtFlightID.PlaceholderText = "Flight ID";
            this.TxtFlightID.ReadOnly = true;
            this.TxtFlightID.SelectedText = "";
            this.TxtFlightID.ShadowDecoration.Parent = this.TxtFlightID;
            this.TxtFlightID.Size = new System.Drawing.Size(382, 43);
            this.TxtFlightID.TabIndex = 0;
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
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.HeaderText = "ID";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 61;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "FLIGHT NO.";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 134;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "PRICE TYPE";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 133;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "ORIGIN";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "DESTINATION";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 151;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "E. SEATS";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 108;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "B. SEATS";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 109;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "DEP. DATE";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 121;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "DEP. TIME";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 120;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.HeaderText = "ARR. TIME";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 125;
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
            // FrmFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 906);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DtTo);
            this.Controls.Add(this.DtFrom);
            this.Controls.Add(this.CmbTo);
            this.Controls.Add(this.CmbFrom);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.DGClientFlights);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFlights";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientFlights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox CmbStatus;
        private Guna.UI2.WinForms.Guna2TextBox TxtDepTime;
        private Guna.UI2.WinForms.Guna2TextBox TxtArrTime;
        private Guna.UI2.WinForms.Guna2TextBox TxtEconomySeats;
        private Guna.UI2.WinForms.Guna2TextBox TxtBusinessSeats;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtDepDate;
        private Guna.UI2.WinForms.Guna2Button BtnAddEdit;
        private Guna.UI2.WinForms.Guna2TextBox TxtFlightNo;
        private System.Windows.Forms.DataGridView DGClientFlights;
        private Guna.UI2.WinForms.Guna2ComboBox CmbTo;
        private Guna.UI2.WinForms.Guna2ComboBox CmbFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtTo;
        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private Guna.UI2.WinForms.Guna2ComboBox CmbDestination;
        private Guna.UI2.WinForms.Guna2ComboBox CmbOrigin;
        public Guna.UI2.WinForms.Guna2CustomCheckBox CbStop;
        public System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox CmbStop;
        private Guna.UI2.WinForms.Guna2ComboBox CmbPriceType;
        private Guna.UI2.WinForms.Guna2ComboBox CmbAirplaneModel;
        private Guna.UI2.WinForms.Guna2TextBox TxtFlightID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn EDIT;
        private System.Windows.Forms.DataGridViewImageColumn DEL;
    }
}