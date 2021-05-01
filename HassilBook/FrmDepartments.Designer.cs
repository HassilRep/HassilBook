
namespace HassilBook
{
    partial class FrmDepartments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartments));
            this.DGClientDepartments = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewImageColumn();
            this.DEL = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnAddEdit = new Guna.UI2.WinForms.Guna2Button();
            this.TxtSearchWith = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // DGClientDepartments
            // 
            this.DGClientDepartments.AllowUserToAddRows = false;
            this.DGClientDepartments.AllowUserToResizeColumns = false;
            this.DGClientDepartments.AllowUserToResizeRows = false;
            this.DGClientDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGClientDepartments.BackgroundColor = System.Drawing.Color.White;
            this.DGClientDepartments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGClientDepartments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(191)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(162)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGClientDepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGClientDepartments.ColumnHeadersHeight = 25;
            this.DGClientDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGClientDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column9,
            this.EDIT,
            this.DEL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGClientDepartments.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGClientDepartments.EnableHeadersVisualStyles = false;
            this.DGClientDepartments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DGClientDepartments.Location = new System.Drawing.Point(14, 57);
            this.DGClientDepartments.Margin = new System.Windows.Forms.Padding(0);
            this.DGClientDepartments.Name = "DGClientDepartments";
            this.DGClientDepartments.ReadOnly = true;
            this.DGClientDepartments.RowHeadersVisible = false;
            this.DGClientDepartments.RowHeadersWidth = 61;
            this.DGClientDepartments.RowTemplate.Height = 25;
            this.DGClientDepartments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGClientDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGClientDepartments.Size = new System.Drawing.Size(1173, 717);
            this.DGClientDepartments.TabIndex = 39;
            this.DGClientDepartments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGClientDepartments_CellContentClick);
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
            this.Column5.HeaderText = "DEPARTMENT";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "DEPARTMENT MANAGER";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 240;
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
            // BtnAddEdit
            // 
            this.BtnAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddEdit.BorderRadius = 5;
            this.BtnAddEdit.CheckedState.Parent = this.BtnAddEdit;
            this.BtnAddEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddEdit.CustomImages.Parent = this.BtnAddEdit;
            this.BtnAddEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(123)))), ((int)(((byte)(253)))));
            this.BtnAddEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAddEdit.ForeColor = System.Drawing.Color.White;
            this.BtnAddEdit.HoverState.Parent = this.BtnAddEdit;
            this.BtnAddEdit.Location = new System.Drawing.Point(939, 8);
            this.BtnAddEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddEdit.Name = "BtnAddEdit";
            this.BtnAddEdit.ShadowDecoration.Parent = this.BtnAddEdit;
            this.BtnAddEdit.Size = new System.Drawing.Size(248, 43);
            this.BtnAddEdit.TabIndex = 41;
            this.BtnAddEdit.Text = "ADD NEW DEPARTMENT";
            this.BtnAddEdit.Click += new System.EventHandler(this.BtnAddEdit_Click);
            // 
            // TxtSearchWith
            // 
            this.TxtSearchWith.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearchWith.BorderRadius = 5;
            this.TxtSearchWith.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearchWith.DefaultText = "";
            this.TxtSearchWith.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSearchWith.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSearchWith.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearchWith.DisabledState.Parent = this.TxtSearchWith;
            this.TxtSearchWith.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearchWith.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchWith.FocusedState.Parent = this.TxtSearchWith;
            this.TxtSearchWith.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtSearchWith.ForeColor = System.Drawing.Color.Black;
            this.TxtSearchWith.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchWith.HoverState.Parent = this.TxtSearchWith;
            this.TxtSearchWith.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtSearchWith.IconLeft")));
            this.TxtSearchWith.IconLeftSize = new System.Drawing.Size(12, 12);
            this.TxtSearchWith.Location = new System.Drawing.Point(14, 8);
            this.TxtSearchWith.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearchWith.Name = "TxtSearchWith";
            this.TxtSearchWith.PasswordChar = '\0';
            this.TxtSearchWith.PlaceholderText = "Search with department ID, description or manager by pressing enter";
            this.TxtSearchWith.SelectedText = "";
            this.TxtSearchWith.ShadowDecoration.Parent = this.TxtSearchWith;
            this.TxtSearchWith.Size = new System.Drawing.Size(916, 43);
            this.TxtSearchWith.TabIndex = 40;
            this.TxtSearchWith.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchWith_KeyDown);
            // 
            // FrmDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.DGClientDepartments);
            this.Controls.Add(this.BtnAddEdit);
            this.Controls.Add(this.TxtSearchWith);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDepartments";
            this.Text = "FrmDepartments";
            ((System.ComponentModel.ISupportInitialize)(this.DGClientDepartments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGClientDepartments;
        private Guna.UI2.WinForms.Guna2Button BtnAddEdit;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearchWith;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn EDIT;
        private System.Windows.Forms.DataGridViewImageColumn DEL;
    }
}