using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.DataAccess.SchoolManagement;
using InovexiaEBS.DataAccess.TextileEducation;

namespace InovexiaEBS.BusinessLogic.SchoolManagement
{
    public class StudentListBLL
    {
      

        internal static DataTable GetAllStudent()
        {
            StudentListDLL _objStudentList = new StudentListDLL();
            return _objStudentList.GetAllStudent();
        }

        
         internal static DataTable GetStudentInfobyAdmissionNo(Hashtable ht)
        {
            StudentListDLL _objStudentRegistrationDll = new StudentListDLL();

            return _objStudentRegistrationDll.GetStudentInfobyAdmissionNo(ht);

        }

       
         internal static DataTable GetFilteredstudentlistwithStuID(Hashtable ht)
         {
             StudentListDLL objdll = new StudentListDLL();

             return objdll.GetFilterSearchwithStuID(ht);
         }

         internal static DataTable GetFilteredstudentlistwithStuName(Hashtable ht)
         {
             StudentListDLL objdll = new StudentListDLL();

             return objdll.GetFilterSearchwithStuName(ht);
         }

         internal static DataTable GetFilteredstudentlistwithBatch(VmStudentRegistration _objvm)
         {
             StudentListDLL objdll = new StudentListDLL();

             return objdll.GetFilterSearchwithBatch(_objvm);
         }

         internal static long DeleteStudentInfobyAdmissionNo(VmStudentRegistration objStudentRegistration)
        {
            StudentListDLL _objStudentRegistrationDll = new StudentListDLL();

            return _objStudentRegistrationDll.DeleteStudentInfobyAdmissionNo(objStudentRegistration);
        }
          
    }
}