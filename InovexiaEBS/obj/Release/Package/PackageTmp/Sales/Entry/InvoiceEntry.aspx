<%@ Page Title="Dealer Invoice Entry" Language="C#" MasterPageFile="~/InvexiaMaster.Master"  AutoEventWireup="true" CodeBehind="InvoiceEntry.aspx.cs" Inherits="ABS.UI.Sales.Entry.InvoiceEntry" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

  


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            background-color: #CCCCCC;
        }
    </style>
    
</asp:Content>
  



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="row">
                          
                                <div class="col-lg-12">
                                    <div class="panel">
                                        <div class="panel-heading">
                                            <div class="panel-control">
                                               
                                            </div>
                                            <h3 class="panel-title">Sales Invoice</h3>
                                        </div>
                                        <!--Horizontal Form-->
                                        <!--===================================================-->
                                        
                                            <div class="panel-body">                                                                                 
                                                                              



            <table   style="width: 100%;">
                <tr>
                    <td style="width: 1%;">
                        &nbsp;</td>
                    <td>
                        Invoice ID</td>
                    <td>
                        <telerik:RadTextBox ID="txtInvoiceID" Runat="server" AutoPostBack="False" ReadOnly="True" style="color: #FF0000; font-weight: 700" Width="200px" Skin="Silk">
                        </telerik:RadTextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;Date</td>
                    <td>
                        <telerik:RadDatePicker ID="txtInvoiceDate" runat="server" AutoPostBack="True" Culture="en-US" MaxDate="3000-01-01" MinDate="1000-01-01" ShowPopupOnFocus="True" style="background-color: #FFFFFF; font-weight: 700; color: #FF0000;" Width="150px" Skin="Silk">
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
                    <td>
                        &nbsp;</td>
                    <td>
                        Client </td>
                    <td>
                        <telerik:RadComboBox ID="RadComboBox1" runat="server" AutoPostBack="True"
                             DropDownWidth="376px" EmptyMessage="Choose Client" EnableLoadOnDemand="True"
                             Filter="Contains" Height="200px" HighlightTemplatedItems="True"
                             OnItemsRequested="RadComboBox1_ItemsRequested"
                             Skin="Silk" style="background-color: #339966" Width="203px">
                            <HeaderTemplate>
                                <table cellpadding="0" cellspacing="0" style="width: 375px">
                                    <tr>
                                        <td style="width: 200px;">ClientName</td>
                                        <td style="width: 120px;">ClientID</td>
                                    </tr>
                                </table>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <table cellpadding="0" cellspacing="0" style="width: 275px">
                                    <tr>
                                        <td style="width: 250px;"><%# DataBinder.Eval(Container, "Text")%></td>
                                        <td style="width: 70px;"><%# DataBinder.Eval(Container, "Attributes['DealerID']")%></td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </telerik:RadComboBox>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        Remarks</td>
                    <td>
                        <telerik:RadTextBox ID="txtRemarks" Runat="server" 
                            style="background-color: #FFFFFF" Width="200px" Skin="Silk">
                        </telerik:RadTextBox>
                    </td>
                </tr>
                </table>          

              
                                                

          

            <table  style="width: 100%;"  >



            <tr>
                <td  style="width: 1%;">
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>



            <tr  >
                <td >
                    &nbsp;</td>
                <td class="auto-style1"  >
                    Style</td>
                <td class="auto-style1"  >
                    Rate</td>
                <td class="auto-style1"  >
                    Quantity</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>



            <tr>
                <td >
                    </td>
                <td >
                    <telerik:RadComboBox ID="cmbProduct" runat="server" DropDownWidth="350px" EmptyMessage="Choose Style" 
                    EnableLoadOnDemand="True" Filter="Contains" Height="200px" HighlightTemplatedItems="True" 
                    OnItemsRequested="cmbProduct_ItemsRequested" Skin="Silk" style="background-color: #999999; font-weight: bold;" Width="350px" 
                        AutoPostBack="True" OnSelectedIndexChanged="cmbProduct_SelectedIndexChanged" 
                    >
                    <HeaderTemplate>
                        <table cellpadding="0" cellspacing="0" style="width: 350px">
                            <tr>
                                <td style="width: 50px;">ID </td>                               
                                <td style="width: 160px;">Name</td>
                                 <td style="width: 80px;">Style </td>                               
                                <td style="width: 60px;">Stock </td>
                               
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <table cellpadding="0" cellspacing="0" style="width: 350px">
                            <tr>
                                <td style="width: 50px;"><%# DataBinder.Eval(Container, "Attributes['ProductID']")%></td>                             
                               
                                <td style="width: 150px;"><%# DataBinder.Eval(Container, "Text")%></td>
                                <td style="width: 80px;"><%# DataBinder.Eval(Container, "Attributes['CategoryName']")%></td>
                                
                                <td style="width: 60px;"><%# DataBinder.Eval(Container, "Attributes['StockQTY']")%></td>

                                
                                
                            </tr>
                        </table>
                    </ItemTemplate>
                    </telerik:RadComboBox>
                </td>
                <td >
                    <telerik:RadTextBox ID="txtRate" Runat="server"               
                        Width="150px" Skin="Silk">
                    </telerik:RadTextBox>
                </td>
                <td >
                    <telerik:RadTextBox ID="txtQty" Runat="server"   Width="150px" Skin="Silk">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:Button ID="btnAddtolist" runat="server" onclick="btnAddtolist_Click" Text="ADD" Width="120px" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>

        </table>

            
        <table style="width: 100%;" >
        <tr>
        
        <td style="width: 1%;"></td>
         <td>       

            <telerik:RadGrid ID="grdList" runat="server"  Height="170px"    Width="100%" 
                CellSpacing="0" GridLines="None" Skin="Silk">
              
                   
                <ClientSettings>
                    <Scrolling AllowScroll="True"   />
                </ClientSettings>
                <MasterTableView DataKeyNames="ProductID">


                    <Columns>

                            <telerik:GridTemplateColumn HeaderStyle-Width="10px">
                                <ItemTemplate>
                                    <telerik:RadButton ID="btnItemDelete" runat="server" Text="" OnClick="btnItemDelete_Click">
                                        <Icon PrimaryIconCssClass="rbCancel" />
                                    </telerik:RadButton>
                                </ItemTemplate>

                            </telerik:GridTemplateColumn>
                        </Columns>

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
        
        </td>
        
        </tr>
        
        </table>

