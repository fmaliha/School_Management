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
    public class DAPBML_SDM_DCDetail
    {
        PBSDBUtility idbutility = new PBSDBUtility();

        public long InsertPBML_SDM_DCDetail(BOPBML_SDM_DCDetail boItem, string doRevisedNumber)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("DCNO", boItem.DCNO1);
                ht.Add("DONO", boItem.DONO1);
                ht.Add("ProductCode", boItem.ProductCode1);
                ht.Add("DOQuantity", boItem.DOQuantity1);
                ht.Add("BalanceQuantity", boItem.BalanceQuantity1);
                ht.Add("Rate", boItem.Rate1);
                ht.Add("ChallanQuantity", boItem.ChallanQuantity1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("doRevisedNumber", doRevisedNumber);


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_DCDetail"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertPBML_SDM_DCDetailSpecial(BOPBML_SDM_DCDetail dodObj, string originalProductCode)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("DCNO", dodObj.DCNO1);
                ht.Add("DONO", dodObj.DONO1);
                ht.Add("ProductCode", dodObj.ProductCode1);
                ht.Add("DOQuantity", dodObj.DOQuantity1);
                ht.Add("BalanceQuantity", dodObj.BalanceQuantity1);
                ht.Add("Rate", dodObj.Rate1);
                ht.Add("ChallanQuantity", dodObj.ChallanQuantity1);
                ht.Add("IsActive", dodObj.IsActive1);
                ht.Add("CreatedBy", dodObj.CreatedBy1);
                ht.Add("CreatedDate", dodObj.CreatedDate1);
                ht.Add("UpdatedBy", dodObj.UpdatedBy1);
                ht.Add("UpdatedDate", dodObj.UpdatedDate1);
                ht.Add("DOProductCode", originalProductCode);


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_DCDetailSpecial"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetBalanceQuantity(int count, string productId, string dono, string replaceByProductId)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("Count", count);
                ht.Add("ProductId", productId);
                ht.Add("DONO", dono);
                ht.Add("replaceByProductId", replaceByProductId);
                return idbutility.GetDataByProc(ht, "dbo.sp_GetBalanceQuantity");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetBalanceQuantityForDO(int count, string productId, string dono, string attribute2Value)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("Count", count);
                ht.Add("ProductId", productId);
                ht.Add("DONO", dono);
                ht.Add("attribute2Value", attribute2Value);
                return idbutility.GetDataByProc(ht, "dbo.sp_GetBalanceQuantityFORDO");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}