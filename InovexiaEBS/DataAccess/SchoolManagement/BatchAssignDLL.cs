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
    public class BatchAssignDLL
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();

        internal DataTable CheckAssignedBatch(Hashtable ht )
        {
            try
            {

                DataTable dbt = pbsUtility.GetDataByProc(ht, "SM_CheckAssignedBatch");
                return dbt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal long SaveBatchAssign(VmStudentRegistration model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                
                ht.Add("AdmissionNo", model.Student);
                ht.Add("Batch", model.Batch);
                ht.Add("Class", model.Class);
                ht.Add("Session", model.Session);


                result = pbsUtility.InsertData(ht, "SM_SaveBatchAssign");
                return result;
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}