using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_ProductPriceForDealer
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long PBML_SDM_ProductPriceForDealer(BOPBML_SDM_ProductPriceForDealer boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("ProductCode", boItem.ProductCode1);
                ht.Add("PCODE", boItem.PCODE1);
                ht.Add("Rate", boItem.Rate1);
                ht.Add("StartDate", boItem.StartDate1);
                ht.Add("EndDate", boItem.EndDate1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);




                return Convert.ToInt64(idbutility.InsertData(ht, "spInsert_ProductPriceForDealer"));

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}