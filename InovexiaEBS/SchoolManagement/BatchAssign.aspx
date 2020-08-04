<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="BatchAssign.aspx.cs" Inherits="InovexiaEBS.StudentRegistrationView.BatchAssign" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%--<link href="../css/bootstrap.css" rel="stylesheet" />
    <script src="../js/bootstrap.min.js"></script>--%>
    
    <style type="text/css">
        
        
                        .divColorb {
                            background-color:  #e6e6ff;
                            /*color: grey;*/
                        }

                        .batchbutton {
                            color: #006699;
                        }
                        
    </style>

    

    <div class="row" id="MasterPanel" runat="server" >
             <div class="col-lg-12">
                 
                     <div class="alert alert-dark"  id="alertbassign2" runat="server" role="alert" style="font-family: cursive">
                 Student has been assigned successfully!
            </div>   
                
            <div class="alert alert-danger" id="alertbassign1" runat="server" role="alert">
                This Student has already been assigned!
              </div>  
                  
                 <div class="row " id="divAssignBatch" runat="server" >
                     
                       <div class="col-lg-12">
                                <div class="card">
           
                                  <div class="card-body divColorb">
                                    <h3 style="font-family: fantasy">Assign Batch</h3>
                                                      
                                       <%-- <h4 style="font-family: fantasy"> Personal Details</h4>--%>
                                            <div class="list-divider"></div>
                                                    Fields with<span style="color: red">*</span> are required
                                                    <br/>
                                                <br/>
                                  
                                                <div class="row">
                                                                            
                                                <div class="col-md-4" >
                                                  <div style="float: left">
                                                <asp:Label ID="Label2" runat="server" Text="Student ID"  Font-Bold="true" ></asp:Label>&nbsp;&nbsp;
                                                   </div>
                                                
                                                 <div style="float: right">
                                                 
                                                     <telerik:RadComboBox ID="ddlStudentID"  runat="server" DropDownCssClass="widthClass"  
                                                            EmptyMessage="Select StudentID" EnableLoadOnDemand="True" Filter="Contains" Height="300px"
                                                            HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                            AutoPostBack="False" SetFocusOnError ="True"  OnItemsRequested="ddlStudentID_ItemsRequested">
                                                           
                                                          <HeaderTemplate>
                                                                <table cellpadding="0" cellspacing="0">
                                                                    <tr>

                                                                        <td>Name</td>

                                                                    </tr>
                                                                </table>
                                                            </HeaderTemplate>
                                                          <ItemTemplate>
                                                                <table cellpadding="0" cellspacing="0">
                                                                    <tr>
                                                                        <td><%# DataBinder.Eval(Container, "Attributes['Name']")%></td>
                                                                    </tr>
                                                                </table>
                                                            </ItemTemplate> 
                                                     </telerik:RadComboBox>
                                                    
                                                       <asp:RequiredFieldValidator ID="rfvtxtsid" ControlToValidate="ddlStudentID" runat="server" ForeColor="red" ErrorMessage="*Required" ValidationGroup="batchvalidation"  SetFocusOnError="True"></asp:requiredfieldvalidator>
                                                 </div>                        
                                                        
                                              
                                                <br/>
                                                  <br/>
                                                      <br/>
                                                                      
                                              
                                            
                                        </div> 
                                                <%--<br/>
                                                    <br/>--%>
                                                 <div class="col-md-2"></div>                         
                                                <div class="col-md-4" >
                                               
                                                    <div style="float: left">
                                                        <asp:Label ID="Label5" runat="server" Text="Batch"  Font-Bold="true"></asp:Label>
                                                        <span style="color: red">*</span> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                             
                                                    </div>
                                               
                                                     <div style="float: left">
                                                        <telerik:RadComboBox ID="ddlBatch"  runat="server" DropDownCssClass="widthClass"  
                                                            EmptyMessage="Select Batch" EnableLoadOnDemand="True" Filter="Contains" Height="300px"
                                                            HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                            AutoPostBack="False" SetFocusOnError ="True"  OnItemsRequested="ddlBatch_ItemsRequested">
                                                            <ItemTemplate>
                                                        <table cellpadding="0" cellspacing="0">
                                                        <tr>

                                                        <td><%# DataBinder.Eval(Container, "Attributes['SectionName']")%></td>

                                                        </tr>
                                                    </table>
                                                </ItemTemplate> 
                                                        </telerik:RadComboBox>
                                                         
                                                        <asp:RequiredFieldValidator ID="rfvddlclass" ControlToValidate="ddlBatch" runat="server" ForeColor="red" ErrorMessage="*Required" ValidationGroup="batchvalidation"  SetFocusOnError="True"></asp:requiredfieldvalidator>    
                                                     </div>
                                                <br/>
                                                <br/>
                                               
                                              </div>
                                            
                                                </div>
                                            
                                                
                                                
                                                <div class="row">
                                                    
                                                     <div class="col-md-4" >
                                                  <div style="float: left">
                                                <asp:Label ID="Label1" runat="server" Text="Class"  Font-Bold="true" ></asp:Label>&nbsp;&nbsp;
                                                   </div>
                                                
                                                 <div style="float: right">
                                                 
                                                     <telerik:RadComboBox ID="ddlClass"  runat="server" DropDownCssClass="widthClass"  
                                                            EmptyMessage="Select Class" EnableLoadOnDemand="True" Filter="Contains" Height="300px"
                                                            HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                            AutoPostBack="False" SetFocusOnError ="True"  OnItemsRequested="ddlClass_ItemsRequested">
                                                            <ItemTemplate>
                                                                <table cellpadding="0" cellspacing="0">
                                                                    <tr>
                                                                        <td><%# DataBinder.Eval(Container, "Attributes['ClassName']")%></td>
                                                                    </tr>
                                                                </table>
                                                            </ItemTemplate> 
                                                     </telerik:RadComboBox>
                                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ddlClass" runat="server" ForeColor="red" ErrorMessage="*Required" ValidationGroup="batchvalidation"  SetFocusOnError="True"></asp:requiredfieldvalidator>
                                                 </div>                        
                                                        
                                              
                                                <%--<br/>
                                                  <br/>
                                                      <br/>
                                                              --%>        
                                                
                                            
                                        </div> 
                                                <br/>
                                                    <%--<br/>--%>
                                                  <div class="col-md-2"></div>                        
                                                <div class="col-md-4" >
                                               
                                                    <div style="float: left">
                                                        <asp:Label ID="Label3" runat="server" Text="Session" Font-Bold="true"></asp:Label>
                                                        <span style="color: red">*</span> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                             
                                                    </div>
                                               
                                                     <div style="float: left">
                                                        <%--<form id="form1" runat="server">--%>
    
                                                            <div>
                                                                <asp:RadioButton ID="rbsession1" runat="server" GroupName="session" Text="&nbsp;&nbsp;First" AutoPostBack="true" CssClass="radioClass" />
                                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                <asp:RadioButton ID="rbsession2" runat="server" GroupName="session" Text="&nbsp;&nbsp;Second" AutoPostBack="true" CssClass="radioClass" />
                                                               &nbsp;&nbsp;&nbsp;
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="ddlBatch" runat="server" ForeColor="red" ErrorMessage="*Required" ValidationGroup="batchvalidation"  SetFocusOnError="True"></asp:requiredfieldvalidator>       
                                                            </div>
                                                        <%--</form>--%>
                                                         
                                                        
                                                     </div>
                                                <br/>
                                                <br/>
                                               
                                              </div>
                                                     
                                                  
                                                   
                                                                            
                                                </div>
                                      
                                                    <br/>
                                      <br/>                             
                                                   <div style="float: right">
                        <asp:Button ID="BtnSaveBatchAssign" CssClass="btn btn-primary" runat="server" CausesValidation="True" ValidationGroup="batchvalidation" OnClick="btn_SavebatchAssign" Text="Save"/>
        </div>                                
                                            
                                                </div>

                                   
    
                                </div>

                
                                 </div>
                 
                 
                
                       </div>
                 </div>
        
        
      
    </div>
    

</asp:Content>
