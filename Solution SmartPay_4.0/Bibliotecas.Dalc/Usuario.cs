//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bibliotecas.Dalc
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Vehiculo = new HashSet<Vehiculo>();
            this.Viaje = new HashSet<Viaje>();
        }
    
        public string rut { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string contraseña { get; set; }
        public Nullable<double> saldo { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public string activo { get; set; }
    
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
        public virtual ICollection<Viaje> Viaje { get; set; }
    }
}
