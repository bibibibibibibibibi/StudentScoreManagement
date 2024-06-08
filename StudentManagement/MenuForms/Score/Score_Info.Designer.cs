namespace StudentManagement.MenuForms.Score
{
    partial class Score_Info
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
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.lblScale4 = new System.Windows.Forms.Label();
            this.txtAverage4 = new System.Windows.Forms.TextBox();
            this.lblScale10 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtAverage10 = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvScore = new System.Windows.Forms.DataGridView();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(140, 446);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.ReadOnly = true;
            this.txtCourseID.Size = new System.Drawing.Size(169, 28);
            this.txtCourseID.TabIndex = 22;
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
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Score Information";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Brown;
            this.pnlBottom.Controls.Add(this.btnReport);
            this.pnlBottom.Controls.Add(this.btnExport);
            this.pnlBottom.Controls.Add(this.btnReload);
            this.pnlBottom.Controls.Add(this.btnPrint);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 664);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(764, 59);
            this.pnlBottom.TabIndex = 25;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Location = new System.Drawing.Point(12, 13);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(122, 34);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Get Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
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
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCourseID.Location = new System.Drawing.Point(38, 449);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(96, 21);
            this.lblCourseID.TabIndex = 21;
            this.lblCourseID.Text = "Course ID:";
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
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(140, 396);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(169, 28);
            this.txtStudentID.TabIndex = 11;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.txtGPA);
            this.pnlCenter.Controls.Add(this.lblScale4);
            this.pnlCenter.Controls.Add(this.txtAverage4);
            this.pnlCenter.Controls.Add(this.lblScale10);
            this.pnlCenter.Controls.Add(this.txtResults);
            this.pnlCenter.Controls.Add(this.lblResults);
            this.pnlCenter.Controls.Add(this.txtScore2);
            this.pnlCenter.Controls.Add(this.txtScore1);
            this.pnlCenter.Controls.Add(this.txtAverage10);
            this.pnlCenter.Controls.Add(this.lblAverage);
            this.pnlCenter.Controls.Add(this.txtSemester);
            this.pnlCenter.Controls.Add(this.lblSemester);
            this.pnlCenter.Controls.Add(this.txtYear);
            this.pnlCenter.Controls.Add(this.lblYear);
            this.pnlCenter.Controls.Add(this.lblScore2);
            this.pnlCenter.Controls.Add(this.lblScore1);
            this.pnlCenter.Controls.Add(this.txtCourseID);
            this.pnlCenter.Controls.Add(this.lblCourseID);
            this.pnlCenter.Controls.Add(this.btnSearch);
            this.pnlCenter.Controls.Add(this.cbbSearch);
            this.pnlCenter.Controls.Add(this.lblSearch);
            this.pnlCenter.Controls.Add(this.txtSearch);
            this.pnlCenter.Controls.Add(this.dgvScore);
            this.pnlCenter.Controls.Add(this.lblStudentID);
            this.pnlCenter.Controls.Add(this.txtStudentID);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 77);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(764, 646);
            this.pnlCenter.TabIndex = 26;
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(663, 446);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.ReadOnly = true;
            this.txtGPA.Size = new System.Drawing.Size(63, 28);
            this.txtGPA.TabIndex = 41;
            // 
            // lblScale4
            // 
            this.lblScale4.AutoSize = true;
            this.lblScale4.ForeColor = System.Drawing.Color.Firebrick;
            this.lblScale4.Location = new System.Drawing.Point(616, 449);
            this.lblScale4.Name = "lblScale4";
            this.lblScale4.Size = new System.Drawing.Size(26, 21);
            this.lblScale4.TabIndex = 40;
            this.lblScale4.Text = "/4";
            // 
            // txtAverage4
            // 
            this.txtAverage4.Location = new System.Drawing.Point(547, 446);
            this.txtAverage4.Name = "txtAverage4";
            this.txtAverage4.ReadOnly = true;
            this.txtAverage4.Size = new System.Drawing.Size(63, 28);
            this.txtAverage4.TabIndex = 39;
            // 
            // lblScale10
            // 
            this.lblScale10.AutoSize = true;
            this.lblScale10.ForeColor = System.Drawing.Color.Firebrick;
            this.lblScale10.Location = new System.Drawing.Point(503, 449);
            this.lblScale10.Name = "lblScale10";
            this.lblScale10.Size = new System.Drawing.Size(35, 21);
            this.lblScale10.TabIndex = 37;
            this.lblScale10.Text = "/10";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(564, 497);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(87, 28);
            this.txtResults.TabIndex = 36;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.ForeColor = System.Drawing.Color.Firebrick;
            this.lblResults.Location = new System.Drawing.Point(488, 500);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(70, 21);
            this.lblResults.TabIndex = 35;
            this.lblResults.Text = "Results:";
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(593, 396);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.ReadOnly = true;
            this.txtScore2.Size = new System.Drawing.Size(70, 28);
            this.txtScore2.TabIndex = 34;
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(420, 396);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.ReadOnly = true;
            this.txtScore1.Size = new System.Drawing.Size(70, 28);
            this.txtScore1.TabIndex = 33;
            // 
            // txtAverage10
            // 
            this.txtAverage10.Location = new System.Drawing.Point(434, 446);
            this.txtAverage10.Name = "txtAverage10";
            this.txtAverage10.ReadOnly = true;
            this.txtAverage10.Size = new System.Drawing.Size(63, 28);
            this.txtAverage10.TabIndex = 32;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAverage.Location = new System.Drawing.Point(339, 449);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(89, 21);
            this.lblAverage.TabIndex = 31;
            this.lblAverage.Text = "Average:";
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(326, 497);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.ReadOnly = true;
            this.txtSemester.Size = new System.Drawing.Size(70, 28);
            this.txtSemester.TabIndex = 30;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSemester.Location = new System.Drawing.Point(230, 500);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(90, 21);
            this.lblSemester.TabIndex = 29;
            this.lblSemester.Text = "Semester:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(140, 497);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(70, 28);
            this.txtYear.TabIndex = 28;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.Color.Firebrick;
            this.lblYear.Location = new System.Drawing.Point(80, 500);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(54, 21);
            this.lblYear.TabIndex = 27;
            this.lblYear.Text = "Year:";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.ForeColor = System.Drawing.Color.Firebrick;
            this.lblScore2.Location = new System.Drawing.Point(512, 399);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(75, 21);
            this.lblScore2.TabIndex = 25;
            this.lblScore2.Text = "Score 2:";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.ForeColor = System.Drawing.Color.Firebrick;
            this.lblScore1.Location = new System.Drawing.Point(339, 399);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(75, 21);
            this.lblScore1.TabIndex = 23;
            this.lblScore1.Text = "Score 1:";
            // 
            // cbbSearch
            // 
            this.cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Items.AddRange(new object[] {
            "Student ID",
            "Course ID",
            "(Score 1) Lower than",
            "(Score 1) Higher than",
            "(Score 2) Lower than",
            "(Score 2) Higher than"});
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
            // 
            // dgvScore
            // 
            this.dgvScore.AllowUserToAddRows = false;
            this.dgvScore.AllowUserToDeleteRows = false;
            this.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvScore.Location = new System.Drawing.Point(0, 0);
            this.dgvScore.Name = "dgvScore";
            this.dgvScore.ReadOnly = true;
            this.dgvScore.RowHeadersWidth = 51;
            this.dgvScore.RowTemplate.Height = 24;
            this.dgvScore.Size = new System.Drawing.Size(764, 322);
            this.dgvScore.TabIndex = 3;
            this.dgvScore.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScore_CellEnter);
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
            // Score_Info
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
            this.Name = "Score_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score_Info";
            this.Load += new System.EventHandler(this.Score_Info_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvScore;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.TextBox txtAverage10;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblScale4;
        private System.Windows.Forms.TextBox txtAverage4;
        private System.Windows.Forms.Label lblScale10;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnReport;
    }
}