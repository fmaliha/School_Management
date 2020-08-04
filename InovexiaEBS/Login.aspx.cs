using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using PBSConnLib;
using IPLCriptography;

namespace InovexiaEBS
{
    public partial class Login : System.Web.UI.Page
    {
        MyEncryptor objMyEncryptor = new MyEncryptor();
        DataTable DTabMod = new DataTable();
        DataTable DTabMen = new DataTable();
        DataTable DTAMScreen = new DataTable();
        DataTable DTabLogin = new DataTable();
        DataTable DTabPage = new DataTable();

        int pin_num;
        TreeNode tn;
        PBSDBUtility idb = new PBSDBUtility();

        BOUserAccess boclient = new BOUserAccess();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.UserAgent.IndexOf("AppleWebKit") > 0)
            {

                Request.Browser.Adapters.Clear();

            }
        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {

            //string userName = txtLoginID.Text.Trim();
            //boclient.Login_id = txtLoginID.Text.Trim();
            //boclient.Password = "";

            //DTabLogin = BLUserAccess.ValidateUserPin(boclient);

            //if (DTabLogin.Rows.Count == 1)
            //{


            //    Response.Redirect("~/Dashboard.aspx");


            //}

            //else
            //{
            //    Label4.Text = "Invalid User Id Or Password";
            //}


            string pass = objMyEncryptor.Encrypt(txtPassword.Text.Trim());


            boclient.Login_id = txtUserName.Text.Trim();
            boclient.Password = pass;

            DTabLogin = BLUserAccess.UserId(boclient);

            if (DTabLogin.Rows.Count == 1)
            {

                pin_num = int.Parse(DTabLogin.Rows[0][0].ToString());

                Session.Add(SessionInfo.pin_number, DTabLogin.Rows[0][0].ToString());
                Session.Add(SessionInfo.user_name, DTabLogin.Rows[0][1].ToString());
                Session.Add(SessionInfo.loginid, DTabLogin.Rows[0][2].ToString());
                Session.Add(SessionInfo.UserType, DTabLogin.Rows[0][4].ToString());
                Session.Add(SessionInfo.ClientIP, GetUserIP());

                //Session.Add(SessionInfo.EmployeeID, DTabLogin.Rows[0][5].ToString());
                //Session.Add(SessionInfo.StoreID, DTabLogin.Rows[0][6].ToString());
                //Session.Add(SessionInfo.CompanyName, DTabLogin.Rows[0][7].ToString());



                Response.Redirect("~/MainDashboard.aspx");

            }
        }
        private string GetUserIP()
        {
            string ipList = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipList))
            {
                return ipList.Split(',')[0];
            }

            return Request.ServerVariables["REMOTE_ADDR"];
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {

            //string pass = txtPassWord.Text.Trim();
            string pass = objMyEncryptor.Encrypt(txtPassword.Text.Trim());


            boclient.Login_id = txtUserName.Text.Trim();
            boclient.Password = pass;

            DTabLogin = BLUserAccess.UserId(boclient);

            if (DTabLogin.Rows.Count == 1)
            {

                pin_num = int.Parse(DTabLogin.Rows[0][0].ToString());

                Session.Add(SessionInfo.pin_number, DTabLogin.Rows[0][0].ToString());
                Session.Add(SessionInfo.user_name, DTabLogin.Rows[0][1].ToString());
                Session.Add(SessionInfo.loginid, DTabLogin.Rows[0][2].ToString());
                Session.Add(SessionInfo.UserType, DTabLogin.Rows[0][4].ToString());
                //Session.Add(SessionInfo.ClientIP, GetUserIP());
                Session.Add(SessionInfo.ClientIP, "192.1.1.0");
                //Session.Add(SessionInfo.EmployeeID, DTabLogin.Rows[0][5].ToString());
                //Session.Add(SessionInfo.StoreID, DTabLogin.Rows[0][6].ToString());
                //Session.Add(SessionInfo.CompanyName, DTabLogin.Rows[0][7].ToString());



                Response.Redirect("~/MainDashboard.aspx");


            }

            else
            {
                LoginMsg.Text = "Invalid User Id Or Password";
            }

        }
    }
}