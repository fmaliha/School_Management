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
    public class CreateBatchDLL
    {
        PBSDBUtility pbu = new PBSDBUtility();


        internal DataTable checkbatchnames(Hashtable ht)
        {
            try
            {
               
                DataTable dbt = pbu.GetDataByProc(ht,"SM_Checkbatchnames");
                return dbt;

            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message.ToString());
            }
        }

        
        internal long SaveYearBatch(VmStudentRegistration objbatch)
        {
            try
            {

                long result = 0;

                Hashtable ht = new Hashtable();

             
                ht.Add("SectionName",objbatch.batchname);
                ht.Add("BatchYearFrom", objbatch.batchyearf);
                ht.Add("BatchYearTo", objbatch.batchyeart);
                ht.Add("ClassName", objbatch.classname);
                ht.Add("Remarks", objbatch.batchremarks);

                result = pbu.InsertData(ht,"SM_CreateYearlyBatch");
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}