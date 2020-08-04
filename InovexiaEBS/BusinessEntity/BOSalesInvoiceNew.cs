using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


    public class BOSalesInvoiceNew
    {

        public string InvoiceID { get; set; }
        public DateTime InvoiceDate { get; set; }      
              
        public string Remarks { get; set; }
        public int InvoiceType { get; set; }
        public bool IsActive { get; set; }
        public bool IsApprove { get; set; }
        public string ApprovedBy { get; set; }
        public string ApproveComments { get; set; }
        public DateTime ApproveDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdateID { get; set; }
        public DateTime UpdateDate { get; set; }
        public int SIMonth { get; set; }
        public int SIYear { get; set; }
        public int InvoiceIDSerial { get; set; }
        public float  VatPercent { get; set; }
        public float DiscountAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal ReturnAmount { get; set; }
        public decimal DamageAmount { get; set; }
        public float  DiscountPercent { get; set; }
        public bool IsSalesApproval { get; set; }
        public string SalesApproveBy { get; set; }
        public DateTime SalesApproveDate { get; set; }
        public bool IsTransfer { get; set; }
        public string TransferNo { get; set; }
        public int StoreID { get; set; }
        public bool IsDC { get; set; }
        public string SalesType { get; set; }
        public decimal CashAmount { get; set; }
        public decimal CardAmount { get; set; }
        public decimal ChangeAmount { get; set; }
        public decimal RecieveAmount { get; set; }
        public decimal ServiceCharge { get; set; }

        public decimal DeliveryCharge { get; set; }

        public decimal VatAmount1 { get; set; }


        public string DCNO { get; set; }
        public DateTime DCDATE { get; set; }
       
        public string CompanyID { get; set; }
        public string ClientID { get; set; }
        public int SalesInitiatorID { get; set; }

        public int ProductID { get; set; }

        public Decimal Quantity { get; set; }

        public Decimal ReturnQTY { get; set; }

        
       
        
       
       
        public int DCSerial { get; set; }
       
        public string GatePassNo { get; set; }
        public string VehicleNo { get; set; }
        public string DriverName { get; set; }
        public string DeliveryAddress { get; set; }
 
 


    }
