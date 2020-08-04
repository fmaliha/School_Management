using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_Size
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_Size(BOPBML_SDM_Size boItem)
        {



            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("SizeID", boItem.SizeID1);
                ht.Add("SizeName", boItem.SizeName1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_Size"));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}