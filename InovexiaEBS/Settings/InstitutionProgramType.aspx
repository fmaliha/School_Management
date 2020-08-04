<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="InstitutionProgramType.aspx.cs" Inherits="InovexiaEBS.Settings.InstitutionProgramType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <div class="panel-heading">
                    <div class="panel-control">
                    </div>
                    <h3 class="panel-title">Institution Program Type</h3>
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




                        <MasterTableView EditMode="Batch" DataSourceID="SqlDataSource2" DataKeyNames="ProgramTypeID" AllowMultiColumnSorting="True"
                            Width="100%" CommandItemDisplay="Top" Name="ProgramTypeID" AutoGenerateColumns="False"
                            CommandItemSettings-AddNewRecordText="NEW" CommandItemSettings-CancelChangesText="CANCEL"
                            CommandItemSettings-SaveChangesText="SAVE">



                            <Columns>

                                <telerik:GridEditCommandColumn ButtonType="ImageButton" UniqueName="EditCommandColumn">
                                    <HeaderStyle Width="20px" />
                                    <ItemStyle CssClass="MyImageButton" />
                                </telerik:GridEditCommandColumn>


                                <telerik:GridBoundColumn SortExpression="ProgramTypeID" HeaderText="ProgramTypeID " HeaderButtonType="TextButton"
                                    DataField="ProgramTypeID" UniqueName="ProgramTypeID" ReadOnly="True" Visible="False">
                                </telerik:GridBoundColumn>

                                <telerik:GridBoundColumn SortExpression="ProgramTypeName" HeaderText="Program Type"
                                    DataField="ProgramTypeName" UniqueName="ProgramTypeName">

                                    <ColumnValidationSettings EnableRequiredFieldValidation="true" EnableModelErrorMessageValidation="true">
                                        <RequiredFieldValidator ForeColor="Red" ErrorMessage="This field is required"></RequiredFieldValidator>
                                        <ModelErrorMessage BackColor="Red" />
                                    </ColumnValidationSettings>
                                </telerik:GridBoundColumn>

                                <telerik:GridBoundColumn SortExpression="Remarks" HeaderText="Remark"
                                    DataField="Remarks" UniqueName="Remarks">                                   
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
                        SelectCommand="SELECT [ProgramTypeID],[ProgramTypeName],[Remarks] FROM [dbo].[Institute_Program_Type] order by ProgramTypeID desc"

                        InsertCommand="INSERT INTO [Institute_Program_Type] (ProgramTypeName, Remarks) 
                             VALUES (@ProgramTypeName, @Remarks)"

                        UpdateCommand="UPDATE [Institute_Program_Type] SET [ProgramTypeName]=@ProgramTypeName, [Remarks]=@Remarks WHERE [ProgramTypeID] = @ProgramTypeID">

                        <InsertParameters>
                            <asp:Parameter Name="ProgramTypeID" Type="Int32" />
                            <asp:Parameter Name="ProgramTypeName" Type="String" />
                            <asp:Parameter Name="Remarks" Type="String" />

                        </InsertParameters>

                        <UpdateParameters>

                            <asp:Parameter Name="ProgramTypeName" Type="String" />
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
