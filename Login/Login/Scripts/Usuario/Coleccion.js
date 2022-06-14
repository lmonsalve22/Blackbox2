const removeAccents = (str) => {
    let salida = str.normalize("NFD").replace(/[\u0300-\u036f]/g, "").split(" ").join("").toLowerCase();
    return salida.replaceAll("(", "").replace(")", "").replace("/", "").replace(",", "").replace(".", "");
}
 //console.log(removeAccents("La uña se me rompió después de beber cachaça"))

function RenderEnlace(objeto) {
    //var clean = removeAccents(objeto);
    var salida = '<ul style="margin:0px !important;"><li style="disk; margin:0px !important;"><a class="enlaceFinal" href="/Data_Usuario/VisualizarGraficoColecion_Usuario?id=' + objeto.id + '"> ' + objeto.titulo + ' </a></li></ul><br />';
    return salida;
}
function RenderEnlaceEnfermedades_Mundiales(objeto) {
    //var clean = removeAccents(objeto);
    var salida = '<ul style="margin:0px !important;"><li style="disk; margin:0px !important;"><a class="enlaceFinal"  href="/Enfermedades_Mundiales/VisualizarGraficoColecion_Usuario?id=' + objeto.id + '"> ' + objeto.titulo + ' </a></li></ul><br />';
    return salida;
}
function RenderEnlaceINGRESO_HISTORICO(objeto) {
    //var clean = removeAccents(objeto);
    var salida = '<ul style="margin:0px !important;"><li style="disk; margin:0px !important;"><a class="enlaceFinal"  href="/INGRESO_HISTORICO/VisualizarGraficoColecion_Usuario?id=' + objeto.id + '"> ' + objeto.titulo + ' </a></li></ul><br />';
    return salida;
}
function RenderEnlaceECONOMIA(objeto) {
    //var clean = removeAccents(objeto);
    var salida = '<ul style="margin:0px !important;"><li style="disk; margin:0px !important;"><a class=" enlaceFinal"  href="/ECONOMIA/VisualizarGraficoColecion_Usuario?id=' + objeto.id + '"> ' + objeto.titulo + ' </a></li></ul><br />';
    return salida;
}
function RenderEnlaceAgencia_Informacion(objeto) {
    //var clean = removeAccents(objeto);
    var salida = '<ul style="margin:0px !important;"><li style="disk; margin:0px !important;"><a class="enlaceFinal"  href="/Agencia_Informacion/VisualizarGraficoColecion_Usuario?id=' + objeto.id + '"> ' + objeto.titulo + ' </a></li></ul><br />';
    return salida;
}
function RenderEnlaceAgricultura(objeto) {
    //var clean = removeAccents(objeto);
    var salida = '<ul style="margin:0px !important;"><li style="disk; margin:0px !important;"><a class="enlaceFinal"  href="/Agricultura/VisualizarGraficoColecion_Usuario?id=' + objeto.id + '"> ' + objeto.titulo + ' </a></li></ul><br />';
    return salida;
}
function RenderEnlaceViolencia(objeto) {
    //var clean = removeAccents(objeto);
    var salida = '<ul style="margin:0px !important;"><li style="disk; margin:0px !important;"><a class="enlaceFinal"  href="/Violencia_contra_la_mujer/VisualizarGraficoColecion_Usuario?id=' + objeto.id + '"> ' + objeto.titulo + ' </a></li></ul><br />';
    return salida;
}
function RenderEnlaceGlaciares_10(objeto) {
    //var clean = removeAccents(objeto);
    var salida = '<ul style="margin:0px !important;"><li style="disk; margin:0px !important;"><a class="enlaceFinal"  href="/Glaciares_10/Mapa2?id=' + objeto.id + '"> ' + objeto.titulo + ' </a></li></ul><br />';
    return salida;
}
function RenderEnlaceIncendios(objeto) {
    //var clean = removeAccents(objeto);
    var salida = '<ul style="margin:0px !important;"><li style="disk; margin:0px !important;"><a class="enlaceFinal"  href="/Incendios/VisualizarGraficoColecion_Usuario?id=' + objeto.id + '"> ' + objeto.titulo + ' </a></li></ul><br />';
    return salida;
}
function RenderEnlaceMunicipio(objeto) {
    //var clean = removeAccents(objeto);
    var salida = '<ul style="margin:0px !important;"><li style="disk; margin:0px !important;"><a class="enlaceFinal"  href="/Municipio/VisualizarGraficoColecion_Usuario?id=' + objeto.id + '"> ' + objeto.titulo + ' </a></li></ul><br />';
    return salida;
}
function RenderEnlaceGobiernos_Regionales(objeto) {
    //var clean = removeAccents(objeto);
    var salida = '<ul style="margin:0px !important;"><li style="disk; margin:0px !important;"><a class="enlaceFinal"  href="/Region/VisualizarGraficoColecion_Usuario?id=' + objeto.id + '"> ' + objeto.titulo + ' </a></li></ul><br />';
    return salida;
}
function RenderEnlaceCiudades(objeto) {
    //var clean = removeAccents(objeto);
    var salida = '<ul style="margin:0px !important;"><li style="disk; margin:0px !important;"><a class="enlaceFinal"  href="/Ciudades/VisualizarGraficoColecion_Usuario?id=' + objeto.id + '"> ' + objeto.titulo + ' </a></li></ul><br />';
    return salida;
}
function RenderEnlaceEducación_Básica_Media(objeto) {
    //var clean = removeAccents(objeto);
    var salida = '<ul style="margin:0px !important;"><li style="disk; margin:0px !important;"><a class="enlaceFinal"  href="/Educación_Básica_Media/VisualizarGraficoColecion_Usuario?id=' + objeto.id + '"> ' + objeto.titulo + ' </a></li></ul><br />';
    return salida;
}
function RenderCard(concepto, padre, nRenders, show = '') {
    var salida = '<div class="card">'
    salida = salida + RenderCardHeader(concepto) + RenderCollapse(concepto, padre, nRenders, show)
    salida = salida + '</div>'
    return salida;
}

