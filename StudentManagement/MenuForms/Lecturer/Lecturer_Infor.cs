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

namespace StudentManagement.MenuForms.Lecturer
{
    public partial class Lecturer_Infor : Form
    {
        BS_GiangVien giangVien = new BS_GiangVien();
        public Lecturer_Infor()
        {
            InitializeComponent();

            dgvLecturer.AllowUserToOrderColumns = true;
            dgvLecturer.AllowUserToResizeColumns = true;
        }

        private void Lecturer_Infor_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                dgvLecturer.DataSource = giangVien.GetData();
                dgvLecturer.AutoResizeColumns();

                dgvLecturer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLecturer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                dgvLecturer_CellEnter(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLecturer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvLecturer.Rows[0].Cells[0].Value == null)
                    return;

                int row = dgvLecturer.CurrentCell.RowIndex;

                txtLecturerID.Text = dgvLecturer.Rows[row].Cells[0].Value.ToString().Trim();
                txtName.Text = dgvLecturer.Rows[row].Cells[1].Value.ToString().Trim();
                txtAddress.Text = dgvLecturer.Rows[row].Cells[2].Value.ToString().Trim();
                txtPhone.Text = dgvLecturer.Rows[row].Cells[3].Value.ToString().Trim();
                txtFalcutyID.Text = dgvLecturer.Rows[row].Cells[4].Value.ToString().Trim();
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
            ws.Name = "Lecturer";

            List<int> excludedColumns = new List<int>();

            int columnIndex = 1;
            for (int i = 0; i < dgvLecturer.Columns.Count; i++)
            {
                if (!dgvLecturer.Columns[i].Visible)
                    excludedColumns.Add(i);
                else
                {
                    ws.Cells[1, columnIndex] = dgvLecturer.Columns[i].HeaderText;
                    columnIndex++;
                }
            }

            for (int i = 0; i < dgvLecturer.Rows.Count; i++)
            {
                columnIndex = 1;
                for (int j = 0; j < dgvLecturer.Columns.Count; j++)
                {
                    if (!excludedColumns.Contains(j))
                    {
                        ws.Cells[i + 2, columnIndex] = dgvLecturer.Rows[i].Cells[j].Value.ToString();
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
            printer.PrintDataGridView(dgvLecturer);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

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
                    int lecturerID;
                    if (int.TryParse(txtSearch.Text.Trim(), out lecturerID))
                    {
                        dgvLecturer.DataSource = giangVien.SearchByLecturerID(lecturerID);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid lecturer ID.");
                    }
                    break;
                case 1:
                    dgvLecturer.DataSource = giangVien.SearchByName(txtSearch.Text.Trim());
                    break;
                case 2:
                    dgvLecturer.DataSource = giangVien.SearchByHometown(txtSearch.Text.Trim());
                    break;
                case 3:
                    dgvLecturer.DataSource = giangVien.SearchByFalcutyID(txtSearch.Text.Trim());
                    break;
                default:
                    break;
            }
            dgvLecturer_CellEnter(null, null);
        }

        private void btnSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }
    }
}
