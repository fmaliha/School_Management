using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;


     
    public class DAPBML_SDM_ProductPrice
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_ProductPrice(BOPBML_SDM_ProductPrice boItem)
        {
          try
            {

                Hashtable ht = new Hashtable();
                ht.Add("ProductID", boItem.ProductID1);
                ht.Add("PRate", boItem.PRate1);
                ht.Add("Showroomprice", boItem.Showroomprice1);
                ht.Add("DiscountPercentage", boItem.DiscountPrice1);
                ht.Add("StartDate", boItem.StartDate1);
                ht.Add("EndDate", boItem.EndDate1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);



                return Convert.ToInt64(idbutility.InsertData(ht, "sp_insert_productprice"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
    }
