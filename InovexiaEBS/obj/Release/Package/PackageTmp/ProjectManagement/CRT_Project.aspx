<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="CRT_Project.aspx.cs" Inherits="InovexiaEBS.ProjectManagement.CRT_Project" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

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
                            <h3 class="panel-title">Institution Engaged HR</h3>
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
                                                     <div class="col-sm-4">
                                                        <div class="form-group">                                                        

                                                            <asp:Literal ID="Literal3" runat="server" Text="<%$Resources:chienvh.language, mnuHome%>" /></a>
                                                            <asp:TextBox ID="txtMobileNo" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                    <div class="col-sm-4">
                                                        <div class="form-group">
                                                            <label class="control-label">Email</label>
                                                            <asp:TextBox ID="txtEmail" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                    <div class="col-sm-4">
                                                        <div class="form-group">
                                                            <label class="control-label">Gender </label>
                                                            <br />
                                                            <%--<span style="color: red;">*</span>--%>
                                                            <%-- <asp:RequiredFieldValidator ID="rfvGender" ControlToValidate="ddlGender" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>--%>
                                                            <asp:RadioButtonList ID="ddlGender1" runat="server" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                                                <asp:ListItem Text="<%$Resources:chienvh.language, rdbMale%>"  Value="Male" Selected="True"  />
                                                                <asp:ListItem Text="<%$Resources:chienvh.language, rdbFemale%>" Value="Female" style="margin-left:15px;" />
                                                                <asp:ListItem Text="Others" Value="Others" style="margin-left:15px;" />
                                                            </asp:RadioButtonList> 
                                                        </div>



                                                    </div>
                                                   
                                                </div>
                                          

                                                <div class="row">


                                                    <telerik:RadGrid ID="RadGrid1" runat="server" DataSourceID="SqlDataSource1">
                                                        <MasterTableView AutoGenerateColumns="False" DataKeyNames="AC1" DataSourceID="SqlDataSource1">
                                                            <Columns>
                                                                <telerik:GridBoundColumn DataField="AC1" DataType="System.Int32" FilterControlAltText="Filter AC1 column" HeaderText="<%$Resources:chienvh.language, rdbMale%>" ReadOnly="True" SortExpression="AC1" UniqueName="AC1">
                                                                    <ColumnValidationSettings>
                                                                        <ModelErrorMessage Text="" />
                                                                    </ColumnValidationSettings>
                                                                </telerik:GridBoundColumn>
                                                                <telerik:GridBoundColumn DataField="AC1Name" FilterControlAltText="Filter AC1Name column" HeaderText="<%$Resources:chienvh.language, rdbFemale%>" SortExpression="AC1Name" UniqueName="AC1Name">
                                                                    <ColumnValidationSettings>
                                                                        <ModelErrorMessage Text="" />
                                                                    </ColumnValidationSettings>
                                                                </telerik:GridBoundColumn>
                                                                <telerik:GridBoundColumn DataField="AC1ManualCode" FilterControlAltText="Filter AC1ManualCode column" HeaderText="AC1ManualCode" SortExpression="AC1ManualCode" UniqueName="AC1ManualCode">
                                                                    <ColumnValidationSettings>
                                                                        <ModelErrorMessage Text="" />
                                                                    </ColumnValidationSettings>
                                                                </telerik:GridBoundColumn>
                                                                <telerik:GridCheckBoxColumn DataField="Transfered" DataType="System.Boolean" FilterControlAltText="Filter Transfered column" HeaderText="Transfered" SortExpression="Transfered" UniqueName="Transfered">
                                                                </telerik:GridCheckBoxColumn>
                                                                <telerik:GridBoundColumn DataField="AddedBy" FilterControlAltText="Filter AddedBy column" HeaderText="AddedBy" SortExpression="AddedBy" UniqueName="AddedBy">
                                                                    <ColumnValidationSettings>
                                                                        <ModelErrorMessage Text="" />
                                                                    </ColumnValidationSettings>
                                                                </telerik:GridBoundColumn>
                                                                <telerik:GridBoundColumn DataField="DateAdded" DataType="System.DateTime" FilterControlAltText="Filter DateAdded column" HeaderText="DateAdded" SortExpression="DateAdded" UniqueName="DateAdded">
                                                                    <ColumnValidationSettings>
                                                                        <ModelErrorMessage Text="" />
                                                                    </ColumnValidationSettings>
                                                                </telerik:GridBoundColumn>
                                                                <telerik:GridBoundColumn DataField="UpdatedBy" FilterControlAltText="Filter UpdatedBy column" HeaderText="UpdatedBy" SortExpression="UpdatedBy" UniqueName="UpdatedBy">
                                                                    <ColumnValidationSettings>
                                                                        <ModelErrorMessage Text="" />
                                                                    </ColumnValidationSettings>
                                                                </telerik:GridBoundColumn>
                                                                <telerik:GridBoundColumn DataField="DateUpdated" DataType="System.DateTime" FilterControlAltText="Filter DateUpdated column" HeaderText="DateUpdated" SortExpression="DateUpdated" UniqueName="DateUpdated">
                                                                    <ColumnValidationSettings>
                                                                        <ModelErrorMessage Text="" />
                                                                    </ColumnValidationSettings>
                                                                </telerik:GridBoundColumn>
                                                            </Columns>
                                                        </MasterTableView>
                                                    </telerik:RadGrid>
                                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InovexiaReport.Properties.Settings.TERP_DB %>" SelectCommand="SELECT * FROM [AC1]"></asp:SqlDataSource>


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
