<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/MasterPage.master" AutoEventWireup="true" CodeFile="Sell.aspx.cs" Inherits="Sell" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="wrapper row3">
        <div id="container">
            <div class="full_width clear">
                    <div class="one_half">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger alert-dismissable" role="alert"
                                HeaderText="Please correct the following:"/>
                        <asp:panel ID="divSuccess" runat="server" CssClass="alert alert-success alert-dismissable">
                            The product was saved succesfully
                        </asp:panel>             
                    </div>                
            </div>
            <div class="full_width clear">
                <div class="one_half first">
                    <div class="panel panel-default">
                        <div class="panel-heading">Post your product</div>
                        <div class="panel-body">
                            <div class="form-group"> 
                                <label>Product Name</label>
                                <asp:TextBox ID="producttxt" runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="producttxt" ErrorMessage="Please supply your product name" style="display:none"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group"> 
                                <label>Price</label>
                                <asp:TextBox ID="pricetxt" runat="server" style="width:100px" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="pricetxt" ErrorMessage="Set your price" style="display:none"></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group">
                                <label>Type</label>
                                <asp:DropDownList ID="typedbl" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="Women">Women</asp:ListItem>
                                        <asp:ListItem>Men</asp:ListItem>
                                        <asp:ListItem>Baby &amp; Kids</asp:ListItem>
                                        <asp:ListItem>Home</asp:ListItem>
                                        <asp:ListItem>Electronics</asp:ListItem>
                                </asp:DropDownList> 
                            </div>
                            <div class="form-group">
                                <label>Description</label>
                                <asp:TextBox ID="descriptiontxt" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="descriptiontxt" ErrorMessage="Please supply product description" style="display:none" ></asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group">
                                <label>Product pictures</label>
                                <asp:FileUpload ID="productload1" runat="server" />
                                <br />
                                <asp:FileUpload ID="productload2" runat="server" />
                                <br />
                                <asp:FileUpload ID="productload3" runat="server" />
                                <br />
                                <asp:FileUpload ID="productload4" runat="server" />
                            </div>
                            <div class="form-group">
                                <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="btn btn-sm btn-default" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="one_half">
                    &nbsp;
                </div>
            </div>
        </div>
    </div>
</asp:Content>

