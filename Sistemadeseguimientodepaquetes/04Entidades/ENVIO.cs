//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _04Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class ENVIO
    {
        public ENVIO()
        {
            this.PEDIDOS = new HashSet<PEDIDO>();
        }
    
        public int IDENVIO { get; set; }
        public string DESC_ENVIO { get; set; }
    
        public virtual ICollection<PEDIDO> PEDIDOS { get; set; }
    }
}