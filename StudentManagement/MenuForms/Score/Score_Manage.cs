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

namespace StudentManagement.MenuForms.Score
{
    public partial class Score_Manage : Form
    {
        string err;

        BS_Diem diem = new BS_Diem();

        public Score_Manage()
        {
            InitializeComponent();
            dgvScore.AllowUserToOrderColumns = true;
            dgvScore.AllowUserToResizeColumns = true;
        }

        private void Score_Manage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvScore.DataSource = diem.GetData();
                dgvScore.AutoResizeColumns();

                dgvScore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvScore.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                dgvScore_CellEnter(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvScore_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvScore.Rows[0].Cells[0].Value == null)
                    return;

                int row = dgvScore.CurrentCell.RowIndex;

                txtStudentID.Text = dgvScore.Rows[row].Cells[0].Value.ToString().Trim();
                txtCourseID.Text = dgvScore.Rows[row].Cells[1].Value.ToString().Trim();
                txtYear.Text = (int.Parse(dgvScore.Rows[row].Cells[2].Value.ToString().Trim()) / 3 + 1).ToString();
                txtSemester.Text = (int.Parse(dgvScore.Rows[row].Cells[2].Value.ToString().Trim()) % 3).ToString();

                nudScore1.Value = decimal.Parse(dgvScore.Rows[row].Cells[3].Value.ToString().Trim());
                nudScore2.Value = decimal.Parse(dgvScore.Rows[row].Cells[4].Value.ToString().Trim());
                txtAverage10.Text = decimal.Parse(dgvScore.Rows[row].Cells[5].Value.ToString().Trim()).ToString();
                txtAverage4.Text = (decimal.Parse(txtAverage10.Text) / 10 * 4).ToString();
                txtGPA.Text = GetGPA(decimal.Parse(txtAverage4.Text));

                if ((bool)dgvScore.Rows[row].Cells[6].Value == true)
                    txtResults.Text = "Passed";
                else
                    txtResults.Text = "Failed";
            }
            catch (Exception ex)
            {
                if (ex is InvalidCastException)
                    return;
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetGPA(decimal score)
        {
            if (score == 0)
                return "F";
            else if (score > 0 && score <= 0.7m)
                return "D-";
            else if (score > 0.7m && score <= 1)
                return "D";
            else if (score > 1 && score <= 1.3m)
                return "D+";
            else if (score > 1.3m && score <= 1.7m)
                return "C-";
            else if (score > 1.7m && score <= 2)
                return "C";
            else if (score > 2 && score <= 2.3m)
                return "C+";
            else if (score > 2.3m && score <= 2.7m)
                return "B-";
            else if (score > 2.7m && score <= 3)
                return "B";
            else if (score > 3 && score <= 3.3m)
                return "B+";
            else if (score > 3.3m && score <= 3.7m)
                return "A-";
            else
                return "A";
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
                    dgvScore.DataSource = diem.SearchByStudentID(txtSearch.Text.Trim());
                    break;
                case 1:
                    dgvScore.DataSource = diem.SearchByCourseID(txtSearch.Text.Trim());
                    break;
                case 2:
                    try
                    {
                        dgvScore.DataSource = diem.SearchByLowerScore1(float.Parse(txtSearch.Text.Trim()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 3:
                    try
                    {
                        dgvScore.DataSource = diem.SearchByHigherScore1(float.Parse(txtSearch.Text.Trim()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 4:
                    try
                    {
                        dgvScore.DataSource = diem.SearchByLowerScore2(float.Parse(txtSearch.Text.Trim()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 5:
                    try
                    {
                        dgvScore.DataSource = diem.SearchByHigherScore2(float.Parse(txtSearch.Text.Trim()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    break;
            }
            dgvScore_CellEnter(null, null);
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
            string MaMH = txtCourseID.Text.Trim();

            int nYear = int.Parse(txtYear.Text.Trim());
            int nSemester = int.Parse(txtSemester.Text.Trim());
            int HocKy = (nYear - 1) * 3 + nSemester;

            try
            {
                if (String.IsNullOrWhiteSpace(MaSV) || String.IsNullOrWhiteSpace(MaMH))
                {
                    throw new Exception("Please select a valid score");
                }

                bool result = diem.RemoveData(MaSV, MaMH, HocKy, ref err);
                if (result)
                    MessageBox.Show("Removed score!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string MaMH = txtCourseID.Text.Trim();

            int nYear = int.Parse(txtYear.Text.Trim());
            int nSemester = int.Parse(txtSemester.Text.Trim());
            int HocKy = (nYear - 1) * 3 + nSemester;

            float DiemLan1 = (float)nudScore1.Value;
            float DiemLan2 = (float)nudScore2.Value;

            try
            {
                bool result = diem.UpdateData(MaSV, MaMH, HocKy, DiemLan1, DiemLan2, ref err);
                if (result)
                    MessageBox.Show("Updated score!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
