using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using PBSConnLib;
using System.Collections;


public class DAUserAccess
{
    PBSDBUtility objJMSUtility = new PBSDBUtility();
    
	public DAUserAccess()
	{
		
	}

    public DataTable Getuserdetailslist(int cde)
    {
        
        DataTable DTab = objJMSUtility.GetDataBySQLString("select * from user_t where pin_number=" + cde + "");
        return DTab;
    }
    public DataTable Gemodulelist(int pin)
    {
        
        DataTable DTabModule = objJMSUtility.GetDataBySQLString("select distinct module_code,module_name from menuaccess_t where pin_number=" + pin + " order by module_name ASC");
        return DTabModule;
    }


    public DataTable UserId(BOUserAccess  boaddemp)
    {
        Hashtable ht = new Hashtable();
        ht.Add("login_id", boaddemp.Login_id );
        ht.Add("password", boaddemp.Password);
        return objJMSUtility.GetDataByProc(ht, "spLogCheck");

    }

    public DataTable GetAllUsers()
    {
        return objJMSUtility.GetDataByProc("GetUserList");
    }
    public DataTable GetAllModules()
    {
        return objJMSUtility.GetDataByProc("GetModuleList");
    }

    //public DataTable UserId(string login_id,string password)
    //{

    //    DataTable DTabUserId = objJMSUtility.GetDataBySQLString("select pin_number,name,login_id,password,UserType from user_t where login_id='" + login_id + "' COLLATE Latin1_General_CS_AS and password='" + password + "' COLLATE Latin1_General_CS_AS ");
    //    return DTabUserId;
    //}

    //public DataTable Gemenulist(int pin,int mod_code)
    //{
        

    //    DataTable DTabmenu = objJMSUtility.GetDataBySQLString("select distinct menu_code,menu_name from menuaccess_t where pin_number=" + pin + " and module_code=" + mod_code + " order by menu_name ASC");
    //    return DTabmenu;
    //}
    

    //public DataTable Gescreenlist(int pin, int mod_code,int men_code)
    //{
        

    //    DataTable DTAMScreen = objJMSUtility.GetDataBySQLString("select distinct screen_code,screen_name from menuaccess_t where  pin_number=" + pin + " and module_code=" + mod_code + "and menu_code=" + men_code + "  order by screen_name ASC");
    //    return DTAMScreen;
    //}
     
    //public DataTable GetPageName(int screen_code)
    //{

    //    DataTable DTabPageName = objJMSUtility.GetDataBySQLString("select form_name from screen_t where code=" + screen_code + "");
    //    return DTabPageName;
    //}

    //public DataTable Getuserdetailslistgrid()
    //{
    //    DataTable DTab = objJMSUtility.GetDataBySQLString("select module_t.code as mdcode,module_t.name as mdname,menu_t.code as mncode,menu_t.name as mnname,screen_t.code as scrncode,screen_t.display_name as scrnname from module_t, menu_t,screen_t where screen_t.menu_code=menu_t.code and menu_t.module_code=module_t.code order by module_t.code");
    //    return DTab;
    //}

    //public DataTable GetPagepermited(int pin_number)
    //{

    //    DataTable DTabPagepermited = objJMSUtility.GetDataBySQLString("select screen_code from menuaccess_t where pin_number=" + pin_number + "");
    //    return DTabPagepermited;
    //}

    public long Insertuserpermission(BOUserAccess  objBO)
    {
        try
        {
            

            Hashtable ht = new Hashtable();            
            ht.Add("pin_number", objBO.Pin_number);
            ht.Add("module_code",objBO.Module_code);
            ht.Add("module_name", objBO.Module_name1);
            ht.Add("menu_code", objBO.Menu_code );
            ht.Add("menu_name", objBO.Menu_name);
            ht.Add("screen_code", objBO.Screen_code );
            ht.Add("screen_name", objBO.Screen_name);
            return Convert.ToInt64(objJMSUtility.InsertData(ht, "dbo.insert_update_useraccess"));
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
