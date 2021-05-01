
namespace HassilBook
{
    partial class FrmAddEditDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditDepartment));
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.CmbManager = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtDepartment = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtDepartmentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnAddEdit = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.CmbManager);
            this.bunifuGroupBox1.Controls.Add(this.TxtDepartment);
            this.bunifuGroupBox1.Controls.Add(this.TxtDepartmentID);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(5, 3);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(296, 135);
            this.bunifuGroupBox1.TabIndex = 35;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Department details";
            // 
            // CmbManager
            // 
            this.CmbManager.BackColor = System.Drawing.Color.Transparent;
            this.CmbManager.BorderRadius = 5;
            this.CmbManager.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbManager.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbManager.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbManager.FocusedState.Parent = this.CmbManager;
            this.CmbManager.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbManager.ForeColor = System.Drawing.Color.Black;
            this.CmbManager.HoverState.Parent = this.CmbManager;
            this.CmbManager.ItemHeight = 23;
            this.CmbManager.Items.AddRange(new object[] {
            "- Manager -"});
            this.CmbManager.ItemsAppearance.Parent = this.CmbManager;
            this.CmbManager.Location = new System.Drawing.Point(6, 94);
            this.CmbManager.Name = "CmbManager";
            this.CmbManager.ShadowDecoration.Parent = this.CmbManager;
            this.CmbManager.Size = new System.Drawing.Size(284, 29);
            this.CmbManager.StartIndex = 0;
            this.CmbManager.TabIndex = 40;
            //this.CmbManager.SelectedIndexChanged += new System.EventHandler(this.CmbManager_SelectedIndexChanged);
            // 
            // TxtDepartment
            // 
            this.TxtDepartment.BorderRadius = 5;
            this.TxtDepartment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDepartment.DefaultText = "";
            this.TxtDepartment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDepartment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDepartment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDepartment.DisabledState.Parent = this.TxtDepartment;
            this.TxtDepartment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDepartment.FocusedState.Parent = this.TxtDepartment;
            this.TxtDepartment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtDepartment.ForeColor = System.Drawing.Color.Black;
            this.TxtDepartment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDepartment.HoverState.Parent = this.TxtDepartment;
            this.TxtDepartment.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtDepartment.IconLeft")));
            this.TxtDepartment.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtDepartment.Location = new System.Drawing.Point(6, 60);
            this.TxtDepartment.Name = "TxtDepartment";
            this.TxtDepartment.PasswordChar = '\0';
            this.TxtDepartment.PlaceholderText = "Department";
            this.TxtDepartment.SelectedText = "";
            this.TxtDepartment.ShadowDecoration.Parent = this.TxtDepartment;
            this.TxtDepartment.Size = new System.Drawing.Size(284, 28);
            this.TxtDepartment.TabIndex = 39;
            // 
            // TxtDepartmentID
            // 
            this.TxtDepartmentID.BorderRadius = 5;
            this.TxtDepartmentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDepartmentID.DefaultText = "";
            this.TxtDepartmentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDepartmentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDepartmentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDepartmentID.DisabledState.Parent = this.TxtDepartmentID;
            this.TxtDepartmentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDepartmentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDepartmentID.FocusedState.Parent = this.TxtDepartmentID;
            this.TxtDepartmentID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtDepartmentID.ForeColor = System.Drawing.Color.Black;
            this.TxtDepartmentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDepartmentID.HoverState.Parent = this.TxtDepartmentID;
            this.TxtDepartmentID.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtDepartmentID.IconLeft")));
            this.TxtDepartmentID.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtDepartmentID.Location = new System.Drawing.Point(6, 27);
            this.TxtDepartmentID.Name = "TxtDepartmentID";
            this.TxtDepartmentID.PasswordChar = '\0';
            this.TxtDepartmentID.PlaceholderText = "Department ID";
            this.TxtDepartmentID.SelectedText = "";
            this.TxtDepartmentID.ShadowDecoration.Parent = this.TxtDepartmentID;
            this.TxtDepartmentID.Size = new System.Drawing.Size(284, 28);
            this.TxtDepartmentID.TabIndex = 35;
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
            this.BtnAddEdit.Location = new System.Drawing.Point(5, 143);
            this.BtnAddEdit.Name = "BtnAddEdit";
            this.BtnAddEdit.ShadowDecoration.Parent = this.BtnAddEdit;
            this.BtnAddEdit.Size = new System.Drawing.Size(296, 28);
            this.BtnAddEdit.TabIndex = 36;
            this.BtnAddEdit.Text = "ADD NEW DEPARTMENT";
            this.BtnAddEdit.Click += new System.EventHandler(this.BtnAddEdit_Click);
            // 
            // FrmAddEditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(306, 178);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.BtnAddEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddEditDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add | Edit new or existing department";
            this.bunifuGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        public Guna.UI2.WinForms.Guna2ComboBox CmbManager;
        public Guna.UI2.WinForms.Guna2TextBox TxtDepartment;
        public Guna.UI2.WinForms.Guna2TextBox TxtDepartmentID;
        public Guna.UI2.WinForms.Guna2Button BtnAddEdit;
    }
}