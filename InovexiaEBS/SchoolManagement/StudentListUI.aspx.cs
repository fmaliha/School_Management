using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.BusinessLogic.SchoolManagement;
using InovexiaEBS.BusinessLogic.TextileEducation;
using PBSConnLib;
using Telerik.Web.UI;

namespace InovexiaEBS.SchoolManagement
{
    public partial class form : System.Web.UI.Page
    {

        private PBSDBUtility pbUtility = new PBSDBUtility();
        private StudentListBLL _objstulistbll = new StudentListBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            grdstulist.Visible = true;
            GetAllStudent();
        }

        protected void GetAllStudent()
        {
            try
            {
                DataTable dataTableDetails = StudentListBLL.GetAllStudent();
                grdstulist.DataSource = dataTableDetails;
                grdstulist.DataBind();
               // SetGridApearance();
            }
            catch (Exception ex)
            {

                Alert.Show(ex.Message.ToString());
            }
        }

        private void LoadStudentList()
        {

            try
            {
                DataTable dataTableDetails = StudentListBLL.GetAllStudent();
                grdstulist.DataSource = dataTableDetails;
                grdstulist.DataBind();
                //SetGridApearance();
            }
            catch (Exception ex)
            {

                Alert.Show(ex.Message.ToString());
            }


        }

       

        protected void FilterstuID(VmStudentRegistration objvm)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("StudentID", objvm.StudentID);

                DataTable dataTable = StudentListBLL.GetFilteredstudentlistwithStuID(ht);

