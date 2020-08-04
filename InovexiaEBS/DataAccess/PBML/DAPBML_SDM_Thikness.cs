using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_Thikness
    {
         PBSDBUtility idbutility = new PBSDBUtility();
         public long InsertPBML_SDM_Thikness(BOPBML_SDM_Thikness boItem)
         {



             try
             {

                 Hashtable ht = new Hashtable();
                 ht.Add("ThiknessID", boItem.ThiknessID1);
                 ht.Add("ThiknessName", boItem.ThiknessName1);
                 ht.Add("ThiknessUnit", boItem.ThiknessUnit1);
                 ht.Add("IsActive", boItem.IsActive1);
                 ht.Add("CreatedBy", boItem.CreatedBy1);
                 ht.Add("CreatedDate", boItem.CreatedDate1);
                 ht.Add("UpdatedBy", boItem.UpdatedBy1);
                 ht.Add("UpdatedDate", boItem.UpdatedDate1);

                 return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_Thikness"));

             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }
    }
}