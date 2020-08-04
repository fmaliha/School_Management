using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_Discount
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_Discount(BOPBML_SDM_Discount boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("DiscountID", boItem.DiscountID1);
                ht.Add("DiscountName", boItem.DiscountName1);
                ht.Add("ProductCode", boItem.ProductCode1);
                ht.Add("DiscountProductCode", boItem.DiscountProductCode1);
                ht.Add("MinBuyQuantity", boItem.MinBuyQuantity1);
                ht.Add("MaxBuyQuantity", boItem.MaxBuyQuantity1);
                ht.Add("DiscountQuantity", boItem.DiscountQuantity1);
                ht.Add("StartDate", boItem.StartDate1);
                ht.Add("EndDate", boItem.EndDate1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CraetedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);






                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_Discount"));




            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}