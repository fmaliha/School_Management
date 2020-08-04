using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace InovexiaEBS
{
    public class BLStockIn
    {
        public static long insertPJV(BOStockIn grrbo)
        {
            DAStockIn daaddemp = new DAStockIn();
            return Convert.ToInt64(daaddemp.insertPJV(grrbo));
        }
    
    }
}