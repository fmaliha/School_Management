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
    public class DAEnterpriseMarketStatus
    {

        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long InsertEnterpriseMarketStatus(BOEnterpriseMarketStatus model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable(); 
                ht.Add("EnterpriseMarketStatusID", model.EnterpriseMarketStatusID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("CountryID", model.CountryID);
                ht.Add("MeasurementUnitID", model.MeasurementUnitID);
                ht.Add("SaleQty", model.SaleQty);
                ht.Add("SalesAmount", model.SalesAmount);
                ht.Add("ItemDescription", model.ItemDescription);
                ht.Add("YearID", model.YearID);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedAt", model.CreatedAt);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                ht.Add("UpdatedAt", model.UpdatedAt);
                ht.Add("UpdatedBy", model.UpdatedBy);
                ht.Add("UpdatedPC", model.UpdatedPC);
                ht.Add("DeletedAt", model.DeletedAt);
                ht.Add("DeletedBy", model.DeletedBy);
                ht.Add("DeletedPC", model.DeletedPC);
                ht.Add("IsDeleted", model.IsDeleted);
                ht.Add("IsActive", model.IsActive);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertEnterpriseMarketStatus"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long UpdateEnterpriseMarketStatus(BOEnterpriseMarketStatus model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseMarketStatusID", model.EnterpriseMarketStatusID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("CountryID", model.CountryID);
                ht.Add("MeasurementUnitID", model.MeasurementUnitID);
                ht.Add("SaleQty", model.SaleQty);
                ht.Add("SalesAmount", model.SalesAmount);
                ht.Add("ItemDescription", model.ItemDescription);
                ht.Add("YearID", model.YearID);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedAt", model.CreatedAt);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                ht.Add("UpdatedAt", model.UpdatedAt);
                ht.Add("UpdatedBy", model.UpdatedBy);
                ht.Add("UpdatedPC", model.UpdatedPC);
                ht.Add("DeletedAt", model.DeletedAt);
                ht.Add("DeletedBy", model.DeletedBy);
                ht.Add("DeletedPC", model.DeletedPC);
                ht.Add("IsDeleted", model.IsDeleted);
                ht.Add("IsActive", model.IsActive);
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateEnterpriseMarketStatus"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseMarketStatus(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetEnterpriseMarketStatus");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseMarketStatusById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetEnterpriseMarketStatusById");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteEnterpriseMarketStatus(BOEnterpriseMarketStatus model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseMarketStatusID", model.EnterpriseMarketStatusID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "[sp_DeleteEnterpriseMarketStatus]"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}