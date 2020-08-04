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
    public class BLInstitutionPrograms
    {
        internal static long InsertInstitutionPrograms(BOInstitutionPrograms model)
        {
            DAInstitutionPrograms accessLayer = new DAInstitutionPrograms();
            return accessLayer.InsertInstitutionPrograms(model);
        }

        internal static long UpdateInstitutionPrograms(BOInstitutionPrograms model)
        {
            DAInstitutionPrograms accessLayer = new DAInstitutionPrograms();
            return Convert.ToInt64(accessLayer.UpdateInstitutionPrograms(model));
        }

        internal static long DeleteInstitutionPrograms(BOInstitutionPrograms model)
        {
            DAInstitutionPrograms accessLayer = new DAInstitutionPrograms();
            return Convert.ToInt64(accessLayer.DeleteInstitutionPrograms(model));
        }

        

        internal static DataTable GETInstitutionPrograms()
        {
            DAInstitutionPrograms accessLayer = new DAInstitutionPrograms();
            return accessLayer.GETInstitutionPrograms();
        }

        internal static DataTable GETInstitutionProgramsById(Hashtable ht)
        {
            DAInstitutionPrograms accessLayer = new DAInstitutionPrograms();
            return accessLayer.GETInstitutionProgramsById(ht);
        }
    }
}