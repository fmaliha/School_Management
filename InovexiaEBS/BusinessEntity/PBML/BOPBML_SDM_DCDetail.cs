using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_DCDetail
    {
        private string DCNO;

        public string DCNO1
        {
            get { return DCNO; }
            set { DCNO = value; }
        }
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
        private decimal DOQuantity;

        public decimal DOQuantity1
        {
            get { return DOQuantity; }
            set { DOQuantity = value; }
        }


        private decimal BalanceQuantity;

        public decimal BalanceQuantity1
        {
            get { return BalanceQuantity; }
            set { BalanceQuantity = value; }
        }

        private decimal Rate;

        public decimal Rate1
        {
            get { return Rate; }
            set { Rate = value; }
        }
        private decimal ChallanQuantity;

        public decimal ChallanQuantity1
        {
            get { return ChallanQuantity; }
            set { ChallanQuantity = value; }
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

        private int Count;
        public int Count1
        {
            get { return Count; }
            set { Count = value; }
        }
    }
}