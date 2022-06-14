//Funcion para filtrar Territorios a partir de Escala
$(document).ready(function () {
    //Se activa al hacer click sobre cualquier objeto con class "escala"
    $(".escala").on("click", function () {
        //se guarda el contenido de la escala seleccionado, por ejemplo "pais"
        var escalaTerritorial = $(this).val().toLowerCase();
        //Se guarda el estado del checkbox
        //true si esta marcado y false de lo contrario
        var checkTerritorio = $(this).prop("checked");
        $(".territorio").each(function () {
            //alert()
            var checkBox = $(this).find("input").val().toLowerCase();//$(this).find("label").find("input").val().toLowerCase();
            //console.log(checkBox);
            //$(this).hide();
            if (checkTerritorio) {
                if (!checkBox.includes(escalaTerritorial))
                    $(this).hide();
                //console.log("MAL")
                else
                    $(this).show();
            }
            else {
                $(this).show();
            }
        });
        $(this).show();
    });
});

//Funcion para filtrar TEMA a partir de CONTENIDO
$(document).ready(function () {
    //Se activa al hacer click sobre cualquier objeto con class "escala"
    $(".contenido").on("click", function () {
        //se guarda el contenido de la escala seleccionado, por ejemplo "pais"
        var escalaTerritorial = $(this).val().toLowerCase().split(" - ")[0];
        //Se guarda el estado del checkbox
        //true si esta marcado y false de lo contrario
        var checkTerritorio = $(this).prop("checked");
        $(".tema").each(function () {
            //alert()
            var checkBox = $(this).find("input").val().toLowerCase();//$(this).find("label").find("input").val().toLowerCase();
            //console.log(checkBox);
            //console.log(escalaTerritorial);
            //$(this).hide();
            if (checkTerritorio) {
                if (!checkBox.includes(escalaTerritorial))
                    $(this).hide();
                //console.log("MAL")
                else
                    $(this).show();
            }
            else {
                $(this).show();
            }
        });
        $(this).show();
    });
});

//Funcion para filtrar CONTENIDO a partir de SECTOR
$(document).ready(function () {
    //Se activa al hacer click sobre cualquier objeto con class "escala"
    $(".sector").on("click", function () {
        //se guarda el contenido de la escala seleccionado, por ejemplo "pais"
        var escalaTerritorial = $(this).val().toLowerCase().split(" - ")[0];
        //Se guarda el estado del checkbox
        //true si esta marcado y false de lo contrario
        var checkTerritorio = $(this).prop("checked");
        $(".contenido").each(function () {
            //alert()
            var checkBox = $(this).find("input").val().toLowerCase();//$(this).find("label").find("input").val().toLowerCase();
            //console.log(checkBox);
            //console.log(escalaTerritorial);
            //$(this).hide();
            if (checkTerritorio) {
                if (!checkBox.includes(escalaTerritorial))
                    $(this).hide();
                //console.log("MAL")
                else
                    $(this).show();
            }
            else {
                $(this).show();
            }
        });
        $(this).show();
    });
});

//Funcion para filtrar SECTOR a partir de COLECCION
$(document).ready(function () {
    //Se activa al hacer click sobre cualquier objeto con class "escala"
    $(".coleccion").on("click", function () {
        //se guarda el contenido de la escala seleccionado, por ejemplo "pais"
        var escalaTerritorial = $(this).val().toLowerCase();
        //Se guarda el estado del checkbox
        //true si esta marcado y false de lo contrario
        var checkTerritorio = $(this).prop("checked");
        $(".sector").each(function () {
            //alert()
            var checkBox = $(this).find("input").val().toLowerCase();//$(this).find("label").find("input").val().toLowerCase();
            //console.log(checkBox);
            //$(this).hide();
            if (checkTerritorio) {
                if (!checkBox.includes(escalaTerritorial))
                    $(this).hide();
                //console.log("MAL")
                else
                    $(this).show();
            }
            else {
                $(this).show();
            }
        });
        $(this).show();
    });
});


var contador = 0;
$(document).ready(function () {
    $(".name").on("click", function () {
        contador = 0;
        name_list = []
        $("#myTable tr").hide()
        var flag = 1;
        var conceptos = [];
        $("input:checkbox[name=name]:checked").each(function () {
            flag = 0;
            var value = $(this).val().toLowerCase().split(" - ")[0];
            console.log(value);
            if (!conceptos.includes(value))
                conceptos.push(value);
        });
        //Fin agregar
        if (flag == 1) {
            $("#myTable tr").show();
            $("#contar").text($("#myTable tr").length + " Resultados");
        } else {
            //Agregar
            const reducer = (accumulator, currentValue) => accumulator && currentValue;
            $("#myTable tr").filter(function () {
                var valor = $(this).text().toLowerCase();
                //alert(valor);
                var flags = conceptos.map(function (x) {
                    //alert($(this).text().toLowerCase());
                    return valor.indexOf(x) > -1
                });
                if (flags.reduce(reducer)) {
                    $(this).show();
                    contador++;
                }
            });
            /*color y textos de los filtros de resulatados de busqueda */
            if (contador == 0) {
                $('#contar').css({ 'color': 'red' });
                $("#contar").text(contador + " Resultados - Por favor seleccione una sola opción en cada sección de los filtros.");
            } else {
                $('#contar').css({ 'color': 'black' });
                $("#contar").text(contador + " Resultados");
            }
           /* $("#contar").text(contador + " Resultados");*/
        }
    });

});



