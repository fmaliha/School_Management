using InovexiaEBS.BusinessEntity.Enterprise;
using PBSConnLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InovexiaEBS.DataAccess.Enterprise
{
    /// <summary>
    /// Shadhu Chowdhury
    /// </summary>
    public class DAEnterpriseEngagedHR
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        internal string InsertEnterpriseEngagedHR(BOEnterpriseEngagedHr model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("FullName", model.FullName);
                ht.Add("Address", model.Address);
                ht.Add("Gender", model.Gender);
                ht.Add("MobileNo", model.MobileNo);
                ht.Add("Designation", model.Designation);
                ht.Add("HighestEducationID", model.HighestEducationID);
                ht.Add("SpecializationID", model.SpecializationID);
                ht.Add("Email", model.Email);
                ht.Add("CountryID", model.CountryID);
                ht.Add("NationalID", model.NationalID);
                ht.Add("PassportNo", model.PassportNo);
                ht.Add("Website", model.Website);
                ht.Add("SocialSiteInfo", model.SocialSiteInfo);
                ht.Add("HrTypeID", model.HrTypeID);
                ht.Add("JobTypeID", model.JobTypeID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC); 
               
                return idbutility.GetDataByProc(ht, "sp_InsertEnterpriseEngagedHR").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise Enganged HR saved failed: " + ex.Message.ToString();
            }
        }

        internal string UpdateEnterpriseEngagedHR(BOEnterpriseEngagedHr model)
        {
            try
            {

                Hashtable ht = new Hashtable();

                ht.Add("EnterpriseHrID", model.EngagedHrID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("FullName", model.FullName);
                ht.Add("Address", model.Address);
                ht.Add("Gender", model.Gender);
                ht.Add("MobileNo", model.MobileNo);
                ht.Add("Designation", model.Designation);
                ht.Add("HighestEducationID", model.HighestEducationID);
                ht.Add("SpecializationID", model.SpecializationID);
                ht.Add("Email", model.Email);
                ht.Add("CountryID", model.CountryID);
                ht.Add("NationalID", model.NationalID);
                ht.Add("PassportNo", model.PassportNo);
                ht.Add("Website", model.Website);
                ht.Add("SocialSiteInfo", model.SocialSiteInfo);
                ht.Add("HrTypeID", model.HrTypeID);
                ht.Add("JobTypeID", model.JobTypeID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC); 
                return idbutility.GetDataByProc(ht, "sp_UpdateEnterpriseEngagedHR").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise Enganged HR update failed: " + ex.Message.ToString();
            }

        }

        internal string DeleteEnterpriseEngagedHR(BOEnterpriseEngagedHr model)
        {
            try
            {

                Hashtable ht = new Hashtable();

                ht.Add("EnterpriseHrID", model.EngagedHrID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                return idbutility.GetDataByProc(ht, "sp_DeleteEnterpriseEngagedHR").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise Enganged HR update failed: " + ex.Message.ToString();
            }

        }



        internal DataTable GETEnterpriseEngagedHRById(int Id)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseHrID", Id);

                DataTable dataTable = idbutility.GetDataByProc(ht, "sp_GetEnterpriseEngagedHrById");
                return dataTable;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        internal DataTable GETEnterpriseEngagedHRListByCategoryId(int CategoryId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("CategoryId", CategoryId);

                DataTable dataTable = idbutility.GetDataByProc(ht, "sp_GetEnterpriseEngagedHrListByCategoryId");
                return dataTable;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}