using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using PBSConnLib;
using System.Collections;

namespace InovexiaEBS
{
    public class DADealerAccounts
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertDealerAccounts(BODealerAccounts boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("ACode", boItem.ACode1);
             
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);




                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertACDealer"));

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}