<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="InstitutionProgramEntry.aspx.cs" Inherits="InovexiaEBS.TextileEducation.InstitutionProgramEntry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
           

            <div class="row" id="MasterPanel" runat="server">
                <div class="col-lg-12">
                    <div class="panel">
                        <div class="panel-heading">
                          
                            

                             <div class="row">

                                <div class="col-md-2">
                                    <div class="pull-left">
                                       <h3 class="panel-title">Institute Program Management</h3>
                                        </div>
                                    </div>



                                <div class="col-md-9">
                                    <div class="pull-right">
                                        <asp:Button ID="Button1" CssClass="btn btn-success margin-right-btn" runat="server" Text="Save" />


                                    </div>
                                </div>
                                  <div class="col-md-1">
                                    <div class="pull-right">
                                        <asp:Button ID="Button2" CssClass="btn btn-info margin-right-btn" runat="server" Text="Show List" />


                                    </div>
                                </div>

                            </div>





                        </div>
                        <div class="panel-body">

                            <div class="row">
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label class="control-label">Institution Name</label>
                                        <span style="color: red;">*</span>

                                        <asp:DropDownList ID="DropDownList4" runat="server" class="form-control" Width="80%"></asp:DropDownList>



                                    </div>
                                </div>

                                 <div class="col-sm-4">
                                    <div class="form-group">
                                        <label class="control-label">Program Syllabus</label>
                                        <span style="color: red;">*</span>
                                         <asp:DropDownList ID="DropDownList3" runat="server" class="form-control" Width="80%"></asp:DropDownList>
                                        



                                    </div>
                                </div>

                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label class="control-label">Program Type</label>
                                        <span style="color: red;">*</span>

                                        

                                        <asp:DropDownList ID="DropDownList1" runat="server" class="form-control" Width="80%"></asp:DropDownList>

                                    </div>
                                </div>
                            </div>


                           

                            <div class="row">

                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label class="control-label">Program Name</label>
                                        <span style="color: red;">*</span>
                                         
                                         <asp:TextBox ID="TextBox2" runat="server" class="form-control" Width="80%"></asp:TextBox>



                                    </div>
                                </div>




                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label class="control-label">Program Duration</label>
                                        <span style="color: red;">*</span>
                                         
                                         <asp:TextBox ID="TextBox1" runat="server" class="form-control" Width="80%"></asp:TextBox>



                                    </div>
                                </div>



                                 <div class="col-sm-4">
                                    <div class="form-group">
                                        <label class="control-label">No Of Seats</label>
                                        <span style="color: red;">*</span>
                                        
                                        
                                         <asp:TextBox ID="TextBox3" runat="server" class="form-control" Width="80%"></asp:TextBox>


                                    </div>
                                </div>

                               
                                

                               
                            </div>


                            <div class="row">
                                 <div class="col-sm-4">
                                    <div class="form-group">
                                        <label class="control-label">Specialization</label>
                                        <span style="color: red;">*</span>

                                         <asp:DropDownList ID="DropDownList2" runat="server" class="form-control" Width="80%"></asp:DropDownList>



                                    </div>
                                </div>

                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label class="control-label">Remarks</label>
                                        <span style="color: red;">*</span>

                                        <asp:TextBox ID="TextBox9" runat="server" class="form-control" Width="80%"></asp:TextBox>

                                        

                                    </div>
                                </div>


                             
                            </div>




                        </div>



                    </div>
            </div>
            </div>


        </ContentTemplate>
    </asp:UpdatePanel>




</asp:Content>
