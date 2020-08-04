using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.PBML.Settings
{
    public class User
    {
        public string UserName { set; get; }
        public string LoginID { set; get; }
        public string Password { set; get; }
        public string Email { set; get; }
        public string UserType { set; get; }
        public string CreatedBy { set; get; }
        public string ContactNumber { get; set; }
        public string pin_number { get; set; }

    }
}