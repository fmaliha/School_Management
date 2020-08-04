 <%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="BatchListUI.aspx.cs" Inherits="InovexiaEBS.SchoolManagement.BatchListUI" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <style>
        
        
                        .divColorb {
                            background-color:  #e6e6ff;
                            /*color: grey;*/
                        }

                        .batchbutton {
                            color: #006699;
                            padding: 4px 10px 4px 10px; 
                        }

                               table {
                  font-family: arial, sans-serif;
                  border-collapse: collapse;
                  width: 100%;
                   background-color: #454d55;
                   
                                             
                }

                td, th {
                  border: 1px solid #dddddd;
                  text-align: center;
                  padding: 8px;
                }

                tr:nth-child(even) {
                  /*background-color: #bfbfbf;*/
                    color: whitesmoke;
                }

                 th {
                     /*background-color:#262626;*/
                      color: black;
                    }

                 float-right {
                     text-align: right;
                 }

                  .myclass{
    display:inline-block;
    width: 100%;
    height: 40px;
                      background-color: #454d55;
                      padding-bottom: 10px;
}

                  .button {
                      text-align: left;
                  }
                  .label {
                      color: black;
                      padding-right: 0px;
                      padding-left: 0px;
                  }
              
    </style>   
     <br/>
     <br/>
     <br/>
     <asp:Updatepanel runat="server">
       <ContentTemplate>
        <div class="row" id="MasterPanel" runat="server" >
             <div class="col-lg-12">
                 <div class="breadcrumb fontcolordiv" style="background-color: #b3b3b3"  >
                                                    <li class="breadcrumb-item" ><a href="#">Home</a></li>
                                                    <li class="breadcrumb-item"><a href="#">Batch</a></li>
                                                    <li class="breadcrumb-item"><a href="#">Add Batch</a></li>
                                                 
                                                    <%--<li class="breadcrumb-item active">Student Details</li>--%>
                   </div>
                 
                  
                 <div class="row " id="divpdetails" runat="server" >
                     
                       <div class="col-lg-12">
                                <div class="card">
           
                                  <div class="card-body divColorb">
                                    <h3 style="font-family: fantasy">Manage Batches</h3>
                                                      
                                       <%-- <h4 style="font-family: fantasy"> Personal Details</h4>--%>
                                            <div class="list-divider"></div>
                                          
                                                <%--<div style="float: right">
                                    
                                                 <asp:Button ID="btnAddbatch" CssClass="btn btn-success" runat="server" CausesValidation="True" 
                                                     ValidationGroup="batchvalidation" OnClick="btnaddbatch_OnClick" Text="Save"
                                                     />
                                                     data-toggle="modal" data-target="#myModal"
                                                   
                                    <br/>
                                                    <br/>
                                          </div> --%>  
                                            
                                      <asp:HiddenField ID="hfClassName" runat="server" />                                    
                                      <asp:HiddenField ID="hfClassID" runat="server" />                                         
                                        <table class="table table-bordered " style="width: 100% ">
                                                                
                                                                <tbody>
                                                                <tr>
                                                                   
                                                                    <td style="width: 60%; text-align:left; padding: 4px 10px 4px 10px">
                                                                        <asp:Button ID="btnPG" CssClass="myclass button" runat="server" BorderStyle="None" ForeColor="white" Height="50%"  
                                                                             Text="Play Group" OnClick="PGtable" CommandArgument="12">
                                                                        </asp:Button>
                                                                         &nbsp; 
                                                                         
                                                                        <asp:HiddenField ID="hfbpg" runat="server" />
                                                                        <asp:Label ID="lblbPG" CssClass="label" runat="server"/>
                                                                        <asp:Label runat="server" CssClass="label" Text ="- Batch,"/>

                                                                        <asp:HiddenField ID="hfspg" runat="server" />
                                                                        <asp:Label ID="lblsPG" CssClass="label"  runat="server"/>
                                                                        <asp:Label ID="Label2" runat="server" CssClass="label" Text="- Subject(s)"/>
                                                                        
                                                                        
                                                                        <%--<asp:LinkButton ID="lbPG" runat="server" ForeColor="white" OnClick="PGtable">Play Group</asp:LinkButton><br/>--%>
                                                                     
                                                                       
                                                                    </td>

                                                                   
                                                                    <%--<td style="text-align: center">
                                                                        <asp:Button ID="btnedit1" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Edit" />
                                                                        <%--<asp:LinkButton ID="lbedit1" runat="server" ForeColor="white">Edit</asp:LinkButton>
                                                                    </td>--%>

                                                                    <%--<td style="text-align: center">
                                                                         <asp:Button ID="btndlt1" runat="server" CssClass="myclass" BorderStyle="None" ForeColor="white" Text="Delete" />
                                                                  <%--      <asp:LinkButton ID="lbdlt1" runat="server" ForeColor="white"></asp:LinkButton>
                                                                    </td>--%>

                                                                    <%--<td style="text-align: center">
                                                                          <asp:Button ID="btns1" runat="server" CssClass="myclass" BorderStyle="None" ForeColor="white" Text="Add Subject" />
                                                                        <%--<asp:LinkButton ID="lbs1" runat="server" ForeColor="white">Add Subject </asp:LinkButton>
                                                                            
                                                                            </td>--%>
                                                                    <%--<td style="text-align: center">
                                                                         <asp:Button ID="btnb1" runat="server" CssClass="myclass" BorderStyle="None" ForeColor="white" Text="Add Batch" />
                                                                        
                                                                 <%--       <asp:LinkButton ID="lbb1" runat="server" ForeColor="white">Add Batch</asp:LinkButton>
                                                                    </td>--%>
                                                                </tr>
                                                               
                       
                                                                </tbody>
                                                            </table>
                                     
                  <div class="card-body" id="panelgrd1" runat="server" style="display: none"  >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdbatchpg" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%">
                               
                               <PagerStyle CssClass="pagination-ys"/>

                        <HeaderStyle CssClass="gridheader" />

                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                        <RowStyle HorizontalAlign="Center"></RowStyle>

                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                               <asp:TemplateField HeaderText="SL" ItemStyle-Width="10">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                              
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="Year" HeaderText="Year" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="Remarks" HeaderText="Remarks" ItemStyle-Width="70" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="BatchID" HeaderText="BatchID" ItemStyle-Width="70" Visible="False" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                           
                              <asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        
                                         <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("BatchID") %>' OnClick="Btn_DeleteBatch">Delete</asp:LinkButton>
                                         
                                    </ItemTemplate>
                                </asp:TemplateField>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>

                    </asp:GridView>
                  
                                                
                         </div> 
                                      
                                    
                                      
                  <div class="card-body" id="DivsPG" runat="server" style="display: none"  >
                    

                  
                           <asp:GridView ID="grdsPG" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%">
                               
                               <PagerStyle CssClass="pagination-ys"/>

                        <HeaderStyle CssClass="gridheader" />

                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                        <RowStyle HorizontalAlign="Center"></RowStyle>

                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                           <%--  <asp:BoundField DataField="BatchName" HeaderText="SL" ItemStyle-Width="20" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           --%>
                             <asp:TemplateField HeaderText="SL" ItemStyle-Width="20">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField DataField="SubjectName" HeaderText="Subjects" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                            
                            <%--  <asp:BoundField  HeaderText="Actions" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>--%>
                              <%--<asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-mint  pull-right" >Add Student</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right">Delete</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning pull-right">Edit</asp:LinkButton>
                                       
                                       

                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      
                  <table class="table table-bordered " style="width: 100%">
                                                                
                                                                <tbody>
                                                                <tr>
                                                                   
                                                                    <td style="width: 60% ; text-align: left">
                                                                         <asp:Button ID="btnNursery" CssClass="myclass button" runat="server" BorderStyle="None" ForeColor="white" Height="50%" 
                                                                             Text="Nursery" OnClick="nurerytable" CommandArgument="13">
                                                                           
                                                                        </asp:Button>
                                                                       &nbsp;
                                                                        <asp:HiddenField ID="hfbnursery" runat="server" />
                                                                        <asp:Label ID="lblbnursery" CssClass="label" runat="server"></asp:Label>
                                                                        <asp:Label runat="server" CssClass="label" Text ="- Batch,"/>
                                                                        <asp:HiddenField ID="hfsursery" runat="server" />
                                                                        <asp:Label ID="lblsnursery"  CssClass="label" runat="server"></asp:Label>
                                                                        <asp:Label ID="Label4" runat="server" CssClass="label" Text="- Subject(s)"/>
                                                                        
                                                                     
                                                                        
                                                                    </td>

                                                                    <%--<td style="text-align: center">
                                                                         <asp:Button ID="btne2" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Edit" />
                                                                       
                                                                    </td>
                                                                    <td style="text-align: center">
                                                                       
                                                                        <asp:Button ID="btnd2" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Delete" />
                                                                        
                                                                    </td>

                                                                    <td style="text-align: center">
                                                                       
                                                                     <asp:Button ID="btns2" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Subject" />
                                                                    <td style="text-align: center">
                                                                       
                                                                     <asp:Button ID="btnb2" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Batch" />--%>
                                                                </tr>
                                                               
                                                               
                                                                </tbody>
                                                            </table>
                                      
                                      
                   <div class="card-body" id="panelgrd2" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdbnursery" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                              
                             <asp:TemplateField HeaderText="SL" ItemStyle-Width="10">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                              
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="Year" HeaderText="Year" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="Remarks" HeaderText="Remarks" ItemStyle-Width="70" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="BatchID" HeaderText="BatchID" ItemStyle-Width="70" Visible="False" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                            <%--  <asp:BoundField  HeaderText="Actions" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>--%>
                              <asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("BatchID") %>' OnClick="Btn_DeleteBatch">Delete</asp:LinkButton>
                                        
                                    </ItemTemplate>
                                </asp:TemplateField>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      
                   <div class="card-body" id="Divsnursery" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdsnursery" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                            <%--    
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           --%>
                            
                             <asp:TemplateField HeaderText="SL" ItemStyle-Width="20">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="SubjectName" HeaderText="Subjects" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                            
                            <%--  <asp:BoundField  HeaderText="Actions" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>--%>
                              <%--<asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-mint  pull-right" >Add Student</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right">Delete</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning pull-right">Edit</asp:LinkButton>
                                       
                                       

                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      

                                        <table class="table table-bordered " style="width: 100%">
                                                                
                                                                <tbody>
                                                                <tr>
                                                                   
                                                                    <td style="width: 60% ; text-align: left">
                                                                        
                                                                          <asp:Button ID="btnKG" CssClass="myclass button" runat="server" BorderStyle="None" ForeColor="white" Height="50%" 
                                                                             Text="KG" OnClick="KGbtable" CommandArgument="14">
                                                                           
                                                                        </asp:Button>
                                                                       &nbsp;
                                                                        <asp:HiddenField ID="hfbKG" runat="server" />
                                                                        <asp:Label ID="lblbKG" CssClass="label" runat="server"/>
                                                                        <asp:Label runat="server" CssClass="label" Text ="- Batch,"/>
                                                                        <asp:HiddenField ID="hfsKG" runat="server" />
                                                                        <asp:Label ID="lblsKG"  CssClass="label" runat="server"></asp:Label>
                                                                        <asp:Label ID="Label5" runat="server" CssClass="label" Text="- Subject(s)"/>
                      
                                                                    </td>
                                                                    <%--<td style="text-align: center">
                                                                         <asp:Button ID="btne3" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Edit" />
                                                                    <td style="text-align: center">
                                                                        <asp:Button ID="btnd3" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Delete" />
                                                                    <td style="text-align: center">
                                                                         <asp:Button ID="btns3" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Subject" />
                                                                    <td style="text-align: center">
                                                                         <asp:Button ID="btnb3" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Batch" />--%>
                                                                </tr>
                                                               
                                                               
                                                                </tbody>
                                                            </table>
                                      
                                      
                                      
                                       <div class="card-body" id="panelgrd3" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdbKG" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                               <asp:TemplateField HeaderText="SL" ItemStyle-Width="10">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                              
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="Year" HeaderText="Year" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="Remarks" HeaderText="Remarks" ItemStyle-Width="70" > 
                            <ItemStyle Width="70px"></ItemStyle>

                            </asp:BoundField>
                          <asp:BoundField DataField="BatchID" HeaderText="BatchID" ItemStyle-Width="70" Visible="False" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>

                              <asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("BatchID") %>' OnClick="Btn_DeleteBatch">Delete</asp:LinkButton>

                                    </ItemTemplate>
                                </asp:TemplateField>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                   <%--   <div class="card-body" id="Div1" runat="server" style="display: none" >
                    
                    <br/>
                         
                                      </div>--%>
                                      
                                       <div class="card-body" id="DivsKG" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdsKG" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                            <%-- <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>--%>
                            <asp:TemplateField HeaderText="SL" ItemStyle-Width="20">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField DataField="SubjectName" HeaderText="Subjects" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                            
                            <%--  <asp:BoundField  HeaderText="Actions" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>--%>
                              <%--<asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-mint  pull-right" >Add Student</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right">Delete</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning pull-right">Edit</asp:LinkButton>
                                       
                                       

                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      

                                        <table class="table table-bordered " style="width: 100%">
                                                                
                                                                <tbody>
                                                                <tr>
                                                                   
                                                                    <td style="width: 60% ; text-align: left">
                                                                             <asp:Button ID="btn1" CssClass="myclass button" runat="server" BorderStyle="None" ForeColor="white" Height="50%" 
                                                                             Text="Grade I" OnClick="btable1" CommandArgument="1">
                                                                        </asp:Button>
                                                                          &nbsp; 
                                                                        <asp:HiddenField ID="hfb1" runat="server" />
                                                                        <asp:Label ID="lblb1" CssClass="label" runat="server"/>
                                                                        <asp:Label runat="server" CssClass="label" Text ="- Batch,"/>
                                                                        <asp:HiddenField ID="hfs1" runat="server" />
                                                                        <asp:Label ID="lbls1" CssClass="label" runat="server"/>
                                                                        <asp:Label ID="Label6" runat="server" CssClass="label" Text="- Subject(s)"/>

                                                                    </td>
                                                                   <%--<td style="text-align: center">
                                                                         <asp:Button ID="btne4" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Edit" />
                                                                       
                                                                   </td>
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btnd4" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Delete" />
                                                                  
                                                                    </td>
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btns4" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add subject" />
                                                                        
                                                                    </td>
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btnb4" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Batch" />
                                                                        
                                                                    </td>--%>
                                                                </tr>
                                                               
                                                               
                                                                </tbody>
                                                            </table>
                                      
                                       <div class="card-body" id="panelgrd4" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdbg1" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                <asp:TemplateField HeaderText="SL" ItemStyle-Width="10">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                             
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="Year" HeaderText="Year" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="Remarks" HeaderText="Remarks" ItemStyle-Width="70" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                           <asp:BoundField DataField="BatchID" HeaderText="BatchID" ItemStyle-Width="70" Visible="False" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                              <asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("BatchID") %>' OnClick="Btn_DeleteBatch">Delete</asp:LinkButton>

                                    </ItemTemplate>
                                </asp:TemplateField>
                             
                        </Columns>
                    </asp:GridView>
                                          
                         </div> 
                                      
                                       <div class="card-body" id="Divs1" runat="server" style="display: none" >
                    
                    <br/>
                  
                           <asp:GridView ID="grds1" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                           
                            <asp:TemplateField HeaderText="SL" ItemStyle-Width="20">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            
                            <asp:BoundField DataField="SubjectName" HeaderText="Subjects" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                            
                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 

                                       <table class="table table-bordered " style="width: 100%">
                                                                
                                                                <tbody>
                                                                <tr>
                                                                   
                                                                    <td style="width: 60% ; text-align: left">
                                                                         <asp:Button ID="btn2" CssClass="myclass button" runat="server" BorderStyle="None" ForeColor="white" Height="50%" 
                                                                             Text="Grade II" OnClick="btable2" CommandArgument="2">
                                                                        </asp:Button>
                                                                         &nbsp;  
                                                                        <asp:HiddenField ID="hfb2" runat="server" />
                                                                        <asp:Label ID="lblb2" CssClass="label" runat="server"/>
                                                                        <asp:Label runat="server" CssClass="label" Text ="- Batch,"/>
                                                                        <asp:HiddenField ID="hfs2" runat="server" />
                                                                        <asp:Label ID="lbls2" CssClass="label" runat="server"/>
                                                                        <asp:Label ID="Label7" runat="server" CssClass="label" Text="- Subject(s)"/>

                                                                    </td>
                                                                    <%--<td style="text-align: center">
                                                                          <asp:Button ID="btne5" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Edit" />
                                                                       
                                                                    </td>
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btnd5" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Delete" />
                                                                        
                                                                    </td>
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btns5" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Subject" />
                                                                        
                                                                    </td>
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btnb5" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Batch" />
                                                                      
                                                                    </td>--%>
                                                                </tr>
                                                               
                                                               
                                                                </tbody>
                                                            </table>
                                      
                                       <div class="card-body" id="panelgrd5" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdbG2" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                               <asp:TemplateField HeaderText="SL" ItemStyle-Width="10">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                              
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="Year" HeaderText="Year" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="Remarks" HeaderText="Remarks" ItemStyle-Width="70" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                          <asp:BoundField DataField="BatchID" HeaderText="BatchID" ItemStyle-Width="70" Visible="False" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                              <asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("BatchID") %>' OnClick="Btn_DeleteBatch">Delete</asp:LinkButton>

                                    </ItemTemplate>
                                </asp:TemplateField>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      
                                       <div class="card-body" id="Divs2" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grds2" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                          <%--   <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>--%>
                            
                             <asp:TemplateField HeaderText="SL" ItemStyle-Width="20">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                           
                            <asp:BoundField DataField="SubjectName" HeaderText="Subjects" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             
                            <%--  <asp:BoundField  HeaderText="Actions" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>--%>
                              <%--<asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-mint  pull-right" >Add Student</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right">Delete</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning pull-right">Edit</asp:LinkButton>
                                       
                                       

                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                     
                                       <table class="table table-bordered " style="width: 100%">
                                                                
                                                                <tbody>
                                                                <tr>
                                                                   
                                                                    <td style="width: 60% ; text-align: left">
                                                                        
                                                                         
                                                                         <asp:Button ID="btn3" CssClass="myclass button" runat="server" BorderStyle="None" ForeColor="white" Height="50%" 
                                                                             Text="Grade III" OnClick="btable3" CommandArgument="3">
                                                                        </asp:Button>
                                                                           &nbsp;
                                                                        <asp:HiddenField ID="hfb3" runat="server" />
                                                                        <asp:Label ID="lblb3" CssClass="label" runat="server"/>
                                                                        <asp:Label runat="server" CssClass="label" Text ="- Batch,"/>
                                                                        <asp:HiddenField ID="hfs3" runat="server" />
                                                                        <asp:Label ID="lbls3" CssClass="label" runat="server"/>
                                                                        <asp:Label ID="Label8" runat="server" CssClass="label" Text="- Subject(s)"/>

                                                                  
                                                                    </td>

                                                                   <%--<td style="text-align: center">
                                                                         <asp:Button ID="btne6" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Edit" />
                                                                       
                                                                   </td>
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btnd6" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Delete" />
                                                             
                                                                    </td>
                                                                    <td style="text-align: center">
                                                                      <asp:Button ID="btns6" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Subject" />
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btnb6" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Batch" />

                                                                    </td>--%>
                                                                </tr>
                                                               
                                                               
                                                                </tbody>
                                                            </table>
                                      
                                       <div class="card-body" id="panelgrd6" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdbG3" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                <asp:TemplateField HeaderText="SL" ItemStyle-Width="10">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                             
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="Year" HeaderText="Year" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="Remarks" HeaderText="Remarks" ItemStyle-Width="70" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                           <asp:BoundField DataField="BatchID" HeaderText="BatchID" ItemStyle-Width="70" Visible="False" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                              <asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("BatchID") %>' OnClick="Btn_DeleteBatch">Delete</asp:LinkButton>

                                    </ItemTemplate>
                                </asp:TemplateField>
                             
                            
                    

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      
                                       <div class="card-body" id="Divs3" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grds3" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                             <%--<asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           --%>
                             <asp:TemplateField HeaderText="SL" ItemStyle-Width="20">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField DataField="SubjectName" HeaderText="Subjects" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                            
                            <%--  <asp:BoundField  HeaderText="Actions" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>--%>
                              <%--<asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-mint  pull-right" >Add Student</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right">Delete</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning pull-right">Edit</asp:LinkButton>
                                       
                                       

                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 

                                       <table class="table table-bordered" style="width: 100%">
                                                                
                                                                <tbody>
                                                                <tr>
                                                                   
                                                                    <td style="width: 60% ; text-align: left">
                                                                         <asp:Button ID="btn4" CssClass="myclass button" runat="server" BorderStyle="None" ForeColor="white" Height="50%" 
                                                                             Text="Grade IV" OnClick="btable4" CommandArgument="4">
                                                                        </asp:Button>
                                                                          &nbsp; 
                                                                        <asp:HiddenField ID="hfb4" runat="server" />
                                                                        <asp:Label ID="lblb4" CssClass="label" runat="server"/>
                                                                        <asp:Label runat="server" CssClass="label" Text ="- Batch,"/>
                                                                        <asp:HiddenField ID="hfs4" runat="server" />
                                                                        <asp:Label ID="lbls4" CssClass="label" runat="server"/>
                                                                        <asp:Label ID="Label9" runat="server" CssClass="label" Text="- Subject(s)"/>

                                                                    </td>

                                                                   <%--<td style="text-align: center">
                                                                        <asp:Button ID="btne7" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Edit" />
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btnd7" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Delete" />
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btns7" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Subject" />
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btnb7" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Batch" />
                                                                    </td>--%>
                                                                </tr>
                                                               
                                                               
                                                                </tbody>
                                                            </table>
                                      
                                       <div class="card-body" id="panelgrd7" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdbG4" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                             <asp:TemplateField HeaderText="SL" ItemStyle-Width="10">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="Year" HeaderText="Year" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="Remarks" HeaderText="Remarks" ItemStyle-Width="70" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                           <asp:BoundField DataField="BatchID" HeaderText="BatchID" ItemStyle-Width="70" Visible="False" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                              <asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("BatchID") %>' OnClick="Btn_DeleteBatch">Delete</asp:LinkButton>

                                    </ItemTemplate>
                                </asp:TemplateField>
                             
                  

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      
                                       <div class="card-body" id="Divs4" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grds4" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                             <%--<asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           --%>
                             <asp:TemplateField HeaderText="SL" ItemStyle-Width="20">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField DataField="SubjectName" HeaderText="Subjects" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                            
                            <%--  <asp:BoundField  HeaderText="Actions" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>--%>
                              <%--<asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-mint  pull-right" >Add Student</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right">Delete</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning pull-right">Edit</asp:LinkButton>
                                       
                                       

                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 

                                       <table class="table table-bordered " style="width: 100%">
                                                                
                                                                <tbody>
                                                                <tr>
                                                                   
                                                                    <td style="width: 60%; text-align: left">
                                                                        
                                                                         <asp:Button ID="btn5" CssClass="myclass button" runat="server" BorderStyle="None" ForeColor="white" Height="50%" 
                                                                             Text="Grade V" OnClick="btable5" CommandArgument="5">
                                                                        </asp:Button>
                                                                         &nbsp;  
                                                                        <asp:HiddenField ID="hfb5" runat="server" />
                                                                        <asp:Label ID="lblb5" CssClass="label" runat="server"/>
                                                                        <asp:Label runat="server" CssClass="label" Text ="- Batch,"/>
                                                                        <asp:HiddenField ID="hfs5" runat="server" />
                                                                        <asp:Label ID="lbls5" CssClass="label" runat="server"/>
                                                                        <asp:Label ID="Label10" runat="server" CssClass="label" Text="- Subject(s)"/>

                                                                       
                                                                    </td>

                                                                   <%--<td style="text-align: center">
                                                                        <asp:Button ID="btne8" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Edit" />
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btnd8" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Delete" />
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btns8" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Subject" />
                                                                    <td style="text-align: center">
                                                                         <asp:Button ID="btnb8" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Batch" />

                                                                    </td>--%>
                                                                </tr>
                                                               
                                                               
                                                                </tbody>
                                                            </table>
                                      
                                       <div class="card-body" id="panelgrd8" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdbG5" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                 <asp:TemplateField HeaderText="SL" ItemStyle-Width="10">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="Year" HeaderText="Year" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="Remarks" HeaderText="Remarks" ItemStyle-Width="70" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                           <asp:BoundField DataField="BatchID" HeaderText="BatchID" ItemStyle-Width="70" Visible="False" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                              <asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("BatchID") %>' OnClick="Btn_DeleteBatch">Delete</asp:LinkButton>

                                    </ItemTemplate>
                                </asp:TemplateField>
                             
                   

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      
                                       <div class="card-body" id="Divs5" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grds5" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                            <%-- <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>--%>
                            <asp:TemplateField HeaderText="SL" ItemStyle-Width="20">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField DataField="SubjectName" HeaderText="Subjects" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                            
                            <%--  <asp:BoundField  HeaderText="Actions" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>--%>
                              <%--<asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-mint  pull-right" >Add Student</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right">Delete</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning pull-right">Edit</asp:LinkButton>
                                       
                                       

                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 

                                       <table class="table table-bordered " style="width: 100%">
                                                                
                                                                <tbody>
                                                                <tr>
                                                                   
                                                                    <td style="width: 60%; text-align: left">
                                                                        
                                                                        
                                                                         <asp:Button ID="btn6" CssClass="myclass button" runat="server" BorderStyle="None" ForeColor="white" Height="50%" 
                                                                             Text="Grade VI" OnClick="btable6" CommandArgument="6">
                                                                        </asp:Button>
                                                                          &nbsp; 
                                                                        <asp:HiddenField ID="hfb6" runat="server" />
                                                                        <asp:Label ID="lblb6" CssClass="label" runat="server"/>
                                                                        <asp:Label runat="server" CssClass="label" Text ="- Batch,"/>
                                                                        <asp:HiddenField ID="hfs6" runat="server" />
                                                                        <asp:Label ID="lbls6" CssClass="label" runat="server"/>
                                                                        <asp:Label ID="Label11" runat="server" CssClass="label" Text="- Subject(s)"/>
                                                                       
                                                                    </td>

                                                                    <%--<td style="text-align: center">
                                                                          <asp:Button ID="btne9" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Edit" />
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btnd9" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Delete" />
                                                                    <td style="text-align: center">
                                                                        <asp:Button ID="btns9" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Subject" />
                                                                    <td style="text-align: center">
                                                                        <asp:Button ID="btnb9" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Batch" />

                                                                    </td>--%>
                                                                </tr>
                                                               
                                                               
                                                                </tbody>
                                                            </table>
                                      
                                      
                                       <div class="card-body" id="panelgrd9" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdbG6" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                              <asp:TemplateField HeaderText="SL" ItemStyle-Width="10">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                               
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="Year" HeaderText="Year" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="Remarks" HeaderText="Remarks" ItemStyle-Width="70" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="BatchID" HeaderText="BatchID" ItemStyle-Width="70" Visible="False" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                              <asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("BatchID") %>' OnClick="Btn_DeleteBatch">Delete</asp:LinkButton>

                                    </ItemTemplate>
                                </asp:TemplateField>
                             
                   

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      
                                       <div class="card-body" id="Divs6" runat="server" style="display: none" >
                    
                    <br/>
                  
                                
                           <asp:GridView ID="grds6" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                             <%--   
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           --%>
                            
                             <asp:TemplateField HeaderText="SL" ItemStyle-Width="20">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField DataField="SubjectName" HeaderText="Subjects" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                            
                            <%--  <asp:BoundField  HeaderText="Actions" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>--%>
                              <%--<asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-mint  pull-right" >Add Student</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right">Delete</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning pull-right">Edit</asp:LinkButton>
                                       
                                       

                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 

                                       <table class="table table-bordered " style="width: 100%">
                                                                
                                                                <tbody>
                                                                <tr>
                                                                   
                                                                    <td style="width: 60% ; text-align: left">
                                                                        
                                                                        <asp:Button ID="btn7" CssClass="myclass button" runat="server" BorderStyle="None" ForeColor="white" Height="50%" 
                                                                             Text="Grade VII" OnClick="btable7" CommandArgument="7">
                                                                        </asp:Button>
                                                                           &nbsp;
                                                                        <asp:HiddenField ID="hfb7" runat="server" />
                                                                        <asp:Label ID="lblb7" CssClass="label" runat="server"/>
                                                                        <asp:Label runat="server" CssClass="label" Text ="- Batch,"/>
                                                                        <asp:HiddenField ID="hfs7" runat="server" />
                                                                        <asp:Label ID="lbls7" CssClass="label" runat="server"/>
                                                                        <asp:Label ID="Label12" runat="server" CssClass="label" Text="- Subject(s)"/>

                                                                      
                                                                    </td>

                                                                  <%--<td style="text-align: center">
                                                                        <asp:Button ID="btne10" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Edit" />
                                                                    <td style="text-align: center">
                                                                         <asp:Button ID="btnd10" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Delete" />

                                                                    </td>
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btns10" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Subject" />

                                                                    </td>
                                                                    <td style="text-align: center">
                                                                         <asp:Button ID="btnb10" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Batch" />

                                                                    </td>--%>
                                                                </tr>
                                                               
                                                               
                                                                </tbody>
                                                            </table>
                                      
                                      
                                       <div class="card-body" id="panelgrd10" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdbG7" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                <asp:TemplateField HeaderText="SL" ItemStyle-Width="10">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            
                             
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="Year" HeaderText="Year" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="Remarks" HeaderText="Remarks" ItemStyle-Width="70" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="BatchID" HeaderText="BatchID" ItemStyle-Width="70" Visible="False" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                              <asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("BatchID") %>' OnClick="Btn_DeleteBatch">Delete</asp:LinkButton>

                                    </ItemTemplate>
                                </asp:TemplateField>
                             
                   

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      
                                      
                                       <div class="card-body" id="Divs7" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grds7" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                             <%--   
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           --%>
                             <asp:TemplateField HeaderText="SL" ItemStyle-Width="20">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField DataField="SubjectName" HeaderText="Subjects" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                            
                            <%--  <asp:BoundField  HeaderText="Actions" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>--%>
                              <%--<asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-mint  pull-right" >Add Student</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right">Delete</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning pull-right">Edit</asp:LinkButton>
                                       
                                       

                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 

                                       <table class="table table-bordered" style="width: 100%">
                                                                
                                                                <tbody>
                                                                <tr>
                                                                   
                                                                    <td style="width: 60%; text-align: left">
                                                                        
                                                                         <asp:Button ID="btn8" CssClass="myclass button" runat="server" BorderStyle="None" ForeColor="white" Height="50%" 
                                                                             Text="Grade VIII" OnClick="btable8" CommandArgument="8">
                                                                        </asp:Button>
                                                                          &nbsp; 
                                                                        <asp:HiddenField ID="hfb8" runat="server" />
                                                                        <asp:Label ID="lblb8" CssClass="label" runat="server"/>
                                                                        <asp:Label runat="server" CssClass="label" Text ="- Batch,"/>
                                                                        <asp:HiddenField ID="hfs8" runat="server" />
                                                                        <asp:Label ID="lbls8" CssClass="label" runat="server"/>
                                                                        <asp:Label ID="Label13" runat="server" CssClass="label" Text="- Subject(s)"/>
                          
                                                                    </td>
                                                                   <%--<td style="text-align: center">
                                                                         <asp:Button ID="btne11" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Edit" />
                                                                    <td style="text-align: center">
                                                                         <asp:Button ID="btnd11" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Delete" />
                                                                    <td style="text-align: center">
                                                                         <asp:Button ID="btnb11" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Subject" />

                                                                    </td>
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btns11" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Batch" />

                                                                    </td>--%>
                                                                </tr>
                                                               
                                                               
                                                                </tbody>
                                                            </table>
                                      
                                       <div class="card-body" id="panelgrd11" runat="server" style="display: none">
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdbG8" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                               <asp:TemplateField HeaderText="SL" ItemStyle-Width="20">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                              
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="Year" HeaderText="Year" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="Remarks" HeaderText="Remarks" ItemStyle-Width="70" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="BatchID" HeaderText="BatchID" ItemStyle-Width="70" Visible="False" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                              <asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("BatchID") %>' OnClick="Btn_DeleteBatch">Delete</asp:LinkButton>

                                    </ItemTemplate>
                                </asp:TemplateField>
                             
                   

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      
                                       <div class="card-body" id="Divs8" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grds8" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                            <%-- <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           --%>
                            
                             <asp:TemplateField HeaderText="SL" ItemStyle-Width="20">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField DataField="SubjectName" HeaderText="Subjects" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             
                            <%--  <asp:BoundField  HeaderText="Actions" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>--%>
                              <%--<asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-mint  pull-right" >Add Student</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right">Delete</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning pull-right">Edit</asp:LinkButton>
                                       
                                       

                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      
                                       <table class="table table-bordered" style="width: 100%">
                                                                
                                                                <tbody>
                                                                <tr>
                                                                   
                                                                    <td style="width: 60%; text-align: left">
                                                                        
                                                                             <asp:Button ID="btn9" CssClass="myclass button" runat="server" BorderStyle="None" ForeColor="white" Height="50%" 
                                                                             Text="Grade IX" OnClick="btable9" CommandArgument="9">
                                                                        </asp:Button>
                                                                           &nbsp;
                                                                        <asp:HiddenField ID="hfb9" runat="server" />
                                                                        <asp:Label ID="lblb9" CssClass="label" runat="server"/>
                                                                        <asp:Label runat="server" CssClass="label" Text ="- Batch,"/>
                                                                        <asp:HiddenField ID="hfs9" runat="server" />
                                                                        <asp:Label ID="lbls9" CssClass="label" runat="server"/>
                                                                        <asp:Label ID="Label14" runat="server" CssClass="label" Text="- Subject(s)"/>
                                                                        
                                                                    </td>
                                                                  <%--<td style="text-align: center">
                                                                        <asp:Button ID="btne12" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Edit" />

                                                                  </td>
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btnd12" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Delete" />

                                                                    </td>
                                                                    <td style="text-align: center">
                                                                         <asp:Button ID="btns12" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Subject" />

                                                                    </td>
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btnb12" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Batch" />

                                                                    </td>--%>
                                                                </tr>
                                                               
                                                               
                                                                </tbody>
                                                            </table>
                                      
                                      
                                       <div class="card-body" id="panelgrd12" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdbG9" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                               <asp:TemplateField HeaderText="SL" ItemStyle-Width="10">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                              
                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="Year" HeaderText="Year" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="Remarks" HeaderText="Remarks" ItemStyle-Width="70" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="BatchID" HeaderText="BatchID" ItemStyle-Width="70" Visible="False" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                              <asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("BatchID") %>' OnClick="Btn_DeleteBatch">Delete</asp:LinkButton>

                                    </ItemTemplate>
                                </asp:TemplateField>
                             
                   

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      
                                       <div class="card-body" id="Divs9" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grds9" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                             <%--<asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           --%>
                            
                             <asp:TemplateField HeaderText="SL" ItemStyle-Width="20">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField DataField="SubjectName" HeaderText="Subjects" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                            
                            <%--  <asp:BoundField  HeaderText="Actions" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>--%>
                              <%--<asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-mint  pull-right" >Add Student</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right">Delete</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning pull-right">Edit</asp:LinkButton>
                                       
                                       

                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      
                                       <table class="table table-bordered " style="width: 100%">
                                                                
                                                                <tbody>
                                                                <tr>
                                                                   
                                                                    <td style="width: 60% ; text-align: left">
                                                                        
                                                                          <asp:Button ID="btn10" CssClass="myclass button" runat="server" BorderStyle="None" ForeColor="white" Height="50%" 
                                                                             Text="Grade X" OnClick="btable10" CommandArgument="10">
                                                                        </asp:Button>
                                                                          &nbsp; 
                                                                        <asp:HiddenField ID="hfb10" runat="server" />
                                                                        <asp:Label ID="lblb10" CssClass="label" runat="server"/>
                                                                        <asp:Label runat="server" CssClass="label" Text ="- Batch,"/>
                                                                        <asp:HiddenField ID="hfs10" runat="server" />
                                                                        <asp:Label ID="lbls10" CssClass="label" runat="server"/>
                                                                        <asp:Label ID="Label15" runat="server" CssClass="label" Text="- Subject(s)"/>
                                                                     
                                                                    </td>

                                                                    <%--<td style="text-align: center">
                                                                          <asp:Button ID="btne13" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Edit" />
                                                                    <td style="text-align: center">
                                                                         <asp:Button ID="btnd13" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Delete" />
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btns13" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Subject" />
                                                                    <td style="text-align: center">
                                                                          <asp:Button ID="btnb13" CssClass="myclass" runat="server" BorderStyle="None" ForeColor="white" Text="Add Batch" />--%>
                                                                </tr>
                                                               
                                                               
                                                                </tbody>
                                                            </table>
                                      
                                      
                                       <div class="card-body" id="panelgrd13" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grdbG10" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                 <asp:TemplateField HeaderText="SL" ItemStyle-Width="10">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                             <asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           
                            <asp:BoundField DataField="Year" HeaderText="Year" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                             <asp:BoundField DataField="Remarks" HeaderText="Remarks" ItemStyle-Width="70" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="BatchID" HeaderText="BatchID" ItemStyle-Width="70" Visible="False" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>
                              <asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("BatchID") %>' OnClick="Btn_DeleteBatch">Delete</asp:LinkButton>

                                    </ItemTemplate>
                                </asp:TemplateField>
                             
                   

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                      
                                       <div class="card-body" id="Divs10" runat="server" style="display: none" >
                    
                    <br/>
                  
                  
                           <asp:GridView ID="grds10" runat="server" AutoGenerateColumns="False"
                        CssClass="table table-striped table-dark table-hover "  Width="100%" >
                               <PagerStyle CssClass="pagination-ys"/>
                        <HeaderStyle CssClass="gridheader" />
                               <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <RowStyle HorizontalAlign="Center"></RowStyle>
                        <AlternatingRowStyle CssClass="Secondary" />

                        <Columns>
                                
                             <%--<asp:BoundField DataField="BatchName" HeaderText="Batch" ItemStyle-Width="30" >
                            <ItemStyle Width="30px" ></ItemStyle>
                            </asp:BoundField>
                           --%>
                             <asp:TemplateField HeaderText="SL" ItemStyle-Width="20">
                                <ItemTemplate >
                                     <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField DataField="SubjectName" HeaderText="Subjects" ItemStyle-Width="30" >
                            <ItemStyle Width="30px"></ItemStyle>
                            </asp:BoundField>
                            
                            <%--  <asp:BoundField  HeaderText="Actions" ItemStyle-Width="50" > 
                            <ItemStyle Width="70px"></ItemStyle>
                            </asp:BoundField>--%>
                              <%--<asp:TemplateField HeaderText="Actions" ItemStyle-Width="40" >
                                    <ItemTemplate >
                                       
                                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="btn btn-mint  pull-right" >Add Student</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger pull-right">Delete</asp:LinkButton>
                                         <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-warning pull-right">Edit</asp:LinkButton>
                                       
                                       

                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                             
                            
                    <%--   
                     <asp:TemplateField>
                            <ItemTemplate >
                               
                                <asp:LinkButton runat="server" CssClass="btn btn-warning pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      CausesValidation="False" ItemStyle-Width="55" > Edit </asp:LinkButton>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton runat="server" CssClass="btn btn-danger pull-right" CommandArgument= '<%# Eval("AdmissionNo") %>'
                                      ItemStyle-Width="55" CausesValidation="False" > Delete </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        </Columns>
                    </asp:GridView>
                  
                                                
                         </div> 
                                                </div>

                                   
    
                                </div>

                
                                 </div>
                 
                 
                
                       </div>
                 </div>
                 </div> 
           
           
       </ContentTemplate>
           
            </asp:Updatepanel>
</asp:Content>
