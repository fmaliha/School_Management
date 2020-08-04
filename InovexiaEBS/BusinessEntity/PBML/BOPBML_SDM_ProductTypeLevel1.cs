using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_ProductTypeLevel1
    {
        private int ProductMasterTypeID;

        public int ProductMasterTypeID1
        {
            get { return ProductMasterTypeID; }
            set { ProductMasterTypeID = value; }
        }
        private int ProductTypeID;

        public int ProductTypeID1
        {
            get { return ProductTypeID; }
            set { ProductTypeID = value; }
        }

        private string ProductTypeName;

        public string ProductTypeName1
        {
            get { return ProductTypeName; }
            set { ProductTypeName = value; }
        }

        private string ProductTypeCode;

        public string ProductTypeCode1
        {
            get { return ProductTypeCode; }
            set { ProductTypeCode = value; }
        }
        private string CompanyID;

        public string CompanyID1
        {
            get { return CompanyID; }
            set { CompanyID = value; }
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