using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PBSConnLib;
using SchoolManagementReport.ExpenseReport;

using Telerik.Web.UI;

namespace InovexiaEBS.StudentRegistration.Report
{
    public partial class StudentLedgerReportUI : System.Web.UI.Page
    {
        PBSDBUtility pb = new PBSDBUtility();
        protected void Page_Load(object sender, EventArgs e)
        {
            UpdatePanel2.Visible = false;
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                ReportViewer1.ReportSource = new StudentLedgerReport();
                (ReportViewer1.Report as StudentLedgerReport).StartDate = DateTime.Parse(dpStartDate.SelectedDate.ToString());
                (ReportViewer1.Report as StudentLedgerReport).EndDate = DateTime.Parse(dpEndDate.SelectedDate.ToString());
                (ReportViewer1.Report as StudentLedgerReport).AdmissionNo = Convert.ToInt32(ddlStudentName.SelectedValue);


                ReportViewer1.RefreshReport();

                UpdatePanel2.Visible = true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        protected void ddlStudentName_OnItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
           
            try
            {
                DataTable DT = pb.GetDataByProc("SM_GetStudentNames");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = datarow["Name"].ToString();
                    item.Value = datarow["AdmissionNo"].ToString();
                    item.Attributes.Add("Name", datarow["Name"].ToString());
                    ddlStudentName.Items.Add(item);
                    item.DataBind();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        }
    }
