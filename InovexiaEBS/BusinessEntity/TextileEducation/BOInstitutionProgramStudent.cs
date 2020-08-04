using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.TextileEducation
{
    public class BOInstitutionProgramStudent
    {
        public int ProStudentID { get; set; }
        public int InstitutionID { get; set; }
        public int ProgramTypeID { get; set; }
        public int ProgramID { get; set; }
        public int AdmittedMen { get; set; }
        public int AdmittedFemal { get; set; }
        public int? AdmittedOthers { get; set; }
        public int PassingMen { get; set; }
        public int PassingFemal { get; set; }
        public int? PassingOthers { get; set; }
        public int YearID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedPC { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedPC { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedPC { get; set; }
        public bool? IsDeleted { get; set; }
        public string Remark { set; get; }
    }
}