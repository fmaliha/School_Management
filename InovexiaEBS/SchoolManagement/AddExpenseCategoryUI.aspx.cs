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

namespace InovexiaEBS.StudentRegistrationView
{
    public partial class AddExpenseCategoryUI : System.Web.UI.Page
    {
        PBSDBUtility pbu = new PBSDBUtility();
        AddExpenseCategoryBLL objbll = new AddExpenseCategoryBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            alertbatch1.Visible = false;
            alertbatch2.Visible = false;
            btnaddanother.Visible = false;

        }
        

        protected void Btn_SaveExpCategory(object sender, EventArgs e)
        {
            try
            {
                
                VmStudentRegistration objvm = new VmStudentRegistration();
                objvm.ExpenseCategory = txtExpCategory.Text.ToString();
                checkExpenseCategory(objvm);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void checkExpenseCategory(VmStudentRegistration objvm)
        {
            try
            {

                Hashtable ht = new Hashtable();

                ht.Add("HeadName", objvm.ExpenseCategory);

                DataTable dtTable = AddExpenseCategoryBLL.checkExpenseCategory(ht);

                if (dtTable.Rows.Count > 0)
                {

                    //string result = "This record already exists!";
                    // lblbatchcheck.Visible = true;
                    // lblbatchcheck.Text = result.ToString();
                    alertbatch1.Visible = true;
                    alertbatch2.Visible = false;

                }
                else
                {

                    CreateExpenseCategory(objvm);

                }

            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

        }


        private void CreateExpenseCategory(VmStudentRegistration objvm)
        {

            try
            {
                long RN = 0;

                objvm.ExpenseCategory = txtExpCategory.Text.ToString();

                
                RN = objbll.SaveExpenseCategory(objvm);

                if (RN > 0)
                {
                    txtExpID.Text = RN.ToString();
                    alertbatch1.Visible = false;
                    alertbatch2.Visible = true;
                    btnaddanother.Visible = true;
                    BtnSaveExpCategory.Visible = false;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

        }

        protected void Btn_Addanother(object sender, EventArgs e)
        {
            Response.Redirect("AddExpenseCategoryUI.aspx");
        }
    }
}