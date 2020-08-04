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
using PBSConnLib ;

    public class DAStock
    {
        PBSDBUtility idbutility = new PBSDBUtility();

        public DAStock()
        {
        }

        public long InsertStockDealer(BOStock objBO)
        {


            try
            {


                Hashtable ht = new Hashtable();
               
                ht.Add("StockDate", objBO.StockDate1);
                ht.Add("StoreID", objBO.StoreID1);
                ht.Add("ProductID", objBO.ProductID1);
                ht.Add("DealerID", objBO.PONO1);
                ht.Add("PurchaseDate", objBO.PurchaseDate1);
                ht.Add("VendorID", objBO.VendorID1);
                ht.Add("InQuantity", objBO.InQuantity1);
                ht.Add("Rate", objBO.Rate1);
                ht.Add("OutQuantity", objBO.OutQuantity1);
                ht.Add("StockStatus", objBO.StockStatus1);
                ht.Add("Remarks", objBO.Remarks1);
                ht.Add("EntryID", objBO.EntryID1);
                ht.Add("EntryDate", objBO.EntryDate1);
                ht.Add("UpdateID", objBO.UpdateID1);
                ht.Add("UpdateDate", objBO.UpdateDate1);
                ht.Add("IsStockIn", objBO.IsStockIn1);
                ht.Add("TMonth", objBO.MRFNo1);
                ht.Add("TYear", objBO.GRRNo1);
                ht.Add("MobileNo", objBO.Mobileno1 );
                ht.Add("SMSContent", objBO.Smscontent1 );




                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertStockDealer"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertStock(BOStock   objBO)
        {

            
            try

            {

  
                 Hashtable ht = new Hashtable();
                 ht.Add("StockTranID", objBO.StockTranID1 );
                 ht.Add("StockDate", objBO.StockDate1 );
                 ht.Add("StoreID", objBO.StoreID1 );
                 ht.Add("ProductID", objBO.ProductID1 );
                 ht.Add("PONO", objBO.PONO1 );
                 ht.Add("PurchaseDate", objBO.PurchaseDate1 );
                 ht.Add("VendorID", objBO.VendorID1 );
                 ht.Add("InQuantity", objBO.InQuantity1 );
                 ht.Add("Rate", objBO.Rate1 );
                 ht.Add("OutQuantity", objBO.OutQuantity1 );
                 ht.Add("StockStatus", objBO.StockStatus1 );
                 ht.Add("Remarks", objBO.Remarks1 );
                 ht.Add("EntryID", objBO.EntryID1);
                 ht.Add("EntryDate", objBO.EntryDate1);
                 ht.Add("UpdateID", objBO.UpdateID1);
                 ht.Add("UpdateDate", objBO.UpdateDate1 );
                 ht.Add("IsStockIn", objBO.IsStockIn1 );
                 ht.Add("TMonth", objBO.MRFNo1);
                 ht.Add("TYear", objBO.GRRNo1);


                 ht.Add("TranType", objBO.TranType1 );
                 ht.Add("VATPercent", objBO.VATPercent1);
                 ht.Add("VATAmount", objBO.VATAmount1);
                 ht.Add("IsPaid", objBO.IsPaid1);
                 ht.Add("PaidRefNo", objBO.PaidRefNo1);
                 ht.Add("StockStatusID", objBO.StockStatusID1);
                 ht.Add("SupplierStyle", objBO.SupplierStyle1);


                
               


                 return Convert.ToInt64(idbutility.InsertData(ht, "spInsertStock"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertStockImport(BOStock objBO)
        {


            try
            {


                Hashtable ht = new Hashtable();
                ht.Add("StockTranID", objBO.StockTranID1);
                ht.Add("StockDate", objBO.StockDate1);
                ht.Add("StoreID", objBO.StoreID1);
                ht.Add("ProductID", objBO.ProductID1);
                ht.Add("PONO", objBO.PONO1);
                ht.Add("PurchaseDate", objBO.PurchaseDate1);
                ht.Add("VendorID", objBO.VendorID1);
                ht.Add("InQuantity", objBO.InQuantity1);
                ht.Add("Rate", objBO.Rate1);
                ht.Add("OutQuantity", objBO.OutQuantity1);
                ht.Add("StockStatus", objBO.StockStatus1);
                ht.Add("Remarks", objBO.Remarks1);
                ht.Add("EntryID", objBO.EntryID1);
                ht.Add("EntryDate", objBO.EntryDate1);
                ht.Add("UpdateID", objBO.UpdateID1);
                ht.Add("UpdateDate", objBO.UpdateDate1);
                ht.Add("IsStockIn", objBO.IsStockIn1);
                ht.Add("TMonth", objBO.MRFNo1);
                ht.Add("TYear", objBO.GRRNo1);
                ht.Add("PINo", objBO.PINo1 );
                ht.Add("PIDate", objBO.PIDate1 );
                ht.Add("ImportStatus", objBO.ImportStatus1 );
                ht.Add("IsReceive", objBO.IsReceive1);
                




                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertStockImport"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public long UpdateStock(BOStock objBO)
        {


            try
            {


                Hashtable ht = new Hashtable();
                ht.Add("StockTranID", objBO.StockTranID1);
                ht.Add("StockDate", objBO.StockDate1);
                ht.Add("StoreID", objBO.StoreID1);
                ht.Add("ProductID", objBO.ProductID1);
                ht.Add("PONO", objBO.PONO1);
                ht.Add("PurchaseDate", objBO.PurchaseDate1);
                ht.Add("VendorID", objBO.VendorID1);
                ht.Add("InQuantity", objBO.InQuantity1);
                ht.Add("Rate", objBO.Rate1);
                ht.Add("OutQuantity", objBO.OutQuantity1);
                ht.Add("StockStatus", objBO.StockStatus1);
                ht.Add("Remarks", objBO.Remarks1);
                ht.Add("EntryID", objBO.EntryID1);
                ht.Add("EntryDate", objBO.EntryDate1);
                ht.Add("UpdateID", objBO.UpdateID1);
                ht.Add("UpdateDate", objBO.UpdateDate1);
                ht.Add("IsStockIn", objBO.IsStockIn1);
                ht.Add("FloorID", objBO.MRFNo1);
                ht.Add("WorkTitleID", objBO.GRRNo1);

                //MRFNo
                //GRRNo


                return Convert.ToInt64(idbutility.InsertData(ht, "spUpdateStockInfo"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertMIOF(BOMIOF  objBO)
        {


            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("MIOFNo", objBO.MIOFNo1 );
                ht.Add("MIOFDate", objBO.MIOFDate1 );
                ht.Add("company_id", objBO.Company_id );
                ht.Add("MRFNo", objBO.MRFNo1 );
                ht.Add("EmployeeID", objBO.EmployeeID1 );
                ht.Add("DeliveryType", objBO.DeliveryType1 );
                ht.Add("Remarks", objBO.Remarks1 );
                ht.Add("MIOFYear", objBO.MIOFYear1 );
                ht.Add("EntryID", objBO.EntryID1 );
                ht.Add("EntryDate", objBO.EntryDate1 );
                ht.Add("UpdateID", objBO.UpdateID1 );
                ht.Add("UpdateDate", objBO.UpdateDate1 );
                ht.Add("MIOFType", objBO.MIOFType1 );
               
                return Convert.ToInt64(idbutility.InsertData(ht, "InsertMIOFDCL"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public long InsertMIOFDetail(BOMIOF objBO)
        {


            try
            {

    
                Hashtable ht = new Hashtable();
                ht.Add("MIOFNo", objBO.MIOFNo1);
                ht.Add("MRFNo", objBO.MRFNo1);
                ht.Add("ProductID", objBO.ProductID1 );
                ht.Add("Quantity", objBO.Quantity1 );
                ht.Add("Rate", objBO.Rate1 );
               

                return Convert.ToInt64(idbutility.InsertData(ht, "InsertMIODetailsFDCL"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        //-------------AADL--------------------------------------

        public long InsertProjectEstimation(BOProjectEstimation  objBO)
        {


            try
            {


   
                Hashtable ht = new Hashtable();
                ht.Add("TransactionID", objBO.TransactionID1 );
                ht.Add("StoreID", objBO.StoreID1 );
                ht.Add("FloorID", objBO.FloorID1 );
                ht.Add("WorkTitleID", objBO.WorkTitleID1 );
                ht.Add("ProductID", objBO.ProductID1 );
                ht.Add("Quantity", objBO.Quantity1 );
                ht.Add("Rate", objBO.Rate1 );
                ht.Add("Amount", objBO.Amount1 );
                 ht.Add("Remarks", objBO.Remarks1 );
                ht.Add("EntryID", objBO.EntryID1);
                ht.Add("EntryDate", objBO.EntryDate1);
                ht.Add("UpdateID", objBO.UpdateID1);
                ht.Add("UpdateDate", objBO.UpdateDate1);




                return Convert.ToInt64(idbutility.InsertData(ht, "ZspProjectEstimate"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
