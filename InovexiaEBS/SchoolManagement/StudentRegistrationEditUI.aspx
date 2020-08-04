<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="StudentRegistrationEditUI.aspx.cs" Inherits="InovexiaEBS.SchoolManagement.StudentRegistrationEditUI" %>

 <asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
     <link href="../css/bootstrap.css" rel="stylesheet" />   
    
                <%--     <style type="text/css">
                        .gridbtnCustomCss {
                            padding: 0 0 0 2px !important;
                        }
                    </style>--%>
                    <%-- <style>
                        .widthClass {
                            width: 100%;
                        }
                    </style>--%>
                    <style>
                        .fontcolordiv {
                            color: white;
                            font-family: fantasy;
            
                        }

                        .divColorb {
                            background-color:  #e6e6ff;
                            /*color: grey;*/
                        }
                    </style>
                    <%-- <style>
                    .divblue {
                        
                        background-color: lightblue;
                        background-size: initial;
                        
                    }
                         </style>--%>
                    <style>
                        .errortxtbox {
                            /*background-color: red;*/
                            border-color: red;
                            /*box-shadow: red;*/
                        }
                    </style>
                    <style>
                        .radioClass {
                                  /*width: 40px;
                                  height: 45px;
                                  padding: 0 10px;*/
                                  color:#000080;
                                }

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
                  background-color: #f5f5f0;
                }

                 th {
                     background-color:#e6f2ff;
                      color:#6666ff;
                    }

                 float-right {
                     text-align: right;
                 }

                 .gridheader {
                     font-family: cursive;
                     color: #1a1aff;
                 }
                    
                    
                    .pagination-ys {
                            /*display: inline-block; */
                            padding-left: 0;
                            margin: 20px 0;
                            border-radius: 4px;
                        }

                        .pagination-ys table > tbody > tr > td {
                            display: inline;
                        }

                        .pagination-ys table > tbody > tr > td > a,
                        .pagination-ys table > tbody > tr > td > span {
                            position: relative;
                            float: left;
                            padding: 8px 12px;
                            line-height: 1.42857143;
                            text-decoration: none;
                            color: #1a1aff;
                            background-color: #ffffff;
                            border: 1px solid #dddddd;
                            margin-left: -1px;
                        }

                        .pagination-ys table > tbody > tr > td > span {
                            position: relative;
                            float: left;
                            padding: 8px 12px;
                            line-height: 1.42857143;
                            text-decoration: none;    
                            margin-left: -1px;
                            z-index: 2;
                            color: #aea79f;
                            background-color: #f5f5f5;
                            border-color: #dddddd;
                            cursor: default;
                        }

                        .pagination-ys table > tbody > tr > td:first-child > a,
                        .pagination-ys table > tbody > tr > td:first-child > span {
                            margin-left: 0;
                            border-bottom-left-radius: 4px;
                            border-top-left-radius: 4px;
                        }

                        .pagination-ys table > tbody > tr > td:last-child > a,
                        .pagination-ys table > tbody > tr > td:last-child > span {
                            border-bottom-right-radius: 4px;
                            border-top-right-radius: 4px;
                        }

                            .pagination-ys table > tbody > tr > td > a:hover,
                            .pagination-ys table > tbody > tr > td > span:hover,
                            .pagination-ys table > tbody > tr > td > a:focus,
                            .pagination-ys table > tbody > tr > td > span:focus {
                                color: #97310e;
                                background-color: #eeeeee;
                                border-color: #dddddd;
                            }
                        

                        </style>
                   
                        
   
     
      <asp:Updatepanel runat="server">
       <ContentTemplate>
  <%-- <div id="messages" class="notify notify-messages">
       <div class="note note-15">
           <button type="button" class="remove">
               <i class="icon-times">
                   
               </i>
           </button>
           <div class="content">
               <strong class="title">Successful!</strong>
               "Student Details Saved Successfully!"
           </div>
       </div>
       
   </div> --%>
   
                                  
        <div class="row" id="MasterPanel" runat="server" >
             <div class="col-lg-12">
                

                                        <div id="divmainbody"  class="col-mg-10" style="font-family: serif">
                                           
                                              <%--  <h2 style="font-family: monospace">Enrolment</h2>
                                                     <br/>--%>
                                                        <ul class="nav nav-tabs" id="myTab" role="tablist">
                                                            
                                                            <li class="nav-item">
                                                                <a class="nav-link active" id="tabStudentDetails" runat="server" href="#divStudentDetails" data-toggle="tab" role="tab" aria-controls="divStudentDetails"
                                                                     aria-selected="True"><b>Student Details</b></a>
                                                            </li>

                                                            <li class="nav-item">
                                                                <a  class="nav-link" id="tabGuardianDetails" runat="server" href="#GuardianDetails" data-toggle="tab" role="tab"
                                                                     aria-controls="GuardianDetails"
                                                                     aria-selected="False"><b>Guardian Details</b></a>
                                                            </li>

                                                            <li  class="nav-item" >
                                                                <a  class="nav-link" id="tabEmergencyContact" runat="server"  href="#EmergencyContact"  data-toggle="tab" role="tab" 
                                                                    aria-controls="EmergencyContact"
                                                                    aria-selected="False"><b>Emergency Contact</b></a>
                                                            </li>
                                                            
                                                            <li class="nav-item" >
                                                                <a   class="nav-link" id="tabPreviousDetails" runat="server"  href="#PreviousDetails"  data-toggle="tab" role="tab"
                                                                     aria-controls="PreviousDetails"
                                                                     aria-selected="False"><b>Previous Details</b></a>
                                                            </li>
                                                             <li class="nav-item" >
                                                                 <a  class="nav-link" id="tabStudentDocuments" runat="server"  href="#StudentDocuments"  data-toggle="tab" role="tab"
                                                                      aria-controls="StudentDocuments"
                                                                     aria-selected="False" ><b>Student Documents</b></a>
                                                            </li>

                                                              <li class="nav-item">
                                                                <a  class="nav-link" id="tabadditionaldetais"  href="#additionaldetails" data-toggle="tab"role="tab" 
                                                                    aria-controls="additionaldetails"
                                                                     aria-selected="False"><b>Additional Details</b></a>
                                                            </li>
                                                           

                                                          
                                                        </ul>
                                                
                                              
                                         
                                            
    
      <br /><br />
                  
                                  <div id="myTabContent" class="tab-content" runat="server"  >
                                      
                                      
                                      <%-- -------------------------------Student------------------------ --%>
                                
                                        <div id="divStudentDetails" class="tab-pane active" >
                                                    
                                            <div>
                                               
                                                Fields with<span style="color: red">*</span> are required
                                            </div>
                                            <br/>

                                           <div class="row " id="divdate" runat="server"  >
                                                <div class="col-lg-12">
                                                    <div class="card">
           
                                                        <div class="card-body" style="background-color:#d9d9d9">
                                                            
                                                <br/>
                                                            <div class="form-row">
                                                                
                                                            
                                                   <div class="col-md-6" >
                                                  <div style="float:left; padding-top: 6px">
                                                       <asp:Label  CssClass="icol-text-align-left" ID="Label14" runat="server" Text="Admission Number"  
                                                           Font-Bold="true"  ></asp:Label>
                                                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                                  </div>  
                                                   
                                                 <div style="float:left">
                                                    <asp:TextBox ID="txtadmsnnum" runat="server" CssClass="form-control" ReadOnly="True" Width="290px"
                                                        Placeholder="AutoGenerated" ></asp:TextBox>
                                                   
                                                     
                                                    <br/>
                                                    <br/>
                                                </div>
                                                </div>
                                             
                                                   <div class="col-md-6">
                                                    <div style="float:left; padding-top: 6px">
                                                    <asp:Label ID="Label15" runat="server" Text="Admission Date"  Font-Bold="true" ></asp:Label>
                                                     <span style="color: red">*</span>
                                                        &nbsp;
                                                        &nbsp;
                                                        </div>
                                                     
                                                    <div style="float:left; padding-top: 3px">
                                                         <telerik:RadDatePicker ID="ddladmsndate" Class="form-control" runat="server" AutoPostBack="false" Culture="en-US"  
                                                               MaxDate="3000-01-01" MinDate="1000-01-01" ShowPopupOnFocus="True" Style="background-color: #FFFFFF; font-weight: 700; 
                                                              color: #FF0000;" Width="300px">
                                                                <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" runat="server" SelectedDate=""  SelectionMode="Day" 
                                                                   ShowLines="True">
                                                                                         
                                                                                </Calendar>
                                                                                <DateInput AutoPostBack="false" DateFormat="d/MM/yyyy" DisplayDateFormat="d/MM/yyyy" LabelWidth="40%" runat="server">
                                                                                </DateInput>
                                                                           
                                                           </telerik:RadDatePicker>
                                                        <asp:RequiredFieldValidator ID="rfvtxtadmsndate" ControlToValidate="ddladmsndate" runat="server" ForeColor="red" 
                                                            ErrorMessage="*Required" ValidationGroup="validateSP" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                    <br/>
                                                    <br/>
                                                     </div>
                                                    </div>
                                                
                                               
