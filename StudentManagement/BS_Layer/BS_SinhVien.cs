using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace StudentManagement.BS_Layer
{
    class BS_SinhVien
    {
        public DataTable GetData()
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from student in dbEntities.SinhViens
                         select student;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Female", typeof(bool));
            dataTable.Columns.Add("Date of Birth");
            dataTable.Columns.Add("Hometown");
            dataTable.Columns.Add("Class ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaSV, tuple.TenSV, tuple.GioiTinh,
                    tuple.NgaySinh.ToShortDateString(), tuple.QueQuan, tuple.MaLop);

            return dataTable;
        }

        public bool AddData(string MaSV, string TenSV, bool GioiTinh, 
            DateTime NgaySinh, string QueQuan, string MaLop, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                SinhVien sinhVien = new SinhVien();
                sinhVien.MaSV = MaSV;
                sinhVien.TenSV = TenSV;
                sinhVien.GioiTinh = GioiTinh;
                sinhVien.NgaySinh = NgaySinh;
                sinhVien.QueQuan = QueQuan;
                sinhVien.MaLop = MaLop;

                dbEntities.SinhViens.Add(sinhVien);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool RemoveData(string MaSV, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                SinhVien sinhVien = new SinhVien();
                sinhVien.MaSV = MaSV;

                dbEntities.SinhViens.Attach(sinhVien);
                dbEntities.SinhViens.Remove(sinhVien);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool UpdateData(string MaSV, string TenSV, bool GioiTinh,
            DateTime NgaySinh, string QueQuan, string MaLop, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                var tuple = (from student in dbEntities.SinhViens
                             where student.MaSV == MaSV
                             select student).SingleOrDefault();

                if (tuple != null)
                {
                    tuple.TenSV = TenSV;
                    tuple.GioiTinh = GioiTinh;
                    tuple.NgaySinh = NgaySinh;
                    tuple.QueQuan = QueQuan;
                    tuple.MaLop = MaLop;

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

        #region Search functions
        public DataTable SearchByStudentID(string MaSV)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from student in dbEntities.SinhViens
                         where student.MaSV.Contains(MaSV)
                         select student;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Female", typeof(bool));
            dataTable.Columns.Add("Date of Birth");
            dataTable.Columns.Add("Hometown");
            dataTable.Columns.Add("Class ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaSV, tuple.TenSV, tuple.GioiTinh,
                    tuple.NgaySinh.ToShortDateString(), tuple.QueQuan, tuple.MaLop);

            return dataTable;
        }

        public DataTable SearchByName(string TenSV)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from student in dbEntities.SinhViens
                         where student.TenSV.Contains(TenSV)
                         select student;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Female", typeof(bool));
            dataTable.Columns.Add("Date of Birth");
            dataTable.Columns.Add("Hometown");
            dataTable.Columns.Add("Class ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaSV, tuple.TenSV, tuple.GioiTinh,
                    tuple.NgaySinh.ToShortDateString(), tuple.QueQuan, tuple.MaLop);

            return dataTable;
        }

        public DataTable SearchByHometown(string QueQuan)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from student in dbEntities.SinhViens
                         where student.QueQuan.Contains(QueQuan)
                         select student;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Female", typeof(bool));
            dataTable.Columns.Add("Date of Birth");
            dataTable.Columns.Add("Hometown");
            dataTable.Columns.Add("Class ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaSV, tuple.TenSV, tuple.GioiTinh,
                    tuple.NgaySinh.ToShortDateString(), tuple.QueQuan, tuple.MaLop);

            return dataTable;
        }

        public DataTable SearchByClassID(string MaLop)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from student in dbEntities.SinhViens
                         where student.MaLop.Contains(MaLop)
                         select student;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Female", typeof(bool));
            dataTable.Columns.Add("Date of Birth");
            dataTable.Columns.Add("Hometown");
            dataTable.Columns.Add("Class ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaSV, tuple.TenSV, tuple.GioiTinh,
                    tuple.NgaySinh.ToShortDateString(), tuple.QueQuan, tuple.MaLop);

            return dataTable;
        }
        #endregion
    }
}
