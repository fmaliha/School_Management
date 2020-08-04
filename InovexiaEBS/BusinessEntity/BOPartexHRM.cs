using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InovexiaEBS
{
    public class BOPartexHRM
    {
        //for Dept. table
        private Int64 ID;

        public Int64 ID1
        {
            get { return ID; }
            set { ID = value; }
        }

        private int DeptID;

        public int DeptID1
        {
            get { return DeptID; }
            set { DeptID = value; }
        }

        private string DeptName;

        public string DeptName1
        {
            get { return DeptName; }
            set { DeptName = value; }
        }

        private string Description;

        public string Description1
        {
            get { return Description; }
            set { Description = value; }
        }

        //for desig table

        private int DesignationID;

        public int DesignationID1
        {
            get { return DesignationID; }
            set { DesignationID = value; }
        }

        private string DesignationName;

        public string DesignationName1
        {
            get { return DesignationName; }
            set { DesignationName = value; }
        }

        //for employee master

        private string EmployeeID;

        public string EmployeeID1
        {
            get { return EmployeeID; }
            set { EmployeeID = value; }
        }

        private string CardNo;

        public string CardNo1
        {
            get { return CardNo; }
            set { CardNo = value; }
        }

        private string EmployeeName;

        public string EmployeeName1
        {
            get { return EmployeeName; }
            set { EmployeeName = value; }
        }
        private string CompanyID;

        public string CompanyID1
        {
            get { return CompanyID; }
            set { CompanyID = value; }
        }

        private string NationID;

        public string NationID1
        {
            get { return NationID; }
            set { NationID = value; }
        }

        private string HihgestEduQualification;

        public string HihgestEduQualification1
        {
            get { return HihgestEduQualification; }
            set { HihgestEduQualification = value; }
        }
        private string FatherName;

        public string FatherName1
        {
            get { return FatherName; }
            set { FatherName = value; }
        }

        private string MotherName;

        public string MotherName1
        {
            get { return MotherName; }
            set { MotherName = value; }
        }

        private string ParmanentAddress;

        public string ParmanentAddress1
        {
            get { return ParmanentAddress; }
            set { ParmanentAddress = value; }
        }

        private string Sex;

        public string Sex1
        {
            get { return Sex; }
            set { Sex = value; }
        }
        private DateTime BirthDate;

        public DateTime BirthDate1
        {
            get { return BirthDate; }
            set { BirthDate = value; }
        }
        private string BloodGroup;

        public string BloodGroup1
        {
            get { return BloodGroup; }
            set { BloodGroup = value; }
        }
        private string Religion;

        public string Religion1
        {
            get { return Religion; }
            set { Religion = value; }
        }
        private string Maritulstatus;

        public string Maritulstatus1
        {
            get { return Maritulstatus; }
            set { Maritulstatus = value; }
        }
        private string ContactNo;

        public string ContactNo1
        {
            get { return ContactNo; }
            set { ContactNo = value; }
        }
        private string Email;

        public string Email1
        {
            get { return Email; }
            set { Email = value; }
        }
        private string FingerID;

        public string FingerID1
        {
            get { return FingerID; }
            set { FingerID = value; }
        }
        private DateTime JoiningDate;

        public DateTime JoiningDate1
        {
            get { return JoiningDate; }
            set { JoiningDate = value; }
        }
        private string EmployeeType;

        public string EmployeeType1
        {
            get { return EmployeeType; }
            set { EmployeeType = value; }
        }
        private string SalaryBank;

        public string SalaryBank1
        {
            get { return SalaryBank; }
            set { SalaryBank = value; }
        }
        private string ReportingTo;

        public string ReportingTo1
        {
            get { return ReportingTo; }
            set { ReportingTo = value; }
        }
        private string BankAccount;

        public string BankAccount1
        {
            get { return BankAccount; }
            set { BankAccount = value; }
        }
        private string RefBy;

        public string RefBy1
        {
            get { return RefBy; }
            set { RefBy = value; }
        }
        private string sclass;

        public string Sclass
        {
            get { return sclass; }
            set { sclass = value; }
        }
        private string District;

        public string District1
        {
            get { return District; }
            set { District = value; }
        }
        private Boolean IsActive;

        public Boolean IsActive1
        {
            get { return IsActive; }
            set { IsActive = value; }
        }
        private string CreatedBy;

        public string CreatedBy1
        {
            get { return CreatedBy; }
            set { CreatedBy = value; }
        }
        private DateTime CreatdeDate;

        public DateTime CreatdeDate1
        {
            get { return CreatdeDate; }
            set { CreatdeDate = value; }
        }
        private string UpdatedBy;

        public string UpdatedBy1
        {
            get { return UpdatedBy; }
            set { UpdatedBy = value; }
        }
        private DateTime UpdatedDate;

        public DateTime UpdatedDate1
        {
            get { return UpdatedDate; }
            set { UpdatedDate = value; }
        }
        // for JD table

        private string WorkToDo;

        public string WorkToDo1
        {
            get { return WorkToDo; }
            set { WorkToDo = value; }
        }
        private string ReportTowhome;

        public string ReportTowhome1
        {
            get { return ReportTowhome; }
            set { ReportTowhome = value; }
        }
        private string SuccessInfo;

        public string SuccessInfo1
        {
            get { return SuccessInfo; }
            set { SuccessInfo = value; }
        }
        private string FailureInfo;

        public string FailureInfo1
        {
            get { return FailureInfo; }
            set { FailureInfo = value; }
        }
        private string ProblemArea;

        public string ProblemArea1
        {
            get { return ProblemArea; }
            set { ProblemArea = value; }
        }
        private string SuggestionInfo;

        public string SuggestionInfo1
        {
            get { return SuggestionInfo; }
            set { SuggestionInfo = value; }
        }
        private string HelpInfo;

        public string HelpInfo1
        {
            get { return HelpInfo; }
            set { HelpInfo = value; }
        }
        private int JDYear;

        public int JDYear1
        {
            get { return JDYear; }
            set { JDYear = value; }
        }
        private int JDStatus;

        public int JDStatus1
        {
            get { return JDStatus; }
            set { JDStatus = value; }
        }
        private string Remarks;

        public string Remarks1
        {
            get { return Remarks; }
            set { Remarks = value; }
        }

        private int TransactionID;

        public int TransactionID1
        {
            get { return TransactionID; }
            set { TransactionID = value; }
        }
    }
}