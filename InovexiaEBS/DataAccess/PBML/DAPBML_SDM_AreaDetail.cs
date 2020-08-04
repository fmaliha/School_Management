using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_AreaDetail
    {
        PBSDBUtility idbutility = new PBSDBUtility();

        public long InsertPBML_SDM_AreaDetail(BOPBML_SDM_AreaDetail boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("AreaID", boItem.AreaID1);
                ht.Add("EmployeeCode", boItem.EmployeeCode1);
                ht.Add("StartDate", boItem.StartDate1);
                ht.Add("EndDate", boItem.EndDate1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);



                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_AreaDetail"));

            }
            catch (Exception ex)
            {
                throw ex;


            }

        }
    }
}