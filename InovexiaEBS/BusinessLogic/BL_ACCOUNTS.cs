using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


    public class BL_ACCOUNTS
    {

        public BL_ACCOUNTS()
        { 
        
        }

        public static long InsertChequeBL(BO_ACCOUNTS  grrbo)
        {
            DA_ACCOUNTS daaddemp = new DA_ACCOUNTS();
            return Convert.ToInt64(daaddemp.InsertCheque_DA(grrbo));
        }
    }
