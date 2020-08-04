using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


    public class BOSchedule
    {

        public BOSchedule()
        { }




        private string BillingClientID;

        public string BillingClientID1
        {
            get { return BillingClientID; }
            set { BillingClientID = value; }
        }
        
        private string BroadCastType;

        public string BroadCastType1
        {
            get { return BroadCastType; }
            set { BroadCastType = value; }
        }
        private int ScheduleType;

        public int ScheduleType1
        {
            get { return ScheduleType; }
            set { ScheduleType = value; }
        }

        private int ScheduleNo;

        public int ScheduleNo1
        {
            get { return ScheduleNo; }
            set { ScheduleNo = value; }
        }
        private DateTime ScheduleDate;

        public DateTime ScheduleDate1
        {
            get { return ScheduleDate; }
            set { ScheduleDate = value; }
        }
        private string ClientID;

        public string ClientID1
        {
            get { return ClientID; }
            set { ClientID = value; }
        }
        private string MediaID;

        public string MediaID1
        {
            get { return MediaID; }
            set { MediaID = value; }
        }
        private string WorkOrderNo;

        public string WorkOrderNo1
        {
            get { return WorkOrderNo; }
            set { WorkOrderNo = value; }
        }
        private float VatPercent;

        public float VatPercent1
        {
            get { return VatPercent; }
            set { VatPercent = value; }
        }
        private float RatePerMinute;

        public float RatePerMinute1
        {
            get { return RatePerMinute; }
            set { RatePerMinute = value; }
        }
        private DateTime OnAirStartDate;

        public DateTime OnAirStartDate1
        {
            get { return OnAirStartDate; }
            set { OnAirStartDate = value; }
        }
        private DateTime OnAirEndDate;

        public DateTime OnAirEndDate1
        {
            get { return OnAirEndDate; }
            set { OnAirEndDate = value; }
        }
        private int ToatDays;

        public int ToatDays1
        {
            get { return ToatDays; }
            set { ToatDays = value; }
        }
        private float BonusMinute;

        public float BonusMinute1
        {
            get { return BonusMinute; }
            set { BonusMinute = value; }
        }
        private float AdvancePayment;

        public float AdvancePayment1
        {
            get { return AdvancePayment; }
            set { AdvancePayment = value; }
        }
        private string RDC1;

        public string RDC11
        {
            get { return RDC1; }
            set { RDC1 = value; }
        }
        private string RDC2;

        public string RDC21
        {
            get { return RDC2; }
            set { RDC2 = value; }
        }
        private string RDC3;

        public string RDC31
        {
            get { return RDC3; }
            set { RDC3 = value; }
        }
        private string Remarks;

        public string Remarks1
        {
            get { return Remarks; }
            set { Remarks = value; }
        }
        private Boolean MarketingApproval;

        public Boolean MarketingApproval1
        {
            get { return MarketingApproval; }
            set { MarketingApproval = value; }
        }
        private Boolean AccountsApproval;

        public Boolean AccountsApproval1
        {
            get { return AccountsApproval; }
            set { AccountsApproval = value; }
        }
        private Boolean ProgramApproval;

        public Boolean ProgramApproval1
        {
            get { return ProgramApproval; }
            set { ProgramApproval = value; }
        }


        private Boolean OperationApproval;

        public Boolean OperationApproval1
        {
            get { return OperationApproval; }
            set { OperationApproval = value; }
        }

        private Boolean CEOApproval;

        public Boolean CEOApproval1
        {
            get { return CEOApproval; }
            set { CEOApproval = value; }
        }
        private Boolean IsActive;

        public Boolean IsActive1
        {
            get { return IsActive; }
            set { IsActive = value; }
        }
        private string AddBy;

        public string AddBy1
        {
            get { return AddBy; }
            set { AddBy = value; }
        }
        private DateTime AddDate;

        public DateTime AddDate1
        {
            get { return AddDate; }
            set { AddDate = value; }
        }
        private string ModiBy;

        public string ModiBy1
        {
            get { return ModiBy; }
            set { ModiBy = value; }
        }
        private DateTime ModiDate;

        public DateTime ModiDate1
        {
            get { return ModiDate; }
            set { ModiDate = value; }
        }
        private string TimeSlotStart;

        public string TimeSlotStart1
        {
            get { return TimeSlotStart; }
            set { TimeSlotStart = value; }
        }
        private string TimeSlotEnd;

        public string TimeSlotEnd1
        {
            get { return TimeSlotEnd; }
            set { TimeSlotEnd = value; }
        }
        private int NoOfSpot;

        public int NoOfSpot1
        {
            get { return NoOfSpot; }
            set { NoOfSpot = value; }
        }
        private Boolean IsRegularSchedule;

        public Boolean IsRegularSchedule1
        {
            get { return IsRegularSchedule; }
            set { IsRegularSchedule = value; }
        }



        private string CommentsByAccounts = null;

        public string CommentsByAccounts1
        {
            get { return CommentsByAccounts; }
            set { CommentsByAccounts = value; }
        }
        private string CommentsByProgram = null;

        public string CommentsByProgram1
        {
            get { return CommentsByProgram; }
            set { CommentsByProgram = value; }
        }

        private string CommentsByOperation = null;

        public string CommentsByOperation1
        {
            get { return CommentsByOperation; }
            set { CommentsByOperation = value; }
        }

        private string CommentsByCEO = null;

        public string CommentsByCEO1
        {
            get { return CommentsByCEO; }
            set { CommentsByCEO = value; }
        }


        private Boolean IsRevised;

        public Boolean IsRevised1
        {
            get { return IsRevised; }
            set { IsRevised = value; }
        }


        private Boolean isClient;

        public Boolean IsClient
        {
            get { return isClient; }
            set { isClient = value; }
        }



    }
