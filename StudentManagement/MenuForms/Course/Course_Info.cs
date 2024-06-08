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
    public partial class Course_Info : Form
    {
        BS_MonHoc monHoc = new BS_MonHoc();

        public Course_Info()
        {
            InitializeComponent();

            dgvCourse.AllowUserToOrderColumns = true;
            dgvCourse.AllowUserToResizeColumns = true;
        }

        private void Course_Info_Load(object sender, EventArgs e)
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
                txtCredits.Text = dgvCourse.Rows[row].Cells[2].Value.ToString().Trim();
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook wb = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet ws = null;
            ws = wb.Sheets["Sheet1"];
            ws = wb.ActiveSheet;
            ws.Name = "Course";

            List<int> excludedColumns = new List<int>();

            int columnIndex = 1;
            for (int i = 0; i < dgvCourse.Columns.Count; i++)
            {
                if (!dgvCourse.Columns[i].Visible)
                    excludedColumns.Add(i);
                else
                {
                    ws.Cells[1, columnIndex] = dgvCourse.Columns[i].HeaderText;
                    columnIndex++;
                }
            }

            for (int i = 0; i < dgvCourse.Rows.Count; i++)
            {
                columnIndex = 1;
                for (int j = 0; j < dgvCourse.Columns.Count; j++)
                {
                    if (!excludedColumns.Contains(j))
                    {
                        ws.Cells[i + 2, columnIndex] = dgvCourse.Rows[i].Cells[j].Value.ToString();
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
            printer.PrintDataGridView(dgvCourse);
        }
        #endregion
    }
}
