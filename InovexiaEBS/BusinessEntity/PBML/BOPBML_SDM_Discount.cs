using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_Discount
    {
        private int DiscountID;

        public int DiscountID1
        {
            get { return DiscountID; }
            set { DiscountID = value; }
        }
        private string DiscountName;

        public string DiscountName1
        {
            get { return DiscountName; }
            set { DiscountName = value; }
        }
        private string ProductCode;

        public string ProductCode1
        {
            get { return ProductCode; }
            set { ProductCode = value; }
        }

        private string DiscountProductCode;

        public string DiscountProductCode1
        {
            get { return DiscountProductCode; }
            set { DiscountProductCode = value; }
        }
        private decimal MinBuyQuantity;

        public decimal MinBuyQuantity1
        {
            get { return MinBuyQuantity; }
            set { MinBuyQuantity = value; }
        }

        private decimal MaxBuyQuantity;

        public decimal MaxBuyQuantity1
        {
            get { return MaxBuyQuantity; }
            set { MaxBuyQuantity = value; }
        }

        private decimal DiscountQuantity;

        public decimal DiscountQuantity1
        {
            get { return DiscountQuantity; }
            set { DiscountQuantity = value; }
        }
        private DateTime StartDate;

        public DateTime StartDate1
        {
            get { return StartDate; }
            set { StartDate = value; }
        }
        private DateTime EndDate;

        public DateTime EndDate1
        {
            get { return EndDate; }
            set { EndDate = value; }
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