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
    public partial class GuardianListUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GrdGuardianList.Visible = true;
            GetAllGuardian();
            
        }
        protected void GetAllGuardian()
        {
            try
            {
                DataTable dataTableDetails = GuardianListBLL.GetAllGuardian();
                GrdGuardianList.DataSource = dataTableDetails;
                GrdGuardianList.DataBind();
                // SetGridApearance();
            }
            catch (Exception ex)
            {

                Alert.Show(ex.Message.ToString());
            }
           
        }

        //protected void BtnSelectG(object sender, EventArgs e)
        //{
        //    int AdmissionNo = int.Parse((sender as LinkButton).CommandArgument);
        //    Response.Redirect("StudentRegistrationEdit.aspx?AdmissionNo=" + AdmissionNo);
        //}

        protected void BtnDeleteG(object sender, EventArgs e)
        {
            try
            {

                int AdmissionNo = int.Parse((sender as LinkButton).CommandArgument);
                DeleteGuardianInfo(AdmissionNo);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void DeleteGuardianInfo(int AdmissionNo)
        {
            VmStudentRegistration _objVmStudentRegistrationDelete = new VmStudentRegistration();
            _objVmStudentRegistrationDelete.AdmissionNo = AdmissionNo;
            long i = GuardianListBLL.DeleteGuardianDetails(_objVmStudentRegistrationDelete);
            if (i > 0)
            {
                GetAllGuardian();
            }
        }
    }
}