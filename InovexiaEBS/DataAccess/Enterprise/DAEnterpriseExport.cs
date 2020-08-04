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
    public class DAEnterpriseExport
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long InsertEnterpriseExport(BOEnterpriseExport model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                
                ht.Add("EnterpriseExportID", model.EnterpriseExportID);
                ht.Add("EnterpriseID", model.EnterpriseID);

                ht.Add("CountryID", model.CountryID);
                ht.Add("ItemDetails", model.ItemDetails);
                ht.Add("MeasurementUnitID", model.MeasurementUnitID);
                ht.Add("Qty", model.Qty);
                ht.Add("TotalValue", model.TotalValue);
                ht.Add("YearID", model.YearID);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);                
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertEnterpriseExport"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long UpdateEnterpriseExport(BOEnterpriseExport model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseExportID", model.EnterpriseExportID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("CountryID", model.CountryID);
                ht.Add("ItemDetails", model.ItemDetails);
                ht.Add("MeasurementUnitID", model.MeasurementUnitID);
                ht.Add("Qty", model.Qty);
                ht.Add("TotalValue", model.TotalValue);
                ht.Add("YearID", model.YearID);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);     


                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateEnterpriseExport"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteEnterpriseExport(BOEnterpriseExport model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseExportID", model.EnterpriseExportID);               
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);


                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeleteEnterpriseExport"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseExport(int EnterPriseCategoryId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseCategoryId", EnterPriseCategoryId);   
                DataTable dataTable = pbsUtility.GetDataByProc(ht,"sp_GetEnterpriseExport");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseExportById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetEnterpriseExportById");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}