using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_Supplier
    {
        private int SupplierID;

        public int SupplierID1
        {
            get { return SupplierID; }
            set { SupplierID = value; }
        }
        private string SupplierName;

        public string SupplierName1
        {
            get { return SupplierName; }
            set { SupplierName = value; }
        }
        private string Address;

        public string Address1
        {
            get { return Address; }
            set { Address = value; }
        }
        private string ContactPerson;

        public string ContactPerson1
        {
            get { return ContactPerson; }
            set { ContactPerson = value; }
        }
        private string ContactNumber;

        public string ContactNumber1
        {
            get { return ContactNumber; }
            set { ContactNumber = value; }
        }
        private int SerialNumber;

        public int SerialNumber1
        {
            get { return SerialNumber; }
            set { SerialNumber = value; }
        }
        private string CompanyID;

        public string CompanyID1
        {
            get { return CompanyID; }
            set { CompanyID = value; }
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