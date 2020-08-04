using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_SOMaster
    {

        private string login_id;

        public string Login_id
        {
            get { return login_id; }
            set { login_id = value; }
        }
        private string MailFrom;

        public string MailFrom1
        {
            get { return MailFrom; }
            set { MailFrom = value; }
        }
        private string MailTo;

        public string MailTo1
        {
            get { return MailTo; }
            set { MailTo = value; }
        }
        private DateTime SendTime;

        public DateTime SendTime1
        {
            get { return SendTime; }
            set { SendTime = value; }
        }
        private string MailMessage;

        public string MailMessage1
        {
            get { return MailMessage; }
            set { MailMessage = value; }
        }


        private string oldSONO;

        public string oldSONO1
        {
            get { return oldSONO; }
            set { oldSONO = value; }
        }

        private string SONO;

        public string SONO1
        {
            get { return SONO; }
            set { SONO = value; }
        }
        private DateTime SODate;

        public DateTime SODate1
        {
            get { return SODate; }
            set { SODate = value; }
        }



        private DateTime PosibleDeliveryDate;

        public DateTime PosibleDeliveryDate1
        {
            get { return PosibleDeliveryDate; }
            set { PosibleDeliveryDate = value; }
        }



        private string DealerID;

        public string DealerID1
        {
            get { return DealerID; }
            set { DealerID = value; }
        }
        private DateTime DeliveryDate;

        public DateTime DeliveryDate1
        {
            get { return DeliveryDate; }
            set { DeliveryDate = value; }
        }
        private string Reference;

        public string Reference1
        {
            get { return Reference; }
            set { Reference = value; }
        }
        private int SerialNumber;

        public int SerialNumber1
        {
            get { return SerialNumber; }
            set { SerialNumber = value; }
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
        private string CompanyID;

        public string CompanyID1
        {
            get { return CompanyID; }
            set { CompanyID = value; }
        }
        private int Year;

        public int Year1
        {
            get { return Year; }
            set { Year = value; }
        }
        private int Month;

        public int Month1
        {
            get { return Month; }
            set { Month = value; }
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
        private Boolean IsAccountsApporved;

        public Boolean IsAccountsApporved1
        {
            get { return IsAccountsApporved; }
            set { IsAccountsApporved = value; }
        }
        private string AccountsApprovedBy;

        public string AccountsApprovedBy1
        {
            get { return AccountsApprovedBy; }
            set { AccountsApprovedBy = value; }
        }
        private string AccountsApprovalComments;

        public string AccountsApprovalComments1
        {
            get { return AccountsApprovalComments; }
            set { AccountsApprovalComments = value; }
        }
        private DateTime ApprovalDateTime;

        public DateTime ApprovalDateTime1
        {
            get { return ApprovalDateTime; }
            set { ApprovalDateTime = value; }
        }
        private Boolean IsActive;

        public Boolean IsActive1
        {
            get { return IsActive; }
            set { IsActive = value; }
        }
        private string Remarks;

        public string Remarks1
        {
            get { return Remarks; }
            set { Remarks = value; }
        }
        private Boolean IsRevised;

        public Boolean IsRevised1
        {
            get { return IsRevised; }
            set { IsRevised = value; }
        }

        private Boolean IsSendForDO;

        public Boolean IsSendForDO1
        {
            get { return IsSendForDO; }
            set { IsSendForDO = value; }
        }
        private string RevisedNo;

        public string RevisedNo1
        {
            get { return RevisedNo; }
            set { RevisedNo = value; }
        }
    }
}