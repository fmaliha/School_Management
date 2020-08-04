using PBSConnLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InovexiaEBS.DataAccess.PM
{
    public class DAProjectManagement
    {
        PBSDBUtility idbutility = new PBSDBUtility();

        internal DataTable GETProjectList()
        {
            try
            {
                Hashtable ht = new Hashtable();               
                DataTable dataTable = idbutility.GetDataByProc("sp_getProject");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }



        internal DataTable GETProjectByStatus(Hashtable ht)
        {
            try
            {
               
                DataTable dataTable = idbutility.GetDataByProc(ht, "sp_getProjectByStatus");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}