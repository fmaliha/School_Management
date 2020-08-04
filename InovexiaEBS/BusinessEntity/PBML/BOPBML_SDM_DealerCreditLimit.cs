using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_DealerCreditLimit
    {
        private string DealerID;

        public string DealerID1
        {
            get { return DealerID; }
            set { DealerID = value; }
        }
        private decimal CreditLimit;

        public decimal CreditLimit1
        {
            get { return CreditLimit; }
            set { CreditLimit = value; }
        }


        private DateTime CreditLimitDate;

        public DateTime CreditLimitDate1
        {
            get { return CreditLimitDate; }
            set { CreditLimitDate = value; }
        }

        private int CreditDuration;

        public int CreditDuration1
        {
            get { return CreditDuration; }
            set { CreditDuration = value; }
        }

        private int categoryID;

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }



        private DateTime PaymentDate;

        public DateTime PaymentDate1
        {
            get { return PaymentDate; }
            set { PaymentDate = value; }
        }


        private Boolean ISValid;

        public Boolean ISValid1
        {
            get { return ISValid; }
            set { ISValid = value; }
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