using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;


using PBSConnLib;

    public class DASchedule
    {

        public DASchedule()
        { }


       PBSDBUtility    iPBSDBUtility = new PBSDBUtility();

        public long InsertSchedule(BOSchedule  objBO)
        {
            try
            {    

                Hashtable ht = new Hashtable();
                ht.Add("ScheduleNo", objBO.ScheduleNo1 );
                ht.Add("ScheduleDate", objBO.ScheduleDate1 );
                ht.Add("ClientID", objBO.ClientID1 );
                ht.Add("MediaID", objBO.MediaID1 );
                ht.Add("WorkOrderNo", objBO.WorkOrderNo1 );               
                ht.Add("ToatDays", objBO.ToatDays1 );
                ht.Add("BonusMinute", objBO.BonusMinute1 );               
                ht.Add("Remarks", objBO.Remarks1 );
                ht.Add("MarketingApproval", objBO.MarketingApproval1 );
                ht.Add("AccountsApproval", objBO.AccountsApproval1 );
                ht.Add("ProgramApproval", objBO.ProgramApproval1 );//@OperationApproval
                ht.Add("OperationApproval", objBO.OperationApproval1 );
                ht.Add("CEOApproval", objBO.CEOApproval1 );
                ht.Add("IsActive", objBO.IsActive1 );
                ht.Add("AddBy", objBO.AddBy1 );
                ht.Add("AddDate", objBO.AddDate1 );
                ht.Add("ModiBy", objBO.ModiBy1 );
                ht.Add("ModiDate", objBO.ModiDate1 );
                ht.Add("CommentsByAccounts", objBO.CommentsByAccounts1  );
                ht.Add("CommentsByProgram", objBO.CommentsByProgram1  );
                ht.Add("CommentsByOperation", objBO.CommentsByOperation1 );
                ht.Add("CommentsByCEO", objBO.CommentsByCEO1 );
                ht.Add("BillingClientID", objBO.BillingClientID1 );
                ht.Add("IsRevised", objBO.IsRevised1 );
                ht.Add("IsClient", objBO.IsClient );
                
               


                    

                return Convert.ToInt64(iPBSDBUtility.InsertData(ht, "InsertScheduleMaster"));


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public long InsertScheduleDetail(BOSchedule objBO)
        {
            try
            {
                
                Hashtable ht = new Hashtable();
                ht.Add("ScheduleNo", objBO.ScheduleNo1);
                ht.Add("TimeSlotStart", objBO.TimeSlotStart1 );
                ht.Add("TimeSlotEnd", objBO.TimeSlotEnd1 );
                ht.Add("NoOfSpot", objBO.NoOfSpot1 );
                ht.Add("IsRegularSchedule", objBO.IsRegularSchedule1 );

                return Convert.ToInt64(iPBSDBUtility.InsertData(ht, "InsertScheduleDetail"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
