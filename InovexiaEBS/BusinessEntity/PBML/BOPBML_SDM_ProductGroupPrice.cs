using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_ProductGroupPrice
    {
        private int ProductGroupType;
        public int ProductGroupType1
        {
            get { return ProductGroupType; }
            set { ProductGroupType = value; }
        }


        private int ProductThikness;
        public int ProductThikness1
        {
            get { return ProductThikness; }
            set { ProductThikness = value; }
        }


        private int ProductGrade;
        public int ProductGrade1
        {
            get { return ProductGrade; }
            set { ProductGrade = value; }
        }



        private decimal PRate;
        public decimal PRate1
        {
            get { return PRate; }
            set { PRate = value; }
        }


        private string DiscountPercentage;

        public string DiscountPercentage1
        {
            get { return DiscountPercentage; }
            set { DiscountPercentage = value; }
        }

        private string DiscountPrice;

        public string DiscountPrice1
        {
            get { return DiscountPrice; }
            set { DiscountPrice = value; }
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