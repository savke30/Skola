﻿$("#btnIzracunaj").click(function () {

    var data = {
        vrijednost: Number($("#txtVrijednost").val()),
        valutaID: Number($("#Valuta").val())
    };

    $.post("/Konverter/GetConvertedValue", data,
        function (result) {
            // you can access the response in here
            $("#prikaz").html(result);
        });

});