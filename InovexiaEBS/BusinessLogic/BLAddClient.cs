using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;



public class BLAddClient
{


    public BLAddClient()
    {

    }

    public static long InsertClient(BOAddClient  objBO)
    {
        DAddClient objDA = new DAddClient();
        return Convert.ToInt64(objDA.InsertClient(objBO));
    }

    


    public static long InsertInitialClient(BOInitialClient  objBO)
    {
        DAddClient objDA = new DAddClient();
        return Convert.ToInt64(objDA.InsertInitialClient(objBO));
    }


    public static long InsertFollowup(BOFollowUP  objBO)
    {
        DAddClient objDA = new DAddClient();
        return Convert.ToInt64(objDA.InsertFollowup(objBO));
    }

    public static long InsertApplication(BOApplication  objBO)
    {
        DAddClient objDA = new DAddClient();
        return Convert.ToInt64(objDA.InsertApplication(objBO));
    }




}
