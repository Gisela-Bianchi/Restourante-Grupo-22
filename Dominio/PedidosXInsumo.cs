using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class PedidosXInsumo
    {
       public Pedido NumeroPedido { get; set; }
        public Insumo IdInsumo { get; set; }
        public int CantVendida { get; set; }    
        public decimal PrecioUnitario { get; set; }
    }
}
