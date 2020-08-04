using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_DODetail
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_DODetail(BOPBML_SDM_DODetail boItem)
        {
            try
            {
                var ht = new Hashtable();

                ht.Add("DONO", boItem.DONO1);
                ht.Add("ProductCode", boItem.ProductCode1);
                ht.Add("Quantity", boItem.Quantity1);
                ht.Add("DiscountQuantity", boItem.DiscountQuantity1);
                ht.Add("DiscountID", boItem.DiscountID1);
                ht.Add("Rate", boItem.Rate1);
                ht.Add("IsDC", boItem.IsDC1);
                ht.Add("IsIncentive", boItem.IsIncentive1);
                ht.Add("IncentiveCalculateDate", boItem.IncentiveCalculateDate1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_DODetail"));


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertPBML_SDM_DODiscount(string dono, int discountId, string productCode, decimal discountQuantity, bool isActive, string createdBy, DateTime createdDate, string updatedBy, DateTime updatedDate)
        {
            try
            {
                var ht = new Hashtable();
                ht.Add("DONO", dono);
                ht.Add("DiscountId", discountId);
                ht.Add("ProductCode", productCode);
                ht.Add("DiscountQuantity", discountQuantity);
                ht.Add("IsActive", isActive);
                ht.Add("CreatedBy", createdBy);
                ht.Add("CreatedDate", createdDate);
                ht.Add("UpdatedBy", updatedBy);
                ht.Add("UpdatedDate", updatedDate);

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_DODiscountDetail"));


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal long InsertPBML_SDM_DODetailRevised(BOPBML_SDM_DODetail dodObj)
        {
            try
            {
                var ht = new Hashtable();

                ht.Add("DONO", dodObj.DONO1);
                ht.Add("ProductCode", dodObj.ProductCode1);
                ht.Add("Quantity", dodObj.Quantity1);
                ht.Add("DiscountQuantity", dodObj.DiscountQuantity1);
                ht.Add("DiscountID", dodObj.DiscountID1);
                ht.Add("Rate", dodObj.Rate1);
                ht.Add("IsDC", dodObj.IsDC1);
                ht.Add("IsIncentive", dodObj.IsIncentive1);
                ht.Add("IncentiveCalculateDate", dodObj.IncentiveCalculateDate1);
                ht.Add("IsActive", dodObj.IsActive1);
                ht.Add("CreatedBy", dodObj.CreatedBy1);
                ht.Add("CreatedDate", dodObj.CreatedDate1);
                ht.Add("UpdatedBy", dodObj.UpdatedBy1);
                ht.Add("UpdatedDate", dodObj.UpdatedDate1);

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_DODetailRevised"));


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertPBML_SDM_DODetailRevised(BOPBML_SDM_DODetail dodObj, string doSerialNumber, bool isdoRevised)
        {
            try
            {
                var ht = new Hashtable();

                ht.Add("DONO", dodObj.DONO1);
                ht.Add("ProductCode", dodObj.ProductCode1);
                ht.Add("Quantity", dodObj.Quantity1);
                ht.Add("DiscountQuantity", dodObj.DiscountQuantity1);
                ht.Add("DiscountID", dodObj.DiscountID1);
                ht.Add("Rate", dodObj.Rate1);
                ht.Add("IsDC", dodObj.IsDC1);
                ht.Add("IsIncentive", dodObj.IsIncentive1);
                ht.Add("IncentiveCalculateDate", dodObj.IncentiveCalculateDate1);
                ht.Add("IsActive", dodObj.IsActive1);
                ht.Add("CreatedBy", dodObj.CreatedBy1);
                ht.Add("CreatedDate", dodObj.CreatedDate1);
                ht.Add("UpdatedBy", dodObj.UpdatedBy1);
                ht.Add("UpdatedDate", dodObj.UpdatedDate1);
                ht.Add("DORevisedSerialNumber", doSerialNumber);
                ht.Add("ISDORevised", isdoRevised);

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_DODetailRevised"));


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertPBML_SDM_TransferDODetail(string dono1)
        {
            try
            {
                var ht = new Hashtable();

                ht.Add("DONO", dono1);
               

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_TransferDO"));


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertPBML_SDM_DODetailSpecial(string dono, string originalProductCode, string changableProductCode, decimal rate, decimal quantity, int count, bool isIncentive, DateTime incentiveCalculateDate, bool isActive, string createdBy, DateTime createdDate, string updatedBy, DateTime updatedDate, int originalCount)
        {
            try
            {
                var ht = new Hashtable();

                ht.Add("DONO", dono);
                ht.Add("originalProductCode", originalProductCode);
                ht.Add("changableProductCode", changableProductCode);
                ht.Add("rate", rate);
                ht.Add("quantity", quantity);
                ht.Add("count", count);
                ht.Add("isIncentive", isIncentive);
                ht.Add("incentiveCalculateDate", incentiveCalculateDate);
                ht.Add("isActive", isActive);
                ht.Add("createdBy", createdBy);
                ht.Add("createdDate", createdDate);
                ht.Add("updatedBy", updatedBy);
                ht.Add("updatedDate", updatedDate);
                ht.Add("originalCount", originalCount);
                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_DODetailRevisedSpecial"));


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertPBML_SDM_DODetailSpecialRevised(string dono, string productCode, string rate, decimal quantity, int doRevisedNumber, bool isIncentive, DateTime incentiveCalculateDate, bool isActive, string createdBy, DateTime createdDate, string updatedBy, DateTime updatedDate)
        {
            try
            {
                var ht = new Hashtable();

                ht.Add("DONO", dono);
                ht.Add("productCode", productCode);
                ht.Add("rate", rate);
                ht.Add("quantity", quantity);
                ht.Add("doRevisedNumber", doRevisedNumber);
                ht.Add("isIncentive", isIncentive);
                ht.Add("incentiveCalculateDate", incentiveCalculateDate);
                ht.Add("isActive", isActive);
                ht.Add("createdBy", createdBy);
                ht.Add("createdDate", createdDate);
                ht.Add("updatedBy", updatedBy);
                ht.Add("updatedDate", updatedDate);
                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_DODetailRevisedSpecialSecond"));


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}