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
    class BS_Khoa
    {
        public DataTable GetData()
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from faculty in dbEntities.Khoas
                         select faculty;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Faculty ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone number");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaKhoa, tuple.TenKhoa, tuple.DiaChi, tuple.DienThoai);

            return dataTable;
        }

        public bool AddData(string MaKhoa, string TenKhoa, string DiaChi, string DienThoai, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                Khoa khoa = new Khoa();
                khoa.MaKhoa = MaKhoa;
                khoa.TenKhoa = TenKhoa;
                khoa.DiaChi = DiaChi;
                khoa.DienThoai = DienThoai;

                dbEntities.Khoas.Add(khoa);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool RemoveData(string MaKhoa, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                Khoa khoa = new Khoa();
                khoa.MaKhoa = MaKhoa;

                dbEntities.Khoas.Attach(khoa);
                dbEntities.Khoas.Remove(khoa);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool UpdateData(string MaKhoa, string TenKhoa, string DiaChi, string DienThoai, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                var tuple = (from faculty in dbEntities.Khoas
                            where faculty.MaKhoa == MaKhoa
                            select faculty).SingleOrDefault();

                if (tuple != null)
                {
                    tuple.TenKhoa = TenKhoa;
                    tuple.DiaChi = DiaChi;
                    tuple.DienThoai = DienThoai;

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

        public void GetListOfFaculty(System.Windows.Forms.Control control)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from faculty in dbEntities.Khoas
                         select faculty.MaKhoa;

            foreach (var tuple in tuples)
                (control as ComboBox).Items.Add(tuple);
        }

        #region Search functions
        public DataTable SearchByFacultyID(string MaKhoa)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from faculty in dbEntities.Khoas
                         where faculty.MaKhoa.Contains(MaKhoa)
                         select faculty;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Faculty ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone number");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaKhoa, tuple.TenKhoa, tuple.DiaChi, tuple.DienThoai);

            return dataTable;
        }

        public DataTable SearchByName(string TenKhoa)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from faculty in dbEntities.Khoas
                         where faculty.TenKhoa.Contains(TenKhoa)
                         select faculty;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Faculty ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone number");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaKhoa, tuple.TenKhoa, tuple.DiaChi, tuple.DienThoai);

            return dataTable;
        }

        public DataTable SearchByAddress(string DiaChi)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from faculty in dbEntities.Khoas
                         where faculty.DiaChi.Contains(DiaChi)
                         select faculty;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Faculty ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone number");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaKhoa, tuple.TenKhoa, tuple.DiaChi, tuple.DienThoai);

            return dataTable;
        }

        public DataTable SearchByPhoneNumber(string DienThoai)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from faculty in dbEntities.Khoas
                         where faculty.DienThoai.Contains(DienThoai)
                         select faculty;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Faculty ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone number");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaKhoa, tuple.TenKhoa, tuple.DiaChi, tuple.DienThoai);

            return dataTable;
        }
        #endregion
    }
}
