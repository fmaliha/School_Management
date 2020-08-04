using InovexiaEBS.BusinessEntity.PBML.Settings;
using InovexiaEBS.BusinessLogic.Settings;
using PBSConnLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InovexiaEBS.Settings.Entry
{
    public partial class UserEntry : System.Web.UI.Page
    {
        PBSDBUtility ABS_IDB = new PBSDBUtility();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                
                
              
                LoadUserTypes();
                
               
            }
        }

        private void LoadUserTypes()
        {
            try
            {
                DataTable dataTable = ABS_IDB.GetDataByProc("sp_getUserType");
                if (dataTable.Rows.Count > 0)
                {
                    ddlUserType.DataSource = dataTable;
                    ddlUserType.DataValueField = "UserTypeID";
                    ddlUserType.DataTextField = "UserTypeName";
                    ddlUserType.DataBind();
                }

            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message);
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == "")
                {
                    Alert.Show("Please Input Name.");
                    return;
                }
                else if (txtULoginID.Text.Trim() == "")
                {
                    Alert.Show("Please Input Login ID.");
                    return;
                }
                else if (txtUPassword.Text.Trim() == "")
                {
                    Alert.Show("Please Input Password.");
                    return;
                }
                else if (txtEmail.Text.Trim() == "")
                {
                    Alert.Show("Please Input Email.");
                    return;
                }
                else if (!IsValidEmail(txtEmail.Text.Trim()))
                {
                    Alert.Show("Incorrect Email.");
                    return;
                }
                else if (ddlUserType.Text.Trim() == "0")
                {
                    Alert.Show("Select User Type.");
                    return;
                }

                else
                {
                    User _objUser = new User();
                    _objUser.UserName = txtName.Text.Trim();
                    _objUser.LoginID = txtULoginID.Text.Trim();
                    _objUser.Password = txtUPassword.Text.Trim();
                    _objUser.Email = txtEmail.Text.Trim();
                    _objUser.UserType = ddlUserType.SelectedItem.Text.Trim();
                    _objUser.CreatedBy = Session[SessionInfo.pin_number].ToString();

                    long status = BLUser.InsertUser(_objUser);
                    if (status > 0)
                    {
                        Alert.Show("Successfully Save");
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message);
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void Clear()
        {
            txtName.Text = string.Empty;
            txtULoginID.Text = string.Empty;
            txtUPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            LoadUserTypes();
        }

        protected void txtLoginID_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    Hashtable ht = new Hashtable();
            //    ht.Add("LoginId", txtULoginID.Text.Trim());
            //    DataTable dataTable = ABS_IDB.GetDataByProc(ht,"sp_getUserByLoginId");
            //    if (dataTable.Rows.Count > 0)
            //    {
            //        Alert.Show( txtULoginID.Text.Trim() +" Login ID is already taken");
            //        txtULoginID.Text = string.Empty;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Alert.Show(ex.Message);
            //}
        }
    }
}