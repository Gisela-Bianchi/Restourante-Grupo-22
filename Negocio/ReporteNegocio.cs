using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ReporteNegocio
    {
        public List<string> todosNumMesa()
        {
            AccesoDatos acc = new AccesoDatos();
            return acc.todosNumMesa();
        }
        public decimal recTotXMesa(int NumMesa)
        {
            AccesoDatos acc = new AccesoDatos();
            return acc.recTotXMesa(NumMesa);
        }
    }
 
}
