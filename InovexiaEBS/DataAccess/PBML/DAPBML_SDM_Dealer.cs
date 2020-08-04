using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBS.BusinessEntity.PBML;
using PBSConnLib;
using System.Collections;


namespace PBS.DataAccess.PBML
{
    public class DAPBML_SDM_Dealer
    {
        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertPBML_SDM_Dealer(BOPBML_SDM_Dealer boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("DealerID", boItem.DealerID1);
                ht.Add("DealerName", boItem.DealerName1);
                ht.Add("Address", boItem.Address1);
                ht.Add("MobileNumber", boItem.MobileNumber1);
                ht.Add("CompanyID", boItem.CompanyID1);
                ht.Add("District", boItem.District1);

                ht.Add("StoreStatus", boItem.StoreStatus1);
                ht.Add("StoreType", boItem.StoreType1);
                ht.Add("ContactPerson", boItem.ContactPerson1);
                ht.Add("DesignationOfContactPerson", boItem.DesignationOfContactPerson1);
                ht.Add("MobileNumberOfContactPerson", boItem.MobileNumberOfContactPerson1);
                ht.Add("OwnerName", boItem.OwnerName1);
                ht.Add("MobileNumberOfOwner", boItem.MobileNumberOfOwner1);
                ht.Add("MailingAddress", boItem.MailingAddress1);
                ht.Add("Fax", boItem.Fax1);
                ht.Add("EmailID", boItem.EmailID1);
                ht.Add("TradeLicenceNumber", boItem.TradeLicenceNumber1);
                ht.Add("TaxIdentificationNumber", boItem.TaxIdentificationNumber1);
                ht.Add("VatRegistrationNumber", boItem.VatRegistrationNumber1);
                ht.Add("NationalIDNumber", boItem.NationalIDNumber1);
                ht.Add("BankID", boItem.BankID1);
                ht.Add("BankAccountNumber", boItem.BankAccountNumber1);
                ht.Add("PresentDistrubuterCompanyName", boItem.PresentDistrubuterCompanyName1);
                ht.Add("IsPSGDealer", boItem.IsPSGDealer1);
                ht.Add("SerialNumber", boItem.SerialNumber1);
                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatedDate", boItem.CreatedDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
               





                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPBML_SDM_Dealer"));


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public long UpdatePBML_SDM_Dealer(BOPBML_SDM_Dealer boItemUpdate)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("DealerID", boItemUpdate.DealerID1);
                ht.Add("DealerName", boItemUpdate.DealerName1);
                ht.Add("Address", boItemUpdate.Address1);
                ht.Add("MobileNumber", boItemUpdate.MobileNumber1);
                ht.Add("ContactPerson", boItemUpdate.ContactPerson1);
                ht.Add("DiscountPercent", boItemUpdate.DiscountPercent1 );
                ht.Add("District", boItemUpdate.District1);
                ht.Add("UpdatedBy", boItemUpdate.UpdatedBy1);
                ht.Add("IsActive", boItemUpdate.IsActive1 );
                ht.Add("DealerType", boItemUpdate.DealerType1 );


                return Convert.ToInt64(idbutility.InsertData(ht, "UpdatePBML_SDM_Dealer"));


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}