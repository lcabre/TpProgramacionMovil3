using System;
using System.Collections.Generic;

namespace TpProgramacionMovil3.Models
{   
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdUsuarioResponsable { get; set; }
        public int IdEstadoPedido { get; set; }
        public string NombreNegocio { get; set; }
        public string Descripcion { get; set; }
        public int PrecioUnidad { get; set; }
        public int PrecioDocena { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Nullable<DateTime> FechaModificacion { get; set; }
    
        public EstadoPedido EstadoPedido { get; set; }
        public Usuario Usuario { get; set; }
        public List<InvitacionPedido> InvitacionPedido { get; set; }
        public List<InvitacionPedidoGustoEmpanadaUsuario> InvitacionPedidoGustoEmpanadaUsuario { get; set; }
        public List<GustoEmpanada> GustoEmpanada { get; set; }

        public Pedido()
        {
            this.InvitacionPedido = new List<InvitacionPedido>();
            this.InvitacionPedidoGustoEmpanadaUsuario = new List<InvitacionPedidoGustoEmpanadaUsuario>();
            this.GustoEmpanada = new List<GustoEmpanada>();
        }
    }
}
