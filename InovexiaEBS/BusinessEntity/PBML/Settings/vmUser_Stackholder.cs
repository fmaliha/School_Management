using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.PBML.Settings
{
    public class vmUser_Stackholder
    {
        public int MappingID { get; set; }
        public int pin_number { get; set; }
        public string login_id { get; set; }
        
        public int StakeholderTypeID { get; set; }
        public string StakeholderTypeName { get; set; }
        public string StakeholderName { get; set; }
        public string CreatedBy { get; set; }

        


    }
}