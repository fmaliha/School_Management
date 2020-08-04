using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.Enterprise
{
    public class BOEnterpriseImport
    {
        public int EnterpriseImportID { get; set; }
        public int ImportTypeID { get; set; }
        public int EnterpriseID { get; set; }
        public string ItemDescription { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? YearId { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedPC { set; get; }
    }
}