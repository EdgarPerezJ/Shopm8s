<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/MasterPage.master" AutoEventWireup="true" CodeFile="ProductBidPage.aspx.cs" Inherits="ProductBidPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="scripts/modules/ProductDetail.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
        <div id="container">
            <div class="full_width clear"> 
                <asp:panel ID="divSuccess" runat="server" CssClass="alert alert-success alert-dismissable">
                    <asp:label ID="lblSuccess" runat="server"></asp:label>
                </asp:panel> 
                <asp:panel ID="divError" runat="server" CssClass="alert alert-danger alert-dismissable">
                    <asp:label ID="lblError" runat="server"></asp:label>
                </asp:panel>
            </div>
            <div class="full_width clear">              
                <div class="one_quarter first">
                    <div id="pictureOneDiv" style="display: block; cursor: pointer;" class="thumbnail">	
                        <asp:Image ID="imgPictureOne" runat="server" width="80px" Height="80px" CssClass="imgPictureOne" /> 
                    </div>
                    <div id="pictureTwoDiv" style="display: block; cursor: pointer;" class="thumbnail">
                        <asp:Image ID="imgPictureTwo" runat="server" width="80px" Height="80px" CssClass="imgPictureTwo" /> 
                    </div>
                    <div id="pictureThreeDiv" style="display: block; cursor: pointer;" class="thumbnail">
                        <asp:Image ID="imgPictureThree" runat="server" width="80px" Height="80px" CssClass="imgPictureThree" /> 
                    </div>
                    <div id="pictureFourDiv" style="display: block; cursor: pointer;" class="thumbnail">
                        <asp:Image ID="imgPictureFour" runat="server" width="80px" Height="80px" CssClass="imgPictureFour" /> 
                    </div>
                </div>                
                <div class="two_quarter">
                    <div id="mainPictureDiv" style="display: block" class="thumbnail">
                        <asp:Image ID="imgMainPicture" runat="server" width="400px" Height="400px" CssClass="imgPictureMain"/> 
                    </div>
                </div>
                <div class="one_quarter">     
                    <div class="panel panel-default">
                        <div class="panel-heading">Product details</div>
                        <div class="panel-body">                  
                            <div class="form-group">
                                <label>Product Name:</label>
                                <asp:label ID="lblProductName" runat="server"></asp:label>
                            </div>
                            <div class="form-group">
                                <label>Price:</label>
                                <asp:label ID="lblPrice" runat="server"></asp:label>
                            </div>
                            <div class="form-group">
                                <label>Description:</label>
                                <asp:label ID="lblDescription" runat="server"></asp:label>
                            </div>

                             <asp:panel runat="server" id="newbid" CssClass="form-group">
                                <label>Enter Your Bid:</label>
                                 <asp:TextBox ID="amounttxt" runat="server" style="width:100px; display:inline-block" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                <asp:Button ID="btnBid" runat="server" Text="Bid" CssClass="btn btn-sm btn-default" OnClick="btnBid_Click"/>
                            </asp:panel>

                            <asp:panel runat="server" id="modify" CssClass="form-group">
                                <label>Modify Your Bid:</label>
                                 <asp:TextBox ID="modifyamount" runat="server" style="width:100px; display:inline-block" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                <asp:Button ID="btnmodify" runat="server" Text="Bid" CssClass="btn btn-sm btn-default" OnClick="btnmodify_Click" />
                            </asp:panel>

                            <asp:panel runat="server" id="changebid" CssClass="form-group">
                                <label>Your bid was Rejected! Enter new bid:</label>
                                 <asp:TextBox ID="changeamount" runat="server" style="width:100px; display:inline-block" TextMode="Number" CssClass="form-control"></asp:TextBox>
                                <asp:Button ID="btnchange" runat="server" Text="Bid" CssClass="btn btn-sm btn-default"  />
                            </asp:panel>

                             <asp:panel runat="server" id="checkout" CssClass="form-group" >
                                <label>Your Bid was Accepted!</label>                               
                                <asp:Button ID="btnprocced" runat="server" Text="Procced to Checkout" CssClass="btn btn-sm btn-default" />
                            </asp:panel>
                                 
                            <asp:panel runat="server" id="Remove" CssClass="form-group" >
                                <label>This Product was Sold!</label>                               
                                <asp:Button ID="btnremove" runat="server" Text="Remove from Cart" CssClass="btn btn-sm btn-default" OnClick="btnremove_Click" />
                            </asp:panel>                            
                    </div> 
                </div>  
            </div>
        </div>
    </div>         
</asp:Content>

