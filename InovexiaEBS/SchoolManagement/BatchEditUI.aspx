<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="BatchEditUI.aspx.cs" Inherits="InovexiaEBS.SchoolManagement.BatchEditUI" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <style>
        
        
                        .divColorb {
                            background-color:  #e6e6ff;
                            /*color: grey;*/
                        }

                        .batchbutton {
                            color: #006699;
                        }

                        .labelbatchcheck {
                            color: red;
                            padding-left: 200px;
                            padding-top: 20px;
                        }

                       
    </style>
      <div class="row" id="MasterPanel" runat="server" >
             <div class="col-lg-12">
                 <div class="breadcrumb fontcolordiv" style="background-color: #b3b3b3"  >
                                                    <li class="breadcrumb-item" ><a href="#">Home</a></li>
                                                    <li class="breadcrumb-item"><a href="#">Batch</a></li>
                                                    <li class="breadcrumb-item"><a href="#">Add Batch</a></li>
                                                 
                                                    <%--<li class="breadcrumb-item active">Student Details</li>--%>
                   </div>
                 

              <div class="alert alert-success"  id="alertbatch2" runat="server" role="alert">
                 A new batch has been created successfully!
            </div>   
                
            <div class="alert alert-danger" id="alertbatch1" runat="server" role="alert">
                This record already exists!
              </div>  
                    
                 
                  
                 <div class="row " id="divpdetails" runat="server" >
                     
                       <div class="col-lg-12">
                                <div class="card">
           
                                  <div class="card-body divColorb">
                                    <h3 style="font-family: fantasy">Edit Batch</h3>
                                                      
                                       <%-- <h4 style="font-family: fantasy"> Personal Details</h4>--%>
                                            <div class="list-divider"></div>
                                                   
                                                    <br/>
                                                <br/>
                                  
                                                <div class="row">
                                                                            
                                                <div class="col-md-6" >
                                                  <div style="float: left">
                                                <asp:Label ID="Label2" runat="server" Text="Batch Name"  Font-Bold="true" ></asp:Label>&nbsp;&nbsp;
                                                   </div>
                                                
                                                 <div class="col-md-8" style="float: right">
                                                <asp:TextBox ID="txtbatchname" runat="server" CssClass="form-control" ></asp:TextBox>
                                               
                                                     </div>                        
                                                        
                                              
                                                <br/>
                                                  <br/>
                                                      <br/>
                                                                      
                                                <asp:RequiredFieldValidator ID="rfvtxtbn" ControlToValidate="txtbatchname" runat="server" ForeColor="red" ErrorMessage="Required" ValidationGroup="batchvalidation"  SetFocusOnError="True"></asp:requiredfieldvalidator>
                                            
                                        </div> 
                                                <br/>
                                                    <br/>
                                                                          
                                                <div class="col-md-6" >
                                               
                                                    <div style="float: left">
                                                        <asp:Label ID="Label5" runat="server" Text="Class"  Font-Bold="true"></asp:Label>
                                                        <span style="color: red">*</span> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                             
                                                    </div>
                                               
                                                     <div class="col-md-8" style="float: left">
                                                        <telerik:RadComboBox ID="ddlclass"  runat="server" DropDownCssClass="widthClass"  
                                                            EmptyMessage="Select Class" EnableLoadOnDemand="True" Filter="Contains" Height="300px"
                                                            HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                            AutoPostBack="False" SetFocusOnError ="True"  OnItemsRequested="ddlclass_ItemsRequested">
                                                            <ItemTemplate>
                                                        <table cellpadding="0" cellspacing="0">
                                                        <tr>

                                                        <td><%# DataBinder.Eval(Container, "Attributes['ClassName']")%></td>

                                                        </tr>
                                                    </table>
                                                </ItemTemplate> 
                                                        </telerik:RadComboBox>
                                                         
                                                        <asp:RequiredFieldValidator ID="rfvddlclass" ControlToValidate="ddlclass" runat="server" ForeColor="red" ErrorMessage="*Required" ValidationGroup="batchvalidation"  SetFocusOnError="True"></asp:requiredfieldvalidator>    
                                                     </div>
                                                <br/>
                                                <br/>
                                               
                                              </div>
                                            
                                                </div>
                                            
                                                
                                                
                                                <div class="row">
                                                     
                                                     <div class="col-md-6" >
                                                       <div style="float: left">
                                                <asp:Label ID="Label1" runat="server" Text="Year"  Font-Bold="true" ></asp:Label>
                                                    <span style="color: red">*</span>&nbsp;&nbsp;&nbsp;&nbsp;
                                                <br/>
                                                    
                                                  
                                                    </div>
                                                     
                                                    <div class="col-md-4" style="float:right">
                                                 <telerik:RadComboBox ID="ddlyeart"  runat="server" DropDownCssClass="widthClass"  
                                                            EmptyMessage="To" EnableLoadOnDemand="True" Filter="Contains" Height="100%"
                                                            HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                            AutoPostBack="False">
                                                           
                                                        </telerik:RadComboBox>
                                                        
                                                      
                                                         </div>
                                                      
                                                          <div class="col-md-4" style="float:right">

                                                 <telerik:RadComboBox ID="ddlyearf"  runat="server" DropDownCssClass="widthClass"  
                                                            EmptyMessage="From" EnableLoadOnDemand="True" Filter="Contains" Height="100%"
                                                            HighlightTemplatedItems="True" Width="100%" Skin="Silk" Style="background-color: #339966;"
                                                            AutoPostBack="False">
                                                           
                                                        </telerik:RadComboBox> 
                                                              <asp:HiddenField ID="hfyears" runat="server" />
                                                      
                                                         </div> 
                                                         
                                                          <asp:Label ID="lblyearcheck" runat="server" CssClass="labelbatchcheck"></asp:Label>  
                                                         </div>                   
                                                     <div class="col-md-6" >
                                                    <div style="float: left">
                                                <asp:Label ID="Label3" runat="server" Text="Remarks"  Font-Bold="true" ></asp:Label>&nbsp;&nbsp;
                                                   </div>
                                                
                                                 <div class="col-md-8" style="float: left">
                                                <asp:TextBox ID="txtbatchremarks" runat="server" CssClass="form-control" Height="100px" Width="345px" ></asp:TextBox>
                                               
                                                     </div>                        
                                                        <br/>
                                                        <br/>
                                              
                                                    </div>
                                                   
                                                                            
                                                </div>
                                  <%--    <asp:HiddenField ID="hfbatchcheck" runat="server" EnableViewState="True" />--%>
                                     
                                                <div style="float: right">
                                      
                                                 <asp:Button ID="btnsavebatch" CssClass="btn btn-warning" runat="server" CausesValidation="True" 
                                                     ValidationGroup="batchvalidation" OnClick="btnUpdatebatch_OnClick" Text="Update"
                                                     />
                                                     <%--data-toggle="modal" data-target="#myModal"--%>
                                    
                                          </div>                                    
                                                                                 
                                            
                                                </div>

                                   
    
                                </div>

                
                                 </div>
                 
                 
                
                       </div>
                 </div>
                 </div>
</asp:Content>
