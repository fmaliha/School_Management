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
    public class DAInstitutionProgramSyllabus
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long InsertInstitutionProgramSyllabus(BOInstitutionProgramSyllabus model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                 ht.Add("ProgramID", model.ProgramID);
                ht.Add("CourseCode", model.CourseCode);
                ht.Add("CourseTitle", model.CourseTitle);
                ht.Add("Description", model.Description);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);             
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertInstitutionProgramSyllabus"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long UpdateInstitutionProgramSyllabus(BOInstitutionProgramSyllabus model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("SyllabusID", model.SyllabusID);
                ht.Add("ProgramID", model.ProgramID);
                ht.Add("CourseCode", model.CourseCode);
                ht.Add("CourseTitle", model.CourseTitle);
                ht.Add("Description", model.Description);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateInstitutionProgramSyllabus"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteInstitutionProgramSyllabus(BOInstitutionProgramSyllabus model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("SyllabusID", model.SyllabusID);                
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeletedInstitutionProgramSyllabus"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETInstitutionProgramSyllabus()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_GetInstitutionProgramSyllabus");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETInstitutionProgramSyllabusById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetInstitutionProgramSyllabusById");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
    
