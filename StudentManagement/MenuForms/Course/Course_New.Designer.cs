namespace StudentManagement.MenuForms.Course
{
    partial class Course_New
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
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCredits = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.nudCredits = new System.Windows.Forms.NumericUpDown();
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
            this.lblTitle.Size = new System.Drawing.Size(173, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "New Course";
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
            this.pnlBottom.TabIndex = 25;
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
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCredits.Location = new System.Drawing.Point(53, 437);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(74, 21);
            this.lblCredits.TabIndex = 21;
            this.lblCredits.Text = "Credits:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(427, 384);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 28);
            this.txtName.TabIndex = 12;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(140, 384);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(169, 28);
            this.txtCourseID.TabIndex = 11;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.nudCredits);
            this.pnlCenter.Controls.Add(this.lblCredits);
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
            this.nudCredits.Location = new System.Drawing.Point(140, 435);
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
            this.nudCredits.TabIndex = 23;
            this.nudCredits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblName.Location = new System.Drawing.Point(355, 387);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 21);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCourseID.Location = new System.Drawing.Point(31, 387);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(96, 21);
            this.lblCourseID.TabIndex = 5;
            this.lblCourseID.Text = "Course ID:";
            // 
            // Course_New
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
            this.Name = "Course_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course_New";
            this.Load += new System.EventHandler(this.Course_New_Load);
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.NumericUpDown nudCredits;
    }
}