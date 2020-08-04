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
    public class BLInstitutionMachinerie
    {
        internal static long InsertInstitutionMachinerie(BOInstitutionMachinerie model)
        {
            DAInstitutionMachinerie accessLayer = new DAInstitutionMachinerie();
            return accessLayer.InsertInstitutionMachinerie(model);
        }

        internal static long UpdateInstitutionMachinerie(BOInstitutionMachinerie model)
        {
            DAInstitutionMachinerie accessLayer = new DAInstitutionMachinerie();
            return Convert.ToInt64(accessLayer.UpdateInstitutionMachinerie(model));
        }

        internal static DataTable GETInstitutionMachinerie()
        {
            DAInstitutionMachinerie accessLayer = new DAInstitutionMachinerie();
            return accessLayer.GETInstitutionMachinerie();
        }

        internal static DataTable GETInstitutionMachinerieById(Hashtable ht)
        {
            DAInstitutionMachinerie accessLayer = new DAInstitutionMachinerie();
            return accessLayer.GETInstitutionMachinerieById(ht);
        }

        internal static long DeleteInstitutionMachineries(BOInstitutionMachinerie model)
        {

            DAInstitutionMachinerie accessLayer = new DAInstitutionMachinerie();
            return Convert.ToInt64(accessLayer.DeleteInstitutionMachineries(model));
        }
    }
}