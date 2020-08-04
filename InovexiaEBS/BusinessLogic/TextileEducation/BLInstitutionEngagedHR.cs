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
    public class BLInstitutionEngagedHR
    {
        internal static DataTable GETInstitutionEngagedHR()
        {
            DAInstitutionEngagedHR accessLayer = new DAInstitutionEngagedHR();
            return accessLayer.GETInstitutionEngagedHR();
        }
        internal static DataTable GETInstitutionEngagedHRById(Hashtable ht)
        {
            DAInstitutionEngagedHR accessLayer = new DAInstitutionEngagedHR();
            return accessLayer.GETInstitutionEngagedHRById(ht);
        }
        internal static long InsertInstitutionEngagedHR(BOInstitutionEngagedHr model)
        {
            DAInstitutionEngagedHR accessLayer = new DAInstitutionEngagedHR();
            return Convert.ToInt64(accessLayer.InsertInstitutionEngagedHR(model));
        }

        internal static long UpdateInstitutionEngagedHR(BOInstitutionEngagedHr model)
        {
            DAInstitutionEngagedHR accessLayer = new DAInstitutionEngagedHR();
            return Convert.ToInt64(accessLayer.UpdateInstitutionEngagedHR(model));
        }

        internal static long DeleteInstitutionEngagedHR(BOInstitutionEngagedHr model)
        {
            DAInstitutionEngagedHR accessLayer = new DAInstitutionEngagedHR();
            return Convert.ToInt64(accessLayer.DeleteInstitutionEngagedHR(model));
        }

        
    }
}