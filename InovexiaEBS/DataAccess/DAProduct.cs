using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using System.Collections.Generic;
using PBSConnLib;



    public class DAProduct
    {

    PBSDBUtility  idbutility  = new PBSDBUtility();

        public DAProduct()
        { 
        
        }

        public long InsertProduct(BOProduct   objBO)
        {


            
            try
            {




                 Hashtable ht = new Hashtable();
                 ht.Add("ProductID", objBO.ProductID1 );
                 ht.Add("ProductCode",objBO.ProductCode1 );
                 ht.Add("TypeID", objBO.TypeID1 );
                 ht.Add("CategoryID", objBO.CategoryID1 );
                 ht.Add("ProductName", objBO.ProductName1 );
                 ht.Add("UnitID", objBO.UnitID1  );
                 ht.Add("Model", objBO.Model1 );
                 ht.Add("IsVat", objBO.IsVat1);
                 ht.Add("SizeID", objBO.SizeID1);
                 ht.Add("ColorID", objBO.ColorID1);
                 ht.Add("ThicknessID", objBO.ThicknessID1);
                 ht.Add("SideID", objBO.SideID1);
                 ht.Add("IsService", objBO.IsService1);
                 ht.Add("IsActive", objBO.IsActive1);
                 ht.Add("EntryID", objBO.EntryID1);
                 ht.Add("EntryDate", objBO.EntryDate1);
                 ht.Add("UpdateID", objBO.UpdateID1);
                 ht.Add("UpdateDate", objBO.UpdateDate1);
                 ht.Add("VATpercent", objBO.VATpercent1);

                

                 return Convert.ToInt64(idbutility.InsertData(ht, "spInsertProduct"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
