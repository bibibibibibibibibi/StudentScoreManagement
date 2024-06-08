using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.BS_Layer
{
    class BS_MonHoc
    {
        public DataTable GetData()
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from course in dbEntities.MonHocs
                         select course;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Course ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Credits");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaMH, tuple.TenMH, tuple.SoTinChi);

            return dataTable;
        }

        public bool AddData(string MaMH, string TenMH, int SoTinChi, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                MonHoc monHoc = new MonHoc();
                monHoc.MaMH = MaMH;
                monHoc.TenMH = TenMH;
                monHoc.SoTinChi = SoTinChi;

                dbEntities.MonHocs.Add(monHoc);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool RemoveData(string MaMH, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                MonHoc monHoc = new MonHoc();
                monHoc.MaMH = MaMH;

                dbEntities.MonHocs.Attach(monHoc);
                dbEntities.MonHocs.Remove(monHoc);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool UpdateData(string MaMH, string TenMH, int SoTinChi, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                var tuple = (from course in dbEntities.MonHocs
                             where course.MaMH == MaMH
                             select course).SingleOrDefault();

                if (tuple != null)
                {
                    tuple.TenMH = TenMH;
                    tuple.SoTinChi = SoTinChi;

                    dbEntities.SaveChanges();
                }
                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public void GetListOfCourse(System.Windows.Forms.Control control)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from course in dbEntities.MonHocs
                         select course.MaMH;

            foreach (var tuple in tuples)
                (control as ComboBox).Items.Add(tuple);
        }

        #region Search functions
        public DataTable SearchByCourseID(string MaMH)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from course in dbEntities.MonHocs
                         where course.MaMH.Contains(MaMH)
                         select course;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Course ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Credits");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaMH, tuple.TenMH, tuple.SoTinChi);

            return dataTable;
        }

        public DataTable SearchByName(string TenMH)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from course in dbEntities.MonHocs
                         where course.TenMH.Contains(TenMH)
                         select course;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Course ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Credits");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaMH, tuple.TenMH, tuple.SoTinChi);

            return dataTable;
        }

        public DataTable SearchByCredits(int SoTrinh)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from course in dbEntities.MonHocs
                         where course.SoTinChi == SoTrinh
                         select course;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Course ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Credits");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaMH, tuple.TenMH, tuple.SoTinChi);

            return dataTable;
        }
        #endregion
    }
}
