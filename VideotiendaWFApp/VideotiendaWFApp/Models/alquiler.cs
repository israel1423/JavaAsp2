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
    
    public partial class alquiler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public alquiler()
        {
            this.alq_videojuegos = new HashSet<alq_videojuegos>();
        }
    
        public decimal ID_ALQUILER { get; set; }
        public System.DateTime FEC_ALQUILER { get; set; }
        public System.DateTime FEC_DEVOLUCION { get; set; }
        public decimal VLR_ALQUILER { get; set; }
        public Nullable<decimal> VLR_MULTAS { get; set; }
        public Nullable<decimal> NRO_DOC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alq_videojuegos> alq_videojuegos { get; set; }
        public virtual personas personas { get; set; }
    }
}
