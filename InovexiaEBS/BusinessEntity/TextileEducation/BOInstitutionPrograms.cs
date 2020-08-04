using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.TextileEducation
{
    public class BOInstitutionPrograms
    {
        public int InstitutionID { set; get; }
        public int ProgramID { set; get; }
        public int ProgramTypeID { set; get; }
        public string ProgramName { set; get; }
        public string ProgramDuration { set; get; }
        public int NumberOfSeats { set; get; }
        public decimal ExpensePerStudent { set; get; }
        public int SpecializationID { set; get; }
        public string Remarks { set; get; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public String IpAddress { get; set; }
        public bool IsActive { get; set; }
        public string CreatedPC { set; get; }
    }
}