function RenderCardHeader(concepto) {
    var clean = removeAccents(concepto);
    var salida = '<div class="card-header" id="h-' + clean + '">' +
        '<h6 class="mb-0">' +
        '<a role="button" data-toggle="collapse" href="#' + clean + '" aria-controls="' + clean + '">' +
        concepto +
        '</a>' +
        '</h6>' +
        '</div>';
    return salida;
}

function RenderCollapse(concepto, padre, nRenders, show) {
    var clean = removeAccents(concepto);
    padre = removeAccents(padre);
    var salida = '<div id="' + clean + '" class="collapse ' + show + '" data-parent="#a-' + padre + '" aria-labelledby="h-' + clean + '">' +
        '<div class="card-body">' +
        '<div id="a-' + clean + '">'
    salida = salida + nRenders // + n veces RenderCard(concepto)
    //lista.forEach(element => salida = salida + RenderCard(element));
    salida = salida + '</div></div></div>';
    return salida;
}
const reducer = (accumulator, currentValue) => accumulator + currentValue.territorio;
const reducer2 = (accumulator, currentValue) => accumulator + currentValue;

function RenderPrincipal(raw, contenido) {
    datos = JSON.parse(raw);
    var temas = datos.map(function (x) {
        return removeAccents(x.tema);
    });
    var temasUnico = new Set(temas);
    //console.log(temasUnico);
    temasUnico = [...temasUnico];
    var htmlTema = "";
    for (var i = 0; i < temasUnico.length; i++) {
        var filtroTemas = datos.filter(x => x.tema == temasUnico[i])
        var escalas = filtroTemas.map(function (x) {
            return removeAccents(x.escala);
        });
        var escalasUnico = new Set(escalas);
        escalasUnico = [...escalasUnico];
        var htmlEscala = "";
        for (var k = 0; k < escalasUnico.length; k++) {
            var filtroEscala = filtroTemas.filter(x => x.escala == escalasUnico[k])
            //var territorios = filtroTemas.map(function (x) {
            var territorios = filtroEscala.map(function (x) {
                return removeAccents(x.territorio);
            });
            var territoriosUnico = new Set(territorios);
            territoriosUnico = [...territoriosUnico];
            var htmlTerritorio = ""
            for (var l = 0; l < territoriosUnico.length; l++) {
                //var filtroTerritorio = filtroTemas.filter(x => x.territorio == territoriosUnico[l])
                var filtroTerritorio = filtroEscala.filter(x => x.territorio == territoriosUnico[l])
                if (filtroTerritorio.length > 0) {
                    var htmlEnlace = filtroTerritorio.map(RenderEnlace).reduce(reducer2, "")
                    var htmlTerritorio = htmlTerritorio + RenderCard(territoriosUnico[l], escalasUnico[k], htmlEnlace);
                }

            }
            htmlEscala = htmlEscala + RenderCard(escalasUnico[k], temasUnico[i], htmlTerritorio);
        }
        htmlTema = RenderCard(temasUnico[i], contenido, htmlEscala);
        $("#a-" + contenido).append(htmlTema)
    }
}

