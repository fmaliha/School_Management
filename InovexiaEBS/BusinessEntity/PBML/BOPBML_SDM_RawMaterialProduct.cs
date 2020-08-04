using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_RawMaterialProduct
    {
        private int RawMaterialProductID;

        public int RawMaterialProductID1
        {
            get { return RawMaterialProductID; }
            set { RawMaterialProductID = value; }
        }
        private int RawMaterialGroupID;

        public int RawMaterialGroupID1
        {
            get { return RawMaterialGroupID; }
            set { RawMaterialGroupID = value; }
        }
        private string RawMaterialProductName;

        public string RawMaterialProductName1
        {
            get { return RawMaterialProductName; }
            set { RawMaterialProductName = value; }
        }
        private int UnitID;

        public int UnitID1
        {
            get { return UnitID; }
            set { UnitID = value; }
        }
        private int SerialNumber;

        public int SerialNumber1
        {
            get { return SerialNumber; }
            set { SerialNumber = value; }
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