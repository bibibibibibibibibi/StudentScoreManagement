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

namespace StudentManagement.MenuForms.Academic_Course
{
    public partial class AcaCourse_Manage : Form
    {
        string err;

        BS_AcaCourse lhp = new BS_AcaCourse();
        public AcaCourse_Manage()
        {
            InitializeComponent();
            dgvAcaCourse.AllowUserToOrderColumns = true;
            dgvAcaCourse.AllowUserToResizeColumns = true;
        }

        private void AcaCourse_Manage_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                dgvAcaCourse.DataSource = lhp.GetData();
                dgvAcaCourse.AutoResizeColumns();
                dgvAcaCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAcaCourse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                dgvAcaCourse_CellEnter(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAcaCourse_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAcaCourse.Rows[0].Cells[0].Value == null)
                    return;

                int row = dgvAcaCourse.CurrentCell.RowIndex;

                txtAcaCourseID.Text = dgvAcaCourse.Rows[row].Cells[0].Value.ToString().Trim();
                txtCourseID.Text = dgvAcaCourse.Rows[row].Cells[1].Value.ToString().Trim();
                txtYearID.Text = dgvAcaCourse.Rows[row].Cells[2].Value.ToString().Trim();
                txtYear.Text = dgvAcaCourse.Rows[row].Cells[3].Value.ToString().Trim();
                txtTeacherID.Text = dgvAcaCourse.Rows[row].Cells[4].Value.ToString().Trim();
                txtNoStudent.Text = dgvAcaCourse.Rows[row].Cells[5].Value.ToString().Trim();
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
                    dgvAcaCourse.DataSource = lhp.SearchByAcaCourseID(txtSearch.Text.Trim());
                    break;
                case 1:
                    dgvAcaCourse.DataSource = lhp.SearchBySubjectID(txtSearch.Text.Trim());
                    break;
                case 2:
                    int yearID;
                    if (int.TryParse(txtSearch.Text.Trim(), out yearID))
                    {
                        dgvAcaCourse.DataSource = lhp.SearchByYearID(yearID);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Year ID.");
                    }
                    break;
                case 3:
                    dgvAcaCourse.DataSource = lhp.SearchBySchoolyear(txtSearch.Text.Trim());
                    break;
                default:
                    break;
            }
            dgvAcaCourse_CellEnter(null, null);
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

            string MaLHP = txtAcaCourseID.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaLHP))
                {
                    throw new Exception("Please select a valid faculty");
                }
                bool result = lhp.RemoveData(MaLHP, ref err);
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
            string MaLHP = txtAcaCourseID.Text.Trim();
            string MaMH = txtCourseID.Text.Trim();
            string MaKhoaHoc = txtYearID.Text.Trim();
            string NamHoc = txtYear.Text.Trim();
            string MaGV = txtTeacherID.Text.Trim();
            string SiSoSV = txtNoStudent.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaGV) || String.IsNullOrWhiteSpace(MaLHP) ||
                    String.IsNullOrWhiteSpace(MaMH) || String.IsNullOrWhiteSpace(MaKhoaHoc))
                {
                    throw new Exception("All fields need to be filled!");
                }
                int Year = int.Parse(NamHoc);
                int lecturerID = int.Parse(MaGV);
                int NoStudents = int.Parse(SiSoSV);
                bool result = lhp.UpdateData(MaLHP, MaMH, MaKhoaHoc, Year, lecturerID, NoStudents, ref err);
                if (result)
                    MessageBox.Show("Updated Academic Course!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
