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
using InovexiaEBS.BusinessLogic.StudentRegistrationBLL;
using PBSConnLib;
using Telerik.Web.UI;
using System.Configuration;
using System.Data.SqlClient;

namespace InovexiaEBS.StudentRegistrationView
{
    public partial class BatchAssign : System.Web.UI.Page
    {
        private PBSDBUtility pbUtility = new PBSDBUtility();

        protected void Page_Load(object sender, EventArgs e)
        {
            alertbassign1.Visible = false;
            alertbassign2.Visible = false;
        }



        protected void ddlStudentID_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable dataTable = pbUtility.GetDataByProc("SM_GetAdmissionNo");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = dataRow["Name"].ToString();
                    item.Value = dataRow["AdmissionNo"].ToString();
                    item.Attributes.Add("Name", dataRow["Name"].ToString());
                    ddlStudentID.Items.Add(item);
                    item.DataBind();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void ddlBatch_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable dataTable = pbUtility.GetDataByProc("SM_GetBatchSession");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)dataRow["SectionName"];
                    item.Value = dataRow["BatchYearID"].ToString();
                    item.Attributes.Add("SectionName", dataRow["SectionName"].ToString());
                    ddlBatch.Items.Add(item);
                    item.DataBind();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void ddlClass_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable dataTable = pbUtility.GetDataByProc("SM_GetClass");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)dataRow["ClassName"];
                    item.Value = dataRow["ClassID"].ToString();
                    item.Attributes.Add("ClassName", dataRow["ClassName"].ToString());
                    ddlClass.Items.Add(item);
                    item.DataBind();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void btn_SavebatchAssign(object sender, EventArgs e)
        {
            
            VmStudentRegistration _objVmStudent = new VmStudentRegistration();



            _objVmStudent.Student = ddlStudentID.SelectedValue.Trim();
            _objVmStudent.Batch = ddlBatch.SelectedValue.Trim();
            _objVmStudent.Class = ddlClass.SelectedValue.Trim();

            if (rbsession1.Checked)
            {
                _objVmStudent.Session = "1";
            }
            else
            {
                _objVmStudent.Session = "2";
            }

            CheckAssignedBatch(_objVmStudent);

        }

        protected void CheckAssignedBatch(VmStudentRegistration objvm)
        {
            try
            {

                Hashtable ht = new Hashtable();

                ht.Add("AdmissionNo", objvm.Student);
                ht.Add("Batch", objvm.Batch);
                ht.Add("Class", objvm.Class);
                ht.Add("Session", objvm.Session);


                DataTable dtTable = BatchAssignBLL.CheckAssignedBatch(ht);

                if (dtTable.Rows.Count > 0)
                {

                    //string result = "This record already exists!";
                    // lblbatchcheck.Visible = true;
                    // lblbatchcheck.Text = result.ToString();
                    alertbassign1.Visible = true;
                    alertbassign2.Visible = false;

                }
                else
                {

                    SaveBatchAssign(objvm);

                }


            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private void SaveBatchAssign(VmStudentRegistration objvm)
        {
            try
            {
                long result = 1;
                objvm.Student = ddlStudentID.SelectedValue;
                objvm.Bbatch = ddlBatch.SelectedValue;
                objvm.Class =  ddlClass.SelectedValue;

                if (rbsession1.Checked)
                {
                    objvm.Session = "1";
                }
                else
                {
                    objvm.Session = "2";
                }
               

                    result =  BatchAssignBLL.SaveBatchAssign(objvm);
                    alertbassign1.Visible = false;
                    alertbassign1.Visible = true;
                   // clearfieldsBatch();
                




            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
            
        }
    }
}