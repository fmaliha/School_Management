<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="CreateClassUI.aspx.cs" Inherits="InovexiaEBS.StudentRegistrationView.CreateClassUI" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server" >
    
    <div class="col-lg-12" style="font-family: serif">
        
        <div class="breadcrumb fontcolordiv" style="background-color: #b3b3b3"  >
                                                    <li class="breadcrumb-item" ><a href="#">Home</a></li>
                                                    <li class="breadcrumb-item"><a href="#">Course</a></li>
                                                    <li class="breadcrumb-item"><a href="#">Add Class</a></li>
                                                 
                                                    <%--<li class="breadcrumb-item active">Student Details</li>--%>
                   </div>

        <div class="alert alert-dark"  id="alertClass2" runat="server" role="alert" style="font-family: cursive">
                 A new batch has been created successfully!
            </div>   
                
            <div class="alert alert-danger" id="alertClass1" runat="server" role="alert">
                This record already exists!
              </div>
        
                 
                <div class="card">
                    
                   
                
                    <div class="card-body" style="background-color: #e6e6ff">
                          
                          <h3 style="font-family: fantasy">Create Class</h3> 
                        
                        <br/>
                        
                        <div class="list-divider"></div>
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label class="control-label"><b>Class Name</b></label>
                                    <span style="color: red;">*</span>
                                     <asp:HiddenField ID="hfClassID1" runat="server"></asp:HiddenField>
                                    
                                    <asp:TextBox ID="txtNameClass" runat="server" class="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvClassName" ControlToValidate="txtNameClass" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="col-md-2"></div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label class="control-label"><b>Select Section</b></label>
                                    <span style="color: red;">*</span>
                                    
                                    <telerik:RadComboBox ID="ddlSelectSection" runat="server" DropDownCssClass="widthClass"  EmptyMessage="Select Section" EnableLoadOnDemand="True" Filter="Contains" Height="200px" HighlightTemplatedItems="True" Width="100%" OnItemsRequested="ddlSelectSection_ItemsRequested" Skin="Silk" Style="background-color: #339966;" AutoPostBack="False">
                                        
                                        <HeaderTemplate>
                                            <table cellpadding="0" cellspacing="0">
                                                <tr>

                                                    <td>Section</td>

                                                </tr>
                                            </table>
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <table cellpadding="0" cellspacing="0">
                                                <tr>

                                                    <td><%# DataBinder.Eval(Container, "Attributes['SectionName']")%></td>

                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </telerik:RadComboBox>
                                    <asp:RequiredFieldValidator ID="rfvddlSelectSection" ControlToValidate="ddlSelectSection" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                </div>
                            </div>

                            
                        </div>

                        <div class="row">

                            <div class="col-md-4">
                                <div class="form-group">
                                    <label class="control-label"><b>Remarks</b></label>
                                    <span style="color: red;">*</span>
                                    
                                    <asp:TextBox ID="txtRemarksClass" runat="server" Height="44px" TextMode="MultiLine" class="form-control" AutoPostBack="False"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvStudentID" ControlToValidate="txtRemarksClass" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                </div>
                            </div>
  
                        </div>
                        <div class="card-control">
               <div class="pull-Right" style="padding: 5px;">

                   <asp:Button ID="BtnSaveClass" CssClass="btn btn-primary margin-right-btn" runat="server" Text="Save" ValidationGroup="MasterValidation" OnClick="Btn_SaveClass" />
                   <asp:Button ID="BtnUpdateClass" CssClass="btn btn-warning margin-right-btn" runat="server" Text="Update" OnClick="Btn_UpdateClass" />
                   <asp:Button ID="btnaddnew" CssClass="btn btn-dark margin-right-btn" runat="server" Text="Add New" OnClick="Btn_addnew" />
                            </div>
            </div>
                    </div>

                </div>
            </div>

</asp:Content>
