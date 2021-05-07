
namespace HassilBook
{
    partial class FrmLogin
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.LoginTabForm = new Bunifu.UI.WinForms.BunifuPages();
            this.AirlineLoginPage = new System.Windows.Forms.TabPage();
            this.TxtOfficeID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAirPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnAirLogin = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAirExit = new Guna.UI2.WinForms.Guna2Button();
            this.TxtAirUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.AgencyLoginPage = new System.Windows.Forms.TabPage();
            this.TxtAgencyID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAgencyPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnLoginAgency = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAgencyExit = new Guna.UI2.WinForms.Guna2Button();
            this.TxtAgencyUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.PnlButtonHolder = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnAgencyLogin = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAirlineLogin = new Guna.UI2.WinForms.Guna2Button();
            this.LoginTabForm.SuspendLayout();
            this.AirlineLoginPage.SuspendLayout();
            this.AgencyLoginPage.SuspendLayout();
            this.PnlButtonHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTabForm
            // 
            this.LoginTabForm.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.LoginTabForm.AllowTransitions = true;
            this.LoginTabForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginTabForm.Controls.Add(this.AirlineLoginPage);
            this.LoginTabForm.Controls.Add(this.AgencyLoginPage);
            this.LoginTabForm.Location = new System.Drawing.Point(242, 209);
            this.LoginTabForm.Multiline = true;
            this.LoginTabForm.Name = "LoginTabForm";
            this.LoginTabForm.Page = this.AgencyLoginPage;
            this.LoginTabForm.PageIndex = 1;
            this.LoginTabForm.PageName = "AgencyLoginPage";
            this.LoginTabForm.PageTitle = "tabPage2";
            this.LoginTabForm.SelectedIndex = 0;
            this.LoginTabForm.Size = new System.Drawing.Size(482, 388);
            this.LoginTabForm.TabIndex = 1;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LoginTabForm.Transition = animation1;
            this.LoginTabForm.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // AirlineLoginPage
            // 
            this.AirlineLoginPage.Controls.Add(this.TxtOfficeID);
            this.AirlineLoginPage.Controls.Add(this.label1);
            this.AirlineLoginPage.Controls.Add(this.TxtAirPassword);
            this.AirlineLoginPage.Controls.Add(this.BtnAirLogin);
            this.AirlineLoginPage.Controls.Add(this.BtnAirExit);
            this.AirlineLoginPage.Controls.Add(this.TxtAirUsername);
            this.AirlineLoginPage.Location = new System.Drawing.Point(4, 4);
            this.AirlineLoginPage.Name = "AirlineLoginPage";
            this.AirlineLoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.AirlineLoginPage.Size = new System.Drawing.Size(474, 355);
            this.AirlineLoginPage.TabIndex = 0;
            this.AirlineLoginPage.Text = "tabPage1";
            this.AirlineLoginPage.UseVisualStyleBackColor = true;
            // 
            // TxtOfficeID
            // 
            this.TxtOfficeID.BorderRadius = 5;
            this.TxtOfficeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtOfficeID.DefaultText = "AP00001";
            this.TxtOfficeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtOfficeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtOfficeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtOfficeID.DisabledState.Parent = this.TxtOfficeID;
            this.TxtOfficeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtOfficeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtOfficeID.FocusedState.Parent = this.TxtOfficeID;
            this.TxtOfficeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtOfficeID.ForeColor = System.Drawing.Color.Black;
            this.TxtOfficeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtOfficeID.HoverState.Parent = this.TxtOfficeID;
            this.TxtOfficeID.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtOfficeID.IconLeft")));
            this.TxtOfficeID.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtOfficeID.Location = new System.Drawing.Point(32, 77);
            this.TxtOfficeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtOfficeID.Name = "TxtOfficeID";
            this.TxtOfficeID.PasswordChar = '\0';
            this.TxtOfficeID.PlaceholderText = "Your office ID";
            this.TxtOfficeID.SelectedText = "";
            this.TxtOfficeID.SelectionStart = 7;
            this.TxtOfficeID.ShadowDecoration.Parent = this.TxtOfficeID;
            this.TxtOfficeID.Size = new System.Drawing.Size(414, 43);
            this.TxtOfficeID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "AIRLINE LOGIN PAGE";
            // 
            // TxtAirPassword
            // 
            this.TxtAirPassword.BorderRadius = 5;
            this.TxtAirPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAirPassword.DefaultText = "hassilbook";
            this.TxtAirPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAirPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAirPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAirPassword.DisabledState.Parent = this.TxtAirPassword;
            this.TxtAirPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAirPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAirPassword.FocusedState.Parent = this.TxtAirPassword;
            this.TxtAirPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtAirPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtAirPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAirPassword.HoverState.Parent = this.TxtAirPassword;
            this.TxtAirPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtAirPassword.IconLeft")));
            this.TxtAirPassword.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtAirPassword.Location = new System.Drawing.Point(32, 189);
            this.TxtAirPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAirPassword.Name = "TxtAirPassword";
            this.TxtAirPassword.PasswordChar = '\0';
            this.TxtAirPassword.PlaceholderText = "Your password";
            this.TxtAirPassword.SelectedText = "";
            this.TxtAirPassword.SelectionStart = 10;
            this.TxtAirPassword.ShadowDecoration.Parent = this.TxtAirPassword;
            this.TxtAirPassword.Size = new System.Drawing.Size(414, 43);
            this.TxtAirPassword.TabIndex = 3;
            this.TxtAirPassword.UseSystemPasswordChar = true;
            // 
            // BtnAirLogin
            // 
            this.BtnAirLogin.BorderRadius = 5;
            this.BtnAirLogin.CheckedState.Parent = this.BtnAirLogin;
            this.BtnAirLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAirLogin.CustomImages.Parent = this.BtnAirLogin;
            this.BtnAirLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.BtnAirLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAirLogin.ForeColor = System.Drawing.Color.White;
            this.BtnAirLogin.HoverState.Parent = this.BtnAirLogin;
            this.BtnAirLogin.Location = new System.Drawing.Point(32, 245);
            this.BtnAirLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAirLogin.Name = "BtnAirLogin";
            this.BtnAirLogin.ShadowDecoration.Parent = this.BtnAirLogin;
            this.BtnAirLogin.Size = new System.Drawing.Size(414, 43);
            this.BtnAirLogin.TabIndex = 4;
            this.BtnAirLogin.Text = "LOG IN";
            this.BtnAirLogin.Click += new System.EventHandler(this.BtnAirLogin_Click);
            // 
            // BtnAirExit
            // 
            this.BtnAirExit.BorderRadius = 5;
            this.BtnAirExit.CheckedState.Parent = this.BtnAirExit;
            this.BtnAirExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAirExit.CustomImages.Parent = this.BtnAirExit;
            this.BtnAirExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAirExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAirExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.BtnAirExit.HoverState.Parent = this.BtnAirExit;
            this.BtnAirExit.Location = new System.Drawing.Point(32, 302);
            this.BtnAirExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAirExit.Name = "BtnAirExit";
            this.BtnAirExit.ShadowDecoration.Parent = this.BtnAirExit;
            this.BtnAirExit.Size = new System.Drawing.Size(414, 43);
            this.BtnAirExit.TabIndex = 5;
            this.BtnAirExit.Text = "E&XIT";
            // 
            // TxtAirUsername
            // 
            this.TxtAirUsername.BorderRadius = 5;
            this.TxtAirUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAirUsername.DefaultText = "abdi";
            this.TxtAirUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAirUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAirUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAirUsername.DisabledState.Parent = this.TxtAirUsername;
            this.TxtAirUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAirUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAirUsername.FocusedState.Parent = this.TxtAirUsername;
            this.TxtAirUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtAirUsername.ForeColor = System.Drawing.Color.Black;
            this.TxtAirUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAirUsername.HoverState.Parent = this.TxtAirUsername;
            this.TxtAirUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtAirUsername.IconLeft")));
            this.TxtAirUsername.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtAirUsername.Location = new System.Drawing.Point(32, 132);
            this.TxtAirUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAirUsername.Name = "TxtAirUsername";
            this.TxtAirUsername.PasswordChar = '\0';
            this.TxtAirUsername.PlaceholderText = "Your email or username";
            this.TxtAirUsername.SelectedText = "";
            this.TxtAirUsername.SelectionStart = 4;
            this.TxtAirUsername.ShadowDecoration.Parent = this.TxtAirUsername;
            this.TxtAirUsername.Size = new System.Drawing.Size(414, 43);
            this.TxtAirUsername.TabIndex = 2;
            // 
            // AgencyLoginPage
            // 
            this.AgencyLoginPage.Controls.Add(this.TxtAgencyID);
            this.AgencyLoginPage.Controls.Add(this.label2);
            this.AgencyLoginPage.Controls.Add(this.TxtAgencyPassword);
            this.AgencyLoginPage.Controls.Add(this.BtnLoginAgency);
            this.AgencyLoginPage.Controls.Add(this.BtnAgencyExit);
            this.AgencyLoginPage.Controls.Add(this.TxtAgencyUsername);
            this.AgencyLoginPage.Location = new System.Drawing.Point(4, 4);
            this.AgencyLoginPage.Name = "AgencyLoginPage";
            this.AgencyLoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.AgencyLoginPage.Size = new System.Drawing.Size(474, 355);
            this.AgencyLoginPage.TabIndex = 1;
            this.AgencyLoginPage.Text = "tabPage2";
            this.AgencyLoginPage.UseVisualStyleBackColor = true;
            // 
            // TxtAgencyID
            // 
            this.TxtAgencyID.BorderRadius = 5;
            this.TxtAgencyID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAgencyID.DefaultText = "AG0001";
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
            this.TxtAgencyID.Location = new System.Drawing.Point(32, 77);
            this.TxtAgencyID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAgencyID.Name = "TxtAgencyID";
            this.TxtAgencyID.PasswordChar = '\0';
            this.TxtAgencyID.PlaceholderText = "Your agency ID";
            this.TxtAgencyID.SelectedText = "";
            this.TxtAgencyID.SelectionStart = 6;
            this.TxtAgencyID.ShadowDecoration.Parent = this.TxtAgencyID;
            this.TxtAgencyID.Size = new System.Drawing.Size(414, 43);
            this.TxtAgencyID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(34, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 30);
            this.label2.TabIndex = 34;
            this.label2.Text = "AGENCY LOGIN PAGE";
            // 
            // TxtAgencyPassword
            // 
            this.TxtAgencyPassword.BorderRadius = 5;
            this.TxtAgencyPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAgencyPassword.DefaultText = "123456";
            this.TxtAgencyPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAgencyPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAgencyPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAgencyPassword.DisabledState.Parent = this.TxtAgencyPassword;
            this.TxtAgencyPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAgencyPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAgencyPassword.FocusedState.Parent = this.TxtAgencyPassword;
            this.TxtAgencyPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtAgencyPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtAgencyPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAgencyPassword.HoverState.Parent = this.TxtAgencyPassword;
            this.TxtAgencyPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtAgencyPassword.IconLeft")));
            this.TxtAgencyPassword.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtAgencyPassword.Location = new System.Drawing.Point(32, 188);
            this.TxtAgencyPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAgencyPassword.Name = "TxtAgencyPassword";
            this.TxtAgencyPassword.PasswordChar = '\0';
            this.TxtAgencyPassword.PlaceholderText = "Your password";
            this.TxtAgencyPassword.SelectedText = "";
            this.TxtAgencyPassword.SelectionStart = 6;
            this.TxtAgencyPassword.ShadowDecoration.Parent = this.TxtAgencyPassword;
            this.TxtAgencyPassword.Size = new System.Drawing.Size(414, 43);
            this.TxtAgencyPassword.TabIndex = 3;
            this.TxtAgencyPassword.UseSystemPasswordChar = true;
            // 
            // BtnLoginAgency
            // 
            this.BtnLoginAgency.BorderRadius = 5;
            this.BtnLoginAgency.CheckedState.Parent = this.BtnLoginAgency;
            this.BtnLoginAgency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoginAgency.CustomImages.Parent = this.BtnLoginAgency;
            this.BtnLoginAgency.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.BtnLoginAgency.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginAgency.ForeColor = System.Drawing.Color.White;
            this.BtnLoginAgency.HoverState.Parent = this.BtnLoginAgency;
            this.BtnLoginAgency.Location = new System.Drawing.Point(32, 245);
            this.BtnLoginAgency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLoginAgency.Name = "BtnLoginAgency";
            this.BtnLoginAgency.ShadowDecoration.Parent = this.BtnLoginAgency;
            this.BtnLoginAgency.Size = new System.Drawing.Size(414, 43);
            this.BtnLoginAgency.TabIndex = 4;
            this.BtnLoginAgency.Text = "LOG IN";
            this.BtnLoginAgency.Click += new System.EventHandler(this.BtnLoginAgency_Click);
            // 
            // BtnAgencyExit
            // 
            this.BtnAgencyExit.BorderRadius = 5;
            this.BtnAgencyExit.CheckedState.Parent = this.BtnAgencyExit;
            this.BtnAgencyExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgencyExit.CustomImages.Parent = this.BtnAgencyExit;
            this.BtnAgencyExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAgencyExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgencyExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.BtnAgencyExit.HoverState.Parent = this.BtnAgencyExit;
            this.BtnAgencyExit.Location = new System.Drawing.Point(32, 302);
            this.BtnAgencyExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAgencyExit.Name = "BtnAgencyExit";
            this.BtnAgencyExit.ShadowDecoration.Parent = this.BtnAgencyExit;
            this.BtnAgencyExit.Size = new System.Drawing.Size(414, 43);
            this.BtnAgencyExit.TabIndex = 5;
            this.BtnAgencyExit.Text = "E&XIT";
            // 
            // TxtAgencyUsername
            // 
            this.TxtAgencyUsername.BorderRadius = 5;
            this.TxtAgencyUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAgencyUsername.DefaultText = "info@hassildesk.com";
            this.TxtAgencyUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAgencyUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAgencyUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAgencyUsername.DisabledState.Parent = this.TxtAgencyUsername;
            this.TxtAgencyUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAgencyUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAgencyUsername.FocusedState.Parent = this.TxtAgencyUsername;
            this.TxtAgencyUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtAgencyUsername.ForeColor = System.Drawing.Color.Black;
            this.TxtAgencyUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAgencyUsername.HoverState.Parent = this.TxtAgencyUsername;
            this.TxtAgencyUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtAgencyUsername.IconLeft")));
            this.TxtAgencyUsername.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtAgencyUsername.Location = new System.Drawing.Point(32, 132);
            this.TxtAgencyUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAgencyUsername.Name = "TxtAgencyUsername";
            this.TxtAgencyUsername.PasswordChar = '\0';
            this.TxtAgencyUsername.PlaceholderText = "Your email or username";
            this.TxtAgencyUsername.SelectedText = "";
            this.TxtAgencyUsername.SelectionStart = 19;
            this.TxtAgencyUsername.ShadowDecoration.Parent = this.TxtAgencyUsername;
            this.TxtAgencyUsername.Size = new System.Drawing.Size(414, 43);
            this.TxtAgencyUsername.TabIndex = 2;
            // 
            // PnlButtonHolder
            // 
            this.PnlButtonHolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlButtonHolder.BackColor = System.Drawing.Color.White;
            this.PnlButtonHolder.Controls.Add(this.BtnAgencyLogin);
            this.PnlButtonHolder.Controls.Add(this.BtnAirlineLogin);
            this.PnlButtonHolder.Location = new System.Drawing.Point(242, 140);
            this.PnlButtonHolder.Name = "PnlButtonHolder";
            this.PnlButtonHolder.ShadowDecoration.BorderRadius = 3;
            this.PnlButtonHolder.ShadowDecoration.Depth = 5;
            this.PnlButtonHolder.ShadowDecoration.Enabled = true;
            this.PnlButtonHolder.ShadowDecoration.Parent = this.PnlButtonHolder;
            this.PnlButtonHolder.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.PnlButtonHolder.Size = new System.Drawing.Size(482, 69);
            this.PnlButtonHolder.TabIndex = 2;
            // 
            // BtnAgencyLogin
            // 
            this.BtnAgencyLogin.BackColor = System.Drawing.Color.White;
            this.BtnAgencyLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnAgencyLogin.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnAgencyLogin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnAgencyLogin.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnAgencyLogin.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgencyLogin.CheckedState.Image")));
            this.BtnAgencyLogin.CheckedState.Parent = this.BtnAgencyLogin;
            this.BtnAgencyLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgencyLogin.CustomImages.Parent = this.BtnAgencyLogin;
            this.BtnAgencyLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAgencyLogin.FillColor = System.Drawing.Color.White;
            this.BtnAgencyLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnAgencyLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(186)))));
            this.BtnAgencyLogin.HoverState.Parent = this.BtnAgencyLogin;
            this.BtnAgencyLogin.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgencyLogin.Image")));
            this.BtnAgencyLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAgencyLogin.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnAgencyLogin.Location = new System.Drawing.Point(226, 0);
            this.BtnAgencyLogin.Name = "BtnAgencyLogin";
            this.BtnAgencyLogin.ShadowDecoration.Parent = this.BtnAgencyLogin;
            this.BtnAgencyLogin.Size = new System.Drawing.Size(256, 69);
            this.BtnAgencyLogin.TabIndex = 3;
            this.BtnAgencyLogin.Text = "AGENCY LOGIN";
            this.BtnAgencyLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAgencyLogin.TextOffset = new System.Drawing.Point(5, 0);
            this.BtnAgencyLogin.Click += new System.EventHandler(this.BtnAgencyLogin_Click);
            // 
            // BtnAirlineLogin
            // 
            this.BtnAirlineLogin.BackColor = System.Drawing.Color.White;
            this.BtnAirlineLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnAirlineLogin.Checked = true;
            this.BtnAirlineLogin.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnAirlineLogin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnAirlineLogin.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnAirlineLogin.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("BtnAirlineLogin.CheckedState.Image")));
            this.BtnAirlineLogin.CheckedState.Parent = this.BtnAirlineLogin;
            this.BtnAirlineLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAirlineLogin.CustomImages.Parent = this.BtnAirlineLogin;
            this.BtnAirlineLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAirlineLogin.FillColor = System.Drawing.Color.White;
            this.BtnAirlineLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnAirlineLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(186)))));
            this.BtnAirlineLogin.HoverState.Parent = this.BtnAirlineLogin;
            this.BtnAirlineLogin.Image = ((System.Drawing.Image)(resources.GetObject("BtnAirlineLogin.Image")));
            this.BtnAirlineLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAirlineLogin.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnAirlineLogin.Location = new System.Drawing.Point(0, 0);
            this.BtnAirlineLogin.Name = "BtnAirlineLogin";
            this.BtnAirlineLogin.ShadowDecoration.Parent = this.BtnAirlineLogin;
            this.BtnAirlineLogin.Size = new System.Drawing.Size(226, 69);
            this.BtnAirlineLogin.TabIndex = 4;
            this.BtnAirlineLogin.Text = "AIRLINE LOGIN";
            this.BtnAirlineLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAirlineLogin.TextOffset = new System.Drawing.Point(5, 0);
            this.BtnAirlineLogin.Click += new System.EventHandler(this.BtnAirlineLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(982, 749);
            this.Controls.Add(this.PnlButtonHolder);
            this.Controls.Add(this.LoginTabForm);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.LoginTabForm.ResumeLayout(false);
            this.AirlineLoginPage.ResumeLayout(false);
            this.AirlineLoginPage.PerformLayout();
            this.AgencyLoginPage.ResumeLayout(false);
            this.AgencyLoginPage.PerformLayout();
            this.PnlButtonHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPages LoginTabForm;
        private System.Windows.Forms.TabPage AirlineLoginPage;
        private System.Windows.Forms.TabPage AgencyLoginPage;
        private Guna.UI2.WinForms.Guna2Panel PnlButtonHolder;
        private Guna.UI2.WinForms.Guna2TextBox TxtOfficeID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtAirPassword;
        private Guna.UI2.WinForms.Guna2Button BtnAirLogin;
        private Guna.UI2.WinForms.Guna2Button BtnAirExit;
        private Guna.UI2.WinForms.Guna2TextBox TxtAirUsername;
        private Guna.UI2.WinForms.Guna2TextBox TxtAgencyID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtAgencyPassword;
        private Guna.UI2.WinForms.Guna2Button BtnLoginAgency;
        private Guna.UI2.WinForms.Guna2Button BtnAgencyExit;
        private Guna.UI2.WinForms.Guna2TextBox TxtAgencyUsername;
        private Guna.UI2.WinForms.Guna2Button BtnAgencyLogin;
        private Guna.UI2.WinForms.Guna2Button BtnAirlineLogin;
    }
}