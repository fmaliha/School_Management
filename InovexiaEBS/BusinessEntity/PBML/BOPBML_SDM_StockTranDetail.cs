using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_StockTranDetail
    {
        private string StockTranID;

        public string StockTranID1
        {
            get { return StockTranID; }
            set { StockTranID = value; }
        }
        private string ProuductCode;

        public string ProuductCode1
        {
            get { return ProuductCode; }
            set { ProuductCode = value; }
        }
        private decimal Quantity;

        public decimal Quantity1
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        private string TransactionType;

        public string TransactionType1
        {
            get { return TransactionType; }
            set { TransactionType = value; }
        }
        private string EntryNO;

        public string EntryNO1
        {
            get { return EntryNO; }
            set { EntryNO = value; }
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

        private Boolean IsStockIn;

        public Boolean IsStockIn1
        {
            get { return IsStockIn; }
            set { IsStockIn = value; }
        }
        // for FG DETAIL

        private string FGID;

        public string FGID1
        {
            get { return FGID; }
            set { FGID = value; }
        }
    }
}