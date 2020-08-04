using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using PBSConnLib;
using System.Data;

namespace InovexiaEBS
{
    public class DACostCenter
    {
        PBSDBUtility iDBUtility = new PBSDBUtility();
        public DACostCenter()
	    {
		//
		// TODO: Add constructor logic here
		//
	    }
        public long InsertCostCenter(BOCostCenter boCostCenter)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("CostCenterCode", boCostCenter.CostCenterCode);
                ht.Add("CostCenterName", boCostCenter.CostCenterName);
                ht.Add("Transfered ", boCostCenter.Transfered1);
                ht.Add("AddedBy", boCostCenter.AddedBy1);
                ht.Add("DateAdded ", boCostCenter.DateAdded1);
                ht.Add("UpdatedBy", boCostCenter.UpdatedBy1);
                ht.Add("DateUpdated", boCostCenter.DateUpdated1);
                ht.Add("CompanyId", boCostCenter.CompanyID);

                return Convert.ToInt64(iDBUtility.InsertData(ht, "dbo.spInsertCostCenter"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetUserCompany(string loginID)
        {
            try
            {
             
                Hashtable ht = new Hashtable();
                ht.Add("UserLoginId", loginID);
                return iDBUtility.GetDataByProc(ht, "dbo.spUserCompany");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}