using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_ProductionQC
    {
        private int QCAutoID;

        public int QCAutoID1
        {
            get { return QCAutoID; }
            set { QCAutoID = value; }
        }
        private string QCID;

        public string QCID1
        {
            get { return QCID; }
            set { QCID = value; }
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
        private int ProductGradeID;

        public int ProductGradeID1
        {
            get { return ProductGradeID; }
            set { ProductGradeID = value; }
        }
        private decimal QCQuantity;

        public decimal QCQuantity1
        {
            get { return QCQuantity; }
            set { QCQuantity = value; }
        }


        private DateTime QCDate;
        public DateTime QCDate1
        {
            get { return QCDate; }
            set { QCDate = value; }
        }

        private Boolean IsStore;

        public Boolean IsStore1
        {
            get { return IsStore; }
            set { IsStore = value; }
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


        private int SerialNumber;
        public int SerialNumber1
        {
            get { return SerialNumber; }
            set { SerialNumber = value; }
        }


        private int YYear;
        public int YYear1
        {
            get { return YYear; }
            set { YYear = value; }
        }

        private string CompanyID;
        public string CompanyID1
        {
            get { return CompanyID; }
            set { CompanyID = value; }
        }

        private int ShiftID;
        public int ShiftID1
        {
            get { return ShiftID; }
            set { ShiftID = value; }
        }

    }
}