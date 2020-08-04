using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PBSConnLib;

namespace InovexiaEBS.DataAccess.SchoolManagement
{
    
    public class StudentProfileDLL
    {
        PBSDBUtility pbsd = new PBSDBUtility();



        internal DataTable GetStudentProfileInfo(Hashtable ht)
        {
            try
            {
                DataTable dt = pbsd.GetDataByProc(ht,"SM_GetStudentDetails");

                return dt;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetStudentProfileBasicInfo(Hashtable ht)
        {
            try
            {
                DataTable dt = pbsd.GetDataByProc(ht, "SM_GetStudentProfileInfo");

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetGuardianProfileInfo(Hashtable ht)
        {
            try
            {
                DataTable dt = pbsd.GetDataByProc(ht, "SM_GetGuardianDetailsProfile");

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetParentsProfileInfo(Hashtable ht)
        {
            try
            {
                DataTable dt = pbsd.GetDataByProc(ht, "SM_GetPArentsDetailsProfile");

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetContactProfileInfo(Hashtable ht)
        {
            try
            {
                DataTable dt = pbsd.GetDataByProc(ht, "SM_GetEmergencyContactDetailsProfile");

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetPreviousProfileInfo(Hashtable ht)
        {
            try
            {
                DataTable dt = pbsd.GetDataByProc(ht, "SM_GetPreviousDetailsProfile");

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

           }
}