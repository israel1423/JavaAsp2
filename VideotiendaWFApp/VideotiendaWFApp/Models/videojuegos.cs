//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideotiendaWFApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class videojuegos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public videojuegos()
        {
            this.alq_videojuegos = new HashSet<alq_videojuegos>();
            this.cat_videojuegos = new HashSet<cat_videojuegos>();
        }
    
        public decimal NRO_REFERENCIA { get; set; }
        public string NOM_VIDEOJUEGO { get; set; }
        public string IMG_VIDEOJUEGO { get; set; }
        public Nullable<decimal> ID_PROD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alq_videojuegos> alq_videojuegos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cat_videojuegos> cat_videojuegos { get; set; }
        public virtual productores productores { get; set; }
    }
}
