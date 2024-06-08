namespace StudentManagement.MenuForms.Home
{
    partial class Home
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
            this.lblClassFCount = new System.Windows.Forms.Label();
            this.lblClassMCount = new System.Windows.Forms.Label();
            this.lblTotalStdCount = new System.Windows.Forms.Label();
            this.lblTotalFCount = new System.Windows.Forms.Label();
            this.lblTotalMCount = new System.Windows.Forms.Label();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.lblClass_Female = new System.Windows.Forms.Label();
            this.lblClass_Male = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblTotalFemale = new System.Windows.Forms.Label();
            this.lblTotalMale = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
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
            this.pnlTop.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Walter Turncoat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(453, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Student Score Management App";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Brown;
            this.pnlBottom.Controls.Add(this.lblClassFCount);
            this.pnlBottom.Controls.Add(this.lblClassMCount);
            this.pnlBottom.Controls.Add(this.lblTotalStdCount);
            this.pnlBottom.Controls.Add(this.lblTotalFCount);
            this.pnlBottom.Controls.Add(this.lblTotalMCount);
            this.pnlBottom.Controls.Add(this.cbbClass);
            this.pnlBottom.Controls.Add(this.lblClass_Female);
            this.pnlBottom.Controls.Add(this.lblClass_Male);
            this.pnlBottom.Controls.Add(this.lblClass);
            this.pnlBottom.Controls.Add(this.lblTotalFemale);
            this.pnlBottom.Controls.Add(this.lblTotalMale);
            this.pnlBottom.Controls.Add(this.lblTotalStudents);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBottom.ForeColor = System.Drawing.Color.White;
            this.pnlBottom.Location = new System.Drawing.Point(0, 637);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(764, 86);
            this.pnlBottom.TabIndex = 8;
            // 
            // lblClassFCount
            // 
            this.lblClassFCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClassFCount.AutoSize = true;
            this.lblClassFCount.Location = new System.Drawing.Point(689, 48);
            this.lblClassFCount.Name = "lblClassFCount";
            this.lblClassFCount.Size = new System.Drawing.Size(53, 21);
            this.lblClassFCount.TabIndex = 11;
            this.lblClassFCount.Text = "Fnum";
            // 
            // lblClassMCount
            // 
            this.lblClassMCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClassMCount.AutoSize = true;
            this.lblClassMCount.Location = new System.Drawing.Point(553, 48);
            this.lblClassMCount.Name = "lblClassMCount";
            this.lblClassMCount.Size = new System.Drawing.Size(62, 21);
            this.lblClassMCount.TabIndex = 10;
            this.lblClassMCount.Text = "Mnum";
            // 
            // lblTotalStdCount
            // 
            this.lblTotalStdCount.AutoSize = true;
            this.lblTotalStdCount.Location = new System.Drawing.Point(164, 13);
            this.lblTotalStdCount.Name = "lblTotalStdCount";
            this.lblTotalStdCount.Size = new System.Drawing.Size(37, 21);
            this.lblTotalStdCount.TabIndex = 9;
            this.lblTotalStdCount.Text = "Std";
            // 
            // lblTotalFCount
            // 
            this.lblTotalFCount.AutoSize = true;
            this.lblTotalFCount.Location = new System.Drawing.Point(225, 48);
            this.lblTotalFCount.Name = "lblTotalFCount";
            this.lblTotalFCount.Size = new System.Drawing.Size(53, 21);
            this.lblTotalFCount.TabIndex = 8;
            this.lblTotalFCount.Text = "Fnum";
            // 
            // lblTotalMCount
            // 
            this.lblTotalMCount.AutoSize = true;
            this.lblTotalMCount.Location = new System.Drawing.Point(88, 48);
            this.lblTotalMCount.Name = "lblTotalMCount";
            this.lblTotalMCount.Size = new System.Drawing.Size(62, 21);
            this.lblTotalMCount.TabIndex = 7;
            this.lblTotalMCount.Text = "Mnum";
            // 
            // cbbClass
            // 
            this.cbbClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(564, 10);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(164, 29);
            this.cbbClass.TabIndex = 6;
            this.cbbClass.SelectedIndexChanged += new System.EventHandler(this.cbbClass_SelectedIndexChanged);
            // 
            // lblClass_Female
            // 
            this.lblClass_Female.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClass_Female.AutoSize = true;
            this.lblClass_Female.Location = new System.Drawing.Point(619, 48);
            this.lblClass_Female.Name = "lblClass_Female";
            this.lblClass_Female.Size = new System.Drawing.Size(80, 21);
            this.lblClass_Female.TabIndex = 5;
            this.lblClass_Female.Text = "Female: ";
            // 
            // lblClass_Male
            // 
            this.lblClass_Male.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClass_Male.AutoSize = true;
            this.lblClass_Male.Location = new System.Drawing.Point(500, 48);
            this.lblClass_Male.Name = "lblClass_Male";
            this.lblClass_Male.Size = new System.Drawing.Size(63, 21);
            this.lblClass_Male.TabIndex = 4;
            this.lblClass_Male.Text = "Male: ";
            // 
            // lblClass
            // 
            this.lblClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(500, 13);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(58, 21);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "Class:";
            // 
            // lblTotalFemale
            // 
            this.lblTotalFemale.AutoSize = true;
            this.lblTotalFemale.Location = new System.Drawing.Point(154, 48);
            this.lblTotalFemale.Name = "lblTotalFemale";
            this.lblTotalFemale.Size = new System.Drawing.Size(80, 21);
            this.lblTotalFemale.TabIndex = 2;
            this.lblTotalFemale.Text = "Female: ";
            // 
            // lblTotalMale
            // 
            this.lblTotalMale.AutoSize = true;
            this.lblTotalMale.Location = new System.Drawing.Point(34, 48);
            this.lblTotalMale.Name = "lblTotalMale";
            this.lblTotalMale.Size = new System.Drawing.Size(63, 21);
            this.lblTotalMale.TabIndex = 1;
            this.lblTotalMale.Text = "Male: ";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Location = new System.Drawing.Point(34, 13);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(138, 21);
            this.lblTotalStudents.TabIndex = 0;
            this.lblTotalStudents.Text = "Total Students: ";
            // 
            // pbBackground
            // 
            this.pbBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBackground.Image = global::StudentManagement.Properties.Resources.bg;
            this.pbBackground.Location = new System.Drawing.Point(0, 77);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(764, 560);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackground.TabIndex = 9;
            this.pbBackground.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 723);
            this.ControlBox = false;
            this.Controls.Add(this.pbBackground);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Label lblClass_Female;
        private System.Windows.Forms.Label lblClass_Male;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblTotalFemale;
        private System.Windows.Forms.Label lblTotalMale;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Label lblTotalFCount;
        private System.Windows.Forms.Label lblTotalMCount;
        private System.Windows.Forms.Label lblTotalStdCount;
        private System.Windows.Forms.Label lblClassMCount;
        private System.Windows.Forms.Label lblClassFCount;
        private System.Windows.Forms.Label lblTitle;
    }
}