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
    public partial class Class_Manage : Form
    {
        string err;

        BS_Lop lop = new BS_Lop();
        BS_Khoa khoa = new BS_Khoa();
        BS_HeDT heDT = new BS_HeDT();
        BS_KhoaHoc khoaHoc = new BS_KhoaHoc();

        public Class_Manage()
        {
            InitializeComponent();

            getComboBoxItems();

            dgvClass.AllowUserToOrderColumns = true;
            dgvClass.AllowUserToResizeColumns = true;
        }

        private void Class_Manage_Load(object sender, EventArgs e)
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

                dgvClass_CellEnter(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClass_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvClass.Rows[0].Cells[0].Value == null)
                    return;

                int row = dgvClass.CurrentCell.RowIndex;

                txtClassID.Text = dgvClass.Rows[row].Cells[0].Value.ToString().Trim();
                txtName.Text = dgvClass.Rows[row].Cells[1].Value.ToString().Trim();

                // DisplayMember and ValueMember MUST take the same column name as in BS_Layer/BS_Khoa.cs
                cbbFacultyID.DataSource = khoa.GetData();
                cbbFacultyID.DisplayMember = "Faculty ID";
                cbbFacultyID.ValueMember = "Faculty ID";
                cbbFacultyID.SelectedValue = dgvClass.Rows[row].Cells[2].Value.ToString().Trim();

                // DisplayMember and ValueMember MUST take the same column name as in BS_Layer/BS_HeDT.cs
                cbbEduSysID.DataSource = heDT.GetData();
                cbbEduSysID.DisplayMember = "System ID";
                cbbEduSysID.ValueMember = "System ID";
                cbbEduSysID.SelectedValue = dgvClass.Rows[row].Cells[3].Value.ToString().Trim();

                // DisplayMember and ValueMember MUST take the same column name as in BS_Layer/BS_HeDT.cs
                cbbYearID.DataSource = khoaHoc.GetData();
                cbbYearID.DisplayMember = "Year ID";
                cbbYearID.ValueMember = "Year ID";
                cbbYearID.SelectedValue = dgvClass.Rows[row].Cells[4].Value.ToString().Trim();
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
                    dgvClass.DataSource = lop.SearchByClassID(txtSearch.Text.Trim());
                    break;
                case 1:
                    dgvClass.DataSource = lop.SearchByName(txtSearch.Text.Trim());
                    break;
                case 2:
                    dgvClass.DataSource = lop.SearchByFacultyID(txtSearch.Text.Trim());
                    break;
                case 3:
                    dgvClass.DataSource = lop.SearchByEdSysID(txtSearch.Text.Trim());
                    break;
                case 4:
                    dgvClass.DataSource = lop.SearchByYearID(txtSearch.Text.Trim());
                    break;
                default:
                    break;
            }
            dgvClass_CellEnter(null, null);
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

            string MaLop = txtClassID.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaLop))
                {
                    throw new Exception("Please select a valid class");
                }

                bool result = lop.RemoveData(MaLop, ref err);
                if (result)
                    MessageBox.Show("Removed class!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            string MaLop = txtClassID.Text.Trim();
            string TenLop = txtName.Text.Trim();
            string MaKhoa = cbbFacultyID.Text.Trim();
            string MaHeDT = cbbEduSysID.Text.Trim();
            string MaKhoaHoc = cbbYearID.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(TenLop) || String.IsNullOrWhiteSpace(MaKhoa) || 
                    String.IsNullOrWhiteSpace(MaHeDT) || String.IsNullOrWhiteSpace(MaKhoaHoc))
                {
                    throw new Exception("All fields need to be filled!");
                }

                bool result = lop.UpdateData(MaLop, TenLop, MaKhoa, MaHeDT, MaKhoaHoc, ref err);
                if (result)
                    MessageBox.Show("Updated class!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
