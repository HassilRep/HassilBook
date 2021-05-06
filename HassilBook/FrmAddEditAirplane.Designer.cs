
namespace HassilBook
{
    partial class FrmAddEditAirplane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditAirplane));
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.CmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtSeats = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtManufacturer = new Guna.UI2.WinForms.Guna2TextBox();
            this.DtRegistrationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TxtRegistrationNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnAddEdit = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.CmbStatus);
            this.bunifuGroupBox1.Controls.Add(this.CmbCategory);
            this.bunifuGroupBox1.Controls.Add(this.TxtSeats);
            this.bunifuGroupBox1.Controls.Add(this.TxtModel);
            this.bunifuGroupBox1.Controls.Add(this.TxtManufacturer);
            this.bunifuGroupBox1.Controls.Add(this.DtRegistrationDate);
            this.bunifuGroupBox1.Controls.Add(this.TxtRegistrationNumber);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(6, 3);
            this.bunifuGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGroupBox1.Size = new System.Drawing.Size(444, 418);
            this.bunifuGroupBox1.TabIndex = 0;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Airplane details";
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
            this.CmbStatus.ItemHeight = 23;
            this.CmbStatus.Items.AddRange(new object[] {
            "- Status -",
            "Operational",
            "Defect"});
            this.CmbStatus.ItemsAppearance.Parent = this.CmbStatus;
            this.CmbStatus.Location = new System.Drawing.Point(9, 357);
            this.CmbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.ShadowDecoration.Parent = this.CmbStatus;
            this.CmbStatus.Size = new System.Drawing.Size(424, 29);
            this.CmbStatus.StartIndex = 0;
            this.CmbStatus.TabIndex = 41;
            // 
            // CmbCategory
            // 
            this.CmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.CmbCategory.BorderRadius = 5;
            this.CmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbCategory.FocusedState.Parent = this.CmbCategory;
            this.CmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbCategory.ForeColor = System.Drawing.Color.Black;
            this.CmbCategory.HoverState.Parent = this.CmbCategory;
            this.CmbCategory.ItemHeight = 23;
            this.CmbCategory.Items.AddRange(new object[] {
            "- Category -",
            "Schedule",
            "Charter"});
            this.CmbCategory.ItemsAppearance.Parent = this.CmbCategory;
            this.CmbCategory.Location = new System.Drawing.Point(9, 303);
            this.CmbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.ShadowDecoration.Parent = this.CmbCategory;
            this.CmbCategory.Size = new System.Drawing.Size(424, 29);
            this.CmbCategory.StartIndex = 0;
            this.CmbCategory.TabIndex = 40;
            // 
            // TxtSeats
            // 
            this.TxtSeats.BorderRadius = 5;
            this.TxtSeats.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSeats.DefaultText = "";
            this.TxtSeats.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSeats.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSeats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSeats.DisabledState.Parent = this.TxtSeats;
            this.TxtSeats.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSeats.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSeats.FocusedState.Parent = this.TxtSeats;
            this.TxtSeats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtSeats.ForeColor = System.Drawing.Color.Black;
            this.TxtSeats.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSeats.HoverState.Parent = this.TxtSeats;
            this.TxtSeats.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtSeats.IconLeft")));
            this.TxtSeats.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtSeats.Location = new System.Drawing.Point(9, 251);
            this.TxtSeats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSeats.Name = "TxtSeats";
            this.TxtSeats.PasswordChar = '\0';
            this.TxtSeats.PlaceholderText = "Seats";
            this.TxtSeats.SelectedText = "";
            this.TxtSeats.ShadowDecoration.Parent = this.TxtSeats;
            this.TxtSeats.Size = new System.Drawing.Size(426, 43);
            this.TxtSeats.TabIndex = 39;
            // 
            // TxtModel
            // 
            this.TxtModel.BorderRadius = 5;
            this.TxtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtModel.DefaultText = "";
            this.TxtModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtModel.DisabledState.Parent = this.TxtModel;
            this.TxtModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtModel.FocusedState.Parent = this.TxtModel;
            this.TxtModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtModel.ForeColor = System.Drawing.Color.Black;
            this.TxtModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtModel.HoverState.Parent = this.TxtModel;
            this.TxtModel.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtModel.IconLeft")));
            this.TxtModel.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtModel.Location = new System.Drawing.Point(9, 198);
            this.TxtModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.PasswordChar = '\0';
            this.TxtModel.PlaceholderText = "Model";
            this.TxtModel.SelectedText = "";
            this.TxtModel.ShadowDecoration.Parent = this.TxtModel;
            this.TxtModel.Size = new System.Drawing.Size(426, 43);
            this.TxtModel.TabIndex = 38;
            // 
            // TxtManufacturer
            // 
            this.TxtManufacturer.BorderRadius = 5;
            this.TxtManufacturer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtManufacturer.DefaultText = "";
            this.TxtManufacturer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtManufacturer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtManufacturer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtManufacturer.DisabledState.Parent = this.TxtManufacturer;
            this.TxtManufacturer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtManufacturer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtManufacturer.FocusedState.Parent = this.TxtManufacturer;
            this.TxtManufacturer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtManufacturer.ForeColor = System.Drawing.Color.Black;
            this.TxtManufacturer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtManufacturer.HoverState.Parent = this.TxtManufacturer;
            this.TxtManufacturer.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtManufacturer.IconLeft")));
            this.TxtManufacturer.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtManufacturer.Location = new System.Drawing.Point(9, 146);
            this.TxtManufacturer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtManufacturer.Name = "TxtManufacturer";
            this.TxtManufacturer.PasswordChar = '\0';
            this.TxtManufacturer.PlaceholderText = "Manufacturer";
            this.TxtManufacturer.SelectedText = "";
            this.TxtManufacturer.ShadowDecoration.Parent = this.TxtManufacturer;
            this.TxtManufacturer.Size = new System.Drawing.Size(426, 43);
            this.TxtManufacturer.TabIndex = 37;
            // 
            // DtRegistrationDate
            // 
            this.DtRegistrationDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtRegistrationDate.BorderRadius = 5;
            this.DtRegistrationDate.BorderThickness = 1;
            this.DtRegistrationDate.CheckedState.Parent = this.DtRegistrationDate;
            this.DtRegistrationDate.CustomFormat = "dd MMM yyyy";
            this.DtRegistrationDate.FillColor = System.Drawing.Color.White;
            this.DtRegistrationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtRegistrationDate.ForeColor = System.Drawing.Color.Black;
            this.DtRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtRegistrationDate.HoverState.Parent = this.DtRegistrationDate;
            this.DtRegistrationDate.Location = new System.Drawing.Point(9, 94);
            this.DtRegistrationDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtRegistrationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtRegistrationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtRegistrationDate.Name = "DtRegistrationDate";
            this.DtRegistrationDate.ShadowDecoration.Parent = this.DtRegistrationDate;
            this.DtRegistrationDate.Size = new System.Drawing.Size(426, 43);
            this.DtRegistrationDate.TabIndex = 36;
            this.DtRegistrationDate.Value = new System.DateTime(2021, 5, 1, 10, 17, 33, 83);
            // 
            // TxtRegistrationNumber
            // 
            this.TxtRegistrationNumber.BorderRadius = 5;
            this.TxtRegistrationNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRegistrationNumber.DefaultText = "";
            this.TxtRegistrationNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtRegistrationNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtRegistrationNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRegistrationNumber.DisabledState.Parent = this.TxtRegistrationNumber;
            this.TxtRegistrationNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRegistrationNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRegistrationNumber.FocusedState.Parent = this.TxtRegistrationNumber;
            this.TxtRegistrationNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtRegistrationNumber.ForeColor = System.Drawing.Color.Black;
            this.TxtRegistrationNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRegistrationNumber.HoverState.Parent = this.TxtRegistrationNumber;
            this.TxtRegistrationNumber.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtRegistrationNumber.IconLeft")));
            this.TxtRegistrationNumber.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtRegistrationNumber.Location = new System.Drawing.Point(9, 42);
            this.TxtRegistrationNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRegistrationNumber.Name = "TxtRegistrationNumber";
            this.TxtRegistrationNumber.PasswordChar = '\0';
            this.TxtRegistrationNumber.PlaceholderText = "Registration number";
            this.TxtRegistrationNumber.SelectedText = "";
            this.TxtRegistrationNumber.ShadowDecoration.Parent = this.TxtRegistrationNumber;
            this.TxtRegistrationNumber.Size = new System.Drawing.Size(426, 43);
            this.TxtRegistrationNumber.TabIndex = 35;
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
            this.BtnAddEdit.Location = new System.Drawing.Point(6, 428);
            this.BtnAddEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddEdit.Name = "BtnAddEdit";
            this.BtnAddEdit.ShadowDecoration.Parent = this.BtnAddEdit;
            this.BtnAddEdit.Size = new System.Drawing.Size(444, 43);
            this.BtnAddEdit.TabIndex = 34;
            this.BtnAddEdit.Text = "ADD NEW AIRPLANE";
            this.BtnAddEdit.Click += new System.EventHandler(this.BtnAddEdit_Click);
            // 
            // FrmAddEditAirplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 483);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.BtnAddEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(469, 499);
            this.Name = "FrmAddEditAirplane";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add | Edit new or existing airplane";
            this.bunifuGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        public Guna.UI2.WinForms.Guna2DateTimePicker DtRegistrationDate;
        public Guna.UI2.WinForms.Guna2TextBox TxtRegistrationNumber;
        public Guna.UI2.WinForms.Guna2Button BtnAddEdit;
        public Guna.UI2.WinForms.Guna2ComboBox CmbStatus;
        public Guna.UI2.WinForms.Guna2ComboBox CmbCategory;
        public Guna.UI2.WinForms.Guna2TextBox TxtSeats;
        public Guna.UI2.WinForms.Guna2TextBox TxtModel;
        public Guna.UI2.WinForms.Guna2TextBox TxtManufacturer;
    }
}