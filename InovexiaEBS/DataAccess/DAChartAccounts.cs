using System;

using PBSConnLib;
using System.Collections;


    public class DAChartAccounts
    {
        PBSDBUtility iDBUtility = new PBSDBUtility();

        public DAChartAccounts()
        { }



        public long insertAC1(BOChartAccounts  boaddemp)
        {
            Hashtable ht = new Hashtable();

            ht.Add("AC1", boaddemp.AC11 );
            ht.Add("AC1ManualCode", boaddemp.AC1ManualCode1);
            ht.Add("AC1Name", boaddemp.AC1Name1 );
            ht.Add("Transfered ", boaddemp.Transfered1 );
            ht.Add("AddedBy", boaddemp.AddedBy1 );
            ht.Add("DateAdded ", boaddemp.DateAdded1 );
            ht.Add("UpdatedBy", boaddemp.UpdatedBy1 );
            ht.Add("DateUpdated", boaddemp.DateUpdated1 );
            return Convert.ToInt32(iDBUtility.InsertData(ht, "spInsertAC1"));

        }



        public long insertAC2(BOChartAccounts boaddemp)
        {
            Hashtable ht = new Hashtable();                

            ht.Add("AC1", boaddemp.AC11);
            ht.Add("AC2", boaddemp.AC21 );
            ht.Add("AC2ManualCode", boaddemp.AC2ManualCode1);
            ht.Add("AC2Name", boaddemp.AC2Name1 );
            ht.Add("Transfered ", boaddemp.Transfered1);
            ht.Add("AddedBy", boaddemp.AddedBy1);
            ht.Add("DateAdded ", boaddemp.DateAdded1);
            ht.Add("UpdatedBy", boaddemp.UpdatedBy1);
            ht.Add("DateUpdated", boaddemp.DateUpdated1);




            return Convert.ToInt32(iDBUtility.InsertData(ht, "spInsertAC2"));

        }



        public long insertAC3(BOChartAccounts boaddemp)
        {
            Hashtable ht = new Hashtable();
            ht.Add("AC1", boaddemp.AC11);
            ht.Add("AC2", boaddemp.AC21);
            ht.Add("AC3", boaddemp.AC31 );
            ht.Add("AC3ManualCode", boaddemp.AC3ManualCode1);
            ht.Add("AC3Name", boaddemp.AC3Name1 );
            ht.Add("IsInActive", boaddemp.IsInActive1 );
            ht.Add("Transfered ", boaddemp.Transfered1);
            ht.Add("AddedBy", boaddemp.AddedBy1);
            ht.Add("DateAdded ", boaddemp.DateAdded1);
            ht.Add("UpdatedBy", boaddemp.UpdatedBy1);
            ht.Add("DateUpdated", boaddemp.DateUpdated1);
            return Convert.ToInt32(iDBUtility.InsertData(ht, "spInsertAC3"));
        }


        public long insertAC4(BOChartAccounts boaddemp)
        {
            Hashtable ht = new Hashtable();

            ht.Add("AC1", boaddemp.AC11);
            ht.Add("AC2", boaddemp.AC21);
            ht.Add("AC3", boaddemp.AC31);
            ht.Add("AC4", boaddemp.AC41 );
            ht.Add("AC4ManualCode", boaddemp.AC4ManualCode1);
            ht.Add("AC4Name", boaddemp.AC4Name1 );
            ht.Add("IsInActive", boaddemp.IsInActive1);
            ht.Add("Transfered ", boaddemp.Transfered1);
            ht.Add("AddedBy", boaddemp.AddedBy1);
            ht.Add("DateAdded ", boaddemp.DateAdded1);
            ht.Add("UpdatedBy", boaddemp.UpdatedBy1);
            ht.Add("DateUpdated", boaddemp.DateUpdated1);




            return Convert.ToInt32(iDBUtility.InsertData(ht, "spInsertAC4"));

        }


        public long insertACDetail(BOChartAccounts boaddemp)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("ACode", boaddemp.ACode1);
                ht.Add("AC1", boaddemp.AC11);
                ht.Add("AC2", boaddemp.AC21);
                ht.Add("AC3", boaddemp.AC31);
                ht.Add("AC4", boaddemp.AC41);
                ht.Add("AC5", boaddemp.AC51);
                ht.Add("ACName", boaddemp.ACName1);
                //ht.Add("EntryType", boaddemp.EntryType1);
                ht.Add("TransactionType", boaddemp.TransactionType1);
                ht.Add("IsInActive", boaddemp.IsInActive1);
                ht.Add("Transfered ", boaddemp.Transfered1);
                ht.Add("AddedBy", boaddemp.AddedBy1);
                ht.Add("DateAdded ", boaddemp.DateAdded1);
                ht.Add("UpdatedBy", boaddemp.UpdatedBy1);
                ht.Add("DateUpdated", boaddemp.DateUpdated1);
                ht.Add("OpeningBalance", boaddemp.OpeningBalance1);
                ht.Add("OpeningBalanceDate", boaddemp.OpeningBalanceDate1);

                return Convert.ToInt32(iDBUtility.InsertData(ht, "spInsertACDetail"));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public long updateACDetail(BOChartAccounts boaddemp)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("ACode", boaddemp.ACode1);
                ht.Add("AC1", boaddemp.AC11);
                ht.Add("AC2", boaddemp.AC21);
                ht.Add("AC3", boaddemp.AC31);
                ht.Add("AC4", boaddemp.AC41);


                ht.Add("ACName", boaddemp.ACName1);
                ht.Add("OpeningBalance", boaddemp.OpeningBalance1);
                ht.Add("UpdatedBy", boaddemp.UpdatedBy1);
                ht.Add("DateUpdated", boaddemp.DateUpdated1);


                return Convert.ToInt32(iDBUtility.InsertData(ht, "spUpdateACDetail"));
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public long InsertACDetailReportHead(BOChartAccounts boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("ACode", boItem.ACode1);
                ht.Add("ReportHead", boItem.ReportHead1);
             
                return Convert.ToInt64(iDBUtility.InsertData(ht, "spInsertDenim_FM_ACDetailReportHead"));

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
