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
        const string SCHEMA = "group2su222330.";
        const string CONNECTION_STRING = "Server=cstnt.tstc.edu; Database=inew2330su22; User Id=group2su222330; Password=2856454";

        private static SqlConnection _cntDatabase = new SqlConnection(CONNECTION_STRING);
        public static string strPosition = "";

        public static void OpenDatabase()
        {
            try
            {
                if (_cntDatabase != null && _cntDatabase.State == ConnectionState.Closed)
                {
                    _cntDatabase.Open();
                }
                else if (_cntDatabase.State == ConnectionState.Open)
                {
                    _cntDatabase.Close();
                    _cntDatabase.Open();
                }

            }
            catch
            {
                MessageBox.Show("Unexpected Error", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        public static void CloseDatabase()
        {
        try
        {
            if (_cntDatabase.State == ConnectionState.Open)
            {
                _cntDatabase.Close();
            }
        }
        catch
        {
            MessageBox.Show("Unexpected Error", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

        public static bool Login(string strUsername, string strPassword)
        {
            bool bolLogin = false;
            try
            {

                string strLoginCommand = "SELECT Username, Password, Role FROM " + SCHEMA + "Staff WHERE Username = '" + strUsername + "' " +
                "AND Password = '" + strPassword + "';";
                SqlCommand _cmdLoginCommand = new SqlCommand(strLoginCommand, _cntDatabase);
                SqlDataAdapter _daLogin = new SqlDataAdapter();
                DataTable _dsLogin = new DataTable();
                _daLogin.SelectCommand = _cmdLoginCommand;
                _daLogin.Fill(_dsLogin);



                if (_dsLogin.Rows.Count > 0)
                {
                    bolLogin = true;
                }
                else
                {
                    MessageBox.Show("The username/password is incorrect", "Login Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                strPosition = _dsLogin.Rows[0]["PositionTitle"].ToString();

                if (bolLogin)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                MessageBox.Show("Unexpected error. Please try again.", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




        }
    }
}
