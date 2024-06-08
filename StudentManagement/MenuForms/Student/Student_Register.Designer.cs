namespace StudentManagement.MenuForms.Student
{
    partial class Student_Register
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.cbbClassID = new System.Windows.Forms.ComboBox();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
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
            this.btnReload.Location = new System.Drawing.Point(520, 13);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(113, 34);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegister.Location = new System.Drawing.Point(639, 13);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(113, 34);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.cbbClassID);
            this.pnlCenter.Controls.Add(this.rbtFemale);
            this.pnlCenter.Controls.Add(this.rbtMale);
            this.pnlCenter.Controls.Add(this.dtpDateOfBirth);
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
            // cbbClassID
            // 
            this.cbbClassID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClassID.FormattingEnabled = true;
            this.cbbClassID.Location = new System.Drawing.Point(669, 417);
            this.cbbClassID.Name = "cbbClassID";
            this.cbbClassID.Size = new System.Drawing.Size(74, 29);
            this.cbbClassID.TabIndex = 16;
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(218, 419);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(91, 25);
            this.rbtFemale.TabIndex = 14;
            this.rbtFemale.Text = "Female";
            this.rbtFemale.UseVisualStyleBackColor = true;
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Checked = true;
            this.rbtMale.Location = new System.Drawing.Point(140, 419);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(74, 25);
            this.rbtMale.TabIndex = 13;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Male";
            this.rbtMale.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(140, 466);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(169, 28);
            this.dtpDateOfBirth.TabIndex = 17;
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
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(427, 368);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 28);
            this.txtName.TabIndex = 12;
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblClassID.Location = new System.Drawing.Point(582, 421);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(81, 21);
            this.lblClassID.TabIndex = 10;
            this.lblClassID.Text = "Class ID:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGender.Location = new System.Drawing.Point(55, 421);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(79, 21);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblName.Location = new System.Drawing.Point(355, 371);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 21);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // lblHometown
            // 
            this.lblHometown.AutoSize = true;
            this.lblHometown.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHometown.Location = new System.Drawing.Point(315, 421);
            this.lblHometown.Name = "lblHometown";
            this.lblHometown.Size = new System.Drawing.Size(106, 21);
            this.lblHometown.TabIndex = 9;
            this.lblHometown.Text = "Hometown:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDateOfBirth.Location = new System.Drawing.Point(15, 472);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(119, 21);
            this.lblDateOfBirth.TabIndex = 8;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblStudentID.Location = new System.Drawing.Point(31, 371);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(103, 21);
            this.lblStudentID.TabIndex = 5;
            this.lblStudentID.Text = "Student ID:";
            // 
            // txtHometown
            // 
            this.txtHometown.Location = new System.Drawing.Point(427, 418);
            this.txtHometown.Name = "txtHometown";
            this.txtHometown.Size = new System.Drawing.Size(149, 28);
            this.txtHometown.TabIndex = 15;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(140, 368);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(169, 28);
            this.txtStudentID.TabIndex = 11;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Brown;
            this.pnlBottom.Controls.Add(this.btnReload);
            this.pnlBottom.Controls.Add(this.btnRegister);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 664);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(764, 59);
            this.pnlBottom.TabIndex = 19;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Walter Turncoat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Register Student";
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
            // Student_Register
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
            this.Name = "Student_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Register";
            this.Load += new System.EventHandler(this.Student_Register_Load);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.DataGridView dgvStudent;
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
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.ComboBox cbbClassID;
    }
}