function RenderPrincipalEnfermedades_Mundiales(raw, contenido) {
    datos = raw; //JSON.parse(raw);
    var temas = datos.map(function (x) {
        return x.tema;
    });
    var temasUnico = new Set(temas);
    //console.log(temasUnico);
    temasUnico = [...temasUnico];
    var htmlTema = "";
    for (var i = 0; i < temasUnico.length; i++) {
        var filtroTemas = datos.filter(x => x.tema == temasUnico[i])
        var escalas = filtroTemas.map(function (x) {
            return x.escala;
        });
        var escalasUnico = new Set(escalas);
        escalasUnico = [...escalasUnico];
        var htmlEscala = "";
        for (var k = 0; k < escalasUnico.length; k++) {
            var filtroEscala = filtroTemas.filter(x => x.escala == escalasUnico[k])
            //var territorios = filtroTemas.map(function (x) {
            var territorios = filtroEscala.map(function (x) {
                return x.territorio;
            });
            var territoriosUnico = new Set(territorios);
            territoriosUnico = [...territoriosUnico];
            var htmlTerritorio = ""
            for (var l = 0; l < territoriosUnico.length; l++) {
                var filtroTerritorio = filtroEscala.filter(x => x.territorio == territoriosUnico[l])
                if (filtroTerritorio.length > 0) {
                    var htmlEnlace = filtroTerritorio.map(RenderEnlaceEnfermedades_Mundiales).reduce(reducer2, "")
                    var htmlTerritorio = htmlTerritorio + RenderCard(territoriosUnico[l], escalasUnico[k], htmlEnlace);
                }

            }
            htmlEscala = htmlEscala + RenderCard(escalasUnico[k], temasUnico[i], htmlTerritorio);
            //console.log(htmlEscala)
        }
        htmlTema = RenderCard(temasUnico[i], contenido, htmlEscala);
        $("#a-" + contenido).append(htmlTema)
    }
}

