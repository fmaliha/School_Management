using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML.Inventory
{
    public class BOPBML_IM_SPRDetail
    {
        private string SPRNO;

        public string SPRNO1
        {
            get { return SPRNO; }
            set { SPRNO = value; }
        }
        private int PrdID;

        public int PrdID1
        {
            get { return PrdID; }
            set { PrdID = value; }
        }
        private decimal RequiredQty;

        public decimal RequiredQty1
        {
            get { return RequiredQty; }
            set { RequiredQty = value; }
        }
        private Boolean IsPriceEstimated;

        public Boolean IsPriceEstimated1
        {
            get { return IsPriceEstimated; }
            set { IsPriceEstimated = value; }
        }
        private decimal EstUnitPrice;

        public decimal EstUnitPrice1
        {
            get { return EstUnitPrice; }
            set { EstUnitPrice = value; }
        }
        private decimal LastPurchaseRate;

        public decimal LastPurchaseRate1
        {
            get { return LastPurchaseRate; }
            set { LastPurchaseRate = value; }
        }
        private string MRRNO;

        public string MRRNO1
        {
            get { return MRRNO; }
            set { MRRNO = value; }
        }
        private DateTime MRRDate;

        public DateTime MRRDate1
        {
            get { return MRRDate; }
            set { MRRDate = value; }
        }
        private decimal MRRQty;

        public decimal MRRQty1
        {
            get { return MRRQty; }
            set { MRRQty = value; }
        }
        private decimal StockQty;

        public decimal StockQty1
        {
            get { return StockQty; }
            set { StockQty = value; }
        }
        private Boolean IsPurchase;

        public Boolean IsPurchase1
        {
            get { return IsPurchase; }
            set { IsPurchase = value; }
        }
        private Boolean IsQC;

        public Boolean IsQC1
        {
            get { return IsQC; }
            set { IsQC = value; }
        }
        private Boolean IsMRR;

        public Boolean IsMRR1
        {
            get { return IsMRR; }
            set { IsMRR = value; }
        }
        private Boolean IsPaid;

        public Boolean IsPaid1
        {
            get { return IsPaid; }
            set { IsPaid = value; }
        }
        private string Remarks;

        public string Remarks1
        {
            get { return Remarks; }
            set { Remarks = value; }
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