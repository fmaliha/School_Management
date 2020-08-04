using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_Supplier
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_Supplier(BOPBML_SDM_Supplier boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("SupplierID", boItem.SupplierID1);
                ht.Add("SupplierName", boItem.SupplierName1);
                ht.Add("Address", boItem.Address1);
                ht.Add("ContactPerson", boItem.ContactPerson1);
                ht.Add("ContactNumber", boItem.ContactNumber1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
         

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_Supplier"));

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}