using System;
using System.Collections;

using PBSConnLib;

namespace InovexiaEBS
{
    public class DAStockIn
    {
        PBSDBUtility idb = new PBSDBUtility();
        public long insertPJV(BOStockIn boaddemp)
        {
            try
            {
                var ht = new Hashtable();
                ht.Add("PVNO", boaddemp.PJVNO1);
                ht.Add("PVDate", boaddemp.PJVDate1);
                ht.Add("company_id", boaddemp.Company_id);
                ht.Add("Narration", boaddemp.Narration1);
                ht.Add("ACodeTo", boaddemp.ACode1To);
                ht.Add("ACodeBy", boaddemp.ACode1By);
                ht.Add("ProductID", boaddemp.ProductID1);
                ht.Add("WareHouseID", boaddemp.WareHouseID1);
                ht.Add("Quantity", boaddemp.Quantity1);
                ht.Add("Rate", boaddemp.Rate1);
                ht.Add("EntryID", boaddemp.EntryID1);
                ht.Add("EntryDate", boaddemp.EntryDate1);
                ht.Add("UpdateID", boaddemp.UpdateID1);
                ht.Add("UpdateDate", boaddemp.UpdateDate1);
                ht.Add("VMonth", boaddemp.VMonth1);
                ht.Add("VYear", boaddemp.VYear1);
                ht.Add("PVSerial", boaddemp.PVSerial1);
                return Convert.ToInt32(idb.InsertData(ht, "spInsertPJV"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }
    }
}