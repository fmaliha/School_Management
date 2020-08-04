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
    public class BatchListBLL
    {

        //BAtch 

        internal static DataTable GetBatchCounts()
        {
            BatchListDLL objdll = new BatchListDLL();
            return objdll.GetBatchcounts();
        }

        //internal static long GetClassDetails(VmStudentRegistration OBJVM)
        //{
        //    BatchListDLL dll = new BatchListDLL();
        //    return dll.GetClassDetails(OBJVM);
        //}

        internal static DataTable GetSubjectBatchToGrid(VmStudentRegistration OBJVM)
        {
            BatchListDLL dll = new BatchListDLL();
            return dll.GetBatchSubjectsToGrid(OBJVM);
            
        }
      
        internal static DataTable GetBatchByID(Hashtable ht)
        {
            BatchListDLL objdll = new BatchListDLL();

            return objdll.GetBatchInfoByID(ht);
        }

        // Subjects 

        internal static DataTable GetSubjectsCounts()
        {
            BatchListDLL objdll = new BatchListDLL();
            return objdll.GetSubjectcounts();
        }


       
        internal static long DeleteBatch(VmStudentRegistration _objVm)
        {
            BatchListDLL _objBatchListDLL = new BatchListDLL();
            return _objBatchListDLL.DeleteBatch(_objVm);
        }

    }
}