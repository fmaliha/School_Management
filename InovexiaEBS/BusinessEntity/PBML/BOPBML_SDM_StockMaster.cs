using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_StockMaster
    {


        private string StockTranID;

        public string StockTranID1
        {
            get { return StockTranID; }
            set { StockTranID = value; }
        }


        private string FGORDCID;

        public string FGORDCID1
        {
            get { return FGORDCID; }
            set { FGORDCID = value; }
        }

        private DateTime StockTranDate;

        public DateTime StockTranDate1
        {
            get { return StockTranDate; }
            set { StockTranDate = value; }
        }
        private int WhareHouseID;

        public int WhareHouseID1
        {
            get { return WhareHouseID; }
            set { WhareHouseID = value; }
        }

        private int SerialNumber;

        public int SerialNumber1
        {
            get { return SerialNumber; }
            set { SerialNumber = value; }
        }


        private int FGSerialNumber;

        public int FGSerialNumber1
        {
            get { return FGSerialNumber; }
            set { FGSerialNumber = value; }
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

        // FOR FG 
        private string FGID;

        public string FGID1
        {
            get { return FGID; }
            set { FGID = value; }
        }

        private DateTime FGDate;

        public DateTime FGDate1
        {
            get { return FGDate; }
            set { FGDate = value; }
        }
    }
}