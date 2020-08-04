using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_Color
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_Color(BOPBML_SDM_Color boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("ColorID", boItem.ColorID1);
                ht.Add("ColorName", boItem.ColorName1);
                ht.Add("ColorCode", boItem.ColorCode1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);




                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_Color"));

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}