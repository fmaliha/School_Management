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


/// <summary>
/// Summary description for BLSpr
/// </summary>
public class BLSpr
{
    //DASpr daspr = new DASpr();

    public BLSpr()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static long SprInsert(BOSpr objspr)
    {
        DASpr daspr = new DASpr();
        return Convert.ToInt64(daspr.InsertData(objspr));
    }

    public static long SprdetailsInsert(BOSpr objsprdtls)
    {
        DASpr daspr = new DASpr();
        return Convert.ToInt64(daspr.In_Spr_details(objsprdtls));

    }


    public static DataTable ProductName(string storecode)
    {
        DASpr daspr = new DASpr();

        DataTable DTab = daspr.ProductName(storecode);
        return DTab;
    }

    public static DataTable ProductList()
    {
        DASpr daspr = new DASpr();

        DataTable DTab = daspr.ProductList();
        return DTab;
    }
}
