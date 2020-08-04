using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_DOMaster
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_DOMaster(BOPBML_SDM_DOMaster boItem)
        {
            try
            {
                var ht = new Hashtable();
                ht.Add("DONO", boItem.DONO1);
                ht.Add("DODate", boItem.DODate1);
                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("SONO", boItem.SONO1);
                ht.Add("DeliveryDate", boItem.DeliveryDate1);
                ht.Add("Reference", boItem.Reference1);
                ht.Add("Year", boItem.Year1);
                ht.Add("Month", boItem.Month1);
                ht.Add("IsDC", boItem.IsDC1);
                ht.Add("IsIncentive", boItem.IsIncentive1);
                ht.Add("IncentiveCalculateDate", boItem.IncentiveCalculateDate1);
                // Accounts Appoval
                ht.Add("IsAccountsApporved", boItem.IsAccountsApporved1);
                ht.Add("AccountsApprovedBy", boItem.AccountsApprovedBy1);
                ht.Add("AccountsApprovalComments", boItem.AccountsApprovalComments1);
                ht.Add("ApprovalDateTime", boItem.ApprovalDateTime1);
                // Distributor Approval
                ht.Add("IsDistributorApporved", boItem.IsDistributorApporved1);
                ht.Add("DistributorApprovedBy", boItem.DistributorApprovedBy1);
                ht.Add("DistributorApprovalComments", boItem. DistributorApprovalComments1);
                ht.Add("DistributorApprovalDateTime", boItem.DistributorApprovalDateTime1);
                // Sales Approval
                ht.Add("IsSalesDeptApporved", boItem.IsSalesDeptApporved1);
                ht.Add("SalesDeptApprovedBy", boItem.SalesDeptApprovedBy1);
                ht.Add("SalesDeptApprovalComments", boItem.SalesDeptApprovalComments1);
                ht.Add("SalesDeptApprovalDateTime", boItem.SalesDeptApprovalDateTime1);
                // Director Approval
                ht.Add("IsDirectorApporved", boItem.IsDirectorApporved1);
                ht.Add("DirectorApprovedBy", boItem.DirectorApprovedBy1);
                ht.Add("DirectorApprovalComments", boItem.DirectorApprovalComments1);
                ht.Add("DirectorApprovalDateTime", boItem.DirectorApprovalDateTime1);

                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                
                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_DOMaster"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetCurrentDealerBalance(string selectedValue)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("DealerID", selectedValue);
                return idbutility.GetDataByProc(ht, "dbo.GetCurrentDealerBalance");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}