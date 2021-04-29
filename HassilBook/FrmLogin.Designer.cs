﻿
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
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSearchFlight = new Guna.UI2.WinForms.Guna2Button();
            this.TxtFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.AgencyLoginPage = new System.Windows.Forms.TabPage();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.LoginTabForm.Location = new System.Drawing.Point(161, 136);
            this.LoginTabForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginTabForm.Multiline = true;
            this.LoginTabForm.Name = "LoginTabForm";
            this.LoginTabForm.Page = this.AgencyLoginPage;
            this.LoginTabForm.PageIndex = 1;
            this.LoginTabForm.PageName = "AgencyLoginPage";
            this.LoginTabForm.PageTitle = "tabPage2";
            this.LoginTabForm.SelectedIndex = 0;
            this.LoginTabForm.Size = new System.Drawing.Size(321, 252);
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
            this.AirlineLoginPage.Controls.Add(this.guna2TextBox2);
            this.AirlineLoginPage.Controls.Add(this.label1);
            this.AirlineLoginPage.Controls.Add(this.guna2TextBox1);
            this.AirlineLoginPage.Controls.Add(this.guna2Button1);
            this.AirlineLoginPage.Controls.Add(this.BtnSearchFlight);
            this.AirlineLoginPage.Controls.Add(this.TxtFrom);
            this.AirlineLoginPage.Location = new System.Drawing.Point(4, 4);
            this.AirlineLoginPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AirlineLoginPage.Name = "AirlineLoginPage";
            this.AirlineLoginPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AirlineLoginPage.Size = new System.Drawing.Size(313, 226);
            this.AirlineLoginPage.TabIndex = 0;
            this.AirlineLoginPage.Text = "tabPage1";
            this.AirlineLoginPage.UseVisualStyleBackColor = true;
            // 
            // guna2TextBox2
            // 
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
            this.guna2TextBox2.Location = new System.Drawing.Point(21, 50);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "OFFICE ID";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(276, 28);
            this.guna2TextBox2.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "AIRLINE LOGIN PAGE";
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
            this.guna2TextBox1.Location = new System.Drawing.Point(21, 123);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "YOUR PASSWORD";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(276, 28);
            this.guna2TextBox1.TabIndex = 33;
            this.guna2TextBox1.UseSystemPasswordChar = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(21, 159);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(276, 28);
            this.guna2Button1.TabIndex = 32;
            this.guna2Button1.Text = "LOG IN";
            // 
            // BtnSearchFlight
            // 
            this.BtnSearchFlight.BorderRadius = 5;
            this.BtnSearchFlight.CheckedState.Parent = this.BtnSearchFlight;
            this.BtnSearchFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchFlight.CustomImages.Parent = this.BtnSearchFlight;
            this.BtnSearchFlight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSearchFlight.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.BtnSearchFlight.HoverState.Parent = this.BtnSearchFlight;
            this.BtnSearchFlight.Location = new System.Drawing.Point(21, 196);
            this.BtnSearchFlight.Name = "BtnSearchFlight";
            this.BtnSearchFlight.ShadowDecoration.Parent = this.BtnSearchFlight;
            this.BtnSearchFlight.Size = new System.Drawing.Size(276, 28);
            this.BtnSearchFlight.TabIndex = 31;
            this.BtnSearchFlight.Text = "E&XIT";
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
            this.TxtFrom.Location = new System.Drawing.Point(21, 86);
            this.TxtFrom.Name = "TxtFrom";
            this.TxtFrom.PasswordChar = '\0';
            this.TxtFrom.PlaceholderText = "YOUR EMAIL OR USERNAME";
            this.TxtFrom.SelectedText = "";
            this.TxtFrom.ShadowDecoration.Parent = this.TxtFrom;
            this.TxtFrom.Size = new System.Drawing.Size(276, 28);
            this.TxtFrom.TabIndex = 30;
            // 
            // AgencyLoginPage
            // 
            this.AgencyLoginPage.Controls.Add(this.guna2TextBox3);
            this.AgencyLoginPage.Controls.Add(this.label2);
            this.AgencyLoginPage.Controls.Add(this.guna2TextBox4);
            this.AgencyLoginPage.Controls.Add(this.guna2Button2);
            this.AgencyLoginPage.Controls.Add(this.guna2Button3);
            this.AgencyLoginPage.Controls.Add(this.guna2TextBox5);
            this.AgencyLoginPage.Location = new System.Drawing.Point(4, 4);
            this.AgencyLoginPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AgencyLoginPage.Name = "AgencyLoginPage";
            this.AgencyLoginPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AgencyLoginPage.Size = new System.Drawing.Size(313, 226);
            this.AgencyLoginPage.TabIndex = 1;
            this.AgencyLoginPage.Text = "tabPage2";
            this.AgencyLoginPage.UseVisualStyleBackColor = true;
            // 
            // guna2TextBox3
            // 
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
            this.guna2TextBox3.Location = new System.Drawing.Point(21, 50);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "OFFICE ID";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.ShadowDecoration.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Size = new System.Drawing.Size(276, 28);
            this.guna2TextBox3.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "AGENCY LOGIN PAGE";
            // 
            // guna2TextBox4
            // 
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
            this.guna2TextBox4.Location = new System.Drawing.Point(21, 122);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "YOUR PASSWORD";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.ShadowDecoration.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Size = new System.Drawing.Size(276, 28);
            this.guna2TextBox4.TabIndex = 33;
            this.guna2TextBox4.UseSystemPasswordChar = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(21, 159);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(276, 28);
            this.guna2Button2.TabIndex = 32;
            this.guna2Button2.Text = "LOG IN";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(21, 196);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(276, 28);
            this.guna2Button3.TabIndex = 31;
            this.guna2Button3.Text = "E&XIT";
            // 
            // guna2TextBox5
            // 
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
            this.guna2TextBox5.Location = new System.Drawing.Point(21, 86);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderText = "YOUR EMAIL OR USERNAME";
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.ShadowDecoration.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Size = new System.Drawing.Size(276, 28);
            this.guna2TextBox5.TabIndex = 30;
            // 
            // PnlButtonHolder
            // 
            this.PnlButtonHolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlButtonHolder.BackColor = System.Drawing.Color.White;
            this.PnlButtonHolder.Controls.Add(this.BtnAgencyLogin);
            this.PnlButtonHolder.Controls.Add(this.BtnAirlineLogin);
            this.PnlButtonHolder.Location = new System.Drawing.Point(161, 91);
            this.PnlButtonHolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PnlButtonHolder.Name = "PnlButtonHolder";
            this.PnlButtonHolder.ShadowDecoration.BorderRadius = 3;
            this.PnlButtonHolder.ShadowDecoration.Depth = 5;
            this.PnlButtonHolder.ShadowDecoration.Enabled = true;
            this.PnlButtonHolder.ShadowDecoration.Parent = this.PnlButtonHolder;
            this.PnlButtonHolder.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.PnlButtonHolder.Size = new System.Drawing.Size(321, 45);
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
            this.BtnAgencyLogin.Location = new System.Drawing.Point(151, 0);
            this.BtnAgencyLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAgencyLogin.Name = "BtnAgencyLogin";
            this.BtnAgencyLogin.ShadowDecoration.Parent = this.BtnAgencyLogin;
            this.BtnAgencyLogin.Size = new System.Drawing.Size(170, 45);
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
            this.BtnAirlineLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAirlineLogin.Name = "BtnAirlineLogin";
            this.BtnAirlineLogin.ShadowDecoration.Parent = this.BtnAirlineLogin;
            this.BtnAirlineLogin.Size = new System.Drawing.Size(151, 45);
            this.BtnAirlineLogin.TabIndex = 4;
            this.BtnAirlineLogin.Text = "AIRLINE LOGIN";
            this.BtnAirlineLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAirlineLogin.TextOffset = new System.Drawing.Point(5, 0);
            this.BtnAirlineLogin.Click += new System.EventHandler(this.BtnAirlineLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(173)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(655, 487);
            this.Controls.Add(this.PnlButtonHolder);
            this.Controls.Add(this.LoginTabForm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button BtnSearchFlight;
        private Guna.UI2.WinForms.Guna2TextBox TxtFrom;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Guna.UI2.WinForms.Guna2Button BtnAgencyLogin;
        private Guna.UI2.WinForms.Guna2Button BtnAirlineLogin;
    }
}