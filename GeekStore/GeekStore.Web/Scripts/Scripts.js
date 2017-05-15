$(document).ready(function () {
    $('#btnClear').click(function () {
        var elements = document.getElementsByTagName("input");
        for (var ii = 0; ii < elements.length; ii++) {
            if (elements[ii].type == "text" || elements[ii].type == "password") {
                elements[ii].value = "";
            }
        }
    });
});