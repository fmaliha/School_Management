using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.TextileEducation
{
    public class BOInstitutionEngagedHr
    {

        public int EngagedHrID { set; get; }

        public int InstitutionID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Gender { set; get; }
        public string MobileNo { get; set; }
        public int DesignationID { get; set; }
        public int HighestEducationID { get; set; }
        public int SpecializationID { get; set; }
        public string Email { get; set; }
        public int CountryID { get; set; }
        public string NationalID { set; get; }
        public string PassportNo { set; get; }
        public string Website { set; get; }
        public string SocialSiteInfo { set; get; }
        public int HrTypeID { set; get; }
        public int JobTypeID { set; get; }

        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public String IpAddress { get; set; }
        public bool IsActive { get; set; }
        public string CreatedPC { set; get; }

    }
}