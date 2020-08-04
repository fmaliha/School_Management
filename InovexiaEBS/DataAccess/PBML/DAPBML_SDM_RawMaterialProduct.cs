using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_RawMaterialProduct
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_RawMaterialProduct(BOPBML_SDM_RawMaterialProduct boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("RawMaterialProductID", boItem.RawMaterialProductID1);
                ht.Add("RawMaterialGroupID", boItem.RawMaterialGroupID1);
                ht.Add("RawMaterialProductName", boItem.RawMaterialProductName1);
                ht.Add("UnitID", boItem.UnitID1);
                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_RawMaterialProduct"));

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}