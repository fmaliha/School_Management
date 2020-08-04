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
    public class DAInstitutionLabMapping
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        public long InsertInstitutionLabMapping(BOInstitutionLabMapping model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("institutionID", model.InstitutionID);
                ht.Add("machineTypeID", model.MachineTypeID);
                ht.Add("numberOfLab", model.NumberOfLab);
                ht.Add("totalExpense", model.TotalExpense);
                ht.Add("remarks", model.Remarks);
                ht.Add("createdBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertInstitutionLabMapping"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        public long UpdateInstitutionLabMapping(BOInstitutionLabMapping model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("id", model.ID);
                ht.Add("institutionID", model.InstitutionID);
                ht.Add("machineTypeID", model.MachineTypeID);
                ht.Add("numberOfLab", model.NumberOfLab);
                ht.Add("totalExpense", model.TotalExpense);
                ht.Add("remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
               
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateInstitutionLabMapping"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteInstitutionLabMapping(BOInstitutionLabMapping model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("id", model.ID);              
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeleteInstitutionLabMapping"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public DataTable GETInstitutionLabMapping()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_GetInstitutionLabMapping");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public DataTable GETInstitutionLabMappingById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht,"sp_GetInstitutionLabMappingById");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

       
    }
}