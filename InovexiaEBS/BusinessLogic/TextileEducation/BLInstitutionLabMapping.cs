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
    public class BLInstitutionLabMapping
    {

        internal static DataTable GETInstitutionLabMapping()
        {
            DAInstitutionLabMapping accessLayer = new DAInstitutionLabMapping();
            return accessLayer.GETInstitutionLabMapping();
        }
        internal static DataTable GETInstitutionLabMappingById(Hashtable ht)
        {
            DAInstitutionLabMapping accessLayer = new DAInstitutionLabMapping();
            return accessLayer.GETInstitutionLabMappingById(ht);
        }
        internal static long InsertInstitutionLabMapping(BOInstitutionLabMapping model)
        {
            DAInstitutionLabMapping accessLayer = new DAInstitutionLabMapping();
            return Convert.ToInt64(accessLayer.InsertInstitutionLabMapping(model));
        }

        internal static long UpdateInstitutionLabMapping(BOInstitutionLabMapping model)
        {
            DAInstitutionLabMapping accessLayer = new DAInstitutionLabMapping();
            return Convert.ToInt64(accessLayer.UpdateInstitutionLabMapping(model));
        }





        internal static long DeleteInstitutionLabMapping(BOInstitutionLabMapping model)
        {
            DAInstitutionLabMapping accessLayer = new DAInstitutionLabMapping();
            return Convert.ToInt64(accessLayer.DeleteInstitutionLabMapping(model));
        }
    }
}