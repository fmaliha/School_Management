using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_ProductToRMConfig
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_ProductToRMConfig(BOPBML_SDM_ProductToRMConfig boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("ProductGoupID", boItem.ProductGoupID1);
                ht.Add("ThiknessID", boItem.ThiknessID1);
                ht.Add("SizeID", boItem.SizeID1);
                ht.Add("ColorCode", boItem.ColorCode1);
                ht.Add("UnitID", boItem.UnitID1);
                ht.Add("RawMaterialProductID", boItem.RawMaterialProductID1);
                ht.Add("RowMeterialQuantity", boItem.RowMeterialQuantity1);
                ht.Add("ConfigurationDate", boItem.ConfigurationDate1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_ProductToRMConfig"));

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}