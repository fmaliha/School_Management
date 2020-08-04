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
    public class DAPBML_SDM_Production
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_Production(BOPBML_SDM_Production boItem, bool isBrokenCakeee)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("ProductionID", boItem.ProductionID1);
                ht.Add("ProductGroupID", boItem.ProductGroupID1);     
                ht.Add("ThiknessID", boItem.ThiknessID1);
                ht.Add("SizeID", boItem.SizeID1);
                ht.Add("ColorCode", boItem.ColorCode1);
                ht.Add("UnitID", boItem.UnitID1);
                ht.Add("ProductionQuantity", boItem.ProductionQuantity1);
                ht.Add("ProductionDate", boItem.ProductionDate1);
                ht.Add("IsQC", boItem.IsQC1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("YYear", boItem.YYear1);
                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("ShiftID", boItem.ShiftID1);
                ht.Add("IsBrokenCakeee", isBrokenCakeee);

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_Production"));

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable GetRawMeterialInfo(int productGroupId, int thiknessId, int sizeId, string colorCode, int unitId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("productGroupId", productGroupId);
                ht.Add("thiknessId", thiknessId);
                ht.Add("sizeId", sizeId);
                ht.Add("colorCode", colorCode);
                ht.Add("unitId", unitId);
                return idbutility.GetDataByProc(ht, "dbo.spRawMeterialInfoNew");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertPBML_SDM_RawMeterialStockOut(string rawMeterialId, string rawMeterialProductId, decimal rawMeterialQuantity, string stockType)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("rawMeterialId", rawMeterialId);
                ht.Add("rawMeterialProductId", rawMeterialProductId);
                ht.Add("rawMeterialQuantity", rawMeterialQuantity);
                ht.Add("stockType", stockType);           
                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_rawMeterial"));

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public long InsertPBML_SDM_RawMeterialStockOut(string rawMeterialId, string rawMeterialProductId, decimal rawMeterialQuantity, string stockType, int serialNumber, int pYear, string cretedBy, DateTime cretedDate, string updatedBy, DateTime updatedDate, DateTime purchaseDate, string companyId)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("rawMeterialId", rawMeterialId);
                ht.Add("rawMeterialProductId", rawMeterialProductId);
                ht.Add("rawMeterialQuantity", rawMeterialQuantity);
                ht.Add("serialNumber", serialNumber);
                ht.Add("pYear", pYear);
                ht.Add("stockType", 2);
                ht.Add("cretedBy", cretedBy);
                ht.Add("cretedDate", cretedDate);
                ht.Add("updatedBy", updatedBy);
                ht.Add("updatedDate", updatedDate);
                ht.Add("purchaseDate", purchaseDate);
                ht.Add("companyId", companyId);

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_rawMeterial"));

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable GetRawMeterialInfooo(int productGroupId, int thiknessId, int sizeId, string colorCode, int unitId, int madeByProductId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("productGroupId", productGroupId);
                ht.Add("thiknessId", thiknessId);
                ht.Add("sizeId", sizeId);
                ht.Add("colorCode", colorCode);
                ht.Add("unitId", unitId);
                ht.Add("madeByProductId", madeByProductId);
                return idbutility.GetDataByProc(ht, "dbo.spRawMeterialInfooNew");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}