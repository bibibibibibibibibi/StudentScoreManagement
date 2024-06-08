namespace StudentManagement.MenuForms.Class
{
    partial class Class_Manage
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFacultyID = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.cbbEduSysID = new System.Windows.Forms.ComboBox();
            this.cbbYearID = new System.Windows.Forms.ComboBox();
            this.cbbFacultyID = new System.Windows.Forms.ComboBox();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblYearID = new System.Windows.Forms.Label();
            this.lblEduSysID = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.SuspendLayout();
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
            this.pnlBottom.TabIndex = 22;
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
            this.btnDelete.TabIndex = 3;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Walter Turncoat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Class";
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
            this.txtName.Location = new System.Drawing.Point(419, 396);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 28);
            this.txtName.TabIndex = 12;
            // 
            // lblFacultyID
            // 
            this.lblFacultyID.AutoSize = true;
            this.lblFacultyID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFacultyID.Location = new System.Drawing.Point(37, 449);
            this.lblFacultyID.Name = "lblFacultyID";
            this.lblFacultyID.Size = new System.Drawing.Size(97, 21);
            this.lblFacultyID.TabIndex = 7;
            this.lblFacultyID.Text = "Faculty ID:";
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.cbbEduSysID);
            this.pnlCenter.Controls.Add(this.cbbYearID);
            this.pnlCenter.Controls.Add(this.cbbFacultyID);
            this.pnlCenter.Controls.Add(this.btnSearch);
            this.pnlCenter.Controls.Add(this.cbbSearch);
            this.pnlCenter.Controls.Add(this.lblSearch);
            this.pnlCenter.Controls.Add(this.txtSearch);
            this.pnlCenter.Controls.Add(this.dgvClass);
            this.pnlCenter.Controls.Add(this.txtName);
            this.pnlCenter.Controls.Add(this.lblFacultyID);
            this.pnlCenter.Controls.Add(this.lblName);
            this.pnlCenter.Controls.Add(this.lblYearID);
            this.pnlCenter.Controls.Add(this.lblEduSysID);
            this.pnlCenter.Controls.Add(this.lblClassID);
            this.pnlCenter.Controls.Add(this.txtClassID);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 77);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(764, 646);
            this.pnlCenter.TabIndex = 23;
            // 
            // cbbEduSysID
            // 
            this.cbbEduSysID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEduSysID.FormattingEnabled = true;
            this.cbbEduSysID.Location = new System.Drawing.Point(140, 497);
            this.cbbEduSysID.Name = "cbbEduSysID";
            this.cbbEduSysID.Size = new System.Drawing.Size(169, 29);
            this.cbbEduSysID.TabIndex = 23;
            // 
            // cbbYearID
            // 
            this.cbbYearID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYearID.FormattingEnabled = true;
            this.cbbYearID.Location = new System.Drawing.Point(419, 446);
            this.cbbYearID.Name = "cbbYearID";
            this.cbbYearID.Size = new System.Drawing.Size(169, 29);
            this.cbbYearID.TabIndex = 22;
            // 
            // cbbFacultyID
            // 
            this.cbbFacultyID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFacultyID.FormattingEnabled = true;
            this.cbbFacultyID.Location = new System.Drawing.Point(140, 446);
            this.cbbFacultyID.Name = "cbbFacultyID";
            this.cbbFacultyID.Size = new System.Drawing.Size(169, 29);
            this.cbbFacultyID.TabIndex = 21;
            // 
            // cbbSearch
            // 
            this.cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Items.AddRange(new object[] {
            "Class ID",
            "Name",
            "Faculty ID",
            "Edu Sys. ID",
            "Year ID"});
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
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvClass.Location = new System.Drawing.Point(0, 0);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.RowTemplate.Height = 24;
            this.dgvClass.Size = new System.Drawing.Size(764, 322);
            this.dgvClass.TabIndex = 3;
            this.dgvClass.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellEnter);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblName.Location = new System.Drawing.Point(347, 399);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 21);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // lblYearID
            // 
            this.lblYearID.AutoSize = true;
            this.lblYearID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblYearID.Location = new System.Drawing.Point(336, 449);
            this.lblYearID.Name = "lblYearID";
            this.lblYearID.Size = new System.Drawing.Size(77, 21);
            this.lblYearID.TabIndex = 9;
            this.lblYearID.Text = "Year ID:";
            // 
            // lblEduSysID
            // 
            this.lblEduSysID.AutoSize = true;
            this.lblEduSysID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEduSysID.Location = new System.Drawing.Point(32, 500);
            this.lblEduSysID.Name = "lblEduSysID";
            this.lblEduSysID.Size = new System.Drawing.Size(102, 21);
            this.lblEduSysID.TabIndex = 8;
            this.lblEduSysID.Text = "Edu Sys. ID:";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblClassID.Location = new System.Drawing.Point(53, 399);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(81, 21);
            this.lblClassID.TabIndex = 5;
            this.lblClassID.Text = "Class ID:";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(140, 396);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.ReadOnly = true;
            this.txtClassID.Size = new System.Drawing.Size(169, 28);
            this.txtClassID.TabIndex = 11;
            // 
            // Class_Manage
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
            this.Name = "Class_Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class_Manage";
            this.Load += new System.EventHandler(this.Class_Manage_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblFacultyID;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblYearID;
        private System.Windows.Forms.Label lblEduSysID;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbbFacultyID;
        private System.Windows.Forms.ComboBox cbbEduSysID;
        private System.Windows.Forms.ComboBox cbbYearID;
    }
}