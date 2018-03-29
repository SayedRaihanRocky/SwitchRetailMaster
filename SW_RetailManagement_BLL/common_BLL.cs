using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SW_RetailManagement_DAL;
using System.Data;

namespace SW_RetailManagement_BLL
{
   public class common_BLL
    {
       CommonFunction commonfunction_DAL = new CommonFunction();

       public DataTable fill_store()
       {
           DataTable dt = new DataTable();

           dt=commonfunction_DAL.FillStore();

           return dt;
       }

       //end code line
    }
}
