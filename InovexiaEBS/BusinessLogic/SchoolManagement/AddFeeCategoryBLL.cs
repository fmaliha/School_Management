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
    public class AddFeeCategoryBLL
    {
        internal static long SaveAddFeeCategory(VmStudentRegistration _objVmStudent)
        {
            AddFeeCategoryDLL accessLayer = new AddFeeCategoryDLL();
            return accessLayer.SaveAddFeeCategory(_objVmStudent);
        }

        internal static DataTable CheckFeeCategory(Hashtable ht)
        {
            AddFeeCategoryDLL dll = new AddFeeCategoryDLL();

            return dll.CheckFeeCategory(ht);
        }
    }
}