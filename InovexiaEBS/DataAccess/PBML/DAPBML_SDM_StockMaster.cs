using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_StockMaster
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_StockMaster(BOPBML_SDM_StockMaster boItem)
        {



            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("StockTranID", boItem.StockTranID1);
                ht.Add("StockTranDate", boItem.StockTranDate1);
                ht.Add("WhareHouseID", boItem.WhareHouseID1);
                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("Year", boItem.Year1);
                ht.Add("FGORDCID", boItem.FGORDCID1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("IsStockIn", boItem.IsStockIn1);



                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_StockMaster"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertPBML_SDM_FG(BOPBML_SDM_StockMaster boItemFG)
        {



            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("FGID", boItemFG.FGID1);
                ht.Add("FGDate", boItemFG.FGDate1);
                ht.Add("WhareHouseID", boItemFG.WhareHouseID1);
                ht.Add("SerialNumber", boItemFG.FGSerialNumber1);
                ht.Add("CompanyID", boItemFG.CompanyID1);
                ht.Add("Year", boItemFG.Year1);
                ht.Add("IsActive", boItemFG.IsActive1);
                ht.Add("CreatedBy", boItemFG.CreatedBy1);
                ht.Add("CreatedDate", boItemFG.CreatedDate1);
                ht.Add("UpdatedBy", boItemFG.UpdatedBy1);
                ht.Add("UpdatedDate", boItemFG.UpdatedDate1);
               



                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_FG"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}