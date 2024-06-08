using StudentManagement.QLDiemSV_DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            //this.dataTable1TableAdapter1.Fill(this.qLDiemSV_DataSet.DataTable1);
           // this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }
    }
}
