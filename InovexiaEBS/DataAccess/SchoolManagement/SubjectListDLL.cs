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
    public class SubjectListDLL
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();


        internal DataTable GetAllSubject()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("SM_GetSubjecttolist");
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
            ht.Add("SubjectID", _objVmStudentRegistration.SubjectID);
            return pbsUtility.InsertData(ht, "SM_DeleteSubject");
        }

    }
}