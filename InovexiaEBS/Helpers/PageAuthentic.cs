using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBSConnLib;
using System.Collections;
using System.Data;


public class PageAuthentic
{


    PBSDBUtility idb = new PBSDBUtility();

    public int PageAuthenticationCheck(string PinNo, string PageName)
    {
        string pindb = "", pagedb = "";

        string pqry = @"SELECT        dbo.AppsPermission.pin_number, menus.FormName
FROM            dbo.AppsPermission INNER JOIN
                         dbo.menus ON dbo.AppsPermission.menu_id = dbo.menus.menu_id

						 where  dbo.AppsPermission.pin_number='"+PinNo +"' and menus.FormName='"+PageName+"'";

        DataTable DTabPage = idb.GetDataBySQLString(pqry);

        foreach (DataRow dr in DTabPage.Rows)
        {
            pindb = dr[0].ToString();
            pagedb = dr[1].ToString();

        }

        if (PinNo == pindb && PageName == pagedb)

            return 1;
        else

            return 0;
    }


}
