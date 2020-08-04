using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using System.Collections.Generic;
using PBSConnLib;


public class DAScreen
{
    PBSDBUtility iPBSDBUtility = new PBSDBUtility();
	public DAScreen()
	{
		
	}
    public long InsertScreen(BOScreen objBO)
    {
        try
        {
            Hashtable ht = new Hashtable();
            ht.Add("menu_code", objBO.Code);
            ht.Add("display_name", objBO.Name);
            ht.Add("form_name", objBO.Description);
            ht.Add("creator", objBO.Creator);
            return Convert.ToInt64(iPBSDBUtility.InsertData(ht, "dbo.insert_update_screen_t"));
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public DataTable GetAllScreenList()
    {
        DataTable table = iPBSDBUtility.GetDataBySQLString("SELECT trim(code) as code,trim(menu_code)as menu_code ,display_name,form_name,creator FROM dbo.screen_t");
        return table;
    }
    public DataTable GetModuleCodeforScreen()
    {
        DataTable table = iPBSDBUtility.GetDataBySQLString("SELECT  code, convert(varchar,code)+ ' ( '+ name + ' )' AS Description FROM dbo.module_t");
        return table;
    }
    public DataTable GetMenuCodeforScreen( string code)
    {
        DataTable table = iPBSDBUtility.GetDataBySQLString("SELECT  code, convert(varchar,code)+ ' ( '+ name + ' )' AS Description FROM dbo.menu_t where module_code='" + code + "'");
        return table;
    }
    public DataTable GetDisplayORFromNameforScreen(string code)
    {
        DataTable table = iPBSDBUtility.GetDataBySQLString("SET NOCOUNT ON SELECT  code,display_name, form_name FROM dbo.screen_t where menu_code='" + code + "'");
        return table;
    }
    public DataTable GetScreenList()
    {
        DataTable table = iPBSDBUtility.GetDataByProc("dbo.Populated_All_Screen_info");
        return table;
    }
}
