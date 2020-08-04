using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_ProductTypeLevel2
    {

    private  int ProductSubTypeID;
    public int ProductSubTypeID1
    {
        get { return ProductSubTypeID; }
        set { ProductSubTypeID = value; }
    }

    private string ProductSubTypeName;
    public string ProductSubTypeName1
    {
        get { return ProductSubTypeName; }
        set { ProductSubTypeName = value; }
    }
    private string ProductSubTypeCode;

    public string ProductSubTypeCode1
    {
        get { return ProductSubTypeCode; }
        set { ProductSubTypeCode = value; }
    }
    private int ProductTypeID;
    public int ProductTypeID1
    {
        get { return ProductTypeID; }
        set { ProductTypeID = value; }
    }

        private int ProductMasterTypeID;
        public int ProductMasterTypeID1
        {
            get { return ProductMasterTypeID; }
            set { ProductMasterTypeID = value; }
        }

        private string CompanyID;
        public string CompanyID1
        {
            get { return CompanyID; }
            set { CompanyID = value; }
        }

        private Boolean IsActive;
        public bool IsActive1
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