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
    public class DAInstitutionRequiredHr
    {

        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long InsertInstitutionRequiredHr(BOInstitutionRequiredHr model)
        {
            try
            {
                long result = 0; 
                Hashtable ht = new Hashtable();
                ht.Add("RequiredHrID", model.RequiredHrID);
                ht.Add("InstitutionID", model.InstitutionID);
                ht.Add("Designation", model.Designation);
                ht.Add("HighestEducationID", model.HighestEducationID);
                ht.Add("SpecializationID", model.SpecializationID);
                ht.Add("HrTypeID", model.HrTypeID);
                ht.Add("JobTypeID", model.JobTypeID);
                ht.Add("NumberOfHr", model.NumberOfHr);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertInstitutionRequiredHr"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long UpdateInstitutionRequiredHr(BOInstitutionRequiredHr model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("RequiredHrID", model.RequiredHrID);
                ht.Add("InstitutionID", model.InstitutionID);
                ht.Add("Designation", model.Designation);
                ht.Add("HighestEducationID", model.HighestEducationID);
                ht.Add("SpecializationID", model.SpecializationID);
                ht.Add("HrTypeID", model.HrTypeID);
                ht.Add("JobTypeID", model.JobTypeID);
                ht.Add("NumberOfHr", model.NumberOfHr);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);                 

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateInstitutionRequiredHr"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteInstitutionRequiredHr(BOInstitutionRequiredHr model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("RequiredHrID", model.RequiredHrID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeleteInstitutionRequiredHr"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETInstitutionRequiredHr()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_GetInstitutionRequiredHr");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETInstitutionRequiredHrById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetInstitutionRequiredHrById");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


    }
}