using InovexiaEBS.BusinessEntity.TextileEducation;
using PBSConnLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InovexiaEBS.DataAccess.TextileEducation
{
    public class DAInstitutionMachinerie
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long InsertInstitutionMachinerie(BOInstitutionMachinerie model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("institutionID", model.InstitutionID);
                ht.Add("machineName", model.MachineName);
                ht.Add("labTypeID", model.MachineTypeID);
                ht.Add("noOfMachine", model.NoOfMachine);
                ht.Add("remarks", model.Remarks);
                ht.Add("createdBy", model.CreatedBy);
                ht.Add("createdPC", model.CreatedPC);
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertInstitutionMachineries"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long UpdateInstitutionMachinerie(BOInstitutionMachinerie model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("machineID", model.MachineID);
                ht.Add("institutionID", model.InstitutionID);
                ht.Add("machineName", model.MachineName);
                ht.Add("labTypeID", model.MachineTypeID);
                ht.Add("noOfMachine", model.NoOfMachine);
                ht.Add("remarks", model.Remarks);
                ht.Add("createdBy", model.CreatedBy);
                ht.Add("createdPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateInstitutionMachineries"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETInstitutionMachinerie()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_GetInstitutionMachineries");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETInstitutionMachinerieById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetGetInstitutionMachineriesById");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteInstitutionMachineries(BOInstitutionMachinerie model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("machineID", model.MachineID);               
                ht.Add("createdBy", model.CreatedBy);
                ht.Add("createdPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeleteInstitutionMachineries"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}