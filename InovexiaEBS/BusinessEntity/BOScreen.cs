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
/// Summary description for BOScreen
/// </summary>
public class BOScreen
{
    private string code = null;

    public string Code
    {
        get { return code; }
        set { code = value; }
    }
    private string name = null;

    private string creator = null;

    public string Creator
    {
        get { return creator; }
        set { creator = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private string description = null;

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

	public BOScreen()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
