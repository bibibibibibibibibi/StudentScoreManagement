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

namespace StudentManagement.MenuForms.Score
{
    public partial class Score_New : Form
    {
        string err;

        BS_Diem diem = new BS_Diem();
        BS_MonHoc monHoc = new BS_MonHoc();

        public Score_New()
        {
            InitializeComponent();

            getComboBoxItems();

            dgvScore.AllowUserToOrderColumns = true;
            dgvScore.AllowUserToResizeColumns = true;
        }

        private void Score_New_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void getComboBoxItems()
        {
            monHoc.GetListOfCourse(cbbCourseID);
        }

        private void LoadData()
        {
            try
            {
                dgvScore.DataSource = diem.GetData();
                dgvScore.AutoResizeColumns();

                dgvScore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvScore.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
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
            string MaSV = txtStudentID.Text.Trim();
            string MaMH = cbbCourseID.Text.Trim();

            int nYear = (int)nudYear.Value;
            int nSemester = (int)nudSemester.Value;
            int HocKy = (nYear - 1) * 3 + nSemester;

            float DiemLan1 = (float)nudScore1.Value;
            float DiemLan2 = (float)nudScore2.Value;

            try
            {
                if (String.IsNullOrWhiteSpace(MaSV) || String.IsNullOrWhiteSpace(MaMH))
                {
                    throw new Exception("All fields need to be filled!");
                }

                bool result = diem.AddData(MaSV, MaMH, HocKy, DiemLan1, DiemLan2, ref err);
                if (result)
                    MessageBox.Show("Added score!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
