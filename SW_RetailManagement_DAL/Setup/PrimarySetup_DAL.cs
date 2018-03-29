using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SW_RetailManagement_DAL.Setup
{
    public class PrimarySetup_DAL
    {
        
        public bool save()
        {
            return true;
        }

        public bool update()
        {
            return true;
        }

        public DataTable GridLoad()
        {

            dbconnection.Connection conn = new dbconnection.Connection();
            SqlConnection connection = new SqlConnection(conn.SetConnection());

            DataTable dt = new DataTable();

            try
            {

                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select ID,Name as 'Payment Type',Status FROM Tbl_Setup Where Type='payment_type'", connection);
                da.Fill(dt);

                
            }
            catch
            {
            }

            return dt;
        }
    }
}
