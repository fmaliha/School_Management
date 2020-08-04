using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBSConnLib;


    public class DAPasswordChange
    {
        PBSDBUtility AppDbU = new PBSDBUtility();
        public long PasswdChange(string Pin, string LogInID, string Passwd, string oldPass)
        {



            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("Pin", Pin);
                ht.Add("LogInID", LogInID);
                ht.Add("Passwd", Passwd);
                ht.Add("OldPass", oldPass);

                return Convert.ToInt64(AppDbU.InsertData(ht, "PasswdChange"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
