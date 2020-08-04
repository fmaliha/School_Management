using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SchoolManagementReport;
using SchoolManagementReport.FeesReport;


namespace InovexiaEBS.SchoolManagement.Report
{
    public partial class ReportFeesReceived : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UpdatePanel2.Visible = false;
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                ReportViewer1.ReportSource = new RptStudentFeesReceived();
                (ReportViewer1.Report as RptStudentFeesReceived).StartDate =
                 DateTime.Parse(dpStartDate.SelectedDate.ToString());
                (ReportViewer1.Report as RptStudentFeesReceived).EndDate = DateTime.Parse(dpEndDate.SelectedDate.ToString());


                ReportViewer1.RefreshReport();


                //Telerik.Reporting.Report report = (Telerik.Reporting.Report)this.ReportViewer1.Report;

                //Telerik.Reporting.TextBox txtdatefrom = report.Items.Find("txtDateFrom", true)[0] as Telerik.Reporting.TextBox;
                //Telerik.Reporting.TextBox txtdateto = report.Items.Find("txtdatet", true)[0] as Telerik.Reporting.TextBox;


                //txtdatefrom.Value = dpStartDate.SelectedDate.ToString();
                //txtdateto.Value = dpEndDate.SelectedDate.ToString();

                UpdatePanel2.Visible = true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}