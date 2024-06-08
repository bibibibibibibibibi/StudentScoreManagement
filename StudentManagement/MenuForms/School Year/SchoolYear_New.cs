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
    public partial class SchoolYear_New : Form
    {
        string err;

        BS_KhoaHoc schoolYear = new BS_KhoaHoc();

        public SchoolYear_New()
        {
            InitializeComponent();

            dgvSchoolYear.AllowUserToOrderColumns = true;
            dgvSchoolYear.AllowUserToResizeColumns = true;
        }

        private void SchoolYear_New_Load(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MaKhoaHoc = txtYearID.Text.Trim();
            string TenKhoaHoc = txtName.Text.Trim();

            try
            {
                if (String.IsNullOrWhiteSpace(MaKhoaHoc) || String.IsNullOrWhiteSpace(TenKhoaHoc))
                {
                    throw new Exception("All fields need to be filled!");
                }

                bool result = schoolYear.AddData(MaKhoaHoc, TenKhoaHoc, ref err);
                if (result)
                    MessageBox.Show("Added school year!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
