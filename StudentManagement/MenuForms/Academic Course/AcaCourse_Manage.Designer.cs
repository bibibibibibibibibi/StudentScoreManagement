namespace StudentManagement.MenuForms.Academic_Course
{
    partial class AcaCourse_Manage
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
            this.dgvAcaCourse = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNoStudent = new System.Windows.Forms.TextBox();
            this.lblNoStudent = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtYearID = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearID = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.lblAcaCourseID = new System.Windows.Forms.Label();
            this.txtAcaCourseID = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcaCourse)).BeginInit();
            this.pnlBottom.SuspendLayout();
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
            this.pnlTop.TabIndex = 28;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(347, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Academic Course";
            // 
            // dgvAcaCourse
            // 
            this.dgvAcaCourse.AllowUserToAddRows = false;
            this.dgvAcaCourse.AllowUserToDeleteRows = false;
            this.dgvAcaCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcaCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAcaCourse.Location = new System.Drawing.Point(0, 77);
            this.dgvAcaCourse.Name = "dgvAcaCourse";
            this.dgvAcaCourse.ReadOnly = true;
            this.dgvAcaCourse.RowHeadersWidth = 51;
            this.dgvAcaCourse.RowTemplate.Height = 24;
            this.dgvAcaCourse.Size = new System.Drawing.Size(764, 322);
            this.dgvAcaCourse.TabIndex = 29;
            this.dgvAcaCourse.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcaCourse_CellEnter);
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
            this.pnlBottom.TabIndex = 30;
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
            // txtNoStudent
            // 
            this.txtNoStudent.Location = new System.Drawing.Point(483, 570);
            this.txtNoStudent.Name = "txtNoStudent";
            this.txtNoStudent.Size = new System.Drawing.Size(219, 28);
            this.txtNoStudent.TabIndex = 54;
            // 
            // lblNoStudent
            // 
            this.lblNoStudent.AutoSize = true;
            this.lblNoStudent.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNoStudent.Location = new System.Drawing.Point(371, 573);
            this.lblNoStudent.Name = "lblNoStudent";
            this.lblNoStudent.Size = new System.Drawing.Size(116, 21);
            this.lblNoStudent.TabIndex = 53;
            this.lblNoStudent.Text = "No Studetns:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(623, 420);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 34);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbSearch
            // 
            this.cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Items.AddRange(new object[] {
            "AcaCourse ID",
            "Subject ID",
            "Year",
            "School Year"});
            this.cbbSearch.Location = new System.Drawing.Point(133, 424);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(169, 29);
            this.cbbSearch.TabIndex = 51;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSearch.Location = new System.Drawing.Point(30, 427);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(97, 21);
            this.lblSearch.TabIndex = 49;
            this.lblSearch.Text = "Search by:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(312, 424);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 28);
            this.txtSearch.TabIndex = 50;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Location = new System.Drawing.Point(200, 566);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(169, 28);
            this.txtTeacherID.TabIndex = 48;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(484, 469);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(218, 28);
            this.txtCourseID.TabIndex = 45;
            // 
            // txtYearID
            // 
            this.txtYearID.Location = new System.Drawing.Point(200, 519);
            this.txtYearID.Name = "txtYearID";
            this.txtYearID.Size = new System.Drawing.Size(169, 28);
            this.txtYearID.TabIndex = 46;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.Color.Firebrick;
            this.lblYear.Location = new System.Drawing.Point(423, 525);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(54, 21);
            this.lblYear.TabIndex = 43;
            this.lblYear.Text = "Year:";
            // 
            // lblYearID
            // 
            this.lblYearID.AutoSize = true;
            this.lblYearID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblYearID.Location = new System.Drawing.Point(117, 522);
            this.lblYearID.Name = "lblYearID";
            this.lblYearID.Size = new System.Drawing.Size(77, 21);
            this.lblYearID.TabIndex = 41;
            this.lblYearID.Text = "Year ID:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(484, 522);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(218, 28);
            this.txtYear.TabIndex = 47;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCourseID.Location = new System.Drawing.Point(381, 472);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(96, 21);
            this.lblCourseID.TabIndex = 40;
            this.lblCourseID.Text = "Course ID:";
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTeacherID.Location = new System.Drawing.Point(88, 569);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(106, 21);
            this.lblTeacherID.TabIndex = 42;
            this.lblTeacherID.Text = "Teacher ID:";
            // 
            // lblAcaCourseID
            // 
            this.lblAcaCourseID.AutoSize = true;
            this.lblAcaCourseID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAcaCourseID.Location = new System.Drawing.Point(57, 472);
            this.lblAcaCourseID.Name = "lblAcaCourseID";
            this.lblAcaCourseID.Size = new System.Drawing.Size(137, 21);
            this.lblAcaCourseID.TabIndex = 39;
            this.lblAcaCourseID.Text = "Aca Course ID:";
            // 
            // txtAcaCourseID
            // 
            this.txtAcaCourseID.Location = new System.Drawing.Point(200, 469);
            this.txtAcaCourseID.Name = "txtAcaCourseID";
            this.txtAcaCourseID.Size = new System.Drawing.Size(169, 28);
            this.txtAcaCourseID.TabIndex = 44;
            // 
            // AcaCourse_Manage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(764, 723);
            this.ControlBox = false;
            this.Controls.Add(this.txtNoStudent);
            this.Controls.Add(this.lblNoStudent);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtTeacherID);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.txtYearID);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblYearID);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.lblTeacherID);
            this.Controls.Add(this.lblAcaCourseID);
            this.Controls.Add(this.txtAcaCourseID);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.dgvAcaCourse);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcaCourse_Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcaCourse_Manage";
            this.Load += new System.EventHandler(this.AcaCourse_Manage_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcaCourse)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvAcaCourse;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNoStudent;
        private System.Windows.Forms.Label lblNoStudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtYearID;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblYearID;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.Label lblAcaCourseID;
        private System.Windows.Forms.TextBox txtAcaCourseID;
    }
}