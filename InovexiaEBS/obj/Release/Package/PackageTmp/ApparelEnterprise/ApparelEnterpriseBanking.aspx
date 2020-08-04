<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="ApparelEnterpriseBanking.aspx.cs" Inherits="InovexiaEBS.ApparelEnterprise.ApparelEnterpriseBanking" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script language="javascript">

        function ValidationMessage(message) {
            //alertify.alert('Please provide all data with red star!');

            alertify.alert(message);
        }

        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode != 46 && charCode > 31
              && (charCode < 48 || charCode > 57))
                return false;
            return true;
        }

        function UserDeleteConfirmation() {
            if (confirm("Are you sure you want to delete ?"))
                return true;
            else
                return false;
        }
        function checkDec(el) {
            var ex = /^[0-9]+\.?[0-9]*$/;
            if (ex.test(el.value) == false) {
                el.value = el.value.substring(0, el.value.length - 1);
            }
        }

    </script>


    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>

            <div class="row" id="MasterPanel" runat="server">
                <div class="col-lg-12">
                    <div class="panel">
                        <div class="panel-heading">
                            <div class="panel-control">
                                <div class="pull-right" style="padding: 5px;">
                                    <asp:Button ID="btnRefresh" CssClass="btn btn-info margin-right-btn" runat="server" Text="NEW" OnClick="btnRefresh_Click" />
                                    <asp:Button ID="btnSave" CssClass="btn btn-info margin-right-btn" runat="server" ValidationGroup="MasterValidation" Text="SAVE" OnClick="btnSave_Click" />
                                    <asp:Button ID="btnDelete" CssClass="btn btn-danger" runat="server" Text="DELETE" OnClientClick="return UserDeleteConfirmation();" OnClick="btnDelete_Click" />

                                    <asp:Button ID="btnList" CssClass="btn btn-info margin-right-btn" runat="server" Text="List" OnClick="btnList_Click" />

                                </div>
                            </div>
                            <h3 class="panel-title">Yarn Enterprise Banking</h3>
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
                                                        <asp:HiddenField ID="hidEnterpriseBankID" runat="server" />
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

                                                                            <td>Enterpise</td>

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
                                                            <label class="control-label">Bank </label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvddlbank" ControlToValidate="ddlBank" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <telerik:RadComboBox ID="ddlBank" runat="server"
                                                                DropDownCssClass="widthClass"
                                                                EmptyMessage="Select Bank" EnableLoadOnDemand="True" Filter="Contains"
                                                                Height="200px" HighlightTemplatedItems="True"
                                                                Width="100%"
                                                                OnItemsRequested="ddlBank_ItemsRequested"
                                                                Skin="Silk" Style="background-color: #339966;" AutoPostBack="true">
                                                                <HeaderTemplate>
                                                                    <table cellpadding="0" cellspacing="0">
                                                                        <tr>
                                                                            <td>Bank</td>
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
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Branch Info  </label>
                                                             <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvBanckInfo" ControlToValidate="txtBranchInfo" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <asp:TextBox ID="txtBranchInfo" runat="server" class="form-control"></asp:TextBox>

                                                        </div>
                                                    </div>

                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Loan Amount  </label>
                                                              <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvLoanAmount" ControlToValidate="txtLoanAmount" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <asp:TextBox ID="txtLoanAmount" onkeyup="checkDec(this);" runat="server" class="form-control" ></asp:TextBox>

                                                        </div>
                                                    </div>


                                                </div>

                                                <div class="row">
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Remarks</label>
                                                            <asp:TextBox ID="txtRemarks" runat="server" class="form-control"></asp:TextBox>
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
                            <h3 class="panel-title">Enterprise Future Marketing List</h3>
                        </div>
                        <div class="panel-body">


                            <div class="row">
                                <telerik:RadGrid ID="grdDetails" runat="server" CellSpacing="0" GridLines="None" Height="100%" Skin="Silk" OnNeedDataSource="grdDetails_NeedDataSource" Width="100%"
                                    AllowPaging="true"
                                    AllowFilteringByColumn="True" PageSize="10">
                                    <ClientSettings>
                                        <%--  <Scrolling AllowScroll="True" />--%>
                                    </ClientSettings>
                                    <MasterTableView DataKeyNames="EnterpriseBankID">
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


