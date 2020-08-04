using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.DataAccess.SchoolManagement;

namespace InovexiaEBS.BusinessLogic.StudentRegistrationBLL
{
    public class ExpenseEntryBLL
    {
        internal long SaveExpense(VmStudentRegistration objvm)
        {
            ExpenseEntryDLL dll = new ExpenseEntryDLL();

            return dll.SaveExpense(objvm);
        }
        internal long UpdateExpense(VmStudentRegistration objvm)
        {
            ExpenseEntryDLL dll = new ExpenseEntryDLL();

            return dll.UpdateExpense(objvm);
        }
    }
}