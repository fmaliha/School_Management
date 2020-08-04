﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_ProductionStore
    {
        PBSDBUtility idbutility = new PBSDBUtility();


        public long InsertPBML_SDM_ProductStore(BOPBML_SDM_ProductionStore boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("StoreID", boItem.StoreID1);
                ht.Add("QCID", boItem.QCID1);
                ht.Add("ProductionID", boItem.ProductionID1);
                ht.Add("ProductID", boItem.ProductID1);
                ht.Add("ProductGroupID", boItem.ProductGroupID1);
                ht.Add("ThiknessID", boItem.ThiknessID1);
                ht.Add("SizeID", boItem.SizeID1);
                ht.Add("ColorCode", boItem.ColorCode1);
                ht.Add("UnitID", boItem.UnitID1);
                ht.Add("ShiftID", boItem.ShiftID1);
                ht.Add("QCQuantity", boItem.QCQuantity1);
                ht.Add("ProductGradeID", boItem.ProductGradeID1);
                ht.Add("StoreQuantity", boItem.StoreQuantity1);
                ht.Add("StoreDate", boItem.StoreDate1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("YYear", boItem.YYear1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("SerialNumber", boItem.SerialNumber1);


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_ProductionStore"));

            }
            catch (Exception ex)
            {
                throw ex;


            }
        }
    }
}