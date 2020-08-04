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
    public class StudentRegistrationEditDLL
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();

        internal DataTable GetAllStudent()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("SM_GetStudentList");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetStudentInfoById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_GetStudentDetailsByAdmissionNo");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetGuardianInfoById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_GetGuardianDetailsByAdmissionNo");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetFamilyInfoById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_GetFamilyInfoByAdmissionNo");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetEmergencyContactById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_GetEmergencyContactByAdmissionNo");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetKeyReferenceOfParentByID(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_GetKeyReferenceOfParentByAdmissionNo");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        internal DataTable GetTransportationDetailsByID(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_GetTransportationDetailsByAdmissionNo");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }



        internal DataTable GetMedicalInformationByID(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_GetMedicalInformationByAdmissionNo");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        internal DataTable GetSiblingInformation(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_GetSiblingInformationByAdmissionNo");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetEducationalBackGround(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_GetEducationalBackgroundByAdmissionNo");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteStudentDetailsByAdmissionNo(VmStudentRegistration modelRegistration)
        {
            Hashtable ht = new Hashtable();
            ht.Add("AdmissionNo", modelRegistration.AdmissionNo);
            return pbsUtility.InsertData(ht, "SM_DeleteStudentDetailByAdmissionNo");
        }


        public long Update_StudentDetails(VmStudentRegistration model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();

                ht.Add("AdmissionNo", model.AdmissionNo);
                ht.Add("FirstName", model.sFirstName);
                ht.Add("MiddleName", model.MiddleName);
                ht.Add("LastName", model.sLastName);
                ht.Add("StudentID", model.StudentID);
                ht.Add("Batch", model.Batch);
                ht.Add("DOB", model.sDOB);
                ht.Add("Gender", model.Gender);
                ht.Add("Blood", model.Blood);
                ht.Add("BirthPlace", model.BirthPlace);
                ht.Add("Nationality", model.Nationality);
                ht.Add("Language", model.Language);
                ht.Add("Religion", model.Religion);
                ht.Add("CurrentAddress", model.CurrentAddress);
                ht.Add("PermanentAddress", model.PermanentAddress);
                ht.Add("City", model.sCity);
                ht.Add("State", model.sState);
                ht.Add("PinCode", model.sPinCode);
                ht.Add("Country", model.sCountry);
                ht.Add("PhoneNumber", model.PhoneNumber);
                ht.Add("PhoneNumber2", model.PhoneNumber2);
                ht.Add("Email", model.sEmail);
                ht.Add("StudentCategory", model.StudentCategory);
                ht.Add("StudentPhoto", model.StudentPhoto);

                result = pbsUtility.InsertData(ht, "SM_UpdateStudentDetails");
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public long Update_EducationalBackground(VmStudentRegistration model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("AdmissionNo", model.AdmissionNo);
                ht.Add("Institutename", model.namep);
                ht.Add("Prevgrade", model.gradep);
                ht.Add("Addressschool", model.addschoolp);
                ht.Add("Telephoneschool", model.telephonep);
                ht.Add("Emailschool", model.emailp);
                ht.Add("Dateattended", model.attenddeddatep);
                ht.Add("AttendingCurrently", model.attendingcurrp);


                result = Convert.ToInt64(pbsUtility.ExecuteCommand(ht, "SM_UpdateEducationalBackground"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public long Update_EmergencyContact(VmStudentRegistration model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("AdmissionNo", model.AdmissionNo);
                ht.Add("NameE", model.NameE);
                ht.Add("NationalityE", model.NationalityE);
                ht.Add("RsWithStudentE", model.RsWithStudent);
                ht.Add("PresentAddressE", model.PresentAddressE);
                ht.Add("PermanentAddressE", model.PermanentAddressE);
                ht.Add("TelephoneNoE", model.TelephoneNoE);
                ht.Add("MobileNoE", model.MobileNoE);
                ht.Add("EmailE", model.EAddressE);

                ht.Add("NameR1", model.NameR1);
                ht.Add("NationalityR1", model.NationalityR1);
                ht.Add("RsWithStudentR1", model.RsWithParentR1);
                ht.Add("PresentAddressR1", model.PresentAddressR1);
                ht.Add("PermanentAddressR1", model.PermanentAddressR1);
                ht.Add("TelephoneNoR1", model.TelephoneNoR1);
                ht.Add("MobileNoR1", model.MobileNoR1);
                ht.Add("EmailR1", model.EAddressR1);
                ht.Add("NameR2", model.NameR2);
                ht.Add("NationalityR2", model.NationalityR2);
                ht.Add("RsWithStudentR2", model.RsWithParentR2);
                ht.Add("PresentAddressR2", model.PresentAddressR2);
                ht.Add("PermanentAddressR2", model.PermanentAddressR2);
                ht.Add("TelephoneNoR2", model.TelephoneNoR2);
                ht.Add("MobileNoR2", model.MobileNoR2);
                ht.Add("EmailR2", model.EAddressR2);


                result = Convert.ToInt64(pbsUtility.ExecuteCommand(ht, "SM_UpdateEmergencyContact"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        public long Update_GuardianDetails(VmStudentRegistration model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("AdmissionNo", model.AdmissionNo);
                ht.Add("Nameguardian", model.nameg);
                ht.Add("NationalityGuardian", model.nationalityg);
                ht.Add("RelationwithStudent", model.Relationwstug);
                ht.Add("Residentialaddressguardian", model.residenceaddg);
                ht.Add("Presentaddressguardian", model.preaddg);
                ht.Add("Permanentaddressguardian", model.peraddg);
                ht.Add("Telephoneguardian", model.tnog);
                ht.Add("Mobileguardian", model.mobilenog);
                ht.Add("Emailguardian", model.emailg);



                ht.Add("Namefather", model.Namef);
                ht.Add("Nationalityfather", model.Nationalityf);
                ht.Add("MaritalStatusfather", model.Maritalstatusf);
                ht.Add("Educationfather", model.Educationf);
                ht.Add("Occupationfather", model.Occupationf);
                ht.Add("Organizationfather", model.Organizationf);
                ht.Add("Designationfather", model.Designationf);
                ht.Add("Yearofservicefather", model.Yearofservicef);
                ht.Add("Officeaddressfather", model.Officeaddf);
                ht.Add("OfficeTelephonefather", model.offtphonef);
                ht.Add("Residentialaddressfather", model.residenceaddf);
                ht.Add("Presentaddressfather", model.preaddf);
                ht.Add("Permanentaddressfather", model.peraddf);
                ht.Add("Telephonefather", model.tnof);
                ht.Add("Mobilefather", model.mobilef);
                ht.Add("Emailfather", model.emailaddf);
                ht.Add("Residencewithfather", model.childresidewithfather);

                ht.Add("Namemother", model.Namem);
                ht.Add("Nationalitymother", model.Nationalitym);
                ht.Add("Maritalstatusmother", model.Maritalstatusm);
                ht.Add("Educationmother", model.Educationm);
                ht.Add("Occupationmother", model.Occupationm);
                ht.Add("Organizationmother", model.Organizationm);
                ht.Add("Designationmother", model.Designationm); ;
                ht.Add("Yearofservicemother", model.Yearofservicem);
                ht.Add("Officeaddressmother", model.Officeaddm);
                ht.Add("Officetelephonemother", model.offtphonem);
                ht.Add("Residentialaddressmother", model.residenceaddm); ;
                ht.Add("Presentaddressmother", model.preaddm);
                ht.Add("Permanentaddressmother", model.peraddm);
                ht.Add("Telephonemother", model.tnom);
                ht.Add("Mobilemother", model.mobilem);
                ht.Add("Emailmother", model.emailaddm);
                ht.Add("Residencewithmother", model.childresidewithmother);


                result = Convert.ToInt64(pbsUtility.ExecuteCommand(ht, "SM_UpdateGuardianDetails"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public long Update_OtherDetails(VmStudentRegistration model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("AdmissionNo", model.AdmissionNo);
                ht.Add("Haspersonalcar", model.personalcar);
                ht.Add("Willusepublictransport", model.bus);
                ht.Add("Willuseschoolbus", model.schoolbus);
                ht.Add("Carregistrationno", model.carregno);

                ht.Add("Hasmedicalproblem", model.Hasmedicalproblem);
                ht.Add("Onmedication", model.Onmedication);
                ht.Add("MedicalSituationDetails", model.Medicaldetails);

                ht.Add("Name", model.sname1);
                ht.Add("Gender", model.sgender1);
                ht.Add("Relationshipwithstudent", model.srelationship1);
                ht.Add("Age", model.sage1);
                ht.Add("StudentID", model.sstudentID1);
                ht.Add("ClassRoll", model.sclassroll1);
                ht.Add("Campus", model.scampus1);

                //sibling 2
                ht.Add("NameS2", model.sname2);
                ht.Add("GenderS2", model.sgender2);
                ht.Add("RelationshipwithstudentS2", model.srelationship2);
                ht.Add("AgeS2", model.sage2);
                ht.Add("StudentIDS2", model.sstudentID2);
                ht.Add("ClassRollS2", model.sclassroll2);
                ht.Add("CampusS2", model.scampus2);

                result = pbsUtility.InsertData(ht, "SM_UpdateOtherDetails");
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}