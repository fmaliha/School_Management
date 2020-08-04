using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.BusinessLogic.StudentRegistrationBLL;
using PBSConnLib;
using Telerik.Web.UI;

namespace InovexiaEBS.StudentRegistration
{
    public partial class AcountReceiveable_Entry : System.Web.UI.Page
    {
        PBSDBUtility pb = new PBSDBUtility();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)

            {
                ddlmonth_load();
                ddlyear_load();
                ARalert1.Visible = false;
                ARalert2.Visible = false;
                ARAlert3.Visible = false;
            }

        }

        private void ddlmonth_load()
        {
            DateTimeFormatInfo month = new DateTimeFormatInfo();



           // ddlmonth.Items.Insert(0, new ListItem("Please select a Month", "0"));
            for (int i = 1; i < 13; i++)
            {
                ddlmonth.Items.Add(new ListItem(month.GetMonthName(i)));
            }
        }


        private void ddlyear_load()
        {
            //List<int> years = new List<int>();
            int currentYear = DateTime.Now.Year;

           // ddlYear.Items.Insert(0, new ListItem("    --  Please select a Year --", "0"));
            //ddlYear.SelectedIndex = 0;
            //for (int year = currentYear; year <= currentYear + 5; year++)
            //{
            //    years.Add(year);
            //}

            // Bind the dropdownlist
            //ddlYear.DataSource = years;
            txtyear.Text = currentYear.ToString();
           // txtyear.DataBind();
        }

        protected long SaveAccountReceiveableEntry()
        {
            long v = 0;
            VmStudentRegistration objvm = new VmStudentRegistration();

            objvm.EMonth = ddlmonth.SelectedValue.ToString();
            objvm.EYear = txtyear.Text.Trim();
            objvm.EPayHead = ddlpayhead.SelectedValue;
            objvm.EAmount = txtamount1.Text.Trim();
            objvm.ENarration = txtnarrationpayment1.Text.Trim();

            if (
                txtamount1.Text.OfType<string>() != null)
            {
                ARAlert3.Visible = true;
            }

            v = AccountReceiveableEntryBLL.SaveAccountReceiveableData(objvm);
            if (v > 0)
            {
               
                    txtrefno1.Text = v.ToString();
                ARalert1.Visible = true;
                ARAlert3.Visible = false;

            }

            else
            {
                ARalert2.Visible = true;
            }
            return v;
        }
        protected void btnsaveExp1_OnClick(object sender, EventArgs e)
        {
            SaveAccountReceiveableEntry();


        }
        
            

        protected void ddlpayhead_OnItemsRequested(object sender, RadComboBoxItemsRequestedEventArgs e)
        {
            try
            {
                DataTable DT = pb.GetDataByProc("SM_GetExpType");
                foreach (DataRow datarow in DT.Rows)
                {
                    RadComboBoxItem item = new RadComboBoxItem();
                    item.Text = (string)datarow["HeadName"];
                    item.Value = datarow["ExpenseID"].ToString();
                    item.Attributes.Add("HeadName", datarow["HeadName"].ToString());
                    ddlpayhead.Items.Add(item);
                    item.DataBind();
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

        }
    }


        }
    
