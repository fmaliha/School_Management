using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;
namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_StockTranDetail
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_StockTranDetail(BOPBML_SDM_StockTranDetail boItem)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("StockTranID", boItem.StockTranID1);
                ht.Add("ProuductCode", boItem.ProuductCode1);
                ht.Add("Quantity", boItem.Quantity1);
                ht.Add("TransactionType", boItem.TransactionType1);
                ht.Add("EntryNO", boItem.EntryNO1);
                ht.Add("Remarks", boItem.Remarks1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("IsStockIn", boItem.IsStockIn1);



                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_StockTranDetail"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertPBML_SDM_FGDetail(BOPBML_SDM_StockTranDetail boItemFGD)
        {



            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("FGID", boItemFGD.FGID1);
                ht.Add("ProuductCode", boItemFGD.ProuductCode1);
                ht.Add("Quantity", boItemFGD.Quantity1);
                ht.Add("Remarks", boItemFGD.Remarks1);
                ht.Add("IsActive", boItemFGD.IsActive1);
                ht.Add("CreatedBy", boItemFGD.CreatedBy1);
                ht.Add("CreatedDate", boItemFGD.CreatedDate1);
                ht.Add("UpdatedBy", boItemFGD.UpdatedBy1);
                ht.Add("UpdatedDate", boItemFGD.UpdatedDate1);
                



                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_FGDetail"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}