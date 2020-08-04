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


    public class DAProject
    {
        PBSDBUtility  idbutility  = new PBSDBUtility();

        public DAProject()
        { 
        
        }

        public long InsertProject(BOProject  objBO)
        {

            
            try
            {
                 Hashtable ht = new Hashtable();
                 ht.Add("ProjectID", objBO.ProjectID1);
                 ht.Add("ProjectName",objBO.ProjectName1);
                 ht.Add("Address", objBO.Address1);
                 ht.Add("Location", objBO.Location1);
                 ht.Add("NoOfFloor", objBO.NoOfFloor1);
                 ht.Add("IsActive", objBO.IsActive1);
                 ht.Add("EntryID", objBO.EntryID1);
                 ht.Add("EntryDate", objBO.EntryDate1);
                 ht.Add("UpdateID", objBO.UpdateID1);
                 ht.Add("UpdateDate", objBO.UpdateDate1 );

                 return Convert.ToInt64(idbutility.InsertData(ht, "spInsertProjectMaster"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
