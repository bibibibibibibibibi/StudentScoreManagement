using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BS_Layer
{
    class BS_AcaCourse
    {
        public DataTable GetData()
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from acacourses in dbEntities.LopHocPhans
                         select acacourses;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Academic Course ID");
            dataTable.Columns.Add("Subject ID");
            dataTable.Columns.Add("Year ID");
            dataTable.Columns.Add("Year");
            dataTable.Columns.Add("Lecturer ID");
            dataTable.Columns.Add("No students");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaLHP, tuple.MaMH, tuple.MaKhoaHoc,
                    tuple.NamHoc, tuple.MaGV, tuple.SiSoSV);

            return dataTable;
        }
        public bool AddData(string MaLHP, string MaMH, string MaKhoaHoc,
                    int NamHoc, int MaGV, int SiSoSV, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                LopHocPhan lhp = new LopHocPhan();
                lhp.MaLHP = MaLHP;
                lhp.MaMH = MaMH;
                lhp.MaKhoaHoc = MaKhoaHoc;
                lhp.NamHoc = NamHoc;
                lhp.MaGV = MaGV;
                lhp.SiSoSV = SiSoSV;

                dbEntities.LopHocPhans.Add(lhp);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool RemoveData(string MaLHP, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                LopHocPhan lhp = new LopHocPhan();
                lhp.MaLHP = MaLHP;

                dbEntities.LopHocPhans.Attach(lhp);
                dbEntities.LopHocPhans.Remove(lhp);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool UpdateData(string MaLHP, string MaMH, string MaKhoaHoc,
                    int NamHoc, int MaGV, int SiSoSV, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                var tuple = (from acacourses in dbEntities.LopHocPhans
                             where acacourses.MaLHP == MaLHP
                             select acacourses).SingleOrDefault();

                if (tuple != null)
                {
                    tuple.MaMH = MaMH;
                    tuple.MaKhoaHoc = MaKhoaHoc;
                    tuple.NamHoc = NamHoc;
                    tuple.MaGV = MaGV;
                    tuple.SiSoSV = SiSoSV;

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
        public DataTable SearchByAcaCourseID(string MaLHP)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from acacourses in dbEntities.LopHocPhans
                         where acacourses.MaLHP.Contains(MaLHP)
                         select acacourses;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Academic Course ID");
            dataTable.Columns.Add("Subject ID");
            dataTable.Columns.Add("Year ID");
            dataTable.Columns.Add("Year");
            dataTable.Columns.Add("Lecturer ID");
            dataTable.Columns.Add("No students");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaLHP, tuple.MaMH, tuple.MaKhoaHoc,
                    tuple.NamHoc, tuple.MaGV, tuple.SiSoSV);

            return dataTable;
        }

        public DataTable SearchBySubjectID(string MaMH)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from acacourses in dbEntities.LopHocPhans
                         where acacourses.MaMH.Contains(MaMH)
                         select acacourses;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Academic Course ID");
            dataTable.Columns.Add("Subject ID");
            dataTable.Columns.Add("Year ID");
            dataTable.Columns.Add("Year");
            dataTable.Columns.Add("Lecturer ID");
            dataTable.Columns.Add("No students");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaLHP, tuple.MaMH, tuple.MaKhoaHoc,
                    tuple.NamHoc, tuple.MaGV, tuple.SiSoSV);

            return dataTable;
        }

        public DataTable SearchByYearID(int NamHoc)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from acacourses in dbEntities.LopHocPhans
                         where acacourses.NamHoc.ToString().Contains(NamHoc.ToString())
                         select acacourses;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Academic Course ID");
            dataTable.Columns.Add("Subject ID");
            dataTable.Columns.Add("Year ID");
            dataTable.Columns.Add("Year");
            dataTable.Columns.Add("Lecturer ID");
            dataTable.Columns.Add("No students");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaLHP, tuple.MaMH, tuple.MaKhoaHoc,
                    tuple.NamHoc, tuple.MaGV, tuple.SiSoSV);

            return dataTable;
        }

        public DataTable SearchBySchoolyear(string MaKhoaHoc)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from acacourses in dbEntities.LopHocPhans
                         where acacourses.MaKhoaHoc.Contains(MaKhoaHoc)
                         select acacourses;


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Academic Course ID");
            dataTable.Columns.Add("Subject ID");
            dataTable.Columns.Add("Year ID");
            dataTable.Columns.Add("Year");
            dataTable.Columns.Add("Lecturer ID");
            dataTable.Columns.Add("No students");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaLHP, tuple.MaMH, tuple.MaKhoaHoc,
                    tuple.NamHoc, tuple.MaGV, tuple.SiSoSV);

            return dataTable;
        }
        #endregion
    }
}