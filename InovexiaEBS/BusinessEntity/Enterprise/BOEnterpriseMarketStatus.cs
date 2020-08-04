using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.Enterprise
{
    public class BOEnterpriseMarketStatus
    {
        public int EnterpriseCategoryId { get; set; }
        public int EnterpriseMarketStatusID { get; set; }
        public int EnterpriseID { get; set; }
        public int CountryID { get; set; }
        public int MeasurementUnitID { get; set; }
        public decimal SaleQty { get; set; }
        public decimal? SalesAmount { get; set; }
        public string ItemDescription { get; set; }
        public int? YearID { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedPC { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public string UpdatedPC { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string DeletedPC { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}