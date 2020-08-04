using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using PBSConnLib;
using System.Collections;



    public class DAPBML_SDM_MRMaster
    {
        PBSDBUtility idbutility = new PBSDBUtility();

        PBSDBUtility idbutilityBoards = new PBSDBUtility();

        public long InsertPBML_SDM_MRMaster(BOPBML_SDM_MRMaster boItem)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("MRNO", boItem.MRNO1);
                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("MRDate", boItem.MRDate1);
                ht.Add("Acode", boItem.Acode1);
                ht.Add("Amount", boItem.Amount1);
                ht.Add("PaymentMode", boItem.PaymentMode1);
                ht.Add("BankID", boItem.BankID1);
                ht.Add("CheckNo", boItem.CheckNo1);
                ht.Add("CheckDate", boItem.CheckDate1);
                ht.Add("CollectionDate", boItem.CollectionDate1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("Year", boItem.Year1);


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_MRMaster"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertPBML_SDM_MRMaster(BOPBML_SDM_MRMaster boItem, string branchName, string checkStatus)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("MRNO", boItem.MRNO1);
                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("MRDate", boItem.MRDate1);

                ht.Add("DebitHead", boItem.DebitHead1 );
                ht.Add("CreditHead", boItem.CreditHead1);

                ht.Add("Amount", boItem.Amount1);
                ht.Add("PaymentMode", boItem.PaymentMode1);
                ht.Add("BankID", boItem.BankID1);
                ht.Add("CheckNo", boItem.CheckNo1);
                ht.Add("CheckDate", boItem.CheckDate1);
                ht.Add("CollectionDate", boItem.CollectionDate1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("Year", boItem.Year1);
                ht.Add("BranchName", branchName);
                ht.Add("CheckStatus", checkStatus);
                //for cheque info update
                ht.Add("ChequePostingID", boItem.ChequePostingID1);
                ht.Add("TransactionType", boItem.TransactionType1);
                ht.Add("VoucherType", boItem.VoucherType1);
                ht.Add("IsAccountsManagerApproved", boItem.IsAccountsManagerApproved1);
                ht.Add("DiscountAmount", boItem.DiscountAmount1);
                ht.Add("RefNO", boItem.RefNO1);





                return Convert.ToInt64(idbutility.InsertData(ht, "spInsert_Acc_Voucher"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long Insert_Supplier_Payment_DA(BOPBML_SDM_MRMaster boItem, string branchName, string checkStatus)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("MRNO", boItem.MRNO1);
                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("MRDate", boItem.MRDate1);

                ht.Add("DebitHead", boItem.DebitHead1);
                ht.Add("CreditHead", boItem.CreditHead1);

                ht.Add("Amount", boItem.Amount1);
                ht.Add("PaymentMode", boItem.PaymentMode1);
                ht.Add("BankID", boItem.BankID1);
                ht.Add("CheckNo", boItem.CheckNo1);
                ht.Add("CheckDate", boItem.CheckDate1);
                ht.Add("CollectionDate", boItem.CollectionDate1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("Year", boItem.Year1);
                ht.Add("BranchName", branchName);
                ht.Add("CheckStatus", checkStatus);
                //for cheque info update
                ht.Add("ChequePostingID", boItem.ChequePostingID1);
                ht.Add("TransactionType", boItem.TransactionType1);
                ht.Add("VoucherType", boItem.VoucherType1);
                ht.Add("IsAccountsManagerApproved", boItem.IsAccountsManagerApproved1);
                ht.Add("DiscountAmount", boItem.DiscountAmount1);
                ht.Add("RefNO", boItem.RefNO1);





                return Convert.ToInt64(idbutility.InsertData(ht, "spInsert_Acc_Supplier_Payment"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public long Insert_Client_Payment_DA(BOPBML_SDM_MRMaster boItem, string branchName, string checkStatus)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("MRNO", boItem.MRNO1);
                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("MRDate", boItem.MRDate1);

                ht.Add("DebitHead", boItem.DebitHead1);
                ht.Add("CreditHead", boItem.CreditHead1);

                ht.Add("Amount", boItem.Amount1);
                ht.Add("PaymentMode", boItem.PaymentMode1);
                ht.Add("BankID", boItem.BankID1);
                ht.Add("CheckNo", boItem.CheckNo1);
                ht.Add("CheckDate", boItem.CheckDate1);
                ht.Add("CollectionDate", boItem.CollectionDate1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("Year", boItem.Year1);
                ht.Add("BranchName", branchName);
                ht.Add("CheckStatus", checkStatus);
                //for cheque info update
                ht.Add("ChequePostingID", boItem.ChequePostingID1);
                ht.Add("TransactionType", boItem.TransactionType1);
                ht.Add("VoucherType", boItem.VoucherType1);
                ht.Add("IsAccountsManagerApproved", boItem.IsAccountsManagerApproved1);
                ht.Add("DiscountAmount", boItem.DiscountAmount1);
                ht.Add("RefNO", boItem.RefNO1);





                return Convert.ToInt64(idbutility.InsertData(ht, "spInsert_Acc_Client_Payment"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertPBML_SDM_MRMasterReverse(BOPBML_SDM_MRMaster boItem, string branchName, string checkStatus)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("MRNO", boItem.MRNO1);
                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("MRDate", boItem.MRDate1);
                ht.Add("Acode", boItem.Acode1);
                ht.Add("Amount", boItem.Amount1);
                ht.Add("PaymentMode", boItem.PaymentMode1);
                ht.Add("BankID", boItem.BankID1);
                ht.Add("CheckNo", boItem.CheckNo1);
                ht.Add("CheckDate", boItem.CheckDate1);
                ht.Add("CollectionDate", boItem.CollectionDate1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("Year", boItem.Year1);
                ht.Add("BranchName", branchName);
                ht.Add("CheckStatus", checkStatus);
                //for cheque info update
                ht.Add("ChequePostingID", boItem.ChequePostingID1);
                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_MRMaster"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertPBML_SDM_ChequeInfo(BOPBML_SDM_MRMaster boItemChk)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("ChequePostingID", boItemChk.ChequePostingID1);
                ht.Add("PostingDate", boItemChk.PostingDate1);
                ht.Add("DealerID", boItemChk.DealerID1);
                ht.Add("Amount", boItemChk.Amount1);
                ht.Add("Acode", boItemChk.Acode1);
                ht.Add("ChequeType", boItemChk.ChequeType1);
                ht.Add("CheckNo", boItemChk.CheckNo1);
                ht.Add("CheckDate", boItemChk.CheckDate1);
                ht.Add("BankID", boItemChk.BankID1);
                ht.Add("BranchName", boItemChk.BranchName1);
                ht.Add("Remarks", boItemChk.Remarks1);
                ht.Add("IsMR", boItemChk.IsMR1);


                
                ht.Add("CompanyID", boItemChk.CompanyID1);
                ht.Add("SerialNumber", boItemChk.SerialNumber1);
                ht.Add("PYear", boItemChk.Year1);
                ht.Add("IsActive", boItemChk.IsActive1);
                ht.Add("CreatedBy", boItemChk.CreatedBy1);
                ht.Add("CreatedDate", boItemChk.CreatedDate1);
                ht.Add("UpdatedBy", boItemChk.UpdatedBy1);
                ht.Add("UpdatedDate", boItemChk.UpdatedDate1);
                ht.Add("ChequeStatus", boItemChk.ChequeStatus1);


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_ChequeInfo"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long UpdatePBML_SDM_ChequeInfo(BOPBML_SDM_MRMaster boItemChkUpdate)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("ChequePostingID", boItemChkUpdate.ChequePostingID1);
                ht.Add("UpdatedBy", boItemChkUpdate.UpdatedBy1);
                ht.Add("ChequeStatus", boItemChkUpdate.ChequeStatus1);
                return Convert.ToInt64(idbutility.InsertData(ht, "UpdatePBML_SDM_ChequeInfo"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public long InsertPBML_SDM_MRMasterBoards(BOPBML_SDM_MRMaster boItem, string branchName, string checkStatus)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("MRNO", boItem.MRNO1);
                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("MRDate", boItem.MRDate1);
                ht.Add("Acode", boItem.Acode1);
                ht.Add("Amount", boItem.Amount1);
                ht.Add("PaymentMode", boItem.PaymentMode1);
                ht.Add("BankID", boItem.BankID1);
                ht.Add("CheckNo", boItem.CheckNo1);
                ht.Add("CheckDate", boItem.CheckDate1);
                ht.Add("CollectionDate", boItem.CollectionDate1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("Year", boItem.Year1);
                ht.Add("BranchName", branchName);
                ht.Add("CheckStatus", checkStatus);
                //for cheque info update
                ht.Add("ChequePostingID", boItem.ChequePostingID1);
                return Convert.ToInt64(idbutilityBoards.InsertData(ht, "spInsertPBML_SDM_MRMaster"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
