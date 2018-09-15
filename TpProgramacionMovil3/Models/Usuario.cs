using System;
using System.Collections.Generic;

namespace TpProgramacionMovil3.Models
{   
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    
        public virtual List<InvitacionPedido> InvitacionPedido { get; set; }
        public virtual List<InvitacionPedidoGustoEmpanadaUsuario> InvitacionPedidoGustoEmpanadaUsuario { get; set; }
        public virtual List<Pedido> Pedido { get; set; }

        public Usuario()
        {
            this.InvitacionPedido = new List<InvitacionPedido>();
            this.InvitacionPedidoGustoEmpanadaUsuario = new List<InvitacionPedidoGustoEmpanadaUsuario>();
            this.Pedido = new List<Pedido>();
        }
    }
}
