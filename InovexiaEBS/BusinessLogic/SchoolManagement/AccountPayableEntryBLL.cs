using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.DataAccess.SchoolManagement;

namespace InovexiaEBS.BusinessLogic.StudentRegistrationBLL
{
    public class AccountPayableEntryBLL
    {
        internal static long SaveAccountPayableData(VmStudentRegistration objvm)
        {
            AccountPayableEntryDLL dll = new AccountPayableEntryDLL();

            return dll.SaveAccountPayableEntryData(objvm);
        }
    }
}