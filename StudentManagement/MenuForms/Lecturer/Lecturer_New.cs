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

namespace StudentManagement.MenuForms.Lecturer
{
    public partial class Lecturer_New : Form
    {
        string err;

        BS_GiangVien giangVien = new BS_GiangVien();

        public Lecturer_New()
        {
            InitializeComponent();

            dgvLecturer.AllowUserToOrderColumns = true;
            dgvLecturer.AllowUserToResizeColumns = true;
        }

        private void Lecturer_New_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvLecturer.DataSource = giangVien.GetData();
                dgvLecturer.AutoResizeColumns();

                dgvLecturer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLecturer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
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
            string MaGV = txtLecturerID.Text.Trim();
            string TenGV = txtName.Text.Trim();
            string DiaChi = txtAddress.Text.Trim();
            string SDT = txtPhoneNumber.Text.Trim();
            string MaKhoa = txtFalcutyID.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaKhoa) || String.IsNullOrWhiteSpace(TenGV) ||
                    String.IsNullOrWhiteSpace(DiaChi) || String.IsNullOrWhiteSpace(SDT) ||
                    String.IsNullOrWhiteSpace(MaKhoa))
                {
                    throw new Exception("All fields need to be filled!");
                }
                int lecturerID = int.Parse(MaGV);
                bool result = giangVien.AddData(lecturerID, TenGV, DiaChi, SDT, MaKhoa, ref err);
                if (result)
                    MessageBox.Show("Added Lecturer!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
