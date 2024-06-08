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
    public partial class EdSystem_New : Form
    {
        string err;

        BS_HeDT heDT = new BS_HeDT();

        public EdSystem_New()
        {
            InitializeComponent();

            dgvSystem.AllowUserToOrderColumns = true;
            dgvSystem.AllowUserToResizeColumns = true;
        }

        private void EdSystem_New_Load(object sender, EventArgs e)
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
            string MaHeDT = txtSystemID.Text.Trim();
            string TenHeDT = txtName.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaHeDT) || String.IsNullOrWhiteSpace(TenHeDT))
                {
                    throw new Exception("All fields need to be filled!");
                }

                bool result = heDT.AddData(MaHeDT, TenHeDT, ref err);
                if (result)
                    MessageBox.Show("Added education system!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
