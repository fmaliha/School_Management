using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_BankInfo
    {
        PBSDBUtility idbutility = new PBSDBUtility();

        public long InsertPBML_SDM_BankInfo(BOPBML_SDM_BankInfo boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("BankID", boItem.BankID1);
                ht.Add("BankName", boItem.BankName1);
                ht.Add("Address", boItem.Address1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);




                return Convert.ToInt64(idbutility.InsertData(ht,"spInsertPBML_SDM_BankInfo"));

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}