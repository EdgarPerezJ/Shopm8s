<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/MasterPage.master" AutoEventWireup="true" CodeFile="ProductDetail.aspx.cs" Inherits="ProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
        <div id="container">
            <div class="full_width clear">
                <h2>Product detail</h2>
                <div class="one_quarter first">One Quarter</div>
                <div class="one_quarter">
                    <div id="pictureOneDiv" style="display: block">
                        <asp:Image ID="imgPictureOne" runat="server" width="50px" Height="50px" /> 
                    </div>
                    <div id="pictureTwoDiv" style="display: block">
                        <asp:Image ID="imgPictureTwo" runat="server" width="50px" Height="50px" /> 
                    </div>
                    <div id="pictureThreeDiv" style="display: block">
                        <asp:Image ID="imgPictureThree" runat="server" width="50px" Height="50px" /> 
                    </div>
                    <div id="pictureFourDiv" style="display: block">
                        <asp:Image ID="imgPictureFour" runat="server" width="50px" Height="50px" /> 
                    </div>
                </div>                
                <div class="one_quarter">
                    <div id="mainPictureDiv" style="display: block">
                        <asp:Image ID="imgMainPicture" runat="server" width="200px" Height="300px" /> 
                    </div>
                </div>
                <div class="one_quarter">
                    Product Name:
                    <asp:label ID="lblProductName" runat="server"></asp:label>
                    </br>
                    Price:
                    <asp:label ID="lblPrice" runat="server"></asp:label>
                    </br>
                    Description:
                    <asp:label ID="lblDescription" runat="server"></asp:label>
                    </br>
                    <asp:Button ID="btnAddCart" runat="server" Text="Add to Cart"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
