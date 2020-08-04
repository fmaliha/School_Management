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
    public class DAEnterpriseMachineries
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long InsertEnterpriseMachineries(BOEnterpriseMachineries model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();

                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("MachineTypeID", model.MachineTypeID);
                ht.Add("MachineName", model.MachineName);
                ht.Add("NumberOfMachine", model.NumberOfMachine);
                ht.Add("MachineDetails", model.MachineDetails);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertEnterpriseMachineries"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long UpdateEnterpriseMachineries(BOEnterpriseMachineries model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseMachineriesID", model.EnterpriseMachineriesID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("MachineTypeID", model.MachineTypeID);
                ht.Add("MachineName", model.MachineName);
                ht.Add("NumberOfMachine", model.NumberOfMachine);
                ht.Add("MachineDetails", model.MachineDetails);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateEnterpriseMachineries"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteEnterpriseMachineries(BOEnterpriseMachineries model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseMachineriesID", model.EnterpriseMachineriesID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeleteEnterpriseMachineries"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseMachineriesList(int EnterpriseCategoryId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseCategoryId", EnterpriseCategoryId);
                DataTable dataTable = pbsUtility.GetDataByProc(ht,"Sp_GetEnterpriseMachineriesList");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseMachineriesByID(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "Sp_GetEnterpriseMachineriesByID");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}