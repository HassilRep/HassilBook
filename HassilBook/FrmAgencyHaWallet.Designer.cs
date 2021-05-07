
namespace HassilBook
{
    partial class FrmAgencyHaWallet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgencyHaWallet));
            this.DtTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DGClientAgencyHaWallet = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientAgencyHaWallet)).BeginInit();
            this.SuspendLayout();
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
            this.DtTo.Location = new System.Drawing.Point(429, 6);
            this.DtTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtTo.Name = "DtTo";
            this.DtTo.ShadowDecoration.Parent = this.DtTo;
            this.DtTo.Size = new System.Drawing.Size(657, 43);
            this.DtTo.TabIndex = 52;
            this.DtTo.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
            // 
            // DtFrom
            // 
            this.DtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DtFrom.BorderRadius = 5;
            this.DtFrom.BorderThickness = 1;
            this.DtFrom.CheckedState.Parent = this.DtFrom;
            this.DtFrom.FillColor = System.Drawing.Color.White;
            this.DtFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtFrom.HoverState.Parent = this.DtFrom;
            this.DtFrom.Location = new System.Drawing.Point(16, 6);
            this.DtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.ShadowDecoration.Parent = this.DtFrom;
            this.DtFrom.Size = new System.Drawing.Size(405, 43);
            this.DtFrom.TabIndex = 51;
            this.DtFrom.Value = new System.DateTime(2021, 4, 13, 19, 45, 57, 839);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(123)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(105)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGClientAgencyHaWallet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGClientAgencyHaWallet.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGClientAgencyHaWallet.EnableHeadersVisualStyles = false;
            this.DGClientAgencyHaWallet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DGClientAgencyHaWallet.Location = new System.Drawing.Point(16, 55);
            this.DGClientAgencyHaWallet.Margin = new System.Windows.Forms.Padding(0);
            this.DGClientAgencyHaWallet.Name = "DGClientAgencyHaWallet";
            this.DGClientAgencyHaWallet.ReadOnly = true;
            this.DGClientAgencyHaWallet.RowHeadersVisible = false;
            this.DGClientAgencyHaWallet.RowHeadersWidth = 61;
            this.DGClientAgencyHaWallet.RowTemplate.Height = 25;
            this.DGClientAgencyHaWallet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGClientAgencyHaWallet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGClientAgencyHaWallet.Size = new System.Drawing.Size(1119, 738);
            this.DGClientAgencyHaWallet.TabIndex = 50;
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
            this.BtnSearch.Location = new System.Drawing.Point(1093, 6);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.ShadowDecoration.Parent = this.BtnSearch;
            this.BtnSearch.Size = new System.Drawing.Size(43, 43);
            this.BtnSearch.TabIndex = 53;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // FrmAgencyHaWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 802);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DtTo);
            this.Controls.Add(this.DtFrom);
            this.Controls.Add(this.DGClientAgencyHaWallet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgencyHaWallet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgencyHaWallet";
            ((System.ComponentModel.ISupportInitialize)(this.DGClientAgencyHaWallet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtFrom;
        private System.Windows.Forms.DataGridView DGClientAgencyHaWallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}