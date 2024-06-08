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

namespace StudentManagement.MenuForms.Education_System
{
    public partial class EdSystem_Manage : Form
    {
        string err;

        BS_HeDT heDT = new BS_HeDT();

        public EdSystem_Manage()
        {
            InitializeComponent();

            dgvSystem.AllowUserToOrderColumns = true;
            dgvSystem.AllowUserToResizeColumns = true;
        }

        private void EdSystem_Manage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvSystem.DataSource = heDT.GetData();
                dgvSystem.AutoResizeColumns();

                dgvSystem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSystem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                dgvSystem_CellEnter(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSystem_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSystem.Rows[0].Cells[0].Value == null)
                    return;

                int row = dgvSystem.CurrentCell.RowIndex;

                txtSystemID.Text = dgvSystem.Rows[row].Cells[0].Value.ToString().Trim();
                txtName.Text = dgvSystem.Rows[row].Cells[1].Value.ToString().Trim();
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
                    dgvSystem.DataSource = heDT.SearchBySystemID(txtSearch.Text.Trim());
                    break;
                case 1:
                    dgvSystem.DataSource = heDT.SearchByName(txtSearch.Text.Trim());
                    break;
                default:
                    break;
            }
            dgvSystem_CellEnter(null, null);
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

            string MaHeDT = txtSystemID.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaHeDT))
                {
                    throw new Exception("Please select a valid faculty");
                }

                bool result = heDT.RemoveData(MaHeDT, ref err);
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

            string MaHeDT = txtSystemID.Text.Trim();
            string TenHeDT = txtName.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(TenHeDT))
                {
                    throw new Exception("All fields need to be filled!");
                }

                bool result = heDT.UpdateData(MaHeDT, TenHeDT, ref err);
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
