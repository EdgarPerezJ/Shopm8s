<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/MasterPage.master" AutoEventWireup="true" CodeFile="MyProducts.aspx.cs" Inherits="MyProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   
    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" >
        <ItemTemplate >           
                <div style="display: inline-block; margin-left: 50px; margin-bottom:10px; margin-top:10px; border: 1px solid #ddd; border-radius: 5px; padding:10px ">
                  <asp:ImageButton  ID="productimg" runat="server" ImageUrl='<%# Eval("photo1") %>' data-holder-rendered="true" style="height: 200px; width: 200px; display: block;"   CommandName="ImageClick" CommandArgument='<%# Eval("productid") %>' />
                  <div class="caption">
                    <p>Name: <asp:Label ID="namelbl" runat="server" Text='<%# Eval("name") %>' ></asp:Label></p>
                    <p>Price: <asp:Label ID="pricelbl" runat="server" Text='<%# Eval("price") %>' ></asp:Label> </p>
                    <p> 
                        <asp:LinkButton ID="LinkButton1" CommandName="viewbids"  runat="server" Text="View Bids" CssClass="btn btn-sm btn-primary" CommandArgument='<%# Eval("productid") %>'  />                      

                        <asp:LinkButton ID="LinkButton2" CommandName="Modify"  runat="server" text="Modify" CssClass="btn btn-sm btn-default" CommandArgument='<%# Eval("productid") %>' />
                    </p>
                  </div>
                </div>            
        </ItemTemplate>
    </asp:Repeater>
    <asp:HiddenField ID="hfProductID" runat="server"  />
</asp:Content>

