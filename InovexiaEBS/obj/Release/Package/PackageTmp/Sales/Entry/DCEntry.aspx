<%@ Page Title="DC ENTRY" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="DCEntry.aspx.cs" 
    Inherits="PBS.UI.Sales.Entry.DCEntry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    
     
    
</asp:Content>
  



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="row">
                          
                                <div class="col-lg-12">
                                    <div class="panel">
                                        <div class="panel-heading">
                                            <div class="panel-control">
                                               
                                            </div>
                                            <h3 class="panel-title">DC Entry</h3>
                                        </div>
                                        <!--Horizontal Form-->
                                        <!--===================================================-->
                                        
                                            <div class="panel-body">                                                                                 
                                        

            <table >
                <tr>
                    <td >
                        Invoice Number&nbsp;&nbsp; </td>
                    <td>
                        <telerik:RadComboBox ID="cmbProduct" runat="server" DropDownWidth="450px" 
                            EmptyMessage="Choose invoice" EnableLoadOnDemand="True" Filter="Contains"
                             Height="200px" HighlightTemplatedItems="True" 
                            OnItemsRequested="cmbProduct_ItemsRequested" Width="222px" 
                          
                            Skin="Silk"  AutoPostBack="True" OnSelectedIndexChanged="cmbProduct_SelectedIndexChanged">
                            <HeaderTemplate>
                                <table cellpadding="0" cellspacing="0" style="width: 350px">
                                    <tr>
                                        <td style="width: 120px;">Invoice ID </td>
                                        <td style="width: 80px;">Dealer ID</td>
                                        <td style="width: 150px;">Dealer Name</td>
                                    </tr>
                                </table>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <table cellpadding="0" cellspacing="0" style="width: 350px">
                                    <tr>
                                        <td style="width: 120px;"><%# DataBinder.Eval(Container, "Text")%></td>
                                        <td style="width: 80px;"><%# DataBinder.Eval(Container, "Attributes['ClientID']")%></td>
                                        <td style="width: 150px;"><%# DataBinder.Eval(Container, "Attributes['DealerName']")%></td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </telerik:RadComboBox>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        Store</td>
                    <td>
                        <telerik:RadComboBox ID="cmbStore" runat="server" AutoPostBack="True" DropDownWidth="450px" 
                            EmptyMessage="Choose Store" EnableLoadOnDemand="True" Filter="Contains" Height="200px" 
                            HighlightTemplatedItems="True"  Skin="Silk" 
                            style="background-color: #999999; font-weight: bold;" Width="200px" OnItemsRequested="cmbStore_ItemsRequested" OnSelectedIndexChanged="cmbStore_SelectedIndexChanged">
                            <HeaderTemplate>
                                <table cellpadding="0" cellspacing="0" style="width: 350px">
                                    <tr>
                                        <td style="width: 100px;">Code </td>
                                        <td style="width: 200px;">Store Name</td>
                                        <td style="width: 50px;">ID</td>
                                    </tr>
                                </table>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <table cellpadding="0" cellspacing="0" style="width: 350px">
                                    <tr>
                                        <td style="width: 100px;"><%# DataBinder.Eval(Container, "Text")%></td>
                                        <td style="width: 200px;"><%# DataBinder.Eval(Container, "Attributes['StoreName']")%></td>
                                        <td style="width: 50px;"><%# DataBinder.Eval(Container, "Attributes['StoreID']")%></td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </telerik:RadComboBox>
                    </td>
                    <td rowspan="2">Driver Info</td>
                    <td rowspan="2">
                        <telerik:RadTextBox ID="txtDriverName" Runat="server" TextMode="MultiLine" Width="220px" Height="50px" Skin="Silk">
                        </telerik:RadTextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        DC NO</td>
                    <td class="auto-style1">
                        <telerik:RadTextBox ID="txtDCNo" Runat="server" AutoPostBack="False" LabelWidth="80px" ReadOnly="True" style="color: #CC0000; font-weight: 700; background-color: #FFFFFF;" Width="220px" Skin="Silk">
                        </telerik:RadTextBox>
                    </td>
                    <td class="auto-style1">
                        </td>
                    <td class="auto-style1">
                        DC Date</td>
                    <td class="auto-style1">
                        <telerik:RadDatePicker ID="txtDCDate" runat="server" AutoPostBack="True" Culture="en-US" Enabled="False" MaxDate="3000-01-01" MinDate="1000-01-01" ShowPopupOnFocus="True" style="background-color: #FFFFFF; font-weight: 700; color: #FF0000;" Width="150px" Skin="Silk">
                            <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" Skin="Silk">
                            </Calendar>
                            <DateInput AutoPostBack="True" DateFormat="M/d/yyyy" DisplayDateFormat="M/d/yyyy" LabelWidth="40%" value="4/4/2016">
<EmptyMessageStyle Resize="None"></EmptyMessageStyle>

<ReadOnlyStyle Resize="None"></ReadOnlyStyle>

