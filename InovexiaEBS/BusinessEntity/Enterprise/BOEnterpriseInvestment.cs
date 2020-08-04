using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.Enterprise
{
    public class BOEnterpriseInvestment
    {

        public int EnterpriseInvestmentID { get; set; }
        public int EnterpriseID { get; set; }
        public int InvestmentTypeId { get; set; }
        public int CountryID { get; set; }
        public decimal TotalAmount { get; set; }
        public string Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedPC { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedPC { get; set; }
        public bool IsDeleted { get; set; }
        public int DeletedBy { get; set; }
        public DateTime DeletedAt { get; set; }
        public string DeletedPC { get; set; }

        public object IpAddress { get; set; }
    }
}