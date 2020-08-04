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

/// <summary>
/// Summary description for DASpr
/// </summary>
public class DASpr
{
    PBSDBUtility iDBUtility = new PBSDBUtility();

    public DASpr()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public long InsertData(BOSpr objspr)
    {
        Hashtable ht = new Hashtable();

        ht.Add("id", objspr.Id);
        ht.Add("spr_no ", objspr.Spr_no);
        ht.Add("company_id ", objspr.Company_id);
        ht.Add("dept_id", objspr.Dept_id);
        ht.Add("login_id ", objspr.Login_id);
        ht.Add("spr_date", objspr.Spr_date);
        ht.Add("ending_date", objspr.Ending_date);
        ht.Add("status", objspr.Status);
        return Convert.ToInt32(iDBUtility.InsertData(ht, "spInsertSPRMasterDCL"));


    }

    public long In_Spr_details(BOSpr objspr)
    {

        Hashtable ht = new Hashtable();

        ht.Add("id", objspr.Id );
        ht.Add("MRFNo", objspr.MRFNo1 );
        ht.Add("ProductID", objspr.Product_id);
        ht.Add("quantity_req", objspr.Quantity_required);
        ht.Add("est_unit_price", objspr.Est_unit_price);
        ht.Add("last_punit_price", objspr.Last_punit_price);
        ht.Add("mrr_no", objspr.Mrr_no);
        ht.Add("mrr_date", objspr.Mrr_date);
        ht.Add("mrr_qty", objspr.Mrr_qty);
        ht.Add("stock", objspr.Stock_qty);
        ht.Add("remarks", objspr.Remarks);
        ht.Add("IsPurchase", objspr.IsPurchase1);
        return Convert.ToInt32(iDBUtility.InsertData(ht, "spInsertSPRDetailDCL"));

    }

    public DataTable ProductName(string storecode)
    {

        DataTable DTab = iDBUtility.GetDataBySQLString("SELECT distinct PrdID, PrdName FROM  acml_facproducts WHERE   store_code = '" + storecode + "'");

        return DTab;
    }

    public DataTable ProductList()
    {

        DataTable DTab = iDBUtility.GetDataBySQLString("SELECT PrdName FROM  acml_facproducts order by PrdName ");
        return DTab;
    }




}
