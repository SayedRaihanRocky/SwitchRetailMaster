using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SW_RetailManagement_DAL
{
    public class dbconnection
    {
        public class Connection
        {
            public string DataSource, DatabaseUser, DatabasePassword, DatabaseName;

            public string SetConnection()
            {
                CommonFunction.encode_decode decode = new CommonFunction.encode_decode();

                string login_text, db_pass = "";

                string path;


                //path = System.Windows.Forms.Application.StartupPath;

                path = GetCurrentAssemblyPath();

                if (File.Exists(@"" + path + "\\logIndb.dll"))
                {

                    login_text = ReadFromFile(@"" + path + "\\logIndb.dll");

                    string[] arrLines = login_text.Split(new char[] { '\n' });

                    DataSource = arrLines[0].Substring(0, arrLines[0].Length - 1);

                    DatabaseName = arrLines[1].Substring(0, arrLines[1].Length - 1);

                    DatabaseUser = arrLines[2].Substring(0, arrLines[2].Length - 1);

                    db_pass = arrLines[3].Substring(0, arrLines[3].Length - 1);

                    DatabasePassword = decode.Decode(db_pass);


                }

                //string connectionstring = "Data Source=.; Database=DB_PriceTag; Integrated Security=True";

                // string connectionstring = "Data Source=" + DataSource + "; Database=" + DatabaseName + "; Network Library=DBMSSOCN; User ID=" + DatabaseUser + ";Password=" + DatabasePassword + "; Connect Timeout=280";

                // string connectionstring = "Data Source=" + DataSource + "; Database=" + DatabaseName + "; User ID=" + DatabaseUser + ";Password=" + DatabasePassword + "";

                string connectionstring = "Data Source=" + DataSource + "; Database=" + DatabaseName + "; Integrated Security=True";

                ////For My Sql
                ////===========================================================================================
                //string connectionstring = "server=localhost;User Id=root;Password=123;database=mypos";
                ////string connectionstring = "server=50.22.145.67;User Id=dablsoft_prtest; Password=C4pY5KdO8PyT; database=dablsoft_school;Port=3306";
                ////==========================================================================================


                return connectionstring;

            }

            public string GetCurrentAssemblyPath()
            {
                string dllFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string directoryPath = System.IO.Path.GetDirectoryName(dllFilePath);
                return directoryPath;
            }

            private string ReadFromFile(string Filepath)
            {
                string text, mytext;
                using (System.IO.StreamReader sw = new StreamReader(Filepath)) // FILE is the full path to the file - C:\\test.txt for example
                {
                    //text = Convert.ToString(sw.ReadLine().ElementAt(element_no));

                    text = Convert.ToString(sw.ReadToEnd());

                    //MessageBox.Show(""+ text +"");

                    //mytext = text[element_no];

                    sw.Close();

                    return text;
                }
            }
        }
    }
}
