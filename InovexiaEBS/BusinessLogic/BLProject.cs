using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


    public class BLProject
    {

        public BLProject()
        { 
        
        }

        public static long InsertProject(BOProject  objBO)
        {
            DAProject objDA = new DAProject();
            return Convert.ToInt64(objDA.InsertProject(objBO));
        }

    }
