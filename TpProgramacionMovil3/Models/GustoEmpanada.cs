using System;
using System.Collections.Generic;

namespace TpProgramacionMovil3.Models
{   
    public class GustoEmpanada
    {    
        public int IdGustoEmpanada { get; set; }
        public string Nombre { get; set; }
    
        public List<InvitacionPedidoGustoEmpanadaUsuario> InvitacionPedidoGustoEmpanadaUsuario { get; set; }
        public List<Pedido> Pedido { get; set; }

        public GustoEmpanada()
        {
            this.InvitacionPedidoGustoEmpanadaUsuario = new List<InvitacionPedidoGustoEmpanadaUsuario>();
            this.Pedido = new List<Pedido>();
        }
    }
}
