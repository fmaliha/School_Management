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
    public class BLInstituteManagement
    {

        internal static long SaveInstitute(InstituteManagement _objInstituteManagement)
        {
            DAInstituteManagement _objDAInstituteManagement = new DAInstituteManagement();
            return Convert.ToInt64(_objDAInstituteManagement.SaveInstitute(_objInstituteManagement));
        }



        internal static DataTable GetInstitutionInfoById(Hashtable ht)
        {
            DAInstituteManagement accessLayer = new DAInstituteManagement();
            return accessLayer.GetInstitutionInfoById(ht);
        }

        internal static long DeleteInstitute(InstituteManagement _objInstituteManagement)
        {
            DAInstituteManagement _objDAInstituteManagement = new DAInstituteManagement();
            return Convert.ToInt64(_objDAInstituteManagement.DeleteInstitute(_objInstituteManagement));
        }

        internal static long UpdateInstitute(InstituteManagement _objInstituteManagement)
        {

            DAInstituteManagement _objDAInstituteManagement = new DAInstituteManagement();
            return Convert.ToInt64(_objDAInstituteManagement.UpdateInstitute(_objInstituteManagement));
        }

        internal static DataTable GetInstitutionList()
        {
            DAInstituteManagement accessLayer = new DAInstituteManagement();
            return accessLayer.GetInstitutionList();
        }

        internal static DataTable GetTypeWiseNumberOfInstitution()
        {
            DAInstituteManagement accessLayer = new DAInstituteManagement();
            return accessLayer.GetTypeWiseNumberOfInstitution();
        }



        internal static DataTable GetInstitutionListByTypeAndCate(int InstitutionType, int InstitutionCategory)
        {
            DAInstituteManagement accessLayer = new DAInstituteManagement();
            return accessLayer.GetInstitutionListByTypeAndCate(InstitutionType, InstitutionCategory);
        }
    }
}