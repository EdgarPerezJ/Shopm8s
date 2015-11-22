jQuery(document).ready(function ($) {
    
    $.ajax({
        type: "POST",
        url: "Default.aspx/GetCurrentTime",
        data: '{name: "Edgar" }',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: OnSuccess,
        failure: function (response) {
            alert(response.d);
        }
    });

    function OnSuccess(response) {
        data = response.d;
        alert(data[0]._name);
    }
});