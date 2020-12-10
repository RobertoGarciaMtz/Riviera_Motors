// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function obtMarca(select) {
    var idMarca = select.value;
    ajax({
        url: "TbCarros/RecuperarMarca",
        method: "POST"
    });
}

function marcaChanged(select) {
    var idSelected = select.value;
    $.ajax({
        url: "/TbCarros/RecuperarModelo1",
        method: "POST",
        data: { "id": idSelected },
        success: function (e) {
            let selectModelo = document.getElementById("IdModelo");
            let html = "";
            for (var i = 0; i < e.length; i++) {
                html += "<option value ='" + e[i].idModeloCarro + "' >" + e[i].modeloCarro + "</option>";
            }
            selectModelo.innerHTML = html;
        }
    });
}


function modeloChange(select) {
    var idSelect = select.value;
    $.ajax({
        url: "/TbCarros/RecuperarVersion1",
        method: "POST",
        data: { "id": idSelect },
        success: function (f) {
            let selectModelo2 = document.getElementById("IdVersionn");
            let html = "";
            for (var i = 0; i < f.length; i++) {
                html += "<option value='" + f[i].idVersionCarro + "' >" + f[i].VersionCarro + "</option>";
            }
            selectModelo2.innerHTML = html;
        }
    });
}


