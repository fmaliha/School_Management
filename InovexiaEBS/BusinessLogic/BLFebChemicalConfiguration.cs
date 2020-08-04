using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace InovexiaEBS
{
    public class BLFebChemicalConfiguration
    {
        public static long insertChemicalConfiguration(BOFebChemicalConfiguration boclient)
        {
            var daaddemp = new DAFebChemicalConfiguration();
            return Convert.ToInt64(daaddemp.insertChemicalConfiguration(boclient));
        }
    }
}