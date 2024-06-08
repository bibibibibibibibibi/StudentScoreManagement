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

namespace StudentManagement.MenuForms.Academic_Course
{
    public partial class AcaCourse_New : Form
    {
        string err;

        BS_AcaCourse lhp = new BS_AcaCourse();

        public AcaCourse_New()
        {
            InitializeComponent();
            dgvAcaCourse.AllowUserToOrderColumns = true;
            dgvAcaCourse.AllowUserToResizeColumns = true;
        }
        private void AcaCourse_New_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                dgvAcaCourse.DataSource = lhp.GetData();
                dgvAcaCourse.AutoResizeColumns();
                dgvAcaCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAcaCourse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
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
            string MaLHP = txtAcaCourseID.Text.Trim();
            string MaMH = txtCourseID.Text.Trim();
            string MaKhoaHoc = txtYearID.Text.Trim();
            string NamHoc = txtYear.Text.Trim();
            string MaGV = txtTeacherID.Text.Trim();
            string SiSoSV = txtNoStudent.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaLHP) || String.IsNullOrWhiteSpace(MaMH) ||
                    String.IsNullOrWhiteSpace(MaKhoaHoc) || String.IsNullOrWhiteSpace(NamHoc) ||
                    String.IsNullOrWhiteSpace(MaGV) || String.IsNullOrWhiteSpace(SiSoSV))
                {
                    throw new Exception("All fields need to be filled!");
                }
                int Year = int.Parse(NamHoc);
                int lecturerID = int.Parse(MaGV);
                int NoStudents = int.Parse(SiSoSV);
                bool result = lhp.AddData(MaLHP, MaMH, MaKhoaHoc, Year, lecturerID, NoStudents, ref err);
                if (result)
                    MessageBox.Show("Added Academic Course!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
