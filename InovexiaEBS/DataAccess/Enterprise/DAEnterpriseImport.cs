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
    public class DAEnterpriseImport
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long InsertEnterpriseImport(BOEnterpriseImport model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();

                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("ImportTypeID", model.ImportTypeID);
                ht.Add("ItemDescription", model.ItemDescription);
                ht.Add("TotalAmount", model.TotalAmount);
                ht.Add("YearID", model.YearId);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
              
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertEnterpriseImport"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long UpdateEnterpriseImport(BOEnterpriseImport model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseImportID", model.EnterpriseImportID);
                ht.Add("ImportTypeID", model.ImportTypeID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("ItemDescription", model.ItemDescription);
                ht.Add("TotalAmount", model.TotalAmount);
                ht.Add("YearID", model.YearId);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateEnterpriseImport"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteEnterpriseImport(BOEnterpriseImport model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseImportID", model.EnterpriseImportID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeleteEnterpriseImport"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseImport(int EnPriseCategoryID)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseCategoryId", EnPriseCategoryID);
                DataTable dataTable = pbsUtility.GetDataByProc(ht,"sp_GetEnterpriseImport");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseImportById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetEnterpriseImportById");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}