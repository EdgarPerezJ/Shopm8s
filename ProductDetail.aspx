<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/MasterPage.master" AutoEventWireup="true" CodeFile="ProductDetail.aspx.cs" Inherits="ProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="scripts/modules/ProductDetail.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
        <div id="container">
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
                    <asp:Button ID="btnAddCart" runat="server" Text="Add to Cart" CssClass="btn btn-sm btn-default" OnClick="btnAddCart_Click"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
