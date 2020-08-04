using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.TextileEducation
{
    public class BOInstitutionRequiredHr
    {
        public int RequiredHrID { get; set; }
        public int InstitutionID { get; set; }
        public string Designation { get; set; }
        public int HighestEducationID { get; set; }
        public int SpecializationID { get; set; }
        public int HrTypeID { get; set; }
        public int JobTypeID { get; set; }
        public int NumberOfHr { get; set; }
        public String Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string IpAddress { get; set; }
        public bool IsActive { get; set; }
        public string CreatedPC{ set; get; }

         
    }
}