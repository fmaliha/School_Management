using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_SODetail
    {

        private string SONO;

        public string SONO1
        {
            get { return SONO; }
            set { SONO = value; }
        }
        private string ProductCode;

        public string ProductCode1
        {
            get { return ProductCode; }
            set { ProductCode = value; }
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
        private string DiscountID;

        public string DiscountID1
        {
            get { return DiscountID; }
            set { DiscountID = value; }
        }
        private string DiscountQuantity;

        public string DiscountQuantity1
        {
            get { return DiscountQuantity; }
            set { DiscountQuantity = value; }
        }
        private Boolean IsDO;

        public Boolean IsDO1
        {
            get { return IsDO; }
            set { IsDO = value; }
        }
        private Boolean IsIncentive;

        public Boolean IsIncentive1
        {
            get { return IsIncentive; }
            set { IsIncentive = value; }
        }
        private DateTime IncentiveCalculateDate;

        public DateTime IncentiveCalculateDate1
        {
            get { return IncentiveCalculateDate; }
            set { IncentiveCalculateDate = value; }
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