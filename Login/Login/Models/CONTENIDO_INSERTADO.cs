//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONTENIDO_INSERTADO
    {
        public long id { get; set; }
        public string clave { get; set; }
        public string url { get; set; }
        public string comentario { get; set; }
        public string titulo { get; set; }
        public string medio_objetivo { get; set; }
        public string url_medio_objetivo { get; set; }
        public string coleccion { get; set; }
        public string servicio_base { get; set; }

        public string _comentario
        {
            set { _comentario = value; }
            get
            {
                if (comentario == null)
                {
                    return "https://forms.monday.com/forms/embed/1b0cdae45f7d2f680d5d8c0b508aac68?r=use1";
                }
                if (comentario == "")
                {
                    return "https://forms.monday.com/forms/embed/1b0cdae45f7d2f680d5d8c0b508aac68?r=use1";
                }
                try
                {
                    return comentario;
                }
                catch (Exception)
                {
                    return "https://forms.monday.com/forms/embed/1b0cdae45f7d2f680d5d8c0b508aac68?r=use1";
                }
            }
        }
    }
}
