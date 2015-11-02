<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/MasterPage.master" AutoEventWireup="true" CodeFile="Sell.aspx.cs" Inherits="Sell" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="wrapper row3">
        <div id="container">
        <div class="full_width clear">
      <h2>Post your product:</h2>
      <div class="one_half first"><p>Product Name:</p></div>
      <div class="one_half"><asp:TextBox ID="producttxt" runat="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="producttxt" ErrorMessage="Please supply your product name" style="display:none"></asp:RequiredFieldValidator>
          
            
          
            
          
            
          
            </div>
      <div class="one_half first"><p>Price:</p></div>
      <div class="one_half">
          <asp:TextBox ID="pricetxt" runat="server" style="width:50px" TextMode="Number" ></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="pricetxt" ErrorMessage="Set your price" style="display:none"></asp:RequiredFieldValidator>
            
            
            
            </div>
      <div class="one_half first"><p>Type:</p></div>
      <div class="one_half">
          <asp:DropDownList ID="typedbl" runat="server">
              <asp:ListItem Value="Women">Women</asp:ListItem>
              <asp:ListItem>Men</asp:ListItem>
              <asp:ListItem>Baby &amp; Kids</asp:ListItem>
              <asp:ListItem>Home</asp:ListItem>
              <asp:ListItem>Electronics</asp:ListItem>
          </asp:DropDownList>          
         
            </div>
            <div class="one_half first"><p>Description:</p></div>
      <div class="one_half"><asp:TextBox ID="descriptiontxt" runat="server" TextMode="MultiLine" style="width:170px; height:50px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="descriptiontxt" ErrorMessage="Please supply product description" style="display:none" ></asp:RequiredFieldValidator>
         
            </div>
      <div class="one_half first"><p>Product photos:</p></div>
      <div class="one_half">
          <asp:FileUpload ID="productload1" runat="server" /></div>
            <div class="one_half first"><p><br /></p></div>
            <div class="one_half" >
            <asp:FileUpload ID="productload2" runat="server" /></div>
           
             <div class="one_half first"><p><br /></p></div><div class="one_half">
            <asp:FileUpload ID="productload3" runat="server" /></div>
            
          <div class="one_half first"><p><br /></p></div>
            <div class="one_half">
            <asp:FileUpload ID="productload4" runat="server" /></div>
            <div class="one_half first"><p><br /></p></div>
         <div class="one_half">
             <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" />
    </div>
            <div class="one_half first">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" style="color:red"/>
            </div>
            </div>
        </div>
            </div>

</asp:Content>

