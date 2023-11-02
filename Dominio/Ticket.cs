using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ticket
    { public int NumeroPedido {  get; set; }
      public Mesero IdMesero{  get; set; }
      public Mesa NumeroMesa{ get; set; }
      public DateTime Fecha{  get; set; }

      public List<Insumo> Insumos;
      public decimal Total {  get; set; }
      public bool Facturado {  get; set; }

    }
}
