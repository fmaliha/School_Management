<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="OrganizationType.aspx.cs" Inherits="InovexiaEBS.Settings.OrganizationType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <div class="panel-heading">
                    <div class="panel-control">
                    </div>
                    <h3 class="panel-title">Organization Type</h3>
                </div>
                <div class="panel-body">

                    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
                        <script type="text/javascript">
                            function RowDblClick(sender, eventArgs) {
                                sender.get_masterTableView().editItem(eventArgs.get_itemIndexHierarchical());
                            }
                        </script>

                    </telerik:RadCodeBlock>



                    <telerik:RadGrid ID="RadGrid1" AutoGenerateEditColumn="True" Skin="Silk" runat="server"
                        AllowAutomaticDeletes="True" AllowAutomaticInserts="True"
                        AllowAutomaticUpdates="True" DataSourceID="SqlDataSource2"
                        AllowSorting="True" OnItemDeleted="RadGrid1_ItemDeleted"
                        OnItemInserted="RadGrid1_ItemInserted"
                        OnItemUpdated="RadGrid1_ItemUpdated"
                        GridLines="None" CellSpacing="0">




                        <MasterTableView EditMode="Batch" DataSourceID="SqlDataSource2" DataKeyNames="OrganizationTypeID" AllowMultiColumnSorting="True"
                            Width="100%" CommandItemDisplay="Top" Name="OrganizationTypeID" AutoGenerateColumns="False"
                            CommandItemSettings-AddNewRecordText="NEW" CommandItemSettings-CancelChangesText="CANCEL"
                            CommandItemSettings-SaveChangesText="SAVE">



                            <Columns>

                                <telerik:GridEditCommandColumn ButtonType="ImageButton" UniqueName="EditCommandColumn">
                                    <HeaderStyle Width="20px" />
                                    <ItemStyle CssClass="MyImageButton" />
                                </telerik:GridEditCommandColumn>


                                <telerik:GridBoundColumn SortExpression="OrganizationTypeID" HeaderText="OrganizationTypeID " HeaderButtonType="TextButton"
                                    DataField="OrganizationTypeID" UniqueName="OrganizationTypeID" ReadOnly="True" Visible="False">
                                </telerik:GridBoundColumn>

                                <telerik:GridBoundColumn SortExpression="OrganizationTypeName" HeaderText="Name"
                                    DataField="OrganizationTypeName" UniqueName="OrganizationTypeName">

                                    <ColumnValidationSettings EnableRequiredFieldValidation="true" EnableModelErrorMessageValidation="true">
                                        <RequiredFieldValidator ForeColor="Red" ErrorMessage="This field is required"></RequiredFieldValidator>
                                        <ModelErrorMessage BackColor="Red" />
                                    </ColumnValidationSettings>
                                </telerik:GridBoundColumn>

                                <telerik:GridBoundColumn SortExpression="Remarks" HeaderText="Remarks"
                                    DataField="Remarks" UniqueName="Remarks">
                                    <ColumnValidationSettings>
                                        <ModelErrorMessage Text=""></ModelErrorMessage>
                                    </ColumnValidationSettings>
                                </telerik:GridBoundColumn>
                            </Columns>
                            <EditFormSettings>
                                <EditColumn UniqueName="EditCommandColumn1" FilterControlAltText="Filter EditCommandColumn1 column"></EditColumn>
                            </EditFormSettings>
                        </MasterTableView>
                        <ClientSettings>
                            <ClientEvents OnRowDblClick="RowDblClick" />
                            <Scrolling AllowScroll="True" UseStaticHeaders="True" />
                        </ClientSettings>
                    </telerik:RadGrid>



                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PBSConnectionString %>"
                        SelectCommand="SELECT [OrganizationTypeID],[OrganizationTypeName],[Remarks] FROM [dbo].[CmnOrganizationType] where IsActive=1 order by OrganizationTypeID desc"
                        
                        InsertCommand="INSERT INTO [CmnOrganizationType] (OrganizationTypeName, Remarks,IsActive) 
                             VALUES (@OrganizationTypeName, @Remarks,1)"

                        UpdateCommand="UPDATE [CmnOrganizationType] SET [OrganizationTypeName]=@OrganizationTypeName, [Remarks]=@Remarks WHERE [OrganizationTypeID] = @OrganizationTypeID">

                        <InsertParameters>
                            <asp:Parameter Name="OrganizationTypeID" Type="Int32" />
                            <asp:Parameter Name="OrganizationTypeName" Type="String" />
                            <asp:Parameter Name="Remarks" Type="String" />                          
                             <asp:Parameter Name="IsActive" Type="Boolean" />

                        </InsertParameters>

                        <UpdateParameters>

                            <asp:Parameter Name="OrganizationTypeName" Type="String" />
                            <asp:Parameter Name="Remarks" Type="String" />


                        </UpdateParameters>

                    </asp:SqlDataSource>


                    <%-- <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:PBSConnectionString %>"
                        ProviderName="System.Data.SqlClient" SelectCommand="SELECT DistrictID, DistrictName FROM  PBML_SDM_District order by DistrictName"></asp:SqlDataSource>--%>
                </div>

            </div>
        </div>
    </div>
</asp:Content>