                grdIDfilter.DataSource = dataTable;
                grdIDfilter.DataBind();

            }
            catch (Exception ex)
            {

                Alert.Show(ex.Message.ToString());
            }


        }

        protected void FilterStuName(VmStudentRegistration objvm)
        {
            try
            {

                Hashtable ht = new Hashtable();

                ht.Add("Name", objvm.sFirstName);
                ht.Add("Name", objvm.sLastName);
                ht.Add("Name", objvm.MiddleName);

                DataTable dataTable = StudentListBLL.GetFilteredstudentlistwithStuName(ht);


                grdNamefilter.DataSource = dataTable;
                grdNamefilter.DataBind();

            }
            catch (Exception ex)
            {

                Alert.Show(ex.Message.ToString());
            }


        }



        //protected void btnfilterapply_click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        VmStudentRegistration _objVmStudent = new VmStudentRegistration();


        //        _objVmStudent.StudentID = txtfilterID.Text.Trim();
        //        _objVmStudent.sFirstName = txtfiltername.Text.Trim();
        //        _objVmStudent.MiddleName = txtfiltername.Text.Trim();
        //        _objVmStudent.sLastName = txtfiltername.Text.Trim();
        //        _objVmStudent.Batch = ddlfilterbatch.SelectedValue.Trim();

        //        DataTable dataTable = StudentListBLL.GetFilteredstudentlistwithBatch(_objVmStudent);

        //        grdbatchfilter.DataSource = dataTable;
        //        grdbatchfilter.DataBind();
        //    }
        //    catch (Exception ex)
        //    {

        //        Alert.Show(ex.Message.ToString());

        //    }
        //    grdstulist.Visible = false;
        //    grdIDfilter.Visible = false;
        //    grdNamefilter.Visible = false;
        //    grdbatchfilter.Visible = true;

        //}

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

        //protected void btnfilterclear_click(object sender, EventArgs e)
        //{
        //    txtfilterID.Text = string.Empty;
        //    txtfiltername.Text = string.Empty;
        //    //ddlfilterbatch.ClearSelection();
        //    // ddlfilterbatch.SelectedValue = default.ToString();
        //    //  ddlfilterbatch.SelectedIndex = -1;
        //    ddlfilterbatch.DataValueField = "";
        //    grdstulist.Visible = true;
        //    grdIDfilter.Visible = false;
        //    grdNamefilter.Visible = false;
        //    grdbatchfilter.Visible = false;
        //}


        protected void btneditstudent_click(object sender, EventArgs e)
        {
            int AdmissionNo = Convert.ToInt32(((sender as LinkButton).CommandArgument));
            Response.Redirect("StudentRegistrationEditUI.aspx?AdmissionNo=" + AdmissionNo);
            
           // EditstudentDetailstotextbox(AdmissionNo);
        }

        private void EditstudentDetailstotextbox(int AdmissionNo)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("AdmissionNo", AdmissionNo);
                DataTable dataTable = StudentListBLL.GetStudentInfobyAdmissionNo(ht);
                if (dataTable.Rows.Count > 0)
                {
                    //txtadmsnnum.Text = dataTable.Rows[0]["AdmissionNo"].ToString();
                    //ddladmsndate.SelectedDate = (DateTime)dataTable.Rows[0]["AdmissioDate"];
                    //txtfn.Text = dataTable.Rows[0]["FirstName"].ToString();
                    //txtmdln.Text = dataTable.Rows[0]["MiddleName"].ToString();
                    //txtln.Text = dataTable.Rows[0]["LastName"].ToString();
                    //txtstuid.Text = dataTable.Rows[0]["StudentID"].ToString();

                    //ddlbatch.ClearSelection();
                    //ddlbatch.Text = dataTable.Rows[0]["BatchName"].ToString();
                    //ddlbatch.SelectedValue = dataTable.Rows[0]["Batch"].ToString();

                    //DateOfBirthS.SelectedDate = (DateTime)dataTable.Rows[0]["DOB"];

                    //ddlgender.ClearSelection();
                    //ddlgender.Text = dataTable.Rows[0]["GenderName"].ToString();
                    //ddlgender.SelectedValue = dataTable.Rows[0]["Gender"].ToString();

                    //ddlblood.ClearSelection();
                    //ddlblood.Text = dataTable.Rows[0]["BloodgroupName"].ToString();
                    //ddlblood.SelectedValue = dataTable.Rows[0]["Blood"].ToString();

                    //txtbirthplace.Text = dataTable.Rows[0]["BirthPlace"].ToString();

                    //ddlnationality.ClearSelection();
                    //ddlnationality.Text = dataTable.Rows[0]["NationalityName"].ToString();
                    //ddlnationality.SelectedValue = dataTable.Rows[0]["Nationality"].ToString();

                    //txtlang.Text = dataTable.Rows[0]["Language"].ToString();
                    //txtreli.Text = dataTable.Rows[0]["Religion"].ToString();

                    //ddlstucat.ClearSelection();
                    //ddlstucat.Text = dataTable.Rows[0]["StudentCategoryName"].ToString();
                    //ddlstucat.SelectedValue = dataTable.Rows[0]["StudentCategory"].ToString();

                    //txtcadds.Text = dataTable.Rows[0]["CurrentAddress"].ToString();
                    //txtpadds.Text = dataTable.Rows[0]["PermanentAddress"].ToString();
                    //txtcitys.Text = dataTable.Rows[0]["City"].ToString();
                    //txtstates.Text = dataTable.Rows[0]["State"].ToString();
                    //txtpins.Text = dataTable.Rows[0]["PinCode"].ToString();

                    //ddlstucountry.ClearSelection();
                    //ddlstucountry.Text = dataTable.Rows[0]["CountryName"].ToString();
                    //ddlstucountry.SelectedValue = dataTable.Rows[0]["Country"].ToString();

                    //txtphones.Text = dataTable.Rows[0]["PhoneNumber"].ToString();
                    //txtphone2s.Text = dataTable.Rows[0]["PhoneNumber2"].ToString();
                    //txtemails.Text = dataTable.Rows[0]["Email"].ToString();


                }
            }
            catch (Exception)
            {

                throw;
            }


        }


        protected void pagerstulistgrd(object sender, GridViewPageEventArgs e)
        {
            grdstulist.PageIndex = e.NewPageIndex;
            this.GetAllStudent();
           
        }

        protected void btndeletestudent_click(object sender, EventArgs e)
        {

            int Admissionno = Convert.ToInt32(((sender as LinkButton).CommandArgument));
            DeleteStudentInfo(Admissionno);
        }

        private void DeleteStudentInfo(int admissionno)
        {
            VmStudentRegistration _objRegistration = new VmStudentRegistration();
            _objRegistration.AdmissionNo = admissionno;

            long i = StudentListBLL.DeleteStudentInfobyAdmissionNo(_objRegistration);
            if (i > 0)
            {


                LoadStudentList();

            }
        }


        protected void BtnProfile(object sender, EventArgs e)
        {
            int AdmissionNo = int.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("StudentProfileUI.aspx?AdmissionNo=" + AdmissionNo);

        }

       

    }
}