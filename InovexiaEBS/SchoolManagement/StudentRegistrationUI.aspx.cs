using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.BusinessLogic.SchoolManagement;
using InovexiaEBS.BusinessLogic.TextileEducation;
using InovexiaEBS.DataAccess.SchoolManagement;
using Microsoft.AspNet.FriendlyUrls;
using PBSConnLib;
using Telerik.Web.UI;
using Telerik.Web.UI.Calendar;

namespace InovexiaEBS.SchoolManagement
{
    public partial class StudentRegistrationUI : System.Web.UI.Page
    {
        private PBSDBUtility pbUtility = new PBSDBUtility();
        private StudentRegisrationBLL _objStudentRegisrationBll = new StudentRegisrationBLL();
        // StudentRegistrationDLL _objStudentRegistrationDll =new StudentRegistrationDLL();
        private VmStudentRegistration _objVmStudent = new VmStudentRegistration();



        protected void Page_Load(object sender, EventArgs e)
        {
            //  if (!IsPostBack) return;
            myTabContent.Visible = true;
            // divStudentDetails.Visible = true;


            // clearfields();
            // studentlistPanelmaster.Style.Add("display","none");
            // studentlistPanelmaster.Visible = false;
            //filterbutton.Visible = false;
            //studentlistPanel.Visible = false;
            //searchlist.Visible = false;
            //grdstulist.Visible = false;
            //grdstulist.Visible = true;
            //GetAllStudent();
            //btnupguardian.Visible = false;

            //btnuppreviousdetails.Visible = false;
           
           // btnupstudoc.Enabled = false;
            //btnupadddetails.Enabled = false;
            //btnupstudetail.Visible = false;
           // btnupadddetails.Visible = false;
            btnviewprofile.Visible = false;
            btnsaveguardian.Enabled = false;
            btnsaveEmergencyContact.Enabled = false;
            btnsavepreviousdetails.Enabled = false;
            btnsavedoc.Enabled = false;
            btnsaveadditionaldetails.Enabled = false;
            alertstuD1.Visible = false;


        }






        protected void btnsavestudent_click(object sender, EventArgs e)
        {

            try
            {
                VmStudentRegistration objVmStudent = new VmStudentRegistration();


                long AdmissionNo = 0;
                //long result = 1;

                //   objVmStudent.AdmissionNo = Convert.ToInt32(txtadmsnnum.Text.Trim());
                objVmStudent.AdmissionDate = (DateTime)ddladmsndate.SelectedDate;

                // (txtadmsndate.Text.Trim());
                objVmStudent.sFirstName = txtfn.Text.Trim();
                objVmStudent.MiddleName = txtmdln.Text.Trim();
                objVmStudent.sLastName = txtln.Text.Trim();
                objVmStudent.StudentID = txtstuid.Text.Trim();
                objVmStudent.Batch = ddlbatch.SelectedValue.Trim();
                objVmStudent.sDOB = (DateTime)DateOfBirthS.SelectedDate;
                objVmStudent.Gender = ddlgender.SelectedValue.Trim();
                objVmStudent.Blood = ddlblood.SelectedValue.Trim();
                objVmStudent.BirthPlace = txtbirthplace.Text.Trim();
                objVmStudent.Nationality = ddlnationality.SelectedValue.Trim();
                objVmStudent.Language = txtlang.Text.Trim();
                objVmStudent.Religion = txtreli.Text.Trim();
                objVmStudent.CurrentAddress = txtcadds.Text.Trim();
                objVmStudent.PermanentAddress = txtpadds.Text.Trim();
                objVmStudent.sCity = txtcitys.Text.Trim();
                objVmStudent.sState = txtstates.Text.Trim();
                objVmStudent.sPinCode = txtpins.Text.Trim();
                objVmStudent.sCountry = ddlstucountry.SelectedValue.Trim();
                objVmStudent.PhoneNumber = txtphones.Text.Trim();
                objVmStudent.PhoneNumber2 = txtphone2s.Text.Trim();
                objVmStudent.sEmail = txtemails.Text.Trim();
                objVmStudent.StudentCategory = ddlstucat.SelectedValue.Trim();
                objVmStudent.StudentPhoto = photoupload();

                AdmissionNo = _objStudentRegisrationBll.SaveStuDetails(objVmStudent);

                if (AdmissionNo > 0)
                {
                    txtadmsnnum.Text = AdmissionNo.ToString();
                    btnsaveguardian.Enabled = true;
                    btnsavestu.Enabled = false;
                    //Response.Redirect("GuardianDetails", new { t = "tabGuardianDetails" });
                    alertstuD1.Visible = true;
                    
                   


                }

                //photoupload();

                //btnupstudetail.Enabled = true;
               // btnupstudetail.Visible = true;
            }

            catch (Exception)
            {

                throw;
            }


        }


