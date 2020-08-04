<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="ReportExpenseUI.aspx.cs" Inherits="InovexiaEBS.SchoolManagement.Report.ReportExpenseUI" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.ReportViewer.WebForms" Assembly="Telerik.ReportViewer.WebForms, Version=7.2.13.1016, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">


<%--        $(function () {

            $("#<%=ddlCustomerType.ClientID%>").select2({
                   placeholder: "--Select Customer Type--",
                   allowClear: true
               });
               $("#<%=ddlPop.ClientID%>").select2({
                   placeholder: "--Select Status Type--",
                   allowClear: true
               });
           });--%>
        function WarningMessage() {
            MessageBox("Please provide all value", "warning");
        }


        $(function () {
            $("#txtFromDate").datepicker({
                showOn: "button",
                buttonImage: '<%=ResolveUrl("~/Images/calendar.gif") %>',
                buttonImageOnly: true,
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: 0,
                onSelect: function (selected) {

                    $("#txtToDate").datepicker("option", "minDate", selected);

                }

            });

            $("#txtToDate").datepicker({
                showOn: "button",
                buttonImage: '<%=ResolveUrl("~/Images/calendar.gif") %>',
                   buttonImageOnly: true,
                   changeMonth: true,
                   changeYear: true,
                   dateFormat: 'dd/mm/yy',

                   onSelect: function (selected) {

                       $("#txtFromDate").datepicker("option", "maxDate", selected);

                   }

               });
        });

    </script>

    <style type="text/css">
        .saveButton {
            border-style: none;
            border-color: inherit;
            border-width: 0px;
            font-family: "Trebuchet MS", sans-serif;
            background-color: #0072C6; /*border: 1px solid blue;*/
            cursor: pointer;
            font-size: 1.2em;
            font-weight: normal;
            margin: 0;
            padding: 2px 2px 2px 5px;
            color: #FFFFFF;
            letter-spacing: 0.07em;
            white-space: nowrap;
        }
    </style>


  
  <div class="row " id="divEpanel" runat="server" >
                     
                       <div class="col-lg-12">
                                <div class="panel">
           
                                  <div class="panel-body divColorb">
                                      <h3 style="font-family: fantasy">Expense Report</h3>  
                                      
                                      <div class="list-divider"></div>
                                      <br/>
   
               
                  <div class="row" >
                 
                    <%--<asp:TextBox runat="server" ID="txtFromDate" ClientIDMode="Static" onblur="ValidateDate(this)"></asp:TextBox>--%>
                   <div class="col-md-4" style="float: left">
                       <asp:Label ID="Label1" runat="server" ><b>Start Date</b></asp:Label>&nbsp;&nbsp;&nbsp;
                      
                      <div style="float: right">
                           <telerik:RadDatePicker ID="dpSDate" runat="server" Width="229px" Culture="en-US" Skin="Silk"
                        MaxDate="3000-01-01" MinDate="1000-01-01" ShowPopupOnFocus="True" AutoPostBack="False">
                        <DateInput runat="server" DateFormat="d/M/yyyy"></DateInput>
                    </telerik:RadDatePicker>
                      </div>
                        

                      <asp:RequiredFieldValidator ID="rfvdpSDate" runat="server" ControlToValidate="dpSDate" ErrorMessage="*Required" ValidationGroup="feereport" ForeColor="red"></asp:RequiredFieldValidator>     
              
                                     
                  </div>
                    
                    <%--<div class="col-md-2"></div>--%>

                     
                 <div class="col-md-4" style="float: right">
                                       <asp:Label ID="Label2" runat="server"><b>End Date</b></asp:Label> 
                     
                     <div style="float: right">
                         
                          <telerik:RadDatePicker ID="dpEDate" runat="server" Width="229px" Culture="en-US" Skin="Silk"
                        MaxDate="3000-01-01" MinDate="1000-01-01" ShowPopupOnFocus="True" AutoPostBack="False">
                        <DateInput runat="server" DateFormat="d/M/yyyy"></DateInput>
                    </telerik:RadDatePicker>
                     </div>
                   
                    <%-- <asp:TextBox runat="server" ID="txtToDate" ClientIDMode="Static" onblur="ValidateDate(this)"></asp:TextBox>--%>
 <asp:RequiredFieldValidator ID="rfvdpEDate" runat="server" ControlToValidate="dpEDate" ErrorMessage="*Required" ValidationGroup="feereport" ForeColor="red"></asp:RequiredFieldValidator> 
                  
                                      </div>
                    
                    
                                         
             
                    
                     <div class="col-md-4" style="float: right">
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="btnShowreport" runat="server" Text="Show Report" CssClass="saveButton"
                        ValidationGroup ="feereport" OnClick="btnShowreport_Click" Width="148px" />
             </div>
                    

                    
             </div> 
                                      
                                      <br/>
                                      <br/> 
                                      

        <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
            
            <ContentTemplate>

                <telerik:ReportViewer ID="ReportViewer2" runat="server" Height="500px" Width="100%" ViewMode="PrintPreview" ></telerik:ReportViewer>

            </ContentTemplate>

        </asp:UpdatePanel>
    
                                      
                                      </div>
                                    </div>
                           </div>
      </div>
</asp:Content>
