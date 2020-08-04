using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using PBSConnLib;

namespace InovexiaEBS.DataAccess.SchoolManagement
{
    public class StudentRegistrationDLL
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();


        internal long SaveStuDetails(VmStudentRegistration objVmStudent)
        {
            try
            {
                string AdmissionNo = string.Empty;
               // long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("AdmissioDate",objVmStudent.AdmissionDate);
                ht.Add("FirstName",objVmStudent.sFirstName );
                ht.Add("MiddleName",objVmStudent.MiddleName );
                ht.Add("LastName",objVmStudent.sLastName );
                ht.Add("StudentID",objVmStudent.StudentID );
                ht.Add("Batch", objVmStudent.Batch);
                ht.Add("DOB",objVmStudent.sDOB );
                ht.Add("Gender",objVmStudent.Gender);
                ht.Add("Blood",objVmStudent.Blood);
                ht.Add("BirthPlace",objVmStudent.BirthPlace);
                ht.Add("Nationality",objVmStudent.Nationality );
                ht.Add("Language",objVmStudent.Language);
                ht.Add("Religion",objVmStudent.Religion );
                ht.Add("CurrentAddress",objVmStudent.CurrentAddress );
                ht.Add("PermanentAddress",objVmStudent.PermanentAddress );
                ht.Add("City",objVmStudent.sCity);
                ht.Add("State",objVmStudent.sState);
                ht.Add("PinCode",objVmStudent.sPinCode);
                ht.Add("Country",objVmStudent.sCountry );
                ht.Add("PhoneNumber",objVmStudent.PhoneNumber );
                ht.Add("PhoneNumber2",objVmStudent.PhoneNumber2);
                ht.Add("Email", objVmStudent.sEmail);
                ht.Add("StudentCategory", objVmStudent.StudentCategory);
                ht.Add("StudentPhoto", objVmStudent.StudentPhoto);
               // ht.Add("StudentDocument",objVmStudent.StudentDocument);

                //result = Convert.ToInt64(pbsUtility.InsertData(ht, "SMSaveStuDetails"));
                AdmissionNo = pbsUtility.GetDataByProc(ht, "SMSaveStuDetails").Rows[0]["AdmissionNo"].ToString();
                return long.Parse(AdmissionNo);
               // return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


                   ///////////     Gurdians        ///////////////////////////////
                   /// 
                   /// 

       internal long SaveGuardianDetails(VmStudentRegistration objvmguardian)
        {
            try
            {

                long result = 0;
                Hashtable ht = new Hashtable();


                             //father`s


                ht.Add("AdmissionNo",objvmguardian.AdmissionNo);

                ht.Add("Namefather", objvmguardian.Namef);
                ht.Add("Nationalityfather", objvmguardian.Nationalityf);
                ht.Add("MaritalStatusfather", objvmguardian.Maritalstatusf);

                ht.Add("Educationfather", objvmguardian.Educationf);
                ht.Add("Occupationfather", objvmguardian.Occupationf);
                ht.Add("Organizationfather", objvmguardian.Organizationf);

                ht.Add("Designationfather", objvmguardian.Designationf);
                ht.Add("Yearofservicefather", objvmguardian.Yearofservicef);
                ht.Add("Officeaddressfather", objvmguardian.Officeaddf);

                ht.Add("OfficeTelephonefather", objvmguardian.offtphonef);
                ht.Add("Residentialaddressfather", objvmguardian.residenceaddf);
                ht.Add("Presentaddressfather", objvmguardian.preaddf);

                ht.Add("Permanentaddressfather", objvmguardian.peraddf);
                ht.Add("Telephonefather", objvmguardian.tnof);
                ht.Add("Mobilefather", objvmguardian.mobilef);
                ht.Add("Emailfather", objvmguardian.emailaddf);
                ht.Add("Residencewithfather", objvmguardian.childresidewithfather);


                    //   //  Mother`s  ///


                ht.Add("Namemother", objvmguardian.Namem);
                ht.Add("Nationalitymother", objvmguardian.Nationalitym);
                ht.Add("Maritalstatusmother", objvmguardian.Maritalstatusm);

                ht.Add("Educationmother", objvmguardian.Educationm);
                ht.Add("Occupationmother", objvmguardian.Occupationm);
                ht.Add("Organizationmother", objvmguardian.Organizationm);

                ht.Add("Designationmother", objvmguardian.Designationm);
                ht.Add("Yearofservicemother", objvmguardian.Yearofservicem);
                ht.Add("Officeaddressmother", objvmguardian.Officeaddm);

                ht.Add("Officetelephonemother", objvmguardian.offtphonem);
                ht.Add("Residentialaddressmother", objvmguardian.residenceaddm);
                ht.Add("Presentaddressmother", objvmguardian.preaddm);

                ht.Add("Permanentaddressmother", objvmguardian.peraddm);
                ht.Add("Telephonemother", objvmguardian.tnom);
                ht.Add("Mobilemother", objvmguardian.mobilem);
                ht.Add("Emailmother", objvmguardian.emailaddm);
                ht.Add("Residencewithmother", objvmguardian.childresidewithmother);


               
                //////       ////   Guardian`s /// /// 



                ht.Add("Nameguardian", objvmguardian.nameg);
                ht.Add("NationalityGuardian", objvmguardian.nationalityg);
                ht.Add("RelationwithStudent", objvmguardian.Relationwstug);

                ht.Add("Residentialaddressguardian", objvmguardian.residenceaddg);
                ht.Add("Presentaddressguardian", objvmguardian.preaddg);
                ht.Add("Permanentaddressguardian", objvmguardian.peraddg);

                ht.Add("Telephoneguardian", objvmguardian.tnog);
                ht.Add("Mobileguardian", objvmguardian.mobilenog);
                ht.Add("Emailguardian", objvmguardian.emailg);


                result = pbsUtility.InsertData(ht, "SM_GetGuardianDetails");

                return result;
            }
            catch (Exception)
            {
                
                throw;
            }
        }




       internal long SaveEmergencyContact(VmStudentRegistration objvmguardian)
       {
           try
           {

               long result = 0;
               Hashtable ht = new Hashtable();


               //father`s


               ht.Add("AdmissionNo", objvmguardian.AdmissionNo);

               ht.Add("NameE", objvmguardian.NameE);
               ht.Add("NationalityE", objvmguardian.NationalityE);
               ht.Add("RsWithStudentE", objvmguardian.RsWithStudent);

               ht.Add("PresentAddressE", objvmguardian.PresentAddressE);
               ht.Add("PermanentAddressE", objvmguardian.PermanentAddressE);
               ht.Add("TelephoneNoE", objvmguardian.TelephoneNoE);

               ht.Add("MobileNoE", objvmguardian.MobileNoE);
               ht.Add("EmailE", objvmguardian.EAddressE);


               ht.Add("NameR1", objvmguardian.NameR1);
               ht.Add("NationalityR1", objvmguardian.NationalityR1);
               ht.Add("RsWithStudentR1", objvmguardian.RsWithParentR1);

               ht.Add("PresentAddressR1", objvmguardian.PresentAddressR1);
               ht.Add("PermanentAddressR1", objvmguardian.PermanentAddressR1);
               ht.Add("TelephoneNoR1", objvmguardian.TelephoneNoR1);

               ht.Add("MobileNoR1", objvmguardian.MobileNoR1);
               ht.Add("EmailR1", objvmguardian.EAddressR1);



               ht.Add("NameR2", objvmguardian.NameR2);
               ht.Add("NationalityR2", objvmguardian.NationalityR2);
               ht.Add("RsWithStudentR2", objvmguardian.RsWithParentR2);

               ht.Add("PresentAddressR2", objvmguardian.PresentAddressR2);
               ht.Add("PermanentAddressR2", objvmguardian.PermanentAddressR2);
               ht.Add("TelephoneNoR2", objvmguardian.TelephoneNoR2);

               ht.Add("MobileNoR2", objvmguardian.MobileNoR2);
               ht.Add("EmailR2", objvmguardian.EAddressR2);


               result = pbsUtility.InsertData(ht, "SM_SaveEmergencyContact");

               return result;
           }
           catch (Exception)
           {

               throw;
           }
       }


        /// <summary>
        /// /                                    Student List
        /// </summary>
        /// <returns></returns>

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


        internal DataTable GetStudentInfobyAdmissionNo(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht,"SM_Getvaluesbyadmissionno");
                return dataTable;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message.ToString());
            }
        }


        internal long DeleteStudentInfobyAdmissionNo(VmStudentRegistration objStudentRegistration)
        {
            try
            {
               Hashtable ht = new Hashtable();

                ht.Add("AdmissionNo",objStudentRegistration.AdmissionNo);

                return pbsUtility.InsertData(ht, "SM_DeleteStudentRecordbyAdmissionNo");

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        internal long SavePrevDetails(VmStudentRegistration objRegistration)
        {

            long result = 0;
            Hashtable ht = new Hashtable();


            ht.Add("AdmissionNo", objRegistration.AdmissionNo);

            ht.Add("Institutename", objRegistration.namep);
            ht.Add("Prevgrade", objRegistration.gradep);
            ht.Add("Addressschool", objRegistration.addschoolp);

            ht.Add("Telephoneschool", objRegistration.telephonep);
            ht.Add("Emailschool", objRegistration.emailp);
            ht.Add("Dateattended", objRegistration.attenddeddatep);
            ht.Add("Attendingcurrently", objRegistration.attendingcurrp);

            result = pbsUtility.InsertData(ht, "SM_GetPreviousDetails");
            return result;

        }

        internal long SaveAdditionalDetails(VmStudentRegistration vminfo)
        {
            long result = 0;
            Hashtable ht = new Hashtable();

            ht.Add("AdmissionNo", vminfo.AdmissionNo);

            //medical


            ht.Add("HasmedicalProblem", vminfo.Hasmedicalproblem);
            ht.Add("Onmedication", vminfo.Onmedication);
            ht.Add("MedicalSituationDetails", vminfo.Medicaldetails);

           //sibling 1
            ht.Add("Name", vminfo.sname1);
            ht.Add("Gender", vminfo.sgender1);
            ht.Add("Relationshipwithstudent", vminfo.srelationship1);
            ht.Add("Age", vminfo.sage1);
            ht.Add("StudentID", vminfo.sstudentID1);
            ht.Add("ClassRoll", vminfo.sclassroll1);
            ht.Add("Campus", vminfo.scampus1);

            //sibling 2
            ht.Add("NameS2", vminfo.sname2);
            ht.Add("GenderS2", vminfo.sgender2);
            ht.Add("RelationshipwithstudentS2", vminfo.srelationship2);
            ht.Add("AgeS2", vminfo.sage2);
            ht.Add("StudentIDS2", vminfo.sstudentID2);
            ht.Add("ClassRollS2", vminfo.sclassroll2);
            ht.Add("CampusS2", vminfo.scampus2);

            ht.Add("Haspersonalcar", vminfo.personalcar);
            ht.Add("Willusepublictransport", vminfo.bus);
            ht.Add("Willuseschoolbus", vminfo.schoolbus);
            ht.Add("Carregistrationno", vminfo.carregno);
           
          
            result = pbsUtility.InsertData(ht, "SM_SaveAdditionalDetails");
            return result;
        }

        internal long UploadDocument(VmStudentRegistration vmobj)
        {
            long result = 0;
            Hashtable ht = new Hashtable();


            ht.Add("AdmissionNo", vmobj.AdmissionNo);
            ht.Add("Documents", vmobj.StudentDocument);


            result = pbsUtility.InsertData(ht, "SM_GetstudentDoc");
            return result;
        }


        //internal DataTable GetFilterSearchwithStuID(Hashtable ht)
        //{
        //    try
        //    {

        //        DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_FilterStudentListwithID");
        //        return dataTable;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

        //internal DataTable GetFilterSearchwithStuName(Hashtable ht)
        //{
        //    try
        //    {

        //        DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_FilterStudentListwithName");
        //        return dataTable;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

        //internal DataTable GetFilterSearchwithBatch(VmStudentRegistration objvm)
        //{
        //    try
        //    {
        //        Hashtable ht = new Hashtable();

        //        ht.Add("Batch",objvm.Batch);
        //        DataTable dataTable = pbsUtility.GetDataByProc(ht, "SM_FilterStudentListwithBatch");
        //        return dataTable;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message.ToString());
        //    }
        //}
    }
         
}