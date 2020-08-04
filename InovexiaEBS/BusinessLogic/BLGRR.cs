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


    public class BLGRR
    {

        public BLGRR()
    {


    }

    public static long insertGRR(BOGRR  boaddemployee)
    {
        DAGRR daaddemp = new DAGRR();
        return Convert.ToInt64(daaddemp.insertGRR(boaddemployee));

    }

    public static long insertGRRDetail(BOGRR  boaddemployee)
    {
        DAGRR daaddemp = new DAGRR();
        return Convert.ToInt64(daaddemp.insertGRRDetail(boaddemployee));

    }
    }
