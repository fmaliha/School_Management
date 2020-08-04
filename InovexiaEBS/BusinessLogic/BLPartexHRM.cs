using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace InovexiaEBS
{
    public class BLHRM
    {
        public static long InsertPartex_HRM_Dept(BOPartexHRM boItem)
        {
            DAPartexHRM DAobj = new DAPartexHRM();
            return Convert.ToInt64(DAobj.InsertPartex_HRM_Dept(boItem));
        }

        public static long InsertPartex_HRM_EmployeeMaster(BOPartexHRM boItem)
        {

            DAPartexHRM DAobj = new DAPartexHRM();
            return Convert.ToInt64(DAobj.InsertPartex_HRM_EmployeeMaster(boItem));
        }

        public static long InsertPartex_HRM_Desig(BOPartexHRM boItem)
        {

            DAPartexHRM DAobj = new DAPartexHRM();
            return Convert.ToInt64(DAobj.InsertPartex_HRM_Desig(boItem));
        }
        public static long InsertPartex_HRM_JD(BOPartexHRM boItem)
        {

            DAPartexHRM DAobj = new DAPartexHRM();
            return Convert.ToInt64(DAobj.InsertPartex_HRM_JD(boItem));
        }
    }
}