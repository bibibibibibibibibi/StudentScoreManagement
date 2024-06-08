namespace StudentManagement.MenuForms.Lecturer
{
    partial class Lecturer_New
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
            this.dgvLecturer = new System.Windows.Forms.DataGridView();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLecturerID = new System.Windows.Forms.Label();
            this.txtLecturerID = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFalcutyID = new System.Windows.Forms.Label();
            this.txtFalcutyID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturer)).BeginInit();
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
            // dgvLecturer
            // 
            this.dgvLecturer.AllowUserToAddRows = false;
            this.dgvLecturer.AllowUserToDeleteRows = false;
            this.dgvLecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLecturer.Location = new System.Drawing.Point(0, 0);
            this.dgvLecturer.Name = "dgvLecturer";
            this.dgvLecturer.ReadOnly = true;
            this.dgvLecturer.RowHeadersWidth = 51;
            this.dgvLecturer.RowTemplate.Height = 24;
            this.dgvLecturer.Size = new System.Drawing.Size(764, 322);
            this.dgvLecturer.TabIndex = 3;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.txtFalcutyID);
            this.pnlCenter.Controls.Add(this.lblFalcutyID);
            this.pnlCenter.Controls.Add(this.txtAddress);
            this.pnlCenter.Controls.Add(this.lblAddress);
            this.pnlCenter.Controls.Add(this.txtPhoneNumber);
            this.pnlCenter.Controls.Add(this.lblPhoneNumber);
            this.pnlCenter.Controls.Add(this.dgvLecturer);
            this.pnlCenter.Controls.Add(this.txtName);
            this.pnlCenter.Controls.Add(this.lblName);
            this.pnlCenter.Controls.Add(this.lblLecturerID);
            this.pnlCenter.Controls.Add(this.txtLecturerID);
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
            // lblLecturerID
            // 
            this.lblLecturerID.AutoSize = true;
            this.lblLecturerID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblLecturerID.Location = new System.Drawing.Point(41, 381);
            this.lblLecturerID.Name = "lblLecturerID";
            this.lblLecturerID.Size = new System.Drawing.Size(106, 21);
            this.lblLecturerID.TabIndex = 5;
            this.lblLecturerID.Text = "Lecturer ID:";
            // 
            // txtLecturerID
            // 
            this.txtLecturerID.Location = new System.Drawing.Point(153, 378);
            this.txtLecturerID.Name = "txtLecturerID";
            this.txtLecturerID.Size = new System.Drawing.Size(169, 28);
            this.txtLecturerID.TabIndex = 11;
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
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "New Lecturer";
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
            // lblFalcutyID
            // 
            this.lblFalcutyID.AutoSize = true;
            this.lblFalcutyID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblFalcutyID.Location = new System.Drawing.Point(50, 479);
            this.lblFalcutyID.Name = "lblFalcutyID";
            this.lblFalcutyID.Size = new System.Drawing.Size(97, 21);
            this.lblFalcutyID.TabIndex = 25;
            this.lblFalcutyID.Text = "Falcuty ID:";
            // 
            // txtFalcutyID
            // 
            this.txtFalcutyID.Location = new System.Drawing.Point(153, 476);
            this.txtFalcutyID.Name = "txtFalcutyID";
            this.txtFalcutyID.Size = new System.Drawing.Size(169, 28);
            this.txtFalcutyID.TabIndex = 26;
            // 
            // Lecturer_New
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
            this.Name = "Lecturer_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecturer_New";
            this.Load += new System.EventHandler(this.Lecturer_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturer)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvLecturer;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLecturerID;
        private System.Windows.Forms.TextBox txtLecturerID;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtFalcutyID;
        private System.Windows.Forms.Label lblFalcutyID;
    }
}