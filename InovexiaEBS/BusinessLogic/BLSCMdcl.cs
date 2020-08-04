using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


    public class BLSCMdcl
    {

        public BLSCMdcl()
        { 
        
        }


        public static long InsertMRFMaster(BOAddMRF objBO)
        {
            DAscmDCL objDA = new DAscmDCL();
            return Convert.ToInt64(objDA.InsertMRFMaster(objBO));
        }

        public static long InsertMRFDetail(BOAddMRF  objBO)
        {
            DAscmDCL objDA = new DAscmDCL();
            return Convert.ToInt64(objDA.InsertMRFDetail(objBO));
        }






    }
