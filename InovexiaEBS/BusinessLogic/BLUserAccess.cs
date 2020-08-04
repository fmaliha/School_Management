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
/// Summary description for BLUserAccess
/// </summary>
public class BLUserAccess
{
	public BLUserAccess()
	{
		//
		// TODO: Add constructor logic here
        //Modifier By Rezaul
	}

    public static DataTable GetAllUsers()
    {
        DAUserAccess objDA = new DAUserAccess();
        DataTable DTab = objDA.GetAllUsers();       
        return DTab;
    }

    public static DataTable GetAllModules()
    {
        DAUserAccess objDA = new DAUserAccess();
        DataTable DTab = objDA.GetAllModules();
        return DTab;
    }



//for tree populate
    //public static DataTable Getmodul(int a)
    //{
    //    DAUserAccess objDA = new DAUserAccess();
    //    DataTable DTabmod = objDA.Gemodulelist(a);
    //    return DTabmod;
    //}

    public static DataTable UserId(BOUserAccess   userinfo)
    {
        DAUserAccess objDA = new DAUserAccess();
        DataTable DTabUserid = objDA.UserId(userinfo);
        return DTabUserid;
    }

    //public static DataTable Getmen(int pin,int mod )
    //{
    //    DAUserAccess objDA = new DAUserAccess();
    //    DataTable DTabmen = objDA.Gemenulist(pin,mod);
    //    return DTabmen;
    //}

    //public static DataTable Getscreen(int pin,int mod,int men)
    //{
    //    DAUserAccess objDA = new DAUserAccess();
    //    DataTable DTAMScreen = objDA.Gescreenlist(pin, mod, men);
    //    return DTAMScreen;
    //}

    //public static DataTable GetPageName(int code)
    //{
    //    DAUserAccess objDA = new DAUserAccess();
    //    DataTable DTabPage = objDA.GetPageName(code);
    //    return DTabPage;
    //}

    //public static DataTable GetPageNamePermited(int pin_number)
    //{
    //    DAUserAccess objDA = new DAUserAccess();
    //    DataTable DTabPagepermited = objDA.GetPagepermited(pin_number);
    //    return DTabPagepermited;
    //}


    //public static DataTable Getuserasalistgrid()
    //{
        
    //    DAUserAccess objDA1 = new DAUserAccess();
    //    DataTable DTab = objDA1.Getuserdetailslistgrid();        
    //    return DTab;
    //}

    //public DataTable getmenu(int pin_numbner)
    //{
    //    DAUserAccess objDA = new DAUserAccess();
    //    DataTable DTab = objDA.Getuserdetailslist(pin_numbner);        
    //    return DTab;
    //}

    //public static long Insertuserpermission(BOUserAccess  objBO)
    //{
    //    DAUserAccess objDA = new DAUserAccess();
    //    return Convert.ToInt64(objDA.Insertuserpermission (objBO));
    //}

}
