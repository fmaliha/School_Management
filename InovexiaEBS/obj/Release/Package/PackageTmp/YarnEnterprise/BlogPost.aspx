<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="BlogPost.aspx.cs" Inherits="InovexiaEBS.YarnEnterprise.BlogPost" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <div class="row" id="MasterPanel" runat="server">
                <div class="col-lg-12">
                    <div class="panel">
                        <div class="panel-heading">
                            <div class="panel-control">
                                <div class="pull-right" style="padding: 5px;">
                                    <asp:Button ID="btnSave" CssClass="btn btn-info margin-right-btn" runat="server" ValidationGroup="MasterValidation" CausesValidation="True" Text="Save" />

                                    <asp:Button ID="btnList" CssClass="btn btn-info margin-right-btn" runat="server" Text="List" />


                                </div>
                            </div>
                            <h3 class="panel-title">Blog Post</h3>
                        </div>
                        <div class="panel-body">
                            <div class="row">
                                <div class="eq-height">
                                    <div class="col-sm-6 eq-box-sm">

                                        <div class="panel">
                                            <!--Block Styled Form -->
                                            <!--===================================================-->
                                            <div class="panel-body">
                                                
                                                 <div class="row" style="padding-top:10px;">
                                                    <div class="col-sm-1">
                                                        Type
                                                    </div>
                                                    <div class="col-sm-10">
                                                       
                                                        <telerik:RadComboBox ID="ddlPostType" runat="server"
                                                                DropDownCssClass="widthClass"
                                                                EmptyMessage="" EnableLoadOnDemand="True" Filter="Contains"
                                                                Height="200px" HighlightTemplatedItems="True"
                                                                Width="100%"
                                                                OnItemsRequested="ddlPostType_ItemsRequested"
                                                                Skin="Silk" Style="background-color: #339966;" AutoPostBack="true">
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

                                                                            <td><%# DataBinder.Eval(Container, "Attributes['PostTypeName']")%></td>

                                                                        </tr>
                                                                    </table>
                                                                </ItemTemplate>
                                                            </telerik:RadComboBox>

                                                    </div>
                                                    <div class="col-sm-1">
                                                    </div>
                                                </div>

                                                <div class="row" style="padding-top:10px;">
                                                    <div class="col-sm-1">
                                                        Title
                                                    </div>
                                                    <div class="col-sm-10">
                                                        <asp:TextBox ID="txtExportItemDetails" runat="server" class="form-control"></asp:TextBox>
                                                    </div>
                                                    <div class="col-sm-1">
                                                    </div>
                                                </div>
                                                <div class="row" style="padding-top:10px;">
                                                    <div class="col-sm-1">
                                                        Details
                                                    </div>
                                                    <div class="col-sm-10">
                                                        <CKEditor:CKEditorControl ID="CKEditor1" BasePath="/ckeditor/" runat="server"></CKEditor:CKEditorControl>
                                                    </div>
                                                    <div class="col-sm-1">
                                                    </div>
                                                </div>
                                                 <div class="row" style="padding-top:10px;">
                                                    <div class="col-sm-1">
                                                        Remarks
                                                    </div>
                                                    <div class="col-sm-10">
                                                        <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
                                                    </div>
                                                    <div class="col-sm-1">
                                                    </div>
                                                </div>
                                                
                                            </div>
                                            <!--===================================================-->
                                            <!--End Block Styled Form -->
                                        </div>
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
