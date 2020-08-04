using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_Dealer_DO_Account
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_Dealer_DO_Account(BOPBML_SDM_Dealer_DO_Account boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("CStartDate", boItem.CStartDate1);
                ht.Add("CEndDate", boItem.CEndDate1);
                ht.Add("DOAmount", boItem.DOAmount1);
                ht.Add("IncentiveAmount", boItem.IncentiveAmount1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("IsApproved", boItem.IsActive1);
                ht.Add("ApprovedBy", boItem.ApprovedBy1);
                ht.Add("ApprovedCooments", boItem.ApprovedComments1);
                ht.Add("ApprovedDate", boItem.ApprovedDate1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);




                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_Dealer_DO_Account"));

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

    }
}