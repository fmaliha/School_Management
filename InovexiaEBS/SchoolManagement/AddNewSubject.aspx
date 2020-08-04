<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="AddNewSubject.aspx.cs" Inherits="InovexiaEBS.StudentRegistrationView.SubjectManagement" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <div class="row" id="MasterPanel" runat="server" >
             <div class="col-lg-12">
                 <%--<div class="breadcrumb fontcolordiv" style="background-color: #b3b3b3"  >
                                                    <li class="breadcrumb-item" ><a href="#">Home</a></li>
                                                    <li class="breadcrumb-item"><a href="#">Batch</a></li>
                                                    <li class="breadcrumb-item"><a href="#">Assign Batch</a></li>
                                                 
                                                    
                   </div>--%>
                 
                  
                 <div class="row " id="divAssignBatch" runat="server" >
                     
                       <div class="col-lg-12">
                                <div class="card">
           
                                  <div class="card-body divColorb">
                                    <h3 style="font-family: fantasy">Add New Subject</h3>
                                                      
                                       <%-- <h4 style="font-family: fantasy"> Personal Details</h4>--%>
                                            <div class="list-divider"></div>
                                                    Fields with<span style="color: red">*</span> are required
                                                    <br/>
                                                <br/>
                                  
                                                <div class="row">
                                                                            
                                                <div class="col-md-6" >
                                                  <%--<div style="float: left">--%>
                                                <asp:Label ID="Label2" runat="server" Text="Subject ID"  Font-Bold="true" ></asp:Label>
                                                   <%--</div>--%>
                                                
                                                 <%--<div style="float: right">--%>
                                                 
                                                     <asp:TextBox ID="txtSubjectID" runat="server" ReadOnly="True" class="form-control"></asp:TextBox>
                                                    
                                               <%--  </div>  --%>                      
                                                        
                                              
                                                <%--<br/>
                                                  <br/>
                                                      <br/>--%>
                                                                      
                                            
                                        </div> 
                                                <%--<br/>
                                                    <br/>--%>
                                                                          
                                                <div class="col-md-6" >
                                               
                                                    <%--<div style="float: left">--%>
                                                        <asp:Label ID="Label5" runat="server" Text="Subject Name"  Font-Bold="true"></asp:Label>
                                                        <span style="color: red">*</span> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                             
                                                    <%--</div>--%>
                                               
                                                     <%--<div style="float: left">--%>
                                                        <asp:TextBox ID="txtSubjectName" runat="server" class="form-control"></asp:TextBox>
                                                         
                                                        <asp:RequiredFieldValidator ID="rfvddlclass" ControlToValidate="txtSubjectName" runat="server" ForeColor="red" ErrorMessage="*Required" ValidationGroup="Subjectvalidation" SetFocusOnError="True"></asp:requiredfieldvalidator>    
                                                     <%--</div>--%>
                                                <br/>
                                                <br/>
                                               
                                              </div>
                                            
                                                </div>
                                      
                                       <div class="pull-Right" style="float: right">
                        <asp:Button ID="BtnSaveSubject" CssClass="btn btn-primary" runat="server" CausesValidation="True" ValidationGroup="Subjectvalidation" OnClick="Btn_SaveSubject" Text="Save"/>
        </div>
     
                                                </div>

 </div>

                
                                 </div>
                 
                       </div>
                 </div>
        
        
       
    </div>


</asp:Content>
