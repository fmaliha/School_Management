using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_ProductPriceForDealer
    {
        private string  DealerID;
private string  ProductCode;
private string  PCODE;
private  decimal Rate;
private  DateTime StartDate;
private DateTime  EndDate;
private  Boolean IsActive;
private string  CreatedBy;
private  DateTime CreatedDate;
private string  UpdatedBy;
private DateTime  UpdatedDate;

        public string DealerID1
        {
            get { return DealerID; }
            set { DealerID = value; }
        }

        public string ProductCode1
        {
            get { return ProductCode; }
            set { ProductCode = value; }
        }

        public string PCODE1
        {
            get { return PCODE; }
            set { PCODE = value; }
        }

        public decimal Rate1
        {
            get { return Rate; }
            set { Rate = value; }
        }

        public DateTime StartDate1
        {
            get { return StartDate; }
            set { StartDate = value; }
        }

        public DateTime EndDate1
        {
            get { return EndDate; }
            set { EndDate = value; }
        }

        public bool IsActive1
        {
            get { return IsActive; }
            set { IsActive = value; }
        }

        public string CreatedBy1
        {
            get { return CreatedBy; }
            set { CreatedBy = value; }
        }

        public DateTime CreatedDate1
        {
            get { return CreatedDate; }
            set { CreatedDate = value; }
        }

        public string UpdatedBy1
        {
            get { return UpdatedBy; }
            set { UpdatedBy = value; }
        }

        public DateTime UpdatedDate1
        {
            get { return UpdatedDate; }
            set { UpdatedDate = value; }
        }
    }
}