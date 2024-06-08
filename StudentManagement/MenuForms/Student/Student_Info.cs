using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StudentManagement.BS_Layer;

namespace StudentManagement.MenuForms.Student
{
    public partial class Student_Info : Form
    {
        BS_SinhVien sinhVien = new BS_SinhVien();

        public Student_Info()
        {
            InitializeComponent();

            dgvStudent.AllowUserToOrderColumns = true;
            dgvStudent.AllowUserToResizeColumns = true;
        }

        private void Student_Info_Load(object sender, EventArgs e)
        {
            LoadData();
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
                    txtGender.Text = "Female";
                else
                    txtGender.Text = "Male";

                txtDateOfBirth.Text = dgvStudent.Rows[row].Cells[3].Value.ToString().Trim();
                txtHometown.Text = dgvStudent.Rows[row].Cells[4].Value.ToString().Trim();
                txtClassID.Text = dgvStudent.Rows[row].Cells[5].Value.ToString().Trim();
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook wb = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet ws = null;
            ws = wb.Sheets["Sheet1"];
            ws = wb.ActiveSheet;
            ws.Name = "Student";

            List<int> excludedColumns = new List<int>();

            int columnIndex = 1;
            for (int i = 0; i < dgvStudent.Columns.Count; i++)
            {
                if (!dgvStudent.Columns[i].Visible)
                    excludedColumns.Add(i);
                else
                {
                    ws.Cells[1, columnIndex] = dgvStudent.Columns[i].HeaderText;
                    columnIndex++;
                }
            }

            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                columnIndex = 1;
                for (int j = 0; j < dgvStudent.Columns.Count; j++)
                {
                    if (!excludedColumns.Contains(j))
                    {
                        ws.Cells[i + 2, columnIndex] = dgvStudent.Rows[i].Cells[j].Value.ToString();
                        columnIndex++;
                    }
                }
            }

            var savefileDialoge = new SaveFileDialog();
            savefileDialoge.FileName = lblTitle.Text;
            savefileDialoge.DefaultExt = ".xlsx";
            if (savefileDialoge.ShowDialog() == DialogResult.OK)
                wb.SaveAs(savefileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = lblTitle.Text.Trim();
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "HCMUTE";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvStudent);
        }
        #endregion
    }
}
