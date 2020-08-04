using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_Unit
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_Unit(BOPBML_SDM_Unit boItem)
        {



            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("UnitID", boItem.UnitID1);
                ht.Add("UnitName", boItem.UnitName1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_Unit"));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}