using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using PBSConnLib;




    public class DA_ACCOUNTS
    {
        PBSDBUtility iPBSDBUtility = new PBSDBUtility();

        public DA_ACCOUNTS()
        { 
        
        
        }
        public  long  InsertCheque_DA(BO_ACCOUNTS objItem)
           {
                try
                {
                        Hashtable ht = new Hashtable();
                        ht.Add("RefNo", objItem.RefNo);
                        ht.Add("PostingDate", objItem.PostingDate);
                        ht.Add("SupplierID", objItem.SupplierID);
                        ht.Add("Acode", objItem.Acode);
                        ht.Add("Amount", objItem.Amount);
                        ht.Add("ChequeType", objItem.ChequeType);
                        ht.Add("ChequeCategory", objItem.ChequeCategory);
                        ht.Add("ChequeNo", objItem.ChequeNo);
                        ht.Add("ChequeDate", objItem.ChequeDate);
                        ht.Add("BankID", objItem.BankID);
                        ht.Add("BranchName", objItem.BranchName);
                        ht.Add("Remarks", objItem.Remarks);
                        ht.Add("IsMR", objItem.IsMR);
                        ht.Add("CompanyID", objItem.CompanyID);
                        ht.Add("SerialNumber", objItem.SerialNumber);
                        ht.Add("PYear", objItem.PYear);
                        ht.Add("IsActive", objItem.IsActive);
                        ht.Add("CreatedBy", objItem.CreatedBy);
                        ht.Add("CreatedDate", objItem.CreatedDate);
                        ht.Add("UpdatedBy", objItem.UpdatedBy);
                        ht.Add("UpdatedDate", objItem.UpdatedDate);
                        ht.Add("ChequeStatus", objItem.ChequeStatus);

                        return Convert.ToInt64(iPBSDBUtility.InsertData(ht, "spInsertChequeRegister"));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
       }

     



    }