using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.TextileEducation
{
    public class BODocumentMange
    {
        public int DocManageId { set; get; }
        public string FileName { set; get; }
        public string OrginalFileName { set; get; }
        public int InstitutionId { set; get; }
        public int TypeId { set; get; }
        public int CreatedBy { get; set; }
        public string CreatedPC { get; set; }
    }
}