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
    public class DAEnterpriseInvestment
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        internal string InsertEnterpriseInvestment(BOEnterpriseInvestment model)
        {
            try
            {

                Hashtable ht = new Hashtable();
               
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("InvestmentTypeId", model.InvestmentTypeId);
                ht.Add("CountryID", model.CountryID);
                ht.Add("TotalAmount", model.TotalAmount);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);               
                ht.Add("CreatedPC", model.IpAddress);
                

                return idbutility.GetDataByProc(ht, "sp_InsertEnterpriseInvestment").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise Investment saved failed: " + ex.Message.ToString();
            }
        }

        internal string UpdateEnterpriseInvestment(BOEnterpriseInvestment model)
        {
            try
            {

                Hashtable ht = new Hashtable();              
                ht.Add("EnterpriseInvestmentID", model.EnterpriseInvestmentID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("InvestmentTypeId", model.InvestmentTypeId);
                ht.Add("CountryID", model.CountryID);
                ht.Add("TotalAmount", model.TotalAmount);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("UpdatedPC", model.IpAddress);               
              
                return idbutility.GetDataByProc(ht, "sp_UpdateEnterpriseInvestment").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise Investment update failed: " + ex.Message.ToString();
            }

        }


        internal DataTable GETEnterpriseInvestmentById(int Id)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseInvestmentID", Id);

                DataTable dataTable = idbutility.GetDataByProc(ht, "sp_GetEnterpriseInvestmentById");
                return dataTable;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        internal DataTable GETEnterpriseInvestmentListByCategoryId(int CategoryId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("CategoryId", CategoryId);

                DataTable dataTable = idbutility.GetDataByProc(ht, "sp_GetEnterpriseInvestmentListByCategoryId");
                return dataTable;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        internal long DeleteEnterpriseInvestment(BOEnterpriseInvestment model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseInvestmentID", model.EnterpriseInvestmentID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.IpAddress);

                result = Convert.ToInt64(idbutility.InsertData(ht, "sp_DeleteEnterpriseInvestment"));
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}