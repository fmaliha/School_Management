<%@ Page Title="" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .widthClass {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <script language="javascript">

        function ValidationMessage(message) {
            //alertify.alert('Please provide all data with red star!');

            alertify.alert(message);
        }


        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode != 46 && charCode > 31
              && (charCode < 48 || charCode > 57))
                return false;
            return true;
        }
    </script>

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>


            <div class="row" id="MasterPanel" runat="server">
                <div class="col-lg-12">
                    <div class="panel">
                        <div class="panel-heading">

                               
                            <h3 class="panel-title"></h3>
                       



                        </div>
                        <div class="panel-body">
                            <h1>Under Construction....</h1>
                            <br />
                             <br />
                             <br />
                             <br />

                             <br />
                             <br />
                             <br />


                           

                        </div>



                    </div>
                </div>
            </div>
          

        </ContentTemplate>

       
    </asp:UpdatePanel>




</asp:Content>
