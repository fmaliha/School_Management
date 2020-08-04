<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="MenuPermission.aspx.cs" Inherits="InovexiaEBS.Settings.MenuPermission" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">






    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>


            <div class="row" id="MasterPanel" runat="server">
                <div class="col-lg-12">
                    <div class="panel">
                        <div class="panel-heading">
                            <%--<div class="panel-control">


                            </div>--%>
                            <div class="row">

                                <div class="col-md-2">
                                    <div class="pull-left">
                                        <h3 class="panel-title">Menu Permission</h3>
                                        </div>
                                    </div>

                                <div class="col-md-10">
                                    <div class="pull-right">
                                        <asp:Button ID="btnSave" CssClass="btn btn-info margin-right-btn" runat="server" Text="Save" />


                                    </div>
                                </div>
                            </div>

                            
                        </div>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-sm-6">
                                    <div class="form-group">
                                        <label class="control-label">User Name</label>
                                        <span style="color: red;">*</span>
                                        <telerik:RadComboBox ID="radCmboUserName" runat="server" AutoPostBack="True"
                                            DropDownWidth="300px" EmptyMessage="Choose User" EnableLoadOnDemand="True"
                                            Filter="Contains" Height="200px" HighlightTemplatedItems="True"
                                            OnItemsRequested="radCmboUserName_ItemsRequested"
                                            Skin="Silk" Style="background-color: #339966" Width="300px" OnSelectedIndexChanged="radCmboUserName_SelectedIndexChanged">
                                            <HeaderTemplate>
                                                <table cellpadding="0" cellspacing="0" style="width: 300px">
                                                    <tr>
                                                        <td style="width: 50%;">UserName</td>
                                                        <td style="width: 30%;">Email</td>
                                                        <td style="width: 20%;">PIN</td>
                                                    </tr>
                                                </table>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <table cellpadding="0" cellspacing="0" style="width: 300px">
                                                    <tr>
                                                        <td style="width: 50%;"><%# DataBinder.Eval(Container, "Text")%></td>
                                                        <td style="width: 30%;"><%# DataBinder.Eval(Container, "Attributes['email']")%></td>
                                                        <td style="width: 20%;"><%# DataBinder.Eval(Container, "Attributes['pin_number']")%></td>
                                                    </tr>
                                                </table>
                                            </ItemTemplate>
                                        </telerik:RadComboBox>

                                    </div>
                                </div>


                            </div>


                            <div class="row">


                                <telerik:RadGrid RenderMode="Lightweight" ID="grdList" runat="server" Skin="Silk"  >
                                    <MasterTableView AutoGenerateColumns="False" DataKeyNames="menu_id" >
                                        <Columns>

                                            <telerik:GridBoundColumn DataField="menu_id" DataType="System.Int32"
                                                FilterControlAltText="Filter menu_id column" HeaderText="menu_id"
                                                ReadOnly="True" SortExpression="menu_id" UniqueName="menu_id" Visible="false">
                                            </telerik:GridBoundColumn>


                                            <telerik:GridBoundColumn DataField="ModuleName"
                                                FilterControlAltText="ModuleName" HeaderText="ModuleName"
                                                ReadOnly="True" SortExpression="ModuleName" UniqueName="ModuleName">
                                            </telerik:GridBoundColumn>


                                            <telerik:GridBoundColumn DataField="menu_text"
                                                FilterControlAltText="menu_text" HeaderText="Menu"
                                                ReadOnly="True" SortExpression="ModuleName" UniqueName="menu_text">
                                            </telerik:GridBoundColumn>




                                            <telerik:GridTemplateColumn UniqueName="CheckBoxTemplateColumn">
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" />

                                                </ItemTemplate>
                                                <HeaderTemplate>
                                                    <asp:CheckBox ID="headerChkbox" runat="server" OnCheckedChanged="ToggleSelectedState" Text="Create"
                                                        AutoPostBack="True" />
                                                </HeaderTemplate>
                                            </telerik:GridTemplateColumn>

                                            <telerik:GridTemplateColumn UniqueName="CheckBoxTemplateColumn2">
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" />

                                                </ItemTemplate>
                                                <HeaderTemplate>
                                                    <asp:CheckBox ID="headerChkbox2" runat="server" OnCheckedChanged="ToggleSelectedState_view" Text="View"
                                                        AutoPostBack="True" />
                                                </HeaderTemplate>
                                            </telerik:GridTemplateColumn>

                                            <telerik:GridTemplateColumn UniqueName="CheckBoxTemplateColumn3">
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="True" />

                                                </ItemTemplate>
                                                <HeaderTemplate>
                                                    <asp:CheckBox ID="headerChkbox3" runat="server" OnCheckedChanged="ToggleSelectedState_edit" Text="Edit"
                                                        AutoPostBack="True" />
                                                </HeaderTemplate>
                                            </telerik:GridTemplateColumn>


                                        </Columns>
                                    </MasterTableView>
                                </telerik:RadGrid>
                                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>"
                SelectCommand="SELECT [CustomerID], [CompanyName], [ContactName], [Country] FROM [Customers]">
        </asp:SqlDataSource>--%>
                            </div>


                        </div>



                    </div>
                </div>
            </div>


        </ContentTemplate>
    </asp:UpdatePanel>




</asp:Content>
