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

namespace StudentManagement.MenuForms.School_Year
{
    public partial class SchoolYear_Manage : Form
    {
        string err;

        BS_KhoaHoc schoolYear = new BS_KhoaHoc();

        public SchoolYear_Manage()
        {
            InitializeComponent();

            dgvSchoolYear.AllowUserToOrderColumns = true;
            dgvSchoolYear.AllowUserToResizeColumns = true;
        }

        private void SchoolYear_Manage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvSchoolYear.DataSource = schoolYear.GetData();
                dgvSchoolYear.AutoResizeColumns();

                dgvSchoolYear.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSchoolYear.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                dgvSchoolYear_CellEnter(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSchoolYear_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSchoolYear.Rows[0].Cells[0].Value == null)
                    return;

                int row = dgvSchoolYear.CurrentCell.RowIndex;

                txtYearID.Text = dgvSchoolYear.Rows[row].Cells[0].Value.ToString().Trim();
                txtName.Text = dgvSchoolYear.Rows[row].Cells[1].Value.ToString().Trim();
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
                    dgvSchoolYear.DataSource = schoolYear.SearchByYearID(txtSearch.Text.Trim());
                    break;
                case 1:
                    dgvSchoolYear.DataSource = schoolYear.SearchByName(txtSearch.Text.Trim());
                    break;
                default:
                    break;
            }
            dgvSchoolYear_CellEnter(null, null);
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
            string MaKhoaHoc = txtYearID.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaKhoaHoc))
                {
                    throw new Exception("Please select a valid school year");
                }

                bool result = schoolYear.RemoveData(MaKhoaHoc, ref err);
                if (result)
                    MessageBox.Show("Removed school year!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string MaKhoaHoc = txtYearID.Text.Trim();
            string TenKhoaHoc = txtName.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(TenKhoaHoc))
                {
                    throw new Exception("All fields need to be filled!");
                }

                bool result = schoolYear.UpdateData(MaKhoaHoc, TenKhoaHoc, ref err);
                if (result)
                    MessageBox.Show("Updated school year!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
