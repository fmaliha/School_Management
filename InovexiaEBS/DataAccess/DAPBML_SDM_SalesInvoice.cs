using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using PBSConnLib;
using System.Collections;


    public class DAPBML_SDM_SalesInvoice
    {
        PBSDBUtility idbutility = new PBSDBUtility();

        public long InsertPBML_SDM_SalesInvoice(BOPBML_SDM_SalesInvoice boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("DealerID", boItem.DealerID1 );
                ht.Add("SRID", boItem.SRID1 );
               

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertDealerSRConfig"));

            }
            catch (Exception ex)
            {
                throw ex;


            }

        }
    }
