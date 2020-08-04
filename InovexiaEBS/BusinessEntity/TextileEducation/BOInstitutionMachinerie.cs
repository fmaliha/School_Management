using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.TextileEducation
{
    public class BOInstitutionMachinerie
    {
        public int MachineID { get; set; }
        public int InstitutionID { get; set; }
        public string MachineName { get; set; }
        public int MachineTypeID { get; set; }
        public int NoOfMachine { get; set; }
        public string Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public String IpAddress { get; set; }
        public bool IsActive { get; set; }
        public string CreatedPC { set; get; }

    }
}