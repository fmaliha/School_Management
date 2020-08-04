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
    public class BatchAssignBLL
    {
        internal static long SaveBatchAssign(VmStudentRegistration _objVmStudent)
        {
            BatchAssignDLL accessLayer = new BatchAssignDLL();
            return accessLayer.SaveBatchAssign(_objVmStudent);
        }

        internal static DataTable CheckAssignedBatch(Hashtable  ht)
        {
            BatchAssignDLL accessLayer = new BatchAssignDLL();
            return accessLayer.CheckAssignedBatch(ht);
        }
    }
}