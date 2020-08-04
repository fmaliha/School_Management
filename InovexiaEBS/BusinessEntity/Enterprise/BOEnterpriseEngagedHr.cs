using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.Enterprise
{
    public class BOEnterpriseEngagedHr
    {

        public int EnterpriseHrID { get; set; }
        public int EnterpriseID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Gender { get; set; }
        public string MobileNo { get; set; }
        public string NID { get; set; }
        public string Designation { get; set; }
        public int HighestEducationID { get; set; }
        public int SpecializationID { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string SocialSiteInfo { get; set; }
        public int JobTypeID { get; set; }
        public string PassportNo { get; set; }
        public int CountryID { get; set; }
        public int HrTypeID { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        public string NationalID { get; set; }

        public string IpAddress { get; set; }

        public int EngagedHrID { get; set; }
        public string CreatedPC { set; get; }
    }
}