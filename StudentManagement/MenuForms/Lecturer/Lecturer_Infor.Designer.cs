namespace StudentManagement.MenuForms.Lecturer
{
    partial class Lecturer_Infor
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFalcutyID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblFalcutyID = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLecturerID = new System.Windows.Forms.Label();
            this.txtLecturerID = new System.Windows.Forms.TextBox();
            this.dgvLecturer = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturer)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.White;
            this.pnlCenter.Controls.Add(this.btnSearch);
            this.pnlCenter.Controls.Add(this.cbbSearch);
            this.pnlCenter.Controls.Add(this.lblSearch);
            this.pnlCenter.Controls.Add(this.txtSearch);
            this.pnlCenter.Controls.Add(this.txtAddress);
            this.pnlCenter.Controls.Add(this.txtFalcutyID);
            this.pnlCenter.Controls.Add(this.txtName);
            this.pnlCenter.Controls.Add(this.lblPhone);
            this.pnlCenter.Controls.Add(this.lblName);
            this.pnlCenter.Controls.Add(this.txtPhone);
            this.pnlCenter.Controls.Add(this.lblFalcutyID);
            this.pnlCenter.Controls.Add(this.lblAddress);
            this.pnlCenter.Controls.Add(this.lblLecturerID);
            this.pnlCenter.Controls.Add(this.txtLecturerID);
            this.pnlCenter.Controls.Add(this.dgvLecturer);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCenter.Location = new System.Drawing.Point(0, 77);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(764, 587);
            this.pnlCenter.TabIndex = 20;
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
            this.btnSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSearch_KeyPress);
            // 
            // cbbSearch
            // 
            this.cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Items.AddRange(new object[] {
            "Lecturer ID",
            "Name",
            "Hometown",
            "Class ID"});
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
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(131, 499);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(169, 28);
            this.txtAddress.TabIndex = 32;
            // 
            // txtFalcutyID
            // 
            this.txtFalcutyID.Location = new System.Drawing.Point(449, 398);
            this.txtFalcutyID.Name = "txtFalcutyID";
            this.txtFalcutyID.ReadOnly = true;
            this.txtFalcutyID.Size = new System.Drawing.Size(218, 28);
            this.txtFalcutyID.TabIndex = 28;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 448);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(264, 28);
            this.txtName.TabIndex = 29;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPhone.Location = new System.Drawing.Point(401, 451);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(138, 21);
            this.lblPhone.TabIndex = 26;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblName.Location = new System.Drawing.Point(59, 451);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 21);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(545, 448);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(189, 28);
            this.txtPhone.TabIndex = 31;
            // 
            // lblFalcutyID
            // 
            this.lblFalcutyID.AutoSize = true;
            this.lblFalcutyID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFalcutyID.Location = new System.Drawing.Point(346, 401);
            this.lblFalcutyID.Name = "lblFalcutyID";
            this.lblFalcutyID.Size = new System.Drawing.Size(97, 21);
            this.lblFalcutyID.TabIndex = 22;
            this.lblFalcutyID.Text = "Falcuty ID:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAddress.Location = new System.Drawing.Point(43, 502);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 21);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Address:";
            // 
            // lblLecturerID
            // 
            this.lblLecturerID.AutoSize = true;
            this.lblLecturerID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblLecturerID.Location = new System.Drawing.Point(22, 401);
            this.lblLecturerID.Name = "lblLecturerID";
            this.lblLecturerID.Size = new System.Drawing.Size(106, 21);
            this.lblLecturerID.TabIndex = 21;
            this.lblLecturerID.Text = "Lecturer ID:";
            // 
            // txtLecturerID
            // 
            this.txtLecturerID.Location = new System.Drawing.Point(131, 398);
            this.txtLecturerID.Name = "txtLecturerID";
            this.txtLecturerID.ReadOnly = true;
            this.txtLecturerID.Size = new System.Drawing.Size(169, 28);
            this.txtLecturerID.TabIndex = 27;
            // 
            // dgvLecturer
            // 
            this.dgvLecturer.AllowUserToAddRows = false;
            this.dgvLecturer.AllowUserToDeleteRows = false;
            this.dgvLecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLecturer.Location = new System.Drawing.Point(0, 0);
            this.dgvLecturer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLecturer.Name = "dgvLecturer";
            this.dgvLecturer.ReadOnly = true;
            this.dgvLecturer.RowHeadersWidth = 51;
            this.dgvLecturer.RowTemplate.Height = 24;
            this.dgvLecturer.Size = new System.Drawing.Size(764, 322);
            this.dgvLecturer.TabIndex = 3;
            this.dgvLecturer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLecturer_CellEnter);
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
            this.lblTitle.Location = new System.Drawing.Point(15, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(267, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Lecturer Information";
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
            // Lecturer_Infor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(764, 723);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lecturer_Infor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturer_Infor";
            this.Load += new System.EventHandler(this.Lecturer_Infor_Load);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturer)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.DataGridView dgvLecturer;
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
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFalcutyID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblFalcutyID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLecturerID;
        private System.Windows.Forms.TextBox txtLecturerID;
    }
}