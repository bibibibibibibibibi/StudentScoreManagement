namespace StudentManagement.MenuForms.Course
{
    partial class Course_Manage
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCredits = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.nudCredits = new System.Windows.Forms.NumericUpDown();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(228, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Course";
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
            this.pnlBottom.TabIndex = 25;
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
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCredits.Location = new System.Drawing.Point(53, 449);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(74, 21);
            this.lblCredits.TabIndex = 21;
            this.lblCredits.Text = "Credits:";
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
            this.txtName.Size = new System.Drawing.Size(249, 28);
            this.txtName.TabIndex = 12;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(140, 396);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.ReadOnly = true;
            this.txtCourseID.Size = new System.Drawing.Size(169, 28);
            this.txtCourseID.TabIndex = 11;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.nudCredits);
            this.pnlCenter.Controls.Add(this.lblCredits);
            this.pnlCenter.Controls.Add(this.btnSearch);
            this.pnlCenter.Controls.Add(this.cbbSearch);
            this.pnlCenter.Controls.Add(this.lblSearch);
            this.pnlCenter.Controls.Add(this.txtSearch);
            this.pnlCenter.Controls.Add(this.dgvCourse);
            this.pnlCenter.Controls.Add(this.txtName);
            this.pnlCenter.Controls.Add(this.lblName);
            this.pnlCenter.Controls.Add(this.lblCourseID);
            this.pnlCenter.Controls.Add(this.txtCourseID);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 77);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(764, 646);
            this.pnlCenter.TabIndex = 26;
            // 
            // nudCredits
            // 
            this.nudCredits.Location = new System.Drawing.Point(140, 447);
            this.nudCredits.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCredits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCredits.Name = "nudCredits";
            this.nudCredits.Size = new System.Drawing.Size(101, 28);
            this.nudCredits.TabIndex = 24;
            this.nudCredits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbSearch
            // 
            this.cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Items.AddRange(new object[] {
            "Course ID",
            "Name",
            "Credits"});
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
            // dgvCourse
            // 
            this.dgvCourse.AllowUserToAddRows = false;
            this.dgvCourse.AllowUserToDeleteRows = false;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCourse.Location = new System.Drawing.Point(0, 0);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            this.dgvCourse.RowHeadersWidth = 51;
            this.dgvCourse.RowTemplate.Height = 24;
            this.dgvCourse.Size = new System.Drawing.Size(764, 322);
            this.dgvCourse.TabIndex = 3;
            this.dgvCourse.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourse_CellEnter);
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
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCourseID.Location = new System.Drawing.Point(31, 399);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(96, 21);
            this.lblCourseID.TabIndex = 5;
            this.lblCourseID.Text = "Course ID:";
            // 
            // Course_Manage
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
            this.Name = "Course_Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course_Manage";
            this.Load += new System.EventHandler(this.Course_Manage_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown nudCredits;
    }
}