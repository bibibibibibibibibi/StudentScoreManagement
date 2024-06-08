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

namespace StudentManagement.MenuForms.Academic_Course
{
    public partial class AcaCourse_Info : Form
    {
        BS_AcaCourse acaCourse = new BS_AcaCourse();
        public AcaCourse_Info()
        {
            InitializeComponent();
            dgvAcaCourse.AllowUserToOrderColumns = true;
            dgvAcaCourse.AllowUserToResizeColumns = true;
        }
        private void AcaCourse_Infor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvAcaCourse.DataSource = acaCourse.GetData();
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook wb = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet ws = null;
            ws = wb.Sheets["Sheet1"];
            ws = wb.ActiveSheet;
            ws.Name = "Academic Course";

            List<int> excludedColumns = new List<int>();

            int columnIndex = 1;
            for (int i = 0; i < dgvAcaCourse.Columns.Count; i++)
            {
                if (!dgvAcaCourse.Columns[i].Visible)
                    excludedColumns.Add(i);
                else
                {
                    ws.Cells[1, columnIndex] = dgvAcaCourse.Columns[i].HeaderText;
                    columnIndex++;
                }
            }

            for (int i = 0; i < dgvAcaCourse.Rows.Count; i++)
            {
                columnIndex = 1;
                for (int j = 0; j < dgvAcaCourse.Columns.Count; j++)
                {
                    if (!excludedColumns.Contains(j))
                    {
                        ws.Cells[i + 2, columnIndex] = dgvAcaCourse.Rows[i].Cells[j].Value.ToString();
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
            printer.PrintDataGridView(dgvAcaCourse);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

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
                    dgvAcaCourse.DataSource = acaCourse.SearchByAcaCourseID(txtSearch.Text.Trim());
                    break;
                case 1:
                    dgvAcaCourse.DataSource = acaCourse.SearchBySubjectID(txtSearch.Text.Trim());
                    break;
                case 2:
                    try
                    {
                        dgvAcaCourse.DataSource = acaCourse.SearchByYearID(int.Parse(txtSearch.Text.Trim()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
    }
}
