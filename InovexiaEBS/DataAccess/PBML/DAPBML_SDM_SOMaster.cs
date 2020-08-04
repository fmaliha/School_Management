using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;
using PBSConnLib;


namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_SOMaster
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        PBSDBUtility idb = new PBSDBUtility();

        public long InsertPBML_SDM_SOMaster(BOPBML_SDM_SOMaster boItem)
        {



            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("oldSONO", boItem.oldSONO1);
                ht.Add("SONO", boItem.SONO1);
                ht.Add("SODate", boItem.SODate1);
                ht.Add("PosibleDeliveryDate", boItem.PosibleDeliveryDate1);
                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("DeliveryDate", boItem.DeliveryDate1);
                ht.Add("Reference", boItem.Reference1);
                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("Year", boItem.Year1);
                ht.Add("Month", boItem.Month1);
                ht.Add("IsDO", boItem.IsDO1);
                ht.Add("IsIncentive", boItem.IsIncentive1);
                ht.Add("IncentiveCalculateDate", boItem.IncentiveCalculateDate1);
                ht.Add("IsAccountsApporved", boItem.IsAccountsApporved1);
                ht.Add("AccountsApprovedBy", boItem.AccountsApprovedBy1);
                ht.Add("AccountsApprovalComments", boItem.AccountsApprovalComments1);
                ht.Add("ApprovalDateTime", boItem.ApprovalDateTime1);
                ht.Add("Remarks", boItem.Remarks1);
                ht.Add("IsRevised", boItem.IsRevised1);
                ht.Add("IsSendForDO", boItem.IsSendForDO1);
                ht.Add("RevisedNo", boItem.RevisedNo1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);



                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_SOMaster"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long UpdatePBML_SDM_SOMaster(BOPBML_SDM_SOMaster boItem)
        {



            try
            {
               Hashtable ht = new Hashtable();
              
                ht.Add("SONO", boItem.SONO1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
               return Convert.ToInt64(idbutility.InsertData(ht, "spUpdatePBML_SDM_SOMaster"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertEmailHistory(BOPBML_SDM_SOMaster boItem)
        {



            try
            {


                Hashtable ht = new Hashtable();
                ht.Add("login_id", boItem.Login_id);
                ht.Add("MailFrom", boItem.MailFrom1);
                ht.Add("MailTo", boItem.MailTo1);
                ht.Add("SendTime", boItem.SendTime1);
                ht.Add("MailMessage", boItem.MailMessage1);
                ht.Add("Remarks", boItem.Remarks1);



                return Convert.ToInt64(idb.InsertData(ht, "spMailHistory"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}