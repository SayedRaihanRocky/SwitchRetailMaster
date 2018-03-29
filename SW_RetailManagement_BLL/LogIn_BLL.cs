using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SW_RetailManagement_DAL;

namespace SW_RetailManagement_BLL
{
    public class LogIn_BLL
    {
        LogIn_DAL login_DAL = new LogIn_DAL();

        public bool Valid_Login(string UsrName,string UsrPass,string StoreId)
        {
            bool isval = false;

            isval = login_DAL.Valid_login(UsrName,UsrPass,StoreId);

            return isval;
        }
    }
}
