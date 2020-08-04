using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_Production
    {

        private int ProductionAutoID;

        public int ProductionAutoID1
        {
            get { return ProductionAutoID; }
            set { ProductionAutoID = value; }
        }


        private int ShiftID;

        public int ShiftID1
        {
            get { return ShiftID; }
            set { ShiftID = value; }
        }



        private string ProductionID;

        public string ProductionID1
        {
            get { return ProductionID; }
            set { ProductionID = value; }
        }
        private int ProductGroupID;

        public int ProductGroupID1
        {
            get { return ProductGroupID; }
            set { ProductGroupID = value; }
        }
        private int ThiknessID;

        public int ThiknessID1
        {
            get { return ThiknessID; }
            set { ThiknessID = value; }
        }
        private int SizeID;

        public int SizeID1
        {
            get { return SizeID; }
            set { SizeID = value; }
        }
        private string ColorCode;

        public string ColorCode1
        {
            get { return ColorCode; }
            set { ColorCode = value; }
        }
        private int UnitID;

        public int UnitID1
        {
            get { return UnitID; }
            set { UnitID = value; }
        }
        private decimal ProductionQuantity;

        public decimal ProductionQuantity1
        {
            get { return ProductionQuantity; }
            set { ProductionQuantity = value; }
        }


        private DateTime ProductionDate;
        public DateTime ProductionDate1
        {
            get { return ProductionDate; }
            set { ProductionDate = value; }
        }

        private Boolean IsQC;

        public Boolean IsQC1
        {
            get { return IsQC; }
            set { IsQC = value; }
        }

        private string CompanyID;

        public string CompanyID1
        {
            get { return CompanyID; }
            set { CompanyID = value; }
        }
        private int YYear;

        public int YYear1
        {
            get { return YYear; }
            set { YYear = value; }
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
    }
}