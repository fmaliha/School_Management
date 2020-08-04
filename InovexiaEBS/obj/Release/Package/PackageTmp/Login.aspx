<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="InovexiaEBS.Login" %>

<!DOCTYPE html>


 <link href="<%=ResolveUrl("~/plugins/font-awesome/css/font-awesome.min.css")%>" rel="stylesheet"/>




<link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.1/css/all.css" >
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

<%--  <link href="<%=ResolveUrl("~/css/bootstrap.min.css")%>" rel="stylesheet" type="text/css"/>
<script src="<%=ResolveUrl("~/js/bootstrap.min.js") %>"></script>
 <script src="<%=ResolveUrl("~/js/jquery-2.1.1.min.js") %>"></script>--%>
     
<script>

    $(document).ready(function () {

       // $("#loading-image").hide();
        function explode(){
            $('.email > input').focus();
        }

        function explodePassword(){
            $('.password > input').focus();
        }
        setTimeout(explode, 300);
        
        $('.email > input').keydown(function(event){ 
            if (event.which === 13 || event.keyCode === 13) {
                $('.email > input').blur();
                $('.next').click();
            }
        });

        $('.password > input').keydown(function(event){ 
            if (event.which === 13 || event.keyCode === 13) {
                $('.login').click();
            }
        });


        $('.next').click(function(event){ 
            var emailInput = $('.email > input').val();
            if (validateEmail(emailInput)) {
                event.preventDefault();

                $.ajax({
                    url: "../Webservice/Dashboard.asmx/ValidateLoginPin",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    type: "POST",
                    data: "{ ID:'" + emailInput + "'}",
                    beforeSend: function () {
                        //$('form').empty();
                        //$('form').append('<div class="loader"></div>');
                        //setTimeout(function () {
                        //    location = location;;
                        //}, 1000);
                        
                    },
                    success: function (response) {
                        //do whatever your thingy..
                       // location = location;
                        if (response.d == "0") {
                            $('.warning').append('Invalid UserName');
                            //location = location;
                        }
                        if (response.d == "1") {
                            //location = location;
                            $('.inputs').addClass('shift');
                            $('.back').addClass('active-back');
                            $('.email > input').css({
                                'border': '1px solid #cccccc'
                            });

                            $('.warning').empty();
                            setTimeout(explodePassword, 400);
                        }
                        
                        

                    },
                    error: function (response) {
                        //do whatever your thingy..
                        //location = location;
                        event.preventDefault();
                        $('.warning').empty();
                        $('.email > input').css({
                            'border': '1px solid red'
                        });

                        $('.warning').append('Invalid UserName');


                    }
                });

                
            }
            else {
                event.preventDefault();
                $('.warning').empty();
                $('.email > input').css({
                    'border': '1px solid red' });

                $('.warning').append('Invalid UserName');

            }
        });


        $('.back').click(function(event){ 
            event.preventDefault();
            $('.inputs').removeClass('shift');
            $('.back').removeClass('active-back');
            setTimeout(explode, 300);
        });


        $('.login').click(function(event){ 
            event.preventDefault();
            var emailInput = $('.email > input').val();
            var password = $('.password > input').val();
            $.ajax({
                url: "../Webservice/Dashboard.asmx/ValidateLoginUser",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                type: "POST",
                data: "{ ID:'" + emailInput + "',Pin:'" + password + "'}",
                beforeSend: function () {
                    //$('form').empty();
                    //$('form').append('<div class="loader"></div>');
                    //setTimeout(function () {
                    //    location = location;;
                    //}, 1000);

                },
                success: function (response) {
                    //do whatever your thingy..
                    // location = location;
                    if (response.d == "0") {
                        $('.warning').append('Invalid Password');
                        //location = location;
                    }
                    if (response.d == "1") {
                        //location = location;
                        $('.warning').empty();

                        window.location.href = '<%=ResolveUrl("~/Dashboard.aspx") %>';

                         '<%=ResolveUrl("~/Images/calendar.gif") %>'
                    }



                },
                error: function (response) {
                    //do whatever your thingy..
                   // location = location;
                    event.preventDefault();
                    $('.warning').empty();
                    $('.email > input').css({
                        'border': '1px solid red'
                    });

                    $('.warning').append('Invalid UserName');


                }
            });
            
        });
    

    
        function validateEmail(emailInput) {
            if (emailInput.length > 4) {
                return true;
            }
            else {
                return false;
            }
        }
   
    });
    
</script>
        
<!------ Include the above in your HEAD tag ---------->
<head runat="server">
    <title>Login | ERP</title>

    <style>

        .user_card {
			margin-top: 60px;
			margin-bottom: auto;
			/*background: #f39c12; #1b7fab*/ 
            background: #1b7fab;
			position: relative;
			display: flex;
			justify-content: center;
			flex-direction: column;
			padding: 5px;
			/*box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);*/
              box-shadow: 0px 5px 80px 0px #e4e8f0;
			/*-webkit-box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
			-moz-box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);*/
			border-radius: 5px;

		}

.brand_logo_container {
			position: absolute;
			height: 170px;
			width: 170px;
			top: -75px;
			border-radius: 50%;
			background: #60a3bc;
			padding: 10px;
			text-align: center;
		}
		.brand_logo {
			height: 150px;
			width: 150px;
			border-radius: 50%;
			border: 2px solid white;
		}

