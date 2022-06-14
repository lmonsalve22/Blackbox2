using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class ModelColeccion
    {
        public string tema { get; set; }
        public string escala { get; set; }
        public string territorio { get; set; }
        public string contenido { get; set; }
        public string id { get; set; }
        public string titulo { get; set; }

        public ModelColeccion(D101_INCENDIOS d101)
        {
            this.tema = d101.tema;
            this.escala = d101.escala;
            this.territorio = d101.territorio;
            this.contenido = d101.contenido;
            this.id = d101.id.ToString();
            this.titulo = d101.titulo;
        }
        public ModelColeccion()
        {
        }
    }
}