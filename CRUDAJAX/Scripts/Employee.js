

$(document).ready(function () {
    loadData();

});

function loadData() {
    $.ajax({
        url: "/Home/List",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.Eid + '</td>';
                html += '<td>' + item.Ename + '</td>';
                html += '<td>' + item.EEmail + '</td>';
                html += '<td>' + item.EPassword + '</td>';
                html += '<td>' + item.EGender + '</td>';
                html += '<td><a href="#" onclick="return getbyID(' + item.Eid + ')" >Edit</a> | <a href="#" onclick="Delete(' + item.Eid + ')">Delete</a></td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function(errormessage) {
            alert(errormessage.responseText);
        }
    });   
}