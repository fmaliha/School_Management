using InovexiaEBS.BusinessEntity.PBML.Settings;
using InovexiaEBS.DataAccess.Settings;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessLogic.Settings
{
    public class BLUser
    {
        internal static long InsertUser(User _objUser)
        {

            DAUser objDA = new DAUser();
            return Convert.ToInt64(objDA.InsertUser(_objUser));
        }


         
    }
}