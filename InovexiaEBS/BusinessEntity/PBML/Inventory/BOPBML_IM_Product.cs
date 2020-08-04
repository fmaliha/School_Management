using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML.Inventory
{
    public class BOPBML_IM_Product
    {
        private int PrdID;

        public int PrdID1
        {
            get { return PrdID; }
            set { PrdID = value; }
        }
        private int TypeID;

        public int TypeID1
        {
            get { return TypeID; }
            set { TypeID = value; }
        }
        private int CatID;

        public int CatID1
        {
            get { return CatID; }
            set { CatID = value; }
        }
        private string PrdName;

        public string PrdName1
        {
            get { return PrdName; }
            set { PrdName = value; }
        }
        private int UnitID;

        public int UnitID1
        {
            get { return UnitID; }
            set { UnitID = value; }
        }
        private string PartNo;

        public string PartNo1
        {
            get { return PartNo; }
            set { PartNo = value; }
        }
        private string xLocation;

        public string xLocation1
        {
            get { return xLocation; }
            set { xLocation = value; }
        }
        private decimal Conv;

        public decimal Conv1
        {
            get { return Conv; }
            set { Conv = value; }
        }
        private string CUnit;

        public string CUnit1
        {
            get { return CUnit; }
            set { CUnit = value; }
        }
        private string ProductLot;

        public string ProductLot1
        {
            get { return ProductLot; }
            set { ProductLot = value; }
        }
        private string StoreCode;

        public string StoreCode1
        {
            get { return StoreCode; }
            set { StoreCode = value; }
        }
        private string CompanyID;

        public string CompanyID1
        {
            get { return CompanyID; }
            set { CompanyID = value; }
        }
        private int SerialNumber;

        public int SerialNumber1
        {
            get { return SerialNumber; }
            set { SerialNumber = value; }
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
        private Boolean IsInventory;

        public Boolean IsInventory1
        {
            get { return IsInventory; }
            set { IsInventory = value; }
        }
        private Boolean IsFG;

        public Boolean IsFG1
        {
            get { return IsFG; }
            set { IsFG = value; }
        }
    }
}