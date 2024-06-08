using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StudentManagement.BS_Layer;

namespace StudentManagement.MenuForms.Student
{
    public partial class Student_Manage : Form
    {
        string err;

        BS_SinhVien sinhVien = new BS_SinhVien();
        BS_Lop lop = new BS_Lop();

        public Student_Manage()
        {
            InitializeComponent();

            getComboBoxItems();

            dgvStudent.AllowUserToOrderColumns = true;
            dgvStudent.AllowUserToResizeColumns = true;
        }

        private void Student_Manage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void getComboBoxItems()
        {
            lop.GetListOfClass(cbbClassID);
        }

        private void toggleControls(bool state)
        {
            txtName.ReadOnly = !state;
            txtHometown.ReadOnly = !state;

            cbbClassID.Enabled = state;
            dtpDateOfBirth.Enabled = state;
            rbtMale.Enabled = state;
            rbtFemale.Enabled = state;

            btnDelete.Enabled = state;
            btnSave.Enabled = state;
        }

        private void LoadData()
        {
            try
            {
                dgvStudent.DataSource = sinhVien.GetData();
                dgvStudent.AutoResizeColumns();

                dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                dgvStudent_CellEnter(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudent_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStudent.Rows[0].Cells[0].Value == null)
                    return;

                int row = dgvStudent.CurrentCell.RowIndex;

                txtStudentID.Text = dgvStudent.Rows[row].Cells[0].Value.ToString().Trim();
                txtName.Text = dgvStudent.Rows[row].Cells[1].Value.ToString().Trim();

                if ((bool)dgvStudent.Rows[row].Cells[2].Value == true)
                    rbtFemale.Checked = true;
                else
                    rbtMale.Checked = true;

                dtpDateOfBirth.Text = dgvStudent.Rows[row].Cells[3].Value.ToString().Trim();
                txtHometown.Text = dgvStudent.Rows[row].Cells[4].Value.ToString().Trim();

                // DisplayMember and ValueMember MUST take the same column name as in BS_Layer/BS_Lop.cs
                cbbClassID.DataSource = lop.GetData();
                cbbClassID.DisplayMember = "Class ID";
                cbbClassID.ValueMember = "Class ID";
                cbbClassID.SelectedValue = dgvStudent.Rows[row].Cells[5].Value.ToString().Trim();
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
                    dgvStudent.DataSource = sinhVien.SearchByStudentID(txtSearch.Text.Trim());
                    break;
                case 1:
                    dgvStudent.DataSource = sinhVien.SearchByName(txtSearch.Text.Trim());
                    break;
                case 2:
                    dgvStudent.DataSource = sinhVien.SearchByHometown(txtSearch.Text.Trim());
                    break;
                case 3:
                    dgvStudent.DataSource = sinhVien.SearchByClassID(txtSearch.Text.Trim());
                    break;
                default:
                    break;
            }
            dgvStudent_CellEnter(null, null);
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

            string MaSV = txtStudentID.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaSV))
                {
                    throw new Exception("Please select a valid student");
                }

                bool result = sinhVien.RemoveData(MaSV, ref err);
                if (result)
                    MessageBox.Show("Removed student profile!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            string MaSV = txtStudentID.Text.Trim();
            string TenSV = txtName.Text.Trim();
            bool GioiTinh = rbtFemale.Checked;
            DateTime NgaySinh = dtpDateOfBirth.Value;
            string QueQuan = txtHometown.Text.Trim();
            string MaLop = cbbClassID.Text;

            try
            {
                if (String.IsNullOrWhiteSpace(TenSV) || String.IsNullOrWhiteSpace(QueQuan) || 
                    String.IsNullOrWhiteSpace(MaLop))
                {
                    throw new Exception("All fields need to be filled!");
                }

                bool result = sinhVien.UpdateData(MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop, ref err);
                if (result)
                    MessageBox.Show("Updated student profile!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
