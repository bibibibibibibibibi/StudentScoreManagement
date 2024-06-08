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
    public partial class Score_Info : Form
    {
        BS_Diem diem = new BS_Diem();

        public Score_Info()
        {
            InitializeComponent();

            dgvScore.AllowUserToOrderColumns = true;
            dgvScore.AllowUserToResizeColumns = true;
        }

        private void Score_Info_Load(object sender, EventArgs e)
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
                MessageBox.Show(ex.InnerException.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                txtScore1.Text = decimal.Parse(dgvScore.Rows[row].Cells[3].Value.ToString().Trim()).ToString();
                txtScore2.Text = decimal.Parse(dgvScore.Rows[row].Cells[4].Value.ToString().Trim()).ToString();
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
                MessageBox.Show(ex.InnerException.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                Report viewer = new Report();
                viewer.ShowDialog();
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook wb = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet ws = null;
            ws = wb.Sheets["Sheet1"];
            ws = wb.ActiveSheet;
            ws.Name = "Score";

            List<int> excludedColumns = new List<int>();

            int columnIndex = 1;
            for (int i = 0; i < dgvScore.Columns.Count; i++)
            {
                if (!dgvScore.Columns[i].Visible)
                    excludedColumns.Add(i);
                else
                {
                    ws.Cells[1, columnIndex] = dgvScore.Columns[i].HeaderText;
                    columnIndex++;
                }
            }

            for (int i = 0; i < dgvScore.Rows.Count; i++)
            {
                columnIndex = 1;
                for (int j = 0; j < dgvScore.Columns.Count; j++)
                {
                    if (!excludedColumns.Contains(j))
                    {
                        ws.Cells[i + 2, columnIndex] = dgvScore.Rows[i].Cells[j].Value.ToString();
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
            printer.PrintDataGridView(dgvScore);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSearch.Text.Trim()))
            {
                MessageBox.Show("No search query!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
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
                        dgvScore.DataSource = diem.SearchByLowerScore1(float.Parse(txtSearch.Text.Trim()));
                        break;
                    case 3:
                        dgvScore.DataSource = diem.SearchByHigherScore1(float.Parse(txtSearch.Text.Trim()));
                        break;
                    case 4:
                        dgvScore.DataSource = diem.SearchByLowerScore2(float.Parse(txtSearch.Text.Trim()));
                        break;
                    case 5:
                        dgvScore.DataSource = diem.SearchByHigherScore2(float.Parse(txtSearch.Text.Trim()));
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvScore_CellEnter(null, null);
        }
    }
}
