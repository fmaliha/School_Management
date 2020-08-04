using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.BusinessLogic.StudentRegistrationBLL;
using PBSConnLib;

namespace InovexiaEBS.StudentRegistrationView
{
    public partial class SubjectManagement : System.Web.UI.Page
    {
        SubjectManagementBLL _objSubjectManagementBLL = new SubjectManagementBLL();

        PBSDBUtility pbUtility = new PBSDBUtility();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_SaveSubject(object sender, EventArgs e)
        {
            long SubjectID = 0;
            VmStudentRegistration _objVmStudent = new VmStudentRegistration();
            
            _objVmStudent.SubjectName = txtSubjectName.Text.Trim();

            SubjectID = _objSubjectManagementBLL.Save_Subject(_objVmStudent);
            if (SubjectID > 0)
            {
                txtSubjectID.Text = SubjectID.ToString();
                //GetAllStudent();
            }
        }
    }
}