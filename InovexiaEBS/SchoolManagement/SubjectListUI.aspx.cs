using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.BusinessLogic.StudentRegistrationBLL;


namespace InovexiaEBS.StudentRegistrationView
{
    public partial class SubjectListUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllSubject();
        }

        protected void GetAllSubject()
        {
            try
            {
                DataTable dataTableDetails = SubjectListBLL.GetAllSubject();
                GrdSubjectList.DataSource = dataTableDetails;
                GrdSubjectList.DataBind();

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

                int SubjectID = int.Parse((sender as LinkButton).CommandArgument);
                DeleteStudentInfo(SubjectID);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void DeleteStudentInfo(int SubjectID)
        {
            VmStudentRegistration _objVmStudentRegistration = new VmStudentRegistration();
            _objVmStudentRegistration.SubjectID = SubjectID.ToString();
            long i = SubjectListBLL.DeleteSubject(_objVmStudentRegistration);
            if (i > 0)
            {
                GetAllSubject();
            }
        }
    }
}