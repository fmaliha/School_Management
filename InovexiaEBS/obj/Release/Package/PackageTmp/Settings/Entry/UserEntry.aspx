<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="UserEntry.aspx.cs" Inherits="InovexiaEBS.Settings.Entry.UserEntry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <div class="panel-heading">
                    <div class="panel-control">
                    </div>
                    <h3 class="panel-title">User Entry</h3>
                </div>
                <div class="panel-body">


                    <div class="row">


                        <div class="col-sm-6">
                            <div class="form-group">
                                <label class="control-label">Name</label> <span style="color:red;">*</span>
                                <asp:TextBox ID="txtName" runat="server" class="form-control"></asp:TextBox>
                              
                            </div>
                        </div>
                        <div class="col-sm-6">
                            <div class="form-group">
                                <label class="control-label">Login ID</label><span style="color:red;">*</span>
                                <asp:TextBox ID="txtULoginID" runat="server" class="form-control" AutoPostBack="true" OnTextChanged="txtLoginID_TextChanged"></asp:TextBox>
                            </div>
                        </div>

                    </div>


                    <div class="row">


                        <div class="col-sm-6">
                            <div class="form-group">
                                <label class="control-label">Password</label><span style="color:red;">*</span>
                                <asp:TextBox ID="txtUPassword" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-sm-6">
                            <div class="form-group">
                                <label class="control-label">Email</label><span style="color:red;">*</span>
                                <asp:TextBox ID="txtEmail" runat="server" class="form-control"></asp:TextBox>
                            </div>
                        </div>

                    </div>

                    <div class="row">


                        <div class="col-sm-6">
                            <div class="form-group">
                                <label class="control-label">User Type</label><span style="color:red;">*</span>
                             
                                <asp:DropDownList ID="ddlUserType" runat="server" class="form-control">
                                </asp:DropDownList>

                            </div>
                        </div>

                    </div>




                </div>

                <div class="panel-footer text-right">
                    <asp:Button ID="btnSave" class="btn btn-info" runat="server" Text="SAVE" OnClick="btnSave_Click" />
                </div>

            </div>
        </div>
    </div>
</asp:Content>
