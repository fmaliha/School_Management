using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_RawMaterialStockIn
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_RawMaterialStockIn(BOPBML_SDM_RawMaterialStockIn boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("RMID", boItem.RMID1);
                ht.Add("RawMaterialProductID", boItem.RawMaterialProductID1);
                ht.Add("Quantity", boItem.Quantity1);
                ht.Add("Rate", boItem.Rate1);
                ht.Add("PurchaseDate", boItem.PurchaseDate1);
                ht.Add("SupplierID", boItem.SupplierID1);
                ht.Add("PYear", boItem.PYear1);
                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_RawMaterialStockIn"));

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}