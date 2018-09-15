using System;
using System.Collections.Generic;

namespace TpProgramacionMovil3.Models
{
    public class InvitacionPedidoGustoEmpanadaUsuario
    {
        public int IdInvitacionPedidoGustoEmpanadaUsuario { get; set; }
        public int IdPedido { get; set; }
        public int IdGustoEmpanada { get; set; }
        public int IdUsuario { get; set; }
        public int Cantidad { get; set; }
    
        public GustoEmpanada GustoEmpanada { get; set; }
        public Pedido Pedido { get; set; }
        public Usuario Usuario { get; set; }
    }
}