var table = '#mytable'
$('#maxRows').on('change', function () {
    /*alert('Hola');*/
    $('.pagination').html('')
    var trnum = 0;
    var maxRows = parseInt($(this).val())
    var totalRows = $(table + ' tbody tr').length
    $(table + ' tr:gt(0)').each(function () {
        trnum++
        if (trnum > maxRows) {
            $(this).hide()
        }
        if (trnum <= maxRows) {
            $(this).show()
        }
    })
    if (totalRows > maxRows) {
        var pagenum = Math.ceil(totalRows / maxRows)
        for (var i = 1; i <= pagenum;) {
            $('.pagination').append('<li class="btn" data-page="' + i + '">\<span>' + i++ + '<span class="page-item  sr-only">(current)</span></span>\</li>').show()
        }
    }

    $('.pagination li:first-child').addClass('active')
    $('.pagination li').on('click', function () {
        var pageNum = $(this).attr('date-page')
        var trIndex = 0;
        $('.pagination li').removeClass('active')
        $(this).addClass('active')
        $(table + ' tr:gt(0)').each(function () {
            trIndex++
            if (trIndex > (maxRows * pageNum) || trIndex <= ((maxRows * pageNum) - maxRows)) {
                $(this).hide()
            } else {
                $(this).show()
            }

        })
    })
})

function FiltrarII() {
    $("#Informe_Interactivo").prop("checked", true);
    contador = 0;
    name_list = []
    $("#myTable tr").hide()
    var flag = 1
    $("input:checkbox[name=name]:checked").each(function () {
        flag = 0;
        var value = $(this).val().toLowerCase();
        $("#myTable tr").filter(function () {
            if ($(this).text().toLowerCase().indexOf(value) > -1) {
                $(this).show();
                contador++;
            }
        });
        $("#contar").text(contador + " Resultados");
    });
}
function FiltrarReporte360() {
    $("#Reporte_360").prop("checked", true);
    if ($("#Reporte_360").length == 0)
        $("#Informe_Interactivo").prop("checked", true);
    contador = 0;
    name_list = []
    $("#myTable tr").hide()
    var flag = 1
    $("input:checkbox[name=name]:checked").each(function () {
        flag = 0;
        var value = $(this).val().toLowerCase();
        $("#myTable tr").filter(function () {
            if ($(this).text().toLowerCase().indexOf(value) > -1) {
                $(this).show();
                contador++;
            }
        });
        $("#contar").text(contador + " Resultados");
        if ($("#Reporte_360").length == 0)
            $("#contar").text("No pudimos encontrar Reportes 360° pero aqui tienes " + contador + " Informes Interactivos");
    });
}
function ActivarCasilla(casilla) {
    miscasillas = document.getElementsByTagName('input'); //Rescatamos controles tipo Input
    $("#myTable tr").show();
    $("#contar").text($("#myTable tr").length + " Resultados");
    for (i = 0; i < miscasillas.length; i++) //Ejecutamos y recorremos los controles
    {
        if (miscasillas[i].type == "checkbox") // Ejecutamos si es una casilla de verificacion
        {
            miscasillas[i].checked = false;  //casilla.checked; // Si el input es CheckBox se aplica la funcion ActivarCasilla
        }
    }
    $(".territorio").each(function () {
        $(this).show();
    });
    $(".escala").each(function () {
        $(this).show();
    });
}

