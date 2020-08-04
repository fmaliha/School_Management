using InovexiaEBS.BusinessEntity.TextileEducation;
using InovexiaEBS.DataAccess.TextileEducation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessLogic.TextileEducation
{
    public class BLInstitutionRequiredHr
    {
        internal static long InsertInstitutionRequiredHr(BOInstitutionRequiredHr model)
        {
            DAInstitutionRequiredHr accessLayer = new DAInstitutionRequiredHr();
            return accessLayer.InsertInstitutionRequiredHr(model);
        }

        internal static long UpdateInstitutionRequiredHr(BOInstitutionRequiredHr model)
        {
            DAInstitutionRequiredHr accessLayer = new DAInstitutionRequiredHr();
            return Convert.ToInt64(accessLayer.UpdateInstitutionRequiredHr(model));
        }

        internal static long DeleteInstitutionRequiredHr(BOInstitutionRequiredHr model)
        {
            DAInstitutionRequiredHr accessLayer = new DAInstitutionRequiredHr();
            return Convert.ToInt64(accessLayer.DeleteInstitutionRequiredHr(model));
        }


        internal static DataTable GETInstitutionRequiredHr()
        {
            DAInstitutionRequiredHr accessLayer = new DAInstitutionRequiredHr();
            return accessLayer.GETInstitutionRequiredHr();
        }

        internal static DataTable GETInstitutionRequiredHrById(Hashtable ht)
        {
            DAInstitutionRequiredHr accessLayer = new DAInstitutionRequiredHr();
            return accessLayer.GETInstitutionRequiredHrById(ht);
        }
    }
}