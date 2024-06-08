namespace StudentManagement.MenuForms.Academic_Course
{
    partial class AcaCourse_Info
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
            this.pnlCenter = new System.Windows.Forms.Panel();
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
            this.dgvAcaCourse = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcaCourse)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.White;
            this.pnlCenter.Controls.Add(this.txtNoStudent);
            this.pnlCenter.Controls.Add(this.lblNoStudent);
            this.pnlCenter.Controls.Add(this.btnSearch);
            this.pnlCenter.Controls.Add(this.cbbSearch);
            this.pnlCenter.Controls.Add(this.lblSearch);
            this.pnlCenter.Controls.Add(this.txtSearch);
            this.pnlCenter.Controls.Add(this.txtTeacherID);
            this.pnlCenter.Controls.Add(this.txtCourseID);
            this.pnlCenter.Controls.Add(this.txtYearID);
            this.pnlCenter.Controls.Add(this.lblYear);
            this.pnlCenter.Controls.Add(this.lblYearID);
            this.pnlCenter.Controls.Add(this.txtYear);
            this.pnlCenter.Controls.Add(this.lblCourseID);
            this.pnlCenter.Controls.Add(this.lblTeacherID);
            this.pnlCenter.Controls.Add(this.lblAcaCourseID);
            this.pnlCenter.Controls.Add(this.txtAcaCourseID);
            this.pnlCenter.Controls.Add(this.dgvAcaCourse);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCenter.Location = new System.Drawing.Point(0, 77);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(764, 587);
            this.pnlCenter.TabIndex = 20;
            // 
            // txtNoStudent
            // 
            this.txtNoStudent.Location = new System.Drawing.Point(481, 497);
            this.txtNoStudent.Name = "txtNoStudent";
            this.txtNoStudent.ReadOnly = true;
            this.txtNoStudent.Size = new System.Drawing.Size(219, 28);
            this.txtNoStudent.TabIndex = 38;
            // 
            // lblNoStudent
            // 
            this.lblNoStudent.AutoSize = true;
            this.lblNoStudent.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNoStudent.Location = new System.Drawing.Point(369, 500);
            this.lblNoStudent.Name = "lblNoStudent";
            this.lblNoStudent.Size = new System.Drawing.Size(116, 21);
            this.lblNoStudent.TabIndex = 37;
            this.lblNoStudent.Text = "No Studetns:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(621, 347);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 34);
            this.btnSearch.TabIndex = 36;
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
            "Year"});
            this.cbbSearch.Location = new System.Drawing.Point(131, 351);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(169, 29);
            this.cbbSearch.TabIndex = 35;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSearch.Location = new System.Drawing.Point(28, 354);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(97, 21);
            this.lblSearch.TabIndex = 33;
            this.lblSearch.Text = "Search by:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(310, 351);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 28);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Location = new System.Drawing.Point(198, 493);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.ReadOnly = true;
            this.txtTeacherID.Size = new System.Drawing.Size(169, 28);
            this.txtTeacherID.TabIndex = 32;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(482, 396);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.ReadOnly = true;
            this.txtCourseID.Size = new System.Drawing.Size(218, 28);
            this.txtCourseID.TabIndex = 28;
            // 
            // txtYearID
            // 
            this.txtYearID.Location = new System.Drawing.Point(198, 446);
            this.txtYearID.Name = "txtYearID";
            this.txtYearID.ReadOnly = true;
            this.txtYearID.Size = new System.Drawing.Size(169, 28);
            this.txtYearID.TabIndex = 29;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.Color.Firebrick;
            this.lblYear.Location = new System.Drawing.Point(421, 452);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(54, 21);
            this.lblYear.TabIndex = 26;
            this.lblYear.Text = "Year:";
            // 
            // lblYearID
            // 
            this.lblYearID.AutoSize = true;
            this.lblYearID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblYearID.Location = new System.Drawing.Point(115, 449);
            this.lblYearID.Name = "lblYearID";
            this.lblYearID.Size = new System.Drawing.Size(77, 21);
            this.lblYearID.TabIndex = 23;
            this.lblYearID.Text = "Year ID:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(482, 449);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(218, 28);
            this.txtYear.TabIndex = 31;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCourseID.Location = new System.Drawing.Point(379, 399);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(96, 21);
            this.lblCourseID.TabIndex = 22;
            this.lblCourseID.Text = "Course ID:";
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTeacherID.Location = new System.Drawing.Point(86, 496);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(106, 21);
            this.lblTeacherID.TabIndex = 24;
            this.lblTeacherID.Text = "Teacher ID:";
            // 
            // lblAcaCourseID
            // 
            this.lblAcaCourseID.AutoSize = true;
            this.lblAcaCourseID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAcaCourseID.Location = new System.Drawing.Point(55, 399);
            this.lblAcaCourseID.Name = "lblAcaCourseID";
            this.lblAcaCourseID.Size = new System.Drawing.Size(137, 21);
            this.lblAcaCourseID.TabIndex = 21;
            this.lblAcaCourseID.Text = "Aca Course ID:";
            // 
            // txtAcaCourseID
            // 
            this.txtAcaCourseID.Location = new System.Drawing.Point(198, 396);
            this.txtAcaCourseID.Name = "txtAcaCourseID";
            this.txtAcaCourseID.ReadOnly = true;
            this.txtAcaCourseID.Size = new System.Drawing.Size(169, 28);
            this.txtAcaCourseID.TabIndex = 27;
            // 
            // dgvAcaCourse
            // 
            this.dgvAcaCourse.AllowUserToAddRows = false;
            this.dgvAcaCourse.AllowUserToDeleteRows = false;
            this.dgvAcaCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcaCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAcaCourse.Location = new System.Drawing.Point(0, 0);
            this.dgvAcaCourse.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAcaCourse.Name = "dgvAcaCourse";
            this.dgvAcaCourse.ReadOnly = true;
            this.dgvAcaCourse.RowHeadersWidth = 51;
            this.dgvAcaCourse.RowTemplate.Height = 24;
            this.dgvAcaCourse.Size = new System.Drawing.Size(764, 322);
            this.dgvAcaCourse.TabIndex = 3;
            this.dgvAcaCourse.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcaCourse_CellEnter);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(639, 13);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(113, 34);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Brown;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(764, 77);
            this.pnlTop.TabIndex = 18;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(386, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Academic Course Information";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Brown;
            this.pnlBottom.Controls.Add(this.btnExport);
            this.pnlBottom.Controls.Add(this.btnReload);
            this.pnlBottom.Controls.Add(this.btnPrint);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 664);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(764, 59);
            this.pnlBottom.TabIndex = 19;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExport.Location = new System.Drawing.Point(520, 13);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(113, 34);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // AcaCourse_Info
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(764, 723);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AcaCourse_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturer_Infor";
            this.Load += new System.EventHandler(this.AcaCourse_Infor_Load);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcaCourse)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.DataGridView dgvAcaCourse;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnReload;
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
        private System.Windows.Forms.TextBox txtNoStudent;
        private System.Windows.Forms.Label lblNoStudent;
    }
}