function RenderPrincipalAgencia_Informacion(raw, contenido) {
    datos = raw; //JSON.parse(raw);
    var temas = datos.map(function (x) {
        return x.tema;
    });
    var temasUnico = new Set(temas);
    //console.log(temasUnico);
    temasUnico = [...temasUnico];
    var htmlTema = "";
    for (var i = 0; i < temasUnico.length; i++) {
        var filtroTemas = datos.filter(x => x.tema == temasUnico[i])
        var escalas = filtroTemas.map(function (x) {
            return x.escala;
        });
        var escalasUnico = new Set(escalas);
        escalasUnico = [...escalasUnico];
        var htmlEscala = "";
        for (var k = 0; k < escalasUnico.length; k++) {
            var filtroEscala = filtroTemas.filter(x => x.escala == escalasUnico[k])
            //var territorios = filtroTemas.map(function (x) {
            var territorios = filtroEscala.map(function (x) {
                return x.territorio;
            });
            var territoriosUnico = new Set(territorios);
            territoriosUnico = [...territoriosUnico];
            var htmlTerritorio = ""
            for (var l = 0; l < territoriosUnico.length; l++) {
                var filtroTerritorio = filtroTemas.filter(x => x.territorio == territoriosUnico[l])
                if (filtroTerritorio.length > 0) {
                    var htmlEnlace = filtroTerritorio.map(RenderEnlaceAgencia_Informacion).reduce(reducer2, "")
                    var htmlTerritorio = htmlTerritorio + RenderCard(territoriosUnico[l], escalasUnico[k], htmlEnlace);
                }
            }
            htmlEscala = htmlEscala + RenderCard(escalasUnico[k], temasUnico[i], htmlTerritorio);
        }
        htmlTema = RenderCard(temasUnico[i], contenido, htmlEscala);
        $("#a-" + contenido).append(htmlTema)
    }
}
function RenderPrincipalECONOMIA(raw, contenido) {
    datos = raw; //JSON.parse(raw);
    var temas = datos.map(function (x) {
        return x.tema;
    });
    var temasUnico = new Set(temas);
    //console.log(temasUnico);
    temasUnico = [...temasUnico];
    var htmlTema = "";
    for (var i = 0; i < temasUnico.length; i++) {
        var filtroTemas = datos.filter(x => x.tema == temasUnico[i])
        var escalas = filtroTemas.map(function (x) {
            return x.escala;
        });
        var escalasUnico = new Set(escalas);
        escalasUnico = [...escalasUnico];
        var htmlEscala = "";
        for (var k = 0; k < escalasUnico.length; k++) {
            var filtroEscala = filtroTemas.filter(x => x.escala == escalasUnico[k])
            //var territorios = filtroTemas.map(function (x) {
            var territorios = filtroEscala.map(function (x) {
                return x.territorio;
            });
            var territoriosUnico = new Set(territorios);
            territoriosUnico = [...territoriosUnico];
            var htmlTerritorio = ""
            for (var l = 0; l < territoriosUnico.length; l++) {
                var filtroTerritorio = filtroTemas.filter(x => x.territorio == territoriosUnico[l])
                if (filtroTerritorio.length > 0) {
                    var htmlEnlace = filtroTerritorio.map(RenderEnlaceECONOMIA).reduce(reducer2, "")
                    var htmlTerritorio = htmlTerritorio + RenderCard(territoriosUnico[l], escalasUnico[k], htmlEnlace);
                }
            }
            htmlEscala = htmlEscala + RenderCard(escalasUnico[k], temasUnico[i], htmlTerritorio);
        }
        htmlTema = RenderCard(temasUnico[i], contenido, htmlEscala);
        $("#a-" + contenido).append(htmlTema)
    }
}
function RenderPrincipalINGRESO_HISTORICO(raw, contenido) {
    datos = raw; //JSON.parse(raw);
    var temas = datos.map(function (x) {
        return x.tema;
    });
    var temasUnico = new Set(temas);
    //console.log(temasUnico);
    temasUnico = [...temasUnico];
    var htmlTema = "";
    for (var i = 0; i < temasUnico.length; i++) {
        var filtroTemas = datos.filter(x => x.tema == temasUnico[i])
        var escalas = filtroTemas.map(function (x) {
            return x.escala;
        });
        var escalasUnico = new Set(escalas);
        escalasUnico = [...escalasUnico];
        var htmlEscala = "";
        for (var k = 0; k < escalasUnico.length; k++) {
            var filtroEscala = filtroTemas.filter(x => x.escala == escalasUnico[k])
            //var territorios = filtroTemas.map(function (x) {
            var territorios = filtroEscala.map(function (x) {
                return x.territorio;
            });
            var territoriosUnico = new Set(territorios);
            territoriosUnico = [...territoriosUnico];
            var htmlTerritorio = ""
            for (var l = 0; l < territoriosUnico.length; l++) {
                var filtroTerritorio = filtroTemas.filter(x => x.territorio == territoriosUnico[l])
                if (filtroTerritorio.length > 0) {
                    var htmlEnlace = filtroTerritorio.map(RenderEnlaceINGRESO_HISTORICO).reduce(reducer2, "")
                    var htmlTerritorio = htmlTerritorio + RenderCard(territoriosUnico[l], escalasUnico[k], htmlEnlace);
                }

            }
            htmlEscala = htmlEscala + RenderCard(escalasUnico[k], temasUnico[i], htmlTerritorio);
        }
        htmlTema = RenderCard(temasUnico[i], contenido, htmlEscala);
        $("#a-" + contenido).append(htmlTema)
    }
}

