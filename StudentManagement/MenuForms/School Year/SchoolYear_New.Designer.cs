namespace StudentManagement.MenuForms.School_Year
{
    partial class SchoolYear_New
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
            this.dgvSchoolYear = new System.Windows.Forms.DataGridView();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblYearID = new System.Windows.Forms.Label();
            this.txtYearID = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolYear)).BeginInit();
            this.pnlCenter.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSchoolYear
            // 
            this.dgvSchoolYear.AllowUserToAddRows = false;
            this.dgvSchoolYear.AllowUserToDeleteRows = false;
            this.dgvSchoolYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchoolYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSchoolYear.Location = new System.Drawing.Point(0, 0);
            this.dgvSchoolYear.Name = "dgvSchoolYear";
            this.dgvSchoolYear.ReadOnly = true;
            this.dgvSchoolYear.RowHeadersWidth = 51;
            this.dgvSchoolYear.RowTemplate.Height = 24;
            this.dgvSchoolYear.Size = new System.Drawing.Size(764, 322);
            this.dgvSchoolYear.TabIndex = 3;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.dgvSchoolYear);
            this.pnlCenter.Controls.Add(this.txtName);
            this.pnlCenter.Controls.Add(this.lblName);
            this.pnlCenter.Controls.Add(this.lblYearID);
            this.pnlCenter.Controls.Add(this.txtYearID);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 77);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(764, 587);
            this.pnlCenter.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(427, 377);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 28);
            this.txtName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblName.Location = new System.Drawing.Point(355, 380);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 21);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // lblYearID
            // 
            this.lblYearID.AutoSize = true;
            this.lblYearID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblYearID.Location = new System.Drawing.Point(31, 380);
            this.lblYearID.Name = "lblYearID";
            this.lblYearID.Size = new System.Drawing.Size(77, 21);
            this.lblYearID.TabIndex = 5;
            this.lblYearID.Text = "Year ID:";
            // 
            // txtYearID
            // 
            this.txtYearID.Location = new System.Drawing.Point(140, 377);
            this.txtYearID.Name = "txtYearID";
            this.txtYearID.Size = new System.Drawing.Size(169, 28);
            this.txtYearID.TabIndex = 11;
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
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Brown;
            this.pnlBottom.Controls.Add(this.btnReload);
            this.pnlBottom.Controls.Add(this.btnAdd);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 664);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(764, 59);
            this.pnlBottom.TabIndex = 22;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Walter Turncoat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "New School Year";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Brown;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(764, 77);
            this.pnlTop.TabIndex = 21;
            // 
            // SchoolYear_New
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
            this.Name = "SchoolYear_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolYear_New";
            this.Load += new System.EventHandler(this.SchoolYear_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolYear)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSchoolYear;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblYearID;
        private System.Windows.Forms.TextBox txtYearID;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
    }
}