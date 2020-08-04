using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.DataAccess.SchoolManagement;

namespace InovexiaEBS.BusinessLogic.StudentRegistrationBLL
{
    public class AccountReceiveableEntryBLL
    {
        internal static long SaveAccountReceiveableData(VmStudentRegistration objvm)
        {
            AccountReceiveableEntryDLL dll = new AccountReceiveableEntryDLL();

            return dll.SaveAccountReceiveableEntryData(objvm);
        }
    }
}