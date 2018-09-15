using System;
using System.Collections.Generic;

namespace TpProgramacionMovil3.Models
{   
    public class InvitacionPedido
    {
        public int IdInvitacionPedido { get; set; }
        public int IdPedido { get; set; }
        public int IdUsuario { get; set; }
        public System.Guid Token { get; set; }
        public bool Completado { get; set; }
    
        public Pedido Pedido { get; set; }
        public Usuario Usuario { get; set; }
    }
}
