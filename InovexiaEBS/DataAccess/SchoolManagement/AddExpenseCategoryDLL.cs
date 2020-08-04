using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using PBSConnLib;

namespace InovexiaEBS.DataAccess.SchoolManagement
{
    public class AddExpenseCategoryDLL
    {
        PBSDBUtility pbs = new PBSDBUtility();
        internal long SaveExpenseCategory(VmStudentRegistration objvm)
        {
            try
            {
                string RF = string.Empty;

                Hashtable ht = new Hashtable();


                ht.Add("HeadName", objvm.ExpenseCategory);


                RF = pbs.GetDataByProc(ht, "SM_SaveExpenseCategory").Rows[0]["ExpenseID"].ToString();

                return long.Parse(RF);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

            return 0;
        }

        internal DataTable checkExpenseCategory(Hashtable ht)
        {
            try
            {

                DataTable dbt = pbs.GetDataByProc(ht, "SM_CheckExpenseCategory");
                return dbt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}