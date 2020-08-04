using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;

namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_SRDetail
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_SRDetail(BOPBML_SDM_SRDetail boItem)
        {
            try
            {
                var ht = new Hashtable();
                ht.Add("SRID", boItem.SRID1);
                ht.Add("RegionID", boItem.RegionID1 );
                ht.Add("AreaID", boItem.AreaID1);
                ht.Add("SRName", boItem.DealerCode1);
                ht.Add("StartDate", boItem.StartDate1);
                ht.Add("EndDate", boItem.EndDate1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("MobileNo", boItem.MobileNo1 );

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_SRDetail"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long insertSalesForceMasterDA(BOPBML_SDM_SRDetail boItem)
        {
            try
            {
     
                var ht = new Hashtable();

                ht.Add("FieldID", boItem.FieldID1 );
                ht.Add("FieldName", boItem.FieldName1);
                ht.Add("NationID", boItem.NationID1 );
                ht.Add("ZoneID", boItem.ZoneID1);
                ht.Add("AreaID", boItem.AreaID1);
                ht.Add("TerritoryID", boItem.TerritoryID1);
                ht.Add("IsNation", boItem.IsNation1);
                ht.Add("IsZone", boItem.IsZone1);
                ht.Add("IsArea", boItem.IsArea1);
                ht.Add("IsTerritory", boItem.IsTerritory1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdateID", boItem.UpdatedBy1);
                ht.Add("UpdateDate", boItem.UpdatedDate1);


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertSalesForceMaster"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long insertSalesForceDeatilDA(BOPBML_SDM_SRDetail boItem)
        {
            try
            {

     
                var ht = new Hashtable();

                ht.Add("EmpID", boItem.EmpID1 );
                ht.Add("EmpCode", boItem.EmpCode1);
                ht.Add("EmpName", boItem.EmpName1);
                ht.Add("Designation", boItem.Designation1);
                ht.Add("Department", boItem.Department1);
                ht.Add("EmailID", boItem.EmailID1);
                ht.Add("MobileNo", boItem.MobileNo1);
                ht.Add("FieldID", boItem.FieldID1);
                ht.Add("StartDate", boItem.StartDate1);
                ht.Add("EndDate", boItem.EndDate1);            
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("IsSMS", boItem.IsSMS1);
                ht.Add("SalesForceTypeID", boItem.SalesForceTypeID1);


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertSalesForceDetail"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long insertSalesForceFieldDA(BOPBML_SDM_SRDetail boItem)
        {
            try
            {


                var ht = new Hashtable();
                ht.Add("SNID", boItem.SNID1);
                ht.Add("EmpID", boItem.EmpID1);
                ht.Add("EmpCode", boItem.EmpCode1);
                ht.Add("EmpName", boItem.EmpName1);
                ht.Add("Designation", boItem.Designation1);
                ht.Add("Department", boItem.Department1);
                ht.Add("EmailID", boItem.EmailID1);
                ht.Add("MobileNo", boItem.MobileNo1);
                ht.Add("FieldID", boItem.FieldID1);
                ht.Add("StartDate", boItem.StartDate1);
                ht.Add("EndDate", boItem.EndDate1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("IsSMS", boItem.IsSMS1);
                ht.Add("SalesForceTypeID", boItem.SalesForceTypeID1);


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertSalesForceField"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long insertSalesForceDealerDA(BOPBML_SDM_SRDetail boItem)
        {
            try
            {


                var ht = new Hashtable();

                ht.Add("ID", boItem.SNID1);
                ht.Add("EmpID", boItem.EmpID1);
                ht.Add("DealerID", boItem.DealerCode1 );                
                ht.Add("StartDate", boItem.StartDate1);
                ht.Add("EndDate", boItem.EndDate1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdateID", boItem.UpdatedBy1);
                ht.Add("UpdateDate", boItem.UpdatedDate1);



                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertSalesForceDealer"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public long insertDealerTerritoryDA(BOPBML_SDM_SRDetail boItem)
        {
            try
            {


                var ht = new Hashtable();

                ht.Add("ID", boItem.SNID1);
                ht.Add("FieldID", boItem.EmpID1);
                ht.Add("DealerID", boItem.DealerCode1);
                ht.Add("StartDate", boItem.StartDate1);
                ht.Add("EndDate", boItem.EndDate1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdateID", boItem.UpdatedBy1);
                ht.Add("UpdateDate", boItem.UpdatedDate1);



                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertDealerTerritory"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertPBML_SalesManCreditLimit(BOPBML_SDM_SRDetail boItem)
        {
            try
            {
                var ht = new Hashtable();
                ht.Add("SRID", boItem.SRID1);              
                ht.Add("StartDate", boItem.StartDate1);
                ht.Add("EndDate", boItem.EndDate1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("CreditAmount", boItem.Salesmancredit );

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertSalesManCredit"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}