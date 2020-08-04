using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



    public class BLPasswordChange
    {
        public static long PasswdChange(string Pin, string LogInID, string Passwd, string oldPass)
        {
            DAPasswordChange objDA = new DAPasswordChange();
            return Convert.ToInt64(objDA.PasswdChange(Pin, LogInID, Passwd, oldPass));
        }
    }
