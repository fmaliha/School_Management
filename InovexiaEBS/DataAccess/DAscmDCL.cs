using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using System.Collections.Generic;
using PBSConnLib;


    public class DAscmDCL
    {

        PBSDBUtility  idbutility  = new PBSDBUtility();

        public DAscmDCL()
        { }


        public long InsertMRFMaster(BOAddMRF  objBO)
        {



            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("MRFNo", objBO.MRFNo1 );
                ht.Add("MRFDate", objBO.MRFDate1 );
                ht.Add("GPNO", objBO.GPNO1 );
                ht.Add("ABTeamLeader", objBO.ABTeamLeader1 );
                ht.Add("PBStore", objBO.PBStore1 );
                ht.Add("ABAccounts", objBO.ABAccounts1 );
                ht.Add("ABMarketing", objBO.ABMarketing1 );
                ht.Add("ABCEO", objBO.ABCEO1 );
                ht.Add("IsActive", objBO.IsActive1 );
                ht.Add("MRFYear", objBO.MRFYear1 );
                ht.Add("MRFSerial", objBO.MRFSerial1 );             
                ht.Add("EntryID", objBO.EntryID1);
                ht.Add("EntryDate", objBO.EntryDate1);
                ht.Add("UpdateID", objBO.UpdateID1);
                ht.Add("UpdateDate", objBO.UpdateDate1);

                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertMRFMasterDCL"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public long InsertMRFDetail(BOAddMRF objBO)
        {



            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("MRFNo", objBO.MRFNo1 );
                ht.Add("ProductID", objBO.ProductID1 );
                ht.Add("Quantity", objBO.Quantity1 );
                ht.Add("ClientID", objBO.ClientID1 );
                ht.Add("Address", objBO.Address1 );
                ht.Add("SalesFormNo", objBO.SalesFormNo1 );
                ht.Add("IsBillingInfo", objBO.IsBillingInfo1 );
                ht.Add("IsSPR", objBO.IsSPR1 );
                ht.Add("Remarks", objBO.Remarks1 );
                ht.Add("IsGatePass", objBO.IsGatePass1 );


                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertMRFDetailDCL"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
