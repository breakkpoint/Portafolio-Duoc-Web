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
    
    public partial class Peaje
    {
        public Peaje()
        {
            this.Viaje = new HashSet<Viaje>();
        }
    
        public string ruta { get; set; }
        public Nullable<decimal> precio { get; set; }
        public Nullable<int> cantPortico { get; set; }
        public Nullable<double> descuento { get; set; }
    
        public virtual ICollection<Viaje> Viaje { get; set; }
    }
}
