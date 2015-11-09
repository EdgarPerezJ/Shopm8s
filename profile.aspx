<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/MasterPage.master" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
         <div id="container">

              <div class="full_width clear">
             
             <div class="one_half first"> 
                 <h1>Update Profile:</h1>
                 <div class="full_width clear">
             
                 <div class="one_half first">
                     <asp:Image ID="profileimg" runat="server" width="200px" Height="200px" /></div>
                 <div class="one_half">&nbsp;
                     </div>
                 </div>
                  <div class="full_width clear">
             
                 <div class="one_half first">Change Photo:</div>
                 <div class="one_half">
                     <asp:FileUpload ID="picupload" runat="server"  /></div>
                  </div>
                  <div class="full_width clear">
             
                 <div class="one_half first">Name:</div>
                 <div class="one_half">
                     <asp:TextBox ID="nametxt" runat="server" ></asp:TextBox></div>
                  </div>
               <div class="full_width clear">
             
                 <div class="one_half first">Email:</div>
                 <div class="one_half">
                     <asp:TextBox ID="emailtxt" runat="server" ></asp:TextBox></div>
             </div>
                   <div class="full_width clear">
             
                 <div class="one_half first">&nbsp;</div>
                 <div class="one_half">
                     <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" />
                     <asp:Button ID="btndelete" runat="server" Text="Delete Account" OnClick="btndelete_Click" />
                 </div>
             </div>
             </div>
             <div class="one_half"> <h1>Change Password:</h1>
                 <div class="full_width clear">
             
             <div class="one_half first">Old Password:</div>
             <div class="one_half">
                 <asp:TextBox ID="oldpasstxt" runat="server"></asp:TextBox></div>
                </div>

                  <div class="full_width clear">
             
             <div class="one_half first">New Password:</div>
             <div class="one_half">
                 <asp:TextBox ID="newpasstxt" runat="server"></asp:TextBox></div>
                </div>
                 <div class="full_width clear">
             
                 <div class="one_half first">&nbsp;</div>
                 <div class="one_half">
                     <asp:Button ID="btnchange" runat="server" Text="Change" OnClick="btnchange_Click" /></div>
             </div>

             </div>
         </div>


         </div>

    </div>
</asp:Content>

