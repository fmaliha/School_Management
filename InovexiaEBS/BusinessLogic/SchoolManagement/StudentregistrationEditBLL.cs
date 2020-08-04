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
    public class StudentregistrationEditBLL
    {

        StudentRegistrationEditDLL _objStudentRegistrationEditDll = new StudentRegistrationEditDLL();
        internal static DataTable GetAllStudent()
        {
            StudentRegistrationEditDLL _objStudentRegistration = new StudentRegistrationEditDLL();
            return _objStudentRegistration.GetAllStudent();
        }
        internal static DataTable GetStudentDetailsByAdmissionNo(Hashtable ht)
        {
            StudentRegistrationEditDLL accessLayer = new StudentRegistrationEditDLL();
            return accessLayer.GetStudentInfoById(ht);
        }

        internal static DataTable GetGuardianDetailsByAdmissionNo(Hashtable ht)
        {
            StudentRegistrationEditDLL accessLayer = new StudentRegistrationEditDLL();
            return accessLayer.GetGuardianInfoById(ht);
        }

        internal static DataTable GetFamilyInfoByAdmissionNo(Hashtable ht)
        {
            StudentRegistrationEditDLL accessLayer = new StudentRegistrationEditDLL();
            return accessLayer.GetFamilyInfoById(ht);
        }

        internal static DataTable GetEmergencyContactById(Hashtable ht)
        {
            StudentRegistrationEditDLL accessLayer = new StudentRegistrationEditDLL();
            return accessLayer.GetEmergencyContactById(ht);
        }

        internal static DataTable GetKeyReferenceOfParentByID(Hashtable ht)
        {
            StudentRegistrationEditDLL accessLayer = new StudentRegistrationEditDLL();
            return accessLayer.GetKeyReferenceOfParentByID(ht);
        }

        internal static DataTable GetTransportationDetailsByID(Hashtable ht)
        {
            StudentRegistrationEditDLL accessLayer = new StudentRegistrationEditDLL();
            return accessLayer.GetTransportationDetailsByID(ht);
        }

        internal static DataTable GetMedicalInformationByID(Hashtable ht)
        {
            StudentRegistrationEditDLL accessLayer = new StudentRegistrationEditDLL();
            return accessLayer.GetMedicalInformationByID(ht);
        }

        internal static DataTable GetSiblingInformationByAdmissionNo(Hashtable ht)
        {
            StudentRegistrationEditDLL accessLayer = new StudentRegistrationEditDLL();
            return accessLayer.GetSiblingInformation(ht);
        }

        internal static DataTable GetEducationalBackGroundByAdmissionNo(Hashtable ht)
        {
            StudentRegistrationEditDLL accessLayer = new StudentRegistrationEditDLL();
            return accessLayer.GetEducationalBackGround(ht);
        }

        internal static long DeleteStudentDetails(VmStudentRegistration _objVmStudentRegistration)
        {
            StudentRegistrationEditDLL _objStudentRegistrationDll = new StudentRegistrationEditDLL();
            return _objStudentRegistrationDll.DeleteStudentDetailsByAdmissionNo(_objVmStudentRegistration);
        }

        internal long Update_StudentDetails(VmStudentRegistration _objVmStudent)
        {
            return _objStudentRegistrationEditDll.Update_StudentDetails(_objVmStudent);
        }
        internal long Update_EducationalBackground(VmStudentRegistration _objVmStudent)
        {
            return _objStudentRegistrationEditDll.Update_EducationalBackground(_objVmStudent);
        }
        internal long Update_EmergencyContact(VmStudentRegistration _objVmStudent)
        {
            return _objStudentRegistrationEditDll.Update_EmergencyContact(_objVmStudent);
        }

        internal long Update_GuardianDetails(VmStudentRegistration _objVmStudent)
        {
            return _objStudentRegistrationEditDll.Update_GuardianDetails(_objVmStudent);
        }

        internal long Update_OtherDetails(VmStudentRegistration _objVmStudent)
        {
            return _objStudentRegistrationEditDll.Update_OtherDetails(_objVmStudent);
        }

    }
}