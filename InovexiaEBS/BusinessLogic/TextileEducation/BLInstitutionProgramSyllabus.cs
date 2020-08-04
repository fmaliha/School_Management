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
    public class BLInstitutionProgramSyllabus
    {

        internal static long InsertInstitutionProgramSyllabus(BOInstitutionProgramSyllabus model)
        {
            DAInstitutionProgramSyllabus accessLayer = new DAInstitutionProgramSyllabus();
            return accessLayer.InsertInstitutionProgramSyllabus(model);
        }

        internal static long UpdateInstitutionProgramSyllabus(BOInstitutionProgramSyllabus model)
        {
            DAInstitutionProgramSyllabus accessLayer = new DAInstitutionProgramSyllabus();
            return Convert.ToInt64(accessLayer.UpdateInstitutionProgramSyllabus(model));
        }

        internal static long DeleteInstitutionProgramSyllabus(BOInstitutionProgramSyllabus model)
        {
            DAInstitutionProgramSyllabus accessLayer = new DAInstitutionProgramSyllabus();
            return Convert.ToInt64(accessLayer.DeleteInstitutionProgramSyllabus(model));
        }

        

        internal static DataTable GETInstitutionProgramSyllabus()
        {
            DAInstitutionProgramSyllabus accessLayer = new DAInstitutionProgramSyllabus();
            return accessLayer.GETInstitutionProgramSyllabus();
        }

        internal static DataTable GETInstitutionProgramSyllabusById(Hashtable ht)
        {
            DAInstitutionProgramSyllabus accessLayer = new DAInstitutionProgramSyllabus();
            return accessLayer.GETInstitutionProgramSyllabusById(ht);
        }
    }
}