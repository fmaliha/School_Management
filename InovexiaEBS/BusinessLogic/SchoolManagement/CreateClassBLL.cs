using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.DataAccess.SchoolManagement;

namespace InovexiaEBS.BusinessLogic.StudentRegistrationBLL
{
    public class CreateClassBLL
    {
        CreateClassDLL _objCreateClassDLL = new CreateClassDLL();
        internal long Save_CreateClass(VmStudentRegistration _objVmStudent)
        {
            return _objCreateClassDLL.Save_CreateClass(_objVmStudent);
        }

        internal static DataTable checkClassnames(Hashtable ht)
        {
            CreateClassDLL cbdll = new CreateClassDLL();

            return cbdll.checkClassnames(ht);

        }

        //internal static DataTable GetClassDetailsByClassID(Hashtable ht)
        //{
        //    CreateClassDLL accessLayer = new CreateClassDLL();
        //    return accessLayer.GetClassDetailsByClassID(ht);
        //}

        internal long Update_Class(VmStudentRegistration _objVmStudent)
        {
            return _objCreateClassDLL.Update_Class(_objVmStudent);
        }
    }
}