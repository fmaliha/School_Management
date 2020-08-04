using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;



    public class BLProduct
    {

        
        public BLProduct()
        { 
        
        }

        public static long InsertProduct(BOProduct   objBO)
        {
            DAProduct  objDA = new DAProduct();
            return Convert.ToInt64(objDA.InsertProduct(objBO));
        }
    }
