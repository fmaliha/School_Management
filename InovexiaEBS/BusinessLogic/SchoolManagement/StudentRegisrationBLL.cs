using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.DataAccess.SchoolManagement;

namespace InovexiaEBS.BusinessLogic.SchoolManagement
{
    public class StudentRegisrationBLL
    {
        StudentRegistrationDLL _objStudentRegistrationDll = new StudentRegistrationDLL();

        internal long SaveStuDetails(VmStudentRegistration objVmStudent)
        {
            return _objStudentRegistrationDll.SaveStuDetails(objVmStudent);
        }

        internal long SaveGuardianDetails(VmStudentRegistration objvmguardian)
        {
            return _objStudentRegistrationDll.SaveGuardianDetails(objvmguardian);
        }

        internal long SaveEmergencyContact(VmStudentRegistration objvmguardian)
        {
            return _objStudentRegistrationDll.SaveEmergencyContact(objvmguardian);
        }




        /// <summary>
        /// /                       Student List
        /// </summary>
        /// <returns></returns>
        /// 
        /// 
        /// 
        internal static DataTable GetAllStudent()
        {
            StudentRegistrationDLL _objStudentRegistrationDll = new StudentRegistrationDLL();
            return _objStudentRegistrationDll.GetAllStudent();
        }

        


        internal static long SavePrevDetails(VmStudentRegistration objVmStudentRegistration)
        {
            StudentRegistrationDLL objdll = new StudentRegistrationDLL();

            return objdll.SavePrevDetails(objVmStudentRegistration);
        }

        internal static long SaveAdditionalDetails(VmStudentRegistration objvm)
        {
            StudentRegistrationDLL objdll = new StudentRegistrationDLL();

            return objdll.SaveAdditionalDetails(objvm);
        }

        internal static long UploadDocument(VmStudentRegistration vmobj)
        {
            StudentRegistrationDLL objdll = new StudentRegistrationDLL();

            return objdll.UploadDocument(vmobj);
        }

        
        /// ///////                 LIST
      
        //internal static DataTable GetStudentInfobyAdmissionNo(Hashtable ht)
        //{
        //    StudentRegistrationDLL _objStudentRegistrationDll = new StudentRegistrationDLL();

        //    return _objStudentRegistrationDll.GetStudentInfobyAdmissionNo(ht);

        //}

        //internal static long DeleteStudentInfobyAdmissionNo(VmStudentRegistration objStudentRegistration)
        //{
        //    StudentRegistrationDLL _objStudentRegistrationDll = new StudentRegistrationDLL();

        //    return _objStudentRegistrationDll.DeleteStudentInfobyAdmissionNo(objStudentRegistration);
        //}

        //internal static DataTable GetFilteredstudentlistwithStuID( Hashtable ht)
        //{
        //    StudentRegistrationDLL objdll = new StudentRegistrationDLL();

        //    return objdll.GetFilterSearchwithStuID(ht);
        //}

        //internal static DataTable GetFilteredstudentlistwithStuName(Hashtable ht)
        //{
        //    StudentRegistrationDLL objdll = new StudentRegistrationDLL();

        //    return objdll.GetFilterSearchwithStuName(ht);
        //}

        //internal static DataTable GetFilteredstudentlistwithBatch(VmStudentRegistration _objvm)
        //{
        //    StudentRegistrationDLL objdll = new StudentRegistrationDLL();

        //    return objdll.GetFilterSearchwithBatch(_objvm);
        //}
    }
}