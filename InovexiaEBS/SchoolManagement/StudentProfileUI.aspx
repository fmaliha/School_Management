<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="StudentProfileUI.aspx.cs" Inherits="InovexiaEBS.SchoolManagement.StudentProfileUI" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server" >
    
    <style>
        
         .myclass{
    display:inline-block;
    width:640px;
    height: 100%;
             text-align: left;

                      
}
         .border {
             border-right-style: solid;
             border-bottom-style: solid;
             border-width: 1px;
             border-color: #6666ff;
         }

         .tableheader {
             background-color: #ccd9ff;
         }

         .name {
             font-family: sans-serif;
             color: #2e2e1f;
              font-weight: bold;
         }

         .labels {
             font-weight: bold;
         }
    </style>
    
<asp:Updatepanel runat="server">
       <ContentTemplate>

     <div class="col-lg-12">
            <div class="card">
               
                <div class="card-body">
        <div class="row" id="MasterPanelp1" runat="server">
            
                  <div class="row gutters">
                     

                       <div class="col-md-3"  style="border-bottom: 2px solid  #6666ff;height: ; align-content: center; left: 12px" >

                           <asp:Image ID="Image1" runat="server" Height="200px" Width="240px" />

                           <asp:Label ID="lblstuname" runat="server" CssClass="name"></asp:Label>
                           <br/>
                           <asp:Label ID="Label1" runat="server" Text="Admission No: " CssClass="labels"></asp:Label>

                           <asp:Label ID="lbladmsnNO" runat="server"></asp:Label>
                           <br/>
                           <asp:Label ID="Label2" runat="server" Text="Batch:" CssClass="labels"></asp:Label>
                           <asp:Label ID="lblSbatch" runat="server" Text="Not Assigned" ></asp:Label>
                           <br/>
                           <asp:Label ID="Label3" runat="server" Text="Grade:" CssClass="labels"></asp:Label>
                           <asp:Label ID="lblSGrade" runat="server" Text="Not Assigned" ></asp:Label>
                           <br/>
                           <asp:Label ID="Label5" runat="server" Text="Section:" CssClass="labels"></asp:Label>
                            <asp:Label ID="lblSSection" runat="server" Text="Not Assigned" ></asp:Label>
                            <br/>
                           <asp:Label ID="Label8" runat="server" Text="Session:" CssClass="labels"></asp:Label>
                            <asp:Label ID="lblSSession" runat="server" Text="Not Assigned" ></asp:Label>
                   <%-- <i class="fa fa-user-plus fa-5x "></i>--%>
                 </div>
                     
                 <div class="col-md-8 " style="border-left: 2px solid  #6666ff ; height: 100%; left: 10px ">
                     
                   <h3 style="font-family: fantasy">Student Profile</h3> 
                    
                     <div class="list-divider"></div> 
                         <br/>

                     <div >
                            <ul class="nav nav-tabs " role="tablist" style="width: 750px; background-color: #e6e6ff">   
                                                            
                            <li class="nav-item">
                                <a class="nav-link active" id="tabStuProfile" runat="server" href="#tabprofile" data-toggle="tab" role="tab" 
                                    aria-controls="tabprofile"  aria-selected="True"><b>Profile</b></a>
                               
                            </li>

                            <li class="nav-item">
                                <a class="nav-link" id="tabStuCourses" runat="server" href="#tabcourse" data-toggle="tab" role="tab" 
                                    aria-controls="tabcourse"  aria-selected="True"><b>Courses</b></a>
                            </li>

                            <li class="nav-item">
                                <a class="nav-link" id="tabStuassesments" runat="server" href="#tabassesment" data-toggle="tab" role="tab" 
                                    aria-controls="tabassesment"  aria-selected="True"><b>Assesment</b></a>
                            </li>

                            
                        </ul>
                         <%--<br/>--%>
                        
                    
                  </div>
                     <%-- <div style="float: right" class="pull-right">
                         
                             <asp:Button ID="btnstudents" CssClass="btn btn-warning "  runat="server" CausesValidation="False" Text="Students" />
                               <asp:Button ID="btneditpro" CssClass="btn btn-warning  " runat="server" CausesValidation="False" Text="Edit" />
                    
                         
                         </div>--%>
                     
                      <div id="myTabContentprofile" class="tab-content" runat="server" style="width: 750px" >
                                
                           <div id="tabprofile" class="tab-pane active" >
                                        
                               <div style="background-color:  #ffeecc;size:initial">
                                               
                                                <h4 style="font-family: fantasy; padding: 2px">&nbsp;Student Details<i class="fa fa-edit pull-right"></i></h4>
                                            <%--    <br/>--%>
                                                
                                            </div>
                                           <%-- <div  class="table" style="width: 100% ; background-color:#ffeecc">
                                               <table>
                                                    
                                                     <thead>
                                                            <tr>
                                                              <td scope="col" style="font-family: fantasy;font-size: 150%">Student Details</td>
                                                              <td></td>
                                                               <td ></td>
                                                              <td> <i class="fa fa-edit pull-right"></i></td>
                                                            </tr>
                                                         
                                                     </thead>
                                                   </table>
                                             
                                               
                                                
                                           </div>--%>
                                          
                                         
                                            <div id="tblstudetails" >
                                                 <table class="table" style="width: 100%">
                                                     <col width="40%"/>
                                                     <col width="10%"/>
                                                     <col width="50%"/>
                                                     <thead  class="tableheader">
                                                            <tr>
                                                              <th scope="col">Personal Details</th>
                                                                 
                                                              <td  class="tableheader"></td>
                                                                <td  class="tableheader"></td>
                                                               <td> <i class="fa fa-caret-down"></i></td>
                                                            </tr>
                                                         
                                                    </thead>
                                                    <tbody>
                                                   <%-- <tr>
                                                      <th scope="row">Admission No</th>
                                                      <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lbladmissionno" runat="server"></asp:Label>

                                                      </td>
                                                     
                                                    </tr>--%>

                                                    <tr>
                                                        
                                                      <th scope="row">Admission Date</th>
                                                      
                                                       <td scope="row">:</td>
                                                      <td>
                                                           
                                                          <asp:Label ID="lbladmissiondate" runat="server" Text="-"></asp:Label>

                                                      </td>
                                                      
                                                    </tr>

                                                    <tr>
                                                      <th scope="row">Student ID</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          
                                                          <asp:Label ID="lblSID" runat="server" Text="-"></asp:Label>

                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Date Of Birth</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          
                                                          <asp:Label ID="lblDOB" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Gender</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblGender" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Blood</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblblood" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Birth Place</th>
                                                                  <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblBirthplace" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Nationality</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblnationality" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Language</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lbllanguage" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Religion</th>
                                                                  <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblreligion" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                    <tr>
                                                        
                                                      <th scope="row">Student Category</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblStucategory" runat="server" Text="-"> </asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                      
                                                  </tbody>
                                                 </table>
                                            </div>
                                 
                                            <div class="list-divider"></div>   
                                            <br/>
                                            <br/>
                                            
                                            <div id="tblstucontactdetails">
                                                 <table class="table" style="width: 100%">
                                                     <col width="40%"/>
                                                     <col width="10%"/>
                                                     <col width="50%"/>
                                                     <thead  class="tableheader">
                                                            <tr>
                                                              <th scope="col">Contact Details</th>
                                                                  <%--<asp:Button ID="btnheadercontactdetails" runat="server" CssClass="tableheader myclass"  
                                                                       BorderStyle="None" Text="" OnClick="btnheadercontactdetails_OnClick" />
                                                              </th>--%>
                                                               <td  class="tableheader"></td>
                                                                <td  class="tableheader"></td>
                                                               <td> <i class="fa fa-caret-down"></i></td>
                                                            </tr>
                                                         
                                                    </thead>
                                                    <tbody>
                                                    <tr>
                                                      <th scope="row">Current Address</th>
                                                      <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblCurrAdd" runat="server" Text="-" ></asp:Label>

                                                      </td>
                                                     
                                                    </tr>

                                                    <tr>
                                                        
                                                      <th scope="row">Permanent Address</th>
                                                      
                                                       <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblPerAdd" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                      
                                                    </tr>

                                                    <tr>
                                                      <th scope="row">City</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblcity" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Pin Code</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblpincode" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Country</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblcountry" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Phone Number</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblphone" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                             <tr>
                                                      <th scope="row">Phone Phone 2</th>
                                                                  <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblphone2" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Email</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblemail" runat="server" Text="-" ></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                   
                                                  </tbody>
                                                 </table>
                                            </div>
                                            
                                <div class="list-divider"></div>  
                               <br/>
                               <br/>
                                             <div style="background-color:  #ffeecc;size:initial">
                                               
                                                <h4 style="font-family: fantasy; padding: 2px">&nbsp;Guardian Details<i class="fa fa-edit pull-right"></i></h4>
                                            <%--    <br/>--%>
                                                
                                            </div>
                               
                               
                                            <div id="tblguardiandetails" >
                                                 <table class="table" >
                                                     <col width="40%"/>
                                                     <col width="10%"/>
                                                     <col width="50%"/>
                                                     <thead  class="tableheader">
                                                            <tr>
                                                              <th scope="col">Guardian Details</th>
                                                              <td  class="tableheader"></td>
                                                                <td  class="tableheader"></td>
                                                               <td> <i class="fa fa-caret-down"></i></td>
                                                            </tr>
                                                         
                                                    </thead>
                                                 <tbody>
                                                    <tr>
                                                      <th scope="row">Name</th>
                                                      <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblGname" runat="server" Text="-"></asp:Label>

                                                      </td>
                                                     
                                                    </tr>

                                                    <tr>
                                                        
                                                      <th scope="row">Nationality</th>
                                                      
                                                       <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblGnationality" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                      
                                                    </tr>

                                                    <tr>
                                                      <th scope="row">Relationship With Student</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblGrel" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                     
                                                            
                                                      <tr>
                                                      <th scope="row">Residensial Address</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblGresAdd" runat="server" Text="-" ></asp:Label>
                                                      </td>
                                                     
                                                    </tr>  
                                                                 
                                                     <tr>
                                                      <th scope="row">Present Address</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblGpreAdd" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Permanent Address</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblGperAdd" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Telephone No</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblGPNo" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                             <tr>
                                                      <th scope="row">Mobile No</th>
                                                                  <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblGMobile" runat="server" Text="-" ></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Email</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblGemail" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                     
                                                  </tbody>
                                                 </table>
                                            </div>
                            <div class="list-divider"></div>                   
                                            <br/>
                                         
                                            
                                             <div style="background-color:  #ffeecc; ">
                                               
                                                <h4 style="font-family: fantasy; padding: 2px">&nbsp;Parent`s Details<i class="fa fa-edit pull-right"></i></h4>
                                          
                                            </div>
                                      <br/>
                               
                               <div id="tblfatherdetails" >
                                                 <table class="table" >
                                                     <col width="40%"/>
                                                     <col width="10%"/>
                                                     <col width="50%"/>
                                                     <thead  class="tableheader">
                                                            <tr>
                                                              <th scope="col">Father`s Details</th>
                                                              <td  class="tableheader"></td>
                                                                <td  class="tableheader"></td>
                                                               <td> <i class="fa fa-caret-down"></i></td>
                                                            </tr>
                                                         
                                                    </thead>
                                                        <tbody>
                                                    <tr>
                                                      <th scope="row">Name</th>
                                                      <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFname" runat="server" Text="-"></asp:Label>

                                                      </td>
                                                     
                                                    </tr>

                                                    <tr>
                                                        
                                                      <th scope="row">Nationality</th>
                                                      
                                                       <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFnationality" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                      
                                                    </tr>

                                                    <tr>
                                                      <th scope="row">Marital Status</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFmaritalstatus" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">In Residence with Child</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFresidence" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Educational Qualification</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFeducation" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                              <tr>
                                                      <th scope="row">Occupation</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFocc" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Organization</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblForg" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                             <tr>
                                                      <th scope="row">Designation</th>
                                                                  <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFdesignation" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Year Of Service</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFyearofservice" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Office Address</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFOffAdd" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                        <tr>
                                                      <th scope="row">Office Telephone</th>
                                                                  <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFoffTelephone" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>   
                                                            
                                                    <tr>
                                                        
                                                      <th scope="row">Present Address</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFPreAdd" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                            <tr>
                                                      <th scope="row">Permanent Address</th>
                                                      <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFPerAdd" runat="server" Text="-"></asp:Label>

                                                      </td>
                                                     
                                                    </tr>

                                                    <tr>
                                                           
                                                             <tr>
                                                      <th scope="row">Telephone No</th>
                                                                  <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFTelephone" runat="server" Text="-" ></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                      <th scope="row">Mobile No</th>
                                                      
                                                       <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFMobile" runat="server" Text="-" ></asp:Label>
                                                      </td>
                                                      
                                                    </tr>

                                                    <tr>
                                                      <th scope="row">Email</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblFmail" runat="server" Text="-" ></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                   

                                                  </tbody>
                                                 </table>
                                            </div>
                              <div class="list-divider"></div>              
                                            <br/>
                                            <br/>
                                            <div id="tblmotherdetails" >
                                                 <table class="table" >
                                                     <col width="40%"/>
                                                     <col width="10%"/>
                                                     <col width="50%"/>
                                                     <thead  class="tableheader">
                                                            <tr>
                                                              <th scope="col">Mother`s Details</th>
                                                              <td  class="tableheader"></td>
                                                                <td  class="tableheader"></td>
                                                               <td> <i class="fa fa-caret-down"></i></td>
                                                            </tr>
                                                         
                                                    </thead>
                                                         <tbody>
                                                    <tr>
                                                      <th scope="row">Name</th>
                                                      <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMName" runat="server" Text="-"></asp:Label>

                                                      </td>
                                                     
                                                    </tr>

                                                    <tr>
                                                        
                                                      <th scope="row">Nationality</th>
                                                      
                                                       <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMnationality" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                      
                                                    </tr>

                                                    <tr>
                                                      <th scope="row">Marital Status</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMmaritalStatus" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">In Residence with Child</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMresidencewithstudent" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Educational Qualification</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMeducation" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                     <tr>
                                                      <th scope="row">Occupation</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMocc" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                                    
                                                     <tr>
                                                      <th scope="row">Organization</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMOrg" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                             <tr>
                                                      <th scope="row">Designation</th>
                                                                  <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMdesignation" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Year Of Service</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMYearofservice" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                        
                                                              
                                                             <tr>
                                                      <th scope="row">Office Telephone</th>
                                                                  <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMoffTel" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                                 
                                                     <tr>
                                                      <th scope="row">Office Address</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMoffAdd" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                             <tr>
                                                      <th scope="row">Telephone No</th>
                                                                  <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMTelephone" runat="server" Text="-" ></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                     
                                                             <tr>
                                                        
                                                      <th scope="row">Residential Address</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMresidence" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                                    
                                                    <tr>
                                                        
                                                      <th scope="row">Present Address</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMPreAdd" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                            <tr>
                                                      <th scope="row">Permanent Address</th>
                                                      <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMPerAdd" runat="server" Text="-"></asp:Label>

                                                      </td>
                                                     
                                                    </tr>

                                                    <tr>
                                                        
                                                      <th scope="row">Mobile No</th>
                                                      
                                                       <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMMobile" runat="server" Text="-" ></asp:Label>
                                                      </td>
                                                      
                                                    </tr>

                                                    <tr>
                                                      <th scope="row">Email</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblMemail" runat="server" Text="-" ></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                   

                                                  </tbody>
                                                 </table>
                                            </div>
                                      <div class="list-divider"></div>          
                                            <br/>
                                            <br/>

                                             <div style="background-color: #ffeecc;">
                                               
                                                <h4 style="font-family: fantasy; padding: 2px">&nbsp;Primary & Emergency Contact<i class="fa fa-edit pull-right"></i></h4>
                                              
                                                
                                            </div>
                               
                                <div id="tblcontactdetails" >
                                                 <table class="table" >
                                                     <col width="40%"/>
                                                     <col width="10%"/>
                                                     <col width="50%"/>
                                                     <thead  class="tableheader">
                                                            <tr>
                                                              <th scope="col">Primary & Emergency Contact Details</th>
                                                              <td  class="tableheader"></td>
                                                                <td  class="tableheader"></td>
                                                               <td> <i class="fa fa-caret-down"></i></td>
                                                            </tr>
                                                         
                                                    </thead>
                                                        <tbody>
                                                    <tr>
                                                      <th scope="row">Name</th>
                                                      <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblEname" runat="server" Text="-"></asp:Label>

                                                      </td>
                                                     
                                                    </tr>

                                                    <tr>
                                                        
                                                      <th scope="row">Nationality</th>
                                                      
                                                       <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblEnationality" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                      
                                                    </tr>

                                                    <tr>
                                                      <th scope="row">Reationship with Student</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblErel" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Present Address</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblEpreAdd" runat="server" Text="-" ></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Permanent Address</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblEperAdd" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Telephone No</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblETelephone" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                             <tr>
                                                      <th scope="row">Mobile No</th>
                                                                  <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblEmobile" runat="server" Text="-" ></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Email</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblEemail" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                   
                                                  </tbody>
                                                 </table>
                                            </div>
                             <div class="list-divider"></div>                  
                                             <div style="background-color:  #ffeecc;">
                                               
                                                <h4 style="font-family: fantasy; padding: 2px">&nbsp;Previous Details<i class="fa fa-edit pull-right"></i></h4>
                                                <br/>
                                                
                                            </div>
                               
                               
                                <div id="tblpreviousdetails" >
                                                 <table class="table" >
                                                     <col width="40%"/>
                                                     <col width="10%"/>
                                                     <col width="50%"/>
                                                     <thead  class="tableheader">
                                                            <tr>
                                                              <th scope="col">Previous Details</th>
                                                              <td  class="tableheader"></td>
                                                                <td  class="tableheader"></td>
                                                               <td> <i class="fa fa-caret-down"></i></td>
                                                            </tr>
                                                         
                                                    </thead>
                                                        <tbody>
                                                    <tr>
                                                      <th scope="row">Institute Name</th>
                                                      <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblPrevIname" runat="server" Text="-"></asp:Label>

                                                      </td>
                                                     
                                                    </tr>

                                                    <tr>
                                                        
                                                      <th scope="row">Previous Grade</th>
                                                      
                                                       <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblPrevGrade" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                      
                                                    </tr>

                                                    <tr>
                                                      <th scope="row">Address</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblPrevAdd" runat="server" Text="-" ></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Telephone No</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblPrevTel" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Email</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblPrevmail" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Date Attended</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblPrevdateattended" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                             <tr>
                                                      <th scope="row">Attending Currently</th>
                                                                  <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblPrevAttendingcurrently" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                               
                                                  </tbody>
                                                 </table>
                                            </div>
                             
                                <div class="list-divider"></div>  
                               <div id="tblreferees" >
                                                 <table class="table" >
                                                     <col width="40%"/>
                                                     <col width="10%"/>
                                                     <col width="50%"/>
                                                     <thead  class="tableheader">
                                                            <tr>
                                                              <th scope="col">Key Referee Details</th>
                                                              <td  class="tableheader"></td>
                                                                <td  class="tableheader"></td>
                                                               <td> <i class="fa fa-caret-down"></i></td>
                                                            </tr>
                                                         
                                                    </thead>
                                                        <tbody>
                                                            
                                                            <tr>
                                                      <th scope="row">Referee 1</th>
                                                      <td scope="row">:</td>
                                                      <td>
                                                        

                                                      </td>
                                                     
                                                    </tr>
                                                    <tr>
                                                      <th scope="row">Name</th>
                                                      <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR1name" runat="server" Text="-"></asp:Label>

                                                      </td>
                                                     
                                                    </tr>

                                                    <tr>
                                                        
                                                      <th scope="row">Nationality</th>
                                                      
                                                       <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR1nationality" runat="server" Text="-" ></asp:Label>
                                                      </td>
                                                      
                                                    </tr>

                                                    <tr>
                                                      <th scope="row">Reationship with Student</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR1rel" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Present Address</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR1preadd" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Permanent Address</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR1peradd" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Telephone No</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR1Telephone" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                             <tr>
                                                      <th scope="row">Mobile No</th>
                                                                  <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR1Mobile" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Email</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR1mail" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                     
                                                            
                                                             <tr>
                                                      <th scope="row">Referee 2</th>
                                                      <td scope="row">:</td>
                                                      <td>
                                                        

                                                      </td>
                                                     
                                                    </tr>
                                                    <tr>
                                                      <th scope="row">Name</th>
                                                      <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR2name" runat="server" Text="-"></asp:Label>

                                                      </td>
                                                     
                                                    </tr>

                                                    <tr>
                                                        
                                                      <th scope="row">Nationality</th>
                                                      
                                                       <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR2nationality" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                      
                                                    </tr>

                                                    <tr>
                                                      <th scope="row">Reationship with Student</th>
                                                         <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR2rel" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Present Address</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR2preadd" runat="server" Text="-" ></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Permanent Address</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR2peradd" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Telephone No</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR2tel" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                             <tr>
                                                      <th scope="row">Mobile No</th>
                                                                  <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR2mobile" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>
                                                            
                                                     <tr>
                                                      <th scope="row">Email</th>
                                                          <td scope="row">:</td>
                                                      <td>
                                                          <asp:Label ID="lblR2email" runat="server" Text="-"></asp:Label>
                                                      </td>
                                                     
                                                    </tr>       
                                   
                                                  </tbody>
                                                 </table>
                                            </div>
                               <br/>  
                           </div>
                          
                          
                           <div id="tabcourse" class="tab-pane fade" >
                               

                           </div>
                          
                           <div id="tabassesment" class="tab-pane fade" >
                               

                           </div>
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
