//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using InovexiaEBS.BusinessEntity.TextileEducation;
//using InovexiaEBS.BusinessLogic.TextileEducation;

//namespace InovexiaEBS.SchoolManagement
//{
//    public partial class test : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {

//        }
//        try
//            {
//                if (rfvInstituationName.IsValid && rfvInstitutionCode.IsValid && rfvInstitutionType.IsValid
//                && rfvInstitutionCategory.IsValid && rfvAddres.IsValid && rfvEstablishedYear.IsValid && rvfddlDivision.IsValid && rvfDistrict.IsValid &&
//                rvfddlThana.IsValid && revNoOfAcademicBuilding.IsValid && reftxtNoOfLab.IsValid && rfvEmail.IsValid && rfvEmail1.IsValid)
//                {
//                    if (IsExistInstituationName())
//                    {
//                        Alert.ShowMessage("Institution Name " + txtInstituationName.Text.Trim() + " Already Existing.");
//                        txtInstituationName.Text = string.Empty;
//                    }

//                    else if (IsExistInstitutionCode())
//                    {
//                        Alert.ShowMessage("Institution Code " + txtInstitutionCode.Text.Trim() + " Already Existing.");
//                        txtInstitutionCode.Text = string.Empty;
//                    }
//                    else
//                    {


//                        HttpPostedFile postedFile = fuInstituteLog.PostedFile;
//                        string filename = Path.GetFileName(fuInstituteLog.FileName);
//                        string fileExtension = Path.GetExtension(filename);
//                        int fileSize = postedFile.ContentLength;
//                        bool Status = true;
//                        if (filename != "")
//                        {
//                            Status = CheckImageExtenstion(filename, fileExtension, fileSize);
//                        }
//                        if (Status)
//                        {

//                            InstituteManagement _objInstituteManagement = new InstituteManagement();
//                            _objInstituteManagement.InstitutionName = txtInstituationName.Text.Trim();
//                            _objInstituteManagement.InstitutionCode = txtInstitutionCode.Text.Trim();
//                            _objInstituteManagement.InstitutionType = int.Parse(ddlInstitutionType.SelectedValue.Trim());
//                            _objInstituteManagement.InstitutionCategory = int.Parse(ddlInstitutionCategory.SelectedValue.Trim());
//                            _objInstituteManagement.Address = txtAddres.Text.Trim();
//                            _objInstituteManagement.EstablishedYear = txtEstablishedYear.Text.Trim();
//                            _objInstituteManagement.TotalArea = txtTotalArea.Text.Trim();

//                            if (txtNoOfAcademicBuilding.Text.Trim() != "")
//                            {
//                                _objInstituteManagement.NoOfAcademicBuilding = int.Parse(txtNoOfAcademicBuilding.Text.Trim());
//                            }
//                            else
//                            {
//                                _objInstituteManagement.NoOfAcademicBuilding = 0;
//                            }
//                            if (txtNoOfLab.Text.Trim() != "")
//                            {
//                                _objInstituteManagement.NoOfLab = int.Parse(txtNoOfLab.Text.Trim());
//                            }
//                            else
//                            {
//                                _objInstituteManagement.NoOfLab = 0;
//                            }

//                            _objInstituteManagement.DivisionID = int.Parse(ddlDivision.SelectedValue.Trim());
//                            _objInstituteManagement.DistrictID = int.Parse(ddlDistrict.SelectedValue.Trim());
//                            _objInstituteManagement.ThanaID = int.Parse(ddlThana.SelectedValue.Trim());
//                            _objInstituteManagement.Telephone = txtTelephone.Text.Trim();
//                            _objInstituteManagement.Fax = txtFax.Text.Trim();
//                            _objInstituteManagement.Email = txtEmail.Text.Trim();
//                            _objInstituteManagement.Latitude = txtLatitude.Text.Trim();
//                            _objInstituteManagement.Longitute = txtLongitute.Text.Trim();
//                            _objInstituteManagement.Website = txtWebSite.Text.Trim();
//                            _objInstituteManagement.SocialSiteInfo = txtSocialSiteInfo.Text.Trim();
//                            _objInstituteManagement.Remarks = txtRemark.Text.Trim();

//                            if (fuInstituteLog.FileName != "")
//                            {
//                                _objInstituteManagement.Logo = getImageName(txtInstituationName.Text.Trim());
//                            }
//                            else
//                            {
//                                _objInstituteManagement.Logo = "";
//                            }

//                            _objInstituteManagement.CreatedBy = int.Parse(Session[SessionInfo.pin_number].ToString());
//                            _objInstituteManagement.CreatedPC = Session[SessionInfo.ClientIP].ToString();

//                            if (txtTotalInvestment.Text.Trim() != "")
//                            {
//                                _objInstituteManagement.TotalInvestment = decimal.Parse(txtTotalInvestment.Text.Trim());
//                            }
//                            else
//                            {
//                                _objInstituteManagement.TotalInvestment = 0;
//                            }

//                            if (txtInitialInvestment.Text.Trim() != "")
//                            {
//                                _objInstituteManagement.InitialInvestment = decimal.Parse(txtInitialInvestment.Text.Trim());
//                            }
//                            else
//                            {
//                                _objInstituteManagement.InitialInvestment = 0;
//                            }



//                            int pin_number = int.Parse(Session[SessionInfo.pin_number].ToString());
//                            long status = 0;
//                            if (btnSave.Text == "SAVE")
//                            {


//                                if (BLUserAccess.IsEventPermission_Institution(0, pin_number, "IsCreatePermission", sPageName))
//                                {

//                                    status = BLInstituteManagement.SaveInstitute(_objInstituteManagement);

//                                    if (status > 0)
//                                    {
//                                        if (fuInstituteLog.FileName != "")
//                                        {
//                                            SaveLogo(_objInstituteManagement.Logo, _objInstituteManagement.InstitutionCode);
//                                        }

//                                        Clear();
//                                        Alert.ShowMessage("Information Saved Successfully");

//                                    }
//                                }
//                                else
//                                {
//                                    Alert.ShowMessage("You have not enough permission to access this feature.");
                                
//                                }
//                            }
//                            else
//                            {
//                                _objInstituteManagement.InstitutionID = int.Parse(hidInstitutionID.Value);

//                                if (BLUserAccess.IsEventPermission_Institution(int.Parse(hidInstitutionID.Value), pin_number, "IsEditPermission", sPageName))
//                                {

                                    
//                                    status = BLInstituteManagement.UpdateInstitute(_objInstituteManagement);
//                                    if (status > 0)
//                                    {
//                                        if (fuInstituteLog.FileName != "")
//                                        {
//                                            SaveLogo(_objInstituteManagement.Logo, _objInstituteManagement.InstitutionCode);
//                                        }

//                                        LoadInstitutionList();
//                                        ManagePanel("List");
//                                        Clear();

//                                        Alert.ShowMessage("Information Updated Successfully");

//                                    }

//                                }
//                                else
//                                {
//                                    Alert.ShowMessage("You have not enough permission to access this feature.");

//                                }




//                            }

//                        }
//                        else
//                        {
//                            Alert.ShowMessage("Only images (.jpg, .png, .gif and .bmp) can be uploaded");
//                            return;
//                        }
//                    }
//                }

//            }
//            catch (Exception ex)
//            {
                
//                 Alert.Show(ex.Message.ToString());
//            }
//    }
//}