<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="ApparelEnterpriseInvestment.aspx.cs" Inherits="InovexiaEBS.ApparelEnterprise.ApparelEnterpriseInvestment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                            <h3 class="panel-title">Enterprise Investment</h3>
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
                                                            <label class="control-label">Investment Type </label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvInvestmentType" ControlToValidate="ddlInvestmentType" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <telerik:RadComboBox ID="ddlInvestmentType" runat="server"
                                                                DropDownCssClass="widthClass"
                                                                EmptyMessage="Select Investment Tyoe" EnableLoadOnDemand="True" Filter="Contains"
                                                                Height="200px" HighlightTemplatedItems="True"
                                                                Width="100%"
                                                                OnItemsRequested="ddlInvestmentType_ItemsRequested"
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

                                                                            <td><%# DataBinder.Eval(Container, "Attributes['InvestmentTypeName']")%></td>

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
                                                            <label class="control-label">Amount</label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvTotalValue" ControlToValidate="txtAmount" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>

                                                            <asp:TextBox ID="txtAmount" runat="server" onkeypress="return isNumberKey(event)" class="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-sm-6">
                                                        <div class="form-group">

                                                            <label class="control-label">Remarks</label>

                                                            <asp:TextBox ID="txtRemark" runat="server" class="form-control"></asp:TextBox>

                                                        </div>

                                                    </div>
                                                    <div class="col-sm-6">
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