<FocusedStyle Resize="None"></FocusedStyle>

<DisabledStyle Resize="None"></DisabledStyle>

<InvalidStyle Resize="None"></InvalidStyle>

<HoveredStyle Resize="None"></HoveredStyle>

<EnabledStyle Resize="None"></EnabledStyle>
                            </DateInput>
                            <DatePopupButton HoverImageUrl="" ImageUrl="" />
                        </telerik:RadDatePicker>
                    </td>
                    <td class="auto-style1">
                        </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Delivery Add.</td>
                    <td>
                        <telerik:RadTextBox ID="txtDeliveryAdd" Runat="server" Width="220px" Skin="Silk">
                        </telerik:RadTextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>Vehicle</td>
                    <td>
                        <telerik:RadTextBox ID="txtVehicleNo" Runat="server" Width="220px" Skin="Silk">
                        </telerik:RadTextBox>
                    </td>
                    <td>Remarks</td>
                    <td>
                        <telerik:RadTextBox ID="txtRemarks" Runat="server" Width="220px" Skin="Silk">
                        </telerik:RadTextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
<div></div>


             <table width="100%">
            


             <tr>
             <td width="30%">
             
              
<fieldset>
              <legend>
                  Invoice Product
</legend>
               


        <table>



            <tr>
                <td>
                    Product ID</td>
                <td>
                    <telerik:RadTextBox ID="txtPID" Runat="server" ReadOnly="True" 
                         Text="0" 
                        Width="220px" style="font-weight: 700; color: #FF0000" Skin="Silk">
                    </telerik:RadTextBox>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td >
                    Prd. Name</td>
                <td style="height: 26px">
                    <telerik:RadTextBox ID="txtPName" Runat="server"  Width="220px" style="color: #FF0000" Skin="Silk">
                    </telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td>DC Pending Qty</td>
                <td>
                    <telerik:RadTextBox ID="txtOrderQTY" Runat="server" ontextchanged="txtOrderQTY_TextChanged" ReadOnly="True" 
                         Text="0" Width="220px" style="color: #FF0000" Skin="Silk">
                    </telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td>Stock Qty</td>
                <td>
                    <telerik:RadTextBox ID="txtStockQty" Runat="server" ontextchanged="txtOrderQTY_TextChanged" ReadOnly="True" Text="0" Width="220px" style="color: #FF0000" Skin="Silk">
                    </telerik:RadTextBox>
                </td>
            </tr>

            <tr>
                <td>DC Qty</td>
                <td>
                    <telerik:RadTextBox ID="txtDCQty" Runat="server"  Width="220px" Skin="Silk">
                    </telerik:RadTextBox>
                </td>
            </tr>

            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnAddtolist" runat="server" onclick="btnAddtolist_Click" Text="ADD" Width="100px" />
                    &nbsp; &nbsp; 
                    <asp:Button ID="btnRefresh" runat="server" onclick="btnRefresh_Click" Text="CLEAR" Width="100px" />
                </td>
            </tr>

        </table>
        

    </fieldset>
             
             </td>
             

             <td width="62%">
           
            
                 <fieldset>
              <legend>
                  DC Deatils
</legend>


 <telerik:RadGrid ID="grdList" runat="server"  Height="179px"    Width="100%" 
                CellSpacing="0" GridLines="None" Skin="Silk">
              
                   
                <ClientSettings>
                    <Scrolling AllowScroll="True"   />
                </ClientSettings>
                <MasterTableView>
                    <CommandItemSettings ExportToPdfText="Export to PDF" />
                    <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" 
                        Visible="True">
                        <HeaderStyle Width="20px" />
                    </RowIndicatorColumn>
                    <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                        Visible="True">
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
            
        
                     </fieldset>
                


             
             
             </td>
             </tr>
             </table>

             <table width="100%">
             
             <tr>
             <td>


             
                 <telerik:RadGrid ID="RadGrid1" runat="server" GridLines="None" Height="180px" 
                     onitemcommand="RadGrid1_ItemCommand" Skin="Silk" Width="100%">
                     <ClientSettings EnablePostBackOnRowClick="true">
                         <Selecting AllowRowSelect="True" UseClientSelectColumnOnly="True" />
                         <Scrolling AllowScroll="True" />
                     </ClientSettings>
                     <MasterTableView>
                         <RowIndicatorColumn>
                             <HeaderStyle Width="20px" />
                         </RowIndicatorColumn>
                         <ExpandCollapseColumn>
                             <HeaderStyle Width="20px" />
                         </ExpandCollapseColumn>
                     </MasterTableView>
                 </telerik:RadGrid>


             
             </td>
             </tr>
             </table>

               

             
       </div>  
                                        
            <div class="panel-footer text-right">
        <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" class="btn btn-info"  Text="SAVE"  />  

                <asp:Button ID="btnPrint" runat="server"  Text="Print" onclick="btnPrint_Click" Visible="False" />
                </div>

                                    </div>  </div>      </div>    

</asp:Content>
