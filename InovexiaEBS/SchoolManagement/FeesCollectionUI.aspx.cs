using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.BusinessLogic.SchoolManagement;
using PBSConnLib;
using Telerik.Web.UI;
using Telerik.Web.UI.Calendar;

namespace InovexiaEBS.SchoolManagement
{
    public partial class FeesCollecionUI : System.Web.UI.Page
    {
        PBSDBUtility pbu = new PBSDBUtility();
        FeesCollectonBLL objbll = new FeesCollectonBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblfeedate.Visible = true;
            ddlfeedate.SelectedDate = DateTime.Today;
            ddlfeedate.MaxDate = DateTime.Today;
            ddlfeedate.MinDate = DateTime.Today.AddDays(-2);
            alertpayment2.Visible = false;
            btnuppayment.Visible = false;
            lblstudent.Visible = false;
            alertpayment1.Visible = false;
            btnaddan.Visible = false;
        }

        protected void ddlstudent_OnItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pbu.GetDataByProc("SM_GetStudentNames");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["Name"];
                    item.Value = datarow["AdmissionNo"].ToString();
                    item.Attributes.Add("Name", datarow["Name"].ToString());
                    ddlstudent.Items.Add(item);
                    item.DataBind();
                }

            }
            catch (Exception)
            {

                throw;
            }
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

        protected void ddlfeetype_OnItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {

            try
            {
                DataTable DT = pbu.GetDataByProc("SM_GetFeeType");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["HeadName"];
                    item.Value = datarow["Code"].ToString();
                    item.Attributes.Add("HeadName", datarow["HeadName"].ToString());
                    ddlfeetype.Items.Add(item);
                    item.DataBind();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //protected void ddlfeedate_selection()
        //{
        //    if (ddlfeedate.SelectedDate > DateTime.Now)
        //    {
        //        string value = "Future Dates are not allowed!";
        //        lblfeedate.Visible = true;
        //        lblfeedate.Text = value;
        //    }
        //}

        protected void SavePayment()
        {
           

        }
        protected void SavePayment(object sender, EventArgs e)
        {
            try
            {
              //  ddlfeedate_selection();
                VmStudentRegistration objvm = new VmStudentRegistration();

                long RN = 0;

                objvm.StudentAdmissionNo = ddlstudent.SelectedValue.ToString();
                objvm.PaymentDate = (DateTime)ddlfeedate.SelectedDate;

                objvm.collectionType = ddlfeetype.SelectedValue.ToString();
                objvm.PaymentType = ddlpaymode.SelectedValue;
                objvm.Amount = txtamount.Text.Trim();
                objvm.Narration = txtnarrationpayment.Text.Trim();

                RN = objbll.SavePayment(objvm);

                if (RN > 0)
                {
                    txtrefno.Text = RN.ToString();
                    alertpayment2.Visible = true;
                    btnuppayment.Visible = true;
                    btnsavePay.Visible = false;

                    ddlstudent.Enabled = false;
                    lblstudent.Visible = true;
                    btnaddan.Visible = true;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
          
        }

        protected void btnuppayment_OnClickupdatepayment(object sender, EventArgs e)
        {
            long result = 0;

            VmStudentRegistration objvm = new VmStudentRegistration();

            objvm.RefNo = txtrefno.Text.Trim();
            objvm.PaymentDate = (DateTime) ddlfeedate.SelectedDate;
            objvm.collectionType = ddlfeetype.SelectedValue;
            objvm.PaymentType = ddlpaymode.SelectedValue;
            objvm.Amount= txtamount.Text.ToString();
            objvm.Narration = txtnarrationpayment.Text.ToString();


            result = objbll.UpdatePayment(objvm);

            if (result > 0)
            {
                alertpayment1.Visible = true;
                btnaddan.Visible = true;
            }
          

        }

        protected void addanoFC(object sender, EventArgs e)
        {
           Response.Redirect("FeesCollectionUI.aspx");
        }
    }
}