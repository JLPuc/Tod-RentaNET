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
    
    public partial class Sancion
    {
        public int IdSancion { get; set; }
        public string Motivo { get; set; }
        public int Periodo { get; set; }
        public System.DateTime FechaSancion { get; set; }
        public int IdUsuario { get; set; }
        public int IdAdministrador { get; set; }
    
        public virtual Administrador Administrador { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
