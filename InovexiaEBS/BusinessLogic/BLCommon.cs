using System;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
/// <summary>
/// Summary description for BLCommon
/// </summary>
public class BLCommon
{
	public BLCommon()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    

    public static ThemeList GetThemes()
    {
        return DACommon.GetThemes(); 
    
    }
   
}
