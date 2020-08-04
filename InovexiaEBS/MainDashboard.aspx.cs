using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InovexiaEBS.BusinessLogic;
using InovexiaEBS.BusinessLogic.StudentRegistrationBLL;

namespace InovexiaEBS
{
    public partial class MainDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session[SessionInfo.user_name] == null)
            {
                Response.Redirect("~/Login.aspx");
            }


            //Label lblModuleName = (Label)Master.FindControl("lblModuleName");
            //Label lblModuleName1 = (Label)Master.FindControl("lblModuleName1");
            //Label lblPageName = (Label)Master.FindControl("lblPageName");
            //lblModuleName.Text = "DASHBOARD";
            //lblModuleName1.Text = "DASHBOARD";
            //lblPageName.Text = "Dashboard";
            Session[SessionInfo.ClientIP] = "192.168.1.2";


            GetHFStudentValues();
            GetFeeSummary();
        }

        private void GetHFStudentValues()
        {
            Hashtable ht = new Hashtable();

            DataTable dt = DASHBOARDBLL.GetStudentCount(ht);

            if (dt.Rows.Count > 0)
            {

                lblTS.Text = dt.Rows[0]["TotalStudents"].ToString();
                
                lblNA.Text = dt.Rows[0]["NewAdmission"].ToString();
                lblIS.Text = dt.Rows[0]["InactiveStudents"].ToString();

            }
        }



        private void GetFeeSummary()
        {
            Hashtable ht = new Hashtable();

            DataTable dt = DASHBOARDBLL.GetFeeSummary(ht);

            if (dt.Rows.Count > 0)
            {

                lblCategory.Text = dt.Rows[0]["Fee Category"].ToString();

                //lblFee.Text = dt.Rows[0]["Fee Collected"].ToString();
//                int n = Convert.ToInt32(dt.Rows[0]["Fee Collected"].ToString());
//                lblFee.Text = n.ToString("N0");    /// for commas in money format
                
//                int m = Convert.ToInt32(dt.Rows[0]["Expense"].ToString());
//                lblExpense.Text = m.ToString("N0");

            }
        }
    }
}