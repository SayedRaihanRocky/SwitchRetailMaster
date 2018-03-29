using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_RetailManagement_DAL
{
    public class LogIn_DAL
    {
        string sqltext = "";

        public bool Valid_login(string UsrName,string UsrPass,string StoreId)
        {
            
            dbconnection.Connection conn = new dbconnection.Connection();
            SqlConnection connection = new SqlConnection(conn.SetConnection());

            try
            {
                if(UsrName=="admin")
                {

                    sqltext="SELECT UserName,Password FROM UserLogIn WHERE UserName='" + UsrName + "' AND Password='" + UsrPass + "'";
                }
                else
                {
                    sqltext="SELECT UserName,Password FROM UserLogIn WHERE UserName='" + UsrName + "' AND Password='" + UsrPass + "' AND BranchID='" + StoreId + "'";
                }

                connection.Open();

                SqlCommand myCommand1 = new SqlCommand(sqltext, connection);

                object retVal = myCommand1.ExecuteScalar();

                if (retVal != null)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return false;

        }

        // end code line
    }
}
