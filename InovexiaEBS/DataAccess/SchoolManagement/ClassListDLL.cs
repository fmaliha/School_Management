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
    public class ClassListDLL
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();


        internal DataTable GetAllClass()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("SM_GetClassList");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetAddClassByClassID(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_GetAddClassByClassID");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal long SaveSelectedSub(VmStudentRegistration model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();

                ht.Add("ClassID", model.ClassID);
                ht.Add("ClassName", model.NameClass);
                ht.Add("SubjectName", model.SubjectName);


                result = pbsUtility.InsertData(ht, "SM_SaveClasswiseSub");
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetSubByClass(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht,"SM_GetSubByClass");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteSubject(VmStudentRegistration _objVmStudentRegistration)
        {
            Hashtable ht = new Hashtable();
            ht.Add("ID", _objVmStudentRegistration.ID);
            return pbsUtility.InsertData(ht, "SM_DeleteSubByID");
        }
    }
}