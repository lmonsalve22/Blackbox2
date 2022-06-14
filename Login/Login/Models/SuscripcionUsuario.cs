using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Models
{
    public class SuscripcionUsuario
    {
        public List<Producto_Shopify> producto_Shopifies { get; set; }
        public List<suscripcionInterna> suscripciones { get; set; }
        public List<suscripcionInterna> SEMANARIOS { get; set; }

        public SuscripcionUsuario(string usuario)
        {
            List<Producto_Shopify> productos = new List<Producto_Shopify>();
            foreach (var item in APIShopify.BuscarOrdenesPorMail(usuario.ToLower()))
            {
                foreach (var item2 in item["line_items"])
                {
                    try
                    {
                        productos.Add(new Producto_Shopify(item2, (string)item["order_status_url"], item));
                    }
                    catch (Exception)
                    {
                        //string hola = "";
                    }
                }
            }
            this.producto_Shopifies = productos;
            this.suscripciones = new List<suscripcionInterna>();
            this.SEMANARIOS = new List<suscripcionInterna>();
            //foreach (var item in productos.Where(x => x.SKU != null))
            //foreach (var item in productos.Where(x => x.SKU != null && x.SKU.Contains("DATASUSCRIPCIONES2")))
            foreach (var item in productos.Where(x => x.SKU != null))
            {
                if (item.SKU.Contains("DATASUSCRIPCIONES2"))
                {
                    this.suscripciones.Add(new suscripcionInterna(item.SKU, item));
                }
                if (item.SKU.Contains("https://www.dataintelligence-group.com/data-educacion-ranking-comunal-de-establecimientos-educacionales-chile-comunas"))
                {
                    this.suscripciones.Add(new suscripcionInterna(item));
                }
                if (item.SKU.Contains("DATASEMANARIO"))
                {
                    this.SEMANARIOS.Add(new suscripcionInterna(item.SKU, 1));
                }
            }
            /*
            List<string> plataformas = new List<string>() {
                "https://training-dataintelligence.odoo.com/data-educacion-ranking-comunal-de-establecimientos-educacionales-chile-comunas"
            };
            foreach (var item in productos.Where(x => plataformas.Contains(x.SKU.Split('?')[0])))
            {
                this.suscripciones.Add(new suscripcionInterna(item));
            }
            */
        }

        public SuscripcionUsuario()
        {
            List<string> skus = new List<string> {
                "DATASUSCRIPCIONES2-D161_Region-14",
                "DATASUSCRIPCIONES2-D161_Region-12",
                
                "DATASUSCRIPCIONES2-D161_Municipio-10307","DATASUSCRIPCIONES2-D161_Municipio-7201",
                                                    "DATASUSCRIPCIONES2-D161_Region-5",
                                                        "DATASUSCRIPCIONES2-D161_Municipio-8109",
                                                            "DATASUSCRIPCIONES2-D161_PANORAMA_GASES-300",
                                                          "DATASUSCRIPCIONES2-D161_Municipio-12303",
                                                        "DATASUSCRIPCIONES2-D161_Municipio-9107",
                                                        "DATASUSCRIPCIONES2-D161_Municipio-4201",
                                                        "DATASUSCRIPCIONES2-D161_Municipio-6306",
                                                        "DATASUSCRIPCIONES2-D161_Municipio-16107",
                                                    "DATASUSCRIPCIONES2-D161_Municipio-8205",    
                                                    "DATASUSCRIPCIONES2-D161_Municipio-12303",
                                                    "DATASUSCRIPCIONES2-D161_Municipio-8202",
                                                    "DATASUSCRIPCIONES2-D161_Municipio-8302",
                                                    "DATASUSCRIPCIONES2-D161_Municipio-7104",
                                                    "DATASUSCRIPCIONES2-D161_Municipio-12301",
                                                    "DATASUSCRIPCIONES2-D161_EDUCACIONCOMUNAL-13101",
                                                    "DATASUSCRIPCIONES2-D161_EDUCACIONCOMUNAL-13119",
                                                    "DATASUSCRIPCIONES2-D161_EDUCACIONCOMUNAL-13120",
                                                    "DATASUSCRIPCIONES2-D161_EDUCACIONCOMUNAL-13114",
                                                    "DATASUSCRIPCIONES2-D161_EDUCACIONCOMUNAL-13132",
                                                    "DATASUSCRIPCIONES2-D161_Municipio-13115",
                                                    "DATASUSCRIPCIONES2-D161_Municipio-13119",
                                                    "DATASUSCRIPCIONES2-D161_Municipio-13120",
                                                    "DATASUSCRIPCIONES2-D990_AGENCIA_INFORMACION-300",
                                                    "DATASUSCRIPCIONES2-D100_AGRICULTURA-300",
                                                    "DATASUSCRIPCIONES2-D360_Enfermedades_Mundiales-300",
                                                    "DATASUSCRIPCIONES2-D140_ECONOMIA-300",
                                                    "DATASUSCRIPCIONES2-D261_GLACIARES_10-100-10",
                                                    "DATASUSCRIPCIONES2-D101_INCENDIOS-300",
                                                    "DATASUSCRIPCIONES2-D400_INGRESO_HISTORICO-300",
                                                    "DATASUSCRIPCIONES2-D300_VIOLENCIA_CONTRA_LA_MUJER-300",
                                                    "DATASUSCRIPCIONES2-D300_CIUDADES-300",
                                                    "DATASUSCRIPCIONES2-D161_EDUCACIONCOMUNAL-13101"
             };
            List<string> skus2 = new List<string>
            {
                //DATASEMANARIO-1-{PAGO/NO_PAGO}-{NOMBRE}-
                "DATASEMANARIO-1-PAGO-SEMANARIO_AGRO-",
                "DATASEMANARIO-1-PAGO-SEMANARIO_PROYECTOS-",
                "DATASEMANARIO-1-PAGO-SEMANARIO_GLACIARES-",
                "DATASEMANARIO-1-PAGO-SEMANARIO_PUNTOS_CALOR-",
                "DATASEMANARIO-1-NO_PAGO-SEMANARIO_GLACIARES-",
                "DATASEMANARIO-1-NO_PAGO-SEMANARIO_PUNTOS_CALOR-"
            };

            List<Producto_Shopify> productos = new List<Producto_Shopify>();
            this.producto_Shopifies = productos;
            this.suscripciones = new List<suscripcionInterna>();
            this.SEMANARIOS = new List<suscripcionInterna>();
            //Producto_Shopify padre = new Producto_Shopify();

            //padre.DIAS_DESDE_COMPRA = 0;
            foreach (var item in skus)
            {
                this.suscripciones.Add(new suscripcionInterna(item));
            }

            foreach (var item in skus2)
            {
                this.SEMANARIOS.Add(new suscripcionInterna(item,1));
            }
        }

        public SuscripcionUsuario(DateTime date)
        {
            List<string> skus = new List<string> {
                                                    "DATASUSCRIPCIONES2-D101_INCENDIOS-300",
                                                    "DATASUSCRIPCIONES2-D261_GLACIARES_10-100-10",
                                                    //"DATASUSCRIPCIONES2-D101_INCENDIOS-100-8",
                                                    "DATASUSCRIPCIONES2-D100_AGRICULTURA-100-7",
                                                    //"DATASUSCRIPCIONES2-D990_AGENCIA_INFORMACION-100-1",
                                                    "DATASUSCRIPCIONES2-D161_EDUCACIONCOMUNAL-13101",

                                                    //"DATASUSCRIPCIONES2-D161_Municipio-13115"
                                                    //"DATASUSCRIPCIONES2-D161_Municipio-12301"
                                                    //"DATASUSCRIPCIONES2-D161_EDUCACIONCOMUNAL-13101",
                                                    //"DATASUSCRIPCIONES2-D161_EDUCACIONCOMUNAL-13119",
                                                    //"DATASUSCRIPCIONES2-D161_EDUCACIONCOMUNAL-13120",
                                                    //"DATASUSCRIPCIONES2-D161_EDUCACIONCOMUNAL-13114",
                                                    //"DATASUSCRIPCIONES2-D161_EDUCACIONCOMUNAL-13132",

                                                    //"DATASUSCRIPCIONES2-D161_Municipio-13115",
                                                    //"DATASUSCRIPCIONES2-D161_Municipio-13119",
                                                    //"DATASUSCRIPCIONES2-D161_Municipio-13120",
                                                    //"DATASUSCRIPCIONES2-D990_AGENCIA_INFORMACION-300",
                                                    //"DATASUSCRIPCIONES2-D100_AGRICULTURA-300",
                                                    //"DATASUSCRIPCIONES2-D360_Enfermedades_Mundiales-300",
                                                    //"DATASUSCRIPCIONES2-D140_ECONOMIA-300",
                                                    //"DATASUSCRIPCIONES2-D261_GLACIARES_10-100-10",
                                                    //"DATASUSCRIPCIONES2-D101_INCENDIOS-300",
                                                    //"DATASUSCRIPCIONES2-D400_INGRESO_HISTORICO-300",
                                                    "DATASUSCRIPCIONES2-D300_VIOLENCIA_CONTRA_LA_MUJER-300",
                                                    //"DATASUSCRIPCIONES2-D300_CIUDADES-300",
                                                    //"DATASUSCRIPCIONES2-D161_EDUCACIONCOMUNAL-13101"
             };
            List<Producto_Shopify> productos = new List<Producto_Shopify>();
            this.producto_Shopifies = productos;
            this.suscripciones = new List<suscripcionInterna>();
            //Producto_Shopify padre = new Producto_Shopify();

            //padre.DIAS_DESDE_COMPRA = 0;
            foreach (var item in skus)
            {
                this.suscripciones.Add(new suscripcionInterna(item));
            }

            
        }


        public bool autorizacion(string coleccion)
        {
            return suscripciones.Select(x => x.nombre.ToLower()).Contains(coleccion.ToLower());
        }
    }



    public class suscripcionInterna
    {
        public Producto_Shopify producto_padre { get; set; }
        public string nombre { get; set; }
        public string imagen { get; set; }
        public string controlador { get; set; }
        public string nivel { get; set; }
        public string region { get; set; }
        public int filtro { get; set; }
        public string nombreNivel { get; set; }
        public string nombreRegion { get; set; }
        public string resultadoNivel { get; set; }
        public string resultadoRegion { get; set; }

        public suscripcionInterna()
        {
            resultadoNivel = "Prueba";
            resultadoRegion = "Sistema";
            filtro = 300;
        }

        public suscripcionInterna(string sku)
        {
            this.region = "0";
            List<string> ListaConceptos = sku.Split('-').ToList();
            this.nombre = ListaConceptos[1];
            this.controlador = this.nombre.Substring(5);
            this.imagen = "/Images/suscripciones/" + this.nombre + ".png";
            this.nivel = ListaConceptos[2];
            //this.resultadoNivel = "";
            //this.resultadoRegion = "";
            if (ListaConceptos.Count() > 3)
            {
                this.region = ListaConceptos[3];
            }
            this.filtro = int.Parse(this.nivel) + int.Parse(this.region);
            //Setear la variable nombreNivel
            //100 Regional 200 RM 300 Nacional
            //Setear la variable nombreRegion
            //1 ..  17 Nombres de la regiones
            switch (this.nivel)
            {
                case "100":
                    this.resultadoNivel = "Regional";
                    break;

                case "200":
                    this.resultadoNivel = "Región Metropolitana";
                    break;

                case "300":
                    this.resultadoNivel = "Nacional";
                    break;

                default:
                    this.resultadoNivel = "Colección";
                    break;
            }
            if(this.controlador == "Region")
            {
                this.region = this.nivel;
            }
            switch (this.region)
            {
                case "1":
                    this.resultadoRegion = "Tarapacá";
                    break;
                case "2":
                    this.resultadoRegion = "Antofagasta";
                    break;
                case "3":
                    this.resultadoRegion = "Atacama";
                    break;
                case "4":
                    this.resultadoRegion = "Coquimbo";
                    break;
                case "5":
                    this.resultadoRegion = "Valparaíso";
                    break;
                case "6":
                    this.resultadoRegion = "O'Higgins";
                    break;
                case "7":
                    this.resultadoRegion = "Maule";
                    break;
                case "8":
                    this.resultadoRegion = "Biobío";
                    break;
                case "9":
                    this.resultadoRegion = "La Araucanía";
                    break;
                case "10":
                    this.resultadoRegion = "Los Lagos";
                    break;
                case "11":
                    this.resultadoRegion = "Aysén";
                    break;
                case "12":
                    this.resultadoRegion = "Magallanes";
                    break;
                // El caso 13 Corresponde a la región metropolitana, que es otro nivel,
                // por lo que no se toma en cuenta.
                case "14":
                    resultadoRegion = "Los Ríos";
                    break;
                case "15":
                    resultadoRegion = "Arica y Parinacota";
                    break;
                case "16":
                    resultadoRegion = "Ñuble";
                    break;
                // Casos alternos:
                case "0":
                    this.resultadoRegion = "";
                    break;
                default:
                    this.resultadoRegion = "";
                    break;
            }

            if (this.filtro > 1000)
            {
                LOCALIZA lOCALIZA = new LOCALIZA();
                this.resultadoRegion = lOCALIZA.GetComuna(this.filtro);
            }
        }

        public suscripcionInterna(string sku, Producto_Shopify inside)
        {
            this.producto_padre = inside;
            this.region = "0";
            List<string> ListaConceptos = sku.Split('-').ToList();
            this.nombre = ListaConceptos[1];
            if (this.producto_padre.DIAS_DESDE_COMPRA > 31)
            {
                this.controlador = "TIMED_OUT";
            }
            else
            {
                this.controlador = this.nombre.Substring(5);
            }
            this.controlador = this.nombre.Substring(5);
            this.imagen = "/Images/suscripciones/" + this.nombre + ".png";
            this.nivel = ListaConceptos[2];
            //this.resultadoNivel = "";
            //this.resultadoRegion = "";
            if (ListaConceptos.Count() > 3)
            {
                this.region = ListaConceptos[3];
            }
            this.filtro = int.Parse(this.nivel) + int.Parse(this.region);
            //Setear la variable nombreNivel
            //100 Regional 200 RM 300 Nacional
            //Setear la variable nombreRegion
            //1 ..  17 Nombres de la regiones
            switch (this.nivel)
            {
                case "100":
                    this.resultadoNivel = "Regional";
                    break;

                case "200":
                    this.resultadoNivel = "Región Metropolitana";
                    break;

                case "300":
                    this.resultadoNivel = "Nacional";
                    break;

                default:
                    this.resultadoNivel = "Colección";
                    break;
            }
            if (this.controlador == "Region")
            {
                this.region = this.nivel;
            }
            switch (this.region)
            {
                case "1":
                    this.resultadoRegion = "Tarapacá";
                    break;
                case "2":
                    this.resultadoRegion = "Antofagasta";
                    break;
                case "3":
                    this.resultadoRegion = "Atacama";
                    break;
                case "4":
                    this.resultadoRegion = "Coquimbo";
                    break;
                case "5":
                    this.resultadoRegion = "Valparaíso";
                    break;
                case "6":
                    this.resultadoRegion = "O'Higgins";
                    break;
                case "7":
                    this.resultadoRegion = "Maule";
                    break;
                case "8":
                    this.resultadoRegion = "Biobío";
                    break;
                case "9":
                    this.resultadoRegion = "La Araucanía";
                    break;
                case "10":
                    this.resultadoRegion = "Los Lagos";
                    break;
                case "11":
                    this.resultadoRegion = "Aysén";
                    break;
                case "12":
                    this.resultadoRegion = "Magallanes";
                    break;
                // El caso 13 Corresponde a la región metropolitana, que es otro nivel,
                // por lo que no se toma en cuenta.
                case "14":
                    resultadoRegion = "Los Ríos";
                    break;
                case "15":
                    resultadoRegion = "Arica y Parinacota";
                    break;
                case "16":
                    resultadoRegion = "Ñuble";
                    break;
                // Casos alternos:
                case "0":
                    this.resultadoRegion = "";
                    break;
                default:
                    this.resultadoRegion = "";
                    break;
            }

            if(this.filtro > 1000)
            {
                LOCALIZA lOCALIZA = new LOCALIZA();
                this.resultadoRegion = lOCALIZA.GetComuna(this.filtro);
            }
        }

        public suscripcionInterna(Producto_Shopify inside)
        {
            if (inside.SKU.Contains("https://www.dataintelligence-group.com/data-educacion-ranking-comunal-de-establecimientos-educacionales-chile-comunas"))
            {
                this.producto_padre = inside;
                this.controlador = "EducacionComunal";
                this.imagen = inside.URL_IMAGEN;
                this.resultadoNivel = inside.NOMBRE.Split('-')[3];
            }
        }

        public suscripcionInterna(string sku, int codigoSemanario)
        {
            //"DATASEMANARIO-1-PAGO-SEMANARIO_AGRO-"
            this.region = "0";
            List<string> ListaConceptos = sku.Split('-').ToList();
            this.nombre = ListaConceptos[3];
            this.controlador = "SEMANARIO";
            
            this.nivel = ListaConceptos[2];
            this.imagen = "/Images/SEMANARIO/" + this.nombre + this.nivel + ".png";
            this.resultadoNivel = this.nombre.Replace('_', ' ');
            this.resultadoNivel = this.resultadoNivel.Substring(0, 1).ToUpper() + this.resultadoNivel.Substring(1).ToLower();
            if (this.nivel == "PAGO")
            {
                this.resultadoNivel = "";
            }
            else
            {
                this.resultadoNivel = "GRATUITO";
            }

            //this.resultadoNivel = "";
            //this.resultadoRegion = "";
            /*
            if (ListaConceptos.Count() > 3)
            {
                this.region = ListaConceptos[3];
            }
            this.filtro = int.Parse(this.nivel) + int.Parse(this.region);
            //Setear la variable nombreNivel
            //100 Regional 200 RM 300 Nacional
            //Setear la variable nombreRegion
            //1 ..  17 Nombres de la regiones
            switch (this.nivel)
            {
                case "100":
                    this.resultadoNivel = "Regional";
                    break;

                case "200":
                    this.resultadoNivel = "Región Metropolitana";
                    break;

                case "300":
                    this.resultadoNivel = "Nacional";
                    break;

                default:
                    this.resultadoNivel = "Colección";
                    break;
            }
            switch (this.region)
            {
                case "1":
                    this.resultadoRegion = "Tarapacá";
                    break;
                case "2":
                    this.resultadoRegion = "Antofagasta";
                    break;
                case "3":
                    this.resultadoRegion = "Atacama";
                    break;
                case "4":
                    this.resultadoRegion = "Coquimbo";
                    break;
                case "5":
                    this.resultadoRegion = "Valparaíso";
                    break;
                case "6":
                    this.resultadoRegion = "O'Higgins";
                    break;
                case "7":
                    this.resultadoRegion = "Maule";
                    break;
                case "8":
                    this.resultadoRegion = "Biobío";
                    break;
                case "9":
                    this.resultadoRegion = "La Araucanía";
                    break;
                case "10":
                    this.resultadoRegion = "Los Lagos";
                    break;
                case "11":
                    this.resultadoRegion = "Aysén";
                    break;
                case "12":
                    this.resultadoRegion = "Magallanes";
                    break;
                // El caso 13 Corresponde a la región metropolitana, que es otro nivel,
                // por lo que no se toma en cuenta.
                case "14":
                    resultadoRegion = "Los Ríos";
                    break;
                case "15":
                    resultadoRegion = "Arica y Parinacota";
                    break;
                case "16":
                    resultadoRegion = "Ñuble";
                    break;
                // Casos alternos:
                case "0":
                    this.resultadoRegion = "";
                    break;
                default:
                    this.resultadoRegion = "";
                    break;
            }

            if (this.filtro > 1000)
            {
                LOCALIZA lOCALIZA = new LOCALIZA();
                this.resultadoRegion = lOCALIZA.GetComuna(this.filtro);
            }
            */
        }

    }


    public class plataformaInterna{
        public Producto_Shopify producto_padre { get; set; }

        public plataformaInterna(Producto_Shopify p)
        {
            this.producto_padre = p;
        }

    }

}