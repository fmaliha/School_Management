using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;



public class acml_bl_purchase
{
    public acml_bl_purchase()
    {


    }

    public static long insertpurchase(acml_bo_purchase boaddemployee)
    {
        acml_da_purchase daaddemp = new acml_da_purchase();
        return Convert.ToInt64(daaddemp.insertpurchase(boaddemployee));

    }

    public static long insertpurchase_detail(acml_bo_purchase boaddemployee)
    {
        acml_da_purchase daaddemp = new acml_da_purchase();
        return Convert.ToInt64(daaddemp.insertpurchase_detail(boaddemployee));

    }
}
