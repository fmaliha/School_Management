using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace InovexiaEBS.Settings
{
    public partial class GovtAssistType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            
            
        }

        protected void RadGrid1_ItemUpdated(object source, Telerik.Web.UI.GridUpdatedEventArgs e)
        {
            GridEditableItem item = (GridEditableItem)e.Item;
            String id = item.GetDataKeyValue("CmnGovtAssistTypeID").ToString();

            if (e.Exception != null)
            {
                e.KeepInEditMode = true;
                e.ExceptionHandled = true;
                SetMessage("Supplier with ID " + id + " cannot be updated. Reason: " + e.Exception.Message);
            }
            else
            {
                SetMessage("Supplier with ID " + id + " is updated!");
            }
        }

        protected void RadGrid1_ItemInserted(object source, GridInsertedEventArgs e)
        {
            if (e.Exception != null)
            {
                e.ExceptionHandled = true;
                SetMessage("Supplier cannot be inserted. Reason: " + e.Exception.Message);
            }
            else
            {
                SetMessage("New Supplier is inserted!");
            }
        }

        protected void RadGrid1_ItemDeleted(object source, GridDeletedEventArgs e)
        {
            GridDataItem dataItem = (GridDataItem)e.Item;
            String id = dataItem.GetDataKeyValue("CmnGovtAssistTypeID").ToString();

            if (e.Exception != null)
            {
                e.ExceptionHandled = true;
                SetMessage("Supplier with ID " + id + " cannot be deleted. Reason: " + e.Exception.Message);
            }
            else
            {
                SetMessage("Supplier with ID " + id + " is deleted!");
            }
        }

        protected void RadioCheckedChanged(object sender, System.EventArgs e)
        {


            //            RadGrid1.MasterTableView.EditMode = GridEditMode.InPlace;
            //            RadioButton1.Checked = false;
            //            break;

            //RadGrid1.Rebind();
        }
        protected void CheckboxCheckedChanged(object sender, System.EventArgs e)
        {


        }

        private void DisplayMessage(string text)
        {//
            //RadGrid1.Controls.Add(new LiteralControl(string.Format("<span style='color:red'>{0}</span>", text)));
        }

        private void SetMessage(string message)
        {
            gridMessage = message;
        }

        private string gridMessage = null;
        protected void RadGrid1_DataBound(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gridMessage))
            {
                DisplayMessage(gridMessage);
            }
        }


    }
}