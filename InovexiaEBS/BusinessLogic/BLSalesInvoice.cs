using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;




    public class BLSalesInvoice
    {

        public BLSalesInvoice()
	{
		//
		// TODO: Add constructor logic here
		//
	}


        public static long InsertCombinationOfferMasterAmountBL(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.InsertCombinationOfferMasterAmountDA(grrbo));
        }

        public static long InsertCombinationProductAmountBL(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.InsertCombinationProductAmountDA(grrbo));
        }





        public static long InsertCombinationOfferMasterBL(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.InsertCombinationOfferMasterDA(grrbo));
        }


        public static long InsertCombinationProductBL(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.InsertCombinationProductDA(grrbo));
        }

        public static long InsertCombinationAwardBL(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.InsertCombinationAwardDA(grrbo));
        }


        public static long InsertDiscountMasterBL(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.InsertDiscountMasterDA(grrbo));
        }



        public static long InsertDiscountDetailBL(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.InsertDiscountDetailDA(grrbo));
        }









        public static long insertTargetAmountBL(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertTargetAmountDA(grrbo));
        }


        public static long insertTargetProductBL(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertTargetProductDA(grrbo));
        }

        public static long insertInvoiceMaster(BOSalesInvoiceNew  grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertInvoiceMaster(grrbo));
        }

        public static long insertPurchaseMasterBL(BOSalesInvoiceNew grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertPurchaseMasterDA(grrbo));
        }


        public static long insertInvoiceMasterVAT(BOSalesInvoiceNew grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertInvoiceMasterVAT(grrbo));
        }

        public static long insertInvoiceMaster_View(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertInvoiceMaster_View(grrbo));
        }

        
        public static long insertInvoiceDetail(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertInvoiceDetail(grrbo));
        }

        public static long insertPurchaseDetailBL(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertPurchaseDetailDA(grrbo));
        }

        public static long insertInvoiceDetailVAT(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertInvoiceDetailVAT(grrbo));
        }


        public static long insertInvoiceDetail_View(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertInvoiceDetail_View(grrbo));
        }



        public static long insertCombinationCalculationBL(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertCombinationCalculationDA(grrbo));
        }


        public static long insertCombinationCalculationBL_View(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertCombinationCalculationDA_View(grrbo));
        }


       
        public static long insertInvoiceDetailSupli(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertInvoiceDetailSuppli (grrbo));
        }

        public static long insertInvoiceReturn(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertInvoiceReturn(grrbo));
        }


        public static long insertDCMasterBL(BOSalesInvoiceNew  grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertDCMasterDA(grrbo));
        }

        public static long insert_Purchase_Master_BL(BOSalesInvoiceNew grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insert_Purchase_return_Master_DA(grrbo));
        }

        public static long insert_Sales_Master_BL(BOSalesInvoiceNew grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insert_Sales_return_Master_DA(grrbo));
        }




        public static long insertDCDetailBL(BOSalesInvoiceNew grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertDCDetailDA(grrbo));
        }

        public static long insert_Purchase_Detail_BL(BOSalesInvoiceNew grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insert_Purchase_return_Detail_DA(grrbo));
        }

        public static long insert_Sales_Detail_BL(BOSalesInvoiceNew grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insert_Sales_return_Detail_DA(grrbo));
        }




        public static long insertInvoiceReturnMaster(BOSalesInvoicecs grrbo)
        {
            DASalesInvoice daaddemp = new DASalesInvoice();
            return Convert.ToInt64(daaddemp.insertInvoiceReturnMaster(grrbo));
        }
    
    }