        protected string photoupload()
        {
            string StudentImagePath = string.Empty;


            string folderPath = Server.MapPath("/img/Photos/");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }



            if (upstuphoto.HasFile)
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

                        //string fileName = string.Empty;
                        //string newName = DateTime.Now.ToString("ddMMMyyhhmmsstt-");
                        //fileName = newName + filename;
                        //upstuphoto.SaveAs(folderPath + fileName);
                        //return StudentImagePath = fileName;
                    }

                    else
                    {
                        lblphoto.Text = "only Images (.jpg , .png , .gif and .jpeg) can be uploaded";
                        //return null;

                    }
                }

                if (StudentImagePath == "")
                {
                    lblphoto.Text = "Please upload the Student Image";
                    //Alert.ShowMessage("Please upload the Student Image");
                }

            }

            else
            {
                //Alert.ShowMessage("Please Upload the student image");
                // return null;

                lblphoto.Text = "Please Upload the student image";
            }


            return StudentImagePath;
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



        protected void clearfields()
        {

            txtmdln.Text = "";
            txtln.Text = "";
            txtstuid.Text = string.Empty;
            ddlbatch.Text = string.Empty;
            // (DateTime)DateOfBirthS.SelectedDate;
            //ddlgender.Text.Trim();
            // ddlblood.Text.Trim();
            txtbirthplace.Text = string.Empty;
            //ddlnationality.Text = string.Empty;
            //ddlnationality.Text = string.Empty;
            txtreli.Text = string.Empty;
            txtcadds.Text = string.Empty;
            txtpadds.Text = string.Empty;
            txtcitys.Text = string.Empty;
            txtstates.Text = string.Empty;
            txtpins.Text = string.Empty;
            //txtcountrys.Text = string.Empty;
            txtphones.Text = string.Empty;
            txtphone2s.Text = string.Empty;
            txtemails.Text = string.Empty;
            // ddlstucat.Text = string.Empty;
            // upstuphoto.FileName;
        }


        //////////////////  //Guardian  Save
        /// 
        /// 
        /// 
        /// 
        /// 
        protected void btnsaveguardian_click(object sender, EventArgs e)
        {
            try
            {

                long result = 1;
                VmStudentRegistration objVmguardian = new VmStudentRegistration();

                objVmguardian.AdmissionNo = Convert.ToInt32(txtadmsnnum.Text.Trim());

                ///     //   father //////


                objVmguardian.Namef = txtnamef.Text.Trim();
                objVmguardian.Nationalityf = ddlnationalityf.SelectedValue;

                objVmguardian.Maritalstatusf = ddlmaritalstatusf.SelectedValue;
                objVmguardian.Educationf = txteduf.Text.Trim();


                objVmguardian.Occupationf = txtoccf.Text.Trim();
                objVmguardian.Organizationf = txtorgf.Text.Trim();
                objVmguardian.Designationf = txtdesignationf.Text.Trim();

                objVmguardian.Yearofservicef = txtserviceyearfather.Text.Trim();
                objVmguardian.Officeaddf = txtofficeaddressfather.Text.Trim();
                objVmguardian.offtphonef = txtofficephonef.Text.Trim();

                objVmguardian.residenceaddf = txtresidentialaddfather.Text.Trim();
                objVmguardian.preaddf = txtpreaddfather.Text.Trim();
                objVmguardian.peraddf = txtperaddressfather.Text.Trim();

                objVmguardian.tnof = txttelephonefather.Text.Trim();
                objVmguardian.mobilef = txtmobilefather.Text.Trim();
                objVmguardian.emailaddf = txtemailfather.Text.Trim();


                if (rbf1.Checked)
                {
                    objVmguardian.childresidewithfather = "YES";
                }
                else
                {
                    objVmguardian.childresidewithfather = "NO";
                }

                //          mother


                objVmguardian.Namem = txtnamem.Text.Trim();
                objVmguardian.Nationalitym = ddlnationalitym.SelectedValue;

                objVmguardian.Maritalstatusm = ddlmaritalstatusm.SelectedValue;
                objVmguardian.Educationm = txtedum.Text.Trim();


                objVmguardian.Occupationm = txtoccm.Text.Trim();
                objVmguardian.Organizationm = txtorgm.Text.Trim();
                objVmguardian.Designationm = txtdesignationm.Text.Trim();

                objVmguardian.Yearofservicem = txtserviceyearm.Text.Trim();
                objVmguardian.Officeaddm = txtoffaddm.Text.Trim();
                objVmguardian.offtphonem = txtofftelephonem.Text.Trim();

                objVmguardian.residenceaddm = txtresidencem.Text.Trim();
                objVmguardian.preaddm = txtpreaddm.Text.Trim();
                objVmguardian.peraddm = txtperaddm.Text.Trim();

                objVmguardian.tnom = txttelephonem.Text.Trim();
                objVmguardian.mobilem = txtmobilem.Text.Trim();
                objVmguardian.emailaddm = txtemailm.Text.Trim();


                if (rbm3.Checked)
                {
                    objVmguardian.childresidewithmother = "YES";
                }
                else
                {
                    objVmguardian.childresidewithmother = "NO";
                }



                //          guardian



                objVmguardian.nameg = txtnameg.Text.Trim();
                objVmguardian.nationalityg = ddlnationalityg.SelectedValue;

                objVmguardian.Relationwstug = ddlrelwstu.SelectedValue;
                objVmguardian.residenceaddg = txtResAddG.Text.Trim();


                objVmguardian.preaddg = txtPreAddG.Text.Trim();
                objVmguardian.peraddg = txtPerAddG.Text.Trim();
                objVmguardian.tnog = txtTelG.Text.Trim();

                objVmguardian.mobilenog = txtMobileG.Text.Trim();
                objVmguardian.emailg = txtEmailG.Text.Trim();



                result = _objStudentRegisrationBll.SaveGuardianDetails(objVmguardian);

                if (result > 0)
                {
                    // btnupguardian.Visible = true; 
                    btnsaveEmergencyContact.Enabled = true;
                    btnsaveguardian.Enabled = false;
                }




            }
            catch (Exception)
            {

                throw;
            }

           
        }



        protected void btnsaveEmergencyContact_OnClick(object sender, EventArgs e)
        {
            try
            {

                long result = 1;
                VmStudentRegistration objVmguardian = new VmStudentRegistration();

                objVmguardian.AdmissionNo = Convert.ToInt32(txtadmsnnum.Text.Trim());

                
                //emergency contact

                objVmguardian.NameE = txtNameE.Text.Trim();
                objVmguardian.NationalityE = ddlNationalityE.SelectedValue.Trim();

                objVmguardian.RsWithStudent = txtRsWithStudentE.Text.Trim();
                objVmguardian.PresentAddressE = txtPreAddressE.Text.Trim();


                objVmguardian.PermanentAddressE = txtPerAddressE.Text.Trim();
                objVmguardian.TelephoneNoE = txtTelNoE.Text.Trim();
                objVmguardian.MobileNoE = TxtMobNoE.Text.Trim();

                objVmguardian.EAddressE = txtEAddressE.Text.Trim();
                

                ///referee  1
                /// 
                objVmguardian.NameR1 = txtNameR1.Text.Trim();
                objVmguardian.NationalityR1 = ddlNationalityR1.SelectedValue.Trim();

                objVmguardian.RsWithParentR1 = txtRsWithParentR1.Text.Trim();
                objVmguardian.PresentAddressR1 = txtPreAddressR1.Text.Trim();
                objVmguardian.PermanentAddressR1 = txtPerAddressR1.Text.Trim();

                objVmguardian.TelephoneNoR1 = txtTelNoR1.Text.Trim();
                objVmguardian.MobileNoR1 = txtMoNoR1.Text.Trim();
                objVmguardian.EAddressR1 = txtEAddressR1.Text.Trim();


                // referee 2


                objVmguardian.NameR2 = txtNameR2.Text.Trim();
                objVmguardian.NationalityR2 = ddlNationalityR2.SelectedValue.Trim();

                objVmguardian.RsWithParentR2 = txtRsWithParentR2.Text.Trim();
                objVmguardian.PresentAddressR2 = txtPreAddressR2.Text.Trim();


                objVmguardian.PermanentAddressR2 = txtPreAddressR2.Text.Trim();
                objVmguardian.TelephoneNoR2 = txtTelNoR2.Text.Trim();
                objVmguardian.MobileNoR2 = txtMobNoR2.Text.Trim();

                objVmguardian.EAddressR2 = txtEAddressR2.Text.Trim();




                result = _objStudentRegisrationBll.SaveEmergencyContact(objVmguardian);

                if (result > 0)
                {
                    btnsavepreviousdetails.Enabled = true;
                    btnsaveEmergencyContact.Enabled = false;
                }


            }
            catch (Exception)
            {

                throw;
            }

            //btnupguardian.Enabled = true;
        }


        protected void Docupload()
        {
            string StudentDocPath = string.Empty;


            string folderPath = Server.MapPath("/img/School Management/Student Documents/");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }



            if (!upstudoc.HasFile)
            {
                Alert.ShowMessage("Please Upload the student Document");
                return;
            }

            else
            {
                HttpPostedFile postedfile = upstudoc.PostedFile;
                string filename = Path.GetFileName(postedfile.FileName);
                string fileExtension = Path.GetExtension(filename);
                int filesize = postedfile.ContentLength;

                if (filename != "")
                {

                    bool status = CheckDocumentExtension(filename, fileExtension, filesize, folderPath);
                    if (status)
                    {
                        StudentDocPath = SaveStuddentDocument(filename, fileExtension, filesize, folderPath);
                    }
                    else
                    {
                        Alert.ShowMessage("only Images (.jpg , .png , .gif and .jpeg) can be uploaded");
                        return;

                    }
                }

                if (StudentDocPath == "")
                {
                    Alert.ShowMessage("Please upload the Student Image");
                }

            }



        }



        private bool CheckDocumentExtension(string filename, string fileExtension, int filesize, string folderPath)
        {
            bool status = false;
            string fileName = string.Empty;
            if (fileExtension.ToLower() == ".doc" || fileExtension.ToLower() == ".docx" ||
                fileExtension.ToLower() == ".pdf")
            {
                status = true;
            }

            else
            {
                status = false;
            }

            return status;

        }


        private string SaveStuddentDocument(string filename, string fileExtension, int filesize, string folderPath)
        {
            string fileName = string.Empty;
            string newName = DateTime.Now.ToString("ddMMMyyhhmmsstt-");
            fileName = newName + filename;
            upstudoc.SaveAs(folderPath + fileName);
            return fileName;

        }

        protected void btnSaveStuDoc(object sender, EventArgs e)
        {
            try
            {
                VmStudentRegistration objVmStudent = new VmStudentRegistration();
                long result = 1;
                objVmStudent.AdmissionNo = Convert.ToInt32(txtadmsnnum.Text.Trim());
                objVmStudent.StudentDocument = upstudoc.FileName;

                result = StudentRegisrationBLL.UploadDocument(objVmStudent);
                if (result > 0)
                {
                    btnsaveadditionaldetails.Enabled = true;
                    btnsavedoc.Enabled = false;
                }

            }
            catch (Exception)
            {

                throw;
            }
            Docupload();
            //btnupstudoc.Enabled = true;
        }




        protected void btnsavepreviousdetails_OnClick(object sender, EventArgs e)
        {

            try
            {
                long result = 1;
                VmStudentRegistration objVmprevinstitute = new VmStudentRegistration();

                objVmprevinstitute.AdmissionNo = Convert.ToInt32(txtadmsnnum.Text.Trim());

                objVmprevinstitute.namep = txtinsname.Text.Trim();
                objVmprevinstitute.gradep = txtprevgrade.Text.Trim();

                objVmprevinstitute.addschoolp = txtaddschl.Text.Trim();
                objVmprevinstitute.telephonep = txtphonescl.Text.Trim();

                objVmprevinstitute.emailp = txtemailscl.Text.Trim();
                objVmprevinstitute.attenddeddatep = (DateTime)ddldateattended.SelectedDate;

                if (rbattendingc1.Checked)
                {
                    objVmprevinstitute.attendingcurrp = " Yes";
                }
                else
                {
                    objVmprevinstitute.attendingcurrp = " No";
                }


                result = StudentRegisrationBLL.SavePrevDetails(objVmprevinstitute);

                if (result > 0)
                {
                   // btnuppreviousdetails.Visible = true;
                    btnsavedoc.Enabled = true;
                    btnsavepreviousdetails.Enabled = false;
                }

            }

            catch (Exception)
            {

                throw;
            }

           // btnuppreviousdetails.Enabled = true;
        }

     
        protected void btnsaveadditionaldetails_OnClick(object sender, EventArgs e)
        {

            additionaldetailssave();
            //btnupadddetails.Visible = true;
           Response.Redirect("StudentProfileUI.aspx");
        }

        protected void additionaldetailssave()
        {

            try
            {
                long result = 1;
                VmStudentRegistration otherdetails = new VmStudentRegistration();

                otherdetails.AdmissionNo = Convert.ToInt32(txtadmsnnum.Text.Trim());



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
                otherdetails.sgender1 = ddlgenderS.SelectedValue;
                otherdetails.srelationship1 = txtsrelation1.Text.Trim();
                otherdetails.sage1 = txtsage1.Text.Trim();
                otherdetails.sstudentID1 = txtsstudentID1.Text.Trim();
                otherdetails.sclassroll1 = txtsclassroll1.Text.Trim();
                otherdetails.scampus1 = txtscampus1.Text.Trim();


                //Sibling2


                otherdetails.sname2 = txtsname2.Text.Trim();
                otherdetails.sgender2 = ddlSgender.SelectedValue;
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

                result = StudentRegisrationBLL.SaveAdditionalDetails(otherdetails);

            }
            catch (Exception)
            {

                throw;
            }


            //studentlistPanelmaster.Visible = true;
            MasterPanel.Visible = false;


        }

        //protected void pagerstulistgrd(object sender, GridViewPageEventArgs e)
        //{
        //    grdstulist.PageIndex = e.NewPageIndex;
        //    this.GetAllStudent();
        //}


        //                 //        Dropdowns



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

        protected void ddlnationalityE_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
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
                    ddlNationalityE.Items.Add(item);
                    item.DataBind();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ddlnationalityR1_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
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
                    ddlNationalityR1.Items.Add(item);
                    item.DataBind();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ddlnationalityR2_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
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
                    ddlNationalityR2.Items.Add(item);
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

        protected void ddlfilterbatch_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
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
                    //ddlfilterbatch.Items.Add(item);
                    item.DataBind();
                }

            }
            catch (Exception)
            {

                throw;
            }



        }

        protected void ddlgenderS_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
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
                    ddlgenderS.Items.Add(item);
                    //ddlSgender.Items.Add(item);
                    item.DataBind();
                }

            }
            catch (Exception)
            {

                throw;
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
                    //ddlgenderS.Items.Add(item);
                    ddlSgender.Items.Add(item);
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
