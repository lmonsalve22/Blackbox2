using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class ListaGraficoPortada
    {
        public List<GraficoPortada> Graficos { get; set; }
        public List<GraficoPortada> GraficosMovil { get; set; }

        public ListaGraficoPortada()
        {
            Random rnd = new Random();
            Graficos = new List<GraficoPortada>();
            GraficosMovil = new List<GraficoPortada>(); 
            //Medias
            Graficos.Add(new GraficoPortada("https://analytics.zoho.com/open-view/2395394000007906094",
                                                "Emisiones Netas de CO2",
                                                "2017: el año que más contaminamos en Chile",
                                                "En 2017 alcanzamos 6.219 (kt) de emisiones y durante 1990 se observó la más baja con un promedio de emisión neta de -684 (kt)."));
            GraficosMovil.Add(new GraficoPortada("https://analytics.zoho.com/open-view/2395394000007906094",
                                                "Emisiones Netas de CO2",
                                                "2017: el año que más contaminamos en Chile",
                                                "En 2017 alcanzamos 6.219 (kt) de emisiones y durante 1990 se observó la más baja con un promedio de emisión neta de -684 (kt)."));

            //Sacar
            Graficos.Add(new GraficoPortada("https://infogram.com/delitos-2-1hdw2jp0zneyp2l?live",
                                                "Homicidios en Chile",
                                                "Desde 2016 existe un alza en la frecuencia de homicidios. ",
                                                "La región de Valparaíso lidera la variación interanual 2019-2020 con un 50%. ¿Qué región de Chile posee la tasa más baja? ¡Averígualo con nuestro gráfico!"));
            //Sacar
            Graficos.Add(new GraficoPortada("https://flo.uri.sh/visualisation/6691988/embed",
                                            "Solicitudes de Edificación",
                                            "2021: ¿Hay trabajo en la construcción?",
                                            "Comparando mayo con 2020 la superficie autorizada para edificaciones disminuyó, mientras que las ampliaciones aumentaron, indistintamente, si fue de uso habitacional o no."));
            //Sacar
            Graficos.Add(new GraficoPortada("https://infogram.com/volcan-osorno-1h7z2l8xmqkrx6o?live",
                                                "Volcán Osorno",
                                                "¿Sabes qué cambio hubo en el volcán Osorno?",
                                                "Generar Texto para Glaciar Volcán Osorno"));
            //sacar
            Graficos.Add(new GraficoPortada("https://app.powerbi.com/view?r=eyJrIjoiZmYzNzdjZDQtZGYyZS00MTVhLThmMDYtNjY2ZTA0YjIwOGM0IiwidCI6IjhmYmFhNWJmLTJlY2MtNGRjOC1iNTZiLThmOTJlMzA3ZjA3NiIsImMiOjR9",
                                            "Candidatos electos 1990-2026",
                                            "Revisa las comunas de Buin, Colina, La Florida, Maipú, Quinta Normal, Recoleta y San Ramón.",
                                            "Presentamos la lista completa de Alcaldes, Concejales, Diputados, Senadores y Consejeros Regionales por cada partido político."));
            //
            Graficos.Add(new GraficoPortada("https://app.powerbi.com/view?r=eyJrIjoiMTBhYjVkMTQtNDA3MC00ZmI5LTljZDMtM2Q3MTgyNGM3ZWYxIiwidCI6IjhmYmFhNWJmLTJlY2MtNGRjOC1iNTZiLThmOTJlMzA3ZjA3NiIsImMiOjR9",
                                             "Medición del Gobierno",
                                             "¡Sólo 6 ministerios lograron buen desempeño!",
                                             "Conozca cuáles son y otros resultados de desempeño por cada una de las 5 Línea de Evaluación y según cada Ministerio, Periodo 1997-2020."));

            Graficos.Add(new GraficoPortada("https://public.flourish.studio/visualisation/6688416/",
                                           "Evolución Parque Vehicular Escolar",
                                           "Ranking: regiones con mas furgones 2014-2021",
                                           "Este año el parque vehicular escolar registra 26.550 vehículos, lidera la región Metropolitana con 8.268, le sigue la región del Biobío con 2.974 vehículos."));
            GraficosMovil.Add(new GraficoPortada("https://public.flourish.studio/visualisation/6688416/",               
                                           "Evolución Parque Vehicular Escolar",
                                           "Ranking: regiones con mas furgones 2014-2021",
                                           "Este año el parque vehicular escolar registra 26.550 vehículos, lidera la región Metropolitana con 8.268, le sigue la región del Biobío con 2.974 vehículos."));

            Graficos.Add(new GraficoPortada("https://analytics.zoho.com/open-view/2395394000008434310",
                                           "Chile: Exportaciones acumuladas en USD",
                                           "China, EEUU, Japón y Brasil lideran",
                                           "¿No tienes curiosidad por saber cuáles son los países que compran nuestros productos? O por saber el que menos consume como Groenlandia. ¡Averigua!"));
            GraficosMovil.Add(new GraficoPortada("https://analytics.zoho.com/open-view/2395394000008434310",
                                           "Chile: Exportaciones acumuladas en USD",
                                           "China, EEUU, Japón y Brasil lideran",
                                           "¿No tienes curiosidad por saber cuáles son los países que compran nuestros productos? O por saber el que menos consume como Groenlandia. ¡Averigua!"));

            Graficos.Add(new GraficoPortada("https://analytics.zoho.com/open-view/2395394000008399250",
                                           "Pandemia a escala nacional",
                                           "Las comunas con más Casos Activos 2020-2021",
                                           "Puente Alto, Maipú, Santiago y Arica lideran los casos activos en Chile."));
            GraficosMovil.Add(new GraficoPortada("https://analytics.zoho.com/open-view/2395394000008399250",
                                           "Pandemia a escala nacional",
                                           "Las comunas con más Casos Activos 2020-2021",
                                           "Puente Alto, Maipú, Santiago y Arica lideran los casos activos en Chile."));

            Graficos.Add(new GraficoPortada("https://analytics.zoho.com/open-view/2395394000008416648",
                                           "Sin cambios en educación 2000-2020",
                                           "Se mantiene la brecha entre colegios Particulares, Municipales y Subvencionados",
                                           "Más allá de la gestión municipal, la proporción de alumnos con más de 450 puntos en la PSU no mejora."));
            GraficosMovil.Add(new GraficoPortada("https://analytics.zoho.com/open-view/2395394000008416648",
                                           "Sin cambios en educación 2000-2020",
                                           "Se mantiene la brecha entre colegios Particulares, Municipales y Subvencionados",
                                           "Más allá de la gestión municipal, la proporción de alumnos con más de 450 puntos en la PSU no mejora."));

            Graficos.Add(new GraficoPortada("https://analytics.zoho.com/open-view/2395394000008263358",
                                           "Víctimas de femicidios 2010-2020",
                                           "Todos los casos según las relaciones víctima y femicida.",
                                           "Presentamos la cantidad de casos comparadas donde las relaciones como conviviente, cónyuge, pareja y expareja lideran las cifras de muertes "));

            Graficos.Add(new GraficoPortada("https://infogram.com/dmcs-1h7j4dv717n0v4n?live",
                                           "Delitos de Mayor Connotación Social",
                                           "Chile: ¿cuántos delitos crees que se cometen al día o en 1 minuto?",
                                           "Si no te sorprende ese dato. ¡Revisa esta gráfica y conoce todas las cifras!"));
            GraficosMovil.Add(new GraficoPortada("https://infogram.com/dmcs-1h7j4dv717n0v4n?live",
                                           "Delitos de Mayor Connotación Social",
                                           "Chile: ¿cuántos delitos crees que se cometen al día o en 1 minuto?",
                                           "Si no te sorprende ese dato. ¡Revisa esta gráfica y conoce todas las cifras!"));

            Graficos.Add(new GraficoPortada("https://analytics.zoho.com/open-view/2395394000008257205?ZOHO_CRITERIA=%22Espacios_Culturales_Completo%201%22.%22C%C3%B3digo_Regi%C3%B3n%22%20=%2013",
                                           "Realidad Cultural en 2021",
                                           "¿Tiene espacio la cultura en tu comuna?",
                                           "Las comunas con más espacios culturales en la RM son Santiago y Providencia, con 104 y 51 espacios. ¡Revisa cómo está tu comuna!"));

            Graficos.Add(new GraficoPortada("https://analytics.zoho.com/open-view/2395394000007908748",
                                           "Evolución SIMCE de Lectura",
                                           "Según Dependencia de Establecimientos - 2° Medio",
                                           "En el SIMCE de Lectura para 2º medio los colegios particulares superan por 80 puntos a colegios municipales y subvencionados. ¡Vea la evolución hasta 2018!"));

            Graficos.Add(new GraficoPortada("https://analytics.zoho.com/open-view/2395394000007990413?ZOHO_CRITERIA=%22Localiza%20CL%22.%22Codreg%22=5",
                                           "Colegios de la Región de Valparaíso",
                                           "Desarrollo personal y social por colegios",
                                           "Hubo un descenso en 2019, todos los indicadores descendieron entre los 20 y 30 puntos según tipo de dependencia del establecimiento y establecimiento en particular."));
            
            Graficos = Graficos.OrderBy(x => rnd.Next()).Take(5).ToList();
            GraficosMovil.Add(new GraficoPortada("https://analytics.zoho.com/open-view/2395394000007906094",
                                                "Emisiones Netas de CO2",
                                                "2017: el año que más contaminamos en Chile",
                                                "En 2017 alcanzamos 6.219 (kt) de emisiones y durante 1990 se observó la más baja con un promedio de emisión neta de -684 (kt)."));
            GraficosMovil.Add(new GraficoPortada("https://analytics.zoho.com/open-view/2395394000007906094",
                                                "Emisiones Netas de CO2",
                                                "2017: el año que más contaminamos en Chile",
                                                "En 2017 alcanzamos 6.219 (kt) de emisiones y durante 1990 se observó la más baja con un promedio de emisión neta de -684 (kt)."));

            GraficosMovil = GraficosMovil.OrderBy(x => rnd.Next()).Take(2).ToList();
            //Graficos.Add(new GraficoPortada());

        }
    }
}