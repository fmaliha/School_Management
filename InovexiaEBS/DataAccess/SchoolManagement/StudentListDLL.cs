using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using PBSConnLib;

namespace InovexiaEBS.DataAccess.SchoolManagement
{
    public class StudentListDLL
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();



        internal DataTable GetAllStudent()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("SM_GetStudentList");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        internal DataTable GetStudentInfobyAdmissionNo(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_Getvaluesbyadmissionno");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteStudentInfobyAdmissionNo(VmStudentRegistration objStudentRegistration)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("AdmissionNo", objStudentRegistration.AdmissionNo);

                return pbsUtility.InsertData(ht, "SM_DeleteStudentRecordbyAdmissionNo");

            }
            catch (Exception)
            {

                throw;
            }
        }

        internal DataTable GetFilterSearchwithStuID(Hashtable ht)
        {
            try
            {

                DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_FilterStudentListwithID");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetFilterSearchwithStuName(Hashtable ht)
        {
            try
            {

                DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_FilterStudentListwithName");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetFilterSearchwithBatch(VmStudentRegistration objvm)
        {
            try
            {
                Hashtable ht = new Hashtable();

                ht.Add("Batch", objvm.Batch);
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_FilterStudentListwithBatch");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
        
    }
}