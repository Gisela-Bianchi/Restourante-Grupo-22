using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Insumo
    {    
        public int Idinsumo { get; set; }
        public string NombreInsumo { get; set; }
        public decimal PrecioUnitario { get; set; }

        public int CantidadStock { get; set; }
        public TipoInsumo Categoria { get; set; }

        public int  IdCategoria_Insumo { get; set; } //Verificar con la base de datos porque tengo duda //ARII
       
        

    }
}
