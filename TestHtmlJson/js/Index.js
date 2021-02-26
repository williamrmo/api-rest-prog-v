var Index = Index || {}

Index.Function = (function () {

    var options = {};

    var initialize = function (otps) {
        $.extend(options, otps);
        cargarClientes();
    }

    function cargarClientes() {
        xmlhttp = new XMLHttpRequest();
        xmlhttp.onreadystatechange = obtenerClientes;
        xmlhttp.open("GET", "http://localhost/", true);
        xmlhttp.send();
    }

    var obtenerClientes = function (obj) {
        if (xmlhttp.readyState == XMLHttpRequest.DONE && xmlhttp.status == 200) {
            $.each(JSON.parse(xmlhttp.responseText), function (key, value) {
                $('#addNombres').append($('<option>').text(value.nombre).attr('value', value.ClientID));
            });
        }
    }

    return {
        Init: initialize
    }
})();
