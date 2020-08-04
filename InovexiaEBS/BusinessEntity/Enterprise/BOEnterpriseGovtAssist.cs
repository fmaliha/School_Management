using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.Enterprise
{
    public class BOEnterpriseGovtAssist
    {

        public int EnterpriseGovtAssistID { get; set; }
        public int EnterpriseID { get; set; }
        public int GovtAssistTypeID { get; set; }
        public bool IsActive { get; set; }
        public int EffectFromYearID { get; set; }
        public string Remarks { get; set; }
        public DateTime CreatedAt { get; set; }
        public int createdBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int DeletedBy { get; set; }
        public DateTime DeletedAt { get; set; }
        public string DeletedPC { get; set; }

        public object IpAddress { get; set; }
    }
}