function RenderFiltro(lista, classDiv, esca_terri, conte) {
    var validador = [];
    lista.map(function (x) {
        //esca_terri = 1 escala
        //esca_terri = 2 territorio
        var escala = "";
        var territorio = "";
  
        if (esca_terri == 1) {
            escala = "escala"
            territorio = "territorio";
        }
        if (esca_terri == 2)
            territorio = "territorio";

        //TEMA - CONTENIDO
        if (esca_terri == 3) {
            escala = "contenido"
            territorio = "tema";
        }
        if (esca_terri == 4)
            territorio = "tema";

        ////CONTENIDO - SECTOR
        //if (conte == 5) {
        //    escala = "sector"
        //    territorio = "contenido";
        //}
        //if (conte == 3)
        //    territorio = "contenido";
        var textohtml = ""
        if (esca_terri == 4) {
            textohtml = x
        }
        else {
            textohtml = x.split("-")[0]
        }
        var html = "<label style='width: 100%;' class='" + territorio + "'>" +
            /*"<li style='color: #000; cursor: pointer;'><input type='checkbox' class='name " + escala + "' name='name' value='" + x + "'>" + x.split("-")[0]; + "</li>" +*/
            "<li style='color: #000; cursor: pointer;'><input type='checkbox' class='name " + escala + "' name='name' value='" + x + "'>" + textohtml; + "</li>" +
            "</label>";

        //// SECTOR Y CONTENIDO
        //var sector = "";
        //var contenido = "";
        //if (esca_terri == 5) {
        //    sector = "sector"
        //    contenido = "contenido";
        //}
        //if (esca_terri == 3)
        //    contenido = "contenido";
        //var html = "<label style='width: 100%;' class='" + contenido + "'>" +
        //    "<li style='color: #000; cursor: pointer;'><input type='checkbox' class='name " + sector + "' name='name' value='" + x + "'>" + x.split("-")[0]; + "</li>" +
        //        "</label>";
        //if (validador.indexOf(x.split("-")[0]) == -1) {
        //    $(classDiv).append(html);
        //    validador.push(x.split("-")[0])
        //}
        $(classDiv).append(html);
        
    });
}


function MostrarFiltros(raw) {
    var data = JSON.parse(raw);
    var listaColeccion = [... new Set(data.map(x => x.coleccion.replaceAll("-", "")))];
    var listaSector = [... new Set(data.map(x => x.sector.replaceAll("-", "")))];
    var listaEscala = [... new Set(data.map(x => x.escala.replaceAll("-", "")))];
    var listaTerritorio = [... new Set(data.map(x => x.territorio.replaceAll("-", "") + " - " + x.escala.replaceAll("-", "")))];
    var listaTema = [... new Set(data.map(x => x.tema.replaceAll("-", "")))];
    /*var listaDetalle = [... new Set(data.map(x => x.unidad_medida))];*/
    var listaDetalle = [... new Set(data.map(x => x.muestra_temporalidad.replaceAll("-", "")))];
    var listaContenido = [... new Set(data.map(x => x.contenido.replaceAll("-", "")))];
    
    RenderFiltro(listaColeccion.sort(),  ".pageSubmenu1");
    RenderFiltro(listaSector.sort(),     ".pageSubmenu2");
    RenderFiltro(listaEscala.sort(),     ".pageSubmenu6", 1);
    RenderFiltro(listaTema.sort(),       ".pageSubmenu3");
    RenderFiltro(listaContenido.sort(),  ".pageSubmenu4");
    RenderFiltro(listaTerritorio.sort(), ".pageSubmenu7", 2);
    RenderFiltro(listaDetalle.sort(),    ".pageSubmenu8");
}

function MostrarFiltros2(raw) {
    var data = raw;//JSON.parse(raw);
    var listaColeccion = [... new Set(data.map(x => x.coleccion.replaceAll("-","")))];
    var listaSector = [... new Set(data.map(x => x.sector.replaceAll("-", "") + " - " + x.coleccion.replaceAll("-", "")))];
    var listaEscala = [... new Set(data.map(x => x.escala.replaceAll("-", "")))];
    var listaTerritorio = [... new Set(data.map(x => x.territorio.replaceAll("-", "") + " - " + x.escala.replaceAll("-", "")))];
    var listaTema = [... new Set(data.map(x => x.tema.replaceAll("-", "") + " - " + x.contenido.replaceAll("-", "")))];
    /*var listaDetalle = [... new Set(data.map(x => x.unidad_medida))];*/
    var listaDetalle = [... new Set(data.map(x => x.muestra_temporalidad.replaceAll("-", "")))];
    var listaContenido = [... new Set(data.map(x => x.contenido.replaceAll("-", "") + " - " + x.sector.replaceAll("-", "")))];

    //Escala 1  Territorio 2  Contenido 3,7  Tema 4  Sector  5  Coleccion 6
    RenderFiltro(listaColeccion.sort(), ".pageSubmenu1", 6);
    RenderFiltro(listaSector.sort(), ".pageSubmenu2", 5);
    RenderFiltro(listaEscala.sort(), ".pageSubmenu6", 1);
    RenderFiltro(listaTema.sort(), ".pageSubmenu3", 4);
    RenderFiltro(listaContenido.sort(), ".pageSubmenu4", 3);
    RenderFiltro(listaTerritorio.sort(), ".pageSubmenu7", 2);
    RenderFiltro(listaDetalle.sort(), ".pageSubmenu8");
}

