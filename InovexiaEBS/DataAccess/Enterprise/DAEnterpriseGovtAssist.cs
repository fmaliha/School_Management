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
    public class DAEnterpriseGovtAssist
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        internal string InsertEnterpriseGovtAssist(BOEnterpriseGovtAssist model)
        {
            try
            {

                Hashtable ht = new Hashtable();

               
               
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("GovtAssistTypeID", model.GovtAssistTypeID);                
                ht.Add("EffectFromYearID", model.EffectFromYearID);
                ht.Add("Remarks", model.Remarks);                
                ht.Add("createdBy", model.createdBy);           
                ht.Add("CreatedPC", model.IpAddress);


                return idbutility.GetDataByProc(ht, "sp_InsertEnterpriseGovtAssist").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise Govt. Assist saved failed: " + ex.Message.ToString();
            }
        }

        internal string UpdateEnterpriseGovtAssist(BOEnterpriseGovtAssist model)
        {
            try
            {

                Hashtable ht = new Hashtable();
                
                ht.Add("EnterpriseGovtAssistID", model.EnterpriseGovtAssistID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("GovtAssistTypeID", model.GovtAssistTypeID);
                ht.Add("EffectFromYearID", model.EffectFromYearID);
                ht.Add("Remarks", model.Remarks);
                ht.Add("UpdatedBy", model.createdBy);              
                ht.Add("UpdatedPC", model.IpAddress);

                return idbutility.GetDataByProc(ht, "sp_UpdateEnterpriseGovtAssist").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise Govt. Assist update failed: " + ex.Message.ToString();
            }

        }


        internal DataTable GETEnterpriseGovtAssistById(int Id)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseGovtAssistID", Id);

                DataTable dataTable = idbutility.GetDataByProc(ht, "sp_GetEnterpriseGovtAssistById");
                return dataTable;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        internal DataTable GETEnterpriseGovtAssistListByCategoryId(int CategoryId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("CategoryId", CategoryId);

                DataTable dataTable = idbutility.GetDataByProc(ht, "sp_GetEnterpriseGovtAssistListByCategoryId");
                return dataTable;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        internal long DeleteEnterpriseGovtAssist(BOEnterpriseGovtAssist model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseGovtAssistID", model.EnterpriseGovtAssistID);
                ht.Add("DeletedBy", model.createdBy);
                ht.Add("DeletedPC", model.IpAddress);

                result = Convert.ToInt64(idbutility.InsertData(ht, "sp_DeleteEnterpriseGovtAssist"));
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}