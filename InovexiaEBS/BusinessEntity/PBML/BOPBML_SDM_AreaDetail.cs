using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBS.BusinessEntity.PBML
{
    public class BOPBML_SDM_AreaDetail
    {
        private int AreaID;

        public int AreaID1
        {
            get { return AreaID; }
            set { AreaID = value; }
        }
        private string EmployeeCode;

        public string EmployeeCode1
        {
            get { return EmployeeCode; }
            set { EmployeeCode = value; }
        }
        private DateTime StartDate;

        public DateTime StartDate1
        {
            get { return StartDate; }
            set { StartDate = value; }
        }
        private DateTime EndDate;

        public DateTime EndDate1
        {
            get { return EndDate; }
            set { EndDate = value; }
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