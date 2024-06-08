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
    class BS_KhoaHoc
    {
        public DataTable GetData()
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from schoolYear in dbEntities.KhoaHocs
                         select schoolYear;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Year ID");
            dataTable.Columns.Add("Name");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaKhoaHoc, tuple.TenKhoaHoc);

            return dataTable;
        }

        public bool AddData(string MaKhoaHoc, string TenKhoaHoc, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                KhoaHoc khoaHoc = new KhoaHoc();
                khoaHoc.MaKhoaHoc = MaKhoaHoc;
                khoaHoc.TenKhoaHoc = TenKhoaHoc;

                dbEntities.KhoaHocs.Add(khoaHoc);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool RemoveData(string MaKhoaHoc, ref string err) 
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                KhoaHoc khoaHoc = new KhoaHoc();
                khoaHoc.MaKhoaHoc = MaKhoaHoc;

                dbEntities.KhoaHocs.Attach(khoaHoc);
                dbEntities.KhoaHocs.Remove(khoaHoc);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool UpdateData(string MaKhoaHoc, string TenKhoaHoc, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                var tuple = (from schoolYear in dbEntities.KhoaHocs
                            where schoolYear.MaKhoaHoc == MaKhoaHoc
                            select schoolYear).SingleOrDefault();

                if (tuple != null)
                {
                    tuple.TenKhoaHoc = TenKhoaHoc;

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

        public void GetListOfSchoolYear(System.Windows.Forms.Control control)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from schoolYear in dbEntities.KhoaHocs
                         select schoolYear.MaKhoaHoc;

            foreach (var tuple in tuples)
                (control as ComboBox).Items.Add(tuple);
        }

        #region Search functions
        public DataTable SearchByYearID(string MaKhoaHoc)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from schoolYear in dbEntities.KhoaHocs
                         where schoolYear.MaKhoaHoc.Contains(MaKhoaHoc)
                         select schoolYear;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Year ID");
            dataTable.Columns.Add("Name");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaKhoaHoc, tuple.TenKhoaHoc);

            return dataTable;
        }

        public DataTable SearchByName(string TenKhoaHoc)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from schoolYear in dbEntities.KhoaHocs
                         where schoolYear.TenKhoaHoc.Contains(TenKhoaHoc)
                         select schoolYear;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Year ID");
            dataTable.Columns.Add("Name");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaKhoaHoc, tuple.TenKhoaHoc);

            return dataTable;
        }
        #endregion
    }
}