function RenderPrincipalAgricultura(raw, contenido) {
    datos = raw; //JSON.parse(raw);
    var temas = datos.map(function (x) {
        return x.tema;
    });
    var temasUnico = new Set(temas);
    //console.log(temasUnico);
    temasUnico = [...temasUnico];
    var htmlTema = "";
    for (var i = 0; i < temasUnico.length; i++) {
        var filtroTemas = datos.filter(x => x.tema == temasUnico[i])
        var escalas = filtroTemas.map(function (x) {
            return x.escala;
        });
        var escalasUnico = new Set(escalas);
        escalasUnico = [...escalasUnico];
        var htmlEscala = "";
        for (var k = 0; k < escalasUnico.length; k++) {
            var filtroEscala = filtroTemas.filter(x => x.escala == escalasUnico[k])
            //var territorios = filtroTemas.map(function (x) {
            var territorios = filtroEscala.map(function (x) {
                return x.territorio;
            });
            var territoriosUnico = new Set(territorios);
            territoriosUnico = [...territoriosUnico];
            var htmlTerritorio = ""
            for (var l = 0; l < territoriosUnico.length; l++) {
                var filtroTerritorio = filtroTemas.filter(x => x.territorio == territoriosUnico[l])
                if (filtroTerritorio.length > 0) {
                    var htmlEnlace = filtroTerritorio.map(RenderEnlaceAgricultura).reduce(reducer2, "")
                    var htmlTerritorio = htmlTerritorio + RenderCard(territoriosUnico[l], escalasUnico[k], htmlEnlace);
                }

            }
            htmlEscala = htmlEscala + RenderCard(escalasUnico[k], temasUnico[i], htmlTerritorio);
        }
        htmlTema = RenderCard(temasUnico[i], contenido, htmlEscala);
        $("#a-" + contenido).append(htmlTema)
    }
}


function RenderPrincipalGlaciares_10(raw, contenido) {
    datos = raw; //JSON.parse(raw);
    var temas = datos.map(function (x) {
        return x.tema;
    });
    var temasUnico = new Set(temas);
    //console.log(temasUnico);
    temasUnico = [...temasUnico];
    var htmlTema = "";
    for (var i = 0; i < temasUnico.length; i++) {
        var filtroTemas = datos.filter(x => x.tema == temasUnico[i])
        var escalas = filtroTemas.map(function (x) {
            return x.escala;
        });
        var escalasUnico = new Set(escalas);
        escalasUnico = [...escalasUnico];
        var htmlEscala = "";
        for (var k = 0; k < escalasUnico.length; k++) {
            var filtroEscala = filtroTemas.filter(x => x.escala == escalasUnico[k])
            //var territorios = filtroTemas.map(function (x) {
            var territorios = filtroEscala.map(function (x) {
                return x.territorio;
            });
            var territoriosUnico = new Set(territorios);
            territoriosUnico = [...territoriosUnico];
            var htmlTerritorio = ""
            for (var l = 0; l < territoriosUnico.length; l++) {
                var filtroTerritorio = filtroTemas.filter(x => x.territorio == territoriosUnico[l])
                if (filtroTerritorio.length > 0) {
                    var htmlEnlace = filtroTerritorio.map(RenderEnlaceGlaciares_10).reduce(reducer2, "")
                    var htmlTerritorio = htmlTerritorio + RenderCard(territoriosUnico[l], escalasUnico[k], htmlEnlace);
                }

            }
            htmlEscala = htmlEscala + RenderCard(escalasUnico[k], temasUnico[i], htmlTerritorio);
        }
        htmlTema = RenderCard(temasUnico[i], contenido, htmlEscala);
        $("#a-" + contenido).append(htmlTema)
    }
}

