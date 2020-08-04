using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_DealerCreditLimit
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_DealerCreditLimit(BOPBML_SDM_DealerCreditLimit boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();


                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("CreditLimit", boItem.CreditLimit1);
                ht.Add("ISValid", boItem.ISValid1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);

                ht.Add("CreditLimitDate", boItem.CreditLimitDate1);
                ht.Add("CreditDuration", boItem.CreditDuration1);
                ht.Add("PaymentDate", boItem.PaymentDate1 );
                ht.Add("CategoryID",boItem.CategoryID);


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_DealerCreditLimit"));


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}