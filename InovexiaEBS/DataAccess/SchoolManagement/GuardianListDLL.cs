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
    public class GuardianListDLL
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();


        internal DataTable GetAllGuardian()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("SM_GetGuardianList");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        internal long DeleteGuardianDetailsByAdmissionNo(VmStudentRegistration _objVmStudentRegistration)
        {
            Hashtable ht = new Hashtable();
            ht.Add("AdmissionNo", _objVmStudentRegistration.AdmissionNo);
            return pbsUtility.InsertData(ht, "SM_DeleteGuardianDetailByAdmissionNo");
        }
    }
}