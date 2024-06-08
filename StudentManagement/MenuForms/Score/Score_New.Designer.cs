namespace StudentManagement.MenuForms.Score
{
    partial class Score_New
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
            this.cbbCourseID = new System.Windows.Forms.ComboBox();
            this.nudScore2 = new System.Windows.Forms.NumericUpDown();
            this.nudScore1 = new System.Windows.Forms.NumericUpDown();
            this.nudSemester = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.dgvScore = new System.Windows.Forms.DataGridView();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.cbbCourseID);
            this.pnlCenter.Controls.Add(this.nudScore2);
            this.pnlCenter.Controls.Add(this.nudScore1);
            this.pnlCenter.Controls.Add(this.nudSemester);
            this.pnlCenter.Controls.Add(this.nudYear);
            this.pnlCenter.Controls.Add(this.lblSemester);
            this.pnlCenter.Controls.Add(this.lblYear);
            this.pnlCenter.Controls.Add(this.lblScore2);
            this.pnlCenter.Controls.Add(this.lblScore1);
            this.pnlCenter.Controls.Add(this.lblCourseID);
            this.pnlCenter.Controls.Add(this.dgvScore);
            this.pnlCenter.Controls.Add(this.lblStudentID);
            this.pnlCenter.Controls.Add(this.txtStudentID);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 77);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(764, 587);
            this.pnlCenter.TabIndex = 29;
            // 
            // cbbCourseID
            // 
            this.cbbCourseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCourseID.FormattingEnabled = true;
            this.cbbCourseID.Location = new System.Drawing.Point(140, 429);
            this.cbbCourseID.Name = "cbbCourseID";
            this.cbbCourseID.Size = new System.Drawing.Size(121, 29);
            this.cbbCourseID.TabIndex = 39;
            // 
            // nudScore2
            // 
            this.nudScore2.DecimalPlaces = 2;
            this.nudScore2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudScore2.Location = new System.Drawing.Point(592, 380);
            this.nudScore2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudScore2.Name = "nudScore2";
            this.nudScore2.Size = new System.Drawing.Size(70, 28);
            this.nudScore2.TabIndex = 38;
            // 
            // nudScore1
            // 
            this.nudScore1.DecimalPlaces = 2;
            this.nudScore1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudScore1.Location = new System.Drawing.Point(419, 380);
            this.nudScore1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudScore1.Name = "nudScore1";
            this.nudScore1.Size = new System.Drawing.Size(70, 28);
            this.nudScore1.TabIndex = 37;
            // 
            // nudSemester
            // 
            this.nudSemester.Location = new System.Drawing.Point(326, 482);
            this.nudSemester.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSemester.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSemester.Name = "nudSemester";
            this.nudSemester.Size = new System.Drawing.Size(70, 28);
            this.nudSemester.TabIndex = 36;
            this.nudSemester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(140, 482);
            this.nudYear.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(70, 28);
            this.nudYear.TabIndex = 35;
            this.nudYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSemester.Location = new System.Drawing.Point(230, 484);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(90, 21);
            this.lblSemester.TabIndex = 29;
            this.lblSemester.Text = "Semester:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.Color.Firebrick;
            this.lblYear.Location = new System.Drawing.Point(80, 484);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(54, 21);
            this.lblYear.TabIndex = 27;
            this.lblYear.Text = "Year:";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.ForeColor = System.Drawing.Color.Firebrick;
            this.lblScore2.Location = new System.Drawing.Point(511, 383);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(75, 21);
            this.lblScore2.TabIndex = 25;
            this.lblScore2.Text = "Score 2:";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.ForeColor = System.Drawing.Color.Firebrick;
            this.lblScore1.Location = new System.Drawing.Point(338, 383);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(75, 21);
            this.lblScore1.TabIndex = 23;
            this.lblScore1.Text = "Score 1:";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCourseID.Location = new System.Drawing.Point(38, 433);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(96, 21);
            this.lblCourseID.TabIndex = 21;
            this.lblCourseID.Text = "Course ID:";
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
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblStudentID.Location = new System.Drawing.Point(31, 383);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(103, 21);
            this.lblStudentID.TabIndex = 5;
            this.lblStudentID.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(140, 380);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(169, 28);
            this.txtStudentID.TabIndex = 11;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Walter Turncoat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "New Score";
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
            this.pnlBottom.TabIndex = 28;
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
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Brown;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(764, 77);
            this.pnlTop.TabIndex = 27;
            // 
            // Score_New
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
            this.Name = "Score_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score_New";
            this.Load += new System.EventHandler(this.Score_New_Load);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.DataGridView dgvScore;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.NumericUpDown nudSemester;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.NumericUpDown nudScore2;
        private System.Windows.Forms.NumericUpDown nudScore1;
        private System.Windows.Forms.ComboBox cbbCourseID;
    }
}