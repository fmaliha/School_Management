using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using PBSConnLib;
using System.Collections;



    public class DASalesInvoice
    {

        PBSDBUtility idb = new PBSDBUtility();

       



        public long InsertCombinationOfferMasterAmountDA(BOSalesInvoicecs boaddemp)
        {
            try
            {
                


                var ht = new Hashtable();

                ht.Add("SNID", boaddemp.SNID1);
                ht.Add("OfferID", boaddemp.OfferID1);
                ht.Add("OfferName", boaddemp.OfferName1);
                ht.Add("DTID", boaddemp.DTID1);
                ht.Add("DMID", boaddemp.DMID1);             
                ht.Add("MinValue", boaddemp.MinValue1);
                ht.Add("MaxValue", boaddemp.MaxValue1);
                ht.Add("OfferValue", boaddemp.OfferValue1);
                ht.Add("StarDate", boaddemp.StarDate1);
                ht.Add("EndDate", boaddemp.EndDate1);
                ht.Add("IsActive", boaddemp.IsActive1);
                ht.Add("CreatedBy", boaddemp.CreatedBy1);
                ht.Add("CreatedDate", boaddemp.CreatedDate1);
                ht.Add("UpdateID", boaddemp.UpdateID1);
                ht.Add("UpdateDate", boaddemp.UpdateDate1);
                ht.Add("MultiPlyQy", boaddemp.MultiPlyQy1);

                return Convert.ToInt32(idb.InsertData(ht, "spInsertCombinationMasterAmnt"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }


        public long InsertCombinationProductAmountDA(BOSalesInvoicecs boaddemp)
        {
            try
            {


                var ht = new Hashtable();


                ht.Add("OfferID", boaddemp.OfferID1);
                ht.Add("ProductID", boaddemp.ProductID1);
                ht.Add("MinValue", boaddemp.MinValue1);
                ht.Add("MaxValue", boaddemp.MaxValue1);
                ht.Add("IsActive", boaddemp.IsActive1);
                ht.Add("CreatedBy", boaddemp.CreatedBy1);
                ht.Add("CreatedDate", boaddemp.CreatedDate1);
                ht.Add("UpdateID", boaddemp.UpdateID1);
                ht.Add("UpdateDate", boaddemp.UpdateDate1);


                return Convert.ToInt32(idb.InsertData(ht, "spInsertCombinationPrdAmnt"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }




        public long InsertCombinationOfferMasterDA(BOSalesInvoicecs boaddemp)
        {
            try
            {

                var ht = new Hashtable();

                ht.Add("SNID", boaddemp.SNID1);
                ht.Add("OfferID", boaddemp.OfferID1 );
                ht.Add("OfferName", boaddemp.OfferName1);
                ht.Add("StarDate", boaddemp.StarDate1);
                ht.Add("EndDate", boaddemp.EndDate1);
                ht.Add("DTID", boaddemp.DTID1);
                ht.Add("DMID", boaddemp.DMID1);
                ht.Add("MinValue", boaddemp.MinValue1);
                ht.Add("MaxValue", boaddemp.MaxValue1);
                ht.Add("OfferValue", boaddemp.OfferValue1);
                ht.Add("IsActive", boaddemp.IsActive1);
                ht.Add("CreatedBy", boaddemp.CreatedBy1);
                ht.Add("CreatedDate", boaddemp.CreatedDate1);
                ht.Add("UpdateID", boaddemp.UpdateID1);
                ht.Add("UpdateDate", boaddemp.UpdateDate1);
                ht.Add("MultiPlyQy", boaddemp.MultiPlyQy1);            
                
                return Convert.ToInt32(idb.InsertData(ht, "spInsertCombinationOfferMaster"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }



        public long InsertCombinationProductDA(BOSalesInvoicecs boaddemp)
        {
            try
            {

                var ht = new Hashtable();

               
                ht.Add("OfferID", boaddemp.OfferID1);
                ht.Add("ProductID", boaddemp.ProductID1);
                ht.Add("IsActive", boaddemp.IsActive1);
                ht.Add("CreatedBy", boaddemp.CreatedBy1);
                ht.Add("CreatedDate", boaddemp.CreatedDate1);
                ht.Add("UpdateID", boaddemp.UpdateID1);
                ht.Add("UpdateDate", boaddemp.UpdateDate1);


                return Convert.ToInt32(idb.InsertData(ht, "spInsertCombinationProduct"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }


        public long InsertCombinationAwardDA(BOSalesInvoicecs boaddemp)
        {
            try
            {

                var ht = new Hashtable();


                ht.Add("OfferID", boaddemp.OfferID1);
                ht.Add("ProductID", boaddemp.ProductID1);
                ht.Add("IsActive", boaddemp.IsActive1);
                ht.Add("CreatedBy", boaddemp.CreatedBy1);
                ht.Add("CreatedDate", boaddemp.CreatedDate1);
                ht.Add("UpdateID", boaddemp.UpdateID1);
                ht.Add("UpdateDate", boaddemp.UpdateDate1);


                return Convert.ToInt32(idb.InsertData(ht, "spInsertCombinationAward"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }


        public long InsertDiscountMasterDA(BOSalesInvoicecs boaddemp)
        {
            try
            {

                var ht = new Hashtable();
                

                ht.Add("DiscountID", boaddemp.OfferID1);
                ht.Add("DiscountName", boaddemp.OfferName1);
                ht.Add("StarDate", boaddemp.StarDate1);
                ht.Add("EndDate", boaddemp.EndDate1);             
            
                ht.Add("IsActive", boaddemp.IsActive1);
                ht.Add("CreatedBy", boaddemp.CreatedBy1);
                ht.Add("CreatedDate", boaddemp.CreatedDate1);
                ht.Add("UpdateID", boaddemp.UpdateID1);
                ht.Add("UpdateDate", boaddemp.UpdateDate1);
                    


                return Convert.ToInt32(idb.InsertData(ht, "spInsertDiscountMaster"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }



        public long InsertDiscountDetailDA(BOSalesInvoicecs boaddemp)
        {
            try
            {
                   

                var ht = new Hashtable();



                ht.Add("DiscountID", boaddemp.OfferID1 );
                ht.Add("ProductID", boaddemp.ProductID1);            
                ht.Add("DTID", boaddemp.DTID1);
                ht.Add("DMID", boaddemp.DMID1);
                ht.Add("MinValue", boaddemp.MinValue1);
                ht.Add("MaxValue", boaddemp.MaxValue1);
                ht.Add("DiscountValue", boaddemp.OfferValue1);
                ht.Add("StarDate", boaddemp.StarDate1);
                ht.Add("EndDate", boaddemp.EndDate1);               
                ht.Add("IsActive", boaddemp.IsActive1);
                ht.Add("CreatedBy", boaddemp.CreatedBy1);
                ht.Add("CreatedDate", boaddemp.CreatedDate1);
                ht.Add("UpdateID", boaddemp.UpdateID1);
                ht.Add("UpdateDate", boaddemp.UpdateDate1);
                 



                return Convert.ToInt32(idb.InsertData(ht, "spInsertDiscountDetail"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }




        public long insertTargetAmountDA(BOSalesInvoicecs boaddemp)
        {
            try
            {

                var ht = new Hashtable();

                ht.Add("SRID", boaddemp.SRID1 );
                ht.Add("TargetMonth", boaddemp.TargetMonth1 );
                ht.Add("TargetYear", boaddemp.TargetYear1 );
                ht.Add("SalesTargetAmount", boaddemp.SalesTargetAmount1);
                ht.Add("EntryID", boaddemp.EntryID1);
                ht.Add("EntryDate", boaddemp.EntryDate1 );
                ht.Add("UpdateID", boaddemp.UpdateID1);
                ht.Add("UpdateDate", boaddemp.UpdateDate1 );
                ht.Add("CategoryID", boaddemp.SalesCategoryid1);  

                
                return Convert.ToInt32(idb.InsertData(ht, "spInsertSalesTargetAmount"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }

        public long insertTargetProductDA(BOSalesInvoicecs boaddemp)
        {
            try
            {

   
                var ht = new Hashtable();

                ht.Add("SRID", boaddemp.SRID1);
                ht.Add("TargetMonth", boaddemp.TargetMonth1);
                ht.Add("TargetYear", boaddemp.TargetYear1);
                ht.Add("ProductID", boaddemp.ProductID1 );
                ht.Add("SalesTargetQty", boaddemp.SalesTargetQty1 );
                ht.Add("EntryID", boaddemp.EntryID1);
                ht.Add("EntryDate", boaddemp.EntryDate1);
                ht.Add("UpdateID", boaddemp.UpdateID1);
                ht.Add("UpdateDate", boaddemp.UpdateDate1);


                return Convert.ToInt32(idb.InsertData(ht, "spInsertSalesTargetProduct"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }


        public long insertInvoiceMaster(BOSalesInvoiceNew objItem)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("InvoiceID", objItem.InvoiceID);
                ht.Add("InvoiceDate", objItem.InvoiceDate);
                ht.Add("CompanyID", objItem.CompanyID);
                ht.Add("ClientID", objItem.ClientID);
                ht.Add("SalesInitiatorID", objItem.SalesInitiatorID);
                ht.Add("Remarks", objItem.Remarks);
                ht.Add("InvoiceType", objItem.InvoiceType);
                ht.Add("IsActive", objItem.IsActive);
                ht.Add("IsApprove", objItem.IsApprove);
                ht.Add("ApprovedBy", objItem.ApprovedBy);
                ht.Add("ApproveComments", objItem.ApproveComments);
                ht.Add("ApproveDate", objItem.ApproveDate);
                ht.Add("CreatedBy", objItem.CreatedBy);
                ht.Add("CreatedDate", objItem.CreatedDate);
                ht.Add("UpdateID", objItem.UpdateID);
                ht.Add("UpdateDate", objItem.UpdateDate);
                ht.Add("SIMonth", objItem.SIMonth);
                ht.Add("SIYear", objItem.SIYear);
                ht.Add("InvoiceIDSerial", objItem.InvoiceIDSerial);
                ht.Add("VatPercent", objItem.VatPercent);
                ht.Add("DiscountAmount", objItem.DiscountAmount);
                ht.Add("NetAmount", objItem.NetAmount);
                ht.Add("ReturnAmount", objItem.ReturnAmount);
                ht.Add("DamageAmount", objItem.DamageAmount);
                ht.Add("DiscountPercent", objItem.DiscountPercent);
                ht.Add("IsSalesApproval", objItem.IsSalesApproval);
                ht.Add("SalesApproveBy", objItem.SalesApproveBy);
                ht.Add("SalesApproveDate", objItem.SalesApproveDate);
                ht.Add("IsTransfer", objItem.IsTransfer);
                ht.Add("TransferNo", objItem.TransferNo);
                ht.Add("StoreID", objItem.StoreID);
                ht.Add("IsDC", objItem.IsDC);
                ht.Add("SalesType", objItem.SalesType);
                ht.Add("CashAmount", objItem.CashAmount);
                ht.Add("CardAmount", objItem.CardAmount);
                ht.Add("ChangeAmount", objItem.ChangeAmount);
                ht.Add("RecieveAmount", objItem.RecieveAmount);
                ht.Add("ServiceCharge", objItem.ServiceCharge);
                ht.Add("DeliveryCharge", objItem.DeliveryCharge);

                ht.Add("VatAmount", objItem.VatAmount1);
                
             

                return Convert.ToInt32(idb.InsertData(ht, "spInsertInvoiceMaster"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }


        public long insertPurchaseMasterDA(BOSalesInvoiceNew objItem)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("InvoiceID", objItem.InvoiceID);
                ht.Add("InvoiceDate", objItem.InvoiceDate);
                ht.Add("CompanyID", objItem.CompanyID);
                ht.Add("ClientID", objItem.ClientID);
                ht.Add("SalesInitiatorID", objItem.SalesInitiatorID);
                ht.Add("Remarks", objItem.Remarks);
                ht.Add("InvoiceType", objItem.InvoiceType);
                ht.Add("IsActive", objItem.IsActive);
                ht.Add("IsApprove", objItem.IsApprove);
                ht.Add("ApprovedBy", objItem.ApprovedBy);
                ht.Add("ApproveComments", objItem.ApproveComments);
                ht.Add("ApproveDate", objItem.ApproveDate);
                ht.Add("CreatedBy", objItem.CreatedBy);
                ht.Add("CreatedDate", objItem.CreatedDate);
                ht.Add("UpdateID", objItem.UpdateID);
                ht.Add("UpdateDate", objItem.UpdateDate);
                ht.Add("SIMonth", objItem.SIMonth);
                ht.Add("SIYear", objItem.SIYear);
                ht.Add("InvoiceIDSerial", objItem.InvoiceIDSerial);
                ht.Add("VatPercent", objItem.VatPercent);
                ht.Add("DiscountAmount", objItem.DiscountAmount);
                ht.Add("NetAmount", objItem.NetAmount);
                ht.Add("ReturnAmount", objItem.ReturnAmount);
                ht.Add("DamageAmount", objItem.DamageAmount);
                ht.Add("DiscountPercent", objItem.DiscountPercent);
                ht.Add("IsSalesApproval", objItem.IsSalesApproval);
                ht.Add("SalesApproveBy", objItem.SalesApproveBy);
                ht.Add("SalesApproveDate", objItem.SalesApproveDate);
                ht.Add("IsTransfer", objItem.IsTransfer);
                ht.Add("TransferNo", objItem.TransferNo);
                ht.Add("StoreID", objItem.StoreID);
                ht.Add("IsPAID", objItem.IsDC);
                ht.Add("SalesType", objItem.SalesType);
                ht.Add("CashAmount", objItem.CashAmount);
                ht.Add("CardAmount", objItem.CardAmount);
                ht.Add("ChangeAmount", objItem.ChangeAmount);
                ht.Add("RecieveAmount", objItem.RecieveAmount);
                ht.Add("ServiceCharge", objItem.ServiceCharge);
                ht.Add("DeliveryCharge", objItem.DeliveryCharge);
                ht.Add("VatAmount", objItem.VatAmount1);



                return Convert.ToInt32(idb.InsertData(ht, "spInsertPurchaseMaster"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }


        public long insertInvoiceMasterVAT(BOSalesInvoiceNew objItem)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("InvoiceID", objItem.InvoiceID);
                ht.Add("InvoiceDate", objItem.InvoiceDate);
                ht.Add("CompanyID", objItem.CompanyID);
                ht.Add("ClientID", objItem.ClientID);
                ht.Add("SalesInitiatorID", objItem.SalesInitiatorID);
                ht.Add("Remarks", objItem.Remarks);
                ht.Add("InvoiceType", objItem.InvoiceType);
                ht.Add("IsActive", objItem.IsActive);
                ht.Add("IsApprove", objItem.IsApprove);
                ht.Add("ApprovedBy", objItem.ApprovedBy);
                ht.Add("ApproveComments", objItem.ApproveComments);
                ht.Add("ApproveDate", objItem.ApproveDate);
                ht.Add("CreatedBy", objItem.CreatedBy);
                ht.Add("CreatedDate", objItem.CreatedDate);
                ht.Add("UpdateID", objItem.UpdateID);
                ht.Add("UpdateDate", objItem.UpdateDate);
                ht.Add("SIMonth", objItem.SIMonth);
                ht.Add("SIYear", objItem.SIYear);
                ht.Add("InvoiceIDSerial", objItem.InvoiceIDSerial);
                ht.Add("VatPercent", objItem.VatPercent);
                ht.Add("DiscountAmount", objItem.DiscountAmount);
                ht.Add("NetAmount", objItem.NetAmount);
                ht.Add("ReturnAmount", objItem.ReturnAmount);
                ht.Add("DamageAmount", objItem.DamageAmount);
                ht.Add("DiscountPercent", objItem.DiscountPercent);
                ht.Add("IsSalesApproval", objItem.IsSalesApproval);
                ht.Add("SalesApproveBy", objItem.SalesApproveBy);
                ht.Add("SalesApproveDate", objItem.SalesApproveDate);
                ht.Add("IsTransfer", objItem.IsTransfer);
                ht.Add("TransferNo", objItem.TransferNo);
                ht.Add("StoreID", objItem.StoreID);
                ht.Add("IsDC", objItem.IsDC);
                ht.Add("SalesType", objItem.SalesType);
                ht.Add("CashAmount", objItem.CashAmount);
                ht.Add("CardAmount", objItem.CardAmount);
                ht.Add("ChangeAmount", objItem.ChangeAmount);
                ht.Add("RecieveAmount", objItem.RecieveAmount);
                ht.Add("ServiceCharge", objItem.ServiceCharge);
                ht.Add("DeliveryCharge", objItem.DeliveryCharge);



                return Convert.ToInt32(idb.InsertData(ht, "spInsertInvoiceMasterVAT"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }
        public long insertInvoiceMaster_View(BOSalesInvoicecs boaddemp)
        {
            try
            {
                var ht = new Hashtable();
                ht.Add("InvoiceID", boaddemp.InvoiceID1);
                ht.Add("InvoiceDate", boaddemp.InvoiceDate1);
                ht.Add("CompanyID", boaddemp.CompanyID1);
                ht.Add("ClientID", boaddemp.ClientID1);
                ht.Add("SalesInitiatorID", boaddemp.SalesInitiatorID1);
                ht.Add("Remarks", boaddemp.Remarks1);
                ht.Add("InvoiceType", boaddemp.InvoiceType1);
                ht.Add("IsActive", boaddemp.IsActive1);
                ht.Add("IsApprove", boaddemp.IsApprove1);
                ht.Add("ApprovedBy", boaddemp.ApprovedBy1);
                ht.Add("ApproveComments", boaddemp.ApproveComments1);
                ht.Add("ApproveDate", boaddemp.ApproveDate1);
                ht.Add("CreatedBy", boaddemp.CreatedBy1);
                ht.Add("CreatedDate", boaddemp.CreatedDate1);
                ht.Add("UpdateID", boaddemp.UpdateID1);
                ht.Add("UpdateDate", boaddemp.UpdateDate1);
                ht.Add("SIMonth", boaddemp.SIMonth1);
                ht.Add("SIYear", boaddemp.SIYear1);
                ht.Add("InvoiceIDSerial", boaddemp.InvoiceIDSerial1);
                ht.Add("VatPercent", boaddemp.VatPercent1);
                ht.Add("DiscountAmount", boaddemp.DiscountAmount1);
                ht.Add("NetAmount", boaddemp.NetAmount1);
                ht.Add("DiscountPercent", boaddemp.DiscountPercent1);


                return Convert.ToInt32(idb.InsertData(ht, "spInsertInvoiceMaster_View"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }

        



        public long insertInvoiceDetail(BOSalesInvoicecs boaddemp)
        {
            try
            {
                var ht = new Hashtable();
                ht.Add("InvoiceID", boaddemp.InvoiceID1);
                ht.Add("ProductID", boaddemp.ProductID1 );
                ht.Add("Quantity", boaddemp.Quantity1 );
                ht.Add("Rate", boaddemp.Rate1 );
                ht.Add("Total", boaddemp.Total1 );
                ht.Add("IsActive", boaddemp.IsActive1 );
                ht.Add("IsApprove", boaddemp.IsApprove1 );
                ht.Add("DiscountQuantity", boaddemp.DiscountQTy1);

                ht.Add("DiscountPercent", boaddemp.DiscountPercent1 );
                ht.Add("DiscountAmount", boaddemp.DiscountAmount1);


                return Convert.ToInt32(idb.InsertData(ht, "spInsertInvoiceDetail"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }



        public long insertPurchaseDetailDA(BOSalesInvoicecs boaddemp)
        {
            try
            {
                var ht = new Hashtable();
                ht.Add("InvoiceID", boaddemp.InvoiceID1);
                ht.Add("ProductID", boaddemp.ProductID1);
                ht.Add("Quantity", boaddemp.Quantity1);
                ht.Add("Rate", boaddemp.Rate1);
                ht.Add("Total", boaddemp.Total1);
                ht.Add("IsActive", boaddemp.IsActive1);
                ht.Add("IsApprove", boaddemp.IsApprove1);
                ht.Add("DiscountQuantity", boaddemp.DiscountQTy1);
                ht.Add("DiscountPercent", boaddemp.DiscountPercent1);
                ht.Add("DiscountAmount", boaddemp.DiscountAmount1);
                ht.Add("Vat", boaddemp.VatPercent1);
                ht.Add("SupplierStyle", boaddemp.SupplierStyle1 );


                return Convert.ToInt32(idb.InsertData(ht, "spInsertPurchaseDetail"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }


        public long insertInvoiceDetailVAT(BOSalesInvoicecs boaddemp)
        {
            try
            {
                var ht = new Hashtable();
                ht.Add("InvoiceID", boaddemp.InvoiceID1);
                ht.Add("ProductID", boaddemp.ProductID1);
                ht.Add("Quantity", boaddemp.Quantity1);
                ht.Add("Rate", boaddemp.Rate1);
                ht.Add("Total", boaddemp.Total1);
                ht.Add("IsActive", boaddemp.IsActive1);
                ht.Add("IsApprove", boaddemp.IsApprove1);
                ht.Add("DiscountQuantity", boaddemp.DiscountQTy1);

                ht.Add("DiscountPercent", boaddemp.DiscountPercent1);
                ht.Add("DiscountAmount", boaddemp.DiscountAmount1);


                return Convert.ToInt32(idb.InsertData(ht, "spInsertInvoiceDetailVAT"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }



        public long insertInvoiceDetail_View(BOSalesInvoicecs boaddemp)
        {
            try
            {
                var ht = new Hashtable();
                ht.Add("InvoiceID", boaddemp.InvoiceID1);
                ht.Add("ProductID", boaddemp.ProductID1);
                ht.Add("Quantity", boaddemp.Quantity1);
                ht.Add("Rate", boaddemp.Rate1);
                ht.Add("Total", boaddemp.Total1);
                ht.Add("IsActive", boaddemp.IsActive1);
                ht.Add("IsApprove", boaddemp.IsApprove1);
                ht.Add("DiscountQuantity", boaddemp.DiscountQTy1);



                return Convert.ToInt32(idb.InsertData(ht, "spInsertInvoiceDetail_View"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }




        public long insertCombinationCalculationDA(BOSalesInvoicecs boaddemp)
        {
            try
            {
                                
                var ht = new Hashtable();
                ht.Add("SMSID", boaddemp.SMSID1 );
                ht.Add("ProductID", boaddemp.ProductID1);
                ht.Add("Quantity", boaddemp.Quantity1);
                ht.Add("OfferID", boaddemp.OfferID1 );



                return Convert.ToInt32(idb.InsertData(ht, "spCombinationCalculation"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }



        public long insertCombinationCalculationDA_View(BOSalesInvoicecs boaddemp)
        {
            try
            {

                var ht = new Hashtable();
                ht.Add("SMSID", boaddemp.SMSID1);
                ht.Add("ProductID", boaddemp.ProductID1);
                ht.Add("Quantity", boaddemp.Quantity1);
                ht.Add("OfferID", boaddemp.OfferID1);



                return Convert.ToInt32(idb.InsertData(ht, "spCombinationCalculation_View"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }


        public long insertInvoiceDetailSuppli(BOSalesInvoicecs boaddemp)
        {
            try
            {
                var ht = new Hashtable();
                ht.Add("InvoiceID", boaddemp.InvoiceID1);
                ht.Add("ProductID", boaddemp.ProductID1);
                ht.Add("Quantity", boaddemp.Quantity1);
                ht.Add("Rate", boaddemp.Rate1);
                ht.Add("Total", boaddemp.Total1);
                ht.Add("IsActive", boaddemp.IsActive1);
                ht.Add("IsApprove", boaddemp.IsApprove1);



                return Convert.ToInt32(idb.InsertData(ht, "spInsertInvoiceDetailSupli"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }


        public long insertInvoiceReturn(BOSalesInvoicecs boaddemp)
        {
            try
            {

                

                var ht = new Hashtable();

               
                ht.Add("InvoiceID", boaddemp.InvoiceID1);
                ht.Add("InvoiceDate", boaddemp.InvoiceDate1 );
                ht.Add("ReturnDate", boaddemp.ReturnDate1 );    
                ht.Add("ProductID", boaddemp.ProductID1);
                ht.Add("Quantity", boaddemp.Quantity1);
                ht.Add("Rate", boaddemp.Rate1);
                ht.Add("Total", boaddemp.Total1);
                ht.Add("IsActive", boaddemp.IsActive1);
                ht.Add("IsApprove", boaddemp.IsApprove1);
                ht.Add("ReturnQuantity", boaddemp.ReturnQty1 );
                ht.Add("DamageQuantity", boaddemp.DamageQTY1  );
               // ht.Add("DisReturnQuantity", boaddemp.DiscReturnQTy1 );



                return Convert.ToInt32(idb.InsertData(ht, "spInsertInvoiceReturn"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }



        public long insertDCMasterDA(BOSalesInvoiceNew objItem)
        {
            try
            {



             

                Hashtable ht = new Hashtable();

                ht.Add("DCNO", objItem.DCNO);
                ht.Add("DCDATE", objItem.DCDATE);
                ht.Add("InvoiceID", objItem.InvoiceID);
                ht.Add("CompanyID", objItem.CompanyID);
                ht.Add("ClientID", objItem.ClientID);
                ht.Add("SalesInitiatorID", objItem.SalesInitiatorID);
                ht.Add("Remarks", objItem.Remarks);
                ht.Add("InvoiceType", objItem.InvoiceType);
                ht.Add("IsActive", objItem.IsActive);
                ht.Add("IsApprove", objItem.IsApprove);
                ht.Add("ApprovedBy", objItem.ApprovedBy);
                ht.Add("ApproveComments", objItem.ApproveComments);
                ht.Add("ApproveDate", objItem.ApproveDate);
                ht.Add("CreatedBy", objItem.CreatedBy);
                ht.Add("CreatedDate", objItem.CreatedDate);
                ht.Add("UpdateID", objItem.UpdateID);
                ht.Add("UpdateDate", objItem.UpdateDate);
                ht.Add("SIMonth", objItem.SIMonth);
                ht.Add("SIYear", objItem.SIYear);
                ht.Add("DCSerial", objItem.DCSerial);
                ht.Add("StoreID", objItem.StoreID);
                ht.Add("GatePassNo", objItem.GatePassNo);
                ht.Add("VehicleNo", objItem.VehicleNo);
                ht.Add("DriverName", objItem.DriverName);
                ht.Add("DeliveryAddress", objItem.DeliveryAddress);





                return Convert.ToInt32(idb.InsertData(ht, "spInsertDCMaster"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }

        public long insert_Purchase_return_Master_DA(BOSalesInvoiceNew objItem)
        {
            try
            {





                Hashtable ht = new Hashtable();

                ht.Add("DCNO", objItem.DCNO);
                ht.Add("DCDATE", objItem.DCDATE);
                ht.Add("InvoiceID", objItem.InvoiceID);
                ht.Add("CompanyID", objItem.CompanyID);
                ht.Add("ClientID", objItem.ClientID);
                ht.Add("SalesInitiatorID", objItem.SalesInitiatorID);
                ht.Add("Remarks", objItem.Remarks);
                ht.Add("InvoiceType", objItem.InvoiceType);
                ht.Add("IsActive", objItem.IsActive);
                ht.Add("IsApprove", objItem.IsApprove);
                ht.Add("ApprovedBy", objItem.ApprovedBy);
                ht.Add("ApproveComments", objItem.ApproveComments);
                ht.Add("ApproveDate", objItem.ApproveDate);
                ht.Add("CreatedBy", objItem.CreatedBy);
                ht.Add("CreatedDate", objItem.CreatedDate);
                ht.Add("UpdateID", objItem.UpdateID);
                ht.Add("UpdateDate", objItem.UpdateDate);
                ht.Add("SIMonth", objItem.SIMonth);
                ht.Add("SIYear", objItem.SIYear);
                ht.Add("DCSerial", objItem.DCSerial);
                ht.Add("StoreID", objItem.StoreID);
                ht.Add("GatePassNo", objItem.GatePassNo);
                ht.Add("VehicleNo", objItem.VehicleNo);
                ht.Add("DriverName", objItem.DriverName);
                ht.Add("DeliveryAddress", objItem.DeliveryAddress);





                return Convert.ToInt32(idb.InsertData(ht, "spInsertPurchaseReturnMaster"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }



        public long insert_Sales_return_Master_DA(BOSalesInvoiceNew objItem)
        {
            try
            {





                Hashtable ht = new Hashtable();

                ht.Add("DCNO", objItem.DCNO);
                ht.Add("DCDATE", objItem.DCDATE);
                ht.Add("InvoiceID", objItem.InvoiceID);
                ht.Add("CompanyID", objItem.CompanyID);
                ht.Add("ClientID", objItem.ClientID);
                ht.Add("SalesInitiatorID", objItem.SalesInitiatorID);
                ht.Add("Remarks", objItem.Remarks);
                ht.Add("InvoiceType", objItem.InvoiceType);
                ht.Add("IsActive", objItem.IsActive);
                ht.Add("IsApprove", objItem.IsApprove);
                ht.Add("ApprovedBy", objItem.ApprovedBy);
                ht.Add("ApproveComments", objItem.ApproveComments);
                ht.Add("ApproveDate", objItem.ApproveDate);
                ht.Add("CreatedBy", objItem.CreatedBy);
                ht.Add("CreatedDate", objItem.CreatedDate);
                ht.Add("UpdateID", objItem.UpdateID);
                ht.Add("UpdateDate", objItem.UpdateDate);
                ht.Add("SIMonth", objItem.SIMonth);
                ht.Add("SIYear", objItem.SIYear);
                ht.Add("DCSerial", objItem.DCSerial);
                ht.Add("StoreID", objItem.StoreID);
                ht.Add("GatePassNo", objItem.GatePassNo);
                ht.Add("VehicleNo", objItem.VehicleNo);
                ht.Add("DriverName", objItem.DriverName);
                ht.Add("DeliveryAddress", objItem.DeliveryAddress);





                return Convert.ToInt32(idb.InsertData(ht, "spInsertSalesReturnMaster"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }



        public long insertDCDetailDA(BOSalesInvoiceNew objItem)
        {
            try
            {

                Hashtable ht = new Hashtable();
            
                ht.Add("DCNO", objItem.DCNO);
                ht.Add("DCDate", objItem.DCDATE);
                ht.Add("InvoiceID", objItem.InvoiceID);
                ht.Add("ClientID", objItem.ClientID);
                ht.Add("ProductID", objItem.ProductID );
                ht.Add("Quantity", objItem.Quantity);
                ht.Add("ReturnQTY", objItem.ReturnQTY);
                ht.Add("IsActive", objItem.IsActive);
                ht.Add("IsApprove", objItem.IsApprove);


                return Convert.ToInt32(idb.InsertData(ht, "spInsertDCDetail"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }




        public long insert_Purchase_return_Detail_DA(BOSalesInvoiceNew objItem)
        {
            try
            {

                Hashtable ht = new Hashtable();

                ht.Add("DCNO", objItem.DCNO);
                ht.Add("DCDate", objItem.DCDATE);
                ht.Add("InvoiceID", objItem.InvoiceID);
                ht.Add("ClientID", objItem.ClientID);
                ht.Add("ProductID", objItem.ProductID);
                ht.Add("Quantity", objItem.Quantity);
                ht.Add("ReturnQTY", objItem.ReturnQTY);
                ht.Add("IsActive", objItem.IsActive);
                ht.Add("IsApprove", objItem.IsApprove);


                return Convert.ToInt32(idb.InsertData(ht, "spInsertPurchaseReturnDetail"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }


        public long insert_Sales_return_Detail_DA(BOSalesInvoiceNew objItem)
        {
            try
            {

                Hashtable ht = new Hashtable();

                ht.Add("DCNO", objItem.DCNO);
                ht.Add("DCDate", objItem.DCDATE);
                ht.Add("InvoiceID", objItem.InvoiceID);
                ht.Add("ClientID", objItem.ClientID);
                ht.Add("ProductID", objItem.ProductID);
                ht.Add("Quantity", objItem.Quantity);
                ht.Add("ReturnQTY", objItem.ReturnQTY);
                ht.Add("IsActive", objItem.IsActive);
                ht.Add("IsApprove", objItem.IsApprove);


                return Convert.ToInt32(idb.InsertData(ht, "spInsertSalesReturnDetail"));
            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }


        public long insertInvoiceReturnMaster(BOSalesInvoicecs boaddemp)
        {
            try
            {

                
                var ht = new Hashtable();

                ht.Add("ReturnID", boaddemp.ReturnID1);
                ht.Add("ReturnDate", boaddemp.InvoiceDate1);
                ht.Add("InvoiceID", boaddemp.InvoiceID1);      
                ht.Add("ReturnAmount", boaddemp.Returnamount );
                ht.Add("IsActive", boaddemp.IsActive1);
                ht.Add("IsApprove", boaddemp.IsApprove1);
                ht.Add("ApprovedBy", boaddemp.ApprovedBy1);
                ht.Add("ApproveComments", boaddemp.ApproveComments1);
                ht.Add("ApproveDate", boaddemp.ApproveDate1);
                ht.Add("CreatedBy", boaddemp.CreatedBy1);
                ht.Add("CreatedDate", boaddemp.CreatedDate1);
                ht.Add("UpdateID", boaddemp.UpdateID1);
                ht.Add("UpdateDate", boaddemp.UpdateDate1);
                ht.Add("SIMonth", boaddemp.SIMonth1);
                ht.Add("SIYear", boaddemp.SIYear1);
                ht.Add("InvoiceIDSerial", boaddemp.InvoiceIDSerial1);
               
                return Convert.ToInt32(idb.InsertData(ht, "spInsertInvoiceReturnMaster"));


            }

            catch (Exception ex)
            {
                //  Alert.Show(ex.Message);
                throw ex;
            }
        }





    }
