using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_DCMaster
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_DCMaster(BOPBML_SDM_DCMaster boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("DCNO", boItem.DCNO1);
                ht.Add("DCDate", boItem.DCDate1);
                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("WhareHouseID", boItem.WhareHouseID1);
                ht.Add("GatePass", boItem.GatePass1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("Remarks", boItem.Remarks1);
                ht.Add("DCSerialNumber", boItem.DCSerialNumber1);
                ht.Add("PYear", boItem.PYear1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("ISSI", boItem.ISSI1);

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_DCMaster"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertPBML_SDM_DCMasterSpecial(BOPBML_SDM_DCMaster doObj, string DONOSPECIAL)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("DCNO", doObj.DCNO1);
                ht.Add("DCDate", doObj.DCDate1);
                ht.Add("DealerID", doObj.DealerID1);
                ht.Add("WhareHouseID", doObj.WhareHouseID1);
                ht.Add("GatePass", doObj.GatePass1);
                ht.Add("CompanyID", doObj.CompanyID1);
                ht.Add("Remarks", doObj.Remarks1);
                ht.Add("DCSerialNumber", doObj.DCSerialNumber1);
                ht.Add("PYear", doObj.PYear1);
                ht.Add("IsActive", doObj.IsActive1);
                ht.Add("CreatedBy", doObj.CreatedBy1);
                ht.Add("CreatedDate", doObj.CreatedDate1);
                ht.Add("UpdatedBy", doObj.UpdatedBy1);
                ht.Add("UpdatedDate", doObj.UpdatedDate1);
                ht.Add("ISSI", doObj.ISSI1);
                ht.Add("DONOSPECIAL", DONOSPECIAL);

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_DCMasterSpecial"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}