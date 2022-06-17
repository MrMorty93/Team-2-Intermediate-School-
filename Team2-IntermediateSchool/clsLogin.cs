using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2_IntermediateSchool
{
    internal class clsLogin
    {

        public static void Login(string strUsername, string strPassword)
        {
            clsSQL.Login(strUsername, strPassword);

            if(clsSQL.strPosition == "Teacher")
            {
                frmTeacher teacher = new frmTeacher();
                teacher.Show();
            }
            if(clsSQL.strPosition == "Academic Officer")
            {
                frmOfficer officer = new frmOfficer();
                officer.Show();
            }
            if(clsSQL.strPosition == "Administrator")
            {
                frmAdmin admin = new frmAdmin();
                admin.Show();
            }
        }
    }
}
