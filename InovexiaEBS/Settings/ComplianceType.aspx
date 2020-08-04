<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="ComplianceType.aspx.cs" Inherits="InovexiaEBS.Settings.ComplianceType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <div class="panel-heading">
                    <div class="panel-control">
                    </div>
                    <h3 class="panel-title">Compliance Type</h3>
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




                        <MasterTableView EditMode="Batch" DataSourceID="SqlDataSource2" DataKeyNames="ComplianceTypeID" AllowMultiColumnSorting="True"
                            Width="100%" CommandItemDisplay="Top" Name="ComplianceTypeID" AutoGenerateColumns="False"
                            CommandItemSettings-AddNewRecordText="NEW" CommandItemSettings-CancelChangesText="CANCEL"
                            CommandItemSettings-SaveChangesText="SAVE">



                            <Columns>

                                <telerik:GridEditCommandColumn ButtonType="ImageButton" UniqueName="EditCommandColumn">
                                    <HeaderStyle Width="20px" />
                                    <ItemStyle CssClass="MyImageButton" />
                                </telerik:GridEditCommandColumn>


                                <telerik:GridBoundColumn SortExpression="ComplianceTypeID" HeaderText="ComplianceTypeID " HeaderButtonType="TextButton"
                                    DataField="ComplianceTypeID" UniqueName="ComplianceTypeID" ReadOnly="True" Visible="False">
                                </telerik:GridBoundColumn>

                                <telerik:GridBoundColumn SortExpression="ComplianceTypeName" HeaderText="Name"
                                    DataField="ComplianceTypeName" UniqueName="ComplianceTypeName">

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
                        SelectCommand="SELECT [ComplianceTypeID],[ComplianceTypeName],[Remarks] FROM [dbo].[CmnComplianceType] where IsActive=1 order by ComplianceTypeID desc"
                        
                        InsertCommand="INSERT INTO [CmnComplianceType] (ComplianceTypeName, Remarks,IsActive) 
                             VALUES (@ComplianceTypeName, @Remarks,1)"

                        UpdateCommand="UPDATE [CmnComplianceType] SET [ComplianceTypeName]=@ComplianceTypeName, [Remarks]=@Remarks WHERE [ComplianceTypeID] = @ComplianceTypeID">

                        <InsertParameters>
                            <asp:Parameter Name="ComplianceTypeID" Type="Int32" />
                            <asp:Parameter Name="ComplianceTypeName" Type="String" />
                            <asp:Parameter Name="Remarks" Type="String" />                          
                             <asp:Parameter Name="IsActive" Type="Boolean" />

                        </InsertParameters>

                        <UpdateParameters>

                            <asp:Parameter Name="ComplianceTypeName" Type="String" />
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
