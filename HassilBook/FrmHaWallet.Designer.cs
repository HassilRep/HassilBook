
namespace HassilBook
{
    partial class FrmHaWallet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHaWallet));
            this.BtnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPayments = new Guna.UI2.WinForms.Guna2Button();
            this.WalletPage = new Bunifu.UI.WinForms.BunifuPages();
            this.Payments = new System.Windows.Forms.TabPage();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.DtTransactionDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TxtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnAddEdit = new Guna.UI2.WinForms.Guna2Button();
            this.CmbCompanies = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtWalletID = new Guna.UI2.WinForms.Guna2TextBox();
            this.DGClientWalletPaymentTransactions = new System.Windows.Forms.DataGridView();
            this.History = new System.Windows.Forms.TabPage();
            this.DGClientAgencyHaWallet = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.DtTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.CmbAgencies = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblCounter = new System.Windows.Forms.Label();
            this.BtnSearchPayment = new Guna.UI2.WinForms.Guna2Button();
            this.DtTranTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DtTranFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.CmbAgency = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATE = new System.Windows.Forms.DataGridViewImageColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.WalletPage.SuspendLayout();
            this.Payments.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientWalletPaymentTransactions)).BeginInit();
            this.History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientAgencyHaWallet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHistory
            // 
            this.BtnHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHistory.BorderRadius = 5;
            this.BtnHistory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnHistory.CheckedState.Parent = this.BtnHistory;
            this.BtnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHistory.CustomImages.Parent = this.BtnHistory;
            this.BtnHistory.CustomizableEdges.BottomLeft = false;
            this.BtnHistory.CustomizableEdges.TopLeft = false;
            this.BtnHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnHistory.ForeColor = System.Drawing.Color.White;
            this.BtnHistory.HoverState.Parent = this.BtnHistory;
            this.BtnHistory.Location = new System.Drawing.Point(1059, 5);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.ShadowDecoration.Parent = this.BtnHistory;
            this.BtnHistory.Size = new System.Drawing.Size(215, 43);
            this.BtnHistory.TabIndex = 47;
            this.BtnHistory.Text = "HA-WALLET HISTORY";
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // BtnPayments
            // 
            this.BtnPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPayments.BorderRadius = 5;
            this.BtnPayments.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnPayments.Checked = true;
            this.BtnPayments.CheckedState.Parent = this.BtnPayments;
            this.BtnPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPayments.CustomImages.Parent = this.BtnPayments;
            this.BtnPayments.CustomizableEdges.BottomRight = false;
            this.BtnPayments.CustomizableEdges.TopRight = false;
            this.BtnPayments.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            this.BtnPayments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnPayments.ForeColor = System.Drawing.Color.White;
            this.BtnPayments.HoverState.Parent = this.BtnPayments;
            this.BtnPayments.Location = new System.Drawing.Point(867, 5);
            this.BtnPayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPayments.Name = "BtnPayments";
            this.BtnPayments.ShadowDecoration.Parent = this.BtnPayments;
            this.BtnPayments.Size = new System.Drawing.Size(192, 43);
            this.BtnPayments.TabIndex = 45;
            this.BtnPayments.Text = "PAYMENTS";
            this.BtnPayments.Click += new System.EventHandler(this.BtnPayments_Click);
            // 
            // WalletPage
            // 
            this.WalletPage.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.WalletPage.AllowTransitions = false;
            this.WalletPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WalletPage.Controls.Add(this.Payments);
            this.WalletPage.Controls.Add(this.History);
            this.WalletPage.Location = new System.Drawing.Point(-6, 52);
            this.WalletPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WalletPage.Multiline = true;
            this.WalletPage.Name = "WalletPage";
            this.WalletPage.Page = this.Payments;
            this.WalletPage.PageIndex = 0;
            this.WalletPage.PageName = "Payments";
            this.WalletPage.PageTitle = "tabPage1";
            this.WalletPage.SelectedIndex = 0;
            this.WalletPage.Size = new System.Drawing.Size(1295, 880);
            this.WalletPage.TabIndex = 48;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.WalletPage.Transition = animation1;
            this.WalletPage.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Transparent;
            // 
            // Payments
            // 
            this.Payments.BackColor = System.Drawing.Color.White;
            this.Payments.Controls.Add(this.BtnSearchPayment);
            this.Payments.Controls.Add(this.DtTranTo);
            this.Payments.Controls.Add(this.DtTranFrom);
            this.Payments.Controls.Add(this.CmbAgency);
            this.Payments.Controls.Add(this.guna2Panel1);
            this.Payments.Controls.Add(this.DGClientWalletPaymentTransactions);
            this.Payments.Location = new System.Drawing.Point(4, 4);
            this.Payments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Payments.Name = "Payments";
            this.Payments.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Payments.Size = new System.Drawing.Size(1287, 847);
            this.Payments.TabIndex = 0;
            this.Payments.Text = "tabPage1";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.guna2Panel1.Controls.Add(this.LblCounter);
            this.guna2Panel1.Controls.Add(this.DtTransactionDate);
            this.guna2Panel1.Controls.Add(this.TxtAmount);
            this.guna2Panel1.Controls.Add(this.TxtDescription);
            this.guna2Panel1.Controls.Add(this.BtnAddEdit);
            this.guna2Panel1.Controls.Add(this.CmbCompanies);
            this.guna2Panel1.Controls.Add(this.TxtWalletID);
            this.guna2Panel1.Location = new System.Drawing.Point(14, 57);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(400, 776);
            this.guna2Panel1.TabIndex = 44;
            // 
            // DtTransactionDate
            // 
            this.DtTransactionDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtTransactionDate.BorderRadius = 5;
            this.DtTransactionDate.BorderThickness = 1;
            this.DtTransactionDate.CheckedState.Parent = this.DtTransactionDate;
            this.DtTransactionDate.FillColor = System.Drawing.Color.White;
            this.DtTransactionDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtTransactionDate.HoverState.Parent = this.DtTransactionDate;
            this.DtTransactionDate.Location = new System.Drawing.Point(8, 60);
            this.DtTransactionDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtTransactionDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtTransactionDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtTransactionDate.Name = "DtTransactionDate";
            this.DtTransactionDate.ShadowDecoration.Parent = this.DtTransactionDate;
            this.DtTransactionDate.Size = new System.Drawing.Size(384, 43);
            this.DtTransactionDate.TabIndex = 23;
            this.DtTransactionDate.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
            // 
            // TxtAmount
            // 
            this.TxtAmount.BorderRadius = 5;
            this.TxtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAmount.DefaultText = "";
            this.TxtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAmount.DisabledState.Parent = this.TxtAmount;
            this.TxtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAmount.FocusedState.Parent = this.TxtAmount;
            this.TxtAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtAmount.ForeColor = System.Drawing.Color.Black;
            this.TxtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAmount.HoverState.Parent = this.TxtAmount;
            this.TxtAmount.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtAmount.IconLeft")));
            this.TxtAmount.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtAmount.Location = new System.Drawing.Point(8, 162);
            this.TxtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.PasswordChar = '\0';
            this.TxtAmount.PlaceholderText = "Amount";
            this.TxtAmount.SelectedText = "";
            this.TxtAmount.ShadowDecoration.Parent = this.TxtAmount;
            this.TxtAmount.Size = new System.Drawing.Size(384, 43);
            this.TxtAmount.TabIndex = 21;
            // 
            // TxtDescription
            // 
            this.TxtDescription.BorderRadius = 5;
            this.TxtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDescription.DefaultText = "";
            this.TxtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDescription.DisabledState.Parent = this.TxtDescription;
            this.TxtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDescription.FocusedState.Parent = this.TxtDescription;
            this.TxtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtDescription.ForeColor = System.Drawing.Color.Black;
            this.TxtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDescription.HoverState.Parent = this.TxtDescription;
            this.TxtDescription.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtDescription.IconLeft")));
            this.TxtDescription.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtDescription.Location = new System.Drawing.Point(8, 212);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDescription.MaxLength = 150;
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.PasswordChar = '\0';
            this.TxtDescription.PlaceholderText = "Details";
            this.TxtDescription.SelectedText = "";
            this.TxtDescription.ShadowDecoration.Parent = this.TxtDescription;
            this.TxtDescription.Size = new System.Drawing.Size(384, 184);
            this.TxtDescription.TabIndex = 19;
            this.TxtDescription.TextChanged += new System.EventHandler(this.TxtDescription_TextChanged);
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
            this.BtnAddEdit.Location = new System.Drawing.Point(8, 432);
            this.BtnAddEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddEdit.Name = "BtnAddEdit";
            this.BtnAddEdit.ShadowDecoration.Parent = this.BtnAddEdit;
            this.BtnAddEdit.Size = new System.Drawing.Size(384, 46);
            this.BtnAddEdit.TabIndex = 26;
            this.BtnAddEdit.Text = "ADD NEW PAYMENT";
            this.BtnAddEdit.Click += new System.EventHandler(this.BtnAddEdit_Click);
            // 
            // CmbCompanies
            // 
            this.CmbCompanies.BackColor = System.Drawing.Color.Transparent;
            this.CmbCompanies.BorderRadius = 5;
            this.CmbCompanies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCompanies.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbCompanies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbCompanies.FocusedState.Parent = this.CmbCompanies;
            this.CmbCompanies.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbCompanies.ForeColor = System.Drawing.Color.Black;
            this.CmbCompanies.HoverState.Parent = this.CmbCompanies;
            this.CmbCompanies.ItemHeight = 22;
            this.CmbCompanies.Items.AddRange(new object[] {
            "- Agencies -"});
            this.CmbCompanies.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbCompanies.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbCompanies.ItemsAppearance.Parent = this.CmbCompanies;
            this.CmbCompanies.Location = new System.Drawing.Point(8, 111);
            this.CmbCompanies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbCompanies.Name = "CmbCompanies";
            this.CmbCompanies.ShadowDecoration.Parent = this.CmbCompanies;
            this.CmbCompanies.Size = new System.Drawing.Size(382, 28);
            this.CmbCompanies.StartIndex = 0;
            this.CmbCompanies.TabIndex = 20;
            // 
            // TxtWalletID
            // 
            this.TxtWalletID.BorderRadius = 5;
            this.TxtWalletID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtWalletID.DefaultText = "";
            this.TxtWalletID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtWalletID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtWalletID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtWalletID.DisabledState.Parent = this.TxtWalletID;
            this.TxtWalletID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtWalletID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtWalletID.FocusedState.Parent = this.TxtWalletID;
            this.TxtWalletID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtWalletID.ForeColor = System.Drawing.Color.Black;
            this.TxtWalletID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtWalletID.HoverState.Parent = this.TxtWalletID;
            this.TxtWalletID.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtWalletID.IconLeft")));
            this.TxtWalletID.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtWalletID.Location = new System.Drawing.Point(8, 9);
            this.TxtWalletID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtWalletID.Name = "TxtWalletID";
            this.TxtWalletID.PasswordChar = '\0';
            this.TxtWalletID.PlaceholderText = "Payment ID";
            this.TxtWalletID.ReadOnly = true;
            this.TxtWalletID.SelectedText = "";
            this.TxtWalletID.ShadowDecoration.Parent = this.TxtWalletID;
            this.TxtWalletID.Size = new System.Drawing.Size(384, 43);
            this.TxtWalletID.TabIndex = 17;
            // 
            // DGClientWalletPaymentTransactions
            // 
            this.DGClientWalletPaymentTransactions.AllowUserToAddRows = false;
            this.DGClientWalletPaymentTransactions.AllowUserToResizeColumns = false;
            this.DGClientWalletPaymentTransactions.AllowUserToResizeRows = false;
            this.DGClientWalletPaymentTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGClientWalletPaymentTransactions.BackgroundColor = System.Drawing.Color.White;
            this.DGClientWalletPaymentTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGClientWalletPaymentTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(162)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGClientWalletPaymentTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGClientWalletPaymentTransactions.ColumnHeadersHeight = 25;
            this.DGClientWalletPaymentTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGClientWalletPaymentTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column6,
            this.UPDATE,
            this.DELETE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGClientWalletPaymentTransactions.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGClientWalletPaymentTransactions.EnableHeadersVisualStyles = false;
            this.DGClientWalletPaymentTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DGClientWalletPaymentTransactions.Location = new System.Drawing.Point(418, 57);
            this.DGClientWalletPaymentTransactions.Margin = new System.Windows.Forms.Padding(0);
            this.DGClientWalletPaymentTransactions.Name = "DGClientWalletPaymentTransactions";
            this.DGClientWalletPaymentTransactions.ReadOnly = true;
            this.DGClientWalletPaymentTransactions.RowHeadersVisible = false;
            this.DGClientWalletPaymentTransactions.RowHeadersWidth = 61;
            this.DGClientWalletPaymentTransactions.RowTemplate.Height = 25;
            this.DGClientWalletPaymentTransactions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGClientWalletPaymentTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGClientWalletPaymentTransactions.Size = new System.Drawing.Size(853, 776);
            this.DGClientWalletPaymentTransactions.TabIndex = 40;
            this.DGClientWalletPaymentTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGClientWalletPaymentTransactions_CellContentClick);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.White;
            this.History.Controls.Add(this.BtnSearch);
            this.History.Controls.Add(this.DtTo);
            this.History.Controls.Add(this.DtFrom);
            this.History.Controls.Add(this.CmbAgencies);
            this.History.Controls.Add(this.DGClientAgencyHaWallet);
            this.History.Location = new System.Drawing.Point(4, 4);
            this.History.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.History.Size = new System.Drawing.Size(1287, 847);
            this.History.TabIndex = 1;
            this.History.Text = "tabPage2";
            // 
            // DGClientAgencyHaWallet
            // 
            this.DGClientAgencyHaWallet.AllowUserToAddRows = false;
            this.DGClientAgencyHaWallet.AllowUserToResizeColumns = false;
            this.DGClientAgencyHaWallet.AllowUserToResizeRows = false;
            this.DGClientAgencyHaWallet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGClientAgencyHaWallet.BackgroundColor = System.Drawing.Color.White;
            this.DGClientAgencyHaWallet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGClientAgencyHaWallet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(162)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGClientAgencyHaWallet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGClientAgencyHaWallet.ColumnHeadersHeight = 25;
            this.DGClientAgencyHaWallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGClientAgencyHaWallet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column10,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column7,
            this.dataGridViewTextBoxColumn8,
            this.Column8});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGClientAgencyHaWallet.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGClientAgencyHaWallet.EnableHeadersVisualStyles = false;
            this.DGClientAgencyHaWallet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DGClientAgencyHaWallet.Location = new System.Drawing.Point(11, 57);
            this.DGClientAgencyHaWallet.Margin = new System.Windows.Forms.Padding(0);
            this.DGClientAgencyHaWallet.Name = "DGClientAgencyHaWallet";
            this.DGClientAgencyHaWallet.ReadOnly = true;
            this.DGClientAgencyHaWallet.RowHeadersVisible = false;
            this.DGClientAgencyHaWallet.RowHeadersWidth = 61;
            this.DGClientAgencyHaWallet.RowTemplate.Height = 25;
            this.DGClientAgencyHaWallet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGClientAgencyHaWallet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGClientAgencyHaWallet.Size = new System.Drawing.Size(1255, 785);
            this.DGClientAgencyHaWallet.TabIndex = 45;
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
            this.BtnSearch.Location = new System.Drawing.Point(1228, 7);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.ShadowDecoration.Parent = this.BtnSearch;
            this.BtnSearch.Size = new System.Drawing.Size(43, 43);
            this.BtnSearch.TabIndex = 49;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
            this.DtTo.Location = new System.Drawing.Point(934, 7);
            this.DtTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtTo.Name = "DtTo";
            this.DtTo.ShadowDecoration.Parent = this.DtTo;
            this.DtTo.Size = new System.Drawing.Size(287, 43);
            this.DtTo.TabIndex = 48;
            this.DtTo.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
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
            this.DtFrom.Location = new System.Drawing.Point(637, 7);
            this.DtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.ShadowDecoration.Parent = this.DtFrom;
            this.DtFrom.Size = new System.Drawing.Size(287, 43);
            this.DtFrom.TabIndex = 47;
            this.DtFrom.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
            // 
            // CmbAgencies
            // 
            this.CmbAgencies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbAgencies.BackColor = System.Drawing.Color.Transparent;
            this.CmbAgencies.BorderRadius = 5;
            this.CmbAgencies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbAgencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAgencies.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbAgencies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbAgencies.FocusedState.Parent = this.CmbAgencies;
            this.CmbAgencies.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbAgencies.ForeColor = System.Drawing.Color.Black;
            this.CmbAgencies.HoverState.Parent = this.CmbAgencies;
            this.CmbAgencies.ItemHeight = 22;
            this.CmbAgencies.Items.AddRange(new object[] {
            "- Agency -"});
            this.CmbAgencies.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbAgencies.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbAgencies.ItemsAppearance.Parent = this.CmbAgencies;
            this.CmbAgencies.Location = new System.Drawing.Point(11, 9);
            this.CmbAgencies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbAgencies.Name = "CmbAgencies";
            this.CmbAgencies.ShadowDecoration.Parent = this.CmbAgencies;
            this.CmbAgencies.Size = new System.Drawing.Size(618, 28);
            this.CmbAgencies.StartIndex = 0;
            this.CmbAgencies.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "#";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 54;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "REFRENCE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 126;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "DATE";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 84;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "AGENCY";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "DESCRIPTION";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "DEBIT";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 89;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.HeaderText = "CREDIT";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 101;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "RUNNING BALANCE";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 201;
            // 
            // LblCounter
            // 
            this.LblCounter.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblCounter.Location = new System.Drawing.Point(291, 402);
            this.LblCounter.Name = "LblCounter";
            this.LblCounter.Size = new System.Drawing.Size(100, 23);
            this.LblCounter.TabIndex = 27;
            this.LblCounter.Text = "[0/150]";
            this.LblCounter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnSearchPayment
            // 
            this.BtnSearchPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchPayment.BorderRadius = 5;
            this.BtnSearchPayment.CheckedState.Parent = this.BtnSearchPayment;
            this.BtnSearchPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchPayment.CustomImages.Parent = this.BtnSearchPayment;
            this.BtnSearchPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(123)))), ((int)(((byte)(253)))));
            this.BtnSearchPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSearchPayment.ForeColor = System.Drawing.Color.White;
            this.BtnSearchPayment.HoverState.Parent = this.BtnSearchPayment;
            this.BtnSearchPayment.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchPayment.Image")));
            this.BtnSearchPayment.ImageSize = new System.Drawing.Size(15, 15);
            this.BtnSearchPayment.Location = new System.Drawing.Point(1228, 7);
            this.BtnSearchPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearchPayment.Name = "BtnSearchPayment";
            this.BtnSearchPayment.ShadowDecoration.Parent = this.BtnSearchPayment;
            this.BtnSearchPayment.Size = new System.Drawing.Size(43, 43);
            this.BtnSearchPayment.TabIndex = 49;
            this.BtnSearchPayment.Click += new System.EventHandler(this.BtnSearchPayment_Click);
            // 
            // DtTranTo
            // 
            this.DtTranTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtTranTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtTranTo.BorderRadius = 5;
            this.DtTranTo.BorderThickness = 1;
            this.DtTranTo.CheckedState.Parent = this.DtTranTo;
            this.DtTranTo.FillColor = System.Drawing.Color.White;
            this.DtTranTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtTranTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtTranTo.HoverState.Parent = this.DtTranTo;
            this.DtTranTo.Location = new System.Drawing.Point(983, 9);
            this.DtTranTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtTranTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtTranTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtTranTo.Name = "DtTranTo";
            this.DtTranTo.ShadowDecoration.Parent = this.DtTranTo;
            this.DtTranTo.Size = new System.Drawing.Size(238, 43);
            this.DtTranTo.TabIndex = 48;
            this.DtTranTo.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
            // 
            // DtTranFrom
            // 
            this.DtTranFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtTranFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtTranFrom.BorderRadius = 5;
            this.DtTranFrom.BorderThickness = 1;
            this.DtTranFrom.CheckedState.Parent = this.DtTranFrom;
            this.DtTranFrom.FillColor = System.Drawing.Color.White;
            this.DtTranFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtTranFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtTranFrom.HoverState.Parent = this.DtTranFrom;
            this.DtTranFrom.Location = new System.Drawing.Point(747, 9);
            this.DtTranFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtTranFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtTranFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtTranFrom.Name = "DtTranFrom";
            this.DtTranFrom.ShadowDecoration.Parent = this.DtTranFrom;
            this.DtTranFrom.Size = new System.Drawing.Size(226, 43);
            this.DtTranFrom.TabIndex = 47;
            this.DtTranFrom.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
            // 
            // CmbAgency
            // 
            this.CmbAgency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbAgency.BackColor = System.Drawing.Color.Transparent;
            this.CmbAgency.BorderRadius = 5;
            this.CmbAgency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbAgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAgency.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbAgency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbAgency.FocusedState.Parent = this.CmbAgency;
            this.CmbAgency.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbAgency.ForeColor = System.Drawing.Color.Black;
            this.CmbAgency.HoverState.Parent = this.CmbAgency;
            this.CmbAgency.ItemHeight = 22;
            this.CmbAgency.Items.AddRange(new object[] {
            "- Agency -"});
            this.CmbAgency.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.CmbAgency.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.CmbAgency.ItemsAppearance.Parent = this.CmbAgency;
            this.CmbAgency.Location = new System.Drawing.Point(423, 9);
            this.CmbAgency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbAgency.Name = "CmbAgency";
            this.CmbAgency.ShadowDecoration.Parent = this.CmbAgency;
            this.CmbAgency.Size = new System.Drawing.Size(316, 28);
            this.CmbAgency.StartIndex = 0;
            this.CmbAgency.TabIndex = 46;
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
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "DATE";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 84;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "AGENCY";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 110;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "DESCRIPTION";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "AMOUNT";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 118;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "USERNAME";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 134;
            // 
            // UPDATE
            // 
            this.UPDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UPDATE.HeaderText = "EDIT";
            this.UPDATE.Image = ((System.Drawing.Image)(resources.GetObject("UPDATE.Image")));
            this.UPDATE.MinimumWidth = 8;
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.ReadOnly = true;
            this.UPDATE.Width = 49;
            // 
            // DELETE
            // 
            this.DELETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DELETE.HeaderText = "DEL";
            this.DELETE.Image = ((System.Drawing.Image)(resources.GetObject("DELETE.Image")));
            this.DELETE.MinimumWidth = 8;
            this.DELETE.Name = "DELETE";
            this.DELETE.ReadOnly = true;
            this.DELETE.Width = 43;
            // 
            // FrmHaWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 906);
            this.Controls.Add(this.WalletPage);
            this.Controls.Add(this.BtnHistory);
            this.Controls.Add(this.BtnPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHaWallet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHaWallet";
            this.WalletPage.ResumeLayout(false);
            this.Payments.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGClientWalletPaymentTransactions)).EndInit();
            this.History.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGClientAgencyHaWallet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnHistory;
        private Guna.UI2.WinForms.Guna2Button BtnPayments;
        private Bunifu.UI.WinForms.BunifuPages WalletPage;
        private System.Windows.Forms.TabPage Payments;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtTransactionDate;
        private Guna.UI2.WinForms.Guna2TextBox TxtAmount;
        private Guna.UI2.WinForms.Guna2TextBox TxtDescription;
        private Guna.UI2.WinForms.Guna2Button BtnAddEdit;
        private Guna.UI2.WinForms.Guna2ComboBox CmbCompanies;
        private Guna.UI2.WinForms.Guna2TextBox TxtWalletID;
        private System.Windows.Forms.DataGridView DGClientWalletPaymentTransactions;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.DataGridView DGClientAgencyHaWallet;
        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtFrom;
        private Guna.UI2.WinForms.Guna2ComboBox CmbAgencies;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label LblCounter;
        private Guna.UI2.WinForms.Guna2Button BtnSearchPayment;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtTranTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtTranFrom;
        private Guna.UI2.WinForms.Guna2ComboBox CmbAgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn UPDATE;
        private System.Windows.Forms.DataGridViewImageColumn DELETE;
    }
}