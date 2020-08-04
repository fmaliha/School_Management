<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="InstitutionEntry.aspx.cs" Inherits="InovexiaEBS.TextileEducation.InstitutionEntry" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script language="javascript">

        function ValidationMessage(message) {
            //alertify.alert('Please provide all data with red star!');

            alertify.alert(message);
        }


        
        function UserDeleteConfirmation() {
            if (confirm("Are you sure you want to delete ?"))
                return true;
            else
                return false;
        }

        function NotNegativeNumberKey(evt) {
            evt = (evt) ? evt : window.event;
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                return false;
            }
            return true;
        }

        function checkDec(el) {
            var ex = /^[0-9]+\.?[0-9]*$/;
            if (ex.test(el.value) == false) {
                el.value = el.value.substring(0, el.value.length - 1);
            }
        }

    </script>


    <style>
        .widthClass {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <%--    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>--%>


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
                    <h3 class="panel-title">Institute Management</h3>
                </div>
                <div class="panel-body">
                    <asp:HiddenField ID="hidInstitutionID" runat="server" />
                    <asp:HiddenField ID="hidInstitutionCode" runat="server" />
                    <asp:HiddenField ID="hidInstitutionName" runat="server" />
                    <div class="row">
                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Institution Name</label>
                                <span style="color: red;">*</span>
                                <asp:RequiredFieldValidator ID="rfvInstituationName" ControlToValidate="txtInstituationName" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txtInstituationName" runat="server" class="form-control"></asp:TextBox>



                            </div>
                        </div>

                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Institution Code</label>
                                <span style="color: red;">*</span>
                                <asp:RequiredFieldValidator ID="rfvInstitutionCode" ControlToValidate="txtInstitutionCode" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txtInstitutionCode" runat="server" class="form-control" AutoPostBack="true"></asp:TextBox>



                            </div>
                        </div>

                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Institution Type</label>
                                <span style="color: red;">*</span>
                                <asp:RequiredFieldValidator ID="rfvInstitutionType" ControlToValidate="ddlInstitutionType" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                <telerik:RadComboBox ID="ddlInstitutionType" runat="server"
                                    DropDownCssClass="widthClass"
                                    EmptyMessage="Select Institution Type" EnableLoadOnDemand="True" Filter="Contains"
                                    Height="200px" HighlightTemplatedItems="True"
                                    Width="100%"
                                    OnItemsRequested="ddlInstitutionType_ItemsRequested"
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

                                                <td><%# DataBinder.Eval(Container, "Attributes['InstitutionTypeName']")%></td>

                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </telerik:RadComboBox>
                            </div>
                        </div>
                    </div>




                    <div class="row">

                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Institution Category</label>
                                <span style="color: red;">*</span>

                                <asp:RequiredFieldValidator ID="rfvInstitutionCategory" ControlToValidate="ddlInstitutionCategory" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                <telerik:RadComboBox ID="ddlInstitutionCategory" runat="server"
                                    DropDownCssClass="widthClass"
                                    EmptyMessage="Select Category" EnableLoadOnDemand="True" Filter="Contains"
                                    Height="200px" HighlightTemplatedItems="True"
                                    Width="100%"
                                    OnItemsRequested="ddlInstitutionCategory_ItemsRequested"
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

                                                <td><%# DataBinder.Eval(Container, "Attributes['InstitutionCategoryName']")%></td>

                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </telerik:RadComboBox>


                                <%--<asp:DropDownList ID="ddlInstitutionCategory" runat="server" class="form-control" ></asp:DropDownList>--%>
                            </div>
                        </div>



                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Address</label>
                                <span style="color: red;">*</span>
                                <asp:RequiredFieldValidator ID="rfvAddres" ControlToValidate="txtAddres" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txtAddres" runat="server" class="form-control"></asp:TextBox>




                            </div>
                        </div>

                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Established Year</label>
                                <span style="color: red;">*</span>
                                <asp:RequiredFieldValidator ID="rfvEstablishedYear" ControlToValidate="txtEstablishedYear" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                <asp:TextBox ID="txtEstablishedYear" runat="server" onkeypress="return NotNegativeNumberKey(event)" class="form-control" TextMode="Number"></asp:TextBox>



                            </div>
                        </div>




                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Total Area</label>
                                <asp:TextBox ID="txtTotalArea" runat="server" onkeyup="checkDec(this);" class="form-control"></asp:TextBox>



                            </div>
                        </div>

                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">No Of Academic Building</label>
                                <asp:RegularExpressionValidator ID="revNoOfAcademicBuilding" runat="server" ValidationGroup="MasterValidation" ValidationExpression="^\d+" ControlToValidate="txtNoOfAcademicBuilding" ForeColor="Red" ErrorMessage="(Invalid)"></asp:RegularExpressionValidator>

                                <asp:TextBox ID="txtNoOfAcademicBuilding" onkeypress="return NotNegativeNumberKey(event)" runat="server" class="form-control" TextMode="Number"></asp:TextBox>



                            </div>
                        </div>
                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">No Of Lab</label>

                                <asp:RegularExpressionValidator ID="reftxtNoOfLab" runat="server" ValidationGroup="MasterValidation" ValidationExpression="^\d+" ControlToValidate="txtNoOfLab" ForeColor="Red" ErrorMessage="(Invalid)"></asp:RegularExpressionValidator>

                                <asp:TextBox ID="txtNoOfLab" runat="server" onkeypress="return NotNegativeNumberKey(event)" class="form-control" TextMode="Number"></asp:TextBox>



                            </div>
                        </div>



                    </div>

                    <div class="row">

                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Division</label>
                                <span style="color: red;">*</span>
                                <asp:RequiredFieldValidator ID="rvfddlDivision" ControlToValidate="ddlDivision" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                <telerik:RadComboBox ID="ddlDivision" runat="server"
                                    DropDownCssClass="widthClass"
                                    EmptyMessage="Select Division" EnableLoadOnDemand="True" Filter="Contains"
                                    Height="200px" HighlightTemplatedItems="True"
                                    Width="100%"
                                    OnItemsRequested="ddlDivision_ItemsRequested"
                                    OnSelectedIndexChanged="ddlDivision_OnSelectedIndexChanged"
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

                                                <td><%# DataBinder.Eval(Container, "Attributes['name']")%></td>

                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </telerik:RadComboBox>

                                <%--<asp:DropDownList ID="ddlDivision" runat="server" class="form-control" ></asp:DropDownList>--%>
                            </div>
                        </div>


                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">District</label>
                                <span style="color: red;">*</span>
                                <asp:RequiredFieldValidator ID="rvfDistrict" ControlToValidate="ddlDistrict" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                <telerik:RadComboBox ID="ddlDistrict" runat="server"
                                    DropDownCssClass="widthClass"
                                    EmptyMessage="Select District" EnableLoadOnDemand="True" Filter="Contains"
                                    Height="200px" HighlightTemplatedItems="True"
                                    Width="100%"
                                    OnItemsRequested="ddlDistrict_ItemsRequested"
                                    OnSelectedIndexChanged="ddlDistrict_OnSelectedIndexChanged"
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

                                                <td><%# DataBinder.Eval(Container, "Attributes['name']")%></td>

                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </telerik:RadComboBox>

                                <%--<asp:DropDownList ID="ddlDistrict" runat="server" class="form-control" ></asp:DropDownList>--%>
                            </div>
                        </div>

                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Thana</label>
                                <span style="color: red;">*</span>
                                <asp:RequiredFieldValidator ID="rvfddlThana" ControlToValidate="ddlThana" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                <telerik:RadComboBox ID="ddlThana" runat="server"
                                    DropDownCssClass="widthClass"
                                    EmptyMessage="Select Thana" EnableLoadOnDemand="True" Filter="Contains"
                                    Height="200px" HighlightTemplatedItems="True"
                                    Width="100%"
                                    OnItemsRequested="ddlThana_ItemsRequested"
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

                                                <td><%# DataBinder.Eval(Container, "Attributes['name']")%></td>

                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </telerik:RadComboBox>


                                <%--<asp:DropDownList ID="ddlThana" runat="server" class="form-control" ></asp:DropDownList>--%>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Total Investment</label>
                                <%--  <span style="color: red;">*</span>--%>

                                <asp:TextBox ID="txtTotalInvestment" onkeyup="checkDec(this);" runat="server" class="form-control"></asp:TextBox>



                            </div>
                        </div>

                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Initial Investment</label>


                                <asp:TextBox ID="txtInitialInvestment" onkeyup="checkDec(this);" runat="server" class="form-control"></asp:TextBox>



                            </div>
                        </div>
                        <div class="col-sm-4">
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
                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Telephone</label>
                                <%--  <span style="color: red;">*</span>--%>

                                <asp:TextBox ID="txtTelephone" runat="server" class="form-control"></asp:TextBox>



                            </div>
                        </div>

                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">FAX</label>


                                <asp:TextBox ID="txtFax" runat="server" class="form-control"></asp:TextBox>



                            </div>
                        </div>
                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Social Site Info</label>


                                <asp:TextBox ID="txtSocialSiteInfo" runat="server" class="form-control"></asp:TextBox>



                            </div>
                        </div>



                    </div>




                    <div class="row">

                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Latitude</label>


                                <asp:TextBox ID="txtLatitude" runat="server" class="form-control"></asp:TextBox>



                            </div>
                        </div>

                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Longitute</label>


                                <asp:TextBox ID="txtLongitute" runat="server" class="form-control"></asp:TextBox>



                            </div>
                        </div>

                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Website</label>


                                <asp:TextBox ID="txtWebSite" runat="server" class="form-control"></asp:TextBox>



                            </div>
                        </div>

                    </div>


                    <div class="row">

                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Remarks</label>


                                <asp:TextBox ID="txtRemark" runat="server" class="form-control"></asp:TextBox>



                            </div>
                        </div>

                        <div class="col-sm-4">
                            <div class="form-group">
                                <label class="control-label">Logo</label>
                                <asp:FileUpload ID="fuInstituteLog" runat="server" class="form-control" />


                            </div>
                        </div>

                       

                        <div class="col-sm-3" id="ShowLogo" runat="server">
                            <div class="form-group">
                                <asp:Image ID="ImgShowLogo" runat="server" Height="100" Width="200" />

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
                            <asp:Button ID="btnNew" CssClass="btn btn-info margin-right-btn" runat="server" Text="NEW" OnClick="btnNew_Click" />
                        </div>
                    </div>
                    <h3 class="panel-title">Institute Management List</h3>
                </div>
                <div class="panel-body">


                    <div class="row">
                        <telerik:RadGrid ID="grdInstitutionList" runat="server" CellSpacing="0" GridLines="None" Height="100%" Skin="Silk" OnNeedDataSource="grdInstitutionList_NeedDataSource" Width="100%"
                            AllowPaging="true"
                            AllowFilteringByColumn="True" PageSize="10">
                            <ClientSettings>
                                <%--  <Scrolling AllowScroll="True" />--%>
                            </ClientSettings>
                            <MasterTableView DataKeyNames="InstitutionID">
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

    <%--</ContentTemplate>

        <Triggers>
            <asp:PostBackTrigger ControlID="btnSave" />
          
        </Triggers>
    </asp:UpdatePanel>--%>
</asp:Content>
