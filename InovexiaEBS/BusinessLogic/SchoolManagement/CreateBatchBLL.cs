using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.DataAccess.SchoolManagement;

namespace InovexiaEBS.BusinessLogic.SchoolManagement
{
    public class CreateBatchBLL
    {
        


        internal static long SaveYearBatch(VmStudentRegistration objbatch)
        {
            CreateBatchDLL cbdll = new CreateBatchDLL();
            return cbdll.SaveYearBatch(objbatch);
        }

        internal static DataTable checkbatchnames (Hashtable ht)
        
        {
            CreateBatchDLL cbdll = new CreateBatchDLL();

           return  cbdll.checkbatchnames(ht);

        }
    }
}