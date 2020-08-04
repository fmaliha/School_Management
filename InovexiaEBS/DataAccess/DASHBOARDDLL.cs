using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PBSConnLib;

namespace InovexiaEBS.BusinessLogic
{
    public class DASHBOARDDLL
    {
        PBSDBUtility pbsd = new PBSDBUtility();


        internal DataTable GetStudentCount(Hashtable ht)
        {
            try
            {
                DataTable dt = pbsd.GetDataByProc(ht, "SM_CountStudentDashboard");

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        internal DataTable GetFeeSummary(Hashtable ht)
        {
            try
            {
                DataTable dt = pbsd.GetDataByProc(ht, "SM_GetFeeSummary");

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

    }
}