using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using PBSConnLib;

namespace InovexiaEBS.DataAccess.SchoolManagement
{
    public class ExpenseEntryDLL
    {
        PBSDBUtility pbs = new PBSDBUtility();
        internal long SaveExpense(VmStudentRegistration objvm)
        {
            try
            {
                string RF = string.Empty;

                Hashtable ht = new Hashtable();

                
                ht.Add("Date", objvm.Expensedate);
                ht.Add("ExpenseHead", objvm.ExpenseType);
                ht.Add("CollectionMode", objvm.EPaymentType);
                ht.Add("Amount", objvm.EAmount);
                ht.Add("Narration", objvm.ENarration);

                RF = pbs.GetDataByProc(ht, "SM_SaveExpense").Rows[0]["ReferenceNo"].ToString();

                return long.Parse(RF);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

            return 0;
        }

        internal long UpdateExpense(VmStudentRegistration objvm)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();


                ht.Add("ReferenceNo", objvm.RefNo);
                ht.Add("Date", objvm.Expensedate);
                ht.Add("ExpenseHead", objvm.ExpenseType);
                ht.Add("CollectionMode", objvm.EPaymentType);
                ht.Add("Amount", objvm.EAmount);
                ht.Add("Narration", objvm.ENarration); ;

                return result = pbs.InsertData(ht, "SM_UpdateExpense");

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}