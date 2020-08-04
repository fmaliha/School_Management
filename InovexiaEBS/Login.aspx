<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="InovexiaEBS.Login" %>

<!DOCTYPE html>

<html lang="en">
	<head>
		<!-- Required meta tags -->
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
		
		
		<link rel="shortcut icon" href="img/favicon.ico" />
		<title>St. Peter's School of London</title>
		
		<!-- Common CSS -->
		<link rel="stylesheet" href="css/bootstrap.min.css" />
		<link rel="stylesheet" href="fonts/icomoon/icomoon.css" />

		<!-- Mian and Login css -->
		<link rel="stylesheet" href="css/main.css" />
        <style type="text/css">
            html body .riSingle .riTextBox[type="text"], html body .RadInput_Default .riTextBox {

                height:34px!important
            }

        </style>

	</head>  

	<body class="login-bg">
			
		<div class="container">
			<div class="login-screen row align-items-center">
				<div class="col-xl-12 col-lg-12 col-md-12 col-sm-12">
                    <form runat="server" idd="frmLogin">
                          <asp:ScriptManager ID="scrManager1" runat="server"></asp:ScriptManager>

                      <div class="login-container">
							<div class="row no-gutters">
								<div class="col-xl-4 col-lg-5 col-md-6 col-sm-12">
									<div class="login-box">
										<a href="#" class="login-logo">
											<img src="img/logo.png" alt="Amber IT Ltd." />
										</a>
                                        <div class="input-group">
                                            <span class="input-group-addon" id="username"><i class="icon-account_circle"></i></span>

                                            <telerik:RadTextBox ID="txtUserName" runat="server" CssClass="form-control" placeholder="Username" aria-label="username" aria-describedby="username" Width="100%">
                                            </telerik:RadTextBox>


                                        </div>
                                        <div class="input-group">
                                            <asp:RequiredFieldValidator ID="rfv1" ValidationGroup="vg" runat="server" ControlToValidate="txtUserName" ErrorMessage="Username Required" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
                                        </div>
										<br>
                                        <div class="input-group">
                                            <span class="input-group-addon" id="password"><i class="icon-verified_user"></i></span>


                                            <telerik:RadTextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Password" aria-label="Password" aria-describedby="password" TextMode="Password" Width="100%">
                                            </telerik:RadTextBox>


                                        </div>
                                        <div class="input-group">
                                             <asp:RequiredFieldValidator ID="rfv2" ValidationGroup="vg" runat="server" ControlToValidate="txtPassword"  ErrorMessage="Password Required" SetFocusOnError="true" ForeColor="Red" ></asp:RequiredFieldValidator>
                                        </div>
                                        <div class="actions clearfix">



                                            <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-primary" Text="Login" ValidationGroup="vg" OnClick="btnLogin_Click" />

                                        </div>
                                        <div class="input-group">
                                            <asp:Label ID="LoginMsg" runat="server" ForeColor="Red"></asp:Label>
                                        </div>
									 
								
									</div>
								</div>
								<div class="col-xl-8 col-lg-7 col-md-6 col-sm-12">
									<div class="login-slider"></div>
								</div>
							</div>
						</div>
						
					</form>
				</div>
			</div>
		</div>

      

		<footer class="main-footer no-bdr fixed-btm">
			<div class="container">
				  Copyright Amber Software Solutions Ltd. 2019.
			</div>
		</footer>
	</body>
</html>