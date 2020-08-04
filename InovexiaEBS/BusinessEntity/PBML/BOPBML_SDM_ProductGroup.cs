using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_ProductGroup
    {
        private int ProductGroupID;

        public int ProductGroupID1
        {
            get { return ProductGroupID; }
            set { ProductGroupID = value; }
        }
        private string ProductGroupName;

        public string ProductGroupName1
        {
            get { return ProductGroupName; }
            set { ProductGroupName = value; }
        }



        private string ProductGroupCode;

        public string ProductGroupCode1
        {
            get { return ProductGroupCode; }
            set { ProductGroupCode = value; }
        }



        private Boolean IsActive;

        public Boolean IsActive1
        {
            get { return IsActive; }
            set { IsActive = value; }
        }
        private string CreatedBy;

        public string CreatedBy1
        {
            get { return CreatedBy; }
            set { CreatedBy = value; }
        }
        private DateTime CreatedDate;

        public DateTime CreatedDate1
        {
            get { return CreatedDate; }
            set { CreatedDate = value; }
        }
        private string UpdatedBy;

        public string UpdatedBy1
        {
            get { return UpdatedBy; }
            set { UpdatedBy = value; }
        }
        private DateTime UpdatedDate;

        public DateTime UpdatedDate1
        {
            get { return UpdatedDate; }
            set { UpdatedDate = value; }
        }

    }
}