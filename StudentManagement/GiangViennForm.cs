using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StudentManagement.MenuForms.Home;
using StudentManagement.MenuForms.Student;
using StudentManagement.MenuForms.Class;
using StudentManagement.MenuForms.Course;
using StudentManagement.MenuForms.Score;
using StudentManagement.MenuForms.Faculty;
using StudentManagement.MenuForms.Education_System;
using StudentManagement.MenuForms.School_Year;
using StudentManagement.MenuForms.Lecturer;
using StudentManagement.MenuForms.Academic_Course;
using System.Web.UI.WebControls;

namespace StudentManagement
{
    public partial class GiangViennForm : Form
    {
        private Form mainActiveForm;
        private Home home = new Home();

        public Form MainActiveForm { get => mainActiveForm; set => mainActiveForm = value; }
        public GiangViennForm()
        {
            InitializeComponent();
            Startup();
        }
        public void Startup()
        {
            pnlStudent_SubMenu.Visible = false;
            pnlCourse_SubMenu.Visible = false;
            pnlScore_SubMenu.Visible = false;
            pnlFaculty_SubMenu.Visible = false;
            pnlEduSystem_SubMenu.Visible = false;
            pnlSchoolYear_SubMenu.Visible = false;
            pnlClass_SubMenu.Visible = false;
            pnlAcaCor_SubMenu.Visible = false;
            pnlLecturer_SubMenu.Visible = false;

            MainActiveForm = home;
            MainActiveForm.TopLevel = false;
            MainActiveForm.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(MainActiveForm);
            MainActiveForm.Show();
            MainActiveForm.BringToFront();
        }

        public void ToggleSubMenu(System.Windows.Forms.Panel SubMenu)
        {
            if (!SubMenu.Visible)
                SubMenu.Visible = true;
            else SubMenu.Visible = false;
        }

        public void openChildForm(Form form)
        {
            MainActiveForm = form;
            MainActiveForm.TopLevel = false;
            MainActiveForm.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(MainActiveForm);
            MainActiveForm.Show();
            MainActiveForm.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(home);
        }

        #region Student buttons
        private void btnStudent_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(pnlStudent_SubMenu);
        }

        private void btnStudent_Info_Click(object sender, EventArgs e)
        {
            openChildForm(new Student_Info());
        }

        private void btnStudent_Register_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnStudent_Manage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }
        #endregion

        #region Class buttons
        private void btnClass_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(pnlClass_SubMenu);
        }

        private void btnClass_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnClass_New_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnClass_Manage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }
        #endregion

        #region Course buttons
        private void btnCourse_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(pnlCourse_SubMenu);
        }

        private void btnCourse_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnCourse_New_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnCourse_Manage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }
        #endregion

        #region Score buttons
        private void btnScore_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(pnlScore_SubMenu);
        }

        private void btnScore_Info_Click(object sender, EventArgs e)
        {
            openChildForm(new Score_Info());
        }

        private void btnScore_New_Click(object sender, EventArgs e)
        {
            openChildForm(new Score_New());
        }

        private void btnScore_Manage_Click(object sender, EventArgs e)
        {
            openChildForm(new Score_Manage());
        }
        #endregion

        #region Faculty buttons
        private void btnFaculty_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(pnlFaculty_SubMenu);
        }

        private void btnFaculty_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnFaculty_New_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnFaculty_Manage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }
        #endregion

        #region Education System buttons
        private void btnEduSystem_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(pnlEduSystem_SubMenu);
        }

        private void btnEduSystem_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnEduSystem_New_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnEduSystem_Manage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }
        #endregion

        #region School Year buttons
        private void btnSchoolYear_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(pnlSchoolYear_SubMenu);
        }

        private void btnSchoolYear_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnSchoolYear_New_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnSchoolYear_Manage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }
        #endregion

        #region Lecturer buttons
        private void btnLecturer_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(pnlLecturer_SubMenu);
        }

        private void btnLecturer_Infor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnLecturer_New_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnLecturer_Manage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }
        #endregion

        #region Academic Course buttons
        private void btnAcaCor_Click(object sender, EventArgs e)
        {
            ToggleSubMenu(pnlAcaCor_SubMenu);
        }

        private void btnAcaCor_Infor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnAcaCor_New_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }

        private void btnAcaCor_Manage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not access this form!");
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
