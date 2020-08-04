using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace InovexiaEBS
{
    public class BLFebChemicalConsumption
    {
        public static long insertChemicalConsumption(BOFebChemicalConsumption boclient)
        {
            var daaddemp = new DAFebChemicalConsumption();
            return Convert.ToInt64(daaddemp.insertChemicalConsumption(boclient));
        }
    }
}