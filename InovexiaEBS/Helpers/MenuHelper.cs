using System.Collections;
using PBSConnLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace InovexiaEBS
{
    public static class MenuHelper
    {


        public static string GetContentPageMenu(System.Web.UI.Control page, string path, string pinnumber)
        {
            if (page != null)
            {
                string menu = string.Empty;
                string relativePath = Conversion.GetRelativePath(path);
                // Collection<BOMenu> rootMenus = GetRootMenuCollection(relativePath);

                Collection<BOMenu> rootMenus = GetMenuCollection(relativePath, 1, pinnumber);

                if (rootMenus == null)
                {
                    return string.Empty;
                }

                if (rootMenus.Count > 0)
                {
                    int i = 1;

                    string ss = "<div id='cssmenu'><ul><li><a href='#'><span>You are In: " + rootMenus[0].MenuName + "</span></a></li>";
                    foreach (BOMenu rootMenu in rootMenus)
                    {



                        string AccPane = "<li><a href='#'><span> " + rootMenu.MenuText + "</span></a>";

                        menu += string.Format(System.Threading.Thread.CurrentThread.CurrentCulture, AccPane);

                        // menu += string.Format(System.Threading.Thread.CurrentThread.CurrentCulture, "<div class='sub-menu'><div class='menu-title'>{0}</div>", rootMenu.MenuText);


                        Collection<BOMenu> childMenus = GetMenuCollection(rootMenu.MenuId, 2, pinnumber);

                        if (childMenus.Count > 0)
                        {
                            menu += "<ul>";

                            foreach (BOMenu childMenu in childMenus)
                            {
                                menu += string.Format(System.Threading.Thread.CurrentThread.CurrentCulture, "<li><a href=" + page.ResolveUrl(childMenu.Url) + ">" + childMenu.MenuText + "</a></li>");
                                // menu += string.Format(System.Threading.Thread.CurrentThread.CurrentCulture, "<a href='{0}' title='{1}' data-menucode='{2}' class='sub-menu-anchor'>{1}</a>", page.ResolveUrl(childMenu.Url), childMenu.MenuText, childMenu.MenuCode);
                            }

                            menu += "</ul>";
                        }

                        menu += "</li>";
                        i = i + 1;
                    }

                    menu = ss + menu;
                }

                string FinalMenuString = menu + "</ul></div>";

                return FinalMenuString;
            }

            return null;
        }
        /// <summary>
        /// Need IF anothermenu page
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pinnumber"></param>
        /// <returns></returns>
        public static string GetPageMenu(System.Web.UI.Page page, string pinnumber)
        {
            if (page != null)
            {


                string menu = string.Empty;

                Collection<BOMenu> menuCollection = GetMenuCollection(page.Request.Url.AbsolutePath, 1, pinnumber);

                if (menuCollection.Count > 0)
                {
                    foreach (BOMenu model in menuCollection)
                    {
                        // menu += string.Format(System.Threading.Thread.CurrentThread.CurrentCulture, "<div class='menu-panel'><div class='menu-header'>{0}</div><div class='menu_lst_scroll'><ul>", model.MenuText);

                        string ss = "<div class='menu-panel'><div class='menu-header'><li class='block'>" +
        "<input type='checkbox' name='item' id='item1' />" +
        "<label for='item1'><i aria-hidden='true' class='icon-users'></i> " + model.MenuText + " <span>124</span></label><ul class='options'>";

                        menu += string.Format(System.Threading.Thread.CurrentThread.CurrentCulture, ss);





                        Collection<BOMenu> childMenus = GetMenuCollection(model.MenuId, 2, pinnumber);

                        if (childMenus.Count > 0)
                        {
                            foreach (BOMenu childMenu in childMenus)
                            {
                                string cls = "block";


                                menu += string.Format(System.Threading.Thread.CurrentThread.CurrentCulture, "<li><a href='{0}' title='{1}'>{1}<i aria-hidden='true' class='icon-search'></i>" + childMenu.MenuText + "</a></li>", page.ResolveUrl(childMenu.Url), childMenu.MenuText);
                            }
                        }

                        menu += "</ul></li></div></div>";
                    }
                }

                menu += "<div style='clear:both;'></div>";
                return menu;
            }

            return null;
        }







        ///Menu
        ///
        public static Collection<BOMenu> GetMenuCollection(string path, short level, string pinnumber)
        {
            try
            {
                var collection = new Collection<BOMenu>();

                var idb = new PBSDBUtility();

                string relativePath = Conversion.GetRelativePath(path);


                var ht = new Hashtable();
                ht.Add("pin_number", pinnumber);
                ht.Add("URL", path);

                DataTable table = idb.GetDataByProc(ht, "Menu_getByUrl");


                foreach (DataRow row in table.Rows)
                {
                    var model = new BOMenu();

                    model.MenuId = Conversion.TryCastInteger(row["menu_id"]);
                    model.MenuText = Conversion.TryCastString(row["menu_text"]);
                    model.Url = Conversion.ResolveUrl(Conversion.TryCastString(row["url"]));
                    model.MenuCode = Conversion.TryCastString(row["menu_code"]);
                    model.Level = Conversion.TryCastInteger(row["level"]);
                    model.ParentMenuId = Conversion.TryCastInteger(row["parent_menu_id"]);
                    model.CssClass = Conversion.TryCastString(row["CssClass"]);
                    model.MenuName = Conversion.TryCastString(row["ParentMenuText"]);

                    collection.Add(model);
                }
                // }
                return collection;
            }
            catch (Exception)
            {

                return null;
            }


        }

        public static Collection<BOMenu> GetRootMenuCollection(string path)
        {
            Collection<BOMenu> collection = new Collection<BOMenu>();

            PBSDBUtility idb = new PBSDBUtility();
            string relativePath = Conversion.GetRelativePath(path);

            int rootparentmenuid = int.Parse(idb.AggRetrive("select  parent_menu_id from menus WHERE url='" + path + "'").ToString());

            int parent_menu_id = int.Parse(idb.AggRetrive("select parent_menu_id from menus where menu_id=" + rootparentmenuid + "").ToString());




            using (DataTable table = idb.GetDataBySQLString("SELECT * FROM  menus WHERE parent_menu_id=" + parent_menu_id + "  ORDER BY menu_id"))
            {
                if (table == null)
                {
                    return null;
                }

                foreach (DataRow row in table.Rows)
                {
                    BOMenu model = new BOMenu();

                    model.MenuId = Conversion.TryCastInteger(row["menu_id"]);
                    model.MenuText = Conversion.TryCastString(row["menu_text"]);
                    model.Url = Conversion.ResolveUrl(Conversion.TryCastString(row["url"]));
                    model.MenuCode = Conversion.TryCastString(row["menu_code"]);
                    model.Level = Conversion.TryCastInteger(row["level"]);
                    model.ParentMenuId = Conversion.TryCastInteger(row["parent_menu_id"]);

                    collection.Add(model);
                }
            }

            return collection;
        }
        /// <summary>
        /// Menu collection by parent menuid, level, pin
        /// </summary>
        /// <param name="parentMenuId"></param>
        /// <param name="level"></param>
        /// <param name="pinnumber"></param>
        /// <returns></returns>

        public static Collection<BOMenu> GetMenuCollection(int parentMenuId, short level, string pinnumber)
        {
            Collection<BOMenu> collection = new Collection<BOMenu>();


            PBSDBUtility idb = new PBSDBUtility();



            if (parentMenuId > 0)
            {

                string mqrylevel2 = @"SELECT     dbo.AppsPermission.menu_id, dbo.menus.menu_text, dbo.menus.url, dbo.menus.menu_code, dbo.menus.[level], 
                                     dbo.menus.parent_menu_id,dbo.AppsPermission.pin_number
                                    ,CssClass FROM   dbo.AppsPermission INNER JOIN  dbo.menus ON 
                                     dbo.AppsPermission.menu_id = dbo.menus.menu_id  where
                                    menus.parent_menu_id='" + parentMenuId + "' and menus.level=" + level + " and   dbo.AppsPermission.pin_number='" + pinnumber + "' order by menus.MenuOrder ASC ";

                using (DataTable table = idb.GetDataBySQLString(mqrylevel2))
                {
                    if (table == null)
                    {
                        return null;
                    }

                    foreach (DataRow row in table.Rows)
                    {
                        BOMenu model = new BOMenu();

                        model.MenuId = Conversion.TryCastInteger(row["menu_id"]);
                        model.MenuText = Conversion.TryCastString(row["menu_text"]);
                        model.Url = Conversion.ResolveUrl(Conversion.TryCastString(row["url"]));
                        model.MenuCode = Conversion.TryCastString(row["menu_code"]);
                        model.Level = Conversion.TryCastInteger(row["level"]);
                        model.ParentMenuId = Conversion.TryCastInteger(row["parent_menu_id"]);
                        model.CssClass = Conversion.TryCastString(row["CssClass"]);

                        collection.Add(model);
                    }
                }




            }

            else
            {

                string mnqry = @"SELECT        dbo.menus.menu_id, dbo.menus.menu_text, dbo.menus.MenuOrder, dbo.menus.url, dbo.menus.menu_code, dbo.menus.[level], dbo.menus.parent_menu_id, dbo.menus.audit_user_id, dbo.menus.audit_ts, 
                         dbo.menus.LastEditDate, dbo.menus.CreationDate, dbo.menus.ModuleName, dbo.menus.CssClass, dbo.menus.FormName
FROM            dbo.menus INNER JOIN
                         dbo.AppsPermission ON dbo.menus.menu_id = dbo.AppsPermission.menu_id
						 where menus.ModuleName='TEXTILE EDUCATION & HRD' order by dbo.menus.MenuOrder asc";

                using (DataTable table = idb.GetDataBySQLString(mnqry))
                {
                    if (table == null)
                    {
                        return null;
                    }

                    foreach (DataRow row in table.Rows)
                    {
                        BOMenu model = new BOMenu();

                        model.MenuId = Conversion.TryCastInteger(row["menu_id"]);
                        model.MenuText = Conversion.TryCastString(row["menu_text"]);
                        model.Url = Conversion.ResolveUrl(Conversion.TryCastString(row["url"]));
                        model.MenuCode = Conversion.TryCastString(row["menu_code"]);
                        model.Level = Conversion.TryCastInteger(row["level"]);
                        model.ParentMenuId = Conversion.TryCastInteger(row["parent_menu_id"]);
                        model.CssClass = Conversion.TryCastString(row["CssClass"]);

                        collection.Add(model);
                    }
                }
            }



            return collection;
        }


        public static Collection<BOMenu> GetMenuCollection_Purchase(int parentMenuId, short level, string pinnumber)
        {
            Collection<BOMenu> collection = new Collection<BOMenu>();


            PBSDBUtility idb = new PBSDBUtility();


            string mnqry = @"SELECT        dbo.menus.menu_id, dbo.menus.menu_text, dbo.menus.MenuOrder, dbo.menus.url, dbo.menus.menu_code, dbo.menus.[level], dbo.menus.parent_menu_id, dbo.menus.audit_user_id, dbo.menus.audit_ts, 
                         dbo.menus.LastEditDate, dbo.menus.CreationDate, dbo.menus.ModuleName, dbo.menus.CssClass, dbo.menus.FormName
FROM            dbo.menus INNER JOIN
                         dbo.AppsPermission ON dbo.menus.menu_id = dbo.AppsPermission.menu_id
						 where menus.ModuleName='PURCHASE' order by dbo.menus.MenuOrder asc";

            using (DataTable table = idb.GetDataBySQLString(mnqry))
            {
                if (table == null)
                {
                    return null;
                }

                foreach (DataRow row in table.Rows)
                {
                    BOMenu model = new BOMenu();

                    model.MenuId = Conversion.TryCastInteger(row["menu_id"]);
                    model.MenuText = Conversion.TryCastString(row["menu_text"]);
                    model.Url = Conversion.ResolveUrl(Conversion.TryCastString(row["url"]));
                    model.MenuCode = Conversion.TryCastString(row["menu_code"]);
                    model.Level = Conversion.TryCastInteger(row["level"]);
                    model.ParentMenuId = Conversion.TryCastInteger(row["parent_menu_id"]);
                    model.CssClass = Conversion.TryCastString(row["CssClass"]);

                    collection.Add(model);
                }
            }




            return collection;
        }


        public static Collection<BOMenu> GetMenuCollection_Yarn(int parentMenuId, short level, string pinnumber)
        {
            Collection<BOMenu> collection = new Collection<BOMenu>();


            PBSDBUtility idb = new PBSDBUtility();


            string mnqry = @"SELECT        dbo.menus.menu_id, dbo.menus.menu_text, dbo.menus.MenuOrder, dbo.menus.url, dbo.menus.menu_code, dbo.menus.[level], dbo.menus.parent_menu_id, dbo.menus.audit_user_id, dbo.menus.audit_ts, 
                         dbo.menus.LastEditDate, dbo.menus.CreationDate, dbo.menus.ModuleName, dbo.menus.CssClass, dbo.menus.FormName
FROM            dbo.menus INNER JOIN
                         dbo.AppsPermission ON dbo.menus.menu_id = dbo.AppsPermission.menu_id
						 where menus.ModuleName='YARN ENTERPRISE' order by dbo.menus.MenuOrder asc";

            using (DataTable table = idb.GetDataBySQLString(mnqry))
            {
                if (table == null)
                {
                    return null;
                }

                foreach (DataRow row in table.Rows)
                {
                    BOMenu model = new BOMenu();

                    model.MenuId = Conversion.TryCastInteger(row["menu_id"]);
                    model.MenuText = Conversion.TryCastString(row["menu_text"]);
                    model.Url = Conversion.ResolveUrl(Conversion.TryCastString(row["url"]));
                    model.MenuCode = Conversion.TryCastString(row["menu_code"]);
                    model.Level = Conversion.TryCastInteger(row["level"]);
                    model.ParentMenuId = Conversion.TryCastInteger(row["parent_menu_id"]);
                    model.CssClass = Conversion.TryCastString(row["CssClass"]);

                    collection.Add(model);
                }
            }




            return collection;
        }


        public static Collection<BOMenu> GetMenuCollection_Inventory(int parentMenuId, short level, string pinnumber)
        {
            Collection<BOMenu> collection = new Collection<BOMenu>();


            PBSDBUtility idb = new PBSDBUtility();


            string mnqry = @"SELECT        dbo.menus.menu_id, dbo.menus.menu_text, dbo.menus.MenuOrder, dbo.menus.url, dbo.menus.menu_code, dbo.menus.[level], dbo.menus.parent_menu_id, dbo.menus.audit_user_id, dbo.menus.audit_ts, 
                         dbo.menus.LastEditDate, dbo.menus.CreationDate, dbo.menus.ModuleName, dbo.menus.CssClass, dbo.menus.FormName
FROM            dbo.menus INNER JOIN
                         dbo.AppsPermission ON dbo.menus.menu_id = dbo.AppsPermission.menu_id
						 where menus.ModuleName='INV' order by dbo.menus.MenuOrder asc";

            using (DataTable table = idb.GetDataBySQLString(mnqry))
            {
                if (table == null)
                {
                    return null;
                }

                foreach (DataRow row in table.Rows)
                {
                    BOMenu model = new BOMenu();

                    model.MenuId = Conversion.TryCastInteger(row["menu_id"]);
                    model.MenuText = Conversion.TryCastString(row["menu_text"]);
                    model.Url = Conversion.ResolveUrl(Conversion.TryCastString(row["url"]));
                    model.MenuCode = Conversion.TryCastString(row["menu_code"]);
                    model.Level = Conversion.TryCastInteger(row["level"]);
                    model.ParentMenuId = Conversion.TryCastInteger(row["parent_menu_id"]);
                    model.CssClass = Conversion.TryCastString(row["CssClass"]);

                    collection.Add(model);
                }
            }




            return collection;
        }


        public static Collection<BOMenu> GetMenuCollection_Accounts(int parentMenuId, short level, string pinnumber)
        {
            Collection<BOMenu> collection = new Collection<BOMenu>();


            PBSDBUtility idb = new PBSDBUtility();


            string mnqry = @"SELECT        dbo.menus.menu_id, dbo.menus.menu_text, dbo.menus.MenuOrder, dbo.menus.url, dbo.menus.menu_code, dbo.menus.[level], dbo.menus.parent_menu_id, dbo.menus.audit_user_id, dbo.menus.audit_ts, 
                         dbo.menus.LastEditDate, dbo.menus.CreationDate, dbo.menus.ModuleName, dbo.menus.CssClass, dbo.menus.FormName
FROM            dbo.menus INNER JOIN
                         dbo.AppsPermission ON dbo.menus.menu_id = dbo.AppsPermission.menu_id
						 where menus.ModuleName='ACCOUNTS' order by dbo.menus.MenuOrder asc";

            using (DataTable table = idb.GetDataBySQLString(mnqry))
            {
                if (table == null)
                {
                    return null;
                }

                foreach (DataRow row in table.Rows)
                {
                    BOMenu model = new BOMenu();

                    model.MenuId = Conversion.TryCastInteger(row["menu_id"]);
                    model.MenuText = Conversion.TryCastString(row["menu_text"]);
                    model.Url = Conversion.ResolveUrl(Conversion.TryCastString(row["url"]));
                    model.MenuCode = Conversion.TryCastString(row["menu_code"]);
                    model.Level = Conversion.TryCastInteger(row["level"]);
                    model.ParentMenuId = Conversion.TryCastInteger(row["parent_menu_id"]);
                    model.CssClass = Conversion.TryCastString(row["CssClass"]);

                    collection.Add(model);
                }
            }




            return collection;
        }



        public static Collection<BOMenu> GetMenuCollection_Reports(int parentMenuId, short level, string pinnumber)
        {
            Collection<BOMenu> collection = new Collection<BOMenu>();


            PBSDBUtility idb = new PBSDBUtility();



            using (DataTable table = idb.GetDataBySQLString("SELECT  * FROM  menus WHERE ModuleName='RPT' order by  MenuOrder ASC"))
            {
                if (table == null)
                {
                    return null;
                }

                foreach (DataRow row in table.Rows)
                {
                    BOMenu model = new BOMenu();

                    model.MenuId = Conversion.TryCastInteger(row["menu_id"]);
                    model.MenuText = Conversion.TryCastString(row["menu_text"]);
                    model.Url = Conversion.ResolveUrl(Conversion.TryCastString(row["url"]));
                    model.MenuCode = Conversion.TryCastString(row["menu_code"]);
                    model.Level = Conversion.TryCastInteger(row["level"]);
                    model.ParentMenuId = Conversion.TryCastInteger(row["parent_menu_id"]);
                    model.CssClass = Conversion.TryCastString(row["CssClass"]);

                    collection.Add(model);
                }
            }




            return collection;
        }

        public static Collection<BOMenu> GetMenuCollection_SMS(int parentMenuId, short level, string pinnumber)
        {
            Collection<BOMenu> collection = new Collection<BOMenu>();


            PBSDBUtility idb = new PBSDBUtility();



            using (DataTable table = idb.GetDataBySQLString("SELECT  * FROM  menus WHERE ModuleName='SMS' order by  MenuOrder ASC"))
            {
                if (table == null)
                {
                    return null;
                }

                foreach (DataRow row in table.Rows)
                {
                    BOMenu model = new BOMenu();

                    model.MenuId = Conversion.TryCastInteger(row["menu_id"]);
                    model.MenuText = Conversion.TryCastString(row["menu_text"]);
                    model.Url = Conversion.ResolveUrl(Conversion.TryCastString(row["url"]));
                    model.MenuCode = Conversion.TryCastString(row["menu_code"]);
                    model.Level = Conversion.TryCastInteger(row["level"]);
                    model.ParentMenuId = Conversion.TryCastInteger(row["parent_menu_id"]);
                    model.CssClass = Conversion.TryCastString(row["CssClass"]);

                    collection.Add(model);
                }
            }




            return collection;
        }


        public static Collection<BOMenu> GetMenuCollection_Collection(int parentMenuId, short level, string pinnumber)
        {
            Collection<BOMenu> collection = new Collection<BOMenu>();


            PBSDBUtility idb = new PBSDBUtility();



            using (DataTable table = idb.GetDataBySQLString("SELECT  * FROM  menus WHERE ModuleName='COLL' order by  MenuOrder ASC"))
            {
                if (table == null)
                {
                    return null;
                }

                foreach (DataRow row in table.Rows)
                {
                    BOMenu model = new BOMenu();

                    model.MenuId = Conversion.TryCastInteger(row["menu_id"]);
                    model.MenuText = Conversion.TryCastString(row["menu_text"]);
                    model.Url = Conversion.ResolveUrl(Conversion.TryCastString(row["url"]));
                    model.MenuCode = Conversion.TryCastString(row["menu_code"]);
                    model.Level = Conversion.TryCastInteger(row["level"]);
                    model.ParentMenuId = Conversion.TryCastInteger(row["parent_menu_id"]);
                    model.CssClass = Conversion.TryCastString(row["CssClass"]);

                    collection.Add(model);
                }
            }




            return collection;
        }



        public static int PageAuthenticationCheck(string PinNo, string PageName)
        {

            PBSDBUtility idb = new PBSDBUtility();

            string pindb = "", pagedb = "";



            string pqry = @"select count(*) from dbo.AppsPermission where 
    pin_number='" + PinNo + "'  and menu_id in   (select menu_id from dbo.menus where url='" + PageName + "')";



            int pagcount = int.Parse(idb.AggRetrive(pqry).ToString());



            if (pagcount > 0)

                return 1;
            else

                return 0;
        }


        internal static Collection<BOMenu> GetMenuCollection_Settings(int p1, int p2, string pinnumber)
        {
            Collection<BOMenu> collection = new Collection<BOMenu>();


            PBSDBUtility idb = new PBSDBUtility();


            string mnqry = @"SELECT        dbo.menus.menu_id, dbo.menus.menu_text, dbo.menus.MenuOrder, dbo.menus.url, dbo.menus.menu_code, dbo.menus.[level], dbo.menus.parent_menu_id, dbo.menus.audit_user_id, dbo.menus.audit_ts, 
                         dbo.menus.LastEditDate, dbo.menus.CreationDate, dbo.menus.ModuleName, dbo.menus.CssClass, dbo.menus.FormName
FROM            dbo.menus INNER JOIN
                         dbo.AppsPermission ON dbo.menus.menu_id = dbo.AppsPermission.menu_id
						 where menus.ModuleName='SETTINGS' order by dbo.menus.MenuOrder asc";

            using (DataTable table = idb.GetDataBySQLString(mnqry))
            {
                if (table == null)
                {
                    return null;
                }

                foreach (DataRow row in table.Rows)
                {
                    BOMenu model = new BOMenu();

                    model.MenuId = Conversion.TryCastInteger(row["menu_id"]);
                    model.MenuText = Conversion.TryCastString(row["menu_text"]);
                    model.Url = Conversion.ResolveUrl(Conversion.TryCastString(row["url"]));
                    model.MenuCode = Conversion.TryCastString(row["menu_code"]);
                    model.Level = Conversion.TryCastInteger(row["level"]);
                    model.ParentMenuId = Conversion.TryCastInteger(row["parent_menu_id"]);
                    model.CssClass = Conversion.TryCastString(row["CssClass"]);

                    collection.Add(model);
                }
            }




            return collection;
        }



        internal static Collection<BOMenu> GetSideMenuCollection(int p1, int p2, string pinnumber,string modulename)
        {
            Collection<BOMenu> collection = new Collection<BOMenu>();


            PBSDBUtility idb = new PBSDBUtility();


            string mnqry = @"SELECT        dbo.menus.menu_id, dbo.menus.menu_text, dbo.menus.MenuOrder, dbo.menus.url, dbo.menus.menu_code, dbo.menus.[level], dbo.menus.parent_menu_id, dbo.menus.audit_user_id, dbo.menus.audit_ts, 
                         dbo.menus.LastEditDate, dbo.menus.CreationDate, dbo.menus.ModuleName, dbo.menus.CssClass, dbo.menus.FormName
FROM            dbo.menus INNER JOIN
                         dbo.AppsPermission ON dbo.menus.menu_id = dbo.AppsPermission.menu_id
						 where menus.ModuleName='" + modulename + "' and menus.isActive = 1 and level=2 and AppsPermission.pin_number='" + pinnumber + "' order by dbo.menus.MenuOrder asc";

            using (DataTable table = idb.GetDataBySQLString(mnqry))
            {
                if (table == null)
                {
                    return null;
                }

                foreach (DataRow row in table.Rows)
                {
                    BOMenu model = new BOMenu();

                    model.MenuId = Conversion.TryCastInteger(row["menu_id"]);
                    model.MenuText = Conversion.TryCastString(row["menu_text"]);
                    model.Url = Conversion.ResolveUrl(Conversion.TryCastString(row["url"]));
                    model.MenuCode = Conversion.TryCastString(row["menu_code"]);
                    model.Level = Conversion.TryCastInteger(row["level"]);
                    model.ParentMenuId = Conversion.TryCastInteger(row["parent_menu_id"]);
                    model.CssClass = Conversion.TryCastString(row["CssClass"]);

                    collection.Add(model);
                }
            }




            return collection;
        }



        internal static Collection<BOMenu> GetSideMenuCollectionLevel3(int p1, int p2, string pinnumber, string modulename)
        {
            Collection<BOMenu> collection = new Collection<BOMenu>();


            PBSDBUtility idb = new PBSDBUtility();


            string mnqry = @"SELECT        dbo.menus.menu_id, dbo.menus.menu_text, dbo.menus.MenuOrder, dbo.menus.url, dbo.menus.menu_code, dbo.menus.[level], dbo.menus.parent_menu_id, dbo.menus.audit_user_id, dbo.menus.audit_ts, 
                         dbo.menus.LastEditDate, dbo.menus.CreationDate, dbo.menus.ModuleName, dbo.menus.CssClass, dbo.menus.FormName
FROM            dbo.menus INNER JOIN
                         dbo.AppsPermission ON dbo.menus.menu_id = dbo.AppsPermission.menu_id
						 where menus.ModuleName='" + modulename + "' and menus.isActive = 1 and menus.level=3 and parent_menu_id=" + p1 + " and AppsPermission.pin_number='" + pinnumber + "' order by dbo.menus.MenuOrder asc";

            using (DataTable table = idb.GetDataBySQLString(mnqry))
            {
                if (table == null)
                {
                    return null;
                }

                foreach (DataRow row in table.Rows)
                {
                    BOMenu model = new BOMenu();

                    model.MenuId = Conversion.TryCastInteger(row["menu_id"]);
                    model.MenuText = Conversion.TryCastString(row["menu_text"]);
                    model.Url = Conversion.ResolveUrl(Conversion.TryCastString(row["url"]));
                    model.MenuCode = Conversion.TryCastString(row["menu_code"]);
                    model.Level = Conversion.TryCastInteger(row["level"]);
                    model.ParentMenuId = Conversion.TryCastInteger(row["parent_menu_id"]);
                    model.CssClass = Conversion.TryCastString(row["CssClass"]);

                    collection.Add(model);
                }
            }




            return collection;
        }

        internal static DataTable ModuleInfoByPath(string path)
        {
           

            PBSDBUtility idb = new PBSDBUtility();

            Hashtable ht =new Hashtable();
            ht.Add("path",path);
            DataTable dtab = idb.GetDataByProc(ht, "sp_GetModuleInfoByPath");
            return dtab;
        }

    }
}
