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

namespace StudentManagement.MenuForms.Faculty
{
    public partial class Faculty_Info : Form
    {
        BS_Khoa khoa = new BS_Khoa();

        public Faculty_Info()
        {
            InitializeComponent();

            dgvFaculty.AllowUserToOrderColumns = true;
            dgvFaculty.AllowUserToResizeColumns = true;
        }

        private void Faculty_Info_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvFaculty.DataSource = khoa.GetData();
                dgvFaculty.AutoResizeColumns();

                dgvFaculty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvFaculty.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                dgvFaculty_CellEnter(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFaculty_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvFaculty.Rows[0].Cells[0].Value == null)
                    return;

                int row = dgvFaculty.CurrentCell.RowIndex;

                txtFacultyID.Text = dgvFaculty.Rows[row].Cells[0].Value.ToString().Trim();
                txtName.Text = dgvFaculty.Rows[row].Cells[1].Value.ToString().Trim();
                txtAddress.Text = dgvFaculty.Rows[row].Cells[2].Value.ToString().Trim();
                txtPhoneNumber.Text = dgvFaculty.Rows[row].Cells[3].Value.ToString().Trim();
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
                    dgvFaculty.DataSource = khoa.SearchByFacultyID(txtSearch.Text.Trim());
                    break;
                case 1:
                    dgvFaculty.DataSource = khoa.SearchByName(txtSearch.Text.Trim());
                    break;
                case 2:
                    dgvFaculty.DataSource = khoa.SearchByAddress(txtSearch.Text.Trim());
                    break;
                case 3:
                    dgvFaculty.DataSource = khoa.SearchByPhoneNumber(txtSearch.Text.Trim());
                    break;
                default:
                    break;
            }
            dgvFaculty_CellEnter(null, null);
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
            ws.Name = "Faculty";

            List<int> excludedColumns = new List<int>();

            int columnIndex = 1;
            for (int i = 0; i < dgvFaculty.Columns.Count; i++)
            {
                if (!dgvFaculty.Columns[i].Visible)
                    excludedColumns.Add(i);
                else
                {
                    ws.Cells[1, columnIndex] = dgvFaculty.Columns[i].HeaderText;
                    columnIndex++;
                }
            }

            for (int i = 0; i < dgvFaculty.Rows.Count; i++)
            {
                columnIndex = 1;
                for (int j = 0; j < dgvFaculty.Columns.Count; j++)
                {
                    if (!excludedColumns.Contains(j))
                    {
                        ws.Cells[i + 2, columnIndex] = dgvFaculty.Rows[i].Cells[j].Value.ToString();
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
            printer.PrintDataGridView(dgvFaculty);
        }
        #endregion
    }
}
