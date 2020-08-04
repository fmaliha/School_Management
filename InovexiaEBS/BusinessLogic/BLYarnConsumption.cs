using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace InovexiaEBS
{
    public class BLYarnConsumption
    {
        public static long insertYarnConsumption(BOYarnConsumption boclient)
        {

            var daaddemp = new DAYarnConsumption();
            return Convert.ToInt64(daaddemp.insertYarnConsumption(boclient));
        }
    }
}