</div>
                                                 
                                                            
                                                                                 
                                                         </div>
                                                    </div>
                                                </div>
                                              </div>
                                           

                                            <br/>
                                           
                                  

                                           <div class="row " id="divpdetails" runat="server" >
                                                                     <div class="col-lg-12">
                                                                         <div class="card">
           
                                                                             <div class="card-body divColorb">
                                                                    <br/>
                                                                                 
                                                                        <h4 style="font-family: fantasy"> Personal Details</h4>
                                                                           <div class="dropdown-divider"></div>
                                                                                 <br/>
                                                                             <br/>
                                  
                                                                        <div class="form-row">
                                                                            
                                                                              <div class="col-md-4" >
                                                                                <asp:Label ID="Label1" runat="server" Text="First Name"  Font-Bold="true" ></asp:Label>
                                                                                 <span style="color: red">*</span>
                                                                                <br/>
                                                                                <asp:TextBox ID="txtfn" runat="server" CssClass="form-control" Width="312px"></asp:TextBox>
                                                                            
                                                                               <asp:RequiredFieldValidator ID="rfvtxtfn" ControlToValidate="txtfn" runat="server" ForeColor="red" ErrorMessage="Required" ValidationGroup=""  SetFocusOnError="True"></asp:requiredfieldvalidator>
                                                                            
                                                                            <br/>
                                                                            <br/>
                                              
                                                                        </div>
                                                                        <div class="col-md-4" >
                                                                                <asp:Label ID="Label2" runat="server" Text="Middle Name"  Font-Bold="true"></asp:Label>
                                                                                
                                                                                <br/>
                                                                                <asp:TextBox ID="txtmdln" runat="server" CssClass="form-control" Width="314px"></asp:TextBox>
                                                                            <br/>
                                                                            <br/>
                                               
                                                                         </div>
                                                                        <div class="col-md-4" >
                                                                                <asp:Label ID="Label3" runat="server" Text="Last Name"  Font-Bold="true" Width="312px"></asp:Label>
                                                                                <span style="color: red">*</span>
                                                                                    <br/>
                                                                                <asp:TextBox ID="txtln" runat="server" CssClass="form-control" SetFocusOnError="True"></asp:TextBox>
                                                                                
                                                                            
                                                                             <asp:RequiredFieldValidator ID="rfv" ControlToValidate="txtln"  runat="server" SetFocusOnError="True" CssClass="error" ForeColor="red" ErrorMessage="Required" ValidationGroup=""  ></asp:RequiredFieldValidator>  
                                                                            <br/>
                                                                            <br/>
                                                
                                                                        </div>

                                                                        </div>
                                                                        <div class="row">
                                                                          
                                                                           <div class="col-md-4" >
                                                                                <asp:Label ID="Label4" runat="server" Text="Student ID"  Font-Bold="true"></asp:Label>
                                                                                <br/>
                                                                                <asp:TextBox ID="txtstuid" runat="server" CssClass="form-control"></asp:TextBox>
                                                                        <br/>
                                                                        <br/>
                                            
                                                                        </div>
                                                                        <div class="col-md-4" >
                                                                                <asp:Label ID="Label5" runat="server" Text="Batch"  Font-Bold="true"></asp:Label>
                                                                                <br/>
                                                                                 <telerik:RadComboBox ID="ddlbatch"  runat="server" DropDownCssClass="widthClass"  
                                                                                     EmptyMessage="Select Batch" EnableLoadOnDemand="True" Filter="Contains" Height="200px"
                                                                                      HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                                                      AutoPostBack="False" OnItemsRequested="ddlbatch_ItemsRequested">
                                                                                      <ItemTemplate>
                                                                                    <table cellpadding="0" cellspacing="0">
                                                                                    <tr>

                                                                                    <td><%# DataBinder.Eval(Container, "Attributes['BatchName']")%></td>

                                                                                    </tr>
                                                                                </table>
                                                                            </ItemTemplate> 
                                                                                 </telerik:RadComboBox>
                                                                            <br/>
                                                                            <br/>
                                               
                                                                            </div>
                                                                        <div class="col-md-4" >
                                                                                <asp:Label ID="Label6" runat="server" Text="Date Of Birth"  Font-Bold="true"></asp:Label>
                                                                                <span style="color: red">*</span>
                                                                                    <br/>
                                                                                <%--<asp:TextBox ID="txts" runat="server" CssClass="form-control" SetFocusOnError="True" TextMode="Date"></asp:TextBox>--%>
                                                                           <%-- <telerik:RadDatePicker ID="RadDatePicker1" runat="server" CssClass="form-control" AutoPostBack="False" Culture="en-US"></telerik:RadDatePicker>--%>
                                                                            
                                                                            <telerik:RadDatePicker ID="DateOfBirthS" Class="form-control" runat="server" AutoPostBack="false" Culture="en-US"  
                                                                                MaxDate="3000-01-01" MinDate="1000-01-01" ShowPopupOnFocus="True" Style="background-color: #FFFFFF; font-weight: 700; 
                                                                                
                                                                                    color: #FF0000;" Width="300px">
                                                                                <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" runat="server" SelectedDate=""  SelectionMode="Day" 
                                                                                          ShowLines="True">
                                                                                         
                                                                                                 <%--OnSelectionChanged="Selection_Change"--%>                                                                       
 
                                                                                            <%-- <SelectedDayStyle BackColor="Yellow"
                                                                                                               ForeColor="Red">
                                                                                             </SelectedDayStyle>--%>
                                                                                </Calendar>
                                                                                <DateInput AutoPostBack="false" DateFormat="d/MM/yyyy" DisplayDateFormat="d/MM/yyyy" LabelWidth="40%" runat="server">
                                                                                </DateInput>
                                                                                <%--<DatePopupButton HoverImageUrl="" ImageUrl="" />--%>
                                                                             </telerik:RadDatePicker>

                                                                            <asp:RequiredFieldValidator ID="rfvDateOfBirthS" runat="server" ControlToValidate="DateOfBirthS" 
                                                                                ValidationGroup="validateSP" ErrorMessage="*Required" ForeColor="red"></asp:RequiredFieldValidator>
                                                                            <br/>
                                                                            
                                                                            <br/>
                                               
                                                                        </div>
                                                                      </div>      
                                                                        <div class="row">
                                                                                      <div class="col-md-4" >
                                                                                <asp:Label ID="Label7" runat="server" Text="Gender"  Font-Bold="true"></asp:Label>
                                                                                <span style="color: red">*</span>
                                                                                <br/>
                                                                              <telerik:RadComboBox ID="ddlgender"  runat="server" DropDownCssClass="widthClass" SetFocusOnError="True"
                                                                                   EmptyMessage="Select Gender" EnableLoadOnDemand="True" Filter="Contains" Height="200px" HighlightTemplatedItems="True"
                                                                                   Width="100%" Skin="Silk" Style="background-color: #339966;" AutoPostBack="False" AppendDataBoundItems="True"
                                                                                  OnItemsRequested="ddlgender_ItemsRequested">
                                  
                                                                                   <ItemTemplate>
                                                                                    <table cellpadding="0" cellspacing="0">
                                                                                    <tr>

                                                                                    <td><%# DataBinder.Eval(Container, "Attributes['GenderName']")%></td>

                                                                                    </tr>
                                                                                </table>
                                                                            </ItemTemplate> 
                                                                              
                                                                              </telerik:RadComboBox>
                                                                                  
                                                                        <br/>
                                                                        <br/>
                                            
                                                                        </div>
                                                                        <div class="col-md-4">
                                                                                <asp:Label ID="Label8" runat="server" Text="Blood"  Font-Bold="true"></asp:Label>
                                                                                <br/>
                                                                                <telerik:RadComboBox ID="ddlblood"  runat="server" DropDownCssClass="widthClass"  
                                                                                    EmptyMessage="Select BloodGroup" EnableLoadOnDemand="True" Filter="Contains" Height="200px"
                                                                                     HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;" 
                                                                                    OnItemsRequested="ddlblood_ItemsRequested"
                                                                                    AutoPostBack="False">
                                                                                    <ItemTemplate>
                                                                                    <table cellpadding="0" cellspacing="0">
                                                                                    <tr>

                                                                                    <td><%# DataBinder.Eval(Container, "Attributes['BloodgroupName']")%></td>

                                                                                    </tr>
                                                                                </table>
                                                                            </ItemTemplate> 
                                                                                    

                                                                                </telerik:RadComboBox>
                                                                            <br/>
                                                                            <br/>
                                               
                                                                            </div>
                                                                        <div class="col-md-4">
                                                                                <asp:Label ID="Label9" runat="server" Text="Birth Place"  Font-Bold="true"></asp:Label>
                                                                                    <br/>
                                                                                <asp:TextBox ID="txtbirthplace" runat="server" CssClass="form-control"></asp:TextBox>
                                                                            <br/>
                                                                            <br/>
                                                                        </div>

                                                                                 </div>
                                                                        <div class="row">
                                                                                      <div class="col-md-4">
                                                                                <asp:Label ID="Label10" runat="server" Text="Nationality"  Font-Bold="true"></asp:Label>
                                                                                <span style="color: red">*</span>
                                                                                <br/>
                                                                                 <telerik:RadComboBox ID="ddlnationality"  runat="server" DropDownCssClass="widthClass"  
                                                                                     OnItemsRequested="ddlnationality_ItemsRequested"
                                                                                     EmptyMessage="Select Nationality" EnableLoadOnDemand="True" Filter="Contains" Height="200px"
                                                                                      HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                                                      AutoPostBack="False" SetFocusOnError="True">
                                                                                     
                                                                                     <ItemTemplate>
                                                                                    <table cellpadding="0" cellspacing="0">
                                                                                    <tr>

                                                                                    <td><%# DataBinder.Eval(Container, "Attributes['NationalityName']")%></td>

                                                                                    </tr>
                                                                                </table>
                                                                            </ItemTemplate>
                                                                                 </telerik:RadComboBox>
                                                                        <br/>
                                                                            <br/>
                                                                        </div>
                                                                        <div class="col-md-4">
                                                                                <asp:Label ID="Label11" runat="server" Text="Language"  Font-Bold="true"></asp:Label>
                                                                                <br/>
                                                                                <asp:TextBox ID="txtlang" runat="server" CssClass="form-control"></asp:TextBox>
                                                                            <br/>
                                                                            <br/>
                                                                         </div>
                                                                        <div class="col-md-4">
                                                                                <asp:Label ID="Label12" runat="server" Text="Religion"  Font-Bold="true"></asp:Label>
                                                                                    <br/>
                                                                                <asp:TextBox ID="txtreli" runat="server" CssClass="form-control"></asp:TextBox>
                                                                            <br/>
                                                                            <br/>
                                                                        </div>
                                                                                 </div>
                                                                       <div class="form-row">
                                                                        <div class="col-md-4">
                                                                                <asp:Label ID="Label13" runat="server" Text="Student Category"  Font-Bold="true"></asp:Label>
                                                                                    <br/>
                                                                                 <telerik:RadComboBox ID="ddlstucat"  runat="server" DropDownCssClass="widthClass"  
                                                                                     EmptyMessage="Select Batch" EnableLoadOnDemand="True" Filter="Contains" Height="200px" 
                                                                                     HighlightTemplatedItems="True" Width="316px" Skin="Silk" Style="background-color: #339966;" 
                                                                                     AutoPostBack="False" SetFocusOnError="True" OnItemsRequested="ddlstucat_ItemsRequested">
                                                                                     
                                                                                      <ItemTemplate>
                                                                                    <table cellpadding="0" cellspacing="0">
                                                                                    <tr>

                                                                                    <td><%# DataBinder.Eval(Container, "Attributes['StudentCategoryName']")%></td>

                                                                                    </tr>
                                                                                </table>
                                                                            </ItemTemplate>
                                                                
                                                                                 </telerik:RadComboBox> 
                                                                        <br/>
                                                                            <br/>
                                                                        </div>
                                                                           
                                                                           </div>
                                      
                                                                        <br/>
                                                                        <br/> 
                             
                                                            </div>
                                                     
                                                                         </div>
                                                                     </div>
                                                                  </div>
                                                               
                                                               <br/>
                                                     
                                           <div class="row" id="divcondetails" runat="server" >
                                     <div class="col-lg-12">
                                         <div class="card">
                                             <div class="card-body divColorb">
                                                     <h4 style="font-family: fantasy"> Contact Details</h4>
                                                         <div class="list-divider"></div>
                                                                            
                                                                             <br/> 
                                                 
                                                 <div class="row">

                                                    <div class="col-md-4">
                                                            <asp:Label ID="Label16" runat="server" Text="Current Address"  Font-Bold="true"></asp:Label>
                                                                <br/>
                                                            <asp:TextBox ID="txtcadds" runat="server" CssClass="form-control"></asp:TextBox>
                                                        <br/>
                                                        <br/>
                                                    </div>
                                                 
                                                     <div class="col-md-4">
                                                                <asp:Label ID="Label17" runat="server" Text="Permanent Address"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtpadds" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                            <br/>
                                                        </div>
                                                 
                                                     <div class="col-md-4">
                                                                <asp:Label ID="Label18" runat="server" Text="City"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtcitys" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                            <br/>
                                                        </div>
                                                     
                                                     
                                                     </div>
                                                     
                                                     <div class="row">
                                                     
                                                 
                                                     <div class="col-md-4">
                                                                <asp:Label ID="Label19" runat="server" Text="State"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtstates" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                            <br/>
                                                        </div>
                                                 
                                                     <div class="col-md-4">
                                                                <asp:Label ID="Label20" runat="server" Text="Pin Code"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtpins" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                            <br/>
                                                        </div>
                                                 
                                                     <div class="col-md-4">
                                                                <asp:Label ID="Label21" runat="server" Text="Country"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <telerik:RadComboBox ID="ddlstucountry" AutoPostBack="False" DropDownCssClass="widthClass" EmptyMessage="Select Country"
                                                                     EnableLoadOnDemand="True" 
                                                                    Filter="Contains" Height="200px" HighlightTemplatedItems="True" 
                                                                     OnItemsRequested="ddlstucountry_ItemsRequested" runat="server" Skin="Silk" 
                                                                    Style="background-color: #339966;" Width="100%">
                                                                         <ItemTemplate>
                                                                                 <table cellpadding="0" cellspacing="0">
                                                                                        <tr>

                                                                                         <td><%# DataBinder.Eval(Container, "Attributes['CountryName']")%></td>

                                                                                        </tr>
                                                                                    </table>
                                                                         </ItemTemplate> 
                                                                     </telerik:RadComboBox>
                                                            <br/>
                                                            <br/>
                                                        </div>
                                                     
                                                     
                                                     </div>
                                                 
                                                 <div class="row">
                                                 
                                                     <div class="col-md-4">
                                                                <asp:Label ID="Label22" runat="server" Text="Phone Number"  Font-Bold="true"></asp:Label>
                                                                <span style="color: red">*</span>
                                                                    <br/>
                                                                <asp:TextBox ID="txtphones" runat="server" CssClass="form-control" SetFocusOnError="True"></asp:TextBox>
                                                            <br/>
                                                            <br/>
                                                        </div>
                                                 
                                                     <div class="col-md-4">
                                                                <asp:Label ID="Label23" runat="server" Text="Phone Number2"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtphone2s" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                            <br/>
                                                        </div>
                                                 
                                                     <div class="col-md-4">
                                                                <asp:Label ID="Label24" runat="server" Text="Email"  Font-Bold="true"></asp:Label>
                                                                <span style="color: red">*</span>
                                                                    <br/>
                                                                <asp:TextBox ID="txtemails" runat="server" CssClass="form-control" SetFocusOnError="True"></asp:TextBox>
                                                            <br/>
                                                            <br/>
                                                      </div>
                                                     
                                                     
                                                     </div>
                                              </div>
                                          
                                       </div>
                                     </div>  
                                    </div>
                                            
                                 
                                            <br/>           
                                           <div class="row " id="divphoto" runat="server" >
                                     <div class="col-lg-12">
                                         <div class="card">
                                             <div class="card-body divColorb">
                                                     <h4 style="font-family: fantasy">Upload Photo</h4>
                                                 <div class="list-divider"></div>
                                                    <br/>
                                                   
                                                 <asp:FileUpload ID="upstuphoto" runat="server" /> 
                                                 <br/>    
                                                 Maximum file size is 1 MB.Allowed file types are jpg,gif,jpeg,png.  
                                                 
                                                
                                              </div>
                                             
                                        
                                         </div>
                                     </div>
                                 </div>
                                            
                                            
                                            
                                <div style="float: right">
                                    <%-- <asp:Button ID="btnupstudetail" CssClass="btn btn-warning" runat="server" CausesValidation="False"  Text="Update" 
                                        OnClick="Btn_UpdateStudent" />--%>
                                   <%-- <asp:Button ID="btnsavestu" CssClass="btn btn-danger" runat="server" CausesValidation="True"  Text="Save" ValidationGroup="validateSP"
                                        OnClick="btnsavestudent_click" />--%>
                                                 
                                <div style="float: right">
                                     <asp:Button ID="btnupstudetail" CssClass="btn btn-warning" runat="server" CausesValidation="False"  Text="Update" OnClick="Btn_UpdateStudent"/>
                                   
                                    
                                </div>
                                </div>
                                            <br/>
                                            <br/>
            </div>
                                      

                                                     
                                      
                                        <%-- -------------------------------Guardian------------------------ --%>

                                                     
                                        <div class="tab-pane fade" id="GuardianDetails"> 
                                            
                                           
                                                 <div>
                                                    
                                                     Fields with<span style="color: red">*</span> are required
                                                     <br/>
                                                 </div>
                                                  <br/>
                                             <div class="row " id="divfaminfo1" >
                                                                     <div class="col-lg-12">
                                                                         <div class="card">
           
                                                                             <div class="card-body divColorb">
                                                                    
                                                                        <h4 style="font-family: fantasy" >Family Information : &nbsp;Father`s</h4>
                                                                            <div class="list-divider"></div>
                                                                            <br/>
                                                                            
                                                                    <div class="row">
    
                                                                        <div class="col-md-4" >
                                                                                <asp:Label ID="Label35" runat="server" Text="Name"  Font-Bold="true" ></asp:Label>
                                                                                 <span style="color: red">*</span>
                                                                                <br/>
                                                                            <asp:TextBox ID="txtnamef" runat="server" CssClass="form-control" ></asp:TextBox>
                                                                            
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtnamef" runat="server" ForeColor="red" ErrorMessage="Required" ValidationGroup=""  SetFocusOnError="True"></asp:requiredfieldvalidator>
                                                                           
                                                                        </div>
                                                                     
                                                                        <div class="col-md-4" >
                                                                             <asp:Label ID="Label37" runat="server" Text="Nationality"  Font-Bold="true"></asp:Label>
                                                                                <span style="color: red">*</span>
                                                                                   
                                                                                <br/>
                                                                            
                                                                                 <telerik:RadComboBox ID="ddlnationalityf"  runat="server" DropDownCssClass="widthClass"  EmptyMessage="Select Nationality" EnableLoadOnDemand="True"
                                                                                      Filter="Contains" Height="200px" HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                                                      AutoPostBack="False" OnItemsRequested="ddlnationalityf_ItemsRequested">
                                                                                     <ItemTemplate>
                                                                                        <table cellpadding="0" cellspacing="0">
                                                                                            <tr>

                                                                                           <td><%# DataBinder.Eval(Container, "Attributes['NationalityName']")%></td>

                                                                                            </tr>
                                                                                        </table>
                                                                                     </ItemTemplate> 
                                                                                 </telerik:RadComboBox>
                                                                            <br/>
                                                                            <br/>    
                                                                           
                                                                        </div>
                                                                      
                                                                        <div class="col-md-4" >
                                                                                <asp:Label ID="Label46" runat="server" Text="Marital Status"  Font-Bold="true"></asp:Label>
                                                                                <span style="color: red">*</span>
                                                                                   
                                                                                <br/>
                                                                                <telerik:RadComboBox ID="ddlmaritalstatusf"  runat="server" DropDownCssClass="widthClass"  EmptyMessage="Select Marital Status" 
                                                                                       EnableLoadOnDemand="True"
                                                                                      Filter="Contains" Height="200px" HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                                                      AutoPostBack="False" OnItemsRequested="ddlmaritalstatusf_ItemsRequested">
                                                                                     <ItemTemplate>
                                                                                        <table cellpadding="0" cellspacing="0">
                                                                                            <tr>

                                                                                            <td><%# DataBinder.Eval(Container, "Attributes['ddlmaritalstatusf']")%></td>

                                                                                            </tr>
                                                                                        </table>
                                                                                     </ItemTemplate> 
                                                                                 </telerik:RadComboBox>
                                                                            <br/>
                                                                            <br/>
                                               
                                                                         </div>
                                                                       
                                                                    </div>
                                                                                 
                                                                    <div class="row">
                                                                                               
                                                                        <div class="col-md-4" >
                                                                                <asp:Label ID="Label47" runat="server" Text="Educational Qualification"  Font-Bold="true"></asp:Label>
                                                                                <br/>
                                                                                <asp:TextBox ID="txteduf" runat="server" CssClass="form-control" ></asp:TextBox>
                                                                                  
                                                                        </div>
                                  
                                                                        
                                                                        
                                                                        <div class="col-md-4">
                                                                                <asp:Label ID="Label48" runat="server" Text="Occupation"  Font-Bold="true"></asp:Label>
                                                                                <br/>
                                                                                <asp:TextBox ID="txtoccf" runat="server" CssClass="form-control" ></asp:TextBox>
                                                                            <br/>
                                                                            <br/>
                                               
                                                                            </div>
                                                                        
                                                                         <div class="col-md-4">
                                                                                <asp:Label ID="Label49" runat="server" Text="Organization"  Font-Bold="true"></asp:Label>
                                                                                <br/>
                                                                                <asp:TextBox ID="txtorgf" runat="server" CssClass="form-control" ></asp:TextBox>
                                                                            <br/>
                                                                            <br/>
                                               
                                                                           </div>
                                                                    </div>
                                                                       
                                                                    <div class="row">
                                                                      
                                                                          <div class="col-md-4">
                                                                                        <asp:Label ID="Label50" runat="server" Text="Designation"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtdesignationf" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                          </div>
                                                                           
                                                                          <div class="col-md-4">
                                                                                        <asp:Label ID="Label65" runat="server" Text="Years of Business/Service"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtserviceyearfather" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                          </div>
                                                                       
                                                                      
                                                                          <div class="col-md-4">
                                                                                        <asp:Label ID="Label67" runat="server" Text="Office Address"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtofficeaddressfather" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                            </div>
                                                                           
                                                                    </div>
                                                                       
                                                                    <div class="row">
                                                                            <div class="col-md-4">
                                                                                        <asp:Label ID="Label68" runat="server" Text="Office Telephone No"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtofficephonef" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                                </div>
                                                                           
                                                                            <div class="col-md-4">
                                                                                        <asp:Label ID="Label69" runat="server" Text="Residential Address"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtresidentialaddfather" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                            </div>
                                                                       
                                                                      
                                                                           <div class="col-md-4">
                                                                                        <asp:Label ID="Label70" runat="server" Text="Present Address"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtpreaddfather" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                           </div>
                                                                     </div>
                                                                                 
                                                                    <div class="row">
                                                                          
                                                                           <div class="col-md-4">
                                                                                        <asp:Label ID="Label71" runat="server" Text="Permanent Address"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtperaddressfather" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                            </div>
                                                                           
                                                                           <div class="col-md-4">
                                                                                        <asp:Label ID="Label72" runat="server" Text="Telephone No"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txttelephonefather" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                            </div>
                                                                       
                                                                      
                                                                           <div class="col-md-4">
                                                                                        <asp:Label ID="Label73" runat="server" Text="Mobile No"  Font-Bold="true"></asp:Label>
                                                                                        <span style="color: red">*</span>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtmobilefather" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                            </div>
                                                                           
                                                                        </div>
                                                                                 
                                                                    <div class="row">

                                                                            <div class="col-md-4">
                                                                                        <asp:Label ID="Label74" runat="server" Text="Email Address"  Font-Bold="true"></asp:Label>
                                                                                        <span style="color: red">*</span>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtemailfather" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                                </div>
                                                                           
                                                                            <div class="col-md-4">
                                                                                <br/>
                                                                                           <asp:Label ID="Label75" runat="server" Text="In residence with child:"  Font-Bold="true"></asp:Label>  &nbsp;&nbsp;&nbsp;
                                                                                <asp:RadioButton ID="rbf1" runat="server" GroupName="childresidencef1" Text="Yes" CssClass="radioClass"/> &nbsp;&nbsp;&nbsp;
                                                                                 <asp:RadioButton ID="rbf2"   runat="server" GroupName="childresidencef1" Text="No" CssClass="radioClass"/>       
                                                                            
                                                                                          <br/>
                                                                                          <br/>
                                                                            </div>
                                                                           

                                                                    </div>
                                      
                                                                        <br/>
                                                                        <br/> 
                             
                                                                              </div>
                                                     
                                                                         </div>
                                                                     </div>
                                             </div>
                                            <br/>
                                             <div class="row " id="divfaminfo2" runat="server" >
                                                                     <div class="col-lg-12">
                                                                         <div class="card">
           
                                                                             <div class="card-body divColorb">
                                                                    
                                                                        <h4 style="font-family: fantasy"> Family Informaton : (Mother`s)</h4>
                                                                             <div class="list-divider"></div>
                                                                            <br/>
                                                                            
                                                                    <div class="row">
    
                                                                        <div class="col-md-4" >
                                                                                <asp:Label ID="Label51" runat="server" Text="Name"  Font-Bold="true" ></asp:Label>
                                                                                 <span style="color: red">*</span>
                                                                                <br/>
                                                                            <asp:TextBox ID="txtnamem" runat="server" CssClass="form-control" ></asp:TextBox>
                                                                            
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtnamem" runat="server" ForeColor="red" ErrorMessage="Required" ValidationGroup=""  SetFocusOnError="True"></asp:requiredfieldvalidator>
                                                                           
                                                                        </div>
                                                                     
                                                                        <div class="col-md-4" >
                                                                             <asp:Label ID="Label52" runat="server" Text="Nationality"  Font-Bold="true"></asp:Label>
                                                                                <span style="color: red">*</span>
                                                                                   
                                                                                <br/>
                                                                            
                                                                                 <telerik:RadComboBox ID="ddlnationalitym"  runat="server" DropDownCssClass="widthClass"  EmptyMessage="Select Nationality" EnableLoadOnDemand="True"
                                                                                      Filter="Contains" Height="200px" HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                                                      AutoPostBack="False" OnItemsRequested="ddlnationalitym_ItemsRequested">
                                                                                     <ItemTemplate>
                                                                                        <table cellpadding="0" cellspacing="0">
                                                                                            <tr>

                                                                                           <td><%# DataBinder.Eval(Container, "Attributes['NationalityName']")%></td>

                                                                                            </tr>
                                                                                        </table>
                                                                                     </ItemTemplate> 
                                                                                 </telerik:RadComboBox>
                                                                            <br/>
                                                                            <br/>    
                                                                           
                                                                        </div>
                                                                      
                                                                        <div class="col-md-4" >
                                                                                <asp:Label ID="Label53" runat="server" Text="Marital Status"  Font-Bold="true"></asp:Label>
                                                                                <span style="color: red">*</span>
                                                                                   
                                                                                <br/>
                                                                                <telerik:RadComboBox ID="ddlmaritalstatusm"  runat="server" DropDownCssClass="widthClass"  EmptyMessage="Select Marital Status" EnableLoadOnDemand="True"
                                                                                      Filter="Contains" Height="200px" HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                                                      AutoPostBack="False" OnItemsRequested="ddlmaritalstatusm_ItemsRequested">
                                                                                     <ItemTemplate>
                                                                                        <table cellpadding="0" cellspacing="0">
                                                                                            <tr>

                                                                                            <td><%# DataBinder.Eval(Container, "Attributes['ddlmaritalstatusf']")%></td>

                                                                                            </tr>
                                                                                        </table>
                                                                                     </ItemTemplate> 
                                                                                 </telerik:RadComboBox>
                                                                            <br/>
                                                                            <br/>
                                               
                                                                         </div>
                                                                       
                                                                    </div>
                                                                                 
                                                                    <div class="row">
                                                                                               
                                                                        <div class="col-md-4" >
                                                                                <asp:Label ID="Label54" runat="server" Text="Educational Qualification"  Font-Bold="true"></asp:Label>
                                                                                <br/>
                                                                                <asp:TextBox ID="txtedum" runat="server" CssClass="form-control" ></asp:TextBox>
                                                                                  
                                                                        </div>
                                  
                                                                        
                                                                        
                                                                        <div class="col-md-4">
                                                                                <asp:Label ID="Label55" runat="server" Text="Occupation"  Font-Bold="true"></asp:Label>
                                                                                <br/>
                                                                                <asp:TextBox ID="txtoccm" runat="server" CssClass="form-control" ></asp:TextBox>
                                                                            <br/>
                                                                            <br/>
                                               
                                                                            </div>
                                                                        
                                                                         <div class="col-md-4">
                                                                                <asp:Label ID="Label56" runat="server" Text="Organization"  Font-Bold="true"></asp:Label>
                                                                                <br/>
                                                                                <asp:TextBox ID="txtorgm" runat="server" CssClass="form-control" ></asp:TextBox>
                                                                            <br/>
                                                                            <br/>
                                               
                                                                            </div>
                                                                    </div>
                                                                       
                                                                    <div class="row">
                                                                      
                                                                          <div class="col-md-4">
                                                                                        <asp:Label ID="Label57" runat="server" Text="Designation"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtdesignationm" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                                </div>
                                                                           
                                                                          <div class="col-md-4">
                                                                                        <asp:Label ID="Label66" runat="server" Text="Years of Business/Service"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtserviceyearm" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                            </div>
                                                                       
                                                                      
                                                                          <div class="col-md-4">
                                                                                        <asp:Label ID="Label76" runat="server" Text="Office Address"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtoffaddm" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                                </div>
                                                                           
                                                                        </div>
                                                                       
                                                                    <div class="row">
                                                                            <div class="col-md-4">
                                                                                        <asp:Label ID="Label77" runat="server" Text="Telephone No"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txttelephonem" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                                </div>
                                                                           
                                                                            <div class="col-md-4">
                                                                                        <asp:Label ID="Label78" runat="server" Text="Residential Address"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtresidencem" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                            </div>
                                                                       
                                                                      
                                                                           <div class="col-md-4">
                                                                                        <asp:Label ID="Label79" runat="server" Text="Present Address"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtpreaddm" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                                </div>
                                                                        </div>
                                                                                 
                                                                    <div class="row">
                                                                          
                                                                           <div class="col-md-4">
                                                                                        <asp:Label ID="Label80" runat="server" Text="Permanent Address"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtperaddm" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                                </div>
                                                                           
                                                                           <div class="col-md-4">
                                                                                        <asp:Label ID="Label81" runat="server" Text="Telephone No"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtofftelephonem" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                            </div>
                                                                       
                                                                      
                                                                           <div class="col-md-4">
                                                                                        <asp:Label ID="Label82" runat="server" Text="Mobile No"  Font-Bold="true"></asp:Label>
                                                                                        <span style="color: red">*</span>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtmobilem" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                                </div>
                                                                           
                                                                        </div>
                                                                                 
                                                                    <div class="row">

                                                                            <div class="col-md-4">
                                                                                        <asp:Label ID="Label83" runat="server" Text="Email Address"  Font-Bold="true"></asp:Label>
                                                                                        <span style="color: red">*</span>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtemailm" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                         
                                                                                </div>
                                                                           
                                                                            <div class="col-md-4">
                                                                                <br/>
                                                                                           <asp:Label ID="Label84" runat="server" Text="In residence with child:"  Font-Bold="true"></asp:Label>  &nbsp;&nbsp;&nbsp;
                                                                                <asp:RadioButton ID="rbm3" runat="server" GroupName="childresidencem1" Text="Yes" CssClass="radioClass"/> &nbsp;&nbsp;&nbsp;
                                                                                 <asp:RadioButton ID="rbm4"   runat="server" GroupName="childresidencem1" Text="No" CssClass="radioClass"/>       
                                                                            
                                                                                          <br/>
                                                                                          
                                                                            </div>
                                                                           

                                                                        </div>
                                                                       
                                                                        <br/> 
                             
                                                            </div>
                                                     
                                                                         </div>
                                                                     </div>
                                                                  </div>
                                            <br/>
                                             <div class="row " id="divgurinfo" runat="server" >
                                                                     <div class="col-lg-12">
                                                                         <div class="card">
           
                                                                             <div class="card-body divColorb">
                                                                    
                                                                        <h4 style="font-family: fantasy"> Guardian Information</h4>
                                                                                 (Applicable<span style="color: red">*</span>: if the child is not residing with either parent)
                                                                            <div class="list-divider"></div>
                                                                              
                                                                            <br/>
                                         
                                                                   <div class="row">
    
                                                                        <div class="col-md-4" >
                                                                                <asp:Label ID="Label58" runat="server" Text="Name"  Font-Bold="true" ></asp:Label>
                                                                                 <span style="color: red">*</span>
                                                                                <br/>
                                                                            <asp:TextBox ID="txtnameg" runat="server" CssClass="form-control" ></asp:TextBox>
                                                                            
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtnameg" runat="server" ForeColor="red" ErrorMessage="Required" ValidationGroup=""  SetFocusOnError="True"></asp:requiredfieldvalidator>
                                                                           
                                                                        </div>
                                                                     
                                                                        <div class="col-md-4" >
                                                                             <asp:Label ID="Label59" runat="server" Text="Nationality"  Font-Bold="true"></asp:Label>
                                                                                <span style="color: red">*</span>
                                                                                   
                                                                                <br/>
                                                                            
                                                                                 <telerik:RadComboBox ID="ddlnationalityg"  runat="server" DropDownCssClass="widthClass"  EmptyMessage="Select Nationality" EnableLoadOnDemand="True"
                                                                                      Filter="Contains" Height="200px" HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                                                      AutoPostBack="False" OnItemsRequested="ddlnationalityg_ItemsRequested">
                                                                                     <ItemTemplate>
                                                                                        <table cellpadding="0" cellspacing="0">
                                                                                            <tr>

                                                                                           <td><%# DataBinder.Eval(Container, "Attributes['NationalityName']")%></td>

                                                                                            </tr>
                                                                                        </table>
                                                                                     </ItemTemplate> 
                                                                                 </telerik:RadComboBox>
                                                                            <br/>
                                                                            <br/>    
                                                                           
                                                                        </div>
                                                                      
                                                                        <div class="col-md-4" >
                                                                                <asp:Label ID="Label60" runat="server" Text="Relationship with Student"  Font-Bold="true"></asp:Label>
                                                                                <span style="color: red">*</span>
                                                                                   
                                                                                <br/>
                                                                                <telerik:RadComboBox ID="ddlrelwstu"  runat="server" DropDownCssClass="widthClass"  EmptyMessage="Select Marital Status" EnableLoadOnDemand="True"
                                                                                      Filter="Contains" Height="200px" HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                                                      AutoPostBack="False" OnItemsRequested="ddlrelwstu_ItemsRequested">
                                                                                     <ItemTemplate>
                                                                                        <table cellpadding="0" cellspacing="0">
                                                                                            <tr>

                                                                                            <td><%# DataBinder.Eval(Container, "Attributes['RelationName']")%></td>

                                                                                            </tr>
                                                                                        </table>
                                                                                     </ItemTemplate> 
                                                                                 </telerik:RadComboBox>
                                                                            <br/>
                                                                           
                                               
                                                                         </div>
                                                                       
                                                                    </div>
                                                                       
                                                                    <div class="row">
                                                                           
                                                                            
                                                                            <div class="col-md-4">
                                                                                        <asp:Label ID="Label88" runat="server" Text="Residential Address"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtResAddG" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                            </div>
                                                                           
                                                                       
                                                                      
                                                                           <div class="col-md-4">
                                                                                        <asp:Label ID="Label89" runat="server" Text="Present Address"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtPreAddG" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                                </div>
                                                                        
                                                                        <div class="col-md-4">
                                                                                        <asp:Label ID="Label90" runat="server" Text="Permanent Address"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtPerAddG" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                         
                                                                                          
                                                                         </div>
                                                                        </div>
                                                                                 
                                                                    <div class="row">
                                                                          
                                                                           <div class="col-md-4">
                                                                                        <asp:Label ID="Label91" runat="server" Text="Telephone No"  Font-Bold="true"></asp:Label>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtTelG" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                            </div>
                                                                       
                                                                      
                                                                           <div class="col-md-4">
                                                                                        <asp:Label ID="Label92" runat="server" Text="Mobile No"  Font-Bold="true"></asp:Label>
                                                                                        <span style="color: red">*</span>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtMobileG" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                                </div>
                                                                        
                                                                         <div class="col-md-4">
                                                                                        <asp:Label ID="Label93" runat="server" Text="Email Address"  Font-Bold="true"></asp:Label>
                                                                                        <span style="color: red">*</span>
                                                                                            <br/>
                                                                                        <asp:TextBox ID="txtEmailG" runat="server" CssClass="form-control"></asp:TextBox>
                                                                                          <br/>
                                                                                          <br/>
                                                                                </div>
                                                                           
                                                                        </div>
                                                                         
                                                                        <br/>
                                                                       
                             
                                                            </div>
                                                     
                                                                         </div>
                                                                     </div>
                                                                  </div>
                                            
                                            
                                            
                                             <div style="float: right">
                                                 
                                              <%--   <asp:Button ID="btnupguardian" CssClass="btn btn-warning" CausesValidation="False" runat="server" Text="Update" 
                                                     OnClick="btnsaveguardian_click" />--%>
                                               <%-- <asp:Button ID="btnsaveguardian" CssClass="btn btn-danger" CausesValidation="False" runat="server" Text="Save" 
                                                     OnClick="btnsaveguardian_click" />--%>
                                                 
                                                   <asp:Button ID="btnupguardian" CssClass="btn btn-warning" CausesValidation="False" runat="server" Text="Update" 
                                                     OnClick="btn_UpdateGuardianDetails" />
                                             </div>
                                           <br/>
                                            <br/>
                                        </div>
                                      
                                      
                                        <%-- -------------------------------Emergency Contact------------------------ --%>

                                      
                                       <div class="tab-pane fade" id="EmergencyContact">
                                        
                                            
                                                 <div>
                                                    
                                                     Fields with<span style="color: red">*</span> are required
                                                     <br/>
                                                 </div>
                                                  <br/>
                                            
                                            
                                             <div class="row" id="divemergencycontact" runat="server" >
                                     <div class="col-lg-12">
                                         <div class="card">
                                             <div class="card-body divColorb">
                                                     <h4 style="font-family: fantasy">Emergency Contact</h4>
                                                
                                                         <div class="list-divider"></div>
                                                                            <br/>
                                                     <div class=" row">                    
                                                        <div class="col-md-4">
                                                            <asp:Label ID="Label42" runat="server" Text="Name"  Font-Bold="true"></asp:Label>
                                                             
                                                                <br/>
                                                            <asp:TextBox ID="txtNameE" runat="server" CssClass="form-control" ></asp:TextBox>
                                                        
                                                        <br/>
                                                        <br/>
                                                    </div>
                                                 
                                                        <div class="col-md-4">
                                                              <asp:Label ID="Label64" runat="server" Text="Nationality"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <telerik:RadComboBox ID="ddlNationalityE"  runat="server" DropDownCssClass="widthClass"  
                                                                                     OnItemsRequested="ddlnationalityEC_ItemsRequested"
                                                                                     EmptyMessage="Select Nationality" EnableLoadOnDemand="True" Filter="Contains" Height="200px"
                                                                                      HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                                                      AutoPostBack="False" SetFocusOnError="True">
                                                                                     
                                                                                     <ItemTemplate>
                                                                                    <table cellpadding="0" cellspacing="0">
                                                                                    <tr>

                                                                                    <td><%# DataBinder.Eval(Container, "Attributes['NationalityName']")%></td>

                                                                                    </tr>
                                                                                </table>
                                                                            </ItemTemplate>
                                                                                 </telerik:RadComboBox>
                                                            <br/>
                                                            
                                                        </div>
                                                 
                                                        <div class="col-md-4">
                                                                <asp:Label ID="Label85" runat="server" Text="Relationship with Student"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtRsWithStudentE" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                            <br/>
                                                       </div>
                                                    </div> 
                                                 
                                                     <div class="row">
                                                     <div class="col-md-4">
                                                                <asp:Label ID="Label86" runat="server" Text="Present Address"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtPreAddressE" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                           
                                                       </div>
                                                  <div class="col-md-4">
                                                                <asp:Label ID="Label87" runat="server" Text="Permanent Address"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtPerAddressE" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                           
                                                       </div>
                                                  <div class="col-md-4">
                                                                <asp:Label ID="Label94" runat="server" Text="Telephone No"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                
                                                                    <asp:TextBox ID="txtTelNoE" runat="server" CssClass="form-control"></asp:TextBox>   
                                                               
                                                            <br/>
                                                            
                                                       </div>
                                                     
                                                </div>
                                                       
                                                     <div class="row">
                                                      <div class="col-md-4">
                                                                <asp:Label ID="Label95" runat="server" Text="MobileNo "  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="TxtMobNoE" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                           
                                                       </div>
                                                     
                                                      <div class="col-md-4">
                                                                <asp:Label ID="Label96" runat="server" Text="Email Address"  Font-Bold="true"></asp:Label>
                                                          <span style="color: red">*</span>
                                                                    <br/>
                                                                <asp:TextBox ID="txtEAddressE" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                           
                                                       </div>
                                                 </div>
                                              </div>
                                        
                                
                                       </div>
                                     </div>  
                                    </div>
                                      <br/>     
                                            <div class="row" id="divreferee" runat="server" >
                                     <div class="col-lg-12">
                                         <div class="card">
                                             <div class="card-body divColorb">
                                                     <h4 style="font-family: fantasy">Key referees for parents</h4>
                                                 (List two key refeeres not related to you who can verify information about you)
                                                
                                                         <div class="list-divider"></div>
                                                                            <br/>
                                                 
                                                     <div class=" row">                    
                                                        <div class="col-md-4">
                                                            <asp:Label ID="Label97" runat="server" Text="1.Name"  Font-Bold="true"></asp:Label>
                                                             
                                                                <br/>
                                                            <asp:TextBox ID="txtNameR1" runat="server" CssClass="form-control" ></asp:TextBox>
                                                        
                                                        <br/>
                                                        <br/>
                                                    </div>
                                                 
                                                        <div class="col-md-4">
                                                              <asp:Label ID="Label98" runat="server" Text="Nationality"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <telerik:RadComboBox ID="ddlNationalityR1"  runat="server" DropDownCssClass="widthClass"  
                                                                                     OnItemsRequested="ddlnationalityRE1_ItemsRequested"
                                                                                     EmptyMessage="Select Nationality" EnableLoadOnDemand="True" Filter="Contains" Height="200px"
                                                                                      HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                                                      AutoPostBack="False" SetFocusOnError="True">
                                                                                     
                                                                                     <ItemTemplate>
                                                                                    <table cellpadding="0" cellspacing="0">
                                                                                    <tr>

                                                                                    <td><%# DataBinder.Eval(Container, "Attributes['NationalityName']")%></td>

                                                                                    </tr>
                                                                                </table>
                                                                            </ItemTemplate>
                                                                                 </telerik:RadComboBox>
                                                            <br/>
                                                            
                                                        </div>
                                                 
                                                        <div class="col-md-4">
                                                                <asp:Label ID="Label99" runat="server" Text="Relationship with Parent(s)"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtRsWithParentR1" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                            <br/>
                                                       </div>
                                                    </div> 
                                                 
                                                     <div class="row">
                                                     <div class="col-md-4">
                                                                <asp:Label ID="Label100" runat="server" Text="Present Address"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtPreAddressR1" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                           
                                                       </div>
                                                  <div class="col-md-4">
                                                                <asp:Label ID="Label101" runat="server" Text="Permanent Address"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtPerAddressR1" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                           
                                                       </div>
                                                  <div class="col-md-4">
                                                                <asp:Label ID="Label102" runat="server" Text="Telephone No"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                
                                                                    <asp:TextBox ID="txtTelNoR1" runat="server" CssClass="form-control"></asp:TextBox>   
                                                               
                                                            <br/>
                                                            
                                                       </div>
                                                     
                                                </div>
                                                       
                                                     <div class="row">
                                                      <div class="col-md-4">
                                                                <asp:Label ID="Label103" runat="server" Text="MobileNo "  Font-Bold="true"></asp:Label>
                                                                 <span style="color: red">*</span>
                                                                    <br/>
                                                                <asp:TextBox ID="txtMoNoR1" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                           
                                                       </div>
                                                     
                                                      <div class="col-md-4">
                                                                <asp:Label ID="Label104" runat="server" Text="Email Address"  Font-Bold="true"></asp:Label>
                                                          <span style="color: red">*</span>
                                                                    <br/>
                                                                <asp:TextBox ID="txtEAddressR1" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                           
                                                       </div>
                                                 </div>
                                                 
                                                 
                                                                         <br/>
                                                 
                                                   <div class="list-divider"></div>
                                                 <br/>
                                                 

                                                     <div class=" row">                    
                                                        <div class="col-md-4">
                                                            <asp:Label ID="Label105" runat="server" Text="2.Name"  Font-Bold="true"></asp:Label>
                                                             
                                                                <br/>
                                                            <asp:TextBox ID="txtNameR2" runat="server" CssClass="form-control" ></asp:TextBox>
                                                        
                                                        <br/>
                                                        <br/>
                                                    </div>
                                                 
                                                        <div class="col-md-4">
                                                              <asp:Label ID="Label106" runat="server" Text="Nationality"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <telerik:RadComboBox ID="ddlNationalityR2"  runat="server" DropDownCssClass="widthClass"  
                                                                                     OnItemsRequested="ddlnationalityRE2_ItemsRequested"
                                                                                     EmptyMessage="Select Nationality" EnableLoadOnDemand="True" Filter="Contains" Height="200px"
                                                                                      HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                                                      AutoPostBack="False" SetFocusOnError="True">
                                                                                     
                                                                                     <ItemTemplate>
                                                                                    <table cellpadding="0" cellspacing="0">
                                                                                    <tr>

                                                                                    <td><%# DataBinder.Eval(Container, "Attributes['NationalityName']")%></td>

                                                                                    </tr>
                                                                                </table>
                                                                            </ItemTemplate>
                                                                                 </telerik:RadComboBox>
                                                            <br/>
                                                            
                                                        </div>
                                                 
                                                        <div class="col-md-4">
                                                                <asp:Label ID="Label107" runat="server" Text="Relationship with Parent(s)"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtRsWithParentR2" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                            <br/>
                                                       </div>
                                                    </div> 
                                                 
                                                     <div class="row">
                                                     <div class="col-md-4">
                                                                <asp:Label ID="Label108" runat="server" Text="Present Address"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtPreAddressR2" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                           
                                                       </div>
                                                  <div class="col-md-4">
                                                                <asp:Label ID="Label109" runat="server" Text="Permanent Address"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtPerAddressR2" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                           
                                                       </div>
                                                  <div class="col-md-4">
                                                                <asp:Label ID="Label110" runat="server" Text="Telephone No"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                
                                                                    <asp:TextBox ID="txtTelNoR2" runat="server" CssClass="form-control"></asp:TextBox>   
                                                               
                                                            <br/>
                                                            
                                                       </div>
                                                     
                                                </div>
                                                       
                                                     <div class="row">
                                                      <div class="col-md-4">
                                                                <asp:Label ID="Label111" runat="server" Text="MobileNo "  Font-Bold="true"></asp:Label>
                                                                 <span style="color: red">*</span>
                                                                    <br/>
                                                                <asp:TextBox ID="txtMobNoR2" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                           
                                                       </div>
                                                     
                                                      <div class="col-md-4">
                                                                <asp:Label ID="Label112" runat="server" Text="Email Address"  Font-Bold="true"></asp:Label>
                                                          <span style="color: red">*</span>
                                                                    <br/>
                                                                <asp:TextBox ID="txtEAddressR2" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                           
                                                       </div>
                                                 </div>
                                              </div>
                                        
                                       </div>
                                     </div>  
                                    </div>
                                           
                                           <div style="float: right">
                                     
                                    <%-- <asp:Button ID="btnsaveEmergencyContact" CssClass="btn btn-danger" runat="server" Text="Save" 
                                         CausesValidation="False" OnClick="btnsaveEmergencyContact_OnClick"/>--%>
                                                  <asp:Button ID="btnUpdateEmergencyContact" CssClass="btn btn-danger" runat="server" Text="Update" 
                                                      CausesValidation="False" OnClick="Btn_UpdateEmergencyContact"/> 
                                  
                                   
                                </div>
                                           <br/>
                                           <br/>
                                        </div>
                                      
                                      
                                        <%-- -------------------------------Previous Details------------------------ --%>

    
                                        <div class="tab-pane fade" id="PreviousDetails">
                                        
                                            
                                                 <div>
                                                    
                                                     Fields with<span style="color: red">*</span> are required
                                                     <br/>
                                                 </div>
                                                  <br/>
                                            
                                            
                                             <div class="row" id="divpredetails" runat="server" >
                                     <div class="col-lg-12">
                                         <div class="card">
                                             <div class="card-body divColorb">
                                                     <h4 style="font-family: fantasy"> Educational Background</h4>
                                                 (Please account for every year your child has been in school)
                                                         <div class="list-divider"></div>
                                                                            <br/>
                                                     <div class=" row">                    
                                                        <div class="col-md-4">
                                                            <asp:Label ID="Label26" runat="server" Text="Institution Name"  Font-Bold="true"></asp:Label>
                                                             
                                                                <br/>
                                                            <asp:TextBox ID="txtinsname" runat="server" CssClass="form-control" ></asp:TextBox>
                                                        
                                                        <br/>
                                                        <br/>
                                                    </div>
                                                 
                                                        <div class="col-md-4">
                                                              <asp:Label ID="Label30" runat="server" Text="Current/Last Year Grade"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtprevgrade" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                            
                                                        </div>
                                                 
                                                        <div class="col-md-4">
                                                                <asp:Label ID="Label34" runat="server" Text="Full Address of School"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtaddschl" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                            <br/>
                                                       </div>
                                                    </div> 
                                                 
                                                     <div class="row">
                                                     <div class="col-md-4">
                                                                <asp:Label ID="Label36" runat="server" Text="Telephone Number"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtphonescl" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                           
                                                       </div>
                                                  <div class="col-md-4">
                                                                <asp:Label ID="Label25" runat="server" Text="Email Address"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtemailscl" runat="server" CssClass="form-control"></asp:TextBox>
                                                            <br/>
                                                           
                                                       </div>
                                                  <div class="col-md-4">
                                                                <asp:Label ID="Label27" runat="server" Text="Date Attended"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                
                                                                       <telerik:RadDatePicker ID="ddldateattended" Class="form-control" runat="server" AutoPostBack="false" Culture="en-US"  
                                                                                MaxDate="3000-01-01" MinDate="1000-01-01" ShowPopupOnFocus="True" Style="background-color: #FFFFFF; font-weight: 700; 
                                                                                
                                                                                    color: #FF0000;" Width="300px">
                                                                                <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" runat="server" SelectedDate=""  SelectionMode="Day" 
                                                                                          ShowLines="True">
                                                                                         
                                                                                </Calendar>
                                                                                <DateInput AutoPostBack="false" DateFormat="d/MM/yyyy" DisplayDateFormat="d/MM/yyyy" LabelWidth="40%" runat="server">
                                                                                </DateInput>
                                                                             
                                                                             </telerik:RadDatePicker>
                                                      <asp:RequiredFieldValidator ID="rfvddldateattended" runat="server" ControlToValidate="ddldateattended"
                                                          ErrorMessage="*Required" ValidationGroup="validatePD" ForeColor="red"></asp:RequiredFieldValidator>
                                                               
                                                            <br/>
                                                            
                                                       </div>
                                                     
                                                </div>
                                                        <div class="row">
                                                       <div class="col-md-4">
                                                                  <br/>
                                                                   <asp:Label ID="Label28" runat="server" Text="Attending Currently:"  Font-Bold="true"></asp:Label>  &nbsp;&nbsp;&nbsp;
                                                                   <asp:RadioButton ID="rbattendingc1" runat="server" GroupName="attendingcurrently" Text="&nbsp;Yes" CssClass="radioClass"/> &nbsp;&nbsp;&nbsp;
                                                                   <asp:RadioButton ID="rbattendingc2"   runat="server" GroupName="attendingcurrently" Text="&nbsp;No" CssClass="radioClass"/>       
                                                                            
                                                            <br/>
                                                            <br/>
                                                       </div>

                                                   </div> 
                                              </div>
                                      
                                             
                                   
             
                                       </div>
                                     </div>  
                                    </div>
                                                           <div style="float: right">
                                     
                                     <%-- <asp:Button ID="btnuppreviousdetails" CssClass="btn btn-warning" runat="server" Text="Update" CausesValidation="False" />--%>

                                    <%-- <asp:Button ID="btnsavepreviousdetails" CssClass="btn btn-danger" runat="server" Text="Save" CausesValidation="True"
                                         ValidationGroup="validatePD" OnClick="btnsavepreviousdetails_OnClick" />--%>
                                                               
                                     <asp:Button ID="btnuppreviousdetails" CssClass="btn btn-warning" runat="server" Text="Update" CausesValidation="False" 
                                         OnClick="Btn_UpdateEducationalBackground"/>
                                   
                                   
                                </div>     
                                            <br/>
                                           <br/>
                                        </div>
                                      
                                      
                                        <%-- -------------------------------Student Documents------------------------ --%>

    
                                        <div class="tab-pane fade" id="StudentDocuments">
                                        
                                            <div>
                                                    
                                                     Fields with<span style="color: red">*</span> are required
                                                     <br/>
                                                 </div>
                                                  <br/>
                                            <div class="card-body divColorb">

                                                <asp:FileUpload ID="upstudoc" runat="server" />
                                                <%-- <telerik:RadUpload ID="studocup" runat="server"></telerik:RadUpload>--%>
                                              
                                             </div>
                                            <br/>
                                            <div style="float: right">
                                     <%--<asp:Button ID="btnupstudoc" CssClass="btn btn-warning" runat="server" Text="Update"  CausesValidation="False"   OnClick="btnSaveStuDoc" />--%>
                                     <%--<asp:Button ID="btnsavedoc" CssClass="btn btn-danger" runat="server" Text="Save"  CausesValidation="False"   OnClick="btnSaveStuDoc" />--%>
                                   
                                </div>
                                            
                                            <br/>
                                           <br/>
                                        </div>
                                      
                                      
                                        <%-- -------------------------------Additional Details------------------------ --%>

                                      
                                       <div class="tab-pane fade" id="additionaldetails">
                                           
                                                                                
                      <div style="float: right">
                                     
                                   <asp:Button ID="btnviewprofile" CssClass="btn btn-danger" runat="server" Text="View Profile" />   
                                   
                      </div>  
                                       
                                            
                                                 <div>
                                                    
                                                     Fields with<span style="color: red">*</span> are required
                                                     <br/>
                                                 </div>
                                                  <br/>
                                            
                                            
                                             <div class="row" id="divmedicalinfo" runat="server" >
                                     <div class="col-lg-12">
                                         <div class="card">
                                             <div class="card-body divColorb">
                                                     <h4 style="font-family: fantasy">Medical Information</h4>
                                                 
                                                         <div class="list-divider"></div>
                                                                            <br/>
                                                     <div>                    
                                                       
                                                         <div class="col-md-6">
                                                                  <asp:Label ID="Label41" runat="server" Text="Does your child have any special medical problems(including allergies)?" 
                                                                       Font-Bold="true"></asp:Label>  &nbsp;&nbsp;&nbsp;
                                                             </div>
                                                              <br/>
                                                                               &nbsp;&nbsp;
                                                                                 <asp:RadioButton ID="rbmedical1" runat="server" GroupName="allergie" Text="&nbsp;Yes" CssClass="radioClass"/> &nbsp;&nbsp;&nbsp;
                                                                                 <asp:RadioButton ID="rbmedical2"   runat="server" GroupName="allergie" Text="&nbsp;No" CssClass="radioClass"/>       
                                                                            
                                                        <br/>
                                                   
                                                   </div>
                                                    <div >
                                                       
                                                                <br/>
                                                        <div class="col-md-6">
                                                                  <asp:Label ID="Label29" runat="server" Text="Does your child take any medication?"  Font-Bold="true"></asp:Label>  &nbsp;&nbsp;&nbsp;
                                                            
                                                            </div>
                                                        <br/>
                                                                               &nbsp;&nbsp;
                                                                                 <asp:RadioButton ID="rbmedication1" runat="server" GroupName="medication" Text="&nbsp;Yes" CssClass="radioClass"/> &nbsp;&nbsp;&nbsp;
                                                                                 <asp:RadioButton ID="rbmedication2"   runat="server" GroupName="medication" Text="&nbsp;No" CssClass="radioClass"/> 
                                                            <br/>
                                                            
                                                        
                                                     </div>
                                                 <div class="row">
                                                      <div class="col-md-3">
                                                          <br/>
                                                               &nbsp;&nbsp;
                                                           <asp:Label ID="Label32" runat="server" Text="If yes, Please give details"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                           
                                                            <br/>
                                                            <br/>
                                                       </div>
                                                 <div class="col-md-9" >
                                                     <br/>
                                                          <asp:TextBox ID="txtmedicaldetails" runat="server" CssClass="form-control" Height="100px"></asp:TextBox>
                                                     <br/>
                                                 </div>
                                                   <br/>
                                                     <br/>
                                                 </div>
                                                  
                                                       
                                              </div>
                                          
                                      
                                       </div>
                                     </div>  
                                    </div>
                                      <br/>     
                                   <div class="row" id="divsiblinginfo1" runat="server" >
                                     <div class="col-lg-12">
                                         <div class="card">
                                             <div class="card-body divColorb">
                                                     <h4 style="font-family: fantasy">Sibling(s) Information :1</h4>
                                                 (Applicable<span style="color: red">*</span> if sibling of prospective student wishes to study as St.Peter`s School of London as well)
                                                 
                                                         <div class="list-divider"></div>
                                                                            <br/>
                                                     <div class=" row">                    
                                                        
                                                          <br/>
                                                         <div class="col-md-4">
                                                                  <asp:Label ID="Label31" runat="server" Text="Name"  Font-Bold="true"></asp:Label>  
                                                                   <asp:TextBox ID="txtsname1" runat="server" CssClass="form-control"></asp:TextBox>    
                                                             
                                                             </div>
                                                          <div class="col-md-4">
                                                                    <asp:Label ID="Label33" runat="server" Text="Gender"  Font-Bold="true"></asp:Label>  &nbsp;&nbsp;&nbsp;
                                                                                  <telerik:RadComboBox ID="ddlgenderS1"  runat="server" DropDownCssClass="widthClass" SetFocusOnError="True"
                                                                                   EmptyMessage="Select Gender" EnableLoadOnDemand="True" Filter="Contains" Height="200px" HighlightTemplatedItems="True"
                                                                                   Width="100%" Skin="Silk" Style="background-color: #339966;" AutoPostBack="False" AppendDataBoundItems="True"
                                                                                  OnItemsRequested="ddlSgender1_ItemsRequested" >
                                  
                                                                                   <ItemTemplate>
                                                                                    <table cellpadding="0" cellspacing="0">
                                                                                    <tr>

                                                                                    <td><%# DataBinder.Eval(Container, "Attributes['GenderName']")%></td>

                                                                                    </tr>
                                                                                </table>
                                                                            </ItemTemplate> 
                                                                              
                                                                              </telerik:RadComboBox>
                                                                                   
                                                              
                                                          </div> 
                                                         
                                                          <div class="col-md-4">
                                                              
                                                                <asp:Label ID="Label62" runat="server" Text="Relationship with student"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtsrelation1" runat="server" CssClass="form-control"></asp:TextBox>
                                                              </div>               
                                                                            
                                                        <br/>
                                                   
                                                   </div>
                                                 
                                                 <br/>
                                                 <br/>
                                                    <div class=" row">
                                                        <div class="col-md-4">
                                                         <asp:Label ID="Label43" runat="server" Text="age"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtsage1" runat="server" CssClass="form-control"></asp:TextBox>
                                                            
                                                            </div>
                                                        <div class="col-md-4">
                                                                    
                                                                     <asp:Label ID="Label44" runat="server" Text="StudentID"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtsstudentID1" runat="server" CssClass="form-control"></asp:TextBox>
                                                            
                                                            </div>
                                                        <div class="col-md-4">
                                                             <asp:Label ID="Label45" runat="server" Text="Class Roll"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtsclassroll1" runat="server" CssClass="form-control"></asp:TextBox>

                                                        </div>
                                                          
                                                     </div>
                                                         <br/>
                                                         <br/>
                                                     
                                                 <div class="form-row">
                                                      <div class="col-md-4">
                                                     
                                                        <asp:Label ID="Label61" runat="server" Text="Campus"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                            
                                                                <asp:TextBox ID="txtscampus1" runat="server" CssClass="form-control" Width="314px"></asp:TextBox>
                                                            <br/>
                                                                
                                                             </div>

                                                 </div>
                                                       
                                                            <br/>
                                                            <br/>
                                                       
                                                   
                                              </div>
                                          
                                        
                                         
                                       </div>
                                     </div>  
                                    </div>
                                           
                                      
                                    <br/>
                                           <br/>

                                           <div class="row" id="divsiblinginfo2" runat="server" >
                                     <div class="col-lg-12">
                                         <div class="card">
                                             <div class="card-body divColorb">
                                                     <h4 style="font-family: fantasy">Sibling(s) Information:2</h4>
                                                 (Applicable<span style="color: red">*</span> if sibling of prospective student wishes to study as St.Peter`s School of London as well)
                                                 
                                                         <div class="list-divider"></div>
                                                                            <br/>
                                                     <div class=" row">                    
                                                        
                                                          <br/>
                                                         <div class="col-md-4">
                                                                  <asp:Label ID="lblsname2" runat="server" Text="Name"  Font-Bold="true"></asp:Label>  
                                                                   <asp:TextBox ID="txtsname2" runat="server" CssClass="form-control"></asp:TextBox>    
                                                             
                                                             </div>
                                                          <div class="col-md-4">
                                                                    <asp:Label ID="lblsgender2" runat="server" Text="Gender"  Font-Bold="true"></asp:Label>  &nbsp;&nbsp;&nbsp;
                                                                     <telerik:RadComboBox ID="ddlSgender2"  runat="server" DropDownCssClass="widthClass" SetFocusOnError="True"
                                                                                   EmptyMessage="Select Gender" EnableLoadOnDemand="True" Filter="Contains" Height="200px" HighlightTemplatedItems="True"
                                                                                   Width="100%" Skin="Silk" Style="background-color: #339966;" AutoPostBack="False" AppendDataBoundItems="True"
                                                                                  OnItemsRequested="ddlSgender2_ItemsRequested">
                                  
                                                                                   <ItemTemplate>
                                                                                    <table cellpadding="0" cellspacing="0">
                                                                                    <tr>

                                                                                    <td><%# DataBinder.Eval(Container, "Attributes['GenderName']")%></td>

                                                                                    </tr>
                                                                                </table>
                                                                            </ItemTemplate> 
                                                                              
                                                                              </telerik:RadComboBox>
                                                                                   
                                                          </div> 
                                                         
                                                          <div class="col-md-4">
                                                              
                                                                <asp:Label ID="lblsrel2" runat="server" Text="Relationship with student"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtsrelation2" runat="server" CssClass="form-control"></asp:TextBox>
                                                              </div>               
                                                                            
                                                        <br/>
                                                   
                                                   </div>
                                                 
                                                 <br/>
                                                 <br/>
                                                    <div class=" row">
                                                        <div class="col-md-4">
                                                         <asp:Label ID="lblsage2" runat="server" Text="age"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtsage2" runat="server" CssClass="form-control"></asp:TextBox>
                                                            
                                                            </div>
                                                        <div class="col-md-4">
                                                                    
                                                                     <asp:Label ID="lblsID2" runat="server" Text="StudentID"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtsstudentid2" runat="server" CssClass="form-control"></asp:TextBox>
                                                            
                                                            </div>
                                                        <div class="col-md-4">
                                                             <asp:Label ID="lblSRoll2" runat="server" Text="Class Roll"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                                <asp:TextBox ID="txtsclassroll2" runat="server" CssClass="form-control"></asp:TextBox>

                                                        </div>
                                                          
                                                     </div>
                                                         <br/>
                                                         <br/>
                                                     <div class="form-row">
                                                           <div class="col-md-4">
                                                     
                                                        <asp:Label ID="lblScamus2" runat="server" Text="Campus"  Font-Bold="true"></asp:Label>
                                                                    <br/>
                                                            
                                                                <asp:TextBox ID="txtscampus2" runat="server" CssClass="form-control" Width="314px"></asp:TextBox>
                                                                <br/>
                                                             </div>

                                                     </div>
                                                      
                                                            <br/>
                                                            <br/>
                                                       
                                                   
                                              </div>
                                          
                                       
                                       </div>
                                     </div>  
                                    </div>  
                                           <br/>   
                                                 
                                             <div class="row" id="divtransportationinfo" runat="server" >
                                     <div class="col-lg-12">
                                         <div class="card">
                                             <div class="card-body divColorb">
                                                     <h4 style="font-family: fantasy">Transportation Details</h4>
                                                 (How will the student come to school?)
                                                 
                                                         <div class="list-divider"></div>
                                                                            <br/>
                                                     <div class=" row">                    
                                                        
                                                          <br/>
                                                         <div class="col-md-4">
                                                             <div class="col-md-6">
                                                                  <asp:Label ID="Label39" runat="server" Text="Personal Car"  Font-Bold="true"></asp:Label>  &nbsp;&nbsp;&nbsp;
                                                                 </div>
                                                             
                                                                                <asp:RadioButton ID="rbcar1" runat="server" GroupName="car" Text="&nbsp;Yes" CssClass="radioClass"/> &nbsp;&nbsp;&nbsp;
                                                                                 <asp:RadioButton ID="rbcar2"   runat="server" GroupName="car" Text="&nbsp;No" CssClass="radioClass"/>    
                                                         
                                                            
                                                        </div>
                                                         <div class="col-md-4">
                                                                   <div class="col-md-6">
                                                         <asp:Label ID="Label38" runat="server" Text="Public Transport"  Font-Bold="true"></asp:Label>  &nbsp;&nbsp;&nbsp;
                                                                       
                                                                       </div>
                                                             
                                                                                <asp:RadioButton ID="rbbus1" runat="server" GroupName=" bus" Text="&nbsp;Yes" CssClass="radioClass"/> &nbsp;&nbsp;&nbsp;
                                                                                 <asp:RadioButton ID="rbbus2"   runat="server" GroupName="bus" Text="&nbsp;No" CssClass="radioClass"/>  
                                                         
                                                             </div>

                                                         <div class="col-md-4">
                                                              <div class="col-md-6">
                                                                  
                                                          <asp:Label ID="Label63" runat="server" Text="School Bus"  Font-Bold="true"></asp:Label>  &nbsp;&nbsp;&nbsp;
                                                                  
                                                                  </div>
                                                              
                                                                                <asp:RadioButton ID="rbsbus1" runat="server" GroupName=" sbus" Text="&nbsp;Yes" CssClass="radioClass"/> &nbsp;&nbsp;&nbsp;
                                                                                 <asp:RadioButton ID="rbsbus2"   runat="server" GroupName="sbus" Text="&nbsp;No" CssClass="radioClass"/>
                                                                         
                                                               
                                                             </div>
                                                                     
                                                        <br/>
                                                   
                                                   </div>
                                                 <br/>
                                                    <div class="row col-md-4">
                                                       
                                                                <br/>
                                                                  <asp:Label ID="Label40" runat="server" Text="Car Registration Number"  Font-Bold="true"></asp:Label>  &nbsp;&nbsp;&nbsp;
                                                                    <asp:TextBox ID="txtcarregno" runat="server" CssClass="form-control"></asp:TextBox>           
                                                            <br/>
                                                            <br/>
                                                        
                                                     </div>
                                                 
                                                     <br/>
                                                   <br/>

                                                  
                                              </div>
                                          
                                       
                                
                                       </div>
                                     </div>  
                                    </div>
                                          
                                 <div style="float: right">
                                       <%--  <asp:Button ID="btnsaveadditionaldetails" CssClass="btn btn-danger" runat="server" CausesValidation="False" Text="Save"  OnClick="btnsaveadditionaldetails_OnClick"/>
                                  --%>
                                     
                                       <asp:Button ID="btnupadddetails" CssClass="btn btn-warning" runat="server" CausesValidation="False" Text="Update" OnClick="btn_UpdateOtherDetail"/>                                   
                               
                                </div>    
                                           <br/>
                                           <br/>
                                        </div>
                                                             
                     </div>
                                        </div>


                      </div>
            </div>
   

                                                           
        
     
     
     
    
     
            </ContentTemplate>
      </asp:Updatepanel>     
     
           
  </asp:Content>


