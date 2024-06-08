using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StudentManagement.BS_Layer;

namespace StudentManagement.MenuForms.Home
{
    public partial class Home : Form
    {
        BS_Home home = new BS_Home();
        BS_Lop lop = new BS_Lop();

        public Home()
        {
            InitializeComponent();

            getComboBoxItems();
            cbbClass.SelectedIndex = 0;

            setStudentCount();
        }

        private void getComboBoxItems()
        {
            lop.GetListOfClass(cbbClass);
        }

        private void setStudentCount()
        {
            // Set total number of ALL students
            lblTotalStdCount.Text = home.GetStudentCount().ToString();

            // Set total number of Male/Female students
            lblTotalMCount.Text = home.GetStudentCount(false).ToString();
            lblTotalFCount.Text = home.GetStudentCount(true).ToString();
            
            // Set number of Male/Female students by class
            lblClassMCount.Text = home.GetStudentCount(false, cbbClass.Text).ToString();
            lblClassFCount.Text = home.GetStudentCount(true, cbbClass.Text).ToString();
        }

        private void cbbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            setStudentCount();
        }
    }
}
