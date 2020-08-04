using InovexiaEBS.BusinessEntity.PBML.Settings;
using InovexiaEBS.BusinessLogic.Settings;
using IPLCriptography;
using PBSConnLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace InovexiaEBS.Settings.Entry
{
    public partial class UserInfo : System.Web.UI.Page
    {
        PBSDBUtility pbUtility = new PBSDBUtility();
        string connectionString= System.Configuration.ConfigurationManager.ConnectionStrings["PBSConnectionString"].ConnectionString;
        static int masterId = 0;
        MyEncryptor objMyEncryptor = new MyEncryptor();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                
                
                
                ManagePanel("Master");
            }
            else
            {
                txtUPassword.Attributes["value"] = txtUPassword.Text;
            }
        }
        protected void ddlStakeHolderType_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                //string sqlSelectCommand = @"Select StakeholderTypeID,StakeholderTypeName from [dbo].[CmnStakeholderType]";
                //SqlDataAdapter adapter = new SqlDataAdapter(sqlSelectCommand, connectionString);
                ////adapter.SelectCommand.Parameters.AddWithValue("@text", e.Text);
                //DataTable dataTable = new DataTable();
                //adapter.Fill(dataTable);

                //Hashtable ht = new Hashtable();
                //ht.Add("EnterpriseCategoryId", 1);  // 1 for Yarn
                DataTable dataTable = pbUtility.GetDataByProc("sp_getStakeholderType");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)dataRow["StakeholderTypeName"];
                    item.Value = dataRow["StakeholderTypeID"].ToString();
                    item.Attributes.Add("StakeholderTypeName", dataRow["StakeholderTypeName"].ToString());
                    ddlStakeHolderType.Items.Add(item);
                    item.DataBind();

                }

            }
            catch (Exception ex)
            {

                Alert.Show(ex.Message);
            }
        }

        protected void ddlStakeHolderType_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            try
            {
                ClearStakeHolder();
            }
            catch (Exception ex)
            {

                Alert.Show(ex.Message.ToString());
            }

        }

        public void ClearStakeHolder()
        {
            try
            {
                ddlStakeHolder.ClearSelection();
                ddlStakeHolder.Text = string.Empty;
                ddlStakeHolder.Items.Clear();
                
            }
            catch (Exception ex)
            {
                new Exception(ex.Message.ToString());
            }
        }

        public void ClearStakeHolderType()
        {
            try
            {
                ddlStakeHolderType.ClearSelection();
                ddlStakeHolderType.Text = string.Empty;
                ddlStakeHolderType.Items.Clear();
                if (grdDetailsList.MasterTableView.Items.Count == 0)
                {
                    grdDetailsList.DataSource = null;
                    
                }
                 
            }
            catch (Exception ex)
            {
                new Exception(ex.Message.ToString());
            }
        }
        protected void ddlStakeHolder_ItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                var stockholderTypeId = ddlStakeHolderType.SelectedValue.Trim();
                if (stockholderTypeId == "1" || stockholderTypeId == "14")
                {
                    //string sqlSelectCommand = @"Select InstitutionID,InstitutionName from Institution_Master_Info";
                    //SqlDataAdapter adapter = new SqlDataAdapter(sqlSelectCommand, connectionString);
                    ////adapter.SelectCommand.Parameters.AddWithValue("@text", e.Text);
                    //DataTable dataTable = new DataTable();
                    //adapter.Fill(dataTable);

                    DataTable dataTable = pbUtility.GetDataByProc("sp_getInstitutionMaster");
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        RadComboBoxItem item = new RadComboBoxItem();
                        item.Text = (string)dataRow["InstitutionName"];
                        item.Value = dataRow["InstitutionID"].ToString();
                        item.Attributes.Add("InstitutionName", dataRow["InstitutionName"].ToString());
                        ddlStakeHolder.Items.Add(item);
                        item.DataBind();

                    }
                }
                else
                {
                    ClearStakeHolder();
                }


                

            }
            catch (Exception ex)
            {

                Alert.Show(ex.Message);
            }
        }




        private void Clear()
        {
            txtName.Text = string.Empty;
            txtULoginID.Text = string.Empty;
            txtUPassword.Text = string.Empty;
            txtUPassword.Attributes["value"] = string.Empty;
            txtEmail.Text = string.Empty;
            txtContactNumber.Text = string.Empty;
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (rfvName.IsValid && rfvLoginID.IsValid && revContactNumber.IsValid && rfvPassword.IsValid && rfvEmail1.IsValid && rfvEmail.IsValid && grdDetailsList.Items.Count == 0)
                {
                    Alert.Show("Please Add StakeHolder.");
                }
                if (rfvName.IsValid && rfvLoginID.IsValid && revContactNumber.IsValid && rfvPassword.IsValid && rfvEmail1.IsValid && rfvEmail.IsValid && grdDetailsList.Items.Count>0)
                {
                    User _objUser = new User();
                    long status = 0;
                    if (btnSave.Text == "Save")
                    {
                        _objUser.UserName = txtName.Text.Trim();
                        _objUser.LoginID = txtULoginID.Text.Trim();  
                        _objUser.Password = objMyEncryptor.Encrypt(txtUPassword.Text); 
                        _objUser.Email = txtEmail.Text.Trim();
                        _objUser.ContactNumber = txtContactNumber.Text.Trim();
                        _objUser.CreatedBy = Session[SessionInfo.pin_number].ToString();
                        status = BLUser.InsertUser(_objUser);
                    }
                    else
                    {
                        _objUser.UserName = txtName.Text.Trim();
                        _objUser.LoginID = txtULoginID.Text.Trim();
                        _objUser.pin_number = masterId.ToString(); 
                        _objUser.Password = objMyEncryptor.Encrypt(txtUPassword.Text);
                        _objUser.Email = txtEmail.Text.Trim();
                        _objUser.ContactNumber = txtContactNumber.Text.Trim();
                        _objUser.CreatedBy = Session[SessionInfo.pin_number].ToString();
                        //status = BLUser.UpdateUser(_objUser);
                    }
                    
                    long detailStatus = 0;
                    DataTable dt = (DataTable)ViewState["DetailsDataTable"];
                    if (ViewState["DetailsDataTable"] != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {

                            vmUser_Stackholder _objStackHolder = new vmUser_Stackholder();
                            _objStackHolder.MappingID = Convert.ToInt16(row["MappingID"].ToString());
                            _objStackHolder.pin_number = Convert.ToInt16(status.ToString());
                            _objStackHolder.StakeholderTypeID = Convert.ToInt16(row["StakeholderTypeID"].ToString());
                            _objStackHolder.StakeholderName = row["StakeholderName"].ToString();
                            _objStackHolder.CreatedBy = Session[SessionInfo.pin_number].ToString();
                            //detailStatus = BLUser.InsertUserStackholder(_objStackHolder);
                        }
                    }


                    if (status > 0 && detailStatus > 0)
                    {
                        Alert.Show("Successfully Save");
                        Clear();
                        ViewState["DetailsDataTable"] = null;


                        ddlStakeHolderType.ClearSelection();
                        ddlStakeHolderType.Text = string.Empty;

                        grdDetailsList.DataSource = null;
                        grdDetailsList.Rebind();



                        btnSave.Text = "Save";


                    }
                }

                
            }
            catch (Exception ex)
            {

                Alert.Show("Error");
            }
        }

        
        List<vmUser_Stackholder> list = new List<vmUser_Stackholder>();
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (rfvStakeHolderType.IsValid && rfvStakeHolder.IsValid)
                {
                    DataTable dt = (DataTable)ViewState["DetailsDataTable"];
                    if (ViewState["DetailsDataTable"] != null)
                    {
                        DataRow row = dt.NewRow();
                        row["MappingID"] =Convert.ToString(dt.Rows.Count+1);
                        row["pin_number"] = "1";
                        row["StakeholderTypeID"] = Convert.ToInt32(ddlStakeHolderType.SelectedValue.ToString());
                        row["StakeholderTypeName"] = ddlStakeHolderType.Text.ToString().Trim();
                        row["StakeholderName"] = ddlStakeHolder.Text.ToString().Trim();
                        dt.Rows.Add(row);
                    }
                    else
                    {
                        dt = new DataTable();
                        dt.Clear();
                        dt.Columns.Add("MappingID");
                        dt.Columns.Add("pin_number");
                        dt.Columns.Add("StakeholderTypeID");
                        dt.Columns.Add("StakeholderTypeName");
                        dt.Columns.Add("StakeholderName");
                        DataRow row = dt.NewRow();
                        row["MappingID"] = "1";
                        row["pin_number"] = "1";
                        row["StakeholderTypeID"] = Convert.ToInt32(ddlStakeHolderType.SelectedValue.ToString());
                        row["StakeholderTypeName"] = ddlStakeHolderType.Text.ToString().Trim();
                        row["StakeholderName"] = ddlStakeHolder.Text.ToString().Trim();
                        dt.Rows.Add(row);
                    }
                    ViewState["DetailsDataTable"] = dt;
                    grdDetailsList.DataSource = dt;
                    grdDetailsList.DataBind();
                    SetDetailsGridAppearance();
                    ClearStakeHolderType();
                    ClearStakeHolder();
                }
                
            }
            catch (Exception ex)
            {

                Alert.Show(ex.Message.ToString());
            }
           




        }

       
        private void SetDetailsGridAppearance()
        {
            try
            {

                grdDetailsList.MasterTableView.HeaderStyle.HorizontalAlign = HorizontalAlign.Left;
                grdDetailsList.MasterTableView.ItemStyle.HorizontalAlign = HorizontalAlign.Left;
                grdDetailsList.MasterTableView.GetColumn("MappingID").Display = false;
                grdDetailsList.MasterTableView.GetColumn("pin_number").Display = false;
                grdDetailsList.MasterTableView.GetColumn("StakeholderTypeID").Display = false;
                
                //grdDetailsList.MasterTableView.GetColumn("Rate").ItemStyle.HorizontalAlign = HorizontalAlign.Right;
                //grdDetailsList.MasterTableView.GetColumn("Quantitiy").ItemStyle.HorizontalAlign = HorizontalAlign.Right;
                //grdDetailsList.MasterTableView.GetColumn("Amount").ItemStyle.HorizontalAlign = HorizontalAlign.Right;

                //grdDetailsList.MasterTableView.GetColumn("Rate").HeaderStyle.HorizontalAlign = HorizontalAlign.Right;
                //grdDetailsList.MasterTableView.GetColumn("Quantitiy").HeaderStyle.HorizontalAlign = HorizontalAlign.Right;
                //grdDetailsList.MasterTableView.GetColumn("Amount").HeaderStyle.HorizontalAlign = HorizontalAlign.Right;
                //grdDetailsList.MasterTableView.GetColumn("ProductName").HeaderStyle.HorizontalAlign = HorizontalAlign.Left;

                //grdDetailsList.MasterTableView.GetColumn("Company").HeaderStyle.HorizontalAlign = HorizontalAlign.Left;
                //grdDetailsList.MasterTableView.GetColumn("LotNo").HeaderStyle.HorizontalAlign = HorizontalAlign.Left;



                //grdDetailsList.MasterTableView.GetColumn("LotID").Display = false;
                //grdDetailsList.MasterTableView.GetColumn("ProductName").HeaderStyle.Width = Unit.Pixel(300);
                //grdDetailsList.MasterTableView.GetColumn("Company").HeaderStyle.Width = Unit.Pixel(100);
                //grdDetailsList.MasterTableView.GetColumn("LotNo").HeaderStyle.Width = Unit.Pixel(100);
                //grdDetailsList.MasterTableView.GetColumn("Rate").HeaderStyle.Width = Unit.Pixel(80);
                //grdDetailsList.MasterTableView.GetColumn("Quantitiy").HeaderStyle.Width = Unit.Pixel(80);
                //grdDetailsList.MasterTableView.GetColumn("Amount").HeaderStyle.Width = Unit.Pixel(80);


            }
            catch (Exception ex)
            {

                new Exception(ex.Message.ToString());
            }
        }
        public void ManagePanel(String panel)
        {
            try
            {
                if (panel == "Master")
                {
                    MasterPanel.Visible = true;
                    DetailPanel.Visible = true;
                    ListPanel.Visible = false;
                    btnSave.Visible = true;
                    btnNew.Visible = false;
                }
                else
                {
                    MasterPanel.Visible = false;
                    DetailPanel.Visible = false;
                    ListPanel.Visible = true;
                    btnSave.Visible = false;
                    btnNew.Visible = true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        protected void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("pin_number", 0);
                DataTable dataTable = pbUtility.GetDataByProc(ht, "GetUserList");
                grdList.DataSource = dataTable;
                grdList.DataBind();
                SetListGridappearance();
                ManagePanel("List");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

        }
        private void UserEditById(int userId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("pin_number", userId);
                DataTable dataTable = pbUtility.GetDataByProc(ht, "GetUserList");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    txtName.Text = (string)dataRow["name"];
                    txtEmail.Text = (string)dataRow["email"];
                    txtULoginID.Text = (string)dataRow["login_id"];
                    string password = objMyEncryptor.Decrypt((string)dataRow["password"]);
                    txtUPassword.Text = password;
                    txtUPassword.Attributes["value"] = txtUPassword.Text;
                    txtContactNumber.Text = (string)dataRow["ContactNumber"];
                }

                Hashtable ht1 = new Hashtable();
                ht1.Add("pin_number", userId);
                DataTable dataTable1 = pbUtility.GetDataByProc(ht1, "GetUserStakeholder");
                
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("MappingID");
                dt.Columns.Add("pin_number");
                dt.Columns.Add("StakeholderTypeID");
                dt.Columns.Add("StakeholderTypeName");
                dt.Columns.Add("StakeholderName");
                foreach (DataRow dataRow in dataTable1.Rows)
                {
                    DataRow row = dt.NewRow();
                    row["MappingID"] = (string)dataRow["MappingID"].ToString();
                    row["pin_number"] = (string)dataRow["pin_number"].ToString();
                    row["StakeholderTypeID"] = (string)dataRow["StakeholderTypeID"].ToString(); ;
                    row["StakeholderTypeName"] = (string)dataRow["StakeholderTypeName"]; ;
                    row["StakeholderName"] = (string)dataRow["StakeholderName"]; ;
                    dt.Rows.Add(row);
                }

                if (dt.Rows.Count > 0)
                {
                    ViewState["DetailsDataTable"] = null;
                    ViewState["DetailsDataTable"] = dt;
                    grdDetailsList.DataSource = dt;
                    grdDetailsList.DataBind();
                    SetDetailsGridAppearance();
                    ClearStakeHolderType();
                    ClearStakeHolder();
                }
                ManagePanel("Master");
            }
            catch (Exception ex)
            {
                new Exception(ex.Message.ToString());
            }
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                RadButton Button = (RadButton)sender;
                GridDataItem item = (GridDataItem)Button.NamingContainer;
                int pin_number = Convert.ToInt16(item.GetDataKeyValue("pin_number").ToString());
                masterId = pin_number;
                btnSave.Text = "Update";
                UserEditById(pin_number);

            }
            catch (Exception ex)
            {

                Alert.Show(ex.Message);
            }

        }

        protected void btnDeleteDetails_Click(object sender, EventArgs e)
        {
            try
            {
                RadButton Button = (RadButton)sender;
                GridDataItem item = (GridDataItem)Button.NamingContainer;
                String MappingID = item.GetDataKeyValue("MappingID").ToString();

                DataTable dataTable1 = (DataTable)ViewState["DetailsDataTable"];
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("MappingID");
                dt.Columns.Add("pin_number");
                dt.Columns.Add("StakeholderTypeID");
                dt.Columns.Add("StakeholderTypeName");
                dt.Columns.Add("StakeholderName");
                int newMappingID = 0;
                foreach (DataRow dataRow in dataTable1.Rows)
                {
                    if ((string)dataRow["MappingID"].ToString() != MappingID)
                    {
                        newMappingID++;
                        DataRow row = dt.NewRow();
                        row["MappingID"] = (string)newMappingID.ToString();
                        row["pin_number"] = (string)dataRow["pin_number"].ToString();
                        row["StakeholderTypeID"] = (string)dataRow["StakeholderTypeID"].ToString(); 
                        row["StakeholderTypeName"] = (string)dataRow["StakeholderTypeName"]; ;
                        row["StakeholderName"] = (string)dataRow["StakeholderName"]; ;
                        dt.Rows.Add(row);
                    }
                }

                if (dt.Rows.Count > 0)
                {
                    ViewState["DetailsDataTable"] = null;
                    ViewState["DetailsDataTable"] = dt;
                    grdDetailsList.DataSource = dt;
                    grdDetailsList.DataBind();
                    SetDetailsGridAppearance();
                    ClearStakeHolderType();
                    ClearStakeHolder();
                }


            }
            catch (Exception ex)
            {

                Alert.Show(ex.Message);
            }

        }
        
        private void SetListGridappearance()
        {
            try
            {
                grdList.MasterTableView.HeaderStyle.HorizontalAlign = HorizontalAlign.Left;
                grdList.MasterTableView.ItemStyle.HorizontalAlign = HorizontalAlign.Left;
                grdList.MasterTableView.GetColumn("pin_number").Display = false;
                grdList.MasterTableView.GetColumn("password").Display = false;
                
            }
            catch (Exception ex)
            {

                new Exception(ex.Message.ToString());
            }
        }
        protected void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
               
                ManagePanel("Master");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }





        }

        



    }
}