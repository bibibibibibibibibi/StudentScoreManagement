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

namespace StudentManagement.MenuForms.Course
{
    public partial class Course_New : Form
    {
        string err;

        BS_MonHoc monHoc = new BS_MonHoc();

        public Course_New()
        {
            InitializeComponent();

            dgvCourse.AllowUserToOrderColumns = true;
            dgvCourse.AllowUserToResizeColumns = true;
        }

        private void Course_New_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvCourse.DataSource = monHoc.GetData();
                dgvCourse.AutoResizeColumns();

                dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCourse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MaMH = txtCourseID.Text.Trim();
            string TenMH = txtName.Text.Trim();
            int SoTrinh = int.Parse(nudCredits.Value.ToString().Trim());

            try
            {
                if (String.IsNullOrWhiteSpace(MaMH) || String.IsNullOrWhiteSpace(TenMH))
                {
                    throw new Exception("All fields need to be filled!");
                }

                bool result = monHoc.AddData(MaMH, TenMH, SoTrinh, ref err);
                if (result)
                    MessageBox.Show("Added course!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    throw new Exception(err);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadData();
            }
        }
    }
}
