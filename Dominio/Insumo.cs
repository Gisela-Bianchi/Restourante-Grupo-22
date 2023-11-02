using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Insumo
    {    
        public string NombreInsumo { get; set; }
        public TipoInsumo Categoria { get; set; }
        public int CantidadStock { get; set; }
        public decimal PrecioUnitario {  get; set; }

    }
}
