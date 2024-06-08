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

namespace StudentManagement.MenuForms.Course
{
    public partial class Course_Manage : Form
    {
        string err;

        BS_MonHoc monHoc = new BS_MonHoc();

        public Course_Manage()
        {
            InitializeComponent();

            dgvCourse.AllowUserToOrderColumns = true;
            dgvCourse.AllowUserToResizeColumns = true;
        }

        private void Course_Manage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvCourse.DataSource = monHoc.GetData();
                dgvCourse.AutoResizeColumns();

                dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCourse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                dgvCourse_CellEnter(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCourse_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCourse.Rows[0].Cells[0].Value == null)
                    return;

                int row = dgvCourse.CurrentCell.RowIndex;

                txtCourseID.Text = dgvCourse.Rows[row].Cells[0].Value.ToString().Trim();
                txtName.Text = dgvCourse.Rows[row].Cells[1].Value.ToString().Trim();
                nudCredits.Value = int.Parse(dgvCourse.Rows[row].Cells[2].Value.ToString().Trim());
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
            if (String.IsNullOrEmpty(txtSearch.Text.Trim()))
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
                    dgvCourse.DataSource = monHoc.SearchByCourseID(txtSearch.Text.Trim());
                    break;
                case 1:
                    dgvCourse.DataSource = monHoc.SearchByName(txtSearch.Text.Trim());
                    break;
                case 2:
                    try
                    {
                        dgvCourse.DataSource = monHoc.SearchByCredits(int.Parse(txtSearch.Text.Trim()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    break;
            }
            dgvCourse_CellEnter(null, null);
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

            string MaMH = txtCourseID.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaMH))
                {
                    throw new Exception("Please select a valid course");
                }

                bool result = monHoc.RemoveData(MaMH, ref err);
                if (result)
                    MessageBox.Show("Removed course!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            string MaMH = txtCourseID.Text.Trim();
            string TenMH = txtName.Text.Trim();
            int SoTrinh = int.Parse(nudCredits.Value.ToString().Trim());

            try
            {
                if (String.IsNullOrWhiteSpace(TenMH))
                {
                    throw new Exception("All fields need to be filled!");
                }

                bool result = monHoc.UpdateData(MaMH, TenMH, SoTrinh, ref err);
                if (result)
                    MessageBox.Show("Updated course!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
