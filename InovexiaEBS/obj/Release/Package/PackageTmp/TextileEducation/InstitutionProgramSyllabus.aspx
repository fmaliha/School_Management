<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="InstitutionProgramSyllabus.aspx.cs" Inherits="InovexiaEBS.TextileEducation.InstitutionProgramSyllabus" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript">

        function ValidationMessage(message) {
            alertify.alert(message);
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
                                    <asp:Button ID="btnSave" CssClass="btn btn-info margin-right-btn" runat="server" ValidationGroup="MasterValidation" CausesValidation="True" Text="SAVE" OnClick="btnSave_Click" />

                                    <asp:Button ID="btnList" CssClass="btn btn-info margin-right-btn" runat="server" Text="List" OnClick="btnList_Click" />

                                </div>
                            </div>
                            <h3 class="panel-title">Institution Program Syllabus</h3>
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
                                                            <label class="control-label">Program </label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvProgram" ControlToValidate="ddlProgram" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <telerik:RadComboBox ID="ddlProgram" runat="server"
                                                                DropDownCssClass="widthClass"
                                                                EmptyMessage="Select Program" EnableLoadOnDemand="True" Filter="Contains"
                                                                Height="200px" HighlightTemplatedItems="True"
                                                                Width="100%"
                                                                OnItemsRequested="ddlProgram_ItemsRequested"
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
                                                                            <td ><%# DataBinder.Eval(Container, "Text")%></td>

                                                                        </tr>
                                                                    </table>
                                                                </ItemTemplate>
                                                            </telerik:RadComboBox>

                                                        </div>
                                                    </div>
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Course Code</label>
                                                             <span style="color: red;">*</span>
                                                            <asp:TextBox ID="txtCourseCode" runat="server" class="form-control"  ></asp:TextBox>
                                                             <asp:RequiredFieldValidator ID="rfvCourseCode" ControlToValidate="txtCourseCode" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>

                                                        </div>
                                                    </div>
                                                    
                                                </div>
                                                <div class="row">
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Course Title</label><span style="color: red;">*</span>
                                                             <asp:RequiredFieldValidator ID="rfvCourseTitle" ControlToValidate="txtCourseTitle" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                             <asp:TextBox ID="txtCourseTitle" runat="server" class="form-control"  ></asp:TextBox>
                                                        </div>
                                                    </div>
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Course Description</label>
                                                            <asp:TextBox ID="txtCourseDescription" runat="server" class="form-control"></asp:TextBox>

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
                            <h3 class="panel-title">Institution Program Syllabus</h3>
                        </div>
                        <div class="panel-body">


                            <div class="row">
                                <telerik:RadGrid ID="grdInstitutionSyllabus" runat="server" CellSpacing="0" GridLines="None" Height="100%" Skin="Silk" OnNeedDataSource="grdInstitutionPrograms_NeedDataSource" Width="100%"
                                    AllowPaging="true"
                                    AllowFilteringByColumn="True" PageSize="2">
                                    <ClientSettings>
                                        <%--  <Scrolling AllowScroll="True" />--%>
                                    </ClientSettings>
                                    <MasterTableView DataKeyNames="SyllabusID">
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

