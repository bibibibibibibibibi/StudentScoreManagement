using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace StudentManagement.BS_Layer
{
    class BS_Home
    {
        public int GetStudentCount()
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = (from student in dbEntities.SinhViens
                         select student).Count();

            return tuples;
        }

        public int GetStudentCount(bool GioiTinh)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = (from student in dbEntities.SinhViens
                         where student.GioiTinh == GioiTinh
                         select student).Count();

            return tuples;
        }

        public int GetStudentCount(bool GioiTinh, string MaLop)
        {
            QLDiemSV_Entities dbEntities = new QLDiemSV_Entities();

            var tuples = (from student in dbEntities.SinhViens
                         where student.GioiTinh == GioiTinh
                         where student.MaLop == MaLop
                         select student).Count();

            return tuples;
        }
    }
}
