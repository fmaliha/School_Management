using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS
{
    public class BOCostCenter
    {
        public BOCostCenter()
	    {
		//
		// TODO: Add constructor logic here
		//
        }
        private Boolean Transfered;
        public Boolean Transfered1
        {
            get { return Transfered; }
            set { Transfered = value; }
        }
        private string AddedBy;

        public string AddedBy1
        {
            get { return AddedBy; }
            set { AddedBy = value; }
        }

        private DateTime DateAdded;

        public DateTime DateAdded1
        {
            get { return DateAdded; }
            set { DateAdded = value; }
        }

        private string UpdatedBy;

        public string UpdatedBy1
        {
            get { return UpdatedBy; }
            set { UpdatedBy = value; }
        }

        private DateTime DateUpdated;

        public DateTime DateUpdated1
        {
            get { return DateUpdated; }
            set { DateUpdated = value; }
        }

        private int costCenterCode = 0;

        public int CostCenterCode
        {
            get { return costCenterCode; }
            set { costCenterCode = value; }
        }

          private string costCenterName = null;
          public string CostCenterName
           {
            get { return costCenterName; }
            set { costCenterName = value; }
           }


          private string companyId = null;
          public string CompanyID
          {
              get { return companyId; }
              set { companyId = value; }
          }
    }
}