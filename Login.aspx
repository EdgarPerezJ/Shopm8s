<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <meta charset="iso-8859-1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./styles/layout.css" type="text/css" media="all">
    <link rel="stylesheet" href="./styles/mediaqueries.css" type="text/css" media="all">
    <link rel="stylesheet" href="./styles/validation.css" type="text/css" media="all">
    <script src="../scripts/jquery.1.9.0.min.js"></script>
    <script src="../scripts/jquery-mobilemenu.min.js"></script>
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
                <h1><a href="#">SHOPM8S</a></h1>
                <h2>Statement here</h2>
            </div>
        </header>
    </div>
    <div class="wrapper row3">
        <div id="container">
            <div class="full_width clear">
                <h2>Sign up Below:</h2>
                <div class="one_half first"><p>E-Mail:</p></div>
                    <div class="one_half"><asp:TextBox ID="emailtxt" runat="server" TextMode="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Text="<img src='./styles/images/Exclamation.gif' title='Please supply your Email' />" runat="server" ControlToValidate="emailtxt" ErrorMessage="Please supply your Email"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailtxt" ErrorMessage="Email is in wrong format" style="display:none"></asp:RegularExpressionValidator>
                    </div>
                    <div class="one_half first"><p>Password:</p></div>
                    <div class="one_half">
                        <asp:TextBox ID="passwordtxt" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="passwordtxt" Text="<img src='./styles/images/Exclamation.gif' title='Please supply your Password' />" ErrorMessage="Please supply your password"></asp:RequiredFieldValidator>
                    </div>
                    <div class="one_half first"><p>Repeat Password:</p></div>
                    <div class="one_half"><asp:TextBox ID="repasswordtxt" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="repasswordtxt" Text="<img src='./styles/images/Exclamation.gif' title='Please repeat your Password' />" ErrorMessage="Please Repeat your password"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passwordtxt" ControlToValidate="repasswordtxt" ErrorMessage="Passwords dont match" style="display:none"></asp:CompareValidator>
                    </div>
                    <div class="one_half first"><p>Profile Picture:</p></div>
                    <div class="one_half">
                        <asp:FileUpload ID="picupload" runat="server" />
                    </div>
                    <div class="one_half first"><p></p></div>
                     <div class="one_half">
                        <asp:Button ID="btnsave" runat="server" Text="Save" />
                    </div>
                    <div class="one_half first">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="validationsummary"
                            HeaderText="<div class='validationheader'>&nbsp;Please correct the following:</div>" />
                    </div>
                </div>
            </div>
        </div>
        <div class="wrapper row4">
          <footer id="footer" class="clear">
            <p class="fl_left">Copyright &copy; 2013 - All Rights Reserved - <a href="#">Domain Name</a></p>
            <p class="fl_right">Template by <a href="http://www.os-templates.com/" title="Free Website Templates">OS Templates</a></p>
          </footer>
        </div>
    </form>
</body>
</html>