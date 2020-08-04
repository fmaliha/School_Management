<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="StudentLedgerReportUI.aspx.cs" Inherits="InovexiaEBS.StudentRegistration.Report.StudentLedgerReportUI" %>
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
    <div class="row " id="divpdetails" runat="server" >
                     
                       <div class="col-lg-12">
                                <div class="panel">
           
                                  <div class="panel-body divColorb">

    <%--<telerik:RadCalendar ID="RadCalendar1" runat="server"></telerik:RadCalendar>
    <telerik:RadCalendar ID="RadCalendar2" runat="server"></telerik:RadCalendar>
    <asp:Button ID="Button1" runat="server" CssClass="btn btn-dark" Text="Generate Report" />--%>
    
    
   
  <h3 style="font-family: fantasy">Student Fees Received</h3>  
                                      
                                      <div class="list-divider"></div>
                                      
                                      
                                      
    
       <div class="row">
           
           <div class="col-md-4">
               <asp:Label ID="Label3" runat="server"><b>Student ID</b></asp:Label> 
                <telerik:RadComboBox ID="ddlStudentName"  runat="server" DropDownCssClass="widthClass"  
                                                            EmptyMessage="Payment Head" EnableLoadOnDemand="True" Filter="Contains" Height="100%"
                                                            HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                            AutoPostBack="False" OnItemsRequested="ddlStudentName_OnItemsRequested">
                                                          <HeaderTemplate>
                                                                <table cellpadding="0" cellspacing="0">
                                                                    <tr>

                                                                        <td>
                                                                            StudentID. Name

                                                                           
                                                                        </td>

                                                                    </tr>
                                                                </table>
                                                            </HeaderTemplate> 
                                                        </telerik:RadComboBox>
 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlStudentName" ErrorMessage="*Required" ValidationGroup="feereport" ForeColor="red"></asp:RequiredFieldValidator>
                     
               
           </div>
            
           <div class="col-md-4">
             
               <asp:Label ID="Label1" runat="server"><b>Start Date</b></asp:Label>
                
                    <telerik:RadDatePicker ID="dpStartDate" runat="server" Width="229px" Culture="en-US" Skin="Silk"
                        MaxDate="3000-01-01" MinDate="1000-01-01" ShowPopupOnFocus="True" AutoPostBack="False">
                        <DateInput runat="server" DateFormat="d/M/yyyy"></DateInput>
                    </telerik:RadDatePicker>
                    <%--<asp:TextBox runat="server" ID="txtFromDate" ClientIDMode="Static" onblur="ValidateDate(this)"></asp:TextBox>--%>
                 <asp:RequiredFieldValidator ID="rfvdpStartDate" runat="server" ControlToValidate="dpStartDate" ErrorMessage="*Required" ValidationGroup="feereport" ForeColor="red"></asp:RequiredFieldValidator>
                 
  
           </div>
            
               
                
           <div class="col-md-4">
               
               <asp:Label ID="Label2" runat="server"><b>End Date</b></asp:Label> 

                    <telerik:RadDatePicker ID="dpEndDate" runat="server" Width="229px" Culture="en-US" Skin="Silk"
                        MaxDate="3000-01-01" MinDate="1000-01-01" ShowPopupOnFocus="True" AutoPostBack="False">
                        <DateInput runat="server" DateFormat="d/M/yyyy"></DateInput>
                    </telerik:RadDatePicker>
                    <%-- <asp:TextBox runat="server" ID="txtToDate" ClientIDMode="Static" onblur="ValidateDate(this)"></asp:TextBox>--%>
 <asp:RequiredFieldValidator ID="rfvdpEndDate" runat="server" ControlToValidate="dpEndDate" ErrorMessage="*Required" ValidationGroup="feereport" ForeColor="red"></asp:RequiredFieldValidator>
                
           </div>
                   

       </div>
                  <br/><br/> <br/>                   
        <div class="row" style="float: right">
            <asp:Button ID="btnShow" runat="server" Text="Show Report" CssClass="saveButton"
                        ValidationGroup ="feereport" OnClick="btnShow_Click" Width="148px" />
            
        </div>
                    
               
        <br/>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>

                <telerik:ReportViewer ID="ReportViewer1" runat="server" Height="500px" Width="100%" ViewMode="PrintPreview"></telerik:ReportViewer>

            </ContentTemplate>

        </asp:UpdatePanel>
  
        </div>
                                    </div>
                           </div>
                     </div>
</asp:Content>
