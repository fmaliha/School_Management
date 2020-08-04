using PBSConnLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace InovexiaEBS.Settings
{
    public partial class MenuPermission : System.Web.UI.Page
    {

        PBSDBUtility pbUtility = new PBSDBUtility();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                
                
                
               

                Hashtable ht = new Hashtable();
                ht.Add("Pin_Number", 0);               
                DataTable dataTable = pbUtility.GetDataByProc(ht, "getUserModuleMenuPermission");
                grdList.DataSource = dataTable;
                grdList.DataBind();

            }
        }

        protected void radCmboUserName_ItemsRequested(object sender, Telerik.Web.UI.RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {

                DataTable dataTable = BLUserAccess.GetAllUsers();
                
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();

                    item.Text = (string)dataRow["name"];


                    String ContactNumber = dataRow["ContactNumber"].ToString();
                    item.Attributes.Add("ContactNumber", ContactNumber.ToString());

                    String email = dataRow["email"].ToString();
                    item.Attributes.Add("email", email.ToString());


                    item.Value = dataRow["pin_number"].ToString();
                    String pin_number = dataRow["pin_number"].ToString();
                    item.Attributes.Add("pin_number", pin_number.ToString());



                    radCmboUserName.Items.Add(item);

                    item.DataBind();
                }
            }

            catch (Exception ex)
            {
                Alert.Show(ex.Message);
            }
        }


        protected void radCmboUserName_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Pin_Number", radCmboUserName.SelectedValue);
            // ht.Add("ModuleName", radCmboModuleList.SelectedValue);
            DataTable dataTable = pbUtility.GetDataByProc(ht, "getUserModuleMenuPermission");
            grdList.DataSource = dataTable;
            grdList.DataBind();
        }



        protected void ToggleRowSelection(object sender, EventArgs e)
        {
            ((sender as CheckBox).NamingContainer as GridItem).Selected = (sender as CheckBox).Checked;
            bool checkHeader = true;
            foreach (GridDataItem dataItem in grdList.MasterTableView.Items)
            {
                if (!(dataItem.FindControl("CheckBox1") as CheckBox).Checked)
                {
                    checkHeader = false;
                    break;
                }
            }
            GridHeaderItem headerItem = grdList.MasterTableView.GetItems(GridItemType.Header)[0] as GridHeaderItem;
            (headerItem.FindControl("headerChkbox") as CheckBox).Checked = checkHeader;
        }
        protected void ToggleSelectedState(object sender, EventArgs e)
        {
            CheckBox headerCheckBox = (sender as CheckBox);
            foreach (GridDataItem dataItem in grdList.MasterTableView.Items)
            {
                (dataItem.FindControl("CheckBox1") as CheckBox).Checked = headerCheckBox.Checked;
                dataItem.Selected = headerCheckBox.Checked;
            }
        }







        protected void ToggleRowSelection_view(object sender, EventArgs e)
        {
            ((sender as CheckBox).NamingContainer as GridItem).Selected = (sender as CheckBox).Checked;
            bool checkHeader = true;
            foreach (GridDataItem dataItem in grdList.MasterTableView.Items)
            {
                if (!(dataItem.FindControl("CheckBox2") as CheckBox).Checked)
                {
                    checkHeader = false;
                    break;
                }
            }
            GridHeaderItem headerItem = grdList.MasterTableView.GetItems(GridItemType.Header)[0] as GridHeaderItem;
            (headerItem.FindControl("headerChkbox2") as CheckBox).Checked = checkHeader;
        }
        protected void ToggleSelectedState_view(object sender, EventArgs e)
        {
            CheckBox headerCheckBox = (sender as CheckBox);
            foreach (GridDataItem dataItem in grdList.MasterTableView.Items)
            {
                (dataItem.FindControl("CheckBox2") as CheckBox).Checked = headerCheckBox.Checked;
                dataItem.Selected = headerCheckBox.Checked;
            }
        }




        protected void ToggleRowSelection_edit(object sender, EventArgs e)
        {
            ((sender as CheckBox).NamingContainer as GridItem).Selected = (sender as CheckBox).Checked;
            bool checkHeader = true;
            foreach (GridDataItem dataItem in grdList.MasterTableView.Items)
            {
                if (!(dataItem.FindControl("CheckBox3") as CheckBox).Checked)
                {
                    checkHeader = false;
                    break;
                }
            }
            GridHeaderItem headerItem = grdList.MasterTableView.GetItems(GridItemType.Header)[0] as GridHeaderItem;
            (headerItem.FindControl("headerChkbox3") as CheckBox).Checked = checkHeader;
        }
        protected void ToggleSelectedState_edit(object sender, EventArgs e)
        {
            CheckBox headerCheckBox = (sender as CheckBox);
            foreach (GridDataItem dataItem in grdList.MasterTableView.Items)
            {
                (dataItem.FindControl("CheckBox3") as CheckBox).Checked = headerCheckBox.Checked;
                dataItem.Selected = headerCheckBox.Checked;
            }
        }




    }
}