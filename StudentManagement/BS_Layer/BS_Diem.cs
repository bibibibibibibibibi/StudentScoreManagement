using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BS_Layer
{
    class BS_Diem
    {
        public DataTable GetData()
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from scores in dbEntities.Diems
                         select scores;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("Course ID");
            dataTable.Columns.Add("Semester");
            dataTable.Columns.Add("Score 1");
            dataTable.Columns.Add("Score 2");
            dataTable.Columns.Add("Average");
            dataTable.Columns.Add("Passed", typeof(bool));

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaSV, tuple.MaMH, tuple.HocKy, 
                    (tuple.DiemQuaTrinh == null ? 0 : tuple.DiemQuaTrinh),
                    (tuple.DiemCuoiKy == null ? 0 : tuple.DiemCuoiKy),
                    tuple.DiemTrungBinh, tuple.TinhTrang);

            return dataTable;
        }

        public bool AddData(string MaSV, string MaMH, int HocKy, float DiemQuaTrinh, float DiemCuoiKy, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                Diem diem = new Diem();
                diem.MaSV = MaSV;
                diem.MaMH = MaMH;
                diem.HocKy = HocKy;
                diem.DiemQuaTrinh = DiemQuaTrinh;
                diem.DiemCuoiKy = DiemCuoiKy;

                dbEntities.Diems.Add(diem);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool RemoveData(string MaSV, string MaMH, int HocKy, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                Diem diem = new Diem();
                diem.MaSV = MaSV;
                diem.MaMH = MaMH;
                diem.HocKy = HocKy;

                dbEntities.Diems.Attach(diem);
                dbEntities.Diems.Remove(diem);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool UpdateData(string MaSV, string MaMH, int HocKy, float DiemQuaTrinh, float DiemCuoiKy, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                var tuple = (from scores in dbEntities.Diems
                            where scores.MaSV == MaSV
                            where scores.MaMH == MaMH
                            where scores.HocKy == HocKy
                            select scores).SingleOrDefault();

                if (tuple != null)
                {
                    tuple.DiemQuaTrinh = DiemQuaTrinh;
                    tuple.DiemCuoiKy = DiemCuoiKy;

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

        #region Normal Search functions
        public DataTable SearchByStudentID(string MaSV)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from scores in dbEntities.Diems
                         where scores.MaSV.Contains(MaSV)
                         select scores;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("Course ID");
            dataTable.Columns.Add("Semester");
            dataTable.Columns.Add("Score 1");
            dataTable.Columns.Add("Score 2");
            dataTable.Columns.Add("Average");
            dataTable.Columns.Add("Passed", typeof(bool));

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaSV, tuple.MaMH, tuple.HocKy, 
                    (tuple.DiemQuaTrinh == null ? 0 : tuple.DiemQuaTrinh),
                    (tuple.DiemCuoiKy == null ? 0 : tuple.DiemCuoiKy),
                    tuple.DiemTrungBinh, tuple.TinhTrang);

            return dataTable;
        }

        public DataTable SearchByCourseID(string MaMH)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from scores in dbEntities.Diems
                         where scores.MaMH.Contains(MaMH)
                         select scores;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("Course ID");
            dataTable.Columns.Add("Semester");
            dataTable.Columns.Add("Score 1");
            dataTable.Columns.Add("Score 2");
            dataTable.Columns.Add("Average");
            dataTable.Columns.Add("Passed", typeof(bool));

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaSV, tuple.MaMH, tuple.HocKy, 
                    (tuple.DiemQuaTrinh == null ? 0 : tuple.DiemQuaTrinh),
                    (tuple.DiemCuoiKy == null ? 0 : tuple.DiemCuoiKy),
                    tuple.DiemTrungBinh, tuple.TinhTrang);

            return dataTable;
        }

        
        #endregion

        #region Score Search functions
        public DataTable SearchByLowerScore1(float DiemQuaTrinh)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from scores in dbEntities.Diems
                         where scores.DiemQuaTrinh < DiemQuaTrinh
                         select scores;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("Course ID");
            dataTable.Columns.Add("Semester");
            dataTable.Columns.Add("Score 1");
            dataTable.Columns.Add("Score 2");
            dataTable.Columns.Add("Average");
            dataTable.Columns.Add("Passed", typeof(bool));

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaSV, tuple.MaMH, tuple.HocKy, 
                    (tuple.DiemQuaTrinh == null ? 0 : tuple.DiemQuaTrinh), 
                    (tuple.DiemCuoiKy == null ? 0 : tuple.DiemCuoiKy),
                    tuple.DiemTrungBinh, tuple.TinhTrang);

            return dataTable;
        }

        public DataTable SearchByHigherScore1(float DiemQuaTrinh)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from scores in dbEntities.Diems
                         where scores.DiemQuaTrinh > DiemQuaTrinh
                         select scores;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("Course ID");
            dataTable.Columns.Add("Semester");
            dataTable.Columns.Add("Score 1");
            dataTable.Columns.Add("Score 2");
            dataTable.Columns.Add("Average");
            dataTable.Columns.Add("Passed", typeof(bool));

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaSV, tuple.MaMH, tuple.HocKy, 
                    (tuple.DiemQuaTrinh == null ? 0 : tuple.DiemQuaTrinh), 
                    (tuple.DiemCuoiKy == null ? 0 : tuple.DiemCuoiKy),
                    tuple.DiemTrungBinh, tuple.TinhTrang);

            return dataTable;
        }

        public DataTable SearchByLowerScore2(float DiemCuoiKy)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from scores in dbEntities.Diems
                         where scores.DiemCuoiKy < DiemCuoiKy
                         select scores;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("Course ID");
            dataTable.Columns.Add("Semester");
            dataTable.Columns.Add("Score 1");
            dataTable.Columns.Add("Score 2");
            dataTable.Columns.Add("Average");
            dataTable.Columns.Add("Passed", typeof(bool));

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaSV, tuple.MaMH, tuple.HocKy,
                    (tuple.DiemQuaTrinh == null ? 0 : tuple.DiemQuaTrinh), 
                    (tuple.DiemCuoiKy == null ? 0 : tuple.DiemCuoiKy),
                    tuple.DiemTrungBinh, tuple.TinhTrang);

            return dataTable;
        }

        public DataTable SearchByHigherScore2(float DiemCuoiKy)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from scores in dbEntities.Diems
                         where scores.DiemCuoiKy > DiemCuoiKy
                         select scores;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("Course ID");
            dataTable.Columns.Add("Semester");
            dataTable.Columns.Add("Score 1");
            dataTable.Columns.Add("Score 2");
            dataTable.Columns.Add("Average");
            dataTable.Columns.Add("Passed", typeof(bool));

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaSV, tuple.MaMH, tuple.HocKy, 
                    (tuple.DiemQuaTrinh == null ? 0 : tuple.DiemQuaTrinh), 
                    (tuple.DiemCuoiKy == null ? 0 : tuple.DiemCuoiKy),
                    tuple.DiemTrungBinh, tuple.TinhTrang);

            return dataTable;
        }
        #endregion
    }
}
