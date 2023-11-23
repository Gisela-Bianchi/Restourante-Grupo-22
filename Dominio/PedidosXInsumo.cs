using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PedidosXInsumo
    {

       public Pedido NumeroPedido { get; set; }
        public Insumo IdInsumo { get; set; }
        public int CantVendida { get; set; }    
        public double PrecioUnitario { get; set; }

        public PedidosXInsumo() 
        {
            //NumeroPedido.NumeroPedido = 0;
        //     IdInsumo.Idinsumo = 0;
            CantVendida = 0;
            PrecioUnitario = 0;
        } 
    }
}
