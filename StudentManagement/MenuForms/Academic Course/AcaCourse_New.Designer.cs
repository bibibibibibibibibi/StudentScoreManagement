namespace StudentManagement.MenuForms.Academic_Course
{
    partial class AcaCourse_New
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
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNoStudent = new System.Windows.Forms.TextBox();
            this.lblNoStudent = new System.Windows.Forms.Label();
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
            this.lblTitle.Size = new System.Drawing.Size(300, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "New Academic Course";
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
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Brown;
            this.pnlBottom.Controls.Add(this.btnReload);
            this.pnlBottom.Controls.Add(this.btnAdd);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 664);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(764, 59);
            this.pnlBottom.TabIndex = 30;
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
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(639, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNoStudent
            // 
            this.txtNoStudent.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoStudent.Location = new System.Drawing.Point(480, 546);
            this.txtNoStudent.Name = "txtNoStudent";
            this.txtNoStudent.Size = new System.Drawing.Size(219, 28);
            this.txtNoStudent.TabIndex = 54;
            // 
            // lblNoStudent
            // 
            this.lblNoStudent.AutoSize = true;
            this.lblNoStudent.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNoStudent.Location = new System.Drawing.Point(369, 553);
            this.lblNoStudent.Name = "lblNoStudent";
            this.lblNoStudent.Size = new System.Drawing.Size(116, 21);
            this.lblNoStudent.TabIndex = 53;
            this.lblNoStudent.Text = "No Studetns:";
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.BackColor = System.Drawing.SystemColors.Window;
            this.txtTeacherID.Location = new System.Drawing.Point(198, 546);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(169, 28);
            this.txtTeacherID.TabIndex = 48;
            // 
            // txtCourseID
            // 
            this.txtCourseID.BackColor = System.Drawing.SystemColors.Window;
            this.txtCourseID.Location = new System.Drawing.Point(481, 426);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(218, 28);
            this.txtCourseID.TabIndex = 45;
            // 
            // txtYearID
            // 
            this.txtYearID.BackColor = System.Drawing.SystemColors.Window;
            this.txtYearID.Location = new System.Drawing.Point(197, 482);
            this.txtYearID.Name = "txtYearID";
            this.txtYearID.Size = new System.Drawing.Size(169, 28);
            this.txtYearID.TabIndex = 46;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.Color.Firebrick;
            this.lblYear.Location = new System.Drawing.Point(420, 488);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(54, 21);
            this.lblYear.TabIndex = 43;
            this.lblYear.Text = "Year:";
            // 
            // lblYearID
            // 
            this.lblYearID.AutoSize = true;
            this.lblYearID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblYearID.Location = new System.Drawing.Point(114, 485);
            this.lblYearID.Name = "lblYearID";
            this.lblYearID.Size = new System.Drawing.Size(77, 21);
            this.lblYearID.TabIndex = 41;
            this.lblYearID.Text = "Year ID:";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.SystemColors.Window;
            this.txtYear.Location = new System.Drawing.Point(481, 485);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(218, 28);
            this.txtYear.TabIndex = 47;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCourseID.Location = new System.Drawing.Point(378, 429);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(96, 21);
            this.lblCourseID.TabIndex = 40;
            this.lblCourseID.Text = "Course ID:";
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTeacherID.Location = new System.Drawing.Point(86, 549);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(106, 21);
            this.lblTeacherID.TabIndex = 42;
            this.lblTeacherID.Text = "Teacher ID:";
            // 
            // lblAcaCourseID
            // 
            this.lblAcaCourseID.AutoSize = true;
            this.lblAcaCourseID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAcaCourseID.Location = new System.Drawing.Point(54, 429);
            this.lblAcaCourseID.Name = "lblAcaCourseID";
            this.lblAcaCourseID.Size = new System.Drawing.Size(137, 21);
            this.lblAcaCourseID.TabIndex = 39;
            this.lblAcaCourseID.Text = "Aca Course ID:";
            // 
            // txtAcaCourseID
            // 
            this.txtAcaCourseID.BackColor = System.Drawing.SystemColors.Window;
            this.txtAcaCourseID.Location = new System.Drawing.Point(197, 426);
            this.txtAcaCourseID.Name = "txtAcaCourseID";
            this.txtAcaCourseID.Size = new System.Drawing.Size(169, 28);
            this.txtAcaCourseID.TabIndex = 44;
            // 
            // AcaCourse_New
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(764, 723);
            this.ControlBox = false;
            this.Controls.Add(this.txtNoStudent);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.lblNoStudent);
            this.Controls.Add(this.dgvAcaCourse);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.txtAcaCourseID);
            this.Controls.Add(this.lblAcaCourseID);
            this.Controls.Add(this.txtTeacherID);
            this.Controls.Add(this.lblTeacherID);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.txtYearID);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblYearID);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcaCourse_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcaCourse_New";
            this.Load += new System.EventHandler(this.AcaCourse_New_Load);
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
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNoStudent;
        private System.Windows.Forms.Label lblNoStudent;
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