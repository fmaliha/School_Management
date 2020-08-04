using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.Enterprise
{
    public class BOEnterpriseRequiredHr
    { 
        public int EnterpriseRequiredHrID { get; set; }
        public int EnterpriseID { get; set; }
        public string Designation { get; set; }
        public int HighestEducationLevelID { get; set; }
        public int HighestEducationLevel { get; set; }

        public int SpecializationID { get; set; }
        public int HrTypeID { get; set; }
        public int JobTypeID { get; set; }
        public int TotalRequiredNo { get; set; }
        public String Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string IpAddress { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public string CreatedPC { set; get; }
    }
}