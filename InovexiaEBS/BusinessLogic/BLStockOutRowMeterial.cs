using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace InovexiaEBS
{
    public class BLStockOutRowMeterial
    {
        public static DataTable GetRate(int doValue)
        {
            DAStockOutRowMeterial objDA = new DAStockOutRowMeterial();
            return objDA.GetRate(doValue);
        }

        internal static DataTable GetRateFromChemical(int doValue)
        {
            DAStockOutRowMeterial objDA = new DAStockOutRowMeterial();
            return objDA.GetRateFromChemical(doValue);
        }
    }
}