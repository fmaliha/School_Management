using InovexiaEBS.BusinessEntity.TextileEducation;
using InovexiaEBS.DataAccess.TextileEducation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessLogic.TextileEducation
{
    public class BLInstitutionProgramStudent
    {
        internal static DataTable GETInstitutionProgramWiseStudent()
        {
            DAInstitutionProgramStudent accessLayer = new DAInstitutionProgramStudent();
            return accessLayer.GETInstitutionProgramWiseStudent();
        }
        internal static DataTable GETInstitutionProgramWiseStudentById(Hashtable ht)
        {
            DAInstitutionProgramStudent accessLayer = new DAInstitutionProgramStudent();
            return accessLayer.GETInstitutionProgramWiseStudentById(ht);
        }
        internal static long InsertInstitutionProgramWiseStudent(BOInstitutionProgramStudent model)
        {
            DAInstitutionProgramStudent accessLayer = new DAInstitutionProgramStudent();
            return Convert.ToInt64(accessLayer.InsertInstitutionProgramWiseStudent(model));
        }

        internal static long UpdateInstitutionProgramWiseStudent(BOInstitutionProgramStudent model)
        {
            DAInstitutionProgramStudent accessLayer = new DAInstitutionProgramStudent();
            return Convert.ToInt64(accessLayer.UpdateInstitutionProgramWiseStudent(model));
        }

        internal static long DeleteInstitutionProgramWiseStudent(BOInstitutionProgramStudent model)
        {
            DAInstitutionProgramStudent accessLayer = new DAInstitutionProgramStudent();
            return Convert.ToInt64(accessLayer.DeleteInstitutionProgramWiseStudent(model));
        }

    }
}