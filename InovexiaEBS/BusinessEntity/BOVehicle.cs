using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS
{
    public class BOVehicle
    {

        private string MobileServiceName;

        public string MobileServiceName1
        {
            get { return MobileServiceName; }
            set { MobileServiceName = value; }
        }


        private Boolean IsApprove;

        public Boolean IsApprove1
        {
            get { return IsApprove; }
            set { IsApprove = value; }
        }
        private string ApprovalUser;

        public string ApprovalUser1
        {
            get { return ApprovalUser; }
            set { ApprovalUser = value; }
        }

        private DateTime ApprovalDate;

        public DateTime ApprovalDate1
        {
            get { return ApprovalDate; }
            set { ApprovalDate = value; }
        }

        private string ApprovalComments;

        public string ApprovalComments1
        {
            get { return ApprovalComments; }
            set { ApprovalComments = value; }
        }


        private Boolean IsProcess;

        public Boolean IsProcess1
        {
            get { return IsProcess; }
            set { IsProcess = value; }
        }
        private DateTime ProcessDate;

        public DateTime ProcessDate1
        {
            get { return ProcessDate; }
            set { ProcessDate = value; }
        }

        private string VehicleBillID;

        public string VehicleBillID1
        {
            get { return VehicleBillID; }
            set { VehicleBillID = value; }
        }

        private DateTime VehicleBillDate;

        public DateTime VehicleBillDate1
        {
            get { return VehicleBillDate; }
            set { VehicleBillDate = value; }
        }

       private string VehicleNo;

       public string VehicleNo1
       {
           get { return VehicleNo; }
           set { VehicleNo = value; }
       }

       private float  MonthlyKM;

       public float MonthlyKM1
       {
           get { return MonthlyKM; }
           set { MonthlyKM = value; }
       }

       private float MonthlyEndKM;

       public float MonthlyEndKM1
       {
           get { return MonthlyEndKM; }
           set { MonthlyEndKM = value; }
       }

       private float GasBill;

       public float GasBill1
       {
           get { return GasBill; }
           set { GasBill = value; }
       }

       private float OctaneBill;

       public float OctaneBill1
       {
           get { return OctaneBill; }
           set { OctaneBill = value; }
       }

       private float MaintenaceBill;

       public float MaintenaceBill1
       {
           get { return MaintenaceBill; }
           set { MaintenaceBill = value; }
       }

       private float DriverSalary;

       public float DriverSalary1
       {
           get { return DriverSalary; }
           set { DriverSalary = value; }
       }

       private float OtherCost;

       public float OtherCost1
       {
           get { return OtherCost; }
           set { OtherCost = value; }
       }

       private float BillMonth;

       public float BillMonth1
       {
           get { return BillMonth; }
           set { BillMonth = value; }
       }

       private int BillYear;

       public int BillYear1
       {
           get { return BillYear; }
           set { BillYear = value; }
       }

       private Boolean IsActive;

       public Boolean IsActive1
       {
           get { return IsActive; }
           set { IsActive = value; }
       }

       private string EntryID;

       public string EntryID1
       {
           get { return EntryID; }
           set { EntryID = value; }
       }

       private DateTime EntryDate;

       public DateTime EntryDate1
       {
           get { return EntryDate; }
           set { EntryDate = value; }
       }

       private string UpdateID;

       public string UpdateID1
       {
           get { return UpdateID; }
           set { UpdateID = value; }
       }

       private DateTime UpdateDate;

       public DateTime UpdateDate1
       {
           get { return UpdateDate; }
           set { UpdateDate = value; }
       }

       private string Remarks;

       public string Remarks1
       {
           get { return Remarks; }
           set { Remarks = value; }
       }

       private int BillSerial;

       public int BillSerial1
       {
           get { return BillSerial; }
           set { BillSerial = value; }
       }


        ////////-------------------------------Vehicle Master----------------------------------


       private string TypeOfVechicle;

       public string TypeOfVechicle1
       {
           get { return TypeOfVechicle; }
           set { TypeOfVechicle = value; }
       }


       private DateTime RegistrationDate;

       public DateTime RegistrationDate1
       {
           get { return RegistrationDate; }
           set { RegistrationDate = value; }
       }


       private DateTime TaxPayDate;

       public DateTime TaxPayDate1
       {
           get { return TaxPayDate; }
           set { TaxPayDate = value; }
       }

       private DateTime FitnessDate;

       public DateTime FitnessDate1
       {
           get { return FitnessDate; }
           set { FitnessDate = value; }
       }

       private DateTime InsuranceDate;

       public DateTime InsuranceDate1
       {
           get { return InsuranceDate; }
           set { InsuranceDate = value; }
       }

       private DateTime RoadPermitDate;

       public DateTime RoadPermitDate1
       {
           get { return RoadPermitDate; }
           set { RoadPermitDate = value; }
       }

  
        

        //--------------------------Vehicle User-------------------------------------------


       private string ParkingPlace;

       public string ParkingPlace1
       {
           get { return ParkingPlace; }
           set { ParkingPlace = value; }
       }
       private int DriverID;

       public int DriverID1
       {
           get { return DriverID; }
           set { DriverID = value; }
       }
       private DateTime DriverStartDate;

       public DateTime DriverStartDate1
       {
           get { return DriverStartDate; }
           set { DriverStartDate = value; }
       }
       private DateTime DriverEndDate;

       public DateTime DriverEndDate1
       {
           get { return DriverEndDate; }
           set { DriverEndDate = value; }
       }
       

        //---------------------------EMployee Master--------------------------

       private string EmployeeID;

       public string EmployeeID1
       {
           get { return EmployeeID; }
           set { EmployeeID = value; }
       }

       private string EmployeeName ;

       public string EmployeeName1
       {
           get { return EmployeeName; }
           set { EmployeeName = value; }
       }
       private int DesignationID;

       public int DesignationID1
       {
           get { return DesignationID; }
           set { DesignationID = value; }
       }
       private int DepartmentID;

       public int DepartmentID1
       {
           get { return DepartmentID; }
           set { DepartmentID = value; }
       }
       private string CompanyID;

       public string CompanyID1
       {
           get { return CompanyID; }
           set { CompanyID = value; }
       }
       private Boolean IsOfficer;

       public Boolean IsOfficer1
       {
           get { return IsOfficer; }
           set { IsOfficer = value; }
       }
       private Boolean IsDriver;

       public Boolean IsDriver1
       {
           get { return IsDriver; }
           set { IsDriver = value; }
       }

        //---------------------------------------------------------Mobile Master----------------------------

       private string MobileNo;

       public string MobileNo1
       {
           get { return MobileNo; }
           set { MobileNo = value; }
       }
       private DateTime PurchaseDate;

       public DateTime PurchaseDate1
       {
           get { return PurchaseDate; }
           set { PurchaseDate = value; }
       }



       private Boolean IsBlacBerryService;

       public Boolean IsBlacBerryService1
       {
           get { return IsBlacBerryService; }
           set { IsBlacBerryService = value; }
       }

       private string SIMPurchaseBy;

       public string SIMPurchaseBy1
       {
           get { return SIMPurchaseBy; }
           set { SIMPurchaseBy = value; }
       }


        //---------------------------------------Mobile User -----------------------------


       private float LimitAmount;

       public float LimitAmount1
       {
           get { return LimitAmount; }
           set { LimitAmount = value; }
       }

       private string DevicePurchaseBy;

       public string DevicePurchaseBy1
       {
           get { return DevicePurchaseBy; }
           set { DevicePurchaseBy = value; }
       }

       private string DeviceName;

       public string DeviceName1
       {
           get { return DeviceName; }
           set { DeviceName = value; }
       }

       private string BillPaidBy;

       public string BillPaidBy1
       {
           get { return BillPaidBy; }
           set { BillPaidBy = value; }
       }

       private DateTime UsedStartDate;

       public DateTime UsedStartDate1
       {
           get { return UsedStartDate; }
           set { UsedStartDate = value; }
       }

       private DateTime UsedEndDate;

       public DateTime UsedEndDate1
       {
           get { return UsedEndDate; }
           set { UsedEndDate = value; }
       }

       private string Purpose;

       public string Purpose1
       {
           get { return Purpose; }
           set { Purpose = value; }
       }

       private string ApprovedBy;

       public string ApprovedBy1
       {
           get { return ApprovedBy; }
           set { ApprovedBy = value; }
       }
       




    //------------------------------------Mobile Bill history-------------------------------------

       private string MobileBillID;

       public string MobileBillID1
       {
           get { return MobileBillID; }
           set { MobileBillID = value; }
       }

       private DateTime MobileBillDate;

       public DateTime MobileBillDate1
       {
           get { return MobileBillDate; }
           set { MobileBillDate = value; }
       }

       private float BillAmount;

       public float BillAmount1
       {
           get { return BillAmount; }
           set { BillAmount = value; }
       }



       private DateTime BillPaidDate;

       public DateTime BillPaidDate1
       {
           get { return BillPaidDate; }
           set { BillPaidDate = value; }
       }

       private Boolean IsBillPaid;

       public Boolean IsBillPaid1
       {
           get { return IsBillPaid; }
           set { IsBillPaid = value; }
       }

       private string BillPaidType;

       public string BillPaidType1
       {
           get { return BillPaidType; }
           set { BillPaidType = value; }
       }


    }


}