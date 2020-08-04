using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_DO_Incentive
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_DO_Incentive(BOPBML_SDM_DO_Incentive boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("DONO", boItem.DONO1);
                ht.Add("IncentiveID", boItem.IncentiveID1);
                ht.Add("Amount", boItem.Amount1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);



                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_DO_Incentive"));


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}