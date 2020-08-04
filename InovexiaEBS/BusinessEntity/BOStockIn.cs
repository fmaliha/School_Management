using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS
{
    public class BOStockIn
    {
        private string PJVNO;

        public string PJVNO1
        {
            get { return PJVNO; }
            set { PJVNO = value; }
        }

        private DateTime PJVDate;

        public DateTime PJVDate1
        {
            get { return PJVDate; }
            set { PJVDate = value; }
        }

        private string company_id;

        public string Company_id
        {
            get { return company_id; }
            set { company_id = value; }
        }


        private string Narration;

        public string Narration1
        {
            get { return Narration; }
            set { Narration = value; }
        }

        private string ACodeTo;

        public string ACode1To
        {
            get { return ACodeTo; }
            set { ACodeTo = value; }
        }

        private string ACodeBy;

        public string ACode1By
        {
            get { return ACodeBy; }
            set { ACodeBy = value; }
        }


        private int ProductID;

        public int ProductID1
        {
            get { return ProductID; }
            set { ProductID = value; }
        }

        private int WareHouseID;

        public int WareHouseID1
        {
            get { return WareHouseID; }
            set { WareHouseID = value; }
        }

        private double Rate;

        public double Rate1
        {
            get { return Rate; }
            set { Rate = value; }
        }


        private double Quantity;

        public double Quantity1
        {
            get { return Quantity; }
            set { Quantity = value; }
        }


        private string EntryID;

        public string EntryID1
        {
            get { return EntryID; }
            set { EntryID = value; }
        }

        private DateTime EntryDate;

        public DateTime EntryDate1
        {
            get { return EntryDate; }
            set { EntryDate = value; }
        }

        private string UpdateID;

        public string UpdateID1
        {
            get { return UpdateID; }
            set { UpdateID = value; }
        }

        private DateTime UpdateDate;

        public DateTime UpdateDate1
        {
            get { return UpdateDate; }
            set { UpdateDate = value; }
        }



        private int VMonth;

        public int VMonth1
        {
            get { return VMonth; }
            set { VMonth = value; }
        }
        private int VYear;

        public int VYear1
        {
            get { return VYear; }
            set { VYear = value; }
        }

        private int PVSerial;
        public int PVSerial1
        {
            get { return PVSerial; }
            set { PVSerial = value; }
        }
    }
}