using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.TextileEducation
{
    public class BOInstitutionLabMapping
    {

        public int ID { get; set; }
        public int InstitutionID { get; set; }
        public int MachineTypeID { get; set; }
        public int NumberOfLab { get; set; }
        public Decimal TotalExpense { get; set; }
        public string Remarks { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public String IpAddress { get; set; }
        public string CreatedPC { set; get; }
         


    }
}