
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
            this.PnlButtonHolder = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnDepartments = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.PnlButtonHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.guna2Panel1.Controls.Add(this.PnlButtonHolder);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 3;
            this.guna2Panel1.ShadowDecoration.Depth = 5;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(469, 735);
            this.guna2Panel1.TabIndex = 0;
            // 
            // PnlButtonHolder
            // 
            this.PnlButtonHolder.BackColor = System.Drawing.Color.White;
            this.PnlButtonHolder.Controls.Add(this.guna2Button1);
            this.PnlButtonHolder.Controls.Add(this.BtnDepartments);
            this.PnlButtonHolder.Location = new System.Drawing.Point(0, 87);
            this.PnlButtonHolder.Name = "PnlButtonHolder";
            this.PnlButtonHolder.ShadowDecoration.BorderRadius = 3;
            this.PnlButtonHolder.ShadowDecoration.Depth = 5;
            this.PnlButtonHolder.ShadowDecoration.Enabled = true;
            this.PnlButtonHolder.ShadowDecoration.Parent = this.PnlButtonHolder;
            this.PnlButtonHolder.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.PnlButtonHolder.Size = new System.Drawing.Size(469, 82);
            this.PnlButtonHolder.TabIndex = 0;
            // 
            // BtnDepartments
            // 
            this.BtnDepartments.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnDepartments.Checked = true;
            this.BtnDepartments.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnDepartments.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnDepartments.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnDepartments.CheckedState.Parent = this.BtnDepartments;
            this.BtnDepartments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDepartments.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnDepartments.CustomImages.CheckedImage")));
            this.BtnDepartments.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("BtnDepartments.CustomImages.Image")));
            this.BtnDepartments.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDepartments.CustomImages.ImageOffset = new System.Drawing.Point(5, 0);
            this.BtnDepartments.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnDepartments.CustomImages.Parent = this.BtnDepartments;
            this.BtnDepartments.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDepartments.FillColor = System.Drawing.Color.White;
            this.BtnDepartments.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDepartments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(186)))));
            this.BtnDepartments.HoverState.Parent = this.BtnDepartments;
            this.BtnDepartments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDepartments.ImageSize = new System.Drawing.Size(0, 0);
            this.BtnDepartments.Location = new System.Drawing.Point(0, 0);
            this.BtnDepartments.Name = "BtnDepartments";
            this.BtnDepartments.PressedColor = System.Drawing.Color.White;
            this.BtnDepartments.ShadowDecoration.Enabled = true;
            this.BtnDepartments.ShadowDecoration.Parent = this.BtnDepartments;
            this.BtnDepartments.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.BtnDepartments.Size = new System.Drawing.Size(227, 82);
            this.BtnDepartments.TabIndex = 1;
            this.BtnDepartments.Text = "FIND FLIGHTS";
            this.BtnDepartments.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDepartments.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // guna2Button1
            // 
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("guna2Button1.CustomImages.CheckedImage")));
            this.guna2Button1.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.CustomImages.Image")));
            this.guna2Button1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.CustomImages.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2Button1.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(186)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2Button1.Location = new System.Drawing.Point(227, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.White;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.guna2Button1.Size = new System.Drawing.Size(242, 82);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "SEARCH BOOKING";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextOffset = new System.Drawing.Point(25, 0);
            // 
            // FrmSearchEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1006, 735);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FrmSearchEngine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.PnlButtonHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel PnlButtonHolder;
        private Guna.UI2.WinForms.Guna2Button BtnDepartments;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}