.login-block{
    background: #DE6262;  /* fallback for old browsers */
background: -webkit-linear-gradient(to bottom, #FFB88C, #DE6262);  /* Chrome 10-25, Safari 5.1-6 */
background: linear-gradient(to right, rgb(0, 213, 230) 10%, rgb(31, 114, 162) 100%); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
float:left;
width:100%;
height:100%;
padding : 50px 0;
}

.active-back {
  color: #919cb2 !important;
}
.active-back:hover {
  cursor: pointer;
  color: #286efa !important;
}
.back {
  position: absolute;
  height: 20px;
  width: 40px;
  color: #d6dae4;
  display: block;
  transition: 0.3s;
  margin-left: 20px;
  margin-top: -30px;
  font-size: 24px;
}
.shift {
  left: -330px !important;
}
h3 {
  position: absolute;
  margin-left: 92px;
  margin-top: 20px;

  font-size: 22px;
  font-weight: 200;
  color: #ffffff;
}
input {
  width: 250px;
  height: 35px;
  border-radius: 3px;
  border: 1px solid #ccc;
  font-size: 14px;
  padding-left: 10px;
  transition: 0.3s;
}
input::-webkit-input-placeholder {
  font-size: 14px;
}
input:focus {
  border: 1px solid #286efa !important;
  outline-width: 0;
}
button {
  margin-top: 30px;
  width: 262px;
  height: 40px;
  background: #286efa;
  color: #fff;
  font-size: 14px;
  border: 1px solid #286efa;
  border-radius: 3px;
}
button:hover {
  background: #3c82ff;
  cursor: pointer;
}
.form {
  position: relative;
  margin: 0 auto;
  margin-top: 35px;
  width: 400px;
  height: 350px;
  /*background: #fff;*/

  border-radius: 5px;
  overflow: hidden;
}
.form form {
  margin-top: 50px;
  width: 750px;
}
.form form .inputs {
  position: relative;
  left: 76px;
  top: 100px;
  transition: 0.3s;
}
.form form .inputs .email {
  float: left;
  position: relative;
  width: 350px;
}
.form form .inputs .password {
  float: right;
  position: relative;
  width: 350px;
}
.warning {
  color: #f00;
  text-align: center;
  font-size: 15px;
  margin-top: 30px;
}
.loader {
  margin-left: 22%;
  margin-top: 22%;
  width: 50px;
  height: 50px;
  border-radius: 50%;
  border: 5px solid #e8ebf1;
  border-top-color: #286efa;
  animation: spinner 1s infinite linear;
}
@-moz-keyframes spinner {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(360deg);
  }
}
@-webkit-keyframes spinner {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(360deg);
  }
}
@-o-keyframes spinner {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(360deg);
  }
}
@keyframes spinner {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(360deg);
  }
}

 
.footer {
  position: fixed;
  left: 0;
  bottom: 0;
  width: 100%;
  background-color: #286273;
  color: white;
  text-align: center;
}
 

</style>
</head>

<body class="login-block">
    
    <div>
    <section >
    <div class="container">

<div class="d-flex justify-content-center h-100">
			<div class="user_card">
				<div class="d-flex justify-content-center">
					<div class="brand_logo_container">
                        <img src="Images/logo_png.png" class="brand_logo" alt="Logo">
						
					</div>
				</div>
				<div class="d-flex justify-content-center form_container">
        <div class="form">
  <form runat ="server"> 
    <div class="back"> <span><i class="fa fa-arrow-circle-left" aria-hidden="true"></i></span></div>
    <h3>Enter your credentials</h3>
    <%-- <img id="loading-image" src="Images/ajax-loader.gif" style="margin-left:90px;padding-top:10px"/>--%>
    <div class="inputs"> 
         
      <div class="email">

          <asp:TextBox ID="txtLoginID" runat="server" class="first" placeholder="Your UserName"></asp:TextBox>
          <br /><br /> 
          <asp:Label ID="Label4" runat="server" style="font-size: 11px; color: #FF0000;"></asp:Label>
          <asp:Button ID="Button1" class="next" runat="server" Text="Next"  
                onclick="btnLogin_Click1" BackColor="#3366FF" ForeColor="White" Font-Bold="True" />
      </div>
      <div class="password">

          <asp:TextBox ID="txtPassWord" runat="server" class="second" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
        <br /><br /> 

          <asp:Button ID="btnLogin" runat="server" class="login" Text="Log in"  BackColor="#3366FF" Font-Bold="True"
                onclick="btnLogin_Click" ForeColor="White" />
      </div>
    </div>
</form>
            </div>
                    </div>
               <%-- <h4  class="offset-md-5 col-md-7" style="color:white;float:right;">ERP </h4>--%>
                </div>
</div>
<p class="warning"></p>

    </div>

    </section>
    </div>

 <div class="footer">
     <div Style="float:right;">
     <span Style="margin-right:5px;padding:5px; color:white;"  >©2019 </span>
       <a Style="margin-right:5px;padding:5px; color:white;" href="#"  >Terms Of use </a>
     <a Style="margin-right:5px;padding:5px;  color:white;" href="#"  >Privacy & Security </a>
         </div> 
</div>
  
</body>




