using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;


namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_ProductGroup
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_ProductGroup(BOPBML_SDM_ProductGroup boItem)
        {
            try
            {

                var ht = new Hashtable();
                ht.Add("ProductGroupID", boItem.ProductGroupID1);
                ht.Add("ProductGroupCode", boItem.ProductGroupCode1);
                ht.Add("ProductGroupName", boItem.ProductGroupName1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_ProductGroup"));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}