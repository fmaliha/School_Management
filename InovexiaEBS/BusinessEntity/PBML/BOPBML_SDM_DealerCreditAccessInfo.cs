using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_DealerCreditAccessInfo
    {

        private string DONO;

        public string DONO1
        {
            get { return DONO; }
            set { DONO = value; }
        }
        private string SONO;

        public string SONO1
        {
            get { return SONO; }
            set { SONO = value; }
        }
        private string DealerID;

        public string DealerID1
        {
            get { return DealerID; }
            set { DealerID = value; }
        }
        private string DealerName;

        public string DealerName1
        {
            get { return DealerName; }
            set { DealerName = value; }
        }
        private decimal AvailableBalance;

        public decimal AvailableBalance1
        {
            get { return AvailableBalance; }
            set { AvailableBalance = value; }
        }
        private decimal CreditLimit;

        public decimal CreditLimit1
        {
            get { return CreditLimit; }
            set { CreditLimit = value; }
        }
        private decimal DueAmount;

        public decimal DueAmount1
        {
            get { return DueAmount; }
            set { DueAmount = value; }
        }
        private decimal MRBalance;

        public decimal MRBalance1
        {
            get { return MRBalance; }
            set { MRBalance = value; }
        }
        private decimal CreditBalance;

        public decimal CreditBalance1
        {
            get { return CreditBalance; }
            set { CreditBalance = value; }
        }
        private decimal UsedCredit;

        public decimal UsedCredit1
        {
            get { return UsedCredit; }
            set { UsedCredit = value; }
        }
    }
}