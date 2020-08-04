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
    public class DAEnterpriseHrMachineries
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        internal string InsertEnterpriseHrMachineries(BOEnterpriseHrMachineries model)
        {
            try
            {
               
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseHrID", model.EnterpriseHrID);
                ht.Add("MachineTypeID", model.MachineTypeID);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                return idbutility.GetDataByProc(ht, "sp_InsertEnterpriseHrMachineries").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise HR Machineries saved failed: " + ex.Message.ToString();
            }
        }

        internal string UpdateEnterpriseHrMachineries(BOEnterpriseHrMachineries model)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseHrMachineriesID", model.EnterpriseHrMachineriesID);
                ht.Add("EnterpriseHrID", model.EnterpriseHrID);
                ht.Add("MachineTypeID", model.MachineTypeID);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                return idbutility.GetDataByProc(ht, "sp_UpdateEnterpriseHrMachineries").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise HR Machineries update failed: " + ex.Message.ToString();
            }

        }


        internal DataTable GETEnterpriseHrMachineriesById(int Id)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseHrMachineriesID", Id);

                DataTable dataTable = idbutility.GetDataByProc(ht, "sp_GetEnterpriseHrMachineriesById");
                return dataTable;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        internal DataTable GETEnterpriseHrMachineriesListByCategoryId(int CategoryId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("CategoryId", CategoryId);

                DataTable dataTable = idbutility.GetDataByProc(ht, "sp_GetEnterpriseHrMachineriesList");
                return dataTable;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        internal string DeleteEnterpriseHrMachineries(BOEnterpriseHrMachineries model)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseHrMachineriesID", model.EnterpriseHrMachineriesID);               
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                return idbutility.GetDataByProc(ht, "sp_DeleteEnterpriseHrMachineries").Rows[0]["ReturnMessage"].ToString();

            }
            catch (Exception ex)
            {

                return "Enterprise HR Machineries delete failed: " + ex.Message.ToString();
            }
        }
    }
}