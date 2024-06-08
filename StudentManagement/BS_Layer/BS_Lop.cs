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
    class BS_Lop
    {
        public DataTable GetData()
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from classes in dbEntities.Lops
                         select classes;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Class ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Faculty ID");
            dataTable.Columns.Add("Edu Sys. ID");
            dataTable.Columns.Add("Year ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaLop, tuple.TenLop, tuple.MaKhoa, tuple.MaHeDT, tuple.MaKhoaHoc);

            return dataTable;
        }

        public bool AddData(string MaLop, string TenLop, string MaKhoa, 
            string MaHeDT, string MaKhoaHoc, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                Lop lop = new Lop();
                lop.MaLop = MaLop;
                lop.TenLop = TenLop;
                lop.MaKhoa = MaKhoa;
                lop.MaHeDT = MaHeDT;
                lop.MaKhoaHoc = MaKhoaHoc;

                dbEntities.Lops.Add(lop);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool RemoveData(string MaLop, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                Lop lop = new Lop();
                lop.MaLop = MaLop;

                dbEntities.Lops.Attach(lop);
                dbEntities.Lops.Remove(lop);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool UpdateData(string MaLop, string TenLop, string MaKhoa,
            string MaHeDT, string MaKhoaHoc, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                var tuple = (from classes in dbEntities.Lops
                            where classes.MaLop == MaLop
                            select classes).SingleOrDefault();

                if (tuple != null)
                {
                    tuple.TenLop = TenLop;
                    tuple.MaKhoa = MaKhoa;
                    tuple.MaHeDT = MaHeDT;
                    tuple.MaKhoaHoc = MaKhoaHoc;

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

        public void GetListOfClass(System.Windows.Forms.Control control)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from classes in dbEntities.Lops
                         select classes.MaLop;

            foreach (var tuple in tuples)
                (control as ComboBox).Items.Add(tuple);
        }

        #region Search functions
        public DataTable SearchByClassID(string MaLop)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from classes in dbEntities.Lops
                         where classes.MaLop.Contains(MaLop)
                         select classes;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Class ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Faculty ID");
            dataTable.Columns.Add("Edu Sys. ID");
            dataTable.Columns.Add("Year ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaLop, tuple.TenLop, tuple.MaKhoa, tuple.MaHeDT, tuple.MaKhoaHoc);

            return dataTable;
        }

        public DataTable SearchByName(string TenLop)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from classes in dbEntities.Lops
                         where classes.TenLop.Contains(TenLop)
                         select classes;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Class ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Faculty ID");
            dataTable.Columns.Add("Edu Sys. ID");
            dataTable.Columns.Add("Year ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaLop, tuple.TenLop, tuple.MaKhoa, tuple.MaHeDT, tuple.MaKhoaHoc);

            return dataTable;
        }

        public DataTable SearchByFacultyID(string MaKhoa)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from classes in dbEntities.Lops
                         where classes.MaKhoa.Contains(MaKhoa)
                         select classes;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Class ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Faculty ID");
            dataTable.Columns.Add("Edu Sys. ID");
            dataTable.Columns.Add("Year ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaLop, tuple.TenLop, tuple.MaKhoa, tuple.MaHeDT, tuple.MaKhoaHoc);

            return dataTable;
        }

        public DataTable SearchByEdSysID(string MaHeDT)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from classes in dbEntities.Lops
                         where classes.MaHeDT.Contains(MaHeDT)
                         select classes;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Class ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Faculty ID");
            dataTable.Columns.Add("Edu Sys. ID");
            dataTable.Columns.Add("Year ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaLop, tuple.TenLop, tuple.MaKhoa, tuple.MaHeDT, tuple.MaKhoaHoc);

            return dataTable;
        }

        public DataTable SearchByYearID(string MaKhoaHoc)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from classes in dbEntities.Lops
                         where classes.MaKhoaHoc.Contains(MaKhoaHoc)
                         select classes;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Class ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Faculty ID");
            dataTable.Columns.Add("Edu Sys. ID");
            dataTable.Columns.Add("Year ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaLop, tuple.TenLop, tuple.MaKhoa, tuple.MaHeDT, tuple.MaKhoaHoc);

            return dataTable;
        }
        #endregion
    }
}
