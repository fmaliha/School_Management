using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_Product
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_Product(BOPBML_SDM_Product boItem)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("ProductCode", boItem.ProductCode1);
                ht.Add("ProductGroupCode", boItem.ProductGroupCode1);
                ht.Add("ProductTypeID", boItem.ProductTypeID1);
                ht.Add("ProductGrade", boItem.ProductGrade1);
                ht.Add("ProductName", boItem.ProductName1);
                ht.Add("VeneeerTypeID", boItem.VeneeerTypeID1);
                ht.Add("Thikness", boItem.Thikness1);
                ht.Add("Size", boItem.Size1);
                ht.Add("Color", boItem.Color1);
                ht.Add("UnitID", boItem.UnitID1);
                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_Product"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}