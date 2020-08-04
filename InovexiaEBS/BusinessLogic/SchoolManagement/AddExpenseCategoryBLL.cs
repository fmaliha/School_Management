using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.DataAccess.SchoolManagement;

namespace InovexiaEBS.BusinessLogic.StudentRegistrationBLL
{
    public class AddExpenseCategoryBLL
    {
        internal long SaveExpenseCategory(VmStudentRegistration objvm)
        {
            AddExpenseCategoryDLL dll = new AddExpenseCategoryDLL();

            return dll.SaveExpenseCategory(objvm);
        }

        internal static DataTable checkExpenseCategory(Hashtable ht)
        {
            AddExpenseCategoryDLL cbdll = new AddExpenseCategoryDLL();

            return cbdll.checkExpenseCategory(ht);

        }
    }


}