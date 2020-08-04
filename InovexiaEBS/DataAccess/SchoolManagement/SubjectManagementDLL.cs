using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using PBSConnLib;

namespace InovexiaEBS.DataAccess.SchoolManagement
{
    public class SubjectManagementDLL
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();

        internal long Save_Subject(VmStudentRegistration model)
        {
            try
            {
                string SubjectID = string.Empty;
                Hashtable ht = new Hashtable();
                ht.Add("SubjectName", model.SubjectName);
                

                SubjectID = pbsUtility.GetDataByProc(ht, "SM_SaveSubject").Rows[0]["SubjectID"].ToString();
                return long.Parse(SubjectID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}