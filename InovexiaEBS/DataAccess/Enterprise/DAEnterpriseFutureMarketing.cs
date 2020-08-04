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
    public class DAEnterpriseFutureMarketing
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long InsertEnterpriseFutureMarket(BOEnterpriseFutureMarketing model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();

                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("CountryID", model.CountryID);
                ht.Add("ItemDescription", model.ItemDescription);
                ht.Add("Amount", model.Amount);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertEnterpriseFutureMarket"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long UpdateEnterpriseFutureMarket(BOEnterpriseFutureMarketing model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();

                ht.Add("EnterpriseFutureMarketID", model.EnterpriseFutureMarketID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("CountryID", model.CountryID);
                ht.Add("ItemDescription", model.ItemDescription);
                ht.Add("Amount", model.Amount);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateEnterpriseFutureMarket"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteEnterpriseFutureMarket(BOEnterpriseFutureMarketing model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseFutureMarketID", model.EnterpriseFutureMarketID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeleteEnterpriseFutureMarket"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseFutureMarketList(int EnterpriseCategoryId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseCategoryId", EnterpriseCategoryId);
                DataTable dataTable = pbsUtility.GetDataByProc(ht,"Sp_GetEnterpriseFutureMarketList");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseFutureMarketByID(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "Sp_GetEnterpriseFutureMarketByID");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}