// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


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
    alert(idSelected);
    $.ajax({
        url: "/TbCarros/RecuperarVersion1",
        method: "POST",
        data: { "id": idSelected },
        success: function (e) {
            //alert("alert");
            alert("HOLA 2");
            let selectModelo = document.getElementById("IdVersion");
            let html = "";
            for (var i = 0; i < e.length; i++) {
                html += "<option value ='" + e[i].Id_Version_Carro + "' >" + e[i].Version_Carro + "</option>";
            }
            selectModelo.innerHTML = html;
        }
    });
}

function obtMMV(select) {
    alert("alert");
    var idSelected = select.value;
    $.ajax({
        url: "/CCarroExtra/ObtenerMMV",
        method: "POST",
        data: { "id": idSelected },
        success: function (e) {
            alert("alert");
            alert(e[i].Id_Version_Carro);
            let selectModelo = document.getElementById("regresaversion");
            let html = "";
                html = "<option value ='" + e[i].Id_Version_Carro + "' >" + e[i].Version_Carro + "</option>";
            selectModelo.innerHTML = html;
        }
    });
}

