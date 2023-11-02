using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Gerente
    {
        
        public int Id { get; set; }

        public int Mesa { get; set; }
        public string NombreMesero { get; set; }
        public int IdMesero { get; set; }
        public DateTime Fecha { get; set; }

        public List<Reportes> Informes {  get; set; }

    }
 

}
