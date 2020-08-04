using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_Incentive
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_Incentive(BOPBML_SDM_Incentive boItem)
        {



            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("IncentiveID", boItem.IncentiveID1);
                ht.Add("IncentiveName", boItem.IncentiveName1);
                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("DOAmountMin", boItem.DOAmountMin1);
                ht.Add("DOAmountMax", boItem.DOAmountMax1);
                ht.Add("IncentiveAmount", boItem.IncentiveAmount1);
                ht.Add("StartDate", boItem.StartDate1);
                ht.Add("EndDate", boItem.EndDate1);
                ht.Add("ApprovedBY", boItem.ApprovedBY1);
                ht.Add("ApprovalDateTime", boItem.ApprovalDateTime1);
                ht.Add("ApprovalComments", boItem.ApprovalComments1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);



                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_Incentive"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}