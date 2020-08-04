using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_MRMaster
    {


        private decimal ReverseAmount;

        public decimal ReverseAmount1
        {
            get { return ReverseAmount; }
            set { ReverseAmount = value; }
        }


        private string MRNO;

        public string MRNO1
        {
            get { return MRNO; }
            set { MRNO = value; }
        }
        private string DealerID;

        public string DealerID1
        {
            get { return DealerID; }
            set { DealerID = value; }
        }
        private DateTime MRDate;

        public DateTime MRDate1
        {
            get { return MRDate; }
            set { MRDate = value; }
        }
        private string Acode;

        public string Acode1
        {
            get { return Acode; }
            set { Acode = value; }
        }
        private decimal Amount;

        public decimal Amount1
        {
            get { return Amount; }
            set { Amount = value; }
        }
        private string PaymentMode;

        public string PaymentMode1
        {
            get { return PaymentMode; }
            set { PaymentMode = value; }
        }
        private string BankID;

        public string BankID1
        {
            get { return BankID; }
            set { BankID = value; }
        }
        private string CheckNo;

        public string CheckNo1
        {
            get { return CheckNo; }
            set { CheckNo = value; }
        }
        private string CheckDate;

        public string CheckDate1
        {
            get { return CheckDate; }
            set { CheckDate = value; }
        }
        private string CollectionDate;

        public string CollectionDate1
        {
            get { return CollectionDate; }
            set { CollectionDate = value; }
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


        private int Year;

        public int Year1
        {
            get { return Year; }
            set { Year = value; }
        }


        // FOR ChequeInfo table

        private string ChequePostingID;

        public string ChequePostingID1
        {
            get { return ChequePostingID; }
            set { ChequePostingID = value; }
        }
        private DateTime PostingDate;

        public DateTime PostingDate1
        {
            get { return PostingDate; }
            set { PostingDate = value; }
        }

       
        private string ChequeType;

        public string ChequeType1
        {
            get { return ChequeType; }
            set { ChequeType = value; }
        }
        private string BranchName;

        public string BranchName1
        {
            get { return BranchName; }
            set { BranchName = value; }
        }
        private string Remarks;

        public string Remarks1
        {
            get { return Remarks; }
            set { Remarks = value; }
        }
        private Boolean IsMR;

        public Boolean IsMR1
        {
            get { return IsMR; }
            set { IsMR = value; }
        }

        private int ChequeStatus;

        public int ChequeStatus1
        {
            get { return ChequeStatus; }
            set { ChequeStatus = value; }
        }

    }
}