using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BS_Layer
{
    class BS_GiangVien
    {
        public DataTable GetData()
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from lecturers in dbEntities.GiangViens
                         select lecturers;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Lecturer ID");
            dataTable.Columns.Add("Lecturer's Name");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone Number");
            dataTable.Columns.Add("Faculty ID");
           
            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaGV, tuple.TenGV, tuple.DiaChi,
                    tuple.SDT, tuple.MaKhoa);

            return dataTable;
        }
        public bool AddData(int MaGV, string TenGV, string DiaChi,
            string SDT, string MaKhoa, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                GiangVien giangVien = new GiangVien();
                giangVien.MaGV = MaGV;
                giangVien.TenGV = TenGV;
                giangVien.DiaChi = DiaChi;
                giangVien.SDT = SDT;
                giangVien.MaKhoa = MaKhoa;

                dbEntities.GiangViens.Add(giangVien);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool RemoveData(int MaGV, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                GiangVien giangVien = new GiangVien();
                giangVien.MaGV = MaGV;

                dbEntities.GiangViens.Attach(giangVien);
                dbEntities.GiangViens.Remove(giangVien);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool UpdateData(int MaGV, string TenGV, string DiaChi,
            string SDT, string MaKhoa, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                var tuple = (from lecturers in dbEntities.GiangViens
                             where lecturers.MaGV == MaGV
                             select lecturers).SingleOrDefault();

                if (tuple != null)
                {
                    tuple.TenGV = TenGV;
                    tuple.DiaChi = DiaChi;
                    tuple.SDT = SDT;
                    tuple.MaKhoa = MaKhoa;

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
        public DataTable SearchByLecturerID(int MaGV)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from lecturers in dbEntities.GiangViens
                         where lecturers.MaGV.ToString().Contains(MaGV.ToString())
                         select lecturers;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Lecturer ID");
            dataTable.Columns.Add("Lecturer's Name");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone Number");
            dataTable.Columns.Add("Falcuty ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaGV, tuple.TenGV, tuple.DiaChi,
                    tuple.SDT, tuple.MaKhoa);

            return dataTable;
        }

        public DataTable SearchByName(string TenGV)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from lecturers in dbEntities.GiangViens
                         where lecturers.TenGV.Contains(TenGV)
                         select lecturers;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Lecturer ID");
            dataTable.Columns.Add("Lecturer's Name");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone Number");
            dataTable.Columns.Add("Falcuty ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaGV, tuple.TenGV, tuple.DiaChi,
                    tuple.SDT, tuple.MaKhoa);

            return dataTable;
        }

        public DataTable SearchByHometown(string DiaChi)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from lecturers in dbEntities.GiangViens
                         where lecturers.DiaChi.Contains(DiaChi)
                         select lecturers;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Lecturer ID");
            dataTable.Columns.Add("Lecturer's Name");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone Number");
            dataTable.Columns.Add("Falcuty ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaGV, tuple.TenGV, tuple.DiaChi,
                    tuple.SDT, tuple.MaKhoa);

            return dataTable;
        }

        public DataTable SearchByFalcutyID(string MaKhoa)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from lecturers in dbEntities.GiangViens
                         where lecturers.MaKhoa.Contains(MaKhoa)
                         select lecturers;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Lecturer ID");
            dataTable.Columns.Add("Lecturer's Name");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone Number");
            dataTable.Columns.Add("Falcuty ID");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaGV, tuple.TenGV, tuple.DiaChi,
                    tuple.SDT, tuple.MaKhoa);

            return dataTable;
        }
        #endregion
    }
}