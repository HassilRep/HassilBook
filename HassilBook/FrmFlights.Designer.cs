
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFlights));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbAgencyType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtTelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbCountry = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtStreet = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPostalCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtCity = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtOwnerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtCompany = new Guna.UI2.WinForms.Guna2TextBox();
            this.DtJoinDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnAddEdit = new Guna.UI2.WinForms.Guna2Button();
            this.TxtAgencyID = new Guna.UI2.WinForms.Guna2TextBox();
            this.DGClientAgencies = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewImageColumn();
            this.DEL = new System.Windows.Forms.DataGridViewImageColumn();
            this.CmbTo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbFrom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DtTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientAgencies)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.guna2Panel1.Controls.Add(this.CmbStatus);
            this.guna2Panel1.Controls.Add(this.CmbAgencyType);
            this.guna2Panel1.Controls.Add(this.TxtTelephone);
            this.guna2Panel1.Controls.Add(this.TxtEmail);
            this.guna2Panel1.Controls.Add(this.CmbCountry);
            this.guna2Panel1.Controls.Add(this.TxtStreet);
            this.guna2Panel1.Controls.Add(this.TxtPostalCode);
            this.guna2Panel1.Controls.Add(this.TxtCity);
            this.guna2Panel1.Controls.Add(this.CmbGender);
            this.guna2Panel1.Controls.Add(this.TxtOwnerName);
            this.guna2Panel1.Controls.Add(this.TxtCompany);
            this.guna2Panel1.Controls.Add(this.DtJoinDate);
            this.guna2Panel1.Controls.Add(this.BtnAddEdit);
            this.guna2Panel1.Controls.Add(this.TxtAgencyID);
            this.guna2Panel1.Location = new System.Drawing.Point(14, 57);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(400, 835);
            this.guna2Panel1.TabIndex = 50;
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
            "Deactivated"});
            this.CmbStatus.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbStatus.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbStatus.ItemsAppearance.Parent = this.CmbStatus;
            this.CmbStatus.Location = new System.Drawing.Point(8, 618);
            this.CmbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.ShadowDecoration.Parent = this.CmbStatus;
            this.CmbStatus.Size = new System.Drawing.Size(382, 28);
            this.CmbStatus.StartIndex = 0;
            this.CmbStatus.TabIndex = 36;
            // 
            // CmbAgencyType
            // 
            this.CmbAgencyType.BackColor = System.Drawing.Color.Transparent;
            this.CmbAgencyType.BorderRadius = 5;
            this.CmbAgencyType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbAgencyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAgencyType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbAgencyType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbAgencyType.FocusedState.Parent = this.CmbAgencyType;
            this.CmbAgencyType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbAgencyType.ForeColor = System.Drawing.Color.Black;
            this.CmbAgencyType.HoverState.Parent = this.CmbAgencyType;
            this.CmbAgencyType.ItemHeight = 22;
            this.CmbAgencyType.Items.AddRange(new object[] {
            "- Agency type -",
            "Prepaid",
            "Postpaid"});
            this.CmbAgencyType.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbAgencyType.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbAgencyType.ItemsAppearance.Parent = this.CmbAgencyType;
            this.CmbAgencyType.Location = new System.Drawing.Point(8, 568);
            this.CmbAgencyType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbAgencyType.Name = "CmbAgencyType";
            this.CmbAgencyType.ShadowDecoration.Parent = this.CmbAgencyType;
            this.CmbAgencyType.Size = new System.Drawing.Size(382, 28);
            this.CmbAgencyType.StartIndex = 0;
            this.CmbAgencyType.TabIndex = 32;
            // 
            // TxtTelephone
            // 
            this.TxtTelephone.BorderRadius = 5;
            this.TxtTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTelephone.DefaultText = "";
            this.TxtTelephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtTelephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtTelephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTelephone.DisabledState.Parent = this.TxtTelephone;
            this.TxtTelephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTelephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTelephone.FocusedState.Parent = this.TxtTelephone;
            this.TxtTelephone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtTelephone.ForeColor = System.Drawing.Color.Black;
            this.TxtTelephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTelephone.HoverState.Parent = this.TxtTelephone;
            this.TxtTelephone.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtTelephone.IconLeft")));
            this.TxtTelephone.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtTelephone.Location = new System.Drawing.Point(8, 466);
            this.TxtTelephone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTelephone.Name = "TxtTelephone";
            this.TxtTelephone.PasswordChar = '\0';
            this.TxtTelephone.PlaceholderText = "Telephone";
            this.TxtTelephone.SelectedText = "";
            this.TxtTelephone.ShadowDecoration.Parent = this.TxtTelephone;
            this.TxtTelephone.Size = new System.Drawing.Size(384, 43);
            this.TxtTelephone.TabIndex = 30;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderRadius = 5;
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEmail.DefaultText = "";
            this.TxtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmail.DisabledState.Parent = this.TxtEmail;
            this.TxtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmail.FocusedState.Parent = this.TxtEmail;
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtEmail.ForeColor = System.Drawing.Color.Black;
            this.TxtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmail.HoverState.Parent = this.TxtEmail;
            this.TxtEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtEmail.IconLeft")));
            this.TxtEmail.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtEmail.Location = new System.Drawing.Point(8, 517);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.PlaceholderText = "Email";
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.ShadowDecoration.Parent = this.TxtEmail;
            this.TxtEmail.Size = new System.Drawing.Size(384, 43);
            this.TxtEmail.TabIndex = 31;
            // 
            // CmbCountry
            // 
            this.CmbCountry.BackColor = System.Drawing.Color.Transparent;
            this.CmbCountry.BorderRadius = 5;
            this.CmbCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCountry.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbCountry.FocusedState.Parent = this.CmbCountry;
            this.CmbCountry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbCountry.ForeColor = System.Drawing.Color.Black;
            this.CmbCountry.HoverState.Parent = this.CmbCountry;
            this.CmbCountry.ItemHeight = 22;
            this.CmbCountry.Items.AddRange(new object[] {
            "-Country-",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burma",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cabo Verde",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Curacao",
            "Cyprus",
            "Czechia",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia, The",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestinian Territories",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Sint Maarten",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.CmbCountry.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbCountry.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbCountry.ItemsAppearance.Parent = this.CmbCountry;
            this.CmbCountry.Location = new System.Drawing.Point(8, 415);
            this.CmbCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbCountry.Name = "CmbCountry";
            this.CmbCountry.ShadowDecoration.Parent = this.CmbCountry;
            this.CmbCountry.Size = new System.Drawing.Size(382, 28);
            this.CmbCountry.StartIndex = 0;
            this.CmbCountry.TabIndex = 28;
            // 
            // TxtStreet
            // 
            this.TxtStreet.BorderRadius = 5;
            this.TxtStreet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtStreet.DefaultText = "";
            this.TxtStreet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtStreet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtStreet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtStreet.DisabledState.Parent = this.TxtStreet;
            this.TxtStreet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtStreet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtStreet.FocusedState.Parent = this.TxtStreet;
            this.TxtStreet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtStreet.ForeColor = System.Drawing.Color.Black;
            this.TxtStreet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtStreet.HoverState.Parent = this.TxtStreet;
            this.TxtStreet.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtStreet.IconLeft")));
            this.TxtStreet.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtStreet.Location = new System.Drawing.Point(8, 263);
            this.TxtStreet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.PasswordChar = '\0';
            this.TxtStreet.PlaceholderText = "Street";
            this.TxtStreet.SelectedText = "";
            this.TxtStreet.ShadowDecoration.Parent = this.TxtStreet;
            this.TxtStreet.Size = new System.Drawing.Size(384, 43);
            this.TxtStreet.TabIndex = 25;
            // 
            // TxtPostalCode
            // 
            this.TxtPostalCode.BorderRadius = 5;
            this.TxtPostalCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPostalCode.DefaultText = "";
            this.TxtPostalCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPostalCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPostalCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPostalCode.DisabledState.Parent = this.TxtPostalCode;
            this.TxtPostalCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPostalCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPostalCode.FocusedState.Parent = this.TxtPostalCode;
            this.TxtPostalCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtPostalCode.ForeColor = System.Drawing.Color.Black;
            this.TxtPostalCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPostalCode.HoverState.Parent = this.TxtPostalCode;
            this.TxtPostalCode.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtPostalCode.IconLeft")));
            this.TxtPostalCode.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtPostalCode.Location = new System.Drawing.Point(8, 314);
            this.TxtPostalCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPostalCode.Name = "TxtPostalCode";
            this.TxtPostalCode.PasswordChar = '\0';
            this.TxtPostalCode.PlaceholderText = "Postal code";
            this.TxtPostalCode.SelectedText = "";
            this.TxtPostalCode.ShadowDecoration.Parent = this.TxtPostalCode;
            this.TxtPostalCode.Size = new System.Drawing.Size(384, 43);
            this.TxtPostalCode.TabIndex = 26;
            // 
            // TxtCity
            // 
            this.TxtCity.BorderRadius = 5;
            this.TxtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCity.DefaultText = "";
            this.TxtCity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCity.DisabledState.Parent = this.TxtCity;
            this.TxtCity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCity.FocusedState.Parent = this.TxtCity;
            this.TxtCity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtCity.ForeColor = System.Drawing.Color.Black;
            this.TxtCity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCity.HoverState.Parent = this.TxtCity;
            this.TxtCity.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtCity.IconLeft")));
            this.TxtCity.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtCity.Location = new System.Drawing.Point(8, 365);
            this.TxtCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.PasswordChar = '\0';
            this.TxtCity.PlaceholderText = "City";
            this.TxtCity.SelectedText = "";
            this.TxtCity.ShadowDecoration.Parent = this.TxtCity;
            this.TxtCity.Size = new System.Drawing.Size(384, 43);
            this.TxtCity.TabIndex = 27;
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
            this.CmbGender.ItemHeight = 22;
            this.CmbGender.Items.AddRange(new object[] {
            "- Gender -",
            "Mr",
            "Ms"});
            this.CmbGender.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbGender.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbGender.ItemsAppearance.Parent = this.CmbGender;
            this.CmbGender.Location = new System.Drawing.Point(8, 212);
            this.CmbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.ShadowDecoration.Parent = this.CmbGender;
            this.CmbGender.Size = new System.Drawing.Size(382, 28);
            this.CmbGender.StartIndex = 0;
            this.CmbGender.TabIndex = 24;
            // 
            // TxtOwnerName
            // 
            this.TxtOwnerName.BorderRadius = 5;
            this.TxtOwnerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtOwnerName.DefaultText = "";
            this.TxtOwnerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtOwnerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtOwnerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtOwnerName.DisabledState.Parent = this.TxtOwnerName;
            this.TxtOwnerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtOwnerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtOwnerName.FocusedState.Parent = this.TxtOwnerName;
            this.TxtOwnerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtOwnerName.ForeColor = System.Drawing.Color.Black;
            this.TxtOwnerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtOwnerName.HoverState.Parent = this.TxtOwnerName;
            this.TxtOwnerName.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtOwnerName.IconLeft")));
            this.TxtOwnerName.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtOwnerName.Location = new System.Drawing.Point(8, 162);
            this.TxtOwnerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtOwnerName.Name = "TxtOwnerName";
            this.TxtOwnerName.PasswordChar = '\0';
            this.TxtOwnerName.PlaceholderText = "Owner name";
            this.TxtOwnerName.SelectedText = "";
            this.TxtOwnerName.ShadowDecoration.Parent = this.TxtOwnerName;
            this.TxtOwnerName.Size = new System.Drawing.Size(384, 43);
            this.TxtOwnerName.TabIndex = 23;
            // 
            // TxtCompany
            // 
            this.TxtCompany.BorderRadius = 5;
            this.TxtCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCompany.DefaultText = "";
            this.TxtCompany.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCompany.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCompany.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCompany.DisabledState.Parent = this.TxtCompany;
            this.TxtCompany.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCompany.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCompany.FocusedState.Parent = this.TxtCompany;
            this.TxtCompany.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtCompany.ForeColor = System.Drawing.Color.Black;
            this.TxtCompany.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCompany.HoverState.Parent = this.TxtCompany;
            this.TxtCompany.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtCompany.IconLeft")));
            this.TxtCompany.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtCompany.Location = new System.Drawing.Point(8, 111);
            this.TxtCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCompany.Name = "TxtCompany";
            this.TxtCompany.PasswordChar = '\0';
            this.TxtCompany.PlaceholderText = "Agency name";
            this.TxtCompany.SelectedText = "";
            this.TxtCompany.ShadowDecoration.Parent = this.TxtCompany;
            this.TxtCompany.Size = new System.Drawing.Size(384, 43);
            this.TxtCompany.TabIndex = 22;
            // 
            // DtJoinDate
            // 
            this.DtJoinDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtJoinDate.BorderRadius = 5;
            this.DtJoinDate.BorderThickness = 1;
            this.DtJoinDate.CheckedState.Parent = this.DtJoinDate;
            this.DtJoinDate.FillColor = System.Drawing.Color.White;
            this.DtJoinDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtJoinDate.HoverState.Parent = this.DtJoinDate;
            this.DtJoinDate.Location = new System.Drawing.Point(8, 60);
            this.DtJoinDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtJoinDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtJoinDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtJoinDate.Name = "DtJoinDate";
            this.DtJoinDate.ShadowDecoration.Parent = this.DtJoinDate;
            this.DtJoinDate.Size = new System.Drawing.Size(384, 43);
            this.DtJoinDate.TabIndex = 21;
            this.DtJoinDate.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
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
            this.BtnAddEdit.Location = new System.Drawing.Point(8, 669);
            this.BtnAddEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddEdit.Name = "BtnAddEdit";
            this.BtnAddEdit.ShadowDecoration.Parent = this.BtnAddEdit;
            this.BtnAddEdit.Size = new System.Drawing.Size(384, 46);
            this.BtnAddEdit.TabIndex = 35;
            this.BtnAddEdit.Text = "ADD NEW AGENCY";
            // 
            // TxtAgencyID
            // 
            this.TxtAgencyID.BorderRadius = 5;
            this.TxtAgencyID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAgencyID.DefaultText = "";
            this.TxtAgencyID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAgencyID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAgencyID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAgencyID.DisabledState.Parent = this.TxtAgencyID;
            this.TxtAgencyID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAgencyID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAgencyID.FocusedState.Parent = this.TxtAgencyID;
            this.TxtAgencyID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtAgencyID.ForeColor = System.Drawing.Color.Black;
            this.TxtAgencyID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAgencyID.HoverState.Parent = this.TxtAgencyID;
            this.TxtAgencyID.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtAgencyID.IconLeft")));
            this.TxtAgencyID.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtAgencyID.Location = new System.Drawing.Point(8, 9);
            this.TxtAgencyID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAgencyID.Name = "TxtAgencyID";
            this.TxtAgencyID.PasswordChar = '\0';
            this.TxtAgencyID.PlaceholderText = "Agency ID";
            this.TxtAgencyID.ReadOnly = true;
            this.TxtAgencyID.SelectedText = "";
            this.TxtAgencyID.ShadowDecoration.Parent = this.TxtAgencyID;
            this.TxtAgencyID.Size = new System.Drawing.Size(384, 43);
            this.TxtAgencyID.TabIndex = 20;
            // 
            // DGClientAgencies
            // 
            this.DGClientAgencies.AllowUserToAddRows = false;
            this.DGClientAgencies.AllowUserToResizeColumns = false;
            this.DGClientAgencies.AllowUserToResizeRows = false;
            this.DGClientAgencies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGClientAgencies.BackgroundColor = System.Drawing.Color.White;
            this.DGClientAgencies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGClientAgencies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(162)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGClientAgencies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGClientAgencies.ColumnHeadersHeight = 25;
            this.DGClientAgencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGClientAgencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column9,
            this.Column1,
            this.Column2,
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
            this.DGClientAgencies.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGClientAgencies.EnableHeadersVisualStyles = false;
            this.DGClientAgencies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DGClientAgencies.Location = new System.Drawing.Point(418, 57);
            this.DGClientAgencies.Margin = new System.Windows.Forms.Padding(0);
            this.DGClientAgencies.Name = "DGClientAgencies";
            this.DGClientAgencies.ReadOnly = true;
            this.DGClientAgencies.RowHeadersVisible = false;
            this.DGClientAgencies.RowHeadersWidth = 61;
            this.DGClientAgencies.RowTemplate.Height = 25;
            this.DGClientAgencies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGClientAgencies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGClientAgencies.Size = new System.Drawing.Size(852, 835);
            this.DGClientAgencies.TabIndex = 48;
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
            this.Column5.HeaderText = "AGENCY NAME";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "OWNER";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 106;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "EMAIL";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 93;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "TELEPHONE";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 137;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "TYPE";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 82;
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
            // CmbTo
            // 
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
            this.CmbTo.Location = new System.Drawing.Point(324, 9);
            this.CmbTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbTo.Name = "CmbTo";
            this.CmbTo.ShadowDecoration.Parent = this.CmbTo;
            this.CmbTo.Size = new System.Drawing.Size(296, 28);
            this.CmbTo.StartIndex = 0;
            this.CmbTo.TabIndex = 52;
            // 
            // CmbFrom
            // 
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
            this.CmbFrom.Location = new System.Drawing.Point(16, 9);
            this.CmbFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbFrom.Name = "CmbFrom";
            this.CmbFrom.ShadowDecoration.Parent = this.CmbFrom;
            this.CmbFrom.Size = new System.Drawing.Size(296, 28);
            this.CmbFrom.StartIndex = 0;
            this.CmbFrom.TabIndex = 51;
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
            this.DtFrom.Location = new System.Drawing.Point(628, 9);
            this.DtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.ShadowDecoration.Parent = this.DtFrom;
            this.DtFrom.Size = new System.Drawing.Size(286, 43);
            this.DtFrom.TabIndex = 53;
            this.DtFrom.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
            // 
            // DtTo
            // 
            this.DtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtTo.BorderRadius = 5;
            this.DtTo.BorderThickness = 1;
            this.DtTo.CheckedState.Parent = this.DtTo;
            this.DtTo.FillColor = System.Drawing.Color.White;
            this.DtTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtTo.HoverState.Parent = this.DtTo;
            this.DtTo.Location = new System.Drawing.Point(922, 9);
            this.DtTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtTo.Name = "DtTo";
            this.DtTo.ShadowDecoration.Parent = this.DtTo;
            this.DtTo.Size = new System.Drawing.Size(298, 43);
            this.DtTo.TabIndex = 54;
            this.DtTo.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(123)))), ((int)(((byte)(253)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button1.Location = new System.Drawing.Point(1227, 6);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(43, 43);
            this.guna2Button1.TabIndex = 37;
            // 
            // FrmFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 906);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.DtTo);
            this.Controls.Add(this.DtFrom);
            this.Controls.Add(this.CmbTo);
            this.Controls.Add(this.CmbFrom);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.DGClientAgencies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFlights";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGClientAgencies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox CmbStatus;
        private Guna.UI2.WinForms.Guna2ComboBox CmbAgencyType;
        private Guna.UI2.WinForms.Guna2TextBox TxtTelephone;
        private Guna.UI2.WinForms.Guna2TextBox TxtEmail;
        private Guna.UI2.WinForms.Guna2ComboBox CmbCountry;
        private Guna.UI2.WinForms.Guna2TextBox TxtStreet;
        private Guna.UI2.WinForms.Guna2TextBox TxtPostalCode;
        private Guna.UI2.WinForms.Guna2TextBox TxtCity;
        private Guna.UI2.WinForms.Guna2ComboBox CmbGender;
        private Guna.UI2.WinForms.Guna2TextBox TxtOwnerName;
        private Guna.UI2.WinForms.Guna2TextBox TxtCompany;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtJoinDate;
        private Guna.UI2.WinForms.Guna2Button BtnAddEdit;
        private Guna.UI2.WinForms.Guna2TextBox TxtAgencyID;
        private System.Windows.Forms.DataGridView DGClientAgencies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn EDIT;
        private System.Windows.Forms.DataGridViewImageColumn DEL;
        private Guna.UI2.WinForms.Guna2ComboBox CmbTo;
        private Guna.UI2.WinForms.Guna2ComboBox CmbFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtTo;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}