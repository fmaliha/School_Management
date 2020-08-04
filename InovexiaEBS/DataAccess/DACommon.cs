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
using System.IO;
using PBSConnLib;

/// <summary>
/// Summary description for DAManipulator
/// </summary>
public class DACommon
{
	
    PBSDBUtility iPBSDBUtility = new PBSDBUtility();
    public DACommon()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    
    public static ThemeList GetThemes()
    {
        ThemeList objList = new ThemeList();
        DirectoryInfo dInfo = new DirectoryInfo(System.Web.HttpContext.Current.Server.MapPath("App_Themes"));
        DirectoryInfo[] dArrInfo = dInfo.GetDirectories();
        //ArrayList list = new ArrayList();
        foreach (DirectoryInfo sDirectory in dArrInfo)
        {
            BOTheme objBO = new BOTheme();
            objBO.Themename = sDirectory.Name;
            objList.AddToList(objBO);
        }
        return objList;
    }    


    public DataTable PopulateAllPurpose()
    {
        return (DataTable)iPBSDBUtility.GetDataByProc("dbo.populate_all_purpose");
    }

    public DataTable pullingProducer()
    {
        return (DataTable)iPBSDBUtility.GetDataByProc("dbo.pulling_producer_info");
    }

    public long InsertScreen(BOCommon objBO)
    {
        try
        {
            Hashtable ht = new Hashtable();
            ht.Add("menu_code", objBO.Code );
            ht.Add("display_name", objBO.Name);
            ht.Add("form_name", objBO.Description);
            ht.Add("creator", "sa");
            return Convert.ToInt64(iPBSDBUtility.InsertData(ht, "dbo.insert_update_screen_t"));
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    
    public DataTable GetMenuCodeforScreen()
    {
        DataTable table = iPBSDBUtility.GetDataBySQLString("SELECT  code, convert(varchar,code)+ ' ( '+ name + ' )' AS Description FROM dbo.module_t");
        return table;
    }

}
