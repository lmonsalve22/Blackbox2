
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
    
public partial class TERRITORIO
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TERRITORIO()
    {

        this.GRAFICO = new HashSet<GRAFICO>();

        this.DATA_GRAFICO = new HashSet<DATA_GRAFICO>();

    }


    public int id { get; set; }

    public string nombre { get; set; }

    public string descripcion { get; set; }

    public string auxiliar { get; set; }

    public string iso_pais { get; set; }

    public string nivel_administrativo { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<GRAFICO> GRAFICO { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DATA_GRAFICO> DATA_GRAFICO { get; set; }

}

}
