using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_RetailManagement_BO.Setup
{
   public class PrimarySetup_BO
    {
       public string ID { get; set; }
       public string Name { get; set; }
       public string RefID { get; set; }
       public string Address { get; set; }
       public string Type { get; set; }
       
        public string Activity { get; set; }
        public string IUser { get; set; }
        public string EUser { get; set; }
        public DateTime? IDate { get; set; }
        public DateTime? EDate { get; set; }

       public PrimarySetup_BO()
		{ }

       public PrimarySetup_BO(string ID, string Name, string RefID, string Address, string Type, string Activity, string IUser, string EUser, Nullable<DateTime> IDate, Nullable<DateTime> EDate)
		{
            this.ID = ID;
            this.Name = Name;
            this.RefID = RefID;     
            this.Address = Address;
            this.Type = Type;
            this.Activity = Activity;
			this.IUser = IUser;
			this.EUser = EUser;
			this.IDate = IDate;
			this.EDate = EDate;
		}

		public override string ToString()
		{
            return "ID = " + ID.ToString() + ",Name = " + Name + ",RefID= " + RefID + ",Address= " + Address + ",Type= " + Type + ",Activity = " + Activity + ",IUser = " + IUser + ",EUser = " + EUser + ",IDate = " + IDate.ToString() + ",EDate = " + EDate.ToString();
		}
    }
}
