<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="AddExpenseCategoryUI.aspx.cs" Inherits="InovexiaEBS.StudentRegistrationView.AddExpenseCategoryUI" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="row" id="MasterPanel" runat="server" >
             <div class="col-lg-12">
                 
              <div class="alert alert-dark"  id="alertbatch2" runat="server" role="alert" style="font-family: cursive">
                 A new Expense Category has been created successfully!
            </div>   
                
            <div class="alert alert-danger" id="alertbatch1" runat="server" role="alert">
                This record already exists!
              </div>  
                 
                  
                 <div class="row " id="divExpCategory" runat="server" >
                     
                       <div class="col-lg-12">
                                <div class="card">
           
                                  <div class="card-body divColorb">
                                    <h3 style="font-family: fantasy">Create Expense Head</h3>
                                                      
                                       <%-- <h4 style="font-family: fantasy"> Personal Details</h4>--%>
                                            <div class="list-divider"></div>
                                     
                                      
                                                    Fields with<span style="color: red">*</span> are required
                                                    <br/>
                                                <br/>
                                  
                                                <div class="row">
                                                                            
                                                <div class="col-md-6" >
                                                  
                                                    <asp:Label ID="Label1" runat="server" Text="Code" Font-Bold="true" ></asp:Label>
                                                   <%--</div>--%>
                                                
                                                 <%--<div style="float: right">--%>
                                                 
                                                     <asp:TextBox ID="txtExpID" runat="server" ReadOnly="True" class="form-control"></asp:TextBox>
                                            
                                        </div> 
                                                <%--<br/>
                                                    <br/>--%>
                                                                          
                                                <div class="col-md-6" >
                                               
                                                    <%--<div style="float: left">--%>
                                                <asp:Label ID="Label2" runat="server" Text="Expense Head" Font-Bold="true" ></asp:Label>
                                                    <span style="color: red">*</span>&nbsp;&nbsp;&nbsp;&nbsp;
                                                   <%--</div>--%>
                                                
                                                 <%--<div style="float: right">--%>
                                                 
                                                     <asp:TextBox ID="txtExpCategory" runat="server" class="form-control"></asp:TextBox>
                                                 <%--</div> --%>                       
                                                        
                                              
                                                
                                                                      
                                                <asp:RequiredFieldValidator ID="rfvtxtsid" ControlToValidate="txtExpCategory" runat="server" ForeColor="red" ErrorMessage="*Required" ValidationGroup="batchvalidation"  SetFocusOnError="True"></asp:requiredfieldvalidator>
                                               
                                              </div>
                                            
                                                </div>
                                      
                                      
                                      <br/>
                                      <br/>
                                      <br/>
                                      
                                       <div style="float: right">
                                            <asp:Button ID="BtnSaveExpCategory" CssClass="btn btn-primary" runat="server" CausesValidation="True" ValidationGroup="batchvalidation" OnClick="Btn_SaveExpCategory" Text="Save"/>
                                           
                                           <asp:Button ID="btnaddanother" CssClass="btn btn-dark" runat="server"  OnClick="Btn_Addanother" Text="Add Another"/>
                                         </div>
                                                </div>
       
                                  
                                  </div>

                                   
    
                                </div>

                
                                 </div>

                 
                 
                
                       </div>
      
        </div>

</asp:Content>
