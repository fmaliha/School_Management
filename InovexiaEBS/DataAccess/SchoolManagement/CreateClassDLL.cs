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
    public class CreateClassDLL
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long Save_CreateClass(VmStudentRegistration model)
        {
            try
            {
                string result = string.Empty;
                Hashtable ht = new Hashtable();
                
                ht.Add("ClassName", model.NameClass);
                ht.Add("SectionID", model.SectionID);

                ht.Add("Remarks", model.RemarksClass);
                //ht.Add("CreatedBy", model.CreatedByClass);
                //ht.Add("CreateTime", model.CreateTimeClass);

                result = pbsUtility.GetDataByProc(ht, "SM_SaveClassDetails").Rows[0]["ClassID"].ToString();
                return long.Parse(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable checkClassnames(Hashtable ht)
        {
            try
            {

                DataTable dbt = pbsUtility.GetDataByProc(ht, "SM_CheckClassnames");
                return dbt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }



        //internal DataTable GetClassDetailsByClassID(Hashtable ht)
        //{
        //    try
        //    {
        //        DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_GetClassDetailsByClassID");
        //        return dataTable;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

        public long Update_Class(VmStudentRegistration model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();

                ht.Add("ClassID", model.ClassID);
                ht.Add("ClassName", model.NameClass);
                ht.Add("SectionID", model.SectionID);

                ht.Add("Remarks", model.RemarksClass);


                return result= pbsUtility.InsertData(ht, "SM_UpdateClass");
                //return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

    }
}