<table style="width: 100%;" >

        <tr>
            <td align="right" rowspan="4" style="width: 11%">&nbsp;</td>
            <td align="right" rowspan="4" style="width: 11%">CASH</td>
            <td align="right" rowspan="4" style="width: 154px">
                <telerik:RadTextBox ID="txtCashPay" Runat="server" style="color: #FF0000; font-weight: 700; 
background-color: #FFFFFF; font-size: medium;" Text="0" Width="238px" Skin="Silk">
                </telerik:RadTextBox>
            </td>
         <td align="right" >
             Grand Total&nbsp;&nbsp; <telerik:RadTextBox ID="txtGrandTotal" Runat="server" ReadOnly="True" style="font-weight: 700; color: #FF0000" Text="0" Width="300px" Skin="Silk">
             </telerik:RadTextBox>
            </td>
        
        </tr>

            <tr>
                <td align="right" >
                    Discount<telerik:RadTextBox ID="txtDiscount" Runat="server" 
                  
                 Width="300px" style="font-weight: 700; color: #FF0000" Text="0" Skin="Silk" AutoPostBack="True" OnTextChanged="txtDiscount_TextChanged">
             </telerik:RadTextBox>


                </td>
            </tr>

            <tr>
                <td align="right" >
                    VAT(%)<telerik:RadTextBox ID="txtVATPercent" Runat="server" 
                  
                 Width="300px" style="font-weight: 700; color: #FF0000" Text="0" Skin="Silk" AutoPostBack="True" OnTextChanged="txtVATPercent_TextChanged" >
             </telerik:RadTextBox>


                </td>
            </tr>

        <tr>
         <td align="right" >

             VAT Amount<telerik:RadTextBox ID="txtTotalVAT" Runat="server" ReadOnly="True" style="font-weight: 700; color: #FF0000" Width="300px" Text="0" Skin="Silk">
                    </telerik:RadTextBox>


        </td>
        
        </tr>

        <tr>
            <td align="right" rowspan="2" style="width: 11%">&nbsp;</td>
            <td align="right" rowspan="2" style="width: 11%">CHEQUE</td>
            <td align="right" rowspan="2" style="width: 154px">
                <telerik:RadTextBox ID="txtCardPay" Runat="server" 
                    style="color: #FF0000; font-weight: 700; background-color: #FFFFFF; font-size: medium;" Text="0" Width="238px" Skin="Silk">
                </telerik:RadTextBox>
            </td>
         <td align="right" >
                                        <table width="100%" >

                
            <tr>
                <td align="right" >
                    Net Amount <telerik:RadTextBox ID="txtNetAmount" Runat="server"  ReadOnly="True" style="color: #FF0000; font-weight: 700; background-color: #FFFFFF; font-style: italic; font-size: medium;" Text="0" Width="300px" Skin="Silk">
                    </telerik:RadTextBox>
                </td>
            </tr>
       
        
        </table>
        </td>
        
        </tr>
            <tr>
                <td align="right" >
                    &nbsp;&nbsp;</td>
            </tr>
       
        
            </table>

        
        <table style="width: 100%;" >
        
         <tr style="width: 100%;">
        <td align="right">
        <asp:Button ID="btnSave" runat="server"  class="btn btn-info" onclick="btnSave_Click" Text="SAVE" />  &nbsp;  &nbsp;
          </td>
        </tr>
        
        </table>

             </div>  </div>  </div>      </div>    
     
     
</asp:Content>
