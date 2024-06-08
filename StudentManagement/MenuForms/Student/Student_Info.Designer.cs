namespace StudentManagement.MenuForms.Student
{
    partial class Student_Info
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblHometown = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtHometown = new System.Windows.Forms.TextBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
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
            this.pnlTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Student Information";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(764, 322);
            this.dgvStudent.TabIndex = 3;
            this.dgvStudent.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellEnter);
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
            this.pnlBottom.TabIndex = 4;
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
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblStudentID.Location = new System.Drawing.Point(31, 399);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(103, 21);
            this.lblStudentID.TabIndex = 5;
            this.lblStudentID.Text = "Student ID:";
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
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGender.Location = new System.Drawing.Point(55, 449);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(79, 21);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDateOfBirth.Location = new System.Drawing.Point(15, 500);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(119, 21);
            this.lblDateOfBirth.TabIndex = 8;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblHometown
            // 
            this.lblHometown.AutoSize = true;
            this.lblHometown.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHometown.Location = new System.Drawing.Point(315, 449);
            this.lblHometown.Name = "lblHometown";
            this.lblHometown.Size = new System.Drawing.Size(106, 21);
            this.lblHometown.TabIndex = 9;
            this.lblHometown.Text = "Hometown:";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblClassID.Location = new System.Drawing.Point(582, 449);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(81, 21);
            this.lblClassID.TabIndex = 10;
            this.lblClassID.Text = "Class ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(140, 396);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(169, 28);
            this.txtStudentID.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(427, 396);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(249, 28);
            this.txtName.TabIndex = 12;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(140, 446);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(169, 28);
            this.txtGender.TabIndex = 13;
            // 
            // txtHometown
            // 
            this.txtHometown.Location = new System.Drawing.Point(427, 446);
            this.txtHometown.Name = "txtHometown";
            this.txtHometown.ReadOnly = true;
            this.txtHometown.Size = new System.Drawing.Size(149, 28);
            this.txtHometown.TabIndex = 14;
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(669, 446);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.ReadOnly = true;
            this.txtClassID.Size = new System.Drawing.Size(74, 28);
            this.txtClassID.TabIndex = 15;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(140, 497);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.ReadOnly = true;
            this.txtDateOfBirth.Size = new System.Drawing.Size(169, 28);
            this.txtDateOfBirth.TabIndex = 16;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.btnSearch);
            this.pnlCenter.Controls.Add(this.cbbSearch);
            this.pnlCenter.Controls.Add(this.lblSearch);
            this.pnlCenter.Controls.Add(this.txtSearch);
            this.pnlCenter.Controls.Add(this.dgvStudent);
            this.pnlCenter.Controls.Add(this.txtDateOfBirth);
            this.pnlCenter.Controls.Add(this.txtName);
            this.pnlCenter.Controls.Add(this.txtGender);
            this.pnlCenter.Controls.Add(this.lblClassID);
            this.pnlCenter.Controls.Add(this.lblGender);
            this.pnlCenter.Controls.Add(this.txtClassID);
            this.pnlCenter.Controls.Add(this.lblName);
            this.pnlCenter.Controls.Add(this.lblHometown);
            this.pnlCenter.Controls.Add(this.lblDateOfBirth);
            this.pnlCenter.Controls.Add(this.lblStudentID);
            this.pnlCenter.Controls.Add(this.txtHometown);
            this.pnlCenter.Controls.Add(this.txtStudentID);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 77);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(764, 587);
            this.pnlCenter.TabIndex = 17;
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
            // cbbSearch
            // 
            this.cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Items.AddRange(new object[] {
            "Student ID",
            "Name",
            "Hometown",
            "Class ID"});
            this.cbbSearch.Location = new System.Drawing.Point(140, 349);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(169, 29);
            this.cbbSearch.TabIndex = 19;
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
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(319, 349);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 28);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // Student_Info
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 723);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Student_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Info";
            this.Load += new System.EventHandler(this.Student_Info_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblHometown;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtHometown;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnExport;
    }
}