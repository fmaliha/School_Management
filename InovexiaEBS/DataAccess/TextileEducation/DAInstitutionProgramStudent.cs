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
    public class DAInstitutionProgramStudent
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        public long InsertInstitutionProgramWiseStudent(BOInstitutionProgramStudent model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("InstitutionID", model.InstitutionID);
                ht.Add("ProgramTypeID", model.ProgramTypeID);
                ht.Add("ProgramID", model.ProgramID);
                ht.Add("AdmittedMen", model.AdmittedMen);
                ht.Add("AdmittedFemal", model.AdmittedFemal);
                ht.Add("AdmittedOthers", model.AdmittedOthers);
                ht.Add("PassingMen", model.PassingMen);
                ht.Add("PassingFemal", model.PassingFemal);
                ht.Add("PassingOthers", model.PassingOthers);
                ht.Add("YearID", model.YearID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                ht.Add("Remark", model.Remark);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertInstitutionProgramWiseStudent"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        public long UpdateInstitutionProgramWiseStudent(BOInstitutionProgramStudent model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("ProStudentID", model.ProStudentID);
                ht.Add("InstitutionID", model.InstitutionID);
                ht.Add("ProgramTypeID", model.ProgramTypeID);
                ht.Add("ProgramID", model.ProgramID);
                ht.Add("AdmittedMen", model.AdmittedMen);
                ht.Add("AdmittedFemal", model.AdmittedFemal);
                ht.Add("AdmittedOthers", model.AdmittedOthers);
                ht.Add("PassingMen", model.PassingMen);
                ht.Add("PassingFemal", model.PassingFemal);
                ht.Add("PassingOthers", model.PassingOthers);
                ht.Add("YearID", model.YearID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                ht.Add("Remark", model.Remark);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateInstitutionProgramWiseStudent"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public long DeleteInstitutionProgramWiseStudent(BOInstitutionProgramStudent model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("ProStudentID", model.ProStudentID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeleteInstitutionProgramWiseStudent"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public DataTable GETInstitutionProgramWiseStudent()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_GetInstitutionProgramWiseStudent");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public DataTable GETInstitutionProgramWiseStudentById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetInstitutionProgramWiseStudentById");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}