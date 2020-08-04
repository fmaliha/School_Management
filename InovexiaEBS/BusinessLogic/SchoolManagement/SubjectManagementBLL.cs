using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.DataAccess.SchoolManagement;

namespace InovexiaEBS.BusinessLogic.StudentRegistrationBLL
{
    public class SubjectManagementBLL
    {
        SubjectManagementDLL _objSubjectManagementDLL = new SubjectManagementDLL();

        internal long Save_Subject(VmStudentRegistration _objVmStudent)
        {
            return _objSubjectManagementDLL.Save_Subject(_objVmStudent);
        }
    }
}