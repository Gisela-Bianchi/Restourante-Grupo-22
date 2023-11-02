using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        public Mesa NumeroMesa { get; set; }
        public int NumeroServicio { get; set; }
        
        public DateTime HoraPedido {  get; set; }

        public List<Insumo> Insumos;
        public Bool EstadoDelPedido { get; set; }
        public string Comentarios { get; set; }

        public DateTime HoraCierre { get; set; }

    }
}
