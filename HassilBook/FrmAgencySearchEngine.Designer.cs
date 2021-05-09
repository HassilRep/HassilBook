
namespace HassilBook
{
    partial class FrmAgencySearchEngine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgencySearchEngine));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lstDropDownFrom = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSearchFlight = new Guna.UI2.WinForms.Guna2Button();
            this.CmbAdult = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lstDropDownTo = new System.Windows.Forms.ListBox();
            this.DtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.RbtnOneway = new System.Windows.Forms.RadioButton();
            this.TxtFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.RbtnRoundTrip = new System.Windows.Forms.RadioButton();
            this.CmbChild = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbInfant = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DtTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TxtTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.FlpFlightSearchResults = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSwitch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.guna2Panel1.Controls.Add(this.BtnSwitch);
            this.guna2Panel1.Controls.Add(this.lstDropDownFrom);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.BtnSearchFlight);
            this.guna2Panel1.Controls.Add(this.CmbAdult);
            this.guna2Panel1.Controls.Add(this.lstDropDownTo);
            this.guna2Panel1.Controls.Add(this.DtFrom);
            this.guna2Panel1.Controls.Add(this.RbtnOneway);
            this.guna2Panel1.Controls.Add(this.TxtFrom);
            this.guna2Panel1.Controls.Add(this.RbtnRoundTrip);
            this.guna2Panel1.Controls.Add(this.CmbChild);
            this.guna2Panel1.Controls.Add(this.CmbInfant);
            this.guna2Panel1.Controls.Add(this.CmbClass);
            this.guna2Panel1.Controls.Add(this.DtTo);
            this.guna2Panel1.Controls.Add(this.TxtTo);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 3;
            this.guna2Panel1.ShadowDecoration.Depth = 50;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(546, 848);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lstDropDownFrom
            // 
            this.lstDropDownFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDropDownFrom.FormattingEnabled = true;
            this.lstDropDownFrom.ItemHeight = 28;
            this.lstDropDownFrom.Location = new System.Drawing.Point(18, 175);
            this.lstDropDownFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDropDownFrom.Name = "lstDropDownFrom";
            this.lstDropDownFrom.Size = new System.Drawing.Size(455, 60);
            this.lstDropDownFrom.TabIndex = 34;
            this.lstDropDownFrom.Visible = false;
            this.lstDropDownFrom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstDropDownFrom_MouseClick);
            this.lstDropDownFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstDropDownFrom_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "YOUR PERSONAL FLIGHT ENGINE!";
            // 
            // BtnSearchFlight
            // 
            this.BtnSearchFlight.BorderRadius = 5;
            this.BtnSearchFlight.CheckedState.Parent = this.BtnSearchFlight;
            this.BtnSearchFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchFlight.CustomImages.Parent = this.BtnSearchFlight;
            this.BtnSearchFlight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.BtnSearchFlight.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchFlight.ForeColor = System.Drawing.Color.White;
            this.BtnSearchFlight.HoverState.Parent = this.BtnSearchFlight;
            this.BtnSearchFlight.Location = new System.Drawing.Point(18, 471);
            this.BtnSearchFlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearchFlight.Name = "BtnSearchFlight";
            this.BtnSearchFlight.ShadowDecoration.Parent = this.BtnSearchFlight;
            this.BtnSearchFlight.Size = new System.Drawing.Size(514, 43);
            this.BtnSearchFlight.TabIndex = 23;
            this.BtnSearchFlight.Text = "SEARCH FLIGHT";
            this.BtnSearchFlight.Click += new System.EventHandler(this.BtnSearchFlight_Click);
            // 
            // CmbAdult
            // 
            this.CmbAdult.BackColor = System.Drawing.Color.Transparent;
            this.CmbAdult.BorderRadius = 5;
            this.CmbAdult.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbAdult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAdult.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbAdult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbAdult.FocusedState.Parent = this.CmbAdult;
            this.CmbAdult.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbAdult.ForeColor = System.Drawing.Color.Black;
            this.CmbAdult.HoverState.Parent = this.CmbAdult;
            this.CmbAdult.ItemHeight = 22;
            this.CmbAdult.Items.AddRange(new object[] {
            "-ADL-",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CmbAdult.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbAdult.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbAdult.ItemsAppearance.Parent = this.CmbAdult;
            this.CmbAdult.Location = new System.Drawing.Point(18, 414);
            this.CmbAdult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbAdult.Name = "CmbAdult";
            this.CmbAdult.ShadowDecoration.Parent = this.CmbAdult;
            this.CmbAdult.Size = new System.Drawing.Size(161, 28);
            this.CmbAdult.StartIndex = 0;
            this.CmbAdult.TabIndex = 31;
            // 
            // lstDropDownTo
            // 
            this.lstDropDownTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDropDownTo.FormattingEnabled = true;
            this.lstDropDownTo.ItemHeight = 28;
            this.lstDropDownTo.Location = new System.Drawing.Point(18, 232);
            this.lstDropDownTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDropDownTo.Name = "lstDropDownTo";
            this.lstDropDownTo.Size = new System.Drawing.Size(455, 60);
            this.lstDropDownTo.TabIndex = 22;
            this.lstDropDownTo.Visible = false;
            this.lstDropDownTo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstDropDownTo_MouseClick);
            this.lstDropDownTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstDropDownTo_KeyDown);
            // 
            // DtFrom
            // 
            this.DtFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtFrom.BorderRadius = 5;
            this.DtFrom.BorderThickness = 1;
            this.DtFrom.CheckedState.Parent = this.DtFrom;
            this.DtFrom.FillColor = System.Drawing.Color.White;
            this.DtFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtFrom.HoverState.Parent = this.DtFrom;
            this.DtFrom.Location = new System.Drawing.Point(18, 243);
            this.DtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.ShadowDecoration.Parent = this.DtFrom;
            this.DtFrom.Size = new System.Drawing.Size(514, 43);
            this.DtFrom.TabIndex = 19;
            this.DtFrom.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
            // 
            // RbtnOneway
            // 
            this.RbtnOneway.AutoSize = true;
            this.RbtnOneway.Checked = true;
            this.RbtnOneway.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnOneway.Location = new System.Drawing.Point(22, 86);
            this.RbtnOneway.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RbtnOneway.Name = "RbtnOneway";
            this.RbtnOneway.Size = new System.Drawing.Size(96, 27);
            this.RbtnOneway.TabIndex = 28;
            this.RbtnOneway.TabStop = true;
            this.RbtnOneway.Text = "Oneway";
            this.RbtnOneway.UseVisualStyleBackColor = true;
            this.RbtnOneway.CheckedChanged += new System.EventHandler(this.RbtnOneway_CheckedChanged);
            // 
            // TxtFrom
            // 
            this.TxtFrom.BorderRadius = 5;
            this.TxtFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFrom.DefaultText = "";
            this.TxtFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFrom.DisabledState.Parent = this.TxtFrom;
            this.TxtFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFrom.FocusedState.Parent = this.TxtFrom;
            this.TxtFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtFrom.ForeColor = System.Drawing.Color.Black;
            this.TxtFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFrom.HoverState.Parent = this.TxtFrom;
            this.TxtFrom.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtFrom.IconLeft")));
            this.TxtFrom.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtFrom.Location = new System.Drawing.Point(18, 129);
            this.TxtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFrom.Name = "TxtFrom";
            this.TxtFrom.PasswordChar = '\0';
            this.TxtFrom.PlaceholderText = "FROM?";
            this.TxtFrom.SelectedText = "";
            this.TxtFrom.ShadowDecoration.Parent = this.TxtFrom;
            this.TxtFrom.Size = new System.Drawing.Size(455, 43);
            this.TxtFrom.TabIndex = 15;
            this.TxtFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFrom_KeyDown);
            this.TxtFrom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFrom_KeyUp);
            // 
            // RbtnRoundTrip
            // 
            this.RbtnRoundTrip.AutoSize = true;
            this.RbtnRoundTrip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnRoundTrip.Location = new System.Drawing.Point(156, 86);
            this.RbtnRoundTrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RbtnRoundTrip.Name = "RbtnRoundTrip";
            this.RbtnRoundTrip.Size = new System.Drawing.Size(116, 27);
            this.RbtnRoundTrip.TabIndex = 29;
            this.RbtnRoundTrip.Text = "Round trip";
            this.RbtnRoundTrip.UseVisualStyleBackColor = true;
            // 
            // CmbChild
            // 
            this.CmbChild.BackColor = System.Drawing.Color.Transparent;
            this.CmbChild.BorderRadius = 5;
            this.CmbChild.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbChild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbChild.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbChild.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbChild.FocusedState.Parent = this.CmbChild;
            this.CmbChild.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbChild.ForeColor = System.Drawing.Color.Black;
            this.CmbChild.HoverState.Parent = this.CmbChild;
            this.CmbChild.ItemHeight = 22;
            this.CmbChild.Items.AddRange(new object[] {
            "-CHD-",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CmbChild.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbChild.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbChild.ItemsAppearance.Parent = this.CmbChild;
            this.CmbChild.Location = new System.Drawing.Point(187, 414);
            this.CmbChild.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbChild.Name = "CmbChild";
            this.CmbChild.ShadowDecoration.Parent = this.CmbChild;
            this.CmbChild.Size = new System.Drawing.Size(153, 28);
            this.CmbChild.StartIndex = 0;
            this.CmbChild.TabIndex = 32;
            // 
            // CmbInfant
            // 
            this.CmbInfant.BackColor = System.Drawing.Color.Transparent;
            this.CmbInfant.BorderRadius = 5;
            this.CmbInfant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbInfant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbInfant.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbInfant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbInfant.FocusedState.Parent = this.CmbInfant;
            this.CmbInfant.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbInfant.ForeColor = System.Drawing.Color.Black;
            this.CmbInfant.HoverState.Parent = this.CmbInfant;
            this.CmbInfant.ItemHeight = 22;
            this.CmbInfant.Items.AddRange(new object[] {
            "-INF-",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CmbInfant.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbInfant.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbInfant.ItemsAppearance.Parent = this.CmbInfant;
            this.CmbInfant.Location = new System.Drawing.Point(348, 414);
            this.CmbInfant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbInfant.Name = "CmbInfant";
            this.CmbInfant.ShadowDecoration.Parent = this.CmbInfant;
            this.CmbInfant.Size = new System.Drawing.Size(184, 28);
            this.CmbInfant.StartIndex = 0;
            this.CmbInfant.TabIndex = 33;
            // 
            // CmbClass
            // 
            this.CmbClass.BackColor = System.Drawing.Color.Transparent;
            this.CmbClass.BorderRadius = 5;
            this.CmbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbClass.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbClass.FocusedState.Parent = this.CmbClass;
            this.CmbClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbClass.ForeColor = System.Drawing.Color.Black;
            this.CmbClass.HoverState.Parent = this.CmbClass;
            this.CmbClass.ItemHeight = 22;
            this.CmbClass.Items.AddRange(new object[] {
            "- Class -",
            "Economy",
            "Business"});
            this.CmbClass.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbClass.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbClass.ItemsAppearance.Parent = this.CmbClass;
            this.CmbClass.Location = new System.Drawing.Point(18, 357);
            this.CmbClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbClass.Name = "CmbClass";
            this.CmbClass.ShadowDecoration.Parent = this.CmbClass;
            this.CmbClass.Size = new System.Drawing.Size(514, 28);
            this.CmbClass.StartIndex = 0;
            this.CmbClass.TabIndex = 30;
            // 
            // DtTo
            // 
            this.DtTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtTo.BorderRadius = 5;
            this.DtTo.BorderThickness = 1;
            this.DtTo.CheckedState.Parent = this.DtTo;
            this.DtTo.FillColor = System.Drawing.Color.White;
            this.DtTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtTo.HoverState.Parent = this.DtTo;
            this.DtTo.Location = new System.Drawing.Point(18, 300);
            this.DtTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtTo.Name = "DtTo";
            this.DtTo.ShadowDecoration.Parent = this.DtTo;
            this.DtTo.Size = new System.Drawing.Size(516, 43);
            this.DtTo.TabIndex = 20;
            this.DtTo.Value = new System.DateTime(2021, 4, 22, 0, 0, 0, 0);
            this.DtTo.Visible = false;
            // 
            // TxtTo
            // 
            this.TxtTo.BorderRadius = 5;
            this.TxtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTo.DefaultText = "";
            this.TxtTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTo.DisabledState.Parent = this.TxtTo;
            this.TxtTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTo.FocusedState.Parent = this.TxtTo;
            this.TxtTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtTo.ForeColor = System.Drawing.Color.Black;
            this.TxtTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTo.HoverState.Parent = this.TxtTo;
            this.TxtTo.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtTo.IconLeft")));
            this.TxtTo.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtTo.Location = new System.Drawing.Point(18, 186);
            this.TxtTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.PasswordChar = '\0';
            this.TxtTo.PlaceholderText = "TO?";
            this.TxtTo.SelectedText = "";
            this.TxtTo.ShadowDecoration.Parent = this.TxtTo;
            this.TxtTo.Size = new System.Drawing.Size(455, 43);
            this.TxtTo.TabIndex = 16;
            this.TxtTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTo_KeyDown);
            this.TxtTo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTo_KeyUp);
            // 
            // FlpFlightSearchResults
            // 
            this.FlpFlightSearchResults.AutoScroll = true;
            this.FlpFlightSearchResults.BackColor = System.Drawing.Color.White;
            this.FlpFlightSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpFlightSearchResults.Location = new System.Drawing.Point(546, 0);
            this.FlpFlightSearchResults.Name = "FlpFlightSearchResults";
            this.FlpFlightSearchResults.Size = new System.Drawing.Size(664, 848);
            this.FlpFlightSearchResults.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 848);
            this.panel2.TabIndex = 6;
            // 
            // BtnSwitch
            // 
            this.BtnSwitch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.BtnSwitch.BorderRadius = 5;
            this.BtnSwitch.BorderThickness = 1;
            this.BtnSwitch.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnSwitch.CheckedState.Parent = this.BtnSwitch;
            this.BtnSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSwitch.CustomImages.Parent = this.BtnSwitch;
            this.BtnSwitch.FillColor = System.Drawing.Color.White;
            this.BtnSwitch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnSwitch.ForeColor = System.Drawing.Color.White;
            this.BtnSwitch.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.BtnSwitch.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnSwitch.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("BtnSwitch.HoverState.Image")));
            this.BtnSwitch.HoverState.Parent = this.BtnSwitch;
            this.BtnSwitch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSwitch.Image")));
            this.BtnSwitch.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnSwitch.Location = new System.Drawing.Point(481, 129);
            this.BtnSwitch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSwitch.Name = "BtnSwitch";
            this.BtnSwitch.PressedColor = System.Drawing.Color.White;
            this.BtnSwitch.ShadowDecoration.Parent = this.BtnSwitch;
            this.BtnSwitch.Size = new System.Drawing.Size(51, 100);
            this.BtnSwitch.TabIndex = 35;
            this.BtnSwitch.Click += new System.EventHandler(this.BtnSwitch_Click);
            // 
            // FrmAgencySearchEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1274, 848);
            this.Controls.Add(this.FlpFlightSearchResults);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgencySearchEngine";
            this.Text = "FrmAgencySearchEngine";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ListBox lstDropDownFrom;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnSearchFlight;
        private Guna.UI2.WinForms.Guna2ComboBox CmbAdult;
        private System.Windows.Forms.ListBox lstDropDownTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtFrom;
        private System.Windows.Forms.RadioButton RbtnOneway;
        private Guna.UI2.WinForms.Guna2TextBox TxtFrom;
        private System.Windows.Forms.RadioButton RbtnRoundTrip;
        private Guna.UI2.WinForms.Guna2ComboBox CmbChild;
        private Guna.UI2.WinForms.Guna2ComboBox CmbInfant;
        private Guna.UI2.WinForms.Guna2ComboBox CmbClass;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtTo;
        private Guna.UI2.WinForms.Guna2TextBox TxtTo;
        private System.Windows.Forms.FlowLayoutPanel FlpFlightSearchResults;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button BtnSwitch;
    }
}