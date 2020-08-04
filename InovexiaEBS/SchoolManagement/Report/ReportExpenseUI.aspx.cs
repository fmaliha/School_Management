using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SchoolManagementReport.FeesReport;

namespace InovexiaEBS.SchoolManagement.Report
{
    public partial class ReportExpenseUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UpdatePanel2.Visible = false;
        }

        protected void btnShowreport_Click(object sender, EventArgs e)
        {
            try
            {
                ReportViewer2.ReportSource = new RptExpense();

                (ReportViewer2.Report as RptExpense).StartDate =
                 DateTime.Parse(dpSDate.SelectedDate.ToString());

                (ReportViewer2.Report as RptExpense).EndDate = DateTime.Parse(dpEDate.SelectedDate.ToString());


                ReportViewer2.RefreshReport();


                //Telerik.Reporting.Report report = (Telerik.Reporting.Report)this.ReportViewer2.Report;

                //Telerik.Reporting.TextBox txtdatefrom = report.Items.Find("txtdatefrom", true)[0] as Telerik.Reporting.TextBox;
                //Telerik.Reporting.TextBox txtdateto = report.Items.Find("txtdateto", true)[0] as Telerik.Reporting.TextBox;


                //txtdatefrom.Value = dpSDate.SelectedDate.ToString();
                //txtdateto.Value = dpEDate.SelectedDate.ToString();

                UpdatePanel2.Visible = true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}