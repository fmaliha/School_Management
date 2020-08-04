using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using PBSConnLib;
using System.Collections;


namespace InovexiaEBS
{
    public class DAACProduct
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertACProduct(BOACProduct boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("ProductCode", boItem.ProductCode1);
                ht.Add("ACode", boItem.ACode1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertACProduct"));

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}