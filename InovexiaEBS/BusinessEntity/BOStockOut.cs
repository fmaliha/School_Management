using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS
{
    public class BOStockOut
    {
        private string SRJVNO;
        public string SRJVNO1
        {
            get { return SRJVNO; }
            set { SRJVNO = value; }
        }
 
        private DateTime SRJVDate;
        public DateTime SRJVDate1
        {
            get { return SRJVDate; }
            set { SRJVDate = value; }
        }

        private string SRNO;
        public string SRNO1
        {
            get { return SRNO; }
            set { SRNO = value; }
        }

        private string company_id;
        public string Company_id
        {
            get { return company_id; }
            set { company_id = value; }
        }

        private string purpose;
        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }

        private string workDescription;
        public string WorkDescription
        {
            get { return workDescription; }
            set { workDescription = value; }
        }

        private string Narration;
        public string Narration1
        {
            get { return Narration; }
            set { Narration = value; }
        }

        private string whoWillUse;
        public string WhoWillUse
        {
            get { return whoWillUse; }
            set { whoWillUse = value; }
        }

        private string aCode;
        public string ACode
        {
            get { return aCode; }
            set { aCode = value; }
        }


        private int ProductID;
        public int ProductID1
        {
            get { return ProductID; }
            set { ProductID = value; }
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
        private double value;
        public double Value
        {
            get { return value; }
            set { value = value; }
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

        private int SRVSerial;
        public int SRVSerial1
        {
            get { return SRVSerial; }
            set { SRVSerial = value; }
        }
    }
}