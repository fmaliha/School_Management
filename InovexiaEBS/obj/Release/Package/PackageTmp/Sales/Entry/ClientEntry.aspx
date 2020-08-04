<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true"
    CodeBehind="ClientEntry.aspx.cs" Inherits="PBS.UI.PBMLSales.Entry.ClientEntry" %>





<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div class="row">                          
                                <div class="col-lg-12">
                                    <div class="panel">
                                        <div class="panel-heading">
                                            <div class="panel-control">                                               
                                            </div>
                                            <h3 class="panel-title">Client Entry</h3>
                                        </div>                                      
                                <div class="panel-body">        


                                     <div class="row">


                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Code</label>
                                                 <asp:TextBox ID="txtCode" runat="server" class="form-control" Font-Bold="True" ForeColor="Red" ReadOnly="True" ></asp:TextBox>
                                                        </div>
                                                    </div>
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Client Name</label>
                                                            <asp:TextBox ID="txtClientName" runat="server" class="form-control" ></asp:TextBox>
                                                        </div>
                                                    </div>

                                                </div>


                                      <div class="row">


                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Mobile No</label>
                                                 <asp:TextBox ID="txtMobileNo" runat="server" class="form-control"  ></asp:TextBox>
                                                        </div>
                                                    </div>
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Address</label>
                                                            <asp:TextBox ID="txtAddress" runat="server" class="form-control" ></asp:TextBox>
                                                        </div>
                                                    </div>

                                                </div>
    
    
                    

                                     </div>  

                                         <div class="panel-footer text-right">
                                            <asp:Button ID="btnSave" class="btn btn-info" runat="server" Text="SAVE" OnClick="btnSave_Click" />
                                        </div>

                                    </div>  </div>      </div>    
                
</asp:Content>
