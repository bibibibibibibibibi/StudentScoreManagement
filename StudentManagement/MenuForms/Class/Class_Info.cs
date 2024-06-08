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

namespace StudentManagement.MenuForms.Class
{
    public partial class Class_Info : Form
    {
        BS_Lop lop = new BS_Lop();

        public Class_Info()
        {
            InitializeComponent();
            dgvClass.AllowUserToOrderColumns = true;
            dgvClass.AllowUserToResizeColumns = true;
        }

        private void Class_Info_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvClass.DataSource = lop.GetData();
                dgvClass.AutoResizeColumns();

                dgvClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvClass.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                dgvClass_CellEnter(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClass_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvClass.Rows[0].Cells[0].Value == null)
                    return;

                int row = dgvClass.CurrentCell.RowIndex;

                txtClassID.Text = dgvClass.Rows[row].Cells[0].Value.ToString().Trim();
                txtName.Text = dgvClass.Rows[row].Cells[1].Value.ToString().Trim();
                txtFacultyID.Text = dgvClass.Rows[row].Cells[2].Value.ToString().Trim();
                txtEduSysID.Text = dgvClass.Rows[row].Cells[3].Value.ToString().Trim();
                txtYearID.Text = dgvClass.Rows[row].Cells[4].Value.ToString().Trim();
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
                    dgvClass.DataSource = lop.SearchByClassID(txtSearch.Text.Trim());
                    break;
                case 1:
                    dgvClass.DataSource = lop.SearchByName(txtSearch.Text.Trim());
                    break;
                case 2:
                    dgvClass.DataSource = lop.SearchByFacultyID(txtSearch.Text.Trim());
                    break;
                case 3:
                    dgvClass.DataSource = lop.SearchByEdSysID(txtSearch.Text.Trim());
                    break;
                case 4:
                    dgvClass.DataSource = lop.SearchByYearID(txtSearch.Text.Trim());
                    break;
                default:
                    break;
            }
            dgvClass_CellEnter(null, null);
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
            ws.Name = "Class";

            List<int> excludedColumns = new List<int>();

            int columnIndex = 1;
            for (int i = 0; i < dgvClass.Columns.Count; i++)
            {
                if (!dgvClass.Columns[i].Visible)
                    excludedColumns.Add(i);
                else
                {
                    ws.Cells[1, columnIndex] = dgvClass.Columns[i].HeaderText;
                    columnIndex++;
                }
            }

            for (int i = 0; i < dgvClass.Rows.Count; i++)
            {
                columnIndex = 1;
                for (int j = 0; j < dgvClass.Columns.Count; j++)
                {
                    if (!excludedColumns.Contains(j))
                    {
                        ws.Cells[i + 2, columnIndex] = dgvClass.Rows[i].Cells[j].Value.ToString();
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
            printer.PrintDataGridView(dgvClass);
        }
        #endregion
    }
}
