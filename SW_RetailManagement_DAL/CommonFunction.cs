using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SW_RetailManagement_DAL
{
   public class CommonFunction
    {
        ///////////////////////////////////////////

        public static string GetEncryptedString(string value)
        {
            byte[] byteValue = Encoding.UTF8.GetBytes(value);
            string EncryptedString = Convert.ToBase64String(byteValue);
            return EncryptedString;
        }

        public static string GetDecryptedString(string encryptedString)
        {
            byte[] byteValue = Convert.FromBase64String(encryptedString);
            string value = Encoding.UTF8.GetString(byteValue);

            return value;
        }

        public static string Find_IP()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }

            return localIP;

        }

        public class encode_decode
        {
            /// <summary>
            /// This method creates a Base64 encoded string from an input
            /// parameter string.
            /// </summary>
            /// <param name="m_enc">The String containing the characters
            /// to be encoded.</param>
            /// <returns>The Base64 encoded string.</returns>
            public string Encode(string Text)
            {
                byte[] toEncodeAsBytes =
                System.Text.Encoding.UTF8.GetBytes(Text);
                string returnValue =
                System.Convert.ToBase64String(toEncodeAsBytes);
                return returnValue;


            }

            /// <summary>
            /// This method will Decode a Base64 string.
            /// </summary>
            /// <param name="m_enc">The String containing the characters
            /// to be decoded.</param>
            /// <returns>A String containing the results of decoding the
            /// specified sequence of bytes.</returns>
            public string Decode(string text)
            {
                text = text.Replace(" ", "+");
                byte[] encodedDataAsBytes = System.Convert.FromBase64String(text);

                string returnValue = Encoding.UTF8.GetString(encodedDataAsBytes);

                return returnValue;

                ////////////////////////////////


            }

        }

       // Load store in combo
        public DataTable FillStore()
        {
            dbconnection.Connection con = new dbconnection.Connection();
            SqlConnection connection = new SqlConnection(con.SetConnection());

            DataTable dt = new DataTable();

            try
            {
   
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT ID,Name From InfoRetailer Where Activity='Active'", connection);

                da.Fill(dt);


                DataRow row = dt.NewRow();
                row["Name"] = "--Please select store--";
                row["ID"] = 0;
                dt.Rows.InsertAt(row, 0);

            }
            catch (Exception ex)
            {
                return dt;
            }
            finally
            {
                connection.Close();

                
            }

            return dt;
        }
        
       // end code line
    }


}
