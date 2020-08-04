using System;
using System.Collections;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for BOTheme
/// </summary>
public class BOTheme
{
	public BOTheme()
	{
		//
		// TODO: Add constructor logic here
        //Rezaul
	}

    private string themename = null;

    public string Themename
    {
        get { return themename; }
        set { themename = value; }
    }

    
    
}
public class ThemeList : CollectionBase
{
    public ThemeList()
    {
        InnerList.Clear();
    }
    public void AddToList(BOTheme objBO)
    {
        InnerList.Add(objBO);

    }
}