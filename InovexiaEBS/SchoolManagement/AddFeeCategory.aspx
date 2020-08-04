<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="AddFeeCategory.aspx.cs" Inherits="InovexiaEBS.StudentRegistrationView.AddFeeCategory" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="row" id="Masterpanel" runat="server" >
             <div class="col-lg-12">
                 <div class="alert alert-dark"  id="alertbatch2" runat="server" role="alert" style="font-family: cursive">
                 A new Fee Head has been created successfully!
            </div>   
                
            <div class="alert alert-danger" id="alertbatch1" runat="server" role="alert">
                This record already exists!
              </div>
                 
                    
                  
                 <div class="row " id="divFeeCategory" runat="server" >
                     
                       <div class="col-lg-12">
                                <div class="card">
           
                                  <div class="card-body divColorb">
                                    <h3 style="font-family: fantasy">Create Fee Category</h3>
                                                      
                                       <%-- <h4 style="font-family: fantasy"> Personal Details</h4>--%>
                                            <div class="list-divider"></div>
                                     
                                      
                                                    Fields with<span style="color: red">*</span> are required
                                                    <br/>
                                                <br/>
                                  
                                                <div class="row">
                                                                            
                                                <div class="col-md-6" >
                                                  <%--<div style="float: left">--%>
                                                <asp:Label ID="Label2" runat="server" Text="Fee Category"  Font-Bold="true" ></asp:Label>
                                                   <%--</div>--%>
                                                
                                                 <%--<div style="float: right">--%>
                                                 
                                                     <asp:TextBox ID="txtFeeCategory" runat="server" class="form-control"></asp:TextBox>
                                                 <%--</div> --%>                       
                                                        
                                              
                                                
                                                                      
                                                <asp:RequiredFieldValidator ID="rfvtxtsid" ControlToValidate="txtFeeCategory" runat="server" ForeColor="red" ErrorMessage="*Required" ValidationGroup="batchvalidation"  SetFocusOnError="True"></asp:requiredfieldvalidator>
                                            
                                        </div> 
                                                <%--<br/>
                                                    <br/>--%>
                                                                          
                                                <div class="col-md-6" >
                                               
                                                    <%--<div style="float: left">--%>
                                                        <asp:Label ID="Label5" runat="server" Text="Fee Frequency"  Font-Bold="true"></asp:Label>
                                                        <span style="color: red">*</span> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                             
                                                    <%--</div>--%>
                                               
                                                     <%--<div style="float: left">--%>
                                                        <asp:TextBox ID="txtFeeFrequency" runat="server" class="form-control" AutoPostBack="False"></asp:TextBox>
                                                         
                                                        <asp:RequiredFieldValidator ID="rfvddlclass" ControlToValidate="txtFeeFrequency" runat="server" ForeColor="red" ErrorMessage="*Required" ValidationGroup="batchvalidation"  SetFocusOnError="True"></asp:requiredfieldvalidator>    
                                                     <%--</div>--%>
                                                <br/>
                                                <br/>
                                               
                                              </div>
                                            
                                                </div>
                                     
                                   <div style="float: right">
                        <asp:Button ID="BtnSaveFeeCategory" CssClass="btn btn-dark" runat="server" CausesValidation="True" ValidationGroup="batchvalidation"  OnClick="Btn_SaveFeeCategory" Text="Save"/>
        </div>
                                  </div>

                                   
    
                                </div>

                
                                 </div>

                 
                 
                
                       </div>
                 </div>
       
        </div>
        
        
       
        
        <%--<div style="float: right">
                        <asp:Button ID="BtnSaveBatchAssign" CssClass="btn btn-primary" runat="server" CausesValidation="True" ValidationGroup="batchvalidation" OnClick="btn_SavebatchAssign" Text="Create"/>
        </div>--%>
    `

</asp:Content>
