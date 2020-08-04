using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Threading;
using System.Globalization;
using InovexiaEBS;


/// <summary>
/// Summary description for BasePage
/// creator rezaul
/// for theme apply
/// </summary>
public class BasePage:System.Web.UI.Page    
{
    
        /// <summary>
        /// Use this parameter on the Page_Init event of member pages.
        /// This parameter ensures that the user is not redirected to the login page 
        /// even when the user is not logged in.
        /// </summary>
        public bool NoLogOn { get; set; }

        /// <summary>
        /// Since we save the menu on the database, this parameter is only used 
        /// when there is no associated record of this page's url or path in the menu table.
        /// Use this to override or fake the page's url or path. This forces navigation menus 
        /// on the left hand side to be displayed in regards with the specified path.
        /// </summary>
        public string OverridePath { get; set; }

        protected override void OnLoad(EventArgs e)
        {

            //string pinnumber = Context.Session["pin_number"].ToString();
            if (Context.Session["pin_number"] != null)
            {

                if (string.IsNullOrWhiteSpace(OverridePath))
                {
                    OverridePath = this.Page.Request.Url.AbsolutePath;
                }

                PageAuthentic ObjectPage = new PageAuthentic();

                string PinNo = Context.Session["pin_number"].ToString();

                string sPagePath = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
                System.IO.FileInfo oFileInfo = new System.IO.FileInfo(sPagePath);
                string sPageName = oFileInfo.Name + ".aspx";

                string PageName = Conversion.GetRelativePath(this.OverridePath) ;

                int chk = ObjectPage.PageAuthenticationCheck(PinNo, sPageName);

                if (chk == 1)
                {



                    base.OnLoad(e);


                }

                else
                {


                    Response.Redirect("~/Dashboard.aspx", true);


                }

            }

            else
            {
                Response.Redirect("~/Login.aspx");

            }
        }


        //rezaul------------------------


        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);

            //if (Session[SessionInfo.theme_name] != null)
            //{
            //    Page.Theme = Session[SessionInfo.theme_name].ToString();
            //}
            //else
            //{
            //    Session.Add(SessionInfo.theme_name, "Regular");
            //    Page.Theme = Session[SessionInfo.theme_name].ToString();
            //}
        }

        protected override void InitializeCulture()
        {
            SetCulture();


            if (!string.IsNullOrEmpty(Request["lang"]))
            {
                Session["lang"] = Request["lang"];
            }
            string lang = Convert.ToString(Session["lang"]);
            string culture = string.Empty;
            /* // In case, if you want to set vietnamese as default language, then removing this comment
            if (lang.ToLower().CompareTo("vi") == 0 || string.IsNullOrEmpty(culture))
            {
                culture = "vi-VN";
            }
             */
            if (lang.ToLower().CompareTo("en") == 0 || string.IsNullOrEmpty(culture))
            {
                culture = "en-US";
            }
            if (lang.ToLower().CompareTo("vi") == 0 )
            {
                culture = "vi-VN";
            }
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);




            base.InitializeCulture();
        }

        protected override void OnInit(EventArgs e)
        {
            ////if (!IsPostBack)
            ////{
            ////    if (Request.IsAuthenticated)
            ////    {
            ////        if (Context.Session == null)
            ////        {
            ////            SetSession();
            ////        }
            ////        else
            ////        {
            ////            if (Context.Session["UserId"] == null)
            ////            {
            ////                SetSession();
            ////            }
            ////        }
            ////    }
            ////    else
            ////    {
            ////        if (!this.NoLogOn)
            ////        {
            ////            RequestLogOnPage();
            ////        }
            ////    }
            //}

            base.OnInit(e);
        }

        private static void SetCulture()
        {
            //if (HttpContext.Current.Session["Culture"] == null)
            //{
            //    return;
            //}

            //string cultureName = HttpContext.Current.Session["Culture"].ToString();
            //System.Globalization.CultureInfo culture = new CultureInfo(cultureName);
            //Thread.CurrentThread.CurrentCulture = culture;
            //Thread.CurrentThread.CurrentUICulture = culture;



          
         



        }


        private void SetSession()
        {
            //MixERP.Net.BusinessLayer.Security.User.SetSession(this.Page, User.Identity.Name);
        }

        public static void RequestLogOnPage()
        {
            FormsAuthentication.SignOut();

            foreach (var cookie in HttpContext.Current.Request.Cookies.AllKeys)
            {
                HttpContext.Current.Request.Cookies.Remove(cookie);
            }

            string currentPage = HttpContext.Current.Request.Url.AbsolutePath;
            string loginUrl = (HttpContext.Current.Handler as Page).ResolveUrl(FormsAuthentication.LoginUrl);

            if (currentPage != loginUrl)
            {
                FormsAuthentication.RedirectToLoginPage(currentPage);
            }
        }
    }

