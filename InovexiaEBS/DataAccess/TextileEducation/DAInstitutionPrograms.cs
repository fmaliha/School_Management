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
    public class DAInstitutionPrograms
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long InsertInstitutionPrograms(BOInstitutionPrograms model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("institutionID", model.InstitutionID);
                ht.Add("programTypeID", model.ProgramTypeID);
                ht.Add("programName", model.ProgramName);
                ht.Add("programDuration", model.ProgramDuration);
                ht.Add("numberOfSeats", model.NumberOfSeats);
                ht.Add("expensePerStudent", model.ExpensePerStudent);
                ht.Add("specializationID", model.SpecializationID);
                ht.Add("remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
               
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertInstitutionPrograms"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long UpdateInstitutionPrograms(BOInstitutionPrograms model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("programID", model.ProgramID);
                ht.Add("institutionID", model.InstitutionID);
                ht.Add("programTypeID", model.ProgramTypeID);
                ht.Add("programName", model.ProgramName);
                ht.Add("programDuration", model.ProgramDuration);
                ht.Add("numberOfSeats", model.NumberOfSeats);
                ht.Add("expensePerStudent", model.ExpensePerStudent);
                ht.Add("specializationID", model.SpecializationID);
                ht.Add("remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
               

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateInstitutionPrograms"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteInstitutionPrograms(BOInstitutionPrograms model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("programID", model.ProgramID);                
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);


                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeletedInstitutionPrograms"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETInstitutionPrograms()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_GetInstitutionPrograms");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETInstitutionProgramsById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetInstitutionProgramsById");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}