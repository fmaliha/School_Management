using InovexiaEBS.BusinessEntity.Enterprise;
using PBSConnLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InovexiaEBS.DataAccess.Enterprise
{
    public class DAEnterpriseBanking
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long InsertEnterpriseBanking(BOEnterpriseBanking model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();

                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("BankID", model.BankID);
                ht.Add("BranchInfo", model.BranchInfo);
                ht.Add("LoanAmount", model.LoanAmount);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertEnterpriseBanking"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long UpdateEnterpriseBanking(BOEnterpriseBanking model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseBankID", model.EnterpriseBankID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("BankID", model.BankID);
                ht.Add("BranchInfo", model.BranchInfo);
                ht.Add("LoanAmount", model.LoanAmount);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateEnterpriseBanking"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteEnterpriseBanking(BOEnterpriseBanking model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseBankID", model.EnterpriseBankID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeleteEnterpriseBanking"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseBankingList(int EnterpriseCategoryId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseCategoryId", EnterpriseCategoryId);
                DataTable dataTable = pbsUtility.GetDataByProc(ht,"Sp_GetEnterpriseBankingList");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseBankingByID(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "Sp_GetEnterpriseBankingInfoById");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}