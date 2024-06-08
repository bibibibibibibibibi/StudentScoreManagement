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
    public partial class Faculty_Manage : Form
    {
        string err;

        BS_Khoa khoa = new BS_Khoa();

        public Faculty_Manage()
        {
            InitializeComponent();

            dgvFaculty.AllowUserToOrderColumns = true;
            dgvFaculty.AllowUserToResizeColumns = true;
        }

        private void Faculty_Manage_Load(object sender, EventArgs e)
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

                dgvFaculty_CellEnter(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFaculty_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvFaculty.Rows[0].Cells[0].Value == null)
                    return;

                int row = dgvFaculty.CurrentCell.RowIndex;

                txtFacultyID.Text = dgvFaculty.Rows[row].Cells[0].Value.ToString().Trim();
                txtName.Text = dgvFaculty.Rows[row].Cells[1].Value.ToString().Trim();
                txtAddress.Text = dgvFaculty.Rows[row].Cells[2].Value.ToString().Trim();
                txtPhoneNumber.Text = dgvFaculty.Rows[row].Cells[3].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                if (ex is InvalidCastException)
                    return;
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Button events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSearch.Text.Trim()))
            {
                MessageBox.Show("No search query!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (cbbSearch.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("No search type!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 0:
                    dgvFaculty.DataSource = khoa.SearchByFacultyID(txtSearch.Text.Trim());
                    break;
                case 1:
                    dgvFaculty.DataSource = khoa.SearchByName(txtSearch.Text.Trim());
                    break;
                case 2:
                    dgvFaculty.DataSource = khoa.SearchByAddress(txtSearch.Text.Trim());
                    break;
                case 3:
                    dgvFaculty.DataSource = khoa.SearchByPhoneNumber(txtSearch.Text.Trim());
                    break;
                default:
                    break;
            }
            dgvFaculty_CellEnter(null, null);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
            {
                return;
            }

            string MaKhoa = txtFacultyID.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaKhoa))
                {
                    throw new Exception("Please select a valid faculty");
                }

                bool result = khoa.RemoveData(MaKhoa, ref err);
                if (result)
                    MessageBox.Show("Removed faculty!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
            {
                return;
            }

            string MaKhoa = txtFacultyID.Text.Trim();
            string TenKhoa = txtName.Text.Trim();
            string DiaChi = txtAddress.Text.Trim();
            string DienThoai = txtPhoneNumber.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(TenKhoa) ||String.IsNullOrWhiteSpace(DiaChi) || 
                    String.IsNullOrWhiteSpace(DienThoai))
                {
                    throw new Exception("All fields need to be filled!");
                }

                bool result = khoa.UpdateData(MaKhoa, TenKhoa, DiaChi, DienThoai, ref err);
                if (result)
                    MessageBox.Show("Updated faculty!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        #endregion
    }
}
