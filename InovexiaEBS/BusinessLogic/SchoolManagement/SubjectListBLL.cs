using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.DataAccess.SchoolManagement;

namespace InovexiaEBS.BusinessLogic.StudentRegistrationBLL
{
    public class SubjectListBLL
    {
        internal static DataTable GetAllSubject()
        {
            SubjectListDLL _objSubjectListDLL = new SubjectListDLL();
            return _objSubjectListDLL.GetAllSubject();
        }
        internal static long DeleteSubject(VmStudentRegistration _objVmStudentRegistration)
        {
            SubjectListDLL _objSubjectListDLL = new SubjectListDLL();
            return _objSubjectListDLL.DeleteSubject(_objVmStudentRegistration);
        }
    }
}