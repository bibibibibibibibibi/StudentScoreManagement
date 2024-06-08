namespace StudentManagement.MenuForms.Student
{
    partial class Student_Manage
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
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbbClassID = new System.Windows.Forms.ComboBox();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHometown = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtHometown = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.pnlCenter.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
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
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(639, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.dtpDateOfBirth);
            this.pnlCenter.Controls.Add(this.cbbClassID);
            this.pnlCenter.Controls.Add(this.rbtFemale);
            this.pnlCenter.Controls.Add(this.rbtMale);
            this.pnlCenter.Controls.Add(this.btnSearch);
            this.pnlCenter.Controls.Add(this.cbbSearch);
            this.pnlCenter.Controls.Add(this.lblSearch);
            this.pnlCenter.Controls.Add(this.txtSearch);
            this.pnlCenter.Controls.Add(this.dgvStudent);
            this.pnlCenter.Controls.Add(this.txtName);
            this.pnlCenter.Controls.Add(this.lblClassID);
            this.pnlCenter.Controls.Add(this.lblGender);
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
            this.pnlCenter.TabIndex = 20;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(140, 494);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(169, 28);
            this.dtpDateOfBirth.TabIndex = 24;
            // 
            // cbbClassID
            // 
            this.cbbClassID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClassID.FormattingEnabled = true;
            this.cbbClassID.Location = new System.Drawing.Point(669, 446);
            this.cbbClassID.Name = "cbbClassID";
            this.cbbClassID.Size = new System.Drawing.Size(74, 29);
            this.cbbClassID.TabIndex = 23;
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(218, 447);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(91, 25);
            this.rbtFemale.TabIndex = 22;
            this.rbtFemale.Text = "Female";
            this.rbtFemale.UseVisualStyleBackColor = true;
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Checked = true;
            this.rbtMale.Location = new System.Drawing.Point(140, 447);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(74, 25);
            this.rbtMale.TabIndex = 21;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Male";
            this.rbtMale.UseVisualStyleBackColor = true;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(427, 396);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 28);
            this.txtName.TabIndex = 12;
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
            // txtHometown
            // 
            this.txtHometown.Location = new System.Drawing.Point(427, 446);
            this.txtHometown.Name = "txtHometown";
            this.txtHometown.Size = new System.Drawing.Size(149, 28);
            this.txtHometown.TabIndex = 14;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(140, 396);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(169, 28);
            this.txtStudentID.TabIndex = 11;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Brown;
            this.pnlBottom.Controls.Add(this.btnDelete);
            this.pnlBottom.Controls.Add(this.btnReload);
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 664);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(764, 59);
            this.pnlBottom.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(520, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Walter Turncoat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Students";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Brown;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(764, 77);
            this.pnlTop.TabIndex = 18;
            // 
            // Student_Manage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 723);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Student_Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Manage";
            this.Load += new System.EventHandler(this.Student_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHometown;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtHometown;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.ComboBox cbbClassID;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnDelete;
    }
}