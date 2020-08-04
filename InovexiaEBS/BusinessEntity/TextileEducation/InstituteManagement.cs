using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.TextileEducation
{
    public class InstituteManagement
    {
        public int? InstitutionID { get; set; }
        public string InstitutionCode { set; get; }
        public int InstitutionType { set; get; }
        public int InstitutionCategory { set; get; }
        public string InstitutionName { set; get; }
        public string Logo { set; get; }
        public string Longitute { set; get; }
        public string Latitude { set; get; }


        public int DivisionID { set; get; }
        public int DistrictID { set; get; }
        public int ThanaID { set; get; }

        public string Address { set; get; }
        public string Telephone { set; get; }
        public string Fax { set; get; }
        public string Email { set; get; }
        public string Website { set; get; }
        public string SocialSiteInfo { set; get; }
        public string EstablishedYear { set; get; }
        public string Remarks { set; get; }
        public string IpAddress { set; get; }
        public string TotalArea { set; get; }
        public int? NoOfAcademicBuilding { set; get; }
        public int? NoOfLab { set; get; }
       

        public decimal? TotalInvestment { set; get; }
        public decimal? InitialInvestment { set; get; }
        //public bool IsActive { set; get; }

        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedPC { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedPC { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedPC { get; set; }  



    }
}