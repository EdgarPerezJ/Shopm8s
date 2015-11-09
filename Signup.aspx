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
                <h2>&nbsp;</h2>
            </div>
        </header>
    </div>
        <div class="wrapper row3">
        <div id="container">
        <div class="full_width clear">
      <h2>Sign up Below:</h2>
      <div class="one_half first"><p>Name:</p></div>
      <div class="one_half"><asp:TextBox ID="nametxt" runat="server" ></asp:TextBox>
          
            
            </div>
      <div class="one_half first"><p>E-Mail:</p></div>
      <div class="one_half"><asp:TextBox ID="emailtxt" runat="server" TextMode="Email"></asp:TextBox>
          
           
            </div>
      <div class="one_half first"><p>Password:</p></div>
      <div class="one_half">
          <asp:TextBox ID="passwordtxt" runat="server" TextMode="Password"></asp:TextBox>
          
            
            
            
            </div>
      <div class="one_half first"><p>Repeat Password:</p></div>
      <div class="one_half"><asp:TextBox ID="repasswordtxt" runat="server" TextMode="Password"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="repasswordtxt" ErrorMessage="Please Repeat your password" style="display:none" ></asp:RequiredFieldValidator>
          
            </div>
      <div class="one_half first"><p>Profile Picture:</p></div>
      <div class="one_half">
          <asp:FileUpload ID="picupload" runat="server" /></div>
            <div class="one_half first"><p></p></div>
         <div class="one_half">
             <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" />
        </div>
        <div class="one_half first">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" style="color:red"/>
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