function RenderPrincipalViolencia(raw, contenido) {
    datos = raw; //JSON.parse(raw);
    var temas = datos.map(function (x) {
        return x.tema;
    });
    var temasUnico = new Set(temas);
    //console.log(temasUnico);
    temasUnico = [...temasUnico];
    var htmlTema = "";
    for (var i = 0; i < temasUnico.length; i++) {
        var filtroTemas = datos.filter(x => x.tema == temasUnico[i])
        var escalas = filtroTemas.map(function (x) {
            return x.escala;
        });
        var escalasUnico = new Set(escalas);
        escalasUnico = [...escalasUnico];
        var htmlEscala = "";
        for (var k = 0; k < escalasUnico.length; k++) {
            var filtroEscala = filtroTemas.filter(x => x.escala == escalasUnico[k])
            //var territorios = filtroTemas.map(function (x) {
            var territorios = filtroEscala.map(function (x) {
                return x.territorio;
            });
            var territoriosUnico = new Set(territorios);
            territoriosUnico = [...territoriosUnico];
            var htmlTerritorio = ""
            for (var l = 0; l < territoriosUnico.length; l++) {
                var filtroTerritorio = filtroTemas.filter(x => x.territorio == territoriosUnico[l])
                if (filtroTerritorio.length > 0) {
                    var htmlEnlace = filtroTerritorio.map(RenderEnlaceViolencia).reduce(reducer2, "")
                    var htmlTerritorio = htmlTerritorio + RenderCard(territoriosUnico[l], escalasUnico[k], htmlEnlace);
                }

            }
            htmlEscala = htmlEscala + RenderCard(escalasUnico[k], temasUnico[i], htmlTerritorio);
        }
        htmlTema = RenderCard(temasUnico[i], contenido, htmlEscala);
        $("#a-" + contenido).append(htmlTema)
    }
}
/*
function RenderPrincipalMunicipio(raw, contenido) {
    datos = raw; //JSON.parse(raw);
    var temas = datos.map(function (x) {
        return x.tema;
    });
    var temasUnico = new Set(temas);
    //console.log(temasUnico);
    temasUnico = [...temasUnico];
    var htmlTema = "";
    for (var i = 0; i < temasUnico.length; i++) {
        var filtroTemas = datos.filter(x => x.tema == temasUnico[i])
        var escalas = filtroTemas.map(function (x) {
            return x.escala;
        });
        var escalasUnico = new Set(escalas);
        escalasUnico = [...escalasUnico];
        var htmlEscala = "";
        for (var k = 0; k < escalasUnico.length; k++) {
            var filtroEscala = filtroTemas.filter(x => x.escala == escalasUnico[k])
            //var territorios = filtroTemas.map(function (x) {
            var territorios = filtroEscala.map(function (x) {
                return x.territorio;
            });
            var territoriosUnico = new Set(territorios);
            territoriosUnico = [...territoriosUnico];
            var htmlTerritorio = ""
            for (var l = 0; l < territoriosUnico.length; l++) {
                var filtroTerritorio = filtroTemas.filter(x => x.territorio == territoriosUnico[l])

                if (filtroTerritorio.length > 0) {
                    var htmlEnlace = filtroTerritorio.map(RenderEnlaceMunicipio).reduce(reducer2, "")
                    var htmlTerritorio = htmlTerritorio + RenderCard(territoriosUnico[l], escalasUnico[k], htmlEnlace);
                }
            }
            htmlEscala = htmlEscala + RenderCard(escalasUnico[k], temasUnico[i], htmlTerritorio);
        }
        htmlTema = RenderCard(temasUnico[i], contenido, htmlEscala);
        $("#a-" + contenido).append(htmlTema)
    }
}
*/

function RendexAuxEnlaceMunicipio(registro) {
    let result = '<ul style="margin:0px !important;"> \
                            <li style="disk; margin:0px !important;"> \
                                <a class="enlaceFinal" href="/Municipio/VisualizarGraficoColecion_Usuario?id=' + registro.id + '"> \
                                    ' + registro.titulo + ' \
                            </a> \
                            </li> \
                        </ul> \
                <br>';
    return result;

}

