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
    public class ClassListBLL
    {
        internal static DataTable GetAllClass()
        {
            ClassListDLL _objClassListDLL = new ClassListDLL();
            return _objClassListDLL.GetAllClass();
        }

        internal static DataTable GetAddClassByClassID(Hashtable ht)
        {
            ClassListDLL accessLayer = new ClassListDLL();
            return accessLayer.GetAddClassByClassID(ht);
        }

        internal static long SaveSelectedSub(VmStudentRegistration _objVmStudent)
        {
            ClassListDLL accessLayer = new ClassListDLL();
            return accessLayer.SaveSelectedSub(_objVmStudent);
        }

        internal static DataTable GetSubByClass(Hashtable ht)
        {
            ClassListDLL _objClassListDLL = new ClassListDLL();
            return _objClassListDLL.GetSubByClass(ht);
        }
        internal static long DeleteSubject(VmStudentRegistration _objVmStudentRegistration)
        {
            ClassListDLL _objClassListDLL = new ClassListDLL();
            return _objClassListDLL.DeleteSubject(_objVmStudentRegistration);
        }
    }
}