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
    
    public partial class PublicacionRenta
    {
        public int IdPublicacionRenta { get; set; }
        public Nullable<System.DateTime> FechaRenta { get; set; }
        public int IdPublicacion { get; set; }
        public int IdRenta { get; set; }
    
        public virtual Publicacion Publicacion { get; set; }
        public virtual Renta Renta { get; set; }
    }
}
