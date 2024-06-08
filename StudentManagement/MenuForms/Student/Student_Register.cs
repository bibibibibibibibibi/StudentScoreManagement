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

namespace StudentManagement.MenuForms.Student
{
    public partial class Student_Register : Form
    {
        string err;

        BS_SinhVien sinhVien = new BS_SinhVien();
        BS_Lop lop = new BS_Lop();

        public Student_Register()
        {
            InitializeComponent();

            getComboBoxItems();

            dgvStudent.AllowUserToOrderColumns = true;
            dgvStudent.AllowUserToResizeColumns = true;
        }

        private void Student_Register_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void getComboBoxItems()
        {
            lop.GetListOfClass(cbbClassID);
        }

        private void LoadData()
        {
            try
            {
                dgvStudent.DataSource = sinhVien.GetData();
                dgvStudent.AutoResizeColumns();

                dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string MaSV = txtStudentID.Text.Trim();
            string TenSV = txtName.Text.Trim();
            bool GioiTinh = rbtFemale.Checked;
            DateTime NgaySinh = dtpDateOfBirth.Value;
            string QueQuan = txtHometown.Text.Trim();
            string MaLop = cbbClassID.Text;

            try
            {
                if (String.IsNullOrWhiteSpace(MaSV) || String.IsNullOrWhiteSpace(TenSV) ||
                    String.IsNullOrWhiteSpace(QueQuan) || String.IsNullOrWhiteSpace(MaLop))
                {
                    throw new Exception("All fields need to be filled!");
                }

                bool result = sinhVien.AddData(MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop, ref err);
                if (result)
                    MessageBox.Show("Registered new student!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
