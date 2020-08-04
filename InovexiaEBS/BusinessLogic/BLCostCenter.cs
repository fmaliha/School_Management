using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace InovexiaEBS
{
    public class BLCostCenter
    {
        public BLCostCenter()
	    {
		//
		// TODO: Add constructor logic here
		//
	    }

        public static long insertCostCenter(BOCostCenter boCostCenter)
        {
            DACostCenter objDA = new DACostCenter();
            return Convert.ToInt64(objDA.InsertCostCenter(boCostCenter));
        }

        public static System.Data.DataTable GetUserCompany(string loginID)
        {
            DACostCenter objDA = new DACostCenter();
            return objDA.GetUserCompany(loginID);
        }
    }
}