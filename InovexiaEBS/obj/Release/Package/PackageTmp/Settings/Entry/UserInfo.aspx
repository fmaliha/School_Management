<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="InovexiaEBS.Settings.Entry.UserInfo" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        .widthClass {
            width: 100%;
        }
    </style>
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
                                    <asp:Button ID="btnSave" CssClass="btn btn-info margin-right-btn" runat="server" ValidationGroup="MasterValidation" CausesValidation="True" Text="Save" OnClick="btnSave_Click" />

                                    <asp:Button ID="btnList" CssClass="btn btn-info margin-right-btn" runat="server" Text="List" OnClick="btnList_Click" />

                                </div>
                            </div>
                            <h3 class="panel-title">User Info</h3>

                        </div>

                        <div class="panel-body">
                            <div class="row">
                                <div class="eq-height">
                                    <div class="col-sm-6 eq-box-sm">
                                        <div class="panel">
                                            <!--Block Styled Form -->
                                            <!--===================================================-->
                                            <div class="panel-body">
                                                <div class="row">
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Name</label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvName" ControlToValidate="txtName" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>

                                                            <asp:TextBox ID="txtName" runat="server" class="form-control"></asp:TextBox>

                                                        </div>
                                                    </div>
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Email</label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvEmail1" ControlToValidate="txtEmail" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <asp:RegularExpressionValidator ID="rfvEmail" runat="server" ValidationGroup="MasterValidation" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail" ForeColor="Red" ErrorMessage="(Invalid Address)"></asp:RegularExpressionValidator>
                                                            <asp:TextBox ID="txtEmail" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Login ID</label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvLoginID" ControlToValidate="txtULoginID" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <asp:TextBox ID="txtULoginID" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Password</label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvPassword" ControlToValidate="txtUPassword" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <asp:TextBox ID="txtUPassword" runat="server" class="form-control" TextMode="Password"></asp:TextBox>

                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-sm-6">
                                                        <div class="form-group">

                                                            <label class="control-label">Contact No</label><span style="color: red;"></span>
                                                            <asp:RegularExpressionValidator ID="revContactNumber" runat="server" ValidationGroup="MasterValidation" ValidationExpression="^\d+" ControlToValidate="txtContactNumber" ForeColor="Red" ErrorMessage="(Invalid)"></asp:RegularExpressionValidator>
                                                            <asp:TextBox ID="txtContactNumber" runat="server" class="form-control"></asp:TextBox>

                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!--===================================================-->
                                            <!--End Block Styled Form -->
                                        </div>
                                    </div>
                                    <div class="col-sm-6 eq-box-sm">
                                        <div class="panel">
                                            <!--Block Styled Form -->
                                            <!--===================================================-->
                                            <div class="panel-body">
                                                <div class="row">
                                                    <div class="col-sm-12">
                                                        <div class="form-group">
                                                            <label class="control-label">Stake Holder Type</label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvStakeHolderType" ControlToValidate="ddlStakeHolderType" ValidationGroup="DetailValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <telerik:RadComboBox ID="ddlStakeHolderType" runat="server"
                                                                DropDownCssClass="widthClass"
                                                                Width="100%"
                                                                EmptyMessage="Select StakeHolder Type" EnableLoadOnDemand="True" Filter="Contains"
                                                                Height="200px" HighlightTemplatedItems="True"
                                                                OnItemsRequested="ddlStakeHolderType_ItemsRequested"
                                                                OnSelectedIndexChanged="ddlStakeHolderType_SelectedIndexChanged"
                                                                Skin="Silk" Style="background-color: #339966;" AutoPostBack="true">
                                                                <HeaderTemplate>
                                                                    <table cellpadding="0" cellspacing="0">
                                                                        <tr>
                                                                            <td>Stakeholder Type </td>
                                                                        </tr>
                                                                    </table>
                                                                </HeaderTemplate>
                                                                <ItemTemplate>
                                                                    <table cellpadding="0" cellspacing="0">
                                                                        <tr>
                                                                            <td><%# DataBinder.Eval(Container, "Text")%></td>
                                                                        </tr>
                                                                    </table>
                                                                </ItemTemplate>
                                                            </telerik:RadComboBox>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-sm-12">
                                                        <div class="form-group">
                                                            <label class="control-label">Stake Holder</label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvStakeHolder" ControlToValidate="ddlStakeHolder" ValidationGroup="DetailValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <telerik:RadComboBox ID="ddlStakeHolder" runat="server"
                                                                DropDownCssClass="widthClass"
                                                                Width="100%"
                                                                EmptyMessage="Select StakeHolder" EnableLoadOnDemand="True" Filter="Contains"
                                                                Height="200px" HighlightTemplatedItems="True"
                                                                OnItemsRequested="ddlStakeHolder_ItemsRequested"
                                                                Skin="Silk" Style="background-color: #339966;" AutoPostBack="true">
                                                                <HeaderTemplate>
                                                                    <table cellpadding="0" cellspacing="0">
                                                                        <tr>
                                                                            <td>Stakeholder  </td>
                                                                        </tr>
                                                                    </table>
                                                                </HeaderTemplate>
                                                                <ItemTemplate>
                                                                    <table cellpadding="0" cellspacing="0">
                                                                        <tr>
                                                                            <td><%# DataBinder.Eval(Container, "Text")%></td>
                                                                        </tr>
                                                                    </table>
                                                                </ItemTemplate>
                                                            </telerik:RadComboBox>
                                                        </div>
                                                    </div>

                                                </div>



                                            </div>
                                            <!--===================================================-->
                                            <!--End Block Styled Form -->

                                        </div>
                                    </div>
                                </div>
                                <div class="row" style="margin-top: -20px">
                                    <div class="col-sm-12">
                                        <div class="form-group">
                                            <div class="col-sm-offset-11 col-sm-1">
                                                <asp:Button ID="btnAdd" runat="server" class="form-control btn btn-info" Text="Add" CausesValidation="true" ValidationGroup="DetailValidation" OnClick="btnAdd_Click"></asp:Button>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>

                            <div class="row" id="DetailPanel" runat="server" style="margin-top: 5px;">
                                <telerik:RadGrid ID="grdDetailsList" runat="server" CellSpacing="0" GridLines="None" Height="200px" Skin="Silk" Width="100%">
                                    <ClientSettings>
                                        <Scrolling AllowScroll="True" />
                                    </ClientSettings>
                                    <MasterTableView DataKeyNames="MappingID">
                                        <Columns>
                                            <telerik:GridTemplateColumn HeaderStyle-Width="40px">
                                                <ItemTemplate>
                                                    <telerik:RadButton ID="btnEdit" runat="server" Text="D" OnClick="btnDeleteDetails_Click">
                                                        <Icon PrimaryIconCssClass="rbCancel" />
                                                    </telerik:RadButton>
                                                </ItemTemplate>

                                            </telerik:GridTemplateColumn>

                                        </Columns>

                                        <CommandItemSettings ExportToPdfText="Export to PDF" />
                                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" Visible="True">
                                            <HeaderStyle Width="20px" />
                                        </RowIndicatorColumn>
                                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" Visible="True">
                                            <HeaderStyle Width="20px" />
                                        </ExpandCollapseColumn>
                                        <EditFormSettings>
                                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                            </EditColumn>
                                        </EditFormSettings>
                                        <PagerStyle PageSizeControlType="RadComboBox" />
                                    </MasterTableView>
                                    <PagerStyle PageSizeControlType="RadComboBox" />
                                    <FilterMenu EnableImageSprites="False">
                                    </FilterMenu>
                                </telerik:RadGrid>

                            </div>
                        </div>

                    </div>
                </div>
            </div>


            <div class="row" id="ListPanel" runat="server">
                <div class="col-lg-12">
                    <div class="panel">
                        <div class="panel-heading">
                            <div class="panel-control">
                                <div class="pull-right" style="padding: 5px;">
                                    <asp:Button ID="btnNew" CssClass="btn btn-info margin-right-btn" runat="server" Text="New" OnClick="btnNew_Click" />
                                </div>
                            </div>
                            <h3 class="panel-title">User List</h3>
                        </div>
                        <div class="panel-body">


                            <div class="row">
                                <telerik:RadGrid ID="grdList" runat="server" CellSpacing="0" GridLines="None" Height="400px" Skin="Silk" Width="100%">
                                    <ClientSettings>
                                        <Scrolling AllowScroll="True" />
                                    </ClientSettings>
                                    <MasterTableView DataKeyNames="pin_number">
                                        <Columns>

                                            <telerik:GridTemplateColumn HeaderStyle-Width="40px">
                                                <ItemTemplate>
                                                    <telerik:RadButton ID="btnEdit" runat="server" Text="E" OnClick="btnEdit_Click">
                                                        <Icon PrimaryIconCssClass="rbEdit" />
                                                    </telerik:RadButton>
                                                </ItemTemplate>

                                            </telerik:GridTemplateColumn>
                                        </Columns>

                                        <CommandItemSettings ExportToPdfText="Export to PDF" />
                                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" Visible="True">
                                            <HeaderStyle Width="20px" />
                                        </RowIndicatorColumn>
                                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" Visible="True">
                                            <HeaderStyle Width="20px" />
                                        </ExpandCollapseColumn>
                                        <EditFormSettings>
                                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                            </EditColumn>
                                        </EditFormSettings>
                                        <PagerStyle PageSizeControlType="RadComboBox" />
                                    </MasterTableView>
                                    <PagerStyle PageSizeControlType="RadComboBox" />
                                    <FilterMenu EnableImageSprites="False">
                                    </FilterMenu>
                                </telerik:RadGrid>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
