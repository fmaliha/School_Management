using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InovexiaEBS.BusinessLogic.StudentRegistrationBLL;

namespace InovexiaEBS.SchoolManagement
{
    public partial class StudentProfileUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           // tbodestudetails.Visible = false;

           // tbodycontactetails.Visible = false;

            int AdmissionNo = Convert.ToInt32(Request.QueryString["AdmissionNo"]);



            GetStudentDetailsToHF(AdmissionNo);
            GetStudentProfileBasic(AdmissionNo);
            GetGuardianDetailsToHF(AdmissionNo);
            GetParentsDetailsToHF(AdmissionNo);
            GetContactDetailsToHF(AdmissionNo);
            GetPreviousDetailsToHF(AdmissionNo);
        }


        private void GetStudentDetailsToHF(int admissionno)
        {
            Hashtable ht = new Hashtable();

            ht.Add("AdmissionNo",admissionno);

            DataTable dt = StudentProfileBLL.GetStudentDetailsToProfile(ht);

            if (dt.Rows.Count > 0)
            {
                //txtAddmissionNo.Text = dataTable.Rows[0]["AdmissionNo"].ToString();
                // students
                lblstuname.Text = dt.Rows[0]["Name"].ToString();
                lbladmsnNO.Text = dt.Rows[0]["AdmissionNo"].ToString();

                DateTime a = Convert.ToDateTime(dt.Rows[0]["AdmissionDate"].ToString());
                lbladmissiondate.Text = a.ToString("dd/MM/yyyy");

                lblSID.Text = dt.Rows[0]["StudentID"].ToString();

                DateTime b = Convert.ToDateTime(dt.Rows[0]["DOB"].ToString());
                lblDOB.Text = b.ToString("dd/MM/yyyy");

                lblGender.Text = dt.Rows[0]["GenderName"].ToString();
                lblblood.Text = dt.Rows[0]["BloodGroupName"].ToString();
                lblBirthplace.Text = dt.Rows[0]["BirthPlace"].ToString();

                lblnationality.Text = dt.Rows[0]["NationalityName"].ToString();

                lbllanguage.Text = dt.Rows[0]["Language"].ToString();
                lblreligion.Text = dt.Rows[0]["Religion"].ToString();
               
                lblStucategory.Text = dt.Rows[0]["StudentCategoryName"].ToString();
                lblCurrAdd.Text = dt.Rows[0]["CurrentAddress"].ToString();
                lblPerAdd.Text = dt.Rows[0]["PermanentAddress"].ToString();
                lblcity.Text = dt.Rows[0]["City"].ToString();
                lblpincode.Text = dt.Rows[0]["PinCode"].ToString();

                lblcountry.Text = dt.Rows[0]["CountryName"].ToString();

                lblphone.Text = dt.Rows[0]["PhoneNumber"].ToString();
                lblphone2.Text = dt.Rows[0]["PhoneNUmber2"].ToString();
                lblemail.Text = dt.Rows[0]["Email"].ToString();

               
                if (dt.Rows[0]["StudentPhoto"].ToString().Trim() != "")
                {
                    Image1.Visible = true;
                    var photo = dt.Rows[0]["StudentPhoto"].ToString().Trim();
                    Image1.ImageUrl = "~/img/Photos/" + dt.Rows[0]["StudentPhoto"].ToString().Trim();
                }
                else
                {
                    Image1.Visible = false;
                    Image1.ID = null;
                }

                
            }
        }

        private void GetStudentProfileBasic(int admissionno)
        {
            Hashtable ht = new Hashtable();

            ht.Add("AdmissionNo",admissionno);

            DataTable dt = StudentProfileBLL.GetStudentBasicDetailsToProfile(ht);

            if (dt.Rows.Count > 0)
            {
               
                lblSbatch.Text = dt.Rows[0]["BatchYear"].ToString();
                lblSGrade.Text = dt.Rows[0]["Class"].ToString();
                lblSSection.Text = dt.Rows[0]["SectionName"].ToString();
                lblSSession.Text = dt.Rows[0]["Session"].ToString();
            }

        }
        private void GetGuardianDetailsToHF(int admissionno)
        {
            Hashtable ht = new Hashtable();

            ht.Add("AdmissionNo", admissionno);

            DataTable dt = StudentProfileBLL.GetGuardianDetailsToProfile(ht);

            if (dt.Rows.Count > 0)
            {
                //txtAddmissionNo.Text = dataTable.Rows[0]["AdmissionNo"].ToString();
                // students

                lblGname.Text = dt.Rows[0]["Nameguardian"].ToString();

                lblGnationality.Text = dt.Rows[0]["NationalityName"].ToString();
                lblGrel.Text = dt.Rows[0]["RelationName"].ToString();
                lblGresAdd.Text = dt.Rows[0]["Residentialaddressguardian"].ToString();
                lblGpreAdd.Text = dt.Rows[0]["Presentaddressguardian"].ToString();
                lblGperAdd.Text = dt.Rows[0]["Permanentaddressguardian"].ToString();
                lblGPNo.Text = dt.Rows[0]["Telephoneguardian"].ToString();
                lblGMobile.Text = dt.Rows[0]["Mobileguardian"].ToString();
                lblGemail.Text = dt.Rows[0]["Emailguardian"].ToString();
                

            }
        }

        private void GetParentsDetailsToHF(int admissionno)
        {
            Hashtable ht = new Hashtable();

            ht.Add("AdmissionNo", admissionno);

            DataTable dt = StudentProfileBLL.GetParentsDetailsToProfile(ht);

            if (dt.Rows.Count > 0)
            {
                
                // fathers`

                lblFname.Text = dt.Rows[0]["Namefather"].ToString();
                lblFnationality.Text = dt.Rows[0]["NationalityName"].ToString();
                lblFmaritalstatus.Text = dt.Rows[0]["ddlmaritalstatusf"].ToString();
                lblFeducation.Text = dt.Rows[0]["Educationfather"].ToString();
                lblFocc.Text = dt.Rows[0]["Occupationfather"].ToString();   
                lblForg.Text = dt.Rows[0]["Organizationfather"].ToString();
                lblFdesignation.Text = dt.Rows[0]["Designationfather"].ToString();
                lblFyearofservice.Text = dt.Rows[0]["Yearofservicefather"].ToString();
                lblFOffAdd.Text = dt.Rows[0]["Officeaddressfather"].ToString();
                lblFoffTelephone.Text = dt.Rows[0]["OfficeTelephonefather"].ToString();

                lblFresidence.Text = dt.Rows[0]["Residentialaddressfather"].ToString();
                lblFPreAdd.Text = dt.Rows[0]["Presentaddressfather"].ToString();
                lblFPerAdd.Text = dt.Rows[0]["Permanentaddressfather"].ToString();
                lblFTelephone.Text = dt.Rows[0]["Telephonefather"].ToString();
                lblFMobile.Text = dt.Rows[0]["Mobilefather"].ToString();
                lblFmail.Text = dt.Rows[0]["Emailfather"].ToString();
                lblFresidence.Text = dt.Rows[0]["Residencewithfather"].ToString();



                //mother`s

                lblMName.Text = dt.Rows[0]["Namemother"].ToString();
                lblMnationality.Text = dt.Rows[0]["NationalityName"].ToString();
                lblMmaritalStatus.Text = dt.Rows[0]["ddlmaritalstatusf"].ToString();
                lblMeducation.Text = dt.Rows[0]["Educationmother"].ToString();
                lblMocc.Text = dt.Rows[0]["Occupationmother"].ToString();
                lblMOrg.Text = dt.Rows[0]["Organizationmother"].ToString();
                lblMdesignation.Text = dt.Rows[0]["Designationmother"].ToString();
                lblMYearofservice.Text = dt.Rows[0]["Yearofservicemother"].ToString();
                lblMoffAdd.Text = dt.Rows[0]["Officeaddressmother"].ToString();
                lblMoffTel.Text = dt.Rows[0]["Officetelephonemother"].ToString();

                lblMresidence.Text = dt.Rows[0]["Residentialaddessmother"].ToString();
                lblMPreAdd.Text = dt.Rows[0]["Presentaddressmother"].ToString();
                lblMPerAdd.Text = dt.Rows[0]["Permanentaddressmother"].ToString();
                lblMTelephone.Text = dt.Rows[0]["Telephonemother"].ToString();
                lblMMobile.Text = dt.Rows[0]["Mobilemother"].ToString();
                lblMemail.Text = dt.Rows[0]["Emailmother"].ToString();
                lblMresidencewithstudent.Text = dt.Rows[0]["Residencewithmother"].ToString();


            }
        }

        private void GetContactDetailsToHF(int admissionno)
        {
            Hashtable ht = new Hashtable();

            ht.Add("AdmissionNo", admissionno);

            DataTable dt = StudentProfileBLL.GetContactDetailsToProfile(ht);

            if (dt.Rows.Count > 0)
            {
               // emergency contact 

                lblEname.Text = dt.Rows[0]["NameE"].ToString();
                lblEnationality.Text = dt.Rows[0]["NationalityName"].ToString();
                lblErel.Text = dt.Rows[0]["RsWithStudentE"].ToString();
                lblEpreAdd.Text = dt.Rows[0]["PresentAddressE"].ToString();
                lblEperAdd.Text = dt.Rows[0]["PermanentAddressE"].ToString();
                lblETelephone.Text = dt.Rows[0]["TelephoneNoE"].ToString();
                lblEmobile.Text = dt.Rows[0]["MobileNoE"].ToString();
                lblEemail.Text = dt.Rows[0]["EmailE"].ToString();

                
                //referees

                lblR1name.Text = dt.Rows[0]["NameR1"].ToString();
                lblR1nationality.Text = dt.Rows[0]["NationalityName"].ToString();
                lblR1rel.Text = dt.Rows[0]["RsWithStudentR1"].ToString();
                lblR1preadd.Text = dt.Rows[0]["PresentAddressR1"].ToString();
                lblR1peradd.Text = dt.Rows[0]["PermanentAddressR1"].ToString();
                lblR1Telephone.Text = dt.Rows[0]["TelephoneNoR1"].ToString();
                lblR1Mobile.Text = dt.Rows[0]["MobileNoR1"].ToString();
                lblR1mail.Text = dt.Rows[0]["EmailR1"].ToString();

                lblR2name.Text = dt.Rows[0]["NameR2"].ToString();
                lblR2nationality.Text = dt.Rows[0]["NationalityName"].ToString();
                lblR2rel.Text = dt.Rows[0]["RsWithStudentR2"].ToString();
                lblR2preadd.Text = dt.Rows[0]["PresentAddressR2"].ToString();
                lblR2peradd.Text = dt.Rows[0]["PermanentAddressR2"].ToString();
                lblR2tel.Text = dt.Rows[0]["TelephoneNoR2"].ToString();
                lblR2mobile.Text = dt.Rows[0]["MobileNoR2"].ToString();
                lblR2email.Text = dt.Rows[0]["EmailR2"].ToString();

            }
        }

        private void GetPreviousDetailsToHF(int admissionno)
        {
            Hashtable ht = new Hashtable();

            ht.Add("AdmissionNo", admissionno);

            DataTable dt = StudentProfileBLL.GetPreviousDetailsToProfile(ht);

            if (dt.Rows.Count > 0)
            {
                //txtAddmissionNo.Text = dataTable.Rows[0]["AdmissionNo"].ToString();
                // students

                lblPrevIname.Text = dt.Rows[0]["Institutename"].ToString();
                lblPrevGrade.Text = dt.Rows[0]["Prevgrade"].ToString();
                lblPrevAdd.Text = dt.Rows[0]["Addressschool"].ToString();
                lblPrevTel.Text = dt.Rows[0]["Telephoneschool"].ToString();
                lblPrevmail.Text = dt.Rows[0]["Emailschool"].ToString();
                lblPrevdateattended.Text = dt.Rows[0]["Dateattended"].ToString();
                lblPrevAttendingcurrently.Text = dt.Rows[0]["Attendingcurrently"].ToString();
               

            }
        }

       
        protected void btnheaderStuDetails_OnClick(object sender, EventArgs e)
        {
            //tbodestudetails.Visible = true;
        }

        protected void btnheadercontactdetails_OnClick(object sender, EventArgs e)
        {
           // tbodycontactetails.Visible = true;

        }
    }
}