namespace StudentManagement.MenuForms.Faculty
{
    partial class Faculty_New
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.dgvFaculty = new System.Windows.Forms.DataGridView();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFacultyID = new System.Windows.Forms.Label();
            this.txtFacultyID = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).BeginInit();
            this.pnlCenter.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(427, 428);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(249, 28);
            this.txtAddress.TabIndex = 24;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAddress.Location = new System.Drawing.Point(339, 431);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 21);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "Address:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(153, 428);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(169, 28);
            this.txtPhoneNumber.TabIndex = 22;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 431);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(135, 21);
            this.lblPhoneNumber.TabIndex = 21;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // dgvFaculty
            // 
            this.dgvFaculty.AllowUserToAddRows = false;
            this.dgvFaculty.AllowUserToDeleteRows = false;
            this.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaculty.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFaculty.Location = new System.Drawing.Point(0, 0);
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.ReadOnly = true;
            this.dgvFaculty.RowHeadersWidth = 51;
            this.dgvFaculty.RowTemplate.Height = 24;
            this.dgvFaculty.Size = new System.Drawing.Size(764, 322);
            this.dgvFaculty.TabIndex = 3;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.txtAddress);
            this.pnlCenter.Controls.Add(this.lblAddress);
            this.pnlCenter.Controls.Add(this.txtPhoneNumber);
            this.pnlCenter.Controls.Add(this.lblPhoneNumber);
            this.pnlCenter.Controls.Add(this.dgvFaculty);
            this.pnlCenter.Controls.Add(this.txtName);
            this.pnlCenter.Controls.Add(this.lblName);
            this.pnlCenter.Controls.Add(this.lblFacultyID);
            this.pnlCenter.Controls.Add(this.txtFacultyID);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 77);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(764, 587);
            this.pnlCenter.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(427, 378);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 28);
            this.txtName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblName.Location = new System.Drawing.Point(355, 381);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 21);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // lblFacultyID
            // 
            this.lblFacultyID.AutoSize = true;
            this.lblFacultyID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFacultyID.Location = new System.Drawing.Point(50, 381);
            this.lblFacultyID.Name = "lblFacultyID";
            this.lblFacultyID.Size = new System.Drawing.Size(97, 21);
            this.lblFacultyID.TabIndex = 5;
            this.lblFacultyID.Text = "Faculty ID:";
            // 
            // txtFacultyID
            // 
            this.txtFacultyID.Location = new System.Drawing.Point(153, 378);
            this.txtFacultyID.Name = "txtFacultyID";
            this.txtFacultyID.Size = new System.Drawing.Size(169, 28);
            this.txtFacultyID.TabIndex = 11;
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
            this.pnlBottom.TabIndex = 28;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Walter Turncoat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "New Faculty";
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
            // Faculty_New
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
            this.Name = "Faculty_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty_New";
            this.Load += new System.EventHandler(this.Faculty_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.DataGridView dgvFaculty;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFacultyID;
        private System.Windows.Forms.TextBox txtFacultyID;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
    }
}