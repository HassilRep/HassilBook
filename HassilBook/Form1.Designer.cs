
namespace HassilBook
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnFindFlight = new Guna.UI2.WinForms.Guna2Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.FindFlight = new System.Windows.Forms.TabPage();
            this.CheckBooking = new System.Windows.Forms.TabPage();
            this.BtnCheckBooking = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbRoles = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DtBirthdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnAddEdit = new Guna.UI2.WinForms.Guna2Button();
            this.TxtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.tabControl2.SuspendLayout();
            this.FindFlight.SuspendLayout();
            this.CheckBooking.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFindFlight
            // 
            this.BtnFindFlight.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnFindFlight.Checked = true;
            this.BtnFindFlight.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnFindFlight.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.BtnFindFlight.CheckedState.Parent = this.BtnFindFlight;
            this.BtnFindFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFindFlight.CustomImages.Parent = this.BtnFindFlight;
            this.BtnFindFlight.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BtnFindFlight.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindFlight.ForeColor = System.Drawing.Color.Black;
            this.BtnFindFlight.HoverState.Parent = this.BtnFindFlight;
            this.BtnFindFlight.Location = new System.Drawing.Point(614, 134);
            this.BtnFindFlight.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFindFlight.Name = "BtnFindFlight";
            this.BtnFindFlight.ShadowDecoration.Parent = this.BtnFindFlight;
            this.BtnFindFlight.Size = new System.Drawing.Size(282, 46);
            this.BtnFindFlight.TabIndex = 8;
            this.BtnFindFlight.Text = "Find Flight";
            this.BtnFindFlight.Click += new System.EventHandler(this.BtnFindFlight_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.FindFlight);
            this.tabControl2.Controls.Add(this.CheckBooking);
            this.tabControl2.Location = new System.Drawing.Point(444, 49);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1136, 282);
            this.tabControl2.TabIndex = 10;
            // 
            // FindFlight
            // 
            this.FindFlight.BackColor = System.Drawing.Color.White;
            this.FindFlight.Controls.Add(this.radioButton2);
            this.FindFlight.Controls.Add(this.radioButton1);
            this.FindFlight.Controls.Add(this.guna2ComboBox2);
            this.FindFlight.Controls.Add(this.guna2Button1);
            this.FindFlight.Controls.Add(this.guna2ComboBox1);
            this.FindFlight.Controls.Add(this.guna2DateTimePicker1);
            this.FindFlight.Controls.Add(this.DtBirthdate);
            this.FindFlight.Controls.Add(this.CmbRoles);
            this.FindFlight.Controls.Add(this.guna2TextBox3);
            this.FindFlight.Controls.Add(this.guna2TextBox2);
            this.FindFlight.Location = new System.Drawing.Point(4, 29);
            this.FindFlight.Name = "FindFlight";
            this.FindFlight.Padding = new System.Windows.Forms.Padding(3);
            this.FindFlight.Size = new System.Drawing.Size(1128, 249);
            this.FindFlight.TabIndex = 0;
            this.FindFlight.Text = "FindFlight";
            // 
            // CheckBooking
            // 
            this.CheckBooking.BackColor = System.Drawing.Color.White;
            this.CheckBooking.Controls.Add(this.guna2Button2);
            this.CheckBooking.Controls.Add(this.guna2TextBox4);
            this.CheckBooking.Controls.Add(this.guna2TextBox5);
            this.CheckBooking.Location = new System.Drawing.Point(4, 29);
            this.CheckBooking.Name = "CheckBooking";
            this.CheckBooking.Padding = new System.Windows.Forms.Padding(3);
            this.CheckBooking.Size = new System.Drawing.Size(1128, 249);
            this.CheckBooking.TabIndex = 1;
            this.CheckBooking.Text = "CheckBooking";
            // 
            // BtnCheckBooking
            // 
            this.BtnCheckBooking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnCheckBooking.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnCheckBooking.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.BtnCheckBooking.CheckedState.Parent = this.BtnCheckBooking;
            this.BtnCheckBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCheckBooking.CustomImages.Parent = this.BtnCheckBooking;
            this.BtnCheckBooking.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCheckBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckBooking.ForeColor = System.Drawing.Color.Black;
            this.BtnCheckBooking.HoverState.Parent = this.BtnCheckBooking;
            this.BtnCheckBooking.Location = new System.Drawing.Point(413, 49);
            this.BtnCheckBooking.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCheckBooking.Name = "BtnCheckBooking";
            this.BtnCheckBooking.ShadowDecoration.Parent = this.BtnCheckBooking;
            this.BtnCheckBooking.Size = new System.Drawing.Size(282, 52);
            this.BtnCheckBooking.TabIndex = 9;
            this.BtnCheckBooking.Text = "Check Booking";
            this.BtnCheckBooking.Click += new System.EventHandler(this.BtnCheckBooking_Click);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox2.BorderRadius = 5;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox2.IconLeft")));
            this.guna2TextBox2.IconLeftSize = new System.Drawing.Size(12, 12);
            this.guna2TextBox2.Location = new System.Drawing.Point(25, 80);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "Where from?";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(339, 43);
            this.guna2TextBox2.TabIndex = 8;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox3.BorderRadius = 5;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.FocusedState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.HoverState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox3.IconLeft")));
            this.guna2TextBox3.IconLeftSize = new System.Drawing.Size(12, 12);
            this.guna2TextBox3.Location = new System.Drawing.Point(372, 80);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "Where to?";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.ShadowDecoration.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Size = new System.Drawing.Size(339, 43);
            this.guna2TextBox3.TabIndex = 14;
            // 
            // CmbRoles
            // 
            this.CmbRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbRoles.BackColor = System.Drawing.Color.Transparent;
            this.CmbRoles.BorderRadius = 5;
            this.CmbRoles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRoles.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbRoles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbRoles.FocusedState.Parent = this.CmbRoles;
            this.CmbRoles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbRoles.ForeColor = System.Drawing.Color.Black;
            this.CmbRoles.HoverState.Parent = this.CmbRoles;
            this.CmbRoles.ItemHeight = 22;
            this.CmbRoles.Items.AddRange(new object[] {
            "- Adults-",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CmbRoles.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbRoles.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbRoles.ItemsAppearance.Parent = this.CmbRoles;
            this.CmbRoles.Location = new System.Drawing.Point(716, 80);
            this.CmbRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbRoles.Name = "CmbRoles";
            this.CmbRoles.ShadowDecoration.Parent = this.CmbRoles;
            this.CmbRoles.Size = new System.Drawing.Size(339, 28);
            this.CmbRoles.StartIndex = 0;
            this.CmbRoles.TabIndex = 15;
            // 
            // DtBirthdate
            // 
            this.DtBirthdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtBirthdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtBirthdate.BorderRadius = 5;
            this.DtBirthdate.BorderThickness = 1;
            this.DtBirthdate.CheckedState.Parent = this.DtBirthdate;
            this.DtBirthdate.FillColor = System.Drawing.Color.White;
            this.DtBirthdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtBirthdate.HoverState.Parent = this.DtBirthdate;
            this.DtBirthdate.Location = new System.Drawing.Point(25, 137);
            this.DtBirthdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtBirthdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtBirthdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtBirthdate.Name = "DtBirthdate";
            this.DtBirthdate.ShadowDecoration.Parent = this.DtBirthdate;
            this.DtBirthdate.Size = new System.Drawing.Size(339, 43);
            this.DtBirthdate.TabIndex = 16;
            this.DtBirthdate.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2DateTimePicker1.BorderRadius = 5;
            this.guna2DateTimePicker1.BorderThickness = 1;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(372, 137);
            this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(339, 43);
            this.guna2DateTimePicker1.TabIndex = 17;
            this.guna2DateTimePicker1.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 5;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 22;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "- Child -",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.guna2ComboBox1.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.guna2ComboBox1.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(716, 137);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(167, 28);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.TabIndex = 18;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(716, 193);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(339, 46);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "SEARCH FLIGHT";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton1.Location = new System.Drawing.Point(28, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 29);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Oneway";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radioButton2.Location = new System.Drawing.Point(157, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 29);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Round Trip";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderRadius = 5;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBox2.HoverState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.ItemHeight = 22;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "- Infant -",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.guna2ComboBox2.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.guna2ComboBox2.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBox2.ItemsAppearance.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Location = new System.Drawing.Point(887, 137);
            this.guna2ComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.ShadowDecoration.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Size = new System.Drawing.Size(167, 28);
            this.guna2ComboBox2.StartIndex = 0;
            this.guna2ComboBox2.TabIndex = 19;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(571, 136);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(480, 46);
            this.guna2Button2.TabIndex = 15;
            this.guna2Button2.Text = "SEARCH BOOKING";
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox4.BorderRadius = 5;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.FocusedState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.HoverState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox4.IconLeft")));
            this.guna2TextBox4.IconLeftSize = new System.Drawing.Size(12, 12);
            this.guna2TextBox4.Location = new System.Drawing.Point(571, 80);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "Your e-ticket or Refrence number";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.ShadowDecoration.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Size = new System.Drawing.Size(480, 43);
            this.guna2TextBox4.TabIndex = 17;
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox5.BorderRadius = 5;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.FocusedState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox5.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.HoverState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox5.IconLeft")));
            this.guna2TextBox5.IconLeftSize = new System.Drawing.Size(12, 12);
            this.guna2TextBox5.Location = new System.Drawing.Point(25, 80);
            this.guna2TextBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderText = "Your lastname";
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.ShadowDecoration.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Size = new System.Drawing.Size(538, 43);
            this.guna2TextBox5.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.BtnFindFlight);
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Controls.Add(this.BtnCheckBooking);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 621);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1432, 383);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 552);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1432, 73);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.bunifuGradientPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 383);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.guna2Button3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1432, 85);
            this.panel4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Featured Tours";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(1193, 21);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(223, 46);
            this.guna2Button3.TabIndex = 16;
            this.guna2Button3.Text = "AIRLINES LOG IN";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1432, 42);
            this.panel5.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1159, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label3.Size = new System.Drawing.Size(273, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "📞 support: +49 1521-2933-777";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.guna2TextBox1);
            this.bunifuGradientPanel1.Controls.Add(this.BtnAddEdit);
            this.bunifuGradientPanel1.Controls.Add(this.TxtUsername);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.linkLabel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(127)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(127)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 35);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(352, 296);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(12, 12);
            this.guna2TextBox1.Location = new System.Drawing.Point(12, 108);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Your password";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(330, 43);
            this.guna2TextBox1.TabIndex = 2;
            this.guna2TextBox1.UseSystemPasswordChar = true;
            // 
            // BtnAddEdit
            // 
            this.BtnAddEdit.BorderRadius = 5;
            this.BtnAddEdit.CheckedState.Parent = this.BtnAddEdit;
            this.BtnAddEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddEdit.CustomImages.Parent = this.BtnAddEdit;
            this.BtnAddEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.BtnAddEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddEdit.ForeColor = System.Drawing.Color.White;
            this.BtnAddEdit.HoverState.Parent = this.BtnAddEdit;
            this.BtnAddEdit.Location = new System.Drawing.Point(12, 208);
            this.BtnAddEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddEdit.Name = "BtnAddEdit";
            this.BtnAddEdit.ShadowDecoration.Parent = this.BtnAddEdit;
            this.BtnAddEdit.Size = new System.Drawing.Size(330, 46);
            this.BtnAddEdit.TabIndex = 6;
            this.BtnAddEdit.Text = "AGENT LOG IN";
            // 
            // TxtUsername
            // 
            this.TxtUsername.BorderRadius = 5;
            this.TxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUsername.DefaultText = "";
            this.TxtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUsername.DisabledState.Parent = this.TxtUsername;
            this.TxtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUsername.FocusedState.Parent = this.TxtUsername;
            this.TxtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtUsername.ForeColor = System.Drawing.Color.Black;
            this.TxtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUsername.HoverState.Parent = this.TxtUsername;
            this.TxtUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtUsername.IconLeft")));
            this.TxtUsername.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtUsername.Location = new System.Drawing.Point(12, 49);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.PasswordChar = '\0';
            this.TxtUsername.PlaceholderText = "Your agent ID";
            this.TxtUsername.SelectedText = "";
            this.TxtUsername.ShadowDecoration.Parent = this.TxtUsername;
            this.TxtUsername.Size = new System.Drawing.Size(330, 43);
            this.TxtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Log In";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(12, 167);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(197, 25);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgor your password?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1432, 425);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.White;
            this.bunifuShadowPanel1.BorderRadius = 1;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(85, 185);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(1269, 301);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1432, 1004);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl2.ResumeLayout(false);
            this.FindFlight.ResumeLayout(false);
            this.FindFlight.PerformLayout();
            this.CheckBooking.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button BtnFindFlight;
        private Guna.UI2.WinForms.Guna2Button BtnCheckBooking;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage FindFlight;
        private System.Windows.Forms.TabPage CheckBooking;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2ComboBox CmbRoles;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtBirthdate;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button BtnAddEdit;
        private Guna.UI2.WinForms.Guna2TextBox TxtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
    }
}

