using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using PBSConnLib;
using System.Collections;


public class acml_da_purchase
{
    PBSDBUtility iDBUtility = new PBSDBUtility();

    public acml_da_purchase()
    {

    }

    public long insertpurchase(acml_bo_purchase boaddemp)
    {
        Hashtable ht = new Hashtable();


        ht.Add("pono", boaddemp.Pono);
        ht.Add("podate", boaddemp.Podate);
        ht.Add("spr_no", boaddemp.Spr_no);
        ht.Add("vendorid", boaddemp.Vendorid);
        ht.Add("company_id ", boaddemp.Company_id);
        ht.Add("login_id", boaddemp.Login_id);
        ht.Add("creationdate", boaddemp.Creationdate);
        ht.Add("modificationby", boaddemp.Modificationby);
        ht.Add("modificationdate", boaddemp.Modificationdate);
        ht.Add("pstatus", boaddemp.Pstatus);
        ht.Add("remarks", boaddemp.Remarks);
        ht.Add("paymentduration ", boaddemp.Paymentduration);
        ht.Add("deliverydate", boaddemp.Deliverydate);
        ht.Add("paymentmethod", boaddemp.Paymentmethod);

        return Convert.ToInt32(iDBUtility.InsertData(ht, "InsertPurchseMasterDCL"));

    }

    public long insertpurchase_detail(acml_bo_purchase boaddemp)
    {
        Hashtable ht = new Hashtable();

        ht.Add("pono", boaddemp.Pono);
        ht.Add("PrdID", boaddemp.Prdid);
        ht.Add("quantity", boaddemp.Quantity);
        ht.Add("unitprice", boaddemp.Unitprice);
        ht.Add("IsGRR", boaddemp.IsGRR1 );
        


        return Convert.ToInt32(iDBUtility.InsertData(ht, "InsertPurchseDetailDCL"));

    }



}
