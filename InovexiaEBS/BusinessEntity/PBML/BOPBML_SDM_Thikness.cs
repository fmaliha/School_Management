using System;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_Thikness
    {
        private int ThiknessID;
        public int ThiknessID1
        {
            get { return ThiknessID; }
            set { ThiknessID = value; }
        }

        private string ThiknessName;
        public string ThiknessName1
        {
            get { return ThiknessName; }
            set { ThiknessName = value; }
        }

        public string ThiknessUnit;
        public string ThiknessUnit1
        {
            get { return ThiknessUnit; }
            set { ThiknessUnit = value; }
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