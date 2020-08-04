using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_Dealer_DO_Account
    {
        private string DealerID;

        public string DealerID1
        {
            get { return DealerID; }
            set { DealerID = value; }
        }
        private DateTime CStartDate;

        public DateTime CStartDate1
        {
            get { return CStartDate; }
            set { CStartDate = value; }
        }
        private DateTime CEndDate;

        public DateTime CEndDate1
        {
            get { return CEndDate; }
            set { CEndDate = value; }
        }
        private decimal DOAmount;

        public decimal DOAmount1
        {
            get { return DOAmount; }
            set { DOAmount = value; }
        }
        private decimal IncentiveAmount;

        public decimal IncentiveAmount1
        {
            get { return IncentiveAmount; }
            set { IncentiveAmount = value; }
        }
        private Boolean IsApproved;

        public Boolean IsApproved1
        {
            get { return IsApproved; }
            set { IsApproved = value; }
        }
        private string ApprovedBy;

        public string ApprovedBy1
        {
            get { return ApprovedBy; }
            set { ApprovedBy = value; }
        }
        private string ApprovedComments;

        public string ApprovedComments1
        {
            get { return ApprovedComments; }
            set { ApprovedComments = value; }
        }
        private DateTime ApprovedDate;

        public DateTime ApprovedDate1
        {
            get { return ApprovedDate; }
            set { ApprovedDate = value; }
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