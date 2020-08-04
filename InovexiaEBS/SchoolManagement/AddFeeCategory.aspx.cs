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

namespace InovexiaEBS.StudentRegistrationView
{
    public partial class AddFeeCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            alertbatch1.Visible = false;
            alertbatch2.Visible = false;

        }

        protected void Btn_SaveFeeCategory(object sender, EventArgs e)
        {
            //long result = 1;
            VmStudentRegistration objvm = new VmStudentRegistration();

            objvm.FeeCategory = txtFeeCategory.Text.Trim();
            objvm.FeeFrequency = txtFeeFrequency.Text.Trim();

            CheckFeeCategory(objvm);
            

            //result = AddFeeCategoryBLL.SaveAddFeeCategory(_objVmStudent);

            //if (result != 0 )
            //{
            //    alertfc1.Visible = true;
            //}

            
        }

        private void CheckFeeCategory(VmStudentRegistration objvm)
        {
            try
            {

                Hashtable ht = new Hashtable();

                ht.Add("HeadName", objvm.FeeCategory);
                ht.Add("FeesFrequency", objvm.FeeFrequency);

                DataTable dtTable = AddFeeCategoryBLL.CheckFeeCategory(ht);

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

                objvm.FeeCategory = txtFeeCategory.Text.ToString();
                objvm.FeeFrequency = txtFeeFrequency.Text.ToString();


                RN = AddFeeCategoryBLL.SaveAddFeeCategory(objvm);

                if (RN > 0)
                {
                    
                    alertbatch1.Visible = false;
                    alertbatch2.Visible = true;
                    

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

        }

        
    }
}