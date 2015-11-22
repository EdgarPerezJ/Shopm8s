<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/MasterPage.master"  enableEventValidation="false" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="full_width clear"> 
        <asp:panel ID="divSuccess" runat="server" CssClass="alert alert-success alert-dismissable">
            The product was added to your cart
        </asp:panel> 
        <asp:panel ID="divError" runat="server" CssClass="alert alert-danger alert-dismissable">
            You already have this product
        </asp:panel>
    </div>
    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
        <ItemTemplate >           
                <div style="display: inline-block; margin-left: 50px; margin-bottom:10px; margin-top:10px; border: 1px solid #ddd; border-radius: 5px; padding:10px ">
                  <asp:ImageButton  ID="productimg" runat="server" ImageUrl='<%# Eval("photo1") %>' data-holder-rendered="true" style="height: 200px; width: 200px; display: block;"  OnCommand="Image_Click" CommandName="ImageClick" CommandArgument='<%# Eval("productid") %>' />
                  <div class="caption">
                    <p>Name: <asp:Label ID="namelbl" runat="server" Text='<%# Eval("name") %>' ></asp:Label></p>
                    <p>Price: <asp:Label ID="pricelbl" runat="server" Text='<%# Eval("price") %>' ></asp:Label> </p>
                    <p> 
                        <asp:LinkButton CommandName="AddCart"  runat="server" Text="Add to Cart" CssClass="btn btn-sm btn-primary" CommandArgument='<%# Eval("productid") %>'  />                      

                        <asp:LinkButton CommandName="view"  runat="server" CssClass="btn btn-sm btn-default" CommandArgument='<%# Eval("productid") %>' text="View" />
                    </p>
                  </div>
                </div>            
        </ItemTemplate>
    </asp:Repeater>
    <asp:HiddenField ID="hfProductID" runat="server"  />
</asp:Content>

