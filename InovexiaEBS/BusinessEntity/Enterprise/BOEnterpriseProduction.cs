using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.Enterprise
{
    public class BOEnterpriseProduction
    {
        public int EnterpriseProductionID { get; set; }
        public int EnterpriseID { get; set; }
        public string ItemDescriptions { get; set; }
        public decimal Qty { get; set; }
        public int MeasurementUnit { get; set; }
        public decimal TotalValue { get; set; }
        public int? ProductionYear { get; set; }
        public string Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedPC { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedPC { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedPC { get; set; }
        public bool IsDeleted { get; set; }  
    }
}