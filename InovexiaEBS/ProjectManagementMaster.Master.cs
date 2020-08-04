using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InovexiaEBS
{
    public partial class ProjectManagementMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session[SessionInfo.user_name] == null)
                {
                    Response.Redirect("~/Login.aspx");
                }


                string pinnumber = Session[SessionInfo.pin_number].ToString();
                //this.LoadSideMenu_Common(SettingsMenu, "SETTINGS", pinnumber);
                //this.LoadSideMenu_Common(ltlTextileEduHRD, "TEXTILE EDUCATION & HRD", pinnumber);
                //this.LoadSideMenu_Common(ltlYarnEnterprise, "YARN ENTERPRISE", pinnumber);
                //this.LoadSideMenu_Common(ltlFabricEnterPrise, "FABRIC ENTERPRISE", pinnumber);
                //this.LoadSideMenu_Common(ltlApparelEnterprise, "Apparel Enterprise", pinnumber);
                this.LoadSideMenu_Common(ltlProjectManagement, "PROJECT MANAGEMENT", pinnumber);


                

                lblLogin.Text = Session[SessionInfo.user_name].ToString();


                

                string path = HttpContext.Current.Request.Url.AbsolutePath;

                DataTable dtab = MenuHelper.ModuleInfoByPath(path);


                if (dtab.Rows.Count > 0)
                {
                    imgHead.ImageUrl = dtab.Rows[0]["ImageUrl"].ToString();
                    lblModuleName.Text = dtab.Rows[0]["ModuleName"].ToString();                   
                    lblModuleName1.Text = dtab.Rows[0]["ModuleName"].ToString();
                    lblPageName.Text = dtab.Rows[0]["menu_text"].ToString();
                }
                if (path == "/ProjectManagement/PM_LandingPage")
                {
                    imgHead.ImageUrl = "~/img/background/pm25.ico";
                }
                else
                {
                    imgHead.ImageUrl = "~/img/background/dashboard.ico";
                }



            }
        }



       
        public void LoadSideMenu_Common(Literal ltrl, string moduleName, string pinnumber)
        {
            string menu = string.Empty;
           

            if (pinnumber != null)
            {


                Collection<BOMenu> collection = MenuHelper.GetSideMenuCollection(0, 0, pinnumber,moduleName);

                if (collection == null)
                {
                    return;
                }

                if (collection.Count > 0)
                {
                    string colsp = "collapse";

                    menu = menu + "<ul class=" + colsp + ">";



                    foreach (BOMenu model in collection)
                    {
                       
                        string cls = "clsDashboard";
                        string menuText = model.MenuText;
                        string url = model.Url;
                        menu = menu + "<li>";
                        menu += string.Format(System.Threading.Thread.CurrentThread.CurrentCulture, "<a  class=" + cls + " href='{0}' title='{1}'>{1}</a>", ResolveUrl(url), menuText);
                        menu = menu + "</li>";
                    }
                    menu = menu + "</ul>";
                }

                ltrl.Text = menu;
                

            }

            else
            {

                Response.Redirect("~/Login.aspx");
            }

        }


      



        //private void LoadMenu_Purchase()
        //{
        //    string menu = string.Empty;


        //    string pinnumber = Session[SessionInfo.pin_number].ToString();


        //    if (pinnumber != null)
        //    {


        //        Collection<BOMenu> collection = MenuHelper.GetMenuCollection_Purchase(0, 0, pinnumber);

        //        if (collection == null)
        //        {
        //            return;
        //        }

        //        if (collection.Count > 0)
        //        {
        //            string colsp = "collapse";



        //            menu = menu + "<ul class=" + colsp + ">";
        //            foreach (BOMenu model in collection)
        //            {
        //                //string cls = model.CssClass;

        //                string cls = "clsDashboard";
        //                string menuText = model.MenuText;
        //                string url = model.Url;
        //                menu = menu + "<li>";
        //                menu += string.Format(System.Threading.Thread.CurrentThread.CurrentCulture, "<a i class=" + cls + " href='{0}' title='{1}'>{1}</a>", ResolveUrl(url), menuText);
        //                menu = menu + "</li>";
        //            }
        //            menu = menu + "</ul>";
        //        }

        //        PurchaseMenu.Text = menu;




        //    }

        //    else
        //    {

        //        Response.Redirect("~/SignIn.aspx");
        //    }
        //}


        

        //private void LoadMenu_Accounts()
        //{
        //    string menu = string.Empty;


        //    string pinnumber = Session[SessionInfo.pin_number].ToString();


        //    if (pinnumber != null)
        //    {


        //        Collection<BOMenu> collection = MenuHelper.GetMenuCollection_Accounts(0, 0, pinnumber);

        //        if (collection == null)
        //        {
        //            return;
        //        }

        //        if (collection.Count > 0)
        //        {
        //            string colsp = "collapse";



        //            menu = menu + "<ul class=" + colsp + ">";
        //            foreach (BOMenu model in collection)
        //            {
        //                //string cls = model.CssClass;

        //                string cls = "clsDashboard";
        //                string menuText = model.MenuText;
        //                string url = model.Url;
        //                menu = menu + "<li>";
        //                menu += string.Format(System.Threading.Thread.CurrentThread.CurrentCulture, "<a i class=" + cls + " href='{0}' title='{1}'>{1}</a>", ResolveUrl(url), menuText);
        //                menu = menu + "</li>";
        //            }
        //            menu = menu + "</ul>";
        //        }

        //        AccountsMenu.Text = menu;




        //    }

        //    else
        //    {

        //        Response.Redirect("~/SignIn.aspx");
        //    }
        //}

        //private void LoadMenu_Inventory()
        //{
        //    string menu = string.Empty;


        //    string pinnumber = Session[SessionInfo.pin_number].ToString();


        //    if (pinnumber != null)
        //    {


        //        Collection<BOMenu> collection = MenuHelper.GetMenuCollection_Inventory(0, 0, pinnumber);

        //        if (collection == null)
        //        {
        //            return;
        //        }

        //        if (collection.Count > 0)
        //        {
        //            string colsp = "collapse";



        //            menu = menu + "<ul class=" + colsp + ">";
        //            foreach (BOMenu model in collection)
        //            {
        //                //string cls = model.CssClass;

        //                string cls = "clsDashboard";
        //                string menuText = model.MenuText;
        //                string url = model.Url;
        //                menu = menu + "<li>";
        //                menu += string.Format(System.Threading.Thread.CurrentThread.CurrentCulture, "<a i class=" + cls + " href='{0}' title='{1}'>{1}</a>", ResolveUrl(url), menuText);
        //                menu = menu + "</li>";
        //            }
        //            menu = menu + "</ul>";
        //        }

        //        InventoryMenu.Text = menu;




        //    }

        //    else
        //    {

        //        Response.Redirect("~/SignIn.aspx");
        //    }
        //}


        



        protected void LinkButton1_Click1(object sender, EventArgs e)
        {

            Session.Remove(SessionInfo.user_name);
            Session.Remove(SessionInfo.pin_number);
            Session.Remove(SessionInfo.loginid);
            Response.Redirect("~/Login.aspx");
        }


    }
}