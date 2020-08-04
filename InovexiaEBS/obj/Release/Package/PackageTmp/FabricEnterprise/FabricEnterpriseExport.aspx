<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="FabricEnterpriseExport.aspx.cs" Inherits="InovexiaEBS.FabricEnterprise.FabricEnterpriseExport" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script type="text/javascript">

        function ValidationMessage(message) {
            alertify.alert(message);
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script language="javascript">
        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode != 46 && charCode > 31
              && (charCode < 48 || charCode > 57))
                return false;
            return true;
        }
    </script>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
             <asp:HiddenField ID="hdMasterID" runat="server" />
            <div class="row" id="MasterPanel" runat="server">
                <div class="col-lg-12">
                    <div class="panel">
                        <div class="panel-heading">
                            <div class="panel-control">
                                <div class="pull-right" style="padding: 5px;">
                                    <asp:Button ID="btnSave" CssClass="btn btn-info margin-right-btn" runat="server" ValidationGroup="MasterValidation" CausesValidation="True" Text="Save" OnClick="btnSave_Click" />

                                    <asp:Button ID="btnList" CssClass="btn btn-info margin-right-btn" runat="server" Text="List" OnClick="btnList_Click"  />

                                </div>
                            </div>
                            <h3 class="panel-title">Enterprise Export</h3>
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
                                                            <label class="control-label">Enterprise </label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvddlEnterprise" ControlToValidate="ddlEnterprise" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <telerik:RadComboBox ID="ddlEnterprise" runat="server"
                                                                DropDownCssClass="widthClass"
                                                                EmptyMessage="Select Enterprise" EnableLoadOnDemand="True" Filter="Contains"
                                                                Height="200px" HighlightTemplatedItems="True"
                                                                Width="100%"
                                                                OnItemsRequested="ddlEnterprise_ItemsRequested"
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

                                                                            <td><%# DataBinder.Eval(Container, "Attributes['EnterpriseName']")%></td>

                                                                        </tr>
                                                                    </table>
                                                                </ItemTemplate>
                                                            </telerik:RadComboBox>

                                                        </div>
                                                    </div>
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Item Details</label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvExportItemDetails" ControlToValidate="txtExportItemDetails" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>

                                                            <asp:TextBox ID="txtExportItemDetails" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Quantity</label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvQuantity" ControlToValidate="txtQuantity" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>

                                                            <asp:TextBox ID="txtQuantity" runat="server" onkeypress="return isNumberKey(event)" class="form-control"></asp:TextBox>
                                                        </div>


                                                    </div>
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Total Value</label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvTotalValue" ControlToValidate="txtTotalValue" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>

                                                            <asp:TextBox ID="txtTotalValue" runat="server" onkeypress="return isNumberKey(event)" class="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                </div>

                                                <div class="row">
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Measurement Unit </label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvMeasurementUnit" ControlToValidate="ddlMeasurementUnit" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <telerik:RadComboBox ID="ddlMeasurementUnit" runat="server"
                                                                DropDownCssClass="widthClass"
                                                                EmptyMessage="Select Measurement Unit" EnableLoadOnDemand="True" Filter="Contains"
                                                                Height="200px" HighlightTemplatedItems="True"
                                                                Width="100%"
                                                                OnItemsRequested="ddlMeasurementUnit_ItemsRequested"
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

                                                                            <td><%# DataBinder.Eval(Container, "Attributes['MeasurementUnitName']")%></td>

                                                                        </tr>
                                                                    </table>
                                                                </ItemTemplate>
                                                            </telerik:RadComboBox>

                                                        </div>
                                                    </div>
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Year </label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvddlExportYear" ControlToValidate="ddlExportYear" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <telerik:RadComboBox ID="ddlExportYear" runat="server"
                                                                DropDownCssClass="widthClass"
                                                                EmptyMessage="Select  Year" EnableLoadOnDemand="True" Filter="Contains"
                                                                Height="200px" HighlightTemplatedItems="True"
                                                                Width="100%"
                                                                OnItemsRequested="ddlExportYear_ItemsRequested"
                                                                Skin="Silk" Style="background-color: #339966;" AutoPostBack="true">
                                                                <HeaderTemplate>
                                                                    <table cellpadding="0" cellspacing="0">
                                                                        <tr>

                                                                            <td>Year</td>

                                                                        </tr>
                                                                    </table>
                                                                </HeaderTemplate>
                                                                <ItemTemplate>
                                                                    <table cellpadding="0" cellspacing="0">
                                                                        <tr>

                                                                            <td><%# DataBinder.Eval(Container, "Attributes['Year']")%></td>

                                                                        </tr>
                                                                    </table>
                                                                </ItemTemplate>
                                                            </telerik:RadComboBox>

                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Country </label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvCountry" ControlToValidate="ddlCountry" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <telerik:RadComboBox ID="ddlCountry" runat="server"
                                                                DropDownCssClass="widthClass"
                                                                EmptyMessage="Select Country" EnableLoadOnDemand="True" Filter="Contains"
                                                                Height="200px" HighlightTemplatedItems="True"
                                                                Width="100%"
                                                                OnItemsRequested="ddlCountry_ItemsRequested"
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

                                                                            <td><%# DataBinder.Eval(Container, "Attributes['name']")%></td>

                                                                        </tr>
                                                                    </table>
                                                                </ItemTemplate>
                                                            </telerik:RadComboBox>

                                                        </div>

                                                    </div>
                                                    <div class="col-sm-6">
                                                        <div class="form-group">

                                                            <label class="control-label">Remarks</label>

                                                            <asp:TextBox ID="txtRemark" runat="server" class="form-control"></asp:TextBox>

                                                        </div>
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
              <div class="row" id="ListPanel" runat="server">
                <div class="col-lg-12">
                    <div class="panel">
                        <div class="panel-heading">
                            <div class="panel-control">
                                <div class="pull-right" style="padding: 5px;">
                                    <asp:Button ID="btnNew" CssClass="btn btn-info margin-right-btn" runat="server" Text="New" OnClick="btnNew_Click" />
                                </div>
                            </div>
                            <h3 class="panel-title">Enterprise Export</h3>
                        </div>
                        <div class="panel-body">


                            <div class="row">
                                <telerik:RadGrid ID="grdEnterpriseExport" runat="server" CellSpacing="0" GridLines="None" Height="100%" Skin="Silk" OnNeedDataSource="grdInstitutionPrograms_NeedDataSource" Width="100%"
                                    AllowPaging="true"
                                    AllowFilteringByColumn="True" PageSize="5">
                                    <ClientSettings>
                                        <%--  <Scrolling AllowScroll="True" />--%>
                                    </ClientSettings>
                                    <MasterTableView DataKeyNames="EnterpriseExportID">
                                        <Columns>
                                            <telerik:GridTemplateColumn HeaderStyle-Width="20px">
                                                <ItemTemplate>
                                                    <telerik:RadButton ID="btnView" runat="server" Skin="Silk" Visible="true" Text="View" OnClick="btnView_Click">
                                                        <Icon PrimaryIconCssClass="rbEdit" />
                                                    </telerik:RadButton>
                                                </ItemTemplate>
                                                <HeaderStyle Width="40px" />
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
