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

namespace StudentManagement.MenuForms.Class
{
    public partial class Class_New : Form
    {
        string err;

        BS_Lop lop = new BS_Lop();
        BS_Khoa khoa = new BS_Khoa();
        BS_HeDT heDT = new BS_HeDT();
        BS_KhoaHoc khoaHoc = new BS_KhoaHoc();

        public Class_New()
        {
            InitializeComponent();

            getComboBoxItems();

            dgvClass.AllowUserToOrderColumns = true;
            dgvClass.AllowUserToResizeColumns = true;
        }

        private void Class_New_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void getComboBoxItems()
        {
            khoa.GetListOfFaculty(cbbFacultyID);
            heDT.GetListOfEduSys(cbbEduSysID);
            khoaHoc.GetListOfSchoolYear(cbbYearID);
        }

        private void LoadData()
        {
            try
            {
                dgvClass.DataSource = lop.GetData();
                dgvClass.AutoResizeColumns();

                dgvClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvClass.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
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
            string MaLop = txtClassID.Text.Trim();
            string TenLop = txtName.Text.Trim();
            string MaKhoa = cbbFacultyID.Text.Trim();
            string MaHeDT = cbbEduSysID.Text.Trim();
            string MaKhoaHoc = cbbYearID.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaLop) || String.IsNullOrWhiteSpace(TenLop) ||
                    String.IsNullOrWhiteSpace(MaKhoa) || String.IsNullOrWhiteSpace(MaHeDT) ||
                    String.IsNullOrWhiteSpace(MaKhoaHoc))
                {
                    throw new Exception("All fields need to be filled!");
                }

                bool result = lop.AddData(MaLop, TenLop, MaKhoa, MaHeDT, MaKhoaHoc, ref err);
                if (result)
                    MessageBox.Show("Added class!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
