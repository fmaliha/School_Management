<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="GuardianListUI.aspx.cs" Inherits="InovexiaEBS.StudentRegistrationView.GuardianListUI" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <style>
        .widthClass {
            width: 100%;
        }

                        table {
                  font-family: arial, sans-serif;
                  border-collapse: collapse;
                  width: 100%;
                }

                td, th {
                  border: 1px solid #dddddd;
                  text-align: center;
                  padding: 8px;
                }

                tr:nth-child(even) {
                  background-color: white;
                }

                 th {
                     background-color: #ff3333;
                      color: white;
                    }

                 float-right {
                     text-align: right;
                 }
    </style>

    
    <div  id="GuardianDetailsGrid" runat="server">
                                     
                   
          <div id="MasterPanelGridSearch" runat="server" style="font-family: serif">
               
        <div class="col-lg-12">
            
            <div class="breadcrumb fontcolordiv" style="background-color: #b3b3b3"  >
                                                    <li class="breadcrumb-item" ><a href="#">Home</a></li>
                                                    <li class="breadcrumb-item"><a href="#">Guardian</a></li>
                                                    <li class="breadcrumb-item"><a href="#">Guardian List</a></li>
                                                 
                                                    <%--<li class="breadcrumb-item active">Student Details</li>--%>
                   </div>

            <div class="card">
                
              
                <div class="card-body">
                    
                    <h3 style="font-family: fantasy">Guardian List</h3>
                    
                    <br/>
                    
                           <asp:GridView ID="GrdGuardianList" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-bordered dataTable" Width="100%"
                               AllowPaging="true"
                                        PageSize="30" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                
                            <asp:BoundField DataField="AdmissionNo" HeaderText="Admission No" ItemStyle-Width="60" >
                            <ItemStyle Width="60px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="Nameguardian" HeaderText="Guardian Name" ItemStyle-Width="200" >
                            <ItemStyle Width="200px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="RelationwithStudent" HeaderText="Relation" ItemStyle-Width="50" >
                            <ItemStyle Width="50px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="Presentaddressguardian" HeaderText="Present Address" ItemStyle-Width="50" >
                            <ItemStyle Width="50px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="Mobileguardian" HeaderText="Mobile No" ItemStyle-Width="50" > 
                            <ItemStyle Width="50px"></ItemStyle>
                            </asp:BoundField>
                            
                     <%--<asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                               <asp:LinkButton CssClass="btn btn-primary" CommandArgument= '<%# Eval("AdmissionNo") %>' ItemStyle-Width="55" OnClick="BtnSelectG" runat="server" Text="View"> View </asp:LinkButton>
                               <asp:LinkButton CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>' ItemStyle-Width="55" OnClick="BtnDeleteG" runat="server" Text="Delete"> Delete </asp:LinkButton>

                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                                                
                </div> 
            </div>
        </div>
          </div>
               </div>

</asp:Content>
