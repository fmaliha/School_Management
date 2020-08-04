using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.BusinessLogic.StudentRegistrationBLL;
using PBSConnLib;
using Telerik.Web.UI;

namespace InovexiaEBS.StudentRegistrationView
{
    public partial class CreateClassUI : System.Web.UI.Page
    {
        CreateClassBLL _objCreateClassBLL = new CreateClassBLL();
        PBSDBUtility pbUtility = new PBSDBUtility();

        protected void Page_Load(object sender, EventArgs e)
        {

            int ClassID = Convert.ToInt32(Request.QueryString["ClassID"]);
            //GetClassDetailsByClassID(ClassID);
            //BtnUpdateClass.Visible = false;
            //btnaddnew.Visible = false;
            alertClass1.Visible = false;
            alertClass2.Visible = false;
        }

        protected void ddlSelectSection_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable dataTable = pbUtility.GetDataByProc("SM_GetSection");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)dataRow["SectionName"];
                    item.Value = dataRow["SectionID"].ToString();
                    item.Attributes.Add("SectionName", dataRow["SectionName"].ToString());
                    ddlSelectSection.Items.Add(item);
                    item.DataBind();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        

        protected void Btn_SaveClass(object sender, EventArgs e)
        {
            //long result = 1;
            VmStudentRegistration objClass = new VmStudentRegistration();

            objClass.NameClass = txtNameClass.Text.Trim();
            objClass.SectionID = ddlSelectSection.SelectedValue.Trim();
            objClass.RemarksClass = txtRemarksClass.Text.Trim();
            checkClass(objClass);
            //_objVmStudent.CreatedByClass = txtPresentAddressEC.Text.Trim();
            //_objVmStudent.CreateTimeClass = txtPermanentAddressEC.Text.Trim();




        }

        private void checkClass(VmStudentRegistration objClass)
        {
            try
            {

                Hashtable ht = new Hashtable();

                ht.Add("ClassName", objClass.NameClass);
                ht.Add("SectionID", objClass.SectionID);
                ht.Add("Remarks", objClass.RemarksClass);



                DataTable dtTable = CreateClassBLL.checkClassnames(ht);

                if (dtTable.Rows.Count > 0)
                {
                    alertClass1.Visible = true;
                    alertClass2.Visible = false;

                }
                else
                {

                    CreateClass(objClass);

                }

            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

        }

        private void CreateClass(VmStudentRegistration objClass)
        {

            try
            {
                long result = 0;
                objClass.NameClass = txtNameClass.Text.Trim();
                objClass.SectionID = ddlSelectSection.SelectedValue;
                objClass.RemarksClass = txtRemarksClass.Text.Trim();

                result = _objCreateClassBLL.Save_CreateClass(objClass);

                if (result > 0)
                {
                    hfClassID1.Value = result.ToString();
                    BtnUpdateClass.Visible = true;
                    btnaddnew.Visible = true;
                    BtnSaveClass.Visible = false;
                    alertClass1.Visible = false;
                    alertClass2.Visible = true;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

        }




        protected void Btn_UpdateClass(object sender, EventArgs e)
        {
            long result = 0;
            VmStudentRegistration _objVmStudent = new VmStudentRegistration();

            _objVmStudent.ClassID = hfClassID1.Value;
            _objVmStudent.NameClass = txtNameClass.Text.Trim();
            _objVmStudent.SectionID = ddlSelectSection.SelectedValue.Trim();
            _objVmStudent.RemarksClass = txtRemarksClass.Text.Trim();



            result = _objCreateClassBLL.Update_Class(_objVmStudent);

            if (result > 0)
            {
                btnaddnew.Visible = true;

            }

        }

        protected void Btn_addnew(object sender, EventArgs e)
        {
            Response.Redirect("CreateClassUI.aspx");

        }

        //private void GetClassDetailsByClassID(int ClassID)
        //{
        //    try
        //    {

        //        Hashtable ht = new Hashtable();
        //        ht.Add("ClassID", ClassID);
        //        DataTable dataTable = CreateClassBLL.GetClassDetailsByClassID(ht);
        //        if (dataTable.Rows.Count > 0)
        //        {
        //            txtNameClass.Text = dataTable.Rows[0]["ClassName"].ToString();
        //            ddlSelectSection.ClearSelection();
        //            ddlSelectSection.Text = dataTable.Rows[0]["SectionName"].ToString();
        //            ddlSelectSection.SelectedValue = dataTable.Rows[0]["SectionID"].ToString();

        //            txtRemarksClass.Text = dataTable.Rows[0]["Remarks"].ToString();

        //        }


        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message.ToString());
        //    }
        //}
    }
}