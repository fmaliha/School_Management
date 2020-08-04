using System;
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
    public partial class ExpenseEntryUI : System.Web.UI.Page
    {
        PBSDBUtility pbu = new PBSDBUtility();
        ExpenseEntryBLL objbll = new ExpenseEntryBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblExpdate.Visible = true;
            ddlExpdate.SelectedDate = DateTime.Today;
            ddlExpdate.MaxDate = DateTime.Today;
            ddlExpdate.MinDate = DateTime.Today.AddDays(-2);
            alertexpense2.Visible = false;
            btnuppayment.Visible = false;
            alertexpense1.Visible = false;
            btnredirect.Visible = false;
            

        }

        protected void ddlpaymode_OnItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {

            try
            {
                DataTable DT = pbu.GetDataByProc("SM_GetPaymentType");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["Name"];
                    item.Value = datarow["TID"].ToString();
                    item.Attributes.Add("Name", datarow["Name"].ToString());
                    ddlpaymode.Items.Add(item);
                    item.DataBind();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ddlExptype_OnItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {

            try
            {
                DataTable DT = pbu.GetDataByProc("SM_GetExpType");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["HeadName"];
                    item.Value = datarow["ExpenseID"].ToString();
                    item.Attributes.Add("HeadName", datarow["HeadName"].ToString());
                    ddlExptype.Items.Add(item);
                    item.DataBind();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void SaveExpEntry(object sender, EventArgs e)
        {
            try
            {
                //  ddlfeedate_selection();
                VmStudentRegistration objvm = new VmStudentRegistration();

                long RN = 0;

               
                objvm.Expensedate = (DateTime)ddlExpdate.SelectedDate;

                objvm.ExpenseType = ddlExptype.SelectedValue.ToString();
                objvm.EPaymentType = ddlpaymode.SelectedValue;
                objvm.EAmount = txtamount.Text.Trim();
                objvm.ENarration = txtnarrationpayment.Text.Trim();

                RN = objbll.SaveExpense(objvm);

                if (RN > 0)
                {
                    txtrefno.Text = RN.ToString();
                    alertexpense2.Visible = true;
                    btnuppayment.Visible = true;
                    btnsaveExp.Visible = false;
                    btnredirect.Visible = true;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

        }

        protected void btnuppayment_OnClickupdatepayment(object sender, EventArgs e)
        {


            VmStudentRegistration objvm = new VmStudentRegistration();

            objvm.RefNo = txtrefno.Text.Trim();
            objvm.Expensedate = (DateTime)ddlExpdate.SelectedDate;
            objvm.ExpenseType = ddlExptype.SelectedValue;
            objvm.EPaymentType = ddlpaymode.SelectedValue;
            objvm.EAmount = txtamount.Text.ToString();
            objvm.ENarration = txtnarrationpayment.Text.ToString();


            objbll.UpdateExpense(objvm);

            /////no condition check 
            alertexpense1.Visible = true;


            //btnsaveExp.Visible = true;
            btnredirect.Visible = true;
            //ClearFields();

        }

        protected void ClearFields()
        {
            txtrefno.Text = "";
            
            ddlExptype.ClearSelection();
            ddlpaymode.ClearSelection();
            txtamount.Text = "";
            txtnarrationpayment.Text = "";
        }

        protected void btnredirect_click(object sender, EventArgs e)
        {
            Response.Redirect("ExpenseEntryUI.aspx");
        }
    }
}