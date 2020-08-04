using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.Enterprise
{
    public class BOEnterpriseManagement
    {
        public int EnterpriseID { get; set; }
        public string EnterpriseCode { get; set; }
        public string EnterpriseName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string LicenseNo { get; set; }
        public string OwnersInfo { get; set; }
        public string OwnersContact { get; set; }
        public string Website { get; set; }
        public string SocialLink { get; set; }
        public decimal TotalArea { get; set; }
        public decimal TotalInvestment { get; set; }
        public int TotalNoOfBuilding { get; set; }
        public int EnterpriseTypeID { get; set; }
        public string Logo { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public int DivisionID { get; set; }
        public int DistrictID { get; set; }
        public int ThanaID { get; set; }
        public string Address { get; set; }
        public int EnterpriseCategoryID { get; set; }
        public int OrganizationTypeID { get; set; }
        public string Remarks { get; set; }
        public DateTime EstablishedDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public string IpAddress { get; set; }

        public decimal InitialInvestment { get; set; }

        public string CreatedPC { get; set; }

        public int DeletedBy { get; set; }

        public string DeletedPC { get; set; }
    }
}