function RenderPrincipalMunicipio(raw, contenido) {
    datos = raw; //JSON.parse(raw);
    var temas = datos.map(function (x) {
        return x.tema;
    });
    var temasUnico = new Set(temas);
    //console.log(temasUnico);
    temasUnico = [...temasUnico];
    var htmlTema = "";
    for (var i = 0; i < temasUnico.length; i++) {
        let enlaces = datos.filter(x => x.tema == temasUnico[i]);
        console.log(temasUnico[i])
        console.log(enlaces)
        let htmlEnlaces = enlaces.map(RendexAuxEnlaceMunicipio).reduce(reducer2, "");
        let temaClean = removeAccents(temasUnico[i])
        htmlTema = '\
        <div id="a-contenido" style="font-size:0.9rem !important;"> \
            <div class="card" > \
                <div class="card-header" id="h-' + temaClean + '"> \
                    <h6 class="mb-0"> \
                        <a role="button" data-toggle="collapse" href="#' + temaClean + '" aria-controls="' + temaClean + '" aria-expanded="true"> \
                            ' + temasUnico[i] +' \
                    </a> \
                    </h6> \
                </div> \
                <div id="' + temaClean + '" class="collapse" data-parent="#a-contenido" aria-labelledby="h-' + temaClean + '" style=""> \
                    <div class="card-body"> \
                             ' + htmlEnlaces + '\
                            </div> \
                        </div> \
                    </div> \
                </div > \
                '
        $("#a-" + contenido).append(htmlTema)
    }
}
function RenderPrincipalGobiernosRegionales(raw, contenido) {
    datos = raw; //JSON.parse(raw);
    var temas = datos.map(function (x) {
        return x.tema;
    });
    var temasUnico = new Set(temas);
    //console.log(temasUnico);
    temasUnico = [...temasUnico];
    var htmlTema = "";
    for (var i = 0; i < temasUnico.length; i++) {
        var filtroTemas = datos.filter(x => x.tema == temasUnico[i])
        var escalas = filtroTemas.map(function (x) {
            return x.escala;
        });
        var escalasUnico = new Set(escalas);
        escalasUnico = [...escalasUnico];
        var htmlEscala = "";
        for (var k = 0; k < escalasUnico.length; k++) {
            var filtroEscala = filtroTemas.filter(x => x.escala == escalasUnico[k])
            //var territorios = filtroTemas.map(function (x) {
            var territorios = filtroEscala.map(function (x) {
                return x.territorio;
            });
            var territoriosUnico = new Set(territorios);
            territoriosUnico = [...territoriosUnico];
            var htmlTerritorio = ""
            for (var l = 0; l < territoriosUnico.length; l++) {
                var filtroTerritorio = filtroTemas.filter(x => x.territorio == territoriosUnico[l])

                if (filtroTerritorio.length > 0) {
                    var htmlEnlace = filtroTerritorio.map(RenderEnlaceGobiernos_Regionales).reduce(reducer2, "")
                    var htmlTerritorio = htmlTerritorio + RenderCard(territoriosUnico[l], escalasUnico[k], htmlEnlace);
                }
            }
            htmlEscala = htmlEscala + RenderCard(escalasUnico[k], temasUnico[i], htmlTerritorio);
        }
        htmlTema = RenderCard(temasUnico[i], contenido, htmlEscala);
        $("#a-" + contenido).append(htmlTema)
    }
}
function RenderPrincipalIncendios(raw, contenido) {
    datos = raw; //JSON.parse(raw);
    var temas = datos.map(function (x) {
        return x.tema;
    });
    var temasUnico = new Set(temas);
    //console.log(temasUnico);
    temasUnico = [...temasUnico];
    var htmlTema = "";
    for (var i = 0; i < temasUnico.length; i++) {
        var filtroTemas = datos.filter(x => x.tema == temasUnico[i])
        var escalas = filtroTemas.map(function (x) {
            return x.escala;
        });
        var escalasUnico = new Set(escalas);
        escalasUnico = [...escalasUnico];
        var htmlEscala = "";
        for (var k = 0; k < escalasUnico.length; k++) {
            var filtroEscala = filtroTemas.filter(x => x.escala == escalasUnico[k])
            //var territorios = filtroTemas.map(function (x) {
            var territorios = filtroEscala.map(function (x) {
                return x.territorio;
            });
            var territoriosUnico = new Set(territorios);
            territoriosUnico = [...territoriosUnico];
            var htmlTerritorio = ""
            for (var l = 0; l < territoriosUnico.length; l++) {
                var filtroTerritorio = filtroTemas.filter(x => x.territorio == territoriosUnico[l])

                if (filtroTerritorio.length > 0) {
                    var htmlEnlace = filtroTerritorio.map(RenderEnlaceIncendios).reduce(reducer2, "")
                    var htmlTerritorio = htmlTerritorio + RenderCard(territoriosUnico[l], escalasUnico[k], htmlEnlace);
                }
            }
            htmlEscala = htmlEscala + RenderCard(escalasUnico[k], temasUnico[i], htmlTerritorio);
        }
        htmlTema = RenderCard(temasUnico[i], contenido, htmlEscala);
        $("#a-" + contenido).append(htmlTema)
    }
}

function RenderPrincipalCiudades(raw, contenido) {
    datos = raw; //JSON.parse(raw);
    var temas = datos.map(function (x) {
        return x.tema;
    });
    var temasUnico = new Set(temas);
    //console.log(temasUnico);
    temasUnico = [...temasUnico];
    var htmlTema = "";
    for (var i = 0; i < temasUnico.length; i++) {
        var filtroTemas = datos.filter(x => x.tema == temasUnico[i])
        var escalas = filtroTemas.map(function (x) {
            return x.escala;
        });
        var escalasUnico = new Set(escalas);
        escalasUnico = [...escalasUnico];
        var htmlEscala = "";
        for (var k = 0; k < escalasUnico.length; k++) {
            var filtroEscala = filtroTemas.filter(x => x.escala == escalasUnico[k])
            //var territorios = filtroTemas.map(function (x) {
            var territorios = filtroEscala.map(function (x) {
                return x.territorio;
            });
            var territoriosUnico = new Set(territorios);
            territoriosUnico = [...territoriosUnico];
            var htmlTerritorio = ""
            for (var l = 0; l < territoriosUnico.length; l++) {
                var filtroTerritorio = filtroTemas.filter(x => x.territorio == territoriosUnico[l])

                if (filtroTerritorio.length > 0) {
                    var htmlEnlace = filtroTerritorio.map(RenderEnlaceCiudades).reduce(reducer2, "")
                    var htmlTerritorio = htmlTerritorio + RenderCard(territoriosUnico[l], escalasUnico[k], htmlEnlace);
                }
            }
            htmlEscala = htmlEscala + RenderCard(escalasUnico[k], temasUnico[i], htmlTerritorio);
        }
        htmlTema = RenderCard(temasUnico[i], contenido, htmlEscala);
        $("#a-" + contenido).append(htmlTema)
    }
}

function RenderPrincipalEducación_Básica_Media(raw, contenido) {
    datos = raw; //JSON.parse(raw);
    var temas = datos.map(function (x) {
        return x.tema;
    });
    var temasUnico = new Set(temas);
    //console.log(temasUnico);
    temasUnico = [...temasUnico];
    var htmlTema = "";
    for (var i = 0; i < temasUnico.length; i++) {
        var filtroTemas = datos.filter(x => x.tema == temasUnico[i])
        var escalas = filtroTemas.map(function (x) {
            return x.escala;
        });
        var escalasUnico = new Set(escalas);
        escalasUnico = [...escalasUnico];
        var htmlEscala = "";
        for (var k = 0; k < escalasUnico.length; k++) {
            var filtroEscala = filtroTemas.filter(x => x.escala == escalasUnico[k])
            //var territorios = filtroTemas.map(function (x) {
            var territorios = filtroEscala.map(function (x) {
                return x.territorio;
            });
            var territoriosUnico = new Set(territorios);
            territoriosUnico = [...territoriosUnico];
            var htmlTerritorio = ""
            for (var l = 0; l < territoriosUnico.length; l++) {
                var filtroTerritorio = filtroTemas.filter(x => x.territorio == territoriosUnico[l])

                if (filtroTerritorio.length > 0) {
                    var htmlEnlace = filtroTerritorio.map(RenderEnlaceEducación_Básica_Media).reduce(reducer2, "")
                    var htmlTerritorio = htmlTerritorio + RenderCard(territoriosUnico[l], escalasUnico[k], htmlEnlace);
                }
            }
            htmlEscala = htmlEscala + RenderCard(escalasUnico[k], temasUnico[i], htmlTerritorio);
        }
        htmlTema = RenderCard(temasUnico[i], contenido, htmlEscala);
        $("#a-" + contenido).append(htmlTema)
    }
}