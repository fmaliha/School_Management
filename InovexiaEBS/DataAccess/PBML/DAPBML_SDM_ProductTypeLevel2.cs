using System;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_ProductTypeLevel2
    {
        PBSDBUtility idbutility = new PBSDBUtility();

        public long InsertPBML_SDM_ProductTypeLevel2(BOPBML_SDM_ProductTypeLevel2 boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("ProductSubTypeName", boItem.ProductSubTypeName1);
                ht.Add("ProductSubTypeCode", boItem.ProductSubTypeCode1);
                ht.Add("ProductMasterTypeID", boItem.ProductMasterTypeID1);
                ht.Add("ProductTypeID", boItem.ProductTypeID1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);



                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_ProductTypeLevel2"));

            }
            catch (Exception ex)
            {
                throw ex;


            }

        }
    }
}