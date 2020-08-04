using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_Incentive
    {
        private int IncentiveID;

        public int IncentiveID1
        {
            get { return IncentiveID; }
            set { IncentiveID = value; }
        }
        private string IncentiveName;

        public string IncentiveName1
        {
            get { return IncentiveName; }
            set { IncentiveName = value; }
        }
        private string DealerID;

        public string DealerID1
        {
            get { return DealerID; }
            set { DealerID = value; }
        }
        private decimal DOAmountMax;

        public decimal DOAmountMax1
        {
            get { return DOAmountMax; }
            set { DOAmountMax = value; }
        }


        private decimal DOAmountMin;

        public decimal DOAmountMin1
        {
            get { return DOAmountMin; }
            set { DOAmountMin = value; }
        }


        private decimal IncentiveAmount;

        public decimal IncentiveAmount1
        {
            get { return IncentiveAmount; }
            set { IncentiveAmount = value; }
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
        private string ApprovedBY;

        public string ApprovedBY1
        {
            get { return ApprovedBY; }
            set { ApprovedBY = value; }
        }
        private DateTime ApprovalDateTime;

        public DateTime ApprovalDateTime1
        {
            get { return ApprovalDateTime; }
            set { ApprovalDateTime = value; }
        }
        private string ApprovalComments;

        public string ApprovalComments1
        {
            get { return ApprovalComments; }
            set { ApprovalComments = value; }
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