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
    public class DAInstitutionEngagedHR
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        public long InsertInstitutionEngagedHR(BOInstitutionEngagedHr model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("InstitutionID", model.InstitutionID);
                ht.Add("FullName", model.FullName);
                ht.Add("Address", model.Address);
                ht.Add("Gender", model.Gender);
                ht.Add("MobileNo", model.MobileNo);
                ht.Add("DesignationID", model.DesignationID);
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
               
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertInstitutionEngagedHr"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        public long UpdateInstitutionEngagedHR(BOInstitutionEngagedHr model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EngagedHrID", model.EngagedHrID);
                ht.Add("InstitutionID", model.InstitutionID);
                ht.Add("FullName", model.FullName);
                ht.Add("Address", model.Address);
                ht.Add("Gender", model.Gender);
                ht.Add("MobileNo", model.MobileNo);
                ht.Add("DesignationID", model.DesignationID);
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

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateInstitutionEngagedHr"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public long DeleteInstitutionEngagedHR(BOInstitutionEngagedHr model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EngagedHrID", model.EngagedHrID);             
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeleteInstitutionEngagedHr"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public DataTable GETInstitutionEngagedHR()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_GetInstitutionEngagedHr");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public DataTable GETInstitutionEngagedHRById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetInstitutionEngagedHrById");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
