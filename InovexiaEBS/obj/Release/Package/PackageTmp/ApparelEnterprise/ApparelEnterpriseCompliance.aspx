<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="ApparelEnterpriseCompliance.aspx.cs" Inherits="InovexiaEBS.ApparelEnterprise.ApparelEnterpriseCompliance" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   <style>
       .widthmax {
       width:100% !important;
       }
   </style>
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
                                    <asp:Button ID="btnSave" CssClass="btn btn-info margin-right-btn" runat="server" ValidationGroup="MasterValidation" CausesValidation="True" Text="Save"  />

                                    <asp:Button ID="btnList" CssClass="btn btn-info margin-right-btn" runat="server" Text="List"  />

                                </div>
                            </div>
                            <h3 class="panel-title">Apparel Enterprise Compliance</h3>
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
                                                            <label class="control-label">Enterprise Name </label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="rfvEnterprise" ControlToValidate="ddlEnterprise" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
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
                                                            <label class="control-label">Compliance Type</label>
                                                            <span style="color: red;">*</span>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ddlComplianceType" ValidationGroup="MasterValidation" runat="server" ForeColor="Red" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                                                            <telerik:RadComboBox ID="ddlComplianceType" runat="server"
                                                                DropDownCssClass="widthClass"
                                                                Width="100%"
                                                                EmptyMessage="Select Compliance Type" EnableLoadOnDemand="True" Filter="Contains"
                                                                Height="200px" HighlightTemplatedItems="True"
                                                                OnItemsRequested="ddlComplianceType_ItemsRequested"
                                                                OnSelectedIndexChanged="ddlComplianceType_SelectedIndexChanged"
                                                                Skin="Silk" Style="background-color: #339966;" AutoPostBack="true">
                                                                <HeaderTemplate>
                                                                    <table cellpadding="0" cellspacing="0" >
                                                                        <tr>
                                                                            <td  >Compliance Type</td>
                                                                              
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


                                                </div>
                                             
                                                <div class="row">
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Effective From</label>                                                            
                                                            <telerik:RadDatePicker runat="server" ID="dtpEffectiveFrom" class="form-control" CssClass="widthmax"> </telerik:RadDatePicker>
                                                        </div>
                                                    </div>
                                                    <div class="col-sm-6">
                                                        <div class="form-group">
                                                            <label class="control-label">Remarks</label>
                                                            <asp:TextBox ID="txtRemarks" runat="server" class="form-control"></asp:TextBox>

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
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
