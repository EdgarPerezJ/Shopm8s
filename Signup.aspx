<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="iso-8859-1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="./styles/layout.css" type="text/css" media="all" />
    <link rel="stylesheet" href="./styles/mediaqueries.css" type="text/css" media="all" />
    <link rel="stylesheet" href="/styles/alerts.css" type="text/css" media="all"/>
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Lato" />
    <link rel="stylesheet" href="/styles/bootstrap.min.css" type="text/css" media="all"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="/scripts/jquery-mobilemenu.min.js"></script>
    <script src="/scripts/bootstrap.min.js"></script>
    <!--[if lt IE 9]>
    <link rel="stylesheet" href="styles/ie.css" type="text/css" media="all">
    <script src="scripts/ie/css3-mediaqueries.min.js"></script>
    <script src="scripts/ie/ie9.js"></script>
    <script src="scripts/ie/html5shiv.min.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
       <div class="wrapper row1">
            <header id="header" class="clear">
                <div id="hgroup">
                    <h1><a href="Default.aspx">SHOPM8S</a></h1>
                    <h2>&nbsp;</h2>
                </div>
            </header>
        </div>
        <div class="wrapper row3">
            <div id="Div1" style="min-height: 518px;">
            <div id="container" >
                <div class="full_width clear">
                    <div class="one_half first">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger alert-dismissable" role="alert"
                                HeaderText="Please correct the following:" />
                    </div>
                    <div class="one_half">                                                    
                    </div>   
                </div>

                <div class="full_width clear">
                    <div class="one_half first">
                        <div class="panel panel-default">
                            <div class="panel-heading">Add your information</div>
                            <div class="panel-body">
                                <div class="form-group"> 
                                    <label>Name</label>
                                    <asp:TextBox ID="nametxt" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>  

                                <div class="form-group"> 
                                    <label>Email</label>
                                    <asp:TextBox ID="emailtxt" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox>                            
                                </div>

                                <div class="form-group"> 
                                    <label>Password</label>
                                    <asp:TextBox ID="passwordtxt" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>                            
                                </div>

                                <div class="form-group"> 
                                    <label>Repeat password</label>
                                    <asp:TextBox ID="repasswordtxt" runat="server" TextMode="Password" CssClass="form-control"> </asp:TextBox> 
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="repasswordtxt" ErrorMessage="Please Repeat your password" style="display:none" ></asp:RequiredFieldValidator>                       
                                </div>

                                <div class="form-group"> 
                                    <label>Profile picture</label>
                                    <asp:FileUpload ID="picupload" runat="server" />
                                </div>

                                <div class="form-group"> 
                                    <asp:Button ID="btnsave" runat="server" Text="Register" OnClick="btnsave_Click" CssClass="btn btn-sm btn-default"/>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="one_half">
                    </div>
                </div>
            </div>
        </div>
        <div class="wrapper row4">
          <footer id="footer" class="clear">
            <p class="fl_left"> <a href="#"> </a></p>
            <p class="fl_right"></p>
          </footer>
        </div>
    </form>
</body>
</html>
