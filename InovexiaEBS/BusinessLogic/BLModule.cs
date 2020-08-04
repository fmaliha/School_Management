using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for BLModule
/// </summary>
public class BLModule
{
	public BLModule()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static long InsertModule(BOCommon objBO)
    {
        DAModule objDA = new DAModule();
        return Convert.ToInt64(objDA.InsertModule(objBO));
    }
}
