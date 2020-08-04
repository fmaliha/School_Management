using InovexiaEBS.BusinessEntity.TextileEducation;
using PBSConnLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InovexiaEBS.DataAccess.TextileEducation
{
    public class DAInstituteManagement
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        internal long SaveInstitute(InstituteManagement _objInstituteManagement)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("InstitutionCode", _objInstituteManagement.InstitutionCode);
                ht.Add("InstitutionType", _objInstituteManagement.InstitutionType);
                ht.Add("InstitutionCategory", _objInstituteManagement.InstitutionCategory);
                ht.Add("InstitutionName", _objInstituteManagement.InstitutionName);
                ht.Add("Logo", _objInstituteManagement.Logo);
                ht.Add("Longitute", _objInstituteManagement.Longitute);
                ht.Add("Latitude", _objInstituteManagement.Latitude);
                ht.Add("DivisionID", _objInstituteManagement.DivisionID);
                ht.Add("DistrictID", _objInstituteManagement.DistrictID);
                ht.Add("ThanaID", _objInstituteManagement.ThanaID);
                ht.Add("Address", _objInstituteManagement.Address);
                ht.Add("Telephone", _objInstituteManagement.Telephone);
                ht.Add("Fax", _objInstituteManagement.Fax);
                ht.Add("Email", _objInstituteManagement.Email);
                ht.Add("Website", _objInstituteManagement.Website);
                ht.Add("SocialSiteInfo", _objInstituteManagement.SocialSiteInfo);
                ht.Add("EstablishedYear", _objInstituteManagement.EstablishedYear);
                ht.Add("Remarks", _objInstituteManagement.Remarks);
                ht.Add("CreatedBy", _objInstituteManagement.CreatedBy);
                ht.Add("TotalArea", _objInstituteManagement.TotalArea);
                ht.Add("NoOfAcademicBuilding", _objInstituteManagement.NoOfAcademicBuilding);
                ht.Add("NoOfLab", _objInstituteManagement.NoOfLab);

                ht.Add("TotalInvestment", _objInstituteManagement.TotalInvestment);
                ht.Add("InitialInvestment", _objInstituteManagement.InitialInvestment);
             
                 ht.Add("CreatedPC", _objInstituteManagement.CreatedPC);

                
                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertInstituteManagement"));


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal DataTable GetInstitutionInfoById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = idbutility.GetDataByProc(ht, "sp_GetInstitutionInfoById");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteInstitute(InstituteManagement _objInstituteManagement)
        {
            Hashtable ht = new Hashtable();
            ht.Add("InstitutionID", _objInstituteManagement.InstitutionID);
            ht.Add("DeletedBy", _objInstituteManagement.DeletedBy);
            ht.Add("DeletedPC", _objInstituteManagement.DeletedPC);
            return Convert.ToInt64(idbutility.InsertData(ht, "sp_DeleteInstitution"));
        }

        internal long UpdateInstitute(InstituteManagement _objInstituteManagement)
        {
            Hashtable ht = new Hashtable();
            ht.Add("InstitutionID", _objInstituteManagement.InstitutionID);
            ht.Add("InstitutionCode", _objInstituteManagement.InstitutionCode);
            ht.Add("InstitutionType", _objInstituteManagement.InstitutionType);
            ht.Add("InstitutionCategory", _objInstituteManagement.InstitutionCategory);
            ht.Add("InstitutionName", _objInstituteManagement.InstitutionName);
            ht.Add("Logo", _objInstituteManagement.Logo);
            ht.Add("Longitute", _objInstituteManagement.Longitute);
            ht.Add("Latitude", _objInstituteManagement.Latitude);
            ht.Add("DivisionID", _objInstituteManagement.DivisionID);
            ht.Add("DistrictID", _objInstituteManagement.DistrictID);
            ht.Add("ThanaID", _objInstituteManagement.ThanaID);
            ht.Add("Address", _objInstituteManagement.Address);
            ht.Add("Telephone", _objInstituteManagement.Telephone);
            ht.Add("Fax", _objInstituteManagement.Fax);
            ht.Add("Email", _objInstituteManagement.Email);
            ht.Add("Website", _objInstituteManagement.Website);
            ht.Add("SocialSiteInfo", _objInstituteManagement.SocialSiteInfo);
            ht.Add("EstablishedYear", _objInstituteManagement.EstablishedYear);
            ht.Add("Remarks", _objInstituteManagement.Remarks);
            ht.Add("CreatedBy", _objInstituteManagement.CreatedBy);
            ht.Add("TotalArea", _objInstituteManagement.TotalArea);
            ht.Add("NoOfAcademicBuilding", _objInstituteManagement.NoOfAcademicBuilding);
            ht.Add("NoOfLab", _objInstituteManagement.NoOfLab);

            ht.Add("TotalInvestment", _objInstituteManagement.TotalInvestment);
            ht.Add("InitialInvestment", _objInstituteManagement.InitialInvestment);
           
            ht.Add("CreatedPC", _objInstituteManagement.CreatedPC);

            return Convert.ToInt64(idbutility.InsertData(ht, "sp_UpdateInstituteManagement"));
        }

        internal DataTable GetInstitutionList()
        {
            DataTable dataTable = idbutility.GetDataByProc("sp_getInstituteManagementDetails");
            return dataTable;
        }

        internal DataTable GetTypeWiseNumberOfInstitution()
        {
            DataTable dataTable = idbutility.GetDataByProc("sp_TypeWiseNumberOfInstitution");
            return dataTable;
        }

        internal DataTable GetInstitutionListByTypeAndCate(int InstitutionType, int InstitutionCategory)
        {
            Hashtable ht = new Hashtable();
            ht.Add("TypeId", InstitutionType);
            ht.Add("Category", InstitutionCategory);
            DataTable dataTable = idbutility.GetDataByProc(ht, "sp_getInstituteDetailsByTypeAndCate");
            return dataTable;
        }
    }
}