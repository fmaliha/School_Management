using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.BusinessLogic.SchoolManagement;
using PBSConnLib;

namespace InovexiaEBS.DataAccess.SchoolManagement
{
    public class BatchListDLL
    {
        PBSDBUtility pbu = new PBSDBUtility();



        ///Batches 
        /// 
        /// 
        internal DataTable GetBatchcounts()
        {
            try
            {
                DataTable dtb = pbu.GetDataByProc("SM_GetBatchsectioncounthf");
                return dtb;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message.ToString());
            }
            
        }

        //internal long GetClassDetails(VmStudentRegistration OBJVM)
        //{
        //    try
        //    {
        //        Hashtable ht = new Hashtable();
        //        ht.Add("ClassName",OBJVM.ClassName);
        //        long result = Convert.ToInt64(pbu.GetDataByProc(ht,"SM_GetClassNames").Rows[0]["ClassID"].ToString());
        //        return result;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message.ToString());
        //    }

        //}

        internal DataTable GetBatchSubjectsToGrid(VmStudentRegistration objvm)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("ClassID",objvm.BatchClassID);
                DataTable dt = pbu.GetDataByProc(ht, "SM_GetClassBatchSubjctsbyClassID");
               // long a = Convert.ToInt64(pbu.GetDataByProc(ht, "SM_GetClassBatchSubjctsbyClassID").Rows[0]["ClassName"].ToString());
                return dt;

            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message.ToString());
            }
        }

       


       

        internal DataTable GetBatchInfoByID(Hashtable ht)
        {
            try
            {
                DataTable dt = pbu.GetDataByProc(ht,"SM_GetBatchByBatchID");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
           
                        
        }

        // Sections 

        internal DataTable GetSubjectcounts()
        {
            try
            {
                DataTable dtb = pbu.GetDataByProc("SM_GetSubjectCounthf");
                return dtb;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

        }


        internal long DeleteBatch(VmStudentRegistration _objVm)
        {
            Hashtable ht = new Hashtable();
            ht.Add("BatchID", _objVm.BatchID);
            return pbu.InsertData(ht, "SM_DeleteBatch");
        }


    }
}