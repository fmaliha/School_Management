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



public class DAddClient
{

    PBSDBUtility  idbutility  = new PBSDBUtility();

    public DAddClient()
    {

    }

    public long InsertClient(BOAddClient  objBO)
    {



        try
        {
            Hashtable ht = new Hashtable();
            ht.Add("ClientID", objBO.ClientID1 );
            ht.Add("FullName", objBO.FullName1  );
            ht.Add("FHName", objBO.FHName1 );
            ht.Add("MotherName", objBO.MotherName1 );
            ht.Add("PresentAddresss", objBO.PresentAddresss1 );
            ht.Add("PermanentAddress", objBO.PermanentAddress1 );
            ht.Add("PhoneRes", objBO.PhoneRes1 );
            ht.Add("PhoneOff", objBO.PhoneOff1 );
            ht.Add("MobileNo", objBO.MobileNo1 );
            ht.Add("EmailID", objBO.EmailID1 );
            ht.Add("DateOfBirth", objBO.DateOfBirth1 );
            ht.Add("Nationality", objBO.Nationality1 );
            ht.Add("NationalID", objBO.NationalID1 );
            ht.Add("BirthRID", objBO.BirthRID1 );
            ht.Add("PassportNo", objBO.PassportNo1 );
            ht.Add("BloodGroup", objBO.BloodGroup1 );
            ht.Add("Profession", objBO.Profession1 );
            ht.Add("SourceName", objBO.SourceName1 );
            ht.Add("Religion", objBO.Religion1 );
            ht.Add("ProjectID", objBO.ProjectID1 );
            ht.Add("FlatNo", objBO.FloorNo1);
            ht.Add("Remarks", objBO.Remarks1 );
            ht.Add("SalesInitiatorID", objBO.SalesInitiatorID1 );
            ht.Add("CStatus", objBO.CStatus1 );
            ht.Add("EntryID", objBO.EntryID1 );
            ht.Add("EntryDate", objBO.EntryDate1 );
            ht.Add("UpdateID", objBO.UpdateID1 );
            ht.Add("UpdateDate", objBO.UpdateDate1 );
            ht.Add("CMonth", objBO.CMonth1 );
            ht.Add("CYear", objBO.CYear1 );
            ht.Add("IDSerial", objBO.IDSerial1 );

            return Convert.ToInt64(idbutility.InsertData(ht, "InsertClient"));
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }




    public long InsertInitialClient(BOInitialClient  objBO)
    {



        try
        {

            Hashtable ht = new Hashtable();
            ht.Add("ClientID", objBO.ClientID1);
            ht.Add("Name", objBO.Name1 );
            ht.Add("Address", objBO.Address1 );
            ht.Add("PhoneNo", objBO.PhoneNo1 );
            ht.Add("MobileNo", objBO.MobileNo1 );
            ht.Add("SourceName", objBO.SourceName1 );
            ht.Add("ProjectName", objBO.ProjectName1 );
            ht.Add("Area", objBO.Area1 );
            ht.Add("FlatSize", objBO.FlatSize1 );
            ht.Add("FloorNo", objBO.FloorNo1 );           
            ht.Add("Remarks", objBO.Remarks1);
            ht.Add("SalesInitiatorID", objBO.SalesInitiatorID1);
            ht.Add("ClientStatus", objBO.ClientStatus1);
            ht.Add("EntryID", objBO.EntryID1);
            ht.Add("EntryDate", objBO.EntryDate1);
            ht.Add("UpdateID", objBO.UpdateID1);
            ht.Add("UpdateDate", objBO.UpdateDate1);
            ht.Add("QueryDate",objBO.QueryDate1 );
          

            return Convert.ToInt64(idbutility.InsertData(ht, "spInsertInitialClientInfo"));
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }


    public long InsertFollowup(BOFollowUP  objBO)
    {



        try
        {

            Hashtable ht = new Hashtable();
            ht.Add("FollowUpID", objBO.FollowUpID1 );
            ht.Add("ClientID", objBO.ClientID1);
            ht.Add("FollowupDate", objBO.FollowupDate1 );
            ht.Add("WayOfCommunication", objBO.WayOfCommunication1 );
            ht.Add("Comments", objBO.Comments1 );
            ht.Add("Status", objBO.Status1 );
            ht.Add("SalesInitiatorID", objBO.SalesInitiatorID1 );     
            ht.Add("EntryID", objBO.EntryID1);
            ht.Add("EntryDate", objBO.EntryDate1);
            ht.Add("UpdateID", objBO.UpdateID1);
            ht.Add("UpdateDate", objBO.UpdateDate1);


            return Convert.ToInt64(idbutility.InsertData(ht, "spInsertFollowUpInfo"));
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }


    public long InsertApplication(BOApplication  objBO)
    {



        try
        {

            Hashtable ht = new Hashtable();

            ht.Add("ApplicationID",objBO.ApplicationID1 );           
            ht.Add("ApplicationDate", objBO.ApplicationDate1 );
            ht.Add("ClientID", objBO.ClientID1 );
            ht.Add("ProjectID", objBO.ProjectID1 );
            ht.Add("FloorNo", objBO.FloorNo1 );
            ht.Add("FlatNo", objBO.FlatNo1 );
            ht.Add("FlatSize", objBO.FlatSize1 );
            ht.Add("PaymentType", objBO.PaymentType1 );
            ht.Add("RatePerSFT", objBO.RatePerSFT1 );
            ht.Add("UnitValue", objBO.UnitValue1 );
            ht.Add("NoOfCarParking", objBO.NoOfCarParking1 );
            ht.Add("Price", objBO.Price1 );
            ht.Add("Utility", objBO.Utility1 );
            ht.Add("BookingMoney", objBO.BookingMoney1 );
            ht.Add("TotalUnitValue", objBO.TotalUnitValue1 );
            ht.Add("ClientPhoto", objBO.ClientPhoto1 );
            ht.Add("N1Name", objBO.N1Name1 );
            ht.Add("N1Address", objBO.N1Address1 );
            ht.Add("N1Relation", objBO.N1Relation1 );
            ht.Add("N1Photo", objBO.N1Photo1 );                          
            ht.Add("SalesInitiatorID", objBO.SalesInitiatorID1);
            ht.Add("IsActive", objBO);     
            ht.Add("EntryID", objBO.EntryID1);
            ht.Add("EntryDate", objBO.EntryDate1);
            ht.Add("UpdateID", objBO.UpdateID1);
            ht.Add("UpdateDate", objBO.UpdateDate1);
            ht.Add("IDSerial", objBO.IDSerial1 );


            return Convert.ToInt64(idbutility.InsertData(ht, "spInsertApplicationForm"));
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }





}
