using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.DataAccess.SchoolManagement;

namespace InovexiaEBS.BusinessLogic.StudentRegistrationBLL
{
    public class GuardianListBLL
    {
        internal static DataTable GetAllGuardian()
        {
            GuardianListDLL _objGuardianListDLL = new GuardianListDLL();
            return _objGuardianListDLL.GetAllGuardian();
        }


        internal static long DeleteGuardianDetails(VmStudentRegistration _objVmGuardianRegistration)
        {
            GuardianListDLL _objGuardianRegistrationDll = new GuardianListDLL();
            return _objGuardianRegistrationDll.DeleteGuardianDetailsByAdmissionNo(_objVmGuardianRegistration);
        }
    }
}