namespace StudentManagement.MenuForms.Education_System
{
    partial class EdSystem_Info
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSystemID = new System.Windows.Forms.TextBox();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSystem = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSystemID = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Brown;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(764, 77);
            this.pnlTop.TabIndex = 24;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Walter Turncoat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(432, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Education System Information";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Brown;
            this.pnlBottom.Controls.Add(this.btnExport);
            this.pnlBottom.Controls.Add(this.btnReload);
            this.pnlBottom.Controls.Add(this.btnPrint);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 664);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(764, 59);
            this.pnlBottom.TabIndex = 25;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExport.Location = new System.Drawing.Point(520, 13);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(113, 34);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.BackColor = System.Drawing.Color.White;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.Color.Blue;
            this.btnReload.Location = new System.Drawing.Point(401, 13);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(113, 34);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(639, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(113, 34);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(630, 345);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 34);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSearch.Location = new System.Drawing.Point(37, 352);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(97, 21);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Search by:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(427, 396);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(249, 28);
            this.txtName.TabIndex = 12;
            // 
            // txtSystemID
            // 
            this.txtSystemID.Location = new System.Drawing.Point(140, 396);
            this.txtSystemID.Name = "txtSystemID";
            this.txtSystemID.ReadOnly = true;
            this.txtSystemID.Size = new System.Drawing.Size(169, 28);
            this.txtSystemID.TabIndex = 11;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.btnSearch);
            this.pnlCenter.Controls.Add(this.cbbSearch);
            this.pnlCenter.Controls.Add(this.lblSearch);
            this.pnlCenter.Controls.Add(this.txtSearch);
            this.pnlCenter.Controls.Add(this.dgvSystem);
            this.pnlCenter.Controls.Add(this.txtName);
            this.pnlCenter.Controls.Add(this.lblName);
            this.pnlCenter.Controls.Add(this.lblSystemID);
            this.pnlCenter.Controls.Add(this.txtSystemID);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 77);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(764, 646);
            this.pnlCenter.TabIndex = 26;
            // 
            // cbbSearch
            // 
            this.cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Items.AddRange(new object[] {
            "System ID",
            "Name"});
            this.cbbSearch.Location = new System.Drawing.Point(140, 349);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(169, 29);
            this.cbbSearch.TabIndex = 19;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(319, 349);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 28);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // dgvSystem
            // 
            this.dgvSystem.AllowUserToAddRows = false;
            this.dgvSystem.AllowUserToDeleteRows = false;
            this.dgvSystem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSystem.Location = new System.Drawing.Point(0, 0);
            this.dgvSystem.Name = "dgvSystem";
            this.dgvSystem.ReadOnly = true;
            this.dgvSystem.RowHeadersWidth = 51;
            this.dgvSystem.RowTemplate.Height = 24;
            this.dgvSystem.Size = new System.Drawing.Size(764, 322);
            this.dgvSystem.TabIndex = 3;
            this.dgvSystem.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSystem_CellEnter);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblName.Location = new System.Drawing.Point(355, 399);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 21);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // lblSystemID
            // 
            this.lblSystemID.AutoSize = true;
            this.lblSystemID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSystemID.Location = new System.Drawing.Point(40, 399);
            this.lblSystemID.Name = "lblSystemID";
            this.lblSystemID.Size = new System.Drawing.Size(94, 21);
            this.lblSystemID.TabIndex = 5;
            this.lblSystemID.Text = "System ID:";
            // 
            // EdSystem_Info
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 723);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EdSystem_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EdSystem_Info";
            this.Load += new System.EventHandler(this.EdSystem_Info_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSystemID;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSystem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSystemID;
        private System.Windows.Forms.Button btnExport;
    }
}