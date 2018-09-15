using System;
using System.Collections.Generic;

namespace TpProgramacionMovil3.Models
{   
    public class EstadoPedido
    {    
        public int IdEstadoPedido { get; set; }
        public string Nombre { get; set; }
    
        public List<Pedido> Pedido { get; set; }

        public EstadoPedido()
        {
            this.Pedido = new List<Pedido>();
        }
    }
}
