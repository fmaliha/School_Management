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
using InovexiaEBS.DataAccess.SchoolManagement;
using PBSConnLib;
using Telerik.Web.UI;

namespace InovexiaEBS.StudentRegistrationView
{
    public partial class ClassList : System.Web.UI.Page
    {
        //CreateClassBLL _objCreateClassBLL = new CreateClassBLL();
        PBSDBUtility pbUtility = new PBSDBUtility();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAllClass();
                divAddSubject.Visible = false;
                ClassListGrid.Visible = true;
                grdSelectSubject.Visible = true;
            }

        }

        protected void GetAllClass()
        {
            try
            {
                DataTable dataTableDetails = ClassListBLL.GetAllClass();
                GrdClassList.DataSource = dataTableDetails;
                GrdClassList.DataBind();

            }
            catch (Exception ex)
            {

                Alert.Show(ex.Message.ToString());
            }

        }

        protected void Btn_EditClass(object sender, EventArgs e)
        {
            int ClassID = int.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("CreateClassUI.aspx?ClassID=" + ClassID);
        }

        protected void Btn_AddSubject(object sender, EventArgs e)
        {
            int ClassID = int.Parse((sender as LinkButton).CommandArgument);
            hfClassID.Value = int.Parse((sender as LinkButton).CommandArgument).ToString();
            divAddSubject.Visible = true;
            ClassListGrid.Visible = false;
            GetSubByClass(ClassID);
            GetClassByClassID(ClassID);

        }

        private void GetClassByClassID(int ClassID)
        {
            try
            {

                Hashtable ht = new Hashtable();
                ht.Add("ClassID", ClassID);
                DataTable dataTable = ClassListBLL.GetAddClassByClassID(ht);
                if (dataTable.Rows.Count > 0)
                {
                    txtClass.Text = dataTable.Rows[0]["ClassName"].ToString();


                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }



        protected void ddlSelectSubject_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable dataTable = pbUtility.GetDataByProc("SM_GetSubject");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)dataRow["SubjectName"];
                    item.Value = dataRow["SubjectID"].ToString();
                    item.Attributes.Add("SubjectName", dataRow["SubjectName"].ToString());
                    ddlSelectSubject.Items.Add(item);
                    item.DataBind();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void Btn_SaveSelectedSub(object sender, EventArgs e)
        {
            long result = 1;
            VmStudentRegistration _objVmStudent = new VmStudentRegistration();


            int ClassID = Convert.ToInt32(hfClassID.Value.ToString());
            _objVmStudent.ClassID = hfClassID.Value.ToString();
            _objVmStudent.NameClass = txtClass.Text.Trim();
            _objVmStudent.SubjectName = ddlSelectSubject.Text.Trim();

            result = ClassListBLL.SaveSelectedSub(_objVmStudent);
            GetSubByClass(ClassID);

        }

        protected void GetSubByClass(int ClassID)
        {

            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("ClassID", ClassID);
                DataTable dataTableDetails = ClassListBLL.GetSubByClass(ht);

                grdSelectSubject.DataSource = dataTableDetails;
                grdSelectSubject.DataBind();

            }
            catch (Exception ex)
            {

                Alert.Show(ex.Message.ToString());
            }

        }


        protected void Btn_DeleteSub(object sender, EventArgs e)
        {
            try
            {

                int ID = Convert.ToInt32((sender as LinkButton).CommandArgument);
                DeleteSubject(ID);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        private void DeleteSubject(int ID)
        {
            VmStudentRegistration _objVmStudentRegistrationDelete = new VmStudentRegistration();
            int ClassID = Convert.ToInt32(hfClassID.Value.ToString());
            _objVmStudentRegistrationDelete.ID = ID;
            long i = ClassListBLL.DeleteSubject(_objVmStudentRegistrationDelete);
            GetSubByClass(ClassID);

        }


    }
}