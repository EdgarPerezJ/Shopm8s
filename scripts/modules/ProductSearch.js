jQuery(document).ready(function ($) {
    var source = [];    

    $.ajax({
        type: "POST",
        url: "/Default.aspx/GetAllProduct",
        data: "{query: 'EDGAR' }",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            var elements = response.d;
            for (var i in elements) {
                var item = {'id': elements[i]._name, 'name': elements[i]._name};
                source.push(item);
            }
        }
    });

    $('#txtProductSearch').typeahead({
        source: source,
        onSelect: displayResult
    });


    function displayResult(item) {
        document.location.href = "/Default.aspx?name=" + item.value;
    }

    
    /*$("#txtProductSearch").typeahead({
        onSelect: function (item) {
            alert(item);
        },
        ajax: {
            url: "/Default.aspx/GetProductByNameMatch",
            timeout: 500,
            displayField: "title",
            triggerLength: 1,
            method: "post",
            loadingClass: "loading-circle",
            preDispatch: function (query) {
                return {
                    search: query
                }
            },
            preProcess: function (data) {
                alert(data);
                if (data.success === false) {
                    // Hide the list, there was some error
                    return false;
                }
                // We good!
                return data.mylist;
            }
        }
    });*/

});