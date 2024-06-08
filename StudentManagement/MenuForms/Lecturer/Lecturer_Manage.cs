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
    public partial class Lecturer_Manage : Form
    {
        string err;

        BS_GiangVien giangVien = new BS_GiangVien();

        public Lecturer_Manage()
        {
            InitializeComponent();

            dgvLecturer.AllowUserToOrderColumns = true;
            dgvLecturer.AllowUserToResizeColumns = true;
        }

        private void Lecturer_Manage_Load(object sender, EventArgs e)
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

                dgvLecturer_CellEnter(null, null);
            }
            catch (Exception ex)
            {
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
                    int lecturerID;
                    if (int.TryParse(txtSearch.Text.Trim(), out lecturerID))
                    {
                        dgvLecturer.DataSource = giangVien.SearchByLecturerID(lecturerID);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid lecturer ID.");
                    }
                    break;
                case 1:
                    dgvLecturer.DataSource = giangVien.SearchByName(txtSearch.Text.Trim());
                    break;
                case 2:
                    dgvLecturer.DataSource = giangVien.SearchByHometown(txtSearch.Text.Trim());
                    break;
                case 3:
                    dgvLecturer.DataSource = giangVien.SearchByFalcutyID(txtSearch.Text.Trim());
                    break;
                default:
                    break;
            }
            dgvLecturer_CellEnter(null, null);
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

            string MaGV = txtLecturerID.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaGV))
                {
                    throw new Exception("Please select a valid faculty");
                }
                int lecturerID = int.Parse(MaGV);
                bool result = giangVien.RemoveData(lecturerID, ref err);
                if (result)
                    MessageBox.Show("Removed lecturer!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string MaGV = txtLecturerID.Text.Trim();
            string TenGV = txtName.Text.Trim();
            string DiaChi = txtAddress.Text.Trim();
            string SDT = txtPhoneNumber.Text.Trim();
            string MaKhoa = txtFalcutyID.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaGV) ||String.IsNullOrWhiteSpace(DiaChi) || 
                    String.IsNullOrWhiteSpace(TenGV))
                {
                    throw new Exception("All fields need to be filled!");
                }
                int lecturerID = int.Parse(MaGV);

                bool result = giangVien.UpdateData(lecturerID, TenGV, DiaChi, SDT, MaKhoa, ref err);
                if (result)
                    MessageBox.Show("Updated lecturer!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvLecturer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvLecturer.Rows[0].Cells[0].Value == null)
                    return;

                int row = dgvLecturer.CurrentCell.RowIndex;

                txtLecturerID.Text = dgvLecturer.Rows[row].Cells[0].Value.ToString().Trim();
                txtName.Text = dgvLecturer.Rows[row].Cells[1].Value.ToString().Trim();
                txtAddress.Text = dgvLecturer.Rows[row].Cells[2].Value.ToString().Trim();
                txtPhoneNumber.Text = dgvLecturer.Rows[row].Cells[3].Value.ToString().Trim();
                txtFalcutyID.Text = dgvLecturer.Rows[row].Cells[4].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                if (ex is InvalidCastException)
                    return;
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        



    }
}
