using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_SODetail
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_SODetail(BOPBML_SDM_SODetail boItem)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("SONO", boItem.SONO1);
                ht.Add("ProductCode", boItem.ProductCode1);
                ht.Add("Quantity", boItem.Quantity1);
                ht.Add("Rate", boItem.Rate1);
                ht.Add("DiscountID", boItem.DiscountID1);
                ht.Add("DiscountQuantity", boItem.DiscountQuantity1);
                ht.Add("IsDO", boItem.IsDO1);
                ht.Add("IsIncentive", boItem.IsIncentive1);
                ht.Add("IncentiveCalculateDate", boItem.IncentiveCalculateDate1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);



                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_SODetail"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}