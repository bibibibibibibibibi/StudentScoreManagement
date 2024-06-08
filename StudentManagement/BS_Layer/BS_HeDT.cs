using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.BS_Layer
{
    class BS_HeDT
    {
        public DataTable GetData()
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from system in dbEntities.HeDTs
                         select system;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("System ID");
            dataTable.Columns.Add("Name");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaHeDT, tuple.TenHeDT);

            return dataTable;
        }

        public bool AddData(string MaHeDT, string TenHeDT, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                HeDT heDT = new HeDT();
                heDT.MaHeDT = MaHeDT;
                heDT.TenHeDT = TenHeDT;

                dbEntities.HeDTs.Add(heDT);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool RemoveData(string MaHeDT, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                HeDT heDT = new HeDT();
                heDT.MaHeDT = MaHeDT;

                dbEntities.HeDTs.Attach(heDT);
                dbEntities.HeDTs.Remove(heDT);
                dbEntities.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                err = ex.InnerException.InnerException.Message;
                return false;
            }
        }

        public bool UpdateData(string MaHeDT, string TenHeDT, ref string err)
        {
            try
            {
                QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

                var tuple = (from system in dbEntities.HeDTs
                            where system.MaHeDT == MaHeDT
                            select system).SingleOrDefault();

                if (tuple != null)
                {
                    tuple.TenHeDT = TenHeDT;

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

        public void GetListOfEduSys(System.Windows.Forms.Control control)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from system in dbEntities.HeDTs
                        select system.MaHeDT;

            foreach (var tuple in tuples)
                (control as ComboBox).Items.Add(tuple);
        }

        #region Search functions
        public DataTable SearchBySystemID(string MaHeDT)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from system in dbEntities.HeDTs
                         where system.MaHeDT.Contains(MaHeDT)
                         select system;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("System ID");
            dataTable.Columns.Add("Name");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaHeDT, tuple.TenHeDT);

            return dataTable;
        }

        public DataTable SearchByName(string TenHeDT)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = from system in dbEntities.HeDTs
                         where system.TenHeDT.Contains(TenHeDT)
                         select system;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("System ID");
            dataTable.Columns.Add("Name");

            foreach (var tuple in tuples)
                dataTable.Rows.Add(tuple.MaHeDT, tuple.TenHeDT);

            return dataTable;
        }
        #endregion
    }
}
