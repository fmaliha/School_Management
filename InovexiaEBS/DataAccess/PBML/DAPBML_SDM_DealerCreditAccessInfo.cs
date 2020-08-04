using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;


namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_DealerCreditAccessInfo
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_DealerCreditAccessInfo(BOPBML_SDM_DealerCreditAccessInfo boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("DONO", boItem.DONO1);
                ht.Add("SONO", boItem.SONO1);
                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("DealerName", boItem.DealerName1);
                ht.Add("AvailableBalance", boItem.AvailableBalance1);
                ht.Add("CreditLimit", boItem.CreditLimit1);
                ht.Add("DueAmount", boItem.DueAmount1);
                ht.Add("MRBalance", boItem.MRBalance1);
                ht.Add("CreditBalance", boItem.CreditBalance1);
                ht.Add("UsedCredit", boItem.UsedCredit1);
                



                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_DealerCreditAccessInfo"));

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}