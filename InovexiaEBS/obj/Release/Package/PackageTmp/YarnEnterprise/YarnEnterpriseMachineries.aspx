<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="YarnEnterpriseMachineries.aspx.cs" Inherits="InovexiaEBS.YarnEnterprise.YarnEnterpriseMachineries" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script language="javascript">

        function ValidationMessage(message) {
            //alertify.alert('Please provide all data with red star!');

            alertify.alert(message);
        }

        function NotNegativeNumberKey(evt) {
            evt = (evt) ? evt : window.event;
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                return false;
            }
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
                            <h3 class="panel-title">Yarn Enterprise Machineries</h3>
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
                                                          <asp:HiddenField ID="hidEnterpriseMachineriesID" runat="server" />
                                                        <div class="form-group">

                                                            <label class="control-label">Enterprise Name </label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvEnterPrise" ControlToValidate="ddlEnterprise" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
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

                                                                            <td>NAME</td>

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
                                                            <label class="control-label">Machine Name</label>
                                                             <span style="color: red;">*</span>
                                                             <asp:RequiredFieldValidator ID="rfvMachineName" ControlToValidate="txtMachineName" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            
                                                            <asp:TextBox ID="txtMachineName" runat="server" class="form-control"  ></asp:TextBox>
                                                        </div>
                                                    </div>


                                                </div>
                                                <div class="row">
                                                   <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Machine Type</label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvMachineType" ControlToValidate="ddlMachineType" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <telerik:RadComboBox ID="ddlMachineType" runat="server"
                                                                DropDownCssClass="widthClass"
                                                                Width="100%"
                                                                EmptyMessage="Select Machine Type" EnableLoadOnDemand="True" Filter="Contains"
                                                                Height="200px" HighlightTemplatedItems="True"
                                                                OnItemsRequested="ddlMachineType_ItemsRequested"
                                                                Skin="Silk" Style="background-color: #339966;" AutoPostBack="true">
                                                                <HeaderTemplate>
                                                                    <table cellpadding="0" cellspacing="0" >
                                                                        <tr>
                                                                            <td  >Machine Type</td>
                                                                              
                                                                        </tr>
                                                                    </table>
                                                                </HeaderTemplate>
                                                                <ItemTemplate>
                                                                    <table cellpadding="0" cellspacing="0">
                                                                        <tr>
                                                                            <td ><%# DataBinder.Eval(Container, "Text")%></td>
                                                                             
                                                                        </tr>
                                                                    </table>
                                                                </ItemTemplate>
                                                            </telerik:RadComboBox>

                                                        </div>
                                                    </div>
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">No of Machine</label>
                                                            <span style="color: red;">*</span>                                                         
                                                             <asp:RequiredFieldValidator ID="rfvNumberOfMachine" ControlToValidate="txtNumberOfMachine" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <asp:TextBox ID="txtNumberOfMachine" onkeypress="return NotNegativeNumberKey(event)" runat="server" TextMode="Number" class="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                    
                                                </div>
                                                <div class="row">
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Machine Details</label>
                                                            <asp:TextBox ID="txtMachineDetails" runat="server" class="form-control"></asp:TextBox>

                                                        </div>
                                                    </div>
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Remarks</label>
                                                            <asp:TextBox ID="txtReamrk" runat="server" class="form-control"></asp:TextBox>

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
                                    <MasterTableView DataKeyNames="EnterpriseMachineriesID">
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
