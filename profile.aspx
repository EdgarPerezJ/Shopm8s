<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/MasterPage.master" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
         <div id="container">
             <div class="full_width clear">
                 <div class="one_half first"> 
                     <div class="panel panel-default">
                        <div class="panel-heading">Personal Information</div>
                        <div class="panel-body"> 
                            <div style="display:inline-block"> 
                                 <div class="form-group"> 
                                     <asp:Image ID="profileimg" runat="server" width="100px" Height="100px" />
                                 </div>
                            </div>
                            <div style="display:inline-block"> 
                                 <div class="form-group">
                                    <label>Profile picture</label>
                                    <asp:FileUpload ID="picupload" runat="server" />
                                 </div>
                            </div>                        
                            <div class="form-group">
                                <label>Name</label>
                                <asp:TextBox ID="nametxt" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="form-group">             
                                <label>Email</label>
                                <asp:TextBox ID="emailtxt" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>             
                             <div class="form-group">
                                 <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" CssClass="btn btn-sm btn-default"/>
                                 <asp:Button ID="btndelete" runat="server" Text="Delete Account" OnClick="btndelete_Click" CssClass="btn btn-sm btn-default"/>
                             </div>
                        </div>
                    </div>
                </div>

                <div class="one_half"> 
                     <div class="panel panel-default">
                            <div class="panel-heading">Change password</div>
                            <div class="panel-body"> 
                                <div class="form-group">
                                    <label>Old Password</label>
                                    <asp:TextBox ID="oldpasstxt" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label>New Password</label>
                                    <asp:TextBox ID="newpasstxt" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="btnchange" runat="server" Text="Change" OnClick="btnchange_Click" CssClass="btn btn-sm btn-default" />
                                </div>
                            </div>
                        </div>
                 </div>
            </div>

         </div>

    </div>
</asp:Content>

