using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessEntity.Enterprise
{
    public class BOBlogPost
    {
        public int BlogPostID { get; set; }
        public int PostTypeID { get; set; }
        public string PostTitle { get; set; }
        public string Image { get; set; }
        public string Details { get; set; }
        public string Remarks { get; set; }
        public bool? IsApproved { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedAt { get; set; }
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
        public int? EnterpriseCategoryID { set; get; }
    }
}