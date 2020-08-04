using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.TextileEducation
{
    public class BOInstitutionProgramSyllabus
    {
        public int SyllabusID { get; set; }
        public int ProgramID { get; set; }
        public string CourseCode { get; set; }
        public string  CourseTitle { get; set; }
        public string Description { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public String IpAddress { get; set; }
        public bool IsActive { get; set; }
        public string CreatedPC { set; get; }
    }
}