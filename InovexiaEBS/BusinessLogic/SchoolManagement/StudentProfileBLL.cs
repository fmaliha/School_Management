using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using InovexiaEBS.DataAccess.SchoolManagement;

namespace InovexiaEBS.BusinessLogic.StudentRegistrationBLL
{
    public class StudentProfileBLL
    {

        internal static DataTable GetStudentDetailsToProfile(Hashtable ht)
        {
            StudentProfileDLL dll = new StudentProfileDLL();

            return dll.GetStudentProfileInfo(ht);

        }

        internal static DataTable GetStudentBasicDetailsToProfile(Hashtable ht)
        {
            StudentProfileDLL dll = new StudentProfileDLL();

            return dll.GetStudentProfileBasicInfo(ht);

        }

        internal static DataTable GetGuardianDetailsToProfile(Hashtable ht)
        {
            StudentProfileDLL dll = new StudentProfileDLL();

            return dll.GetGuardianProfileInfo(ht);

        }

        internal static DataTable GetParentsDetailsToProfile(Hashtable ht)
        {
            StudentProfileDLL dll = new StudentProfileDLL();

            return dll.GetParentsProfileInfo(ht);

        }

        internal static DataTable GetContactDetailsToProfile(Hashtable ht)
        {
            StudentProfileDLL dll = new StudentProfileDLL();

            return dll.GetContactProfileInfo(ht);

        }

        internal static DataTable GetPreviousDetailsToProfile(Hashtable ht)
        {
            StudentProfileDLL dll = new StudentProfileDLL();

            return dll.GetPreviousProfileInfo(ht);

        }

        
    }
}