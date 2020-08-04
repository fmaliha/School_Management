using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_Product
    {
        private string ProductCode;

        public string ProductCode1
        {
            get { return ProductCode; }
            set { ProductCode = value; }
        }
        private string ProductGroupCode;

        public string ProductGroupCode1
        {
            get { return ProductGroupCode; }
            set { ProductGroupCode = value; }
        }
        private int ProductTypeID;

        public int ProductTypeID1
        {
            get { return ProductTypeID; }
            set { ProductTypeID = value; }
        }

        //private int ProductSubTypeID;

        //public int ProductSubTypeID1
        //{
        //    get { return ProductSubTypeID; }
        //    set { ProductSubTypeID = value; }
        //}
        private string ProductName;

        public string ProductName1
        {
            get { return ProductName; }
            set { ProductName = value; }
        }

        private string ProductGrade;

        public string ProductGrade1
        {
            get { return ProductGrade; }
            set { ProductGrade = value; }
        }


        private int VeneeerTypeID;

        public int VeneeerTypeID1
        {
            get { return VeneeerTypeID; }
            set { VeneeerTypeID = value; }
        }

        private string Thikness;

        public string Thikness1
        {
            get { return Thikness; }
            set { Thikness = value; }
        }
        private string Size;

        public string Size1
        {
            get { return Size; }
            set { Size = value; }
        }
        private string Color;

        public string Color1
        {
            get { return Color; }
            set { Color = value; }
        }
        private int UnitID;

        public int UnitID1
        {
            get { return UnitID; }
            set { UnitID = value; }
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