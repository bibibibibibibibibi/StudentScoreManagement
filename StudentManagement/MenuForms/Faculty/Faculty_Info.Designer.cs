namespace StudentManagement.MenuForms.Faculty
{
    partial class Faculty_Info
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
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFacultyID = new System.Windows.Forms.TextBox();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvFaculty = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFacultyID = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(153, 446);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(169, 28);
            this.txtPhoneNumber.TabIndex = 22;
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
            this.lblTitle.Size = new System.Drawing.Size(297, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Faculty Information";
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
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 449);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(135, 21);
            this.lblPhoneNumber.TabIndex = 21;
            this.lblPhoneNumber.Text = "Phone number:";
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
            // txtFacultyID
            // 
            this.txtFacultyID.Location = new System.Drawing.Point(153, 396);
            this.txtFacultyID.Name = "txtFacultyID";
            this.txtFacultyID.ReadOnly = true;
            this.txtFacultyID.Size = new System.Drawing.Size(169, 28);
            this.txtFacultyID.TabIndex = 11;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.txtAddress);
            this.pnlCenter.Controls.Add(this.lblAddress);
            this.pnlCenter.Controls.Add(this.txtPhoneNumber);
            this.pnlCenter.Controls.Add(this.lblPhoneNumber);
            this.pnlCenter.Controls.Add(this.btnSearch);
            this.pnlCenter.Controls.Add(this.cbbSearch);
            this.pnlCenter.Controls.Add(this.lblSearch);
            this.pnlCenter.Controls.Add(this.txtSearch);
            this.pnlCenter.Controls.Add(this.dgvFaculty);
            this.pnlCenter.Controls.Add(this.txtName);
            this.pnlCenter.Controls.Add(this.lblName);
            this.pnlCenter.Controls.Add(this.lblFacultyID);
            this.pnlCenter.Controls.Add(this.txtFacultyID);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 77);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(764, 646);
            this.pnlCenter.TabIndex = 26;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(427, 446);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(249, 28);
            this.txtAddress.TabIndex = 24;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAddress.Location = new System.Drawing.Point(339, 449);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 21);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "Address:";
            // 
            // cbbSearch
            // 
            this.cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Items.AddRange(new object[] {
            "Faculty ID",
            "Name",
            "Address",
            "Phone number"});
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
            // dgvFaculty
            // 
            this.dgvFaculty.AllowUserToAddRows = false;
            this.dgvFaculty.AllowUserToDeleteRows = false;
            this.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaculty.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFaculty.Location = new System.Drawing.Point(0, 0);
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.ReadOnly = true;
            this.dgvFaculty.RowHeadersWidth = 51;
            this.dgvFaculty.RowTemplate.Height = 24;
            this.dgvFaculty.Size = new System.Drawing.Size(764, 322);
            this.dgvFaculty.TabIndex = 3;
            this.dgvFaculty.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaculty_CellEnter);
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
            // lblFacultyID
            // 
            this.lblFacultyID.AutoSize = true;
            this.lblFacultyID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFacultyID.Location = new System.Drawing.Point(50, 399);
            this.lblFacultyID.Name = "lblFacultyID";
            this.lblFacultyID.Size = new System.Drawing.Size(97, 21);
            this.lblFacultyID.TabIndex = 5;
            this.lblFacultyID.Text = "Faculty ID:";
            // 
            // Faculty_Info
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Faculty_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty_Info";
            this.Load += new System.EventHandler(this.Faculty_Info_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFacultyID;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvFaculty;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFacultyID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnExport;
    }
}