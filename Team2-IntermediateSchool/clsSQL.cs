using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Team2_IntermediateSchool
{
    internal class clsSQL
    {
        const string strSchema = "group2su222330.";
        const string strConnectionString = "Server=cstnt.tstc.edu; Database=inew2330su22; User Id=group2su222330; Password=2856454";

        private static SqlConnection _cntDatabase = new SqlConnection(strConnectionString);

        public static void OpenDatabase()
        {
            _cntDatabase.Open();
        }

        public static void CloseDatabase()
        {
            _cntDatabase.Close();
        }
    }
}
