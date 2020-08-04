<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="StudentListUI.aspx.cs" Inherits="InovexiaEBS.SchoolManagement.form" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
     <%--<link href="../css/bootstrap.min.css" rel="stylesheet" />--%>
    <style type="text/css">
        .gridbtnCustomCss {
            padding: 0 0 0 2px !important;
        }
    </style>

    <script language="javascript">


        function ValidationMessage(message) {
            //alertify.alert('Please provide all data with red star!');

            alertify.alert(message);
        }



        function UserDeleteConfirmation() {
            if (confirm("Are you sure you want to delete ?"))
                return true;
            else
                return false;
        }

        function NotNegativeNumberKey(evt) {
            evt = (evt) ? evt : window.event;
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                return false;
            }
            return true;
        }

        function checkDec(el) {
            var ex = /^[0-9]+\.?[0-9]*$/;
            if (ex.test(el.value) == false) {
                el.value = el.value.substring(0, el.value.length - 1);
            }
        }

    </script>


    <style>
        .widthClass {
            width: 100%;
        }

                        table {
                  font-family: arial, sans-serif;
                  border-collapse: collapse;
                  width: 100%;
                }

                td, th {
                  border: 1px solid #dddddd;
                  text-align: center;
                  padding: 8px;
                }

                tr:nth-child(even) {
                  background-color: white;
                }

                 th {
                     background-color: #ff3333;
                      color: white;
                    }

                 float-right {
                     text-align: right;
                 }
    </style>
    

    
    <div class="row" id="studentlistPanelmaster" runat="server" style="font-family: serif">
        <div class="col-lg-12">
            <div class="breadcrumb fontcolordiv" style="background-color: #b3b3b3"  >
                                                    <li class="breadcrumb-item" ><a href="#">Home</a></li>
                                                    <li class="breadcrumb-item"><a href="#">Student</a></li>
                                                    <li class="breadcrumb-item"><a href="#">Student List</a></li>
                                                 
                                                    <%--<li class="breadcrumb-item active">Student Details</li>--%>
                   </div>
     
    
   <%-- <div runat="server" id="filterbutton" class="fc-button-group">
    <asp:Button ID="btnfiltersave" CssClass="btn btn-warning" runat="server" CausesValidation="False" Text="Save Filter" 
                                        OnClick="btnfiltersave_click" />
    <asp:Button ID="btnfilterload" CssClass="btn btn-warning" runat="server" CausesValidation="False" Text="Load Filter" 
                                        OnClick="btnfilterload_click" />
   
        
        </div>--%>
    
    <%--<div class="row" id="searchlist" runat="server">
        <div class="col-lg-12">
            
            </div>
                
            </div>--%>
    
    

    <div class="row" id="studentlistPanel" runat="server">
        <div class="col-lg-12">
            <div class="card">
                <%--<div class="card-heading">
                   
                    <h2 style="font-family: fantasy">Manage Students </h2>
               </div>--%>
                
               

             <%--<div class="card" style="background-color: #ffe6cc">
                <div class="card-heading">
                    <h1  class="card-title" style="font-family: fantasy">Filter Students </h1>
                    </div>
                <br/>
               
                <div class="card-body row" >
                    
                    <div class="col-md-3">
                    <asp:TextBox ID="txtfilterID" runat="server" CssClass="form-control"  SetFocusOnError="True" placeholder="Search with StudentID" ></asp:TextBox>
                    </div>

                      <div class="col-md-3">
                    <asp:TextBox ID="txtfiltername" runat="server" CssClass="form-control"  SetFocusOnError="True" placeholder="Search with Student Name" ></asp:TextBox>
                    </div>

                    <div class="col-md-3">
                     <telerik:RadComboBox ID="ddlfilterbatch"  runat="server" DropDownCssClass="widthClass"  
                                EmptyMessage="Search with Batch" EnableLoadOnDemand="True" Filter="Contains" Height="200px"
                                HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                AutoPostBack="False" OnItemsRequested="ddlfilterbatch_ItemsRequested">
                                <ItemTemplate>
                            <table cellpadding="0" cellspacing="0">
                            <tr>

                            <td><%# DataBinder.Eval(Container, "Attributes['BatchName']")%></td>

                            </tr>
                        </table>
                    </ItemTemplate> 
                            </telerik:RadComboBox>
                      </div>
                    <div class="col-md-3">
                    <div class=" pull-right">
                        
                        <asp:Button ID="btnfilterapply" CssClass="btn btn-warning" runat="server" CausesValidation="False" Text="Apply" 
                                        OnClick="btnfilterapply_click" />
                        
                    
                     <asp:Button ID="btnfilterclear" CssClass="btn btn-warning" runat="server" CausesValidation="False" Text="Clear All" 
                                        OnClick="btnfilterclear_click" />
                         
                      </div>
                        </div>

                </div>
                </div>--%>
               <div class="card-body" >
                     <%--<div >
                    <asp:Button ID="btnaddstu" CssClass="btn btn-warning pull-left" runat="server" CausesValidation="False" Text="ADD Student" />
                    <asp:Button ID="btnpdflist" CssClass="btn btn-danger pull-right" runat="server" CausesValidation="False" Text="Generate PDF" />
                        
                     </div>--%>
                    
                    <h3 style="font-family: fantasy">Student List</h3>
                    
                    <br/>
                  
                           <asp:GridView ID="grdstulist" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-bordered dataTable"  Width="100%" 
                               AllowPaging="true" OnPageIndexChanging="pagerstulistgrd"
                                        PageSize="30" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                             <asp:BoundField DataField="StudentID" HeaderText="Student ID" ItemStyle-Width="50"  >
                            <ItemStyle Width="70px" ></ItemStyle>
                            </asp:BoundField>
                          
                                <asp:TemplateField HeaderText="Student Name">
                                    <ItemTemplate>
                                        <asp:HyperLink   runat="server" 
                                            Text='<%# DataBinder.Eval(Container.DataItem, "Name") %>'
                                            NavigateUrl='<%# "otherpage.aspx?id=" + DataBinder.Eval(Container.DataItem, "StudentID").ToString() %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                           
                            <asp:BoundField DataField="AdmissionNo" HeaderText="Admission No" ItemStyle-Width="60" >
                            <ItemStyle Width="60px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="GenderName" HeaderText="Gender" ItemStyle-Width="50" >
                            <ItemStyle Width="80px"></ItemStyle>
                            </asp:BoundField>
                       
                     <asp:TemplateField HeaderText="Action">
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                     Text="View" CausesValidation="False" ItemStyle-Width="55" OnClick="btneditstudent_click" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <%--<asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                     Text="View" ItemStyle-Width="55" CausesValidation="False" OnClick="btndeletestudent_click"> Delete </asp:LinkButton>--%>
                                
                                 <asp:LinkButton  runat="server" CssClass="btn btn-dark pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" OnClick="BtnProfile" > Profile </asp:LinkButton>

                            </ItemTemplate>
                        </asp:TemplateField>

                        </Columns>
                    </asp:GridView>
                  
                    <asp:GridView ID="grdIDfilter" runat="server" AutoGenerateColumns="False"
                        CssClass="table" Width="100%" EmptyDataText="No record matched your search!" >
                        <HeaderStyle CssClass="gridViewHeader" />
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                             <asp:BoundField DataField="StudentID" HeaderText="Student ID" ItemStyle-Width="50" >
                            <ItemStyle Width="70px" ></ItemStyle>
                            </asp:BoundField>
                            
                            <asp:BoundField DataField="Name" HeaderText="Student Name" ItemStyle-Width="200" >
                            <ItemStyle Width="300px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="AdmissionNo" HeaderText="Admission No" ItemStyle-Width="60" >
                            <ItemStyle Width="60px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="GenderName" HeaderText="Gender" ItemStyle-Width="50" >
                            <ItemStyle Width="80px"></ItemStyle>
                            </asp:BoundField>
                       
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                     Text="View" CausesValidation="False" ItemStyle-Width="55" OnClick="btneditstudent_click" > Edit </asp:LinkButton>
                                &nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                     Text="View" ItemStyle-Width="55" CausesValidation="False" OnClick="btndeletestudent_click"> Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>

                        </Columns>
                    </asp:GridView>
                    <asp:GridView ID="grdNamefilter" runat="server" AutoGenerateColumns="False"
                        CssClass="table" Width="100%" EmptyDataText="No record matched your search!" >
                        <HeaderStyle CssClass="gridViewHeader" />
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                             <asp:BoundField DataField="StudentID" HeaderText="Student ID" ItemStyle-Width="50" >
                            <ItemStyle Width="70px" ></ItemStyle>
                            </asp:BoundField>
                            
                            <asp:BoundField DataField="Name" HeaderText="Student Name" ItemStyle-Width="200" >
                            <ItemStyle Width="300px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="AdmissionNo" HeaderText="Admission No" ItemStyle-Width="60" >
                            <ItemStyle Width="60px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="GenderName" HeaderText="Gender" ItemStyle-Width="50" >
                            <ItemStyle Width="80px"></ItemStyle>
                            </asp:BoundField>
                       
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                     Text="View" CausesValidation="False" ItemStyle-Width="55" OnClick="btneditstudent_click" > Edit </asp:LinkButton>
                                &nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                     Text="View" ItemStyle-Width="55" CausesValidation="False" OnClick="btndeletestudent_click"> Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>

                        </Columns>
                    </asp:GridView>
                    
                       <asp:GridView ID="grdbatchfilter" runat="server" AutoGenerateColumns="False"
                        CssClass="table" Width="100%" EmptyDataText="No record matched your search!" >
                        <HeaderStyle CssClass="gridViewHeader" />
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                             <asp:BoundField DataField="StudentID" HeaderText="Student ID" ItemStyle-Width="50" >
                            <ItemStyle Width="70px" ></ItemStyle>
                            </asp:BoundField>
                            
                            <asp:BoundField DataField="Name" HeaderText="Student Name" ItemStyle-Width="200" >
                            <ItemStyle Width="300px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="AdmissionNo" HeaderText="Admission No" ItemStyle-Width="60" >
                            <ItemStyle Width="60px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="GenderName" HeaderText="Gender" ItemStyle-Width="50" >
                            <ItemStyle Width="80px"></ItemStyle>
                            </asp:BoundField>
                       
                     <asp:TemplateField>
                            <ItemTemplate  >
                              
                             <asp:LinkButton runat="server" CssClass="btn btn-warning" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                     CausesValidation="False" ItemStyle-Width="55" OnClick="btneditstudent_click" > Edit </asp:LinkButton>
                                &nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                     ItemStyle-Width="55" CausesValidation="False" OnClick="btndeletestudent_click"> Delete </asp:LinkButton>
                                 
                               
                                

                            </ItemTemplate>
                        </asp:TemplateField>

                        </Columns>
                    </asp:GridView>
                       
                         </div> 
                        </div>

                    </div>
            </div>
            
            
        
            </div>
    </div>



</asp:Content>
