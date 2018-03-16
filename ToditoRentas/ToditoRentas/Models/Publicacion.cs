//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToditoRentas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Publicacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Publicacion()
        {
            this.PublicacionRenta = new HashSet<PublicacionRenta>();
        }
    
        public int IdPublicacion { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public string Status { get; set; }
        public int IdProducto { get; set; }
    
        public virtual Producto Producto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PublicacionRenta> PublicacionRenta { get; set; }
    }
}
