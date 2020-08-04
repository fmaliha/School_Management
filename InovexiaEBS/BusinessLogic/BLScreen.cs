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
/// Summary description for BLScreen
/// </summary>
public class BLScreen
{
	public BLScreen()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static long InsertScreen(BOScreen objBO)
    {
        DAScreen objDA = new DAScreen();
        return Convert.ToInt64(objDA.InsertScreen(objBO));
    }
    public static DataTable GetAllScreenList()
    {
        DAScreen objDA = new DAScreen();
        DataTable Dtab = objDA.GetScreenList();
        return Dtab;
    }
    public static DataTable GetMenuCodeforScreen( string code)
    {
        DAScreen objDA = new DAScreen();
        DataTable Dtab = objDA.GetMenuCodeforScreen(code);
        return Dtab;
    }
    public static DataTable GetDisplayORFromNameforScreen(string code)
    {
        DAScreen objDA = new DAScreen();
        DataTable Dtab = objDA.GetDisplayORFromNameforScreen(code);
        return Dtab;
    }
    public static DataTable GetModuleCodeforScreen()
    {
        DAScreen objDA = new DAScreen ();
        DataTable Dtab = objDA.GetModuleCodeforScreen();
        return Dtab;
    }
}
