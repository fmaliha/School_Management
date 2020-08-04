using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.Enterprise
{
    public class BOEnterpriseHrMachineries
    {

        public int EnterpriseHrMachineriesID { get; set; }
        public int EnterpriseHrID { get; set; }
        public int EnterpriseID { get; set; }
        public int MachineTypeID { get; set; }
        public string Remarks { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public string IpAddress { get; set; }
        public bool IsActive { get; set; }
        public string CreatedPC { set; get; }
    }
}