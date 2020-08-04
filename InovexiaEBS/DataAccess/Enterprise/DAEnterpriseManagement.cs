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
    public class DAEnterpriseManagement
    {
        PBSDBUtility idbutility = new PBSDBUtility();

        internal string SaveEnterprise(BOEnterpriseManagement model)
        {
            try
            {
                Hashtable ht = new Hashtable();
                
                ht.Add("EnterpriseCode", model.EnterpriseCode);
                ht.Add("EnterpriseName", model.EnterpriseName);
                ht.Add("ContactNo", model.ContactNo);
                ht.Add("Email", model.Email);
                ht.Add("LicenseNo", model.LicenseNo);
                ht.Add("OwnersInfo", model.OwnersInfo);
                ht.Add("OwnersContact", model.OwnersContact);
                ht.Add("Website", model.Website);
                ht.Add("SocialLink", model.SocialLink);
                ht.Add("TotalArea", model.TotalArea);
                ht.Add("TotalInvestment", model.TotalInvestment);
                ht.Add("InitialInvestment", model.InitialInvestment);
                ht.Add("TotalNoOfBuilding", model.TotalNoOfBuilding);
                ht.Add("EnterpriseTypeID", model.EnterpriseTypeID);
                ht.Add("Logo", model.Logo);
                ht.Add("Longitude", model.Longitude);
                ht.Add("Latitude", model.Latitude);
                ht.Add("DivisionID", model.DivisionID);
                ht.Add("DistrictID", model.DistrictID);
                ht.Add("ThanaID", model.ThanaID);
                ht.Add("Address", model.Address);
                ht.Add("EnterpriseCategoryID", model.EnterpriseCategoryID);
                ht.Add("OrganizationTypeID", model.OrganizationTypeID);
                ht.Add("Remarks", model.Remarks);
                ht.Add("EstablishedDate", model.EstablishedDate);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);    
             
                return idbutility.GetDataByProc(ht, "sp_InsertEnterprise").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise saved failed: "+ ex.Message.ToString();
            }
        }

        internal string UpdateEnterprise(BOEnterpriseManagement model)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseId", model.EnterpriseID);
                ht.Add("EnterpriseCode", model.EnterpriseCode);
                ht.Add("EnterpriseName", model.EnterpriseName);
                ht.Add("ContactNo", model.ContactNo);
                ht.Add("Email", model.Email);
                ht.Add("LicenseNo", model.LicenseNo);
                ht.Add("OwnersInfo", model.OwnersInfo);
                ht.Add("OwnersContact", model.OwnersContact);
                ht.Add("Website", model.Website);
                ht.Add("SocialLink", model.SocialLink);
                ht.Add("TotalArea", model.TotalArea);
                ht.Add("TotalInvestment", model.TotalInvestment);
                ht.Add("InitialInvestment", model.InitialInvestment);
                ht.Add("TotalNoOfBuilding", model.TotalNoOfBuilding);
                ht.Add("EnterpriseTypeID", model.EnterpriseTypeID);
                ht.Add("Logo", model.Logo);
                ht.Add("Longitude", model.Longitude);
                ht.Add("Latitude", model.Latitude);
                ht.Add("DivisionID", model.DivisionID);
                ht.Add("DistrictID", model.DistrictID);
                ht.Add("ThanaID", model.ThanaID);
                ht.Add("Address", model.Address);
                ht.Add("EnterpriseCategoryID", model.EnterpriseCategoryID);
                ht.Add("OrganizationTypeID", model.OrganizationTypeID);
                ht.Add("Remarks", model.Remarks);
                ht.Add("EstablishedDate", model.EstablishedDate);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);  

                return idbutility.GetDataByProc(ht, "sp_UpdateEnterprise").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise saved failed: " + ex.Message.ToString();
            }
        }

        internal string DeleteEnterprise(BOEnterpriseManagement model)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("CreatedBy", model.DeletedBy);
                ht.Add("CreatedPC", model.DeletedPC);

                return idbutility.GetDataByProc(ht, "sp_DeletedEnterprise").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise saved failed: " + ex.Message.ToString();
            }
        }

        internal DataTable GETEnterpriseManagement(int categoryId)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("EnterpriseCategoryID", categoryId);
                DataTable dataTable = idbutility.GetDataByProc(ht,"sp_GetEnterpriseList");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetEnterpriseMasterInfoById(long EnterpriseID)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("EnterpriseID", EnterpriseID);
                DataTable dataTable = idbutility.GetDataByProc(ht, "sp_GetEnterpriseById");
                return dataTable;
            }
            catch (Exception ex)
            {

                return null;
            }
        }




    }
}