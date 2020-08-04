using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_DODetail
    {
        private string DONO;

        public string DONO1
        {
            get { return DONO; }
            set { DONO = value; }
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


        private string DiscountQuantity;

        public string DiscountQuantity1
        {
            get { return DiscountQuantity; }
            set { DiscountQuantity = value; }
        }

        private string DiscountID;
        public string DiscountID1
        {
            get { return DiscountID; }
            set { DiscountID = value; }
        }



        private Boolean IsDC;

        public Boolean IsDC1
        {
            get { return IsDC; }
            set { IsDC = value; }
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