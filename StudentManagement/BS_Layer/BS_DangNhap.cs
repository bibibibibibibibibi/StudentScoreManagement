using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BS_Layer
{
    class BS_DangNhap
    {
        private QLDiemSV_Entities dbContext;

        public BS_DangNhap()
        {
            dbContext = new QLDiemSV_Entities();
        }

        public string AuthenticateUser( string username, string password)
        {
            var user = dbContext.Users
                .Where(u => u.Username == username && u.Password == password)
                .FirstOrDefault();

            if (user != null)
            {
                return user.Role;
            }
            else
            {
                return null;
            }
        }
    }
}
