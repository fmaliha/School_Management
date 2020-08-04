using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BillingERP.DataAccess;

namespace InovexiaEBS
{
    public partial class InvexiaMaster : System.Web.UI.MasterPage
    {


        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["pin_number"] != null)
            
            {

                string PinNo = Session["pin_number"].ToString();     /// changed from pin to pin_number
                Literal menuLiteral = ((Literal)PageUtility.FindControlIterative(this.Master, "ContentMenuLiteral"));

                string menu = DAMenu.GetContentPageMenu(PinNo);
                ContentMenuLiteral.Text = menu;

                lblUser.Text = Session["user_name"].ToString();


            }

            else
            {
                Response.Redirect("~/Login.aspx");

            }


        }




        



        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            Session.Remove(SessionInfo.user_name);
            Session.Remove(SessionInfo.pin_number);
            Session.Remove(SessionInfo.loginid);
            Response.Redirect("~/Login.aspx");
        }


    }
}