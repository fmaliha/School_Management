using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace InovexiaEBS
{
    public class BLDealerAccounts
    {
        public static long InsertDealerAccounts(BODealerAccounts boItem)
        {

            DADealerAccounts objDA = new DADealerAccounts();
            return Convert.ToInt64(objDA.InsertDealerAccounts(boItem));
        }
    }
}