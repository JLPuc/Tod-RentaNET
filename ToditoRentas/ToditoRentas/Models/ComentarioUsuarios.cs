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
    
    public partial class ComentarioUsuarios
    {
        public int IdComentarioUsuarios { get; set; }
        public string ComentarioUsuario { get; set; }
        public int IdComentador { get; set; }
        public int IdUsuario { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}
