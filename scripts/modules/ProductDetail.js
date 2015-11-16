
jQuery(document).ready(function ($) {

    $(".imgPictureOne").click(function () {
        var obj = $(".imgPictureOne");
        var src = obj.attr("src");
        var objTwo = $(".imgPictureMain");
        objTwo.attr("src", src); 
    });

    $(".imgPictureTwo").click(function () {
        var obj = $(".imgPictureTwo");
        var src = obj.attr("src");
        var objTwo = $(".imgPictureMain");
        objTwo.attr("src", src);
    });

    $(".imgPictureThree").click(function () {
        var obj = $(".imgPictureThree");
        var src = obj.attr("src");
        var objTwo = $(".imgPictureMain");
        objTwo.attr("src", src);
    });

    $(".imgPictureFour").click(function () {
        var obj = $(".imgPictureFour");
        var src = obj.attr("src");
        var objTwo = $(".imgPictureMain");
        objTwo.attr("src", src);
    });
       
});

