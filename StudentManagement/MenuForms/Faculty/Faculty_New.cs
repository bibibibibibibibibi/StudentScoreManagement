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

namespace StudentManagement.MenuForms.Faculty
{
    public partial class Faculty_New : Form
    {
        string err;

        BS_Khoa khoa = new BS_Khoa();

        public Faculty_New()
        {
            InitializeComponent();

            dgvFaculty.AllowUserToOrderColumns = true;
            dgvFaculty.AllowUserToResizeColumns = true;
        }

        private void Faculty_New_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvFaculty.DataSource = khoa.GetData();
                dgvFaculty.AutoResizeColumns();

                dgvFaculty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvFaculty.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
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
            string MaKhoa = txtFacultyID.Text.Trim();
            string TenKhoa = txtName.Text.Trim();
            string DiaChi = txtAddress.Text.Trim();
            string DienThoai = txtPhoneNumber.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaKhoa) || String.IsNullOrWhiteSpace(TenKhoa) ||
                    String.IsNullOrWhiteSpace(DiaChi) || String.IsNullOrWhiteSpace(DienThoai))
                {
                    throw new Exception("All fields need to be filled!");
                }

                bool result = khoa.AddData(MaKhoa, TenKhoa, DiaChi, DienThoai, ref err);
                if (result)
                    MessageBox.Show("Added faculty!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
