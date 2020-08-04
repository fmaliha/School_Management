using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_RawMaterialStockIn
    {
        private string RMID;

        public string RMID1
        {
            get { return RMID; }
            set { RMID = value; }
        }
        private int RawMaterialProductID;

        public int RawMaterialProductID1
        {
            get { return RawMaterialProductID; }
            set { RawMaterialProductID = value; }
        }
        private decimal Quantity;

        public decimal Quantity1
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        private decimal Rate;

        public decimal Rate1
        {
            get { return Rate; }
            set { Rate = value; }
        }
        private DateTime PurchaseDate;

        public DateTime PurchaseDate1
        {
            get { return PurchaseDate; }
            set { PurchaseDate = value; }
        }
        private int SupplierID;

        public int SupplierID1
        {
            get { return SupplierID; }
            set { SupplierID = value; }
        }
        private int PYear;

        public int PYear1
        {
            get { return PYear; }
            set { PYear = value; }
        }

        private int StockType;

        public int StockType1
        {
            get { return StockType; }
            set { StockType = value; }
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