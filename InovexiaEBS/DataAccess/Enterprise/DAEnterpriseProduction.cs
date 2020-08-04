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
    public class DAEnterpriseProduction
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long InsertEnterpriseProduction(BOEnterpriseProduction model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();

                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("ItemDescriptions", model.ItemDescriptions);
                ht.Add("Qty", model.Qty);
                ht.Add("MeasurementUnit", model.MeasurementUnit);
                ht.Add("TotalValue", model.TotalValue);
                ht.Add("ProductionYear", model.ProductionYear);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertEnterpriseProduction"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long UpdateEnterpriseProduction(BOEnterpriseProduction model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();

                ht.Add("EnterpriseProductionID", model.EnterpriseProductionID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("ItemDescriptions", model.ItemDescriptions);
                ht.Add("Qty", model.Qty);
                ht.Add("MeasurementUnit", model.MeasurementUnit);
                ht.Add("TotalValue", model.TotalValue);
                ht.Add("ProductionYear", model.ProductionYear);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateEnterpriseProduction"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteEnterpriseProduction(BOEnterpriseProduction model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseProductionID", model.EnterpriseProductionID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeleteEnterpriseProduction"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseProductionList(int EnterpriseCategoryId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseCategoryId", EnterpriseCategoryId);
                DataTable dataTable = pbsUtility.GetDataByProc(ht,"Sp_getEnterpriseProductionList");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseProductionByID(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "Sp_getEnterpriseProductionByID");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}