// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
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

        var idSelected = select.value;
        console.log(select)
        $.ajax({
            url: "/TbCarros/RecuperarVersion1",
            method: "POST",
            data: { "id": idSelected },
            success: function (z) {
                //alert("alert");
                alert("HOLA 2" + z.Version_Carro);
                let selectVersion = document.getElementById("IdVersion");
                let html = "";
                for (var i = 0; i < z.length; i++) {
                    html += "<option value ='" + z[i].Id_Version_Carro + "' >" + z[i].Version_Carro + "</option>";
                }
                selectVersion.innerHTML = html;
            }
        });
    }
})