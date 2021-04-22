
namespace HassilBook
{
    partial class FrmSearchEngine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchEngine));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlButtonHolder = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnFindBookings = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFindFlights = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.guna2Panel1.SuspendLayout();
            this.PnlButtonHolder.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.guna2Panel1.Controls.Add(this.metroTabControl1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.PnlButtonHolder);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 63);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 3;
            this.guna2Panel1.ShadowDecoration.Depth = 5;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(470, 754);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "TAKE A BREAK!";
            // 
            // PnlButtonHolder
            // 
            this.PnlButtonHolder.BackColor = System.Drawing.Color.White;
            this.PnlButtonHolder.Controls.Add(this.BtnFindBookings);
            this.PnlButtonHolder.Controls.Add(this.BtnFindFlights);
            this.PnlButtonHolder.Location = new System.Drawing.Point(0, 88);
            this.PnlButtonHolder.Name = "PnlButtonHolder";
            this.PnlButtonHolder.ShadowDecoration.BorderRadius = 3;
            this.PnlButtonHolder.ShadowDecoration.Depth = 5;
            this.PnlButtonHolder.ShadowDecoration.Enabled = true;
            this.PnlButtonHolder.ShadowDecoration.Parent = this.PnlButtonHolder;
            this.PnlButtonHolder.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.PnlButtonHolder.Size = new System.Drawing.Size(470, 69);
            this.PnlButtonHolder.TabIndex = 0;
            // 
            // BtnFindBookings
            // 
            this.BtnFindBookings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnFindBookings.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnFindBookings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnFindBookings.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnFindBookings.CheckedState.Parent = this.BtnFindBookings;
            this.BtnFindBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFindBookings.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnFindBookings.CustomImages.CheckedImage")));
            this.BtnFindBookings.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("BtnFindBookings.CustomImages.Image")));
            this.BtnFindBookings.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnFindBookings.CustomImages.ImageOffset = new System.Drawing.Point(5, 0);
            this.BtnFindBookings.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnFindBookings.CustomImages.Parent = this.BtnFindBookings;
            this.BtnFindBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFindBookings.FillColor = System.Drawing.Color.White;
            this.BtnFindBookings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(186)))));
            this.BtnFindBookings.HoverState.Parent = this.BtnFindBookings;
            this.BtnFindBookings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnFindBookings.ImageSize = new System.Drawing.Size(0, 0);
            this.BtnFindBookings.Location = new System.Drawing.Point(226, 0);
            this.BtnFindBookings.Name = "BtnFindBookings";
            this.BtnFindBookings.PressedColor = System.Drawing.Color.White;
            this.BtnFindBookings.ShadowDecoration.Enabled = true;
            this.BtnFindBookings.ShadowDecoration.Parent = this.BtnFindBookings;
            this.BtnFindBookings.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.BtnFindBookings.Size = new System.Drawing.Size(244, 69);
            this.BtnFindBookings.TabIndex = 2;
            this.BtnFindBookings.Text = "SEARCH BOOKING";
            this.BtnFindBookings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnFindBookings.TextOffset = new System.Drawing.Point(25, 0);
            this.BtnFindBookings.Click += new System.EventHandler(this.BtnFindBookings_Click);
            // 
            // BtnFindFlights
            // 
            this.BtnFindFlights.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnFindFlights.Checked = true;
            this.BtnFindFlights.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnFindFlights.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnFindFlights.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnFindFlights.CheckedState.Parent = this.BtnFindFlights;
            this.BtnFindFlights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFindFlights.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnFindFlights.CustomImages.CheckedImage")));
            this.BtnFindFlights.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("BtnFindFlights.CustomImages.Image")));
            this.BtnFindFlights.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnFindFlights.CustomImages.ImageOffset = new System.Drawing.Point(5, 0);
            this.BtnFindFlights.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnFindFlights.CustomImages.Parent = this.BtnFindFlights;
            this.BtnFindFlights.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnFindFlights.FillColor = System.Drawing.Color.White;
            this.BtnFindFlights.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindFlights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(186)))));
            this.BtnFindFlights.HoverState.Parent = this.BtnFindFlights;
            this.BtnFindFlights.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnFindFlights.ImageSize = new System.Drawing.Size(0, 0);
            this.BtnFindFlights.Location = new System.Drawing.Point(0, 0);
            this.BtnFindFlights.Name = "BtnFindFlights";
            this.BtnFindFlights.PressedColor = System.Drawing.Color.White;
            this.BtnFindFlights.ShadowDecoration.Enabled = true;
            this.BtnFindFlights.ShadowDecoration.Parent = this.BtnFindFlights;
            this.BtnFindFlights.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.BtnFindFlights.Size = new System.Drawing.Size(226, 69);
            this.BtnFindFlights.TabIndex = 1;
            this.BtnFindFlights.Text = "FIND FLIGHTS";
            this.BtnFindFlights.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnFindFlights.TextOffset = new System.Drawing.Point(25, 0);
            this.BtnFindFlights.Click += new System.EventHandler(this.BtnFindFlights_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.pictureBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 3;
            this.guna2Panel2.ShadowDecoration.Depth = 5;
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.guna2Panel2.Size = new System.Drawing.Size(1156, 63);
            this.guna2Panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 163);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(467, 477);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(259, 107);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(459, 435);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // FrmSearchEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1156, 817);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "FrmSearchEngine";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.PnlButtonHolder.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel PnlButtonHolder;
        private Guna.UI2.WinForms.Guna2Button BtnFindFlights;
        private Guna.UI2.WinForms.Guna2Button BtnFindBookings;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
    }
}