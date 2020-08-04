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
    public class DAEnterpriseWarehouse
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        internal string InsertEnterpriseWarehouse(BOEnterpriseWarehouse model)
        {
            try
            {

                Hashtable ht = new Hashtable();

               
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("ItemDescription", model.ItemDescription);
                ht.Add("Capacity", model.Capacity);
                ht.Add("MeasurementUnitID", model.MeasurementUnitID);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);  
                ht.Add("CreatedPC", model.IpAddress);


                return idbutility.GetDataByProc(ht, "sp_InsertEnterpriseWarehouse").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise Govt. Assist saved failed: " + ex.Message.ToString();
            }
        }

        internal string UpdateEnterpriseWarehouse(BOEnterpriseWarehouse model)
        {
            try
            {

                Hashtable ht = new Hashtable();
             
                ht.Add("EnterpriseWarehouseID", model.EnterpriseWarehouseID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("ItemDescription", model.ItemDescription);
                ht.Add("Capacity", model.Capacity);
                ht.Add("MeasurementUnitID", model.MeasurementUnitID);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);                      
                ht.Add("UpdatedPC", model.IpAddress);

                return idbutility.GetDataByProc(ht, "sp_UpdateEnterpriseWarehouse").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise Govt. Assist update failed: " + ex.Message.ToString();
            }

        }


        internal DataTable GETEnterpriseWarehouseById(int Id)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseWarehouseID", Id);

                DataTable dataTable = idbutility.GetDataByProc(ht, "sp_GetEnterpriseWarehouseById");
                return dataTable;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        internal DataTable GETEnterpriseWarehouseListByCategoryId(int CategoryId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("CategoryId", CategoryId);

                DataTable dataTable = idbutility.GetDataByProc(ht, "sp_GetEnterpriseWarehouseListByCategoryId");
                return dataTable;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        internal long DeleteEnterpriseWarehouse(BOEnterpriseWarehouse model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseWarehouseID", model.EnterpriseWarehouseID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.IpAddress);

                result = Convert.ToInt64(idbutility.InsertData(ht, "sp_DeleteEnterpriseWarehouse"));
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}