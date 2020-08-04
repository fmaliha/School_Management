using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.BusinessLogic.SchoolManagement;
using PBSConnLib;
using Telerik.Web.UI;

namespace InovexiaEBS.SchoolManagement
{
    public partial class StudentRegistrationEditUI : System.Web.UI.Page
    {

        VmStudentRegistration _objVmStudent = new VmStudentRegistration();
        StudentregistrationEditBLL _objStudentregistrationEditBLL = new StudentregistrationEditBLL();
        PBSDBUtility pbUtility = new PBSDBUtility();
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!Page.IsPostBack)
            {
                // do data retrievel here on when the page first loads. The new data you've entered
                // will just postback you click on the udpate button,
                // or you can do data retrievel again after your sql update in btnupdate_click

                // int AdmissionNo = int.Parse((sender as LinkButton).CommandArgument);
                int AdmissionNo = Convert.ToInt32(Request.QueryString["AdmissionNo"]);


                GetStudentDetailsByAdmissionNo(AdmissionNo);
                GetEmergencyContactByAdmissionNo(AdmissionNo);
                //GetKeyReferenceOfParentByAdmissionNo(AdmissionNo);
                GetFamilyInfoByAdmissionNo(AdmissionNo);
                GetGuardianDetailsByAdmissionNo(AdmissionNo);
                GetEducationalBackGroundByAdmissionNo(AdmissionNo);
                GetTranspotationDetailsByAdmissionNo(AdmissionNo);
                GetMedicalInformationByAdmissionNo(AdmissionNo);
                GetSiblingInformationByAdmissionNo(AdmissionNo);
            }

        }





        private void GetStudentDetailsByAdmissionNo(int AdmissionNo)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("AdmissionNo", AdmissionNo);
                DataTable dataTable = StudentregistrationEditBLL.GetStudentDetailsByAdmissionNo(ht);
                if (dataTable.Rows.Count > 0)
                {
                    txtadmsnnum.Text = dataTable.Rows[0]["AdmissionNo"].ToString();
                    ddladmsndate.SelectedDate = (DateTime)dataTable.Rows[0]["AdmissioDate"];
                    txtfn.Text = dataTable.Rows[0]["FirstName"].ToString();

                    txtmdln.Text = dataTable.Rows[0]["MiddleName"].ToString();
                    txtln.Text = dataTable.Rows[0]["LastName"].ToString();
                    txtstuid.Text = dataTable.Rows[0]["StudentID"].ToString();

                    ddlbatch.ClearSelection();
                    ddlbatch.Text = dataTable.Rows[0]["BatchName"].ToString();
                    ddlbatch.SelectedValue = dataTable.Rows[0]["Batch"].ToString();

                    DateOfBirthS.SelectedDate = (DateTime)dataTable.Rows[0]["DOB"];

                    ddlgender.ClearSelection();
                    ddlgender.Text = dataTable.Rows[0]["GenderName"].ToString();
                    ddlgender.SelectedValue = dataTable.Rows[0]["Gender"].ToString();

                    ddlblood.ClearSelection();
                    ddlblood.Text = dataTable.Rows[0]["BloodgroupName"].ToString();
                    ddlblood.SelectedValue = dataTable.Rows[0]["Blood"].ToString();

                    txtbirthplace.Text = dataTable.Rows[0]["BirthPlace"].ToString();

                    ddlnationality.ClearSelection();
                    ddlnationality.Text = dataTable.Rows[0]["NationalityName"].ToString();
                    ddlnationality.SelectedValue = dataTable.Rows[0]["Nationality"].ToString();

                    txtlang.Text = dataTable.Rows[0]["Language"].ToString();

                    txtreli.Text = dataTable.Rows[0]["Religion"].ToString();
                    txtcadds.Text = dataTable.Rows[0]["CurrentAddress"].ToString();
                    txtpadds.Text = dataTable.Rows[0]["PermanentAddress"].ToString();

                    txtcitys.Text = dataTable.Rows[0]["City"].ToString();
                    txtstates.Text = dataTable.Rows[0]["State"].ToString();
                    txtpins.Text = dataTable.Rows[0]["PinCode"].ToString();

                    ddlstucountry.ClearSelection();
                    ddlstucountry.Text = dataTable.Rows[0]["CountryName"].ToString();
                    ddlstucountry.SelectedValue = dataTable.Rows[0]["Country"].ToString();

                    txtphones.Text = dataTable.Rows[0]["PhoneNumber"].ToString();
                    txtphone2s.Text = dataTable.Rows[0]["PhoneNumber2"].ToString();

                    txtemails.Text = dataTable.Rows[0]["Email"].ToString();

                    ddlstucat.ClearSelection();
                    ddlstucat.Text = dataTable.Rows[0]["StudentCategoryName"].ToString();
                    ddlstucat.SelectedValue = dataTable.Rows[0]["StudentCategory"].ToString();

                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void GetEmergencyContactByAdmissionNo(int AdmissionNo)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("AdmissionNo", AdmissionNo);
                DataTable dataTable = StudentregistrationEditBLL.GetEmergencyContactById(ht);
                if (dataTable.Rows.Count > 0)
                {
                    txtadmsnnum.Text = dataTable.Rows[0]["AdmissionNo"].ToString();
                    txtNameE.Text = dataTable.Rows[0]["NameE"].ToString();

                    ddlNationalityE.ClearSelection();
                    ddlNationalityE.Text = dataTable.Rows[0]["NationalityName"].ToString();
                    ddlNationalityE.SelectedValue = dataTable.Rows[0]["NationalityE"].ToString();

                    txtRsWithStudentE.Text = dataTable.Rows[0]["RsWithStudentE"].ToString();
                    txtPreAddressE.Text = dataTable.Rows[0]["PresentAddressE"].ToString();
                    txtPerAddressE.Text = dataTable.Rows[0]["PermanentAddressE"].ToString();

                    txtTelNoE.Text = dataTable.Rows[0]["TelephoneNoE"].ToString();
                    TxtMobNoE.Text = dataTable.Rows[0]["MobileNoE"].ToString();
                    txtEAddressE.Text = dataTable.Rows[0]["EmailE"].ToString();

                    txtNameR1.Text = dataTable.Rows[0]["NameR1"].ToString();

                    ddlNationalityR1.ClearSelection();
                    ddlNationalityR1.Text = dataTable.Rows[0]["NationalityName"].ToString();
                    ddlNationalityR1.SelectedValue = dataTable.Rows[0]["NationalityR1"].ToString();

                    txtRsWithParentR1.Text = dataTable.Rows[0]["RsWithStudentR1"].ToString();
                    txtPreAddressR1.Text = dataTable.Rows[0]["PresentAddressR1"].ToString();
                    txtPerAddressR1.Text = dataTable.Rows[0]["PermanentAddressR1"].ToString();

                    txtTelNoR1.Text = dataTable.Rows[0]["TelephoneNoR1"].ToString();
                    txtMoNoR1.Text = dataTable.Rows[0]["MobileNoR1"].ToString();
                    txtEAddressR1.Text = dataTable.Rows[0]["EmailR1"].ToString();

                    txtNameR2.Text = dataTable.Rows[0]["NameR2"].ToString();

                    ddlNationalityR2.ClearSelection();
                    ddlNationalityR2.Text = dataTable.Rows[0]["NationalityName"].ToString();
                    ddlNationalityR2.SelectedValue = dataTable.Rows[0]["NationalityR2"].ToString();

                    txtRsWithParentR2.Text = dataTable.Rows[0]["RsWithStudentR2"].ToString();
                    txtPreAddressR2.Text = dataTable.Rows[0]["PresentAddressR2"].ToString();
                    txtPerAddressR2.Text = dataTable.Rows[0]["PermanentAddressR2"].ToString();

                    txtTelNoR2.Text = dataTable.Rows[0]["TelephoneNoR2"].ToString();
                    txtMobNoR2.Text = dataTable.Rows[0]["MobileNoR2"].ToString();
                    txtEAddressR2.Text = dataTable.Rows[0]["EmailR2"].ToString();



                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        

        private void GetFamilyInfoByAdmissionNo(int AdmissionNo)
        {
            try
            {
                VmStudentRegistration _objVmStudent = new VmStudentRegistration();
                Hashtable ht = new Hashtable();
                ht.Add("AdmissionNo", AdmissionNo);
                DataTable dataTable = StudentregistrationEditBLL.GetFamilyInfoByAdmissionNo(ht);
                if (dataTable.Rows.Count > 0)
                {
                    txtadmsnnum.Text = dataTable.Rows[0]["AdmissionNo"].ToString();
                    txtnamef.Text = dataTable.Rows[0]["Namefather"].ToString();

                    ddlnationalityf.ClearSelection();
                    ddlnationalityf.Text = dataTable.Rows[0]["NationalityName"].ToString();
                    ddlnationalityf.SelectedValue = dataTable.Rows[0]["Nationalityfather"].ToString();

                    ddlmaritalstatusf.ClearSelection();
                    ddlmaritalstatusf.Text = dataTable.Rows[0]["ddlmaritalstatusf"].ToString();
                    ddlmaritalstatusf.SelectedValue = dataTable.Rows[0]["MaritalStatusfather"].ToString();

                    txteduf.Text = dataTable.Rows[0]["Educationmother"].ToString();
                    txtoccf.Text = dataTable.Rows[0]["Occupationfather"].ToString();
                    txtorgf.Text = dataTable.Rows[0]["Organizationfather"].ToString();

                    txtdesignationf.Text = dataTable.Rows[0]["Designationfather"].ToString();
                    txtserviceyearfather.Text = dataTable.Rows[0]["Yearofservicefather"].ToString();

                    txtofficeaddressfather.Text = dataTable.Rows[0]["Officeaddressfather"].ToString();
                    txtofficephonef.Text = dataTable.Rows[0]["OfficeTelephonefather"].ToString();
                    txtresidentialaddfather.Text = dataTable.Rows[0]["Residentialaddressfather"].ToString();
                    txtpreaddfather.Text = dataTable.Rows[0]["Presentaddressfather"].ToString();

                    txtperaddressfather.Text = dataTable.Rows[0]["Permanentaddressfather"].ToString();
                    txttelephonefather.Text = dataTable.Rows[0]["Telephonefather"].ToString();
                    txtmobilefather.Text = dataTable.Rows[0]["Mobilefather"].ToString();
                    txtemailfather.Text = dataTable.Rows[0]["Emailfather"].ToString();

                   
                     _objVmStudent.childresidewithfather = dataTable.Rows[0]["Residencewithfather"].ToString();

                     if (_objVmStudent.childresidewithfather.Contains("YES"))
                     {
                         rbf1.Checked = true;
                     }
                    else
                     {
                         rbf2.Checked = true;
                     }

                     txtnamem.Text = dataTable.Rows[0]["Namemother"].ToString();

                    ddlnationalitym.ClearSelection();
                    ddlnationalitym.Text = dataTable.Rows[0]["NationalityName"].ToString();
                    ddlnationalitym.SelectedValue = dataTable.Rows[0]["Nationalitymother"].ToString();

                    ddlmaritalstatusm.ClearSelection();
                    ddlmaritalstatusm.Text = dataTable.Rows[0]["ddlmaritalstatusf"].ToString();
                    ddlmaritalstatusm.SelectedValue = dataTable.Rows[0]["Maritalstatusmother"].ToString();

                    txtedum.Text = dataTable.Rows[0]["Educationmother"].ToString();
                    txtoccm.Text = dataTable.Rows[0]["Occupationmother"].ToString();
                    txtorgm.Text = dataTable.Rows[0]["Organizationmother"].ToString();

                    txtdesignationm.Text = dataTable.Rows[0]["Designationmother"].ToString();
                    txtserviceyearm.Text = dataTable.Rows[0]["Yearofservicemother"].ToString();

                    txtoffaddm.Text = dataTable.Rows[0]["Officeaddressmother"].ToString();
                    txttelephonem.Text = dataTable.Rows[0]["Telephonemother"].ToString();
                    txtresidencem.Text = dataTable.Rows[0]["Residentialaddessmother"].ToString();
                    txtpreaddm.Text = dataTable.Rows[0]["Presentaddressmother"].ToString();

                    txtperaddm.Text = dataTable.Rows[0]["Permanentaddressmother"].ToString();
                    txtofftelephonem.Text = dataTable.Rows[0]["Telephonemother"].ToString();
                    txtmobilem.Text = dataTable.Rows[0]["Mobilemother"].ToString();
                    txtemailm.Text = dataTable.Rows[0]["Emailmother"].ToString();
                    _objVmStudent.childresidewithmother = dataTable.Rows[0]["Residencewithmother"].ToString();

                    if (_objVmStudent.childresidewithmother.Contains("YES"))
                    {
                        rbm3.Checked = true;
                    }
                    else
                    {
                        rbm4.Checked = true;
                    }

                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void GetGuardianDetailsByAdmissionNo(int AdmissionNo)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("AdmissionNo", AdmissionNo);
                DataTable dataTable = StudentregistrationEditBLL.GetGuardianDetailsByAdmissionNo(ht);
                if (dataTable.Rows.Count > 0)
                {


                    txtnameg.Text = dataTable.Rows[0]["Nameguardian"].ToString();

                    ddlnationalityg.ClearSelection();
                    ddlnationalityg.Text = dataTable.Rows[0]["NationalityName"].ToString();
                    ddlnationalityg.SelectedValue = dataTable.Rows[0]["NationalityGuardian"].ToString();


                    ddlrelwstu.ClearSelection();
                    ddlrelwstu.Text = dataTable.Rows[0]["RelationName"].ToString();
                    ddlrelwstu.SelectedValue = dataTable.Rows[0]["RelationwithStudent"].ToString();

                    txtResAddG.Text = dataTable.Rows[0]["Residentialaddressguardian"].ToString();
                    txtPreAddG.Text = dataTable.Rows[0]["Presentaddressguardian"].ToString();


                    txtPerAddG.Text = dataTable.Rows[0]["Permanentaddressguardian"].ToString();


                    txtTelG.Text = dataTable.Rows[0]["Telephoneguardian"].ToString();
                    txtMobileG.Text = dataTable.Rows[0]["Mobileguardian"].ToString();

                    txtEmailG.Text = dataTable.Rows[0]["Emailguardian"].ToString();





                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        private void GetTranspotationDetailsByAdmissionNo(int AdmissionNo)
        {
            try
            {
                VmStudentRegistration _objVmStudent = new VmStudentRegistration();
                Hashtable ht = new Hashtable();
                ht.Add("AdmissionNo", AdmissionNo);
                DataTable dataTable = StudentregistrationEditBLL.GetTransportationDetailsByID(ht);
                if (dataTable.Rows.Count > 0)
                {
                    txtadmsnnum.Text = dataTable.Rows[0]["AdmissionNo"].ToString();
                    _objVmStudent.personalcar = dataTable.Rows[0]["Haspersonalcar"].ToString();

                    if (_objVmStudent.personalcar.Contains("Yes"))
                    {
                        rbcar1.Checked = true;
                    }
                    else
                    {
                        rbcar2.Checked = true;
                    }

                    _objVmStudent.bus = dataTable.Rows[0]["Willusepublictransport"].ToString();

                    if (_objVmStudent.bus.Contains("Yes"))
                    {
                        rbbus1.Checked = true;
                    }
                    else
                    {
                        rbbus2.Checked = true;
                    }

                    _objVmStudent.schoolbus = dataTable.Rows[0]["Willuseschoolbus"].ToString();

                    if (_objVmStudent.schoolbus.Contains("Yes"))
                    {
                        rbsbus1.Checked = true;
                    }
                    else
                    {
                        rbsbus2.Checked = true;
                    }

                    txtcarregno.Text = dataTable.Rows[0]["Carregistrationno"].ToString();

                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void GetMedicalInformationByAdmissionNo(int AdmissionNo)
        {

            try
            {
                VmStudentRegistration _objVmStudent = new VmStudentRegistration();
                Hashtable ht = new Hashtable();
                ht.Add("AdmissionNo", AdmissionNo);
                DataTable dataTable = StudentregistrationEditBLL.GetMedicalInformationByID(ht);
                if (dataTable.Rows.Count > 0)
                {
                    txtadmsnnum.Text = dataTable.Rows[0]["AdmissionNo"].ToString();


                    _objVmStudent.Hasmedicalproblem = dataTable.Rows[0]["Hasmedicalproblem"].ToString();
                    if (_objVmStudent.Hasmedicalproblem.Contains("Yes"))
                    {
                        rbmedical1.Checked = true;
                    }
                    else
                    {
                        rbmedical2.Checked = true;
                    }


                    _objVmStudent.Onmedication = dataTable.Rows[0]["Onmedication"].ToString();
                    if (_objVmStudent.Onmedication.Contains("Yes"))
                    {
                        rbmedication1.Checked = true;
                    }
                    else
                    {
                        rbmedication2.Checked = true;
                    }

                    txtmedicaldetails.Text = dataTable.Rows[0]["MedicalSituationDetails"].ToString();

                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void GetSiblingInformationByAdmissionNo(int AdmissionNo)
        {

            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("AdmissionNo", AdmissionNo);
                DataTable dataTable = StudentregistrationEditBLL.GetSiblingInformationByAdmissionNo(ht);
                if (dataTable.Rows.Count > 0)
                {
                    txtadmsnnum.Text = dataTable.Rows[0]["AdmissionNo"].ToString();
                    txtsname1.Text = dataTable.Rows[0]["Name"].ToString();


                    ddlgenderS1.ClearSelection();
                    ddlgenderS1.Text = dataTable.Rows[0]["GenderName"].ToString();
                    ddlgenderS1.SelectedValue = dataTable.Rows[0]["Gender"].ToString();

                    txtsrelation1.Text = dataTable.Rows[0]["Relationshipwithstudent"].ToString();
                    txtsage1.Text = dataTable.Rows[0]["Age"].ToString();
                    txtsstudentID1.Text = dataTable.Rows[0]["StudentID"].ToString();
                    txtsclassroll1.Text = dataTable.Rows[0]["ClassRoll"].ToString();
                    txtscampus1.Text = dataTable.Rows[0]["Campus"].ToString();

                   // txtadmsnnum.Text = dataTable.Rows[0]["AdmissionNo"].ToString();
                    txtsname2.Text = dataTable.Rows[0]["NameS2"].ToString();


                    ddlSgender2.ClearSelection();
                    ddlSgender2.Text = dataTable.Rows[0]["GenderName"].ToString();
                    ddlSgender2.SelectedValue = dataTable.Rows[0]["GenderS2"].ToString();

                    txtsrelation2.Text = dataTable.Rows[0]["RelationshipwithstudentS2"].ToString();
                    txtsage2.Text = dataTable.Rows[0]["AgeS2"].ToString();
                    txtsstudentid2.Text = dataTable.Rows[0]["StudentIDS2"].ToString();
                    txtsclassroll2.Text = dataTable.Rows[0]["ClassRollS2"].ToString();
                    txtscampus2.Text = dataTable.Rows[0]["CampusS2"].ToString();

                    

                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        private void GetEducationalBackGroundByAdmissionNo(int AdmissionNo)
        {

            try
            {
                VmStudentRegistration _objVmStudent = new VmStudentRegistration();
                Hashtable ht = new Hashtable();
                ht.Add("AdmissionNo", AdmissionNo);
                DataTable dataTable = StudentregistrationEditBLL.GetEducationalBackGroundByAdmissionNo(ht);
                if (dataTable.Rows.Count > 0)
                {
                    txtadmsnnum.Text = dataTable.Rows[0]["AdmissionNo"].ToString();
                    txtinsname.Text = dataTable.Rows[0]["Institutename"].ToString();
                    txtprevgrade.Text = dataTable.Rows[0]["Prevgrade"].ToString();
                    txtaddschl.Text = dataTable.Rows[0]["Addressschool"].ToString();
                    txtphonescl.Text = dataTable.Rows[0]["Telephoneschool"].ToString();
                    txtemailscl.Text = dataTable.Rows[0]["Emailschool"].ToString();
                    ddldateattended.SelectedDate = (DateTime)dataTable.Rows[0]["Dateattended"];

                    _objVmStudent.attendingcurrp = dataTable.Rows[0]["Attendingcurrently"].ToString();
                    if (_objVmStudent.attendingcurrp.Contains("Yes"))
                    {
                        rbattendingc1.Checked = true;
                    }
                    else
                    {
                        rbattendingc1.Checked = true;
                    }



                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        protected void Btn_UpdateStudent(object sender, EventArgs e)
        {
            long result = 0;

            VmStudentRegistration _objVmStudent = new VmStudentRegistration();

            _objVmStudent.AdmissionNo       = Convert.ToInt32(txtadmsnnum.Text.Trim());
            _objVmStudent.sFirstName        = txtfn.Text.Trim();
            _objVmStudent.MiddleName        = txtmdln.Text.Trim();
            _objVmStudent.sLastName         = txtln.Text.Trim();
            _objVmStudent.StudentID         = txtstuid.Text.Trim();
            _objVmStudent.Batch             = ddlbatch.SelectedValue.Trim();
            _objVmStudent.sDOB              = (DateTime)DateOfBirthS.SelectedDate;
            _objVmStudent.Gender            = ddlgender.SelectedValue.Trim();
            _objVmStudent.Blood             = ddlblood.SelectedValue.Trim();
            _objVmStudent.BirthPlace        = txtbirthplace.Text.Trim();
            _objVmStudent.Nationality       = ddlnationality.SelectedValue.Trim();
            _objVmStudent.Language          = txtlang.Text.Trim();
            _objVmStudent.Religion          = txtreli.Text.Trim();
            _objVmStudent.CurrentAddress    = txtcadds.Text.Trim();
            _objVmStudent.PermanentAddress  = txtpadds.Text.Trim();
            _objVmStudent.sCity             = txtcitys.Text.Trim();
            _objVmStudent.sState            = txtstates.Text.Trim();
            _objVmStudent.sPinCode          = txtpins.Text.Trim();
            _objVmStudent.sCountry          = ddlstucountry.SelectedValue.Trim();
            _objVmStudent.PhoneNumber       = txtphones.Text.Trim();
            _objVmStudent.PhoneNumber2      = txtphone2s.Text.Trim();
            _objVmStudent.sEmail            = txtemails.Text.Trim();
            _objVmStudent.StudentCategory   = ddlstucat.SelectedValue.Trim();
            _objVmStudent.StudentPhoto      = upstuphoto.FileName;


            result = _objStudentregistrationEditBLL.Update_StudentDetails(_objVmStudent);


        }


        protected void photoupload()
        {
            string StudentImagePath = string.Empty;


            string folderPath = Server.MapPath("/img/School Management/Student Images/");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }



            if (upstuphoto.PostedFile == null)
            {
                Alert.ShowMessage("Please Upload the student image");
                return;
            }

            else
            {
                HttpPostedFile postedfile = upstuphoto.PostedFile;
                string filename = Path.GetFileName(postedfile.FileName);
                string fileExtension = Path.GetExtension(filename);
                int filesize = postedfile.ContentLength;

                if (filename != "")
                {

                    bool status = CheckImageExtension(filename, fileExtension, filesize, folderPath);
                    if (status)
                    {
                        StudentImagePath = SaveStuddentImage(filename, fileExtension, filesize, folderPath);
                    }
                    else
                    {
                        Alert.ShowMessage("only Images (.jpg , .png , .gif and .jpeg) can be uploaded");
                        return;

                    }
                }

                if (StudentImagePath == "")
                {
                    Alert.ShowMessage("Please upload the Student Image");
                }

            }



        }


        private bool CheckImageExtension(string filename, string fileExtension, int filesize, string folderPath)
        {
            bool status = false;
            string fileName = string.Empty;
            if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".jpeg" ||
                fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png")
            {
                status = true;
            }

            else
            {
                status = false;
            }

            return status;

        }

        private string SaveStuddentImage(string filename, string fileExtension, int filesize, string folderPath)
        {
            string fileName = string.Empty;
            string newName = DateTime.Now.ToString("ddMMMyyhhmmsstt-");
            fileName = newName + filename;
            upstuphoto.SaveAs(folderPath + fileName);
            return fileName;

        }





        protected void Btn_UpdateEmergencyContact(object sender, EventArgs e)
        {
            long result = 1;
            VmStudentRegistration _objVmStudent = new VmStudentRegistration();

            _objVmStudent.AdmissionNo               = Convert.ToInt32(txtadmsnnum.Text.Trim());
            _objVmStudent.NameE                     = txtNameE.Text.Trim();
            _objVmStudent.NationalityE              = ddlNationalityE.SelectedValue.Trim();
            _objVmStudent.RsWithStudent             = txtRsWithStudentE.Text.Trim();
            _objVmStudent.PresentAddressE           = txtPreAddressE.Text.Trim();
            _objVmStudent.PermanentAddressE         = txtPerAddressE.Text.Trim();
            _objVmStudent.TelephoneNoE              = txtTelNoE.Text.Trim();
            _objVmStudent.MobileNoE                 = TxtMobNoE.Text.Trim();
            _objVmStudent.EAddressE                 = txtEAddressE.Text.Trim();

            _objVmStudent.NameR1                    = txtNameR1.Text.Trim();
            _objVmStudent.NationalityR1             = ddlNationalityR1.SelectedValue.Trim();
            _objVmStudent.RsWithParentR1            = txtRsWithParentR1.Text.Trim();
            _objVmStudent.PresentAddressR1          = txtPreAddressR1.Text.Trim();
            _objVmStudent.PermanentAddressR1        = txtPerAddressR1.Text.Trim();
            _objVmStudent.TelephoneNoR1             = txtTelNoR1.Text.Trim();
            _objVmStudent.MobileNoR1                = txtMoNoR1.Text.Trim();
            _objVmStudent.EAddressR1                = txtEAddressR1.Text.Trim();

            _objVmStudent.NameR2                    = txtNameR2.Text.Trim();
            _objVmStudent.NationalityR2             = ddlNationalityR2.SelectedValue.Trim();
            _objVmStudent.RsWithParentR2            = txtRsWithParentR2.Text.Trim();
            _objVmStudent.PresentAddressR2          = txtPreAddressR2.Text.Trim();
            _objVmStudent.PermanentAddressR2        = txtPerAddressR2.Text.Trim();
            _objVmStudent.TelephoneNoR2             = txtTelNoR2.Text.Trim();
            _objVmStudent.MobileNoR2                = txtMobNoR2.Text.Trim();
            _objVmStudent.EAddressR2                = txtEAddressR2.Text.Trim();



            result = _objStudentregistrationEditBLL.Update_EmergencyContact(_objVmStudent);
        }



        protected void btn_UpdateOtherDetail(object sender, EventArgs e)
        {
            long result = 1;
            VmStudentRegistration otherdetails = new VmStudentRegistration();

            _objVmStudent.AdmissionNo = Convert.ToInt32(txtadmsnnum.Text.Trim());


            //Medical Info

            if (rbmedical1.Checked)
            {
                otherdetails.Hasmedicalproblem = "Yes";
            }
            else
            {
                otherdetails.Hasmedicalproblem = "No";
            }

            if (rbmedication1.Checked)
            {
                otherdetails.Onmedication = "Yes";
            }
            else
            {
                otherdetails.Onmedication = "No";
            }


            otherdetails.Medicaldetails = txtmedicaldetails.Text.Trim();

            //Sibling1


            otherdetails.sname1 = txtsname1.Text.Trim();
            otherdetails.sgender1 = ddlgenderS1.SelectedValue;
            otherdetails.srelationship1 = txtsrelation1.Text.Trim();
            otherdetails.sage1 = txtsage1.Text.Trim();
            otherdetails.sstudentID1 = txtsstudentID1.Text.Trim();
            otherdetails.sclassroll1 = txtsclassroll1.Text.Trim();
            otherdetails.scampus1 = txtscampus1.Text.Trim();


            //Sibling2


            otherdetails.sname2 = txtsname2.Text.Trim();
            otherdetails.sgender2 = ddlSgender2.SelectedValue;
            otherdetails.srelationship2 = txtsrelation2.Text.Trim();
            otherdetails.sage2 = txtsage2.Text.Trim();
            otherdetails.sstudentID2 = txtsstudentid2.Text.Trim();
            otherdetails.sclassroll2 = txtsclassroll2.Text.Trim();
            otherdetails.scampus2 = txtscampus2.Text.Trim();


            //Transportation
            if (rbcar1.Checked)
            {
                otherdetails.personalcar = "Yes";
            }
            else
            {
                otherdetails.personalcar = "No";
            }

            if (rbbus1.Checked)
            {
                otherdetails.bus = "Yes";
            }
            else
            {
                otherdetails.bus = "No";
            }

            if (rbsbus1.Checked)
            {
                otherdetails.schoolbus = "Yes";
            }
            else
            {
                otherdetails.schoolbus = "No";
            }

            otherdetails.carregno = txtcarregno.Text.Trim();

            result = _objStudentregistrationEditBLL.Update_OtherDetails(_objVmStudent);
        }

        protected void btn_UpdateGuardianDetails(object sender, EventArgs e)
        {
            long result = 1;
            VmStudentRegistration _objVmStudent = new VmStudentRegistration();

            _objVmStudent.AdmissionNo           = Convert.ToInt32(txtadmsnnum.Text.Trim());
            _objVmStudent.nameg                 = txtnameg.Text.Trim();
            _objVmStudent.nationalityg          = ddlnationalityg.SelectedValue.Trim();
            _objVmStudent.Relationwstug         = ddlrelwstu.SelectedValue.Trim();
            _objVmStudent.residenceaddg         = txtResAddG.Text.Trim();
            _objVmStudent.preaddg               = txtPreAddG.Text.Trim();
            _objVmStudent.peraddg               = txtPerAddG.Text.Trim();
            _objVmStudent.tnog                  = txtTelG.Text.Trim();
            _objVmStudent.mobilenog             = txtMobileG.Text.Trim();
            _objVmStudent.emailg                = txtEmailG.Text.Trim();


            _objVmStudent.Namef                 = txtnamef.Text.Trim();
            _objVmStudent.Nationalityf          = ddlnationalityf.SelectedValue.Trim();
            _objVmStudent.Maritalstatusf        = ddlmaritalstatusf.SelectedValue.Trim();
            _objVmStudent.Educationf            = txteduf.Text.Trim();
            _objVmStudent.Occupationf           = txtoccf.Text.Trim();
            _objVmStudent.Organizationf         = txtorgf.Text.Trim();
            _objVmStudent.Designationf          = txtdesignationf.Text.Trim();
            _objVmStudent.Yearofservicef        = txtserviceyearfather.Text.Trim();
            _objVmStudent.Officeaddf            = txtofficeaddressfather.Text.Trim();
            _objVmStudent.offtphonef            = txtofficephonef.Text.Trim();
            _objVmStudent.residenceaddf         = txtresidentialaddfather.Text.Trim();
            _objVmStudent.preaddf               = txtpreaddfather.Text.Trim();
            _objVmStudent.peraddf               = txtperaddressfather.Text.Trim();
            _objVmStudent.tnof                  = txttelephonefather.Text.Trim();
            _objVmStudent.mobilef               = txtmobilefather.Text.Trim();
            _objVmStudent.emailaddf             = txtemailfather.Text.Trim();

            if (rbf1.Checked)
            {
                _objVmStudent.childresidewithfather = "Yes";
            }
            else
            {
                _objVmStudent.childresidewithfather = "NO";
            }
            
            


            _objVmStudent.Namem                  = txtnamem.Text.Trim();
            _objVmStudent.Nationalitym           = ddlnationalitym.SelectedValue.Trim();
            _objVmStudent.Maritalstatusm         = ddlmaritalstatusm.SelectedValue.Trim();
            _objVmStudent.Educationm             = txtedum.Text.Trim();
            _objVmStudent.Occupationm            = txtoccm.Text.Trim();
            _objVmStudent.Organizationm          = txtorgm.Text.Trim();
            _objVmStudent.Designationm           = txtdesignationm.Text.Trim();
            _objVmStudent.Yearofservicem         = txtserviceyearm.Text.Trim();
            _objVmStudent.Officeaddm             = txtoffaddm.Text.Trim();
            _objVmStudent.offtphonem             = txttelephonem.Text.Trim();
            _objVmStudent.residenceaddm          = txtresidencem.Text.Trim();
            _objVmStudent.preaddm                = txtpreaddm.Text.Trim();
            _objVmStudent.peraddm                = txtperaddm.Text.Trim();
            _objVmStudent.tnom                   = txtofftelephonem.Text.Trim();
            _objVmStudent.mobilem                = txtmobilem.Text.Trim();
            _objVmStudent.emailaddm              = txtemailm.Text.Trim();

            if (rbm3.Checked)
            {
                _objVmStudent.childresidewithmother = "Yes";
            }
            else
            {
                _objVmStudent.childresidewithmother = "NO";
            }

            

            result = _objStudentregistrationEditBLL.Update_GuardianDetails(_objVmStudent);
        }



        protected void Btn_UpdateEducationalBackground(object sender, EventArgs e)
        {
            long result = 1;
            VmStudentRegistration _objVmStudent = new VmStudentRegistration();

            _objVmStudent.AdmissionNo       = Convert.ToInt32(txtadmsnnum.Text.Trim());
            _objVmStudent.namep             = txtinsname.Text.Trim();
            _objVmStudent.gradep            = txtprevgrade.Text.Trim();
            _objVmStudent.addschoolp        = txtaddschl.Text.Trim();
            _objVmStudent.telephonep = txtphonescl.Text.Trim();
            _objVmStudent.emailp            = txtemailscl.Text.Trim();
            _objVmStudent.attenddeddatep    = (DateTime)ddldateattended.SelectedDate;

            if (rbattendingc1.Checked)
            {
                _objVmStudent.attendingcurrp = "Yes";
            }
            else
            {
                _objVmStudent.attendingcurrp = "NO";
            }
          
            result = _objStudentregistrationEditBLL.Update_EducationalBackground(_objVmStudent);
        }



        protected void ddlnationalityf_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetNationality");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["NationalityName"];
                    item.Value = datarow["NationalityID"].ToString();
                    item.Attributes.Add("NationalityName", datarow["NationalityName"].ToString());
                    ddlnationalityf.Items.Add(item);
                    item.DataBind();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ddlmaritalstatusf_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetMaritalStatus");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["ddlmaritalstatusf"];
                    item.Value = datarow["MaritalStatusID"].ToString();
                    item.Attributes.Add("ddlmaritalstatusf", datarow["ddlmaritalstatusf"].ToString());
                    ddlmaritalstatusf.Items.Add(item);
                    item.DataBind();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ddlnationalitym_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetNationality");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["NationalityName"];
                    item.Value = datarow["NationalityID"].ToString();
                    item.Attributes.Add("NationalityName", datarow["NationalityName"].ToString());
                    ddlnationalitym.Items.Add(item);
                    item.DataBind();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ddlmaritalstatusm_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetMaritalStatus");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["ddlmaritalstatusf"];
                    item.Value = datarow["MaritalStatusID"].ToString();
                    item.Attributes.Add("ddlmaritalstatusf", datarow["ddlmaritalstatusf"].ToString());
                    ddlmaritalstatusm.Items.Add(item);
                    item.DataBind();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ddlnationalityg_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetNationality");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["NationalityName"];
                    item.Value = datarow["NationalityID"].ToString();
                    item.Attributes.Add("NationalityName", datarow["NationalityName"].ToString());
                    ddlnationalityg.Items.Add(item);
                    item.DataBind();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ddlrelwstu_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetRelation");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["RelationName"];
                    item.Value = datarow["RelationID"].ToString();
                    item.Attributes.Add("RelationName", datarow["RelationName"].ToString());
                    ddlrelwstu.Items.Add(item);
                    item.DataBind();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ddlnationality_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetNationality");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["NationalityName"];
                    item.Value = datarow["NationalityID"].ToString();
                    item.Attributes.Add("NationalityName", datarow["NationalityName"].ToString());
                    ddlnationality.Items.Add(item);
                    item.DataBind();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ddlblood_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetBloodGroup");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["BloodgroupName"];
                    item.Value = datarow["bloodGroupID"].ToString();
                    item.Attributes.Add("BloodgroupName", datarow["BloodgroupName"].ToString());
                    ddlblood.Items.Add(item);
                    item.DataBind();


                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void ddlbatch_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_BatchNames");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["BatchName"];
                    item.Value = datarow["BatchID"].ToString();
                    item.Attributes.Add("BatchName", datarow["BatchName"].ToString());
                    ddlbatch.Items.Add(item);
                    item.DataBind();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ddlstucat_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetStudentCategory");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["StudentCategoryName"];
                    item.Value = datarow["StudentCategoryID"].ToString();
                    item.Attributes.Add("StudentCategoryName", datarow["StudentCategoryName"].ToString());
                    ddlstucat.Items.Add(item);
                    item.DataBind();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void ddlstucountry_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetCountry");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["CountryName"];
                    item.Value = datarow["CountryID"].ToString();
                    item.Attributes.Add("CountryName", datarow["CountryName"].ToString());
                    ddlstucountry.Items.Add(item);
                    item.DataBind();
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ddlgender_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetGenderNames");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["GenderName"];
                    item.Value = datarow["GenderID"].ToString();
                    item.Attributes.Add("GenderName", datarow["GenderName"].ToString());
                    ddlgender.Items.Add(item);
                    item.DataBind();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }


        protected void ddlrelation_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetRelation");
                foreach (DataRow datarow in DT.Rows)
                {
                    //RadComboBoxItem item = new RadComboBoxItem();
                    //item.Text = (string) datarow["RelationName"];
                    //item.Value = datarow["RelationID"].ToString();
                    //item.Attributes.Add("RelationName", datarow["RelationName"].ToString());
                    //ddlrel.Items.Add(item);
                    //item.DataBind();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }       ///needs to be checked

        protected void ddlgurcountry_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetCountry");
                foreach (DataRow datarow in DT.Rows)
                {
                    //RadComboBoxItem item = new RadComboBoxItem();
                    //item.Text = (string) datarow["CountryName"];
                    //item.Value = datarow["CountryID"].ToString();
                    //item.Attributes.Add("CountryName", datarow["CountryName"].ToString());
                    //ddlgurcountry.Items.Add(item);
                    //item.DataBind();
                }


            }
            catch (Exception)
            {

                throw;
            }
        }


        protected void ddlnationalityEC_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable dataTable = pbUtility.GetDataByProc("SM_GetNationality");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)dataRow["NationalityName"];
                    item.Value = dataRow["NationalityID"].ToString();
                    item.Attributes.Add("NationalityName", dataRow["NationalityName"].ToString());
                    ddlNationalityE.Items.Add(item);
                    item.DataBind();

                }
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message.ToString());
            }
        }

        protected void ddlnationalityRE1_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable dataTable = pbUtility.GetDataByProc("SM_GetNationality");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)dataRow["NationalityName"];
                    item.Value = dataRow["NationalityID"].ToString();
                    item.Attributes.Add("NationalityName", dataRow["NationalityName"].ToString());
                    ddlNationalityR1.Items.Add(item);
                    item.DataBind();

                }
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message.ToString());
            }
        }

        protected void ddlnationalityRE2_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable dataTable = pbUtility.GetDataByProc("SM_GetNationality");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)dataRow["NationalityName"];
                    item.Value = dataRow["NationalityID"].ToString();
                    item.Attributes.Add("NationalityName", dataRow["NationalityName"].ToString());
                    ddlNationalityR2.Items.Add(item);
                    item.DataBind();

                }
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message.ToString());
            }
        }

        protected void ddlSgender2_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetGenderNames");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["GenderName"];
                    item.Value = datarow["GenderID"].ToString();
                    item.Attributes.Add("GenderName", datarow["GenderName"].ToString());
                    ddlSgender2.Items.Add(item);
                    item.DataBind();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void ddlSgender1_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbUtility.GetDataByProc("SM_GetGenderNames");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["GenderName"];
                    item.Value = datarow["GenderID"].ToString();
                    item.Attributes.Add("GenderName", datarow["GenderName"].ToString());
                    ddlgenderS1.Items.Add(item);
                    item.DataBind();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    }
