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

        public int DNI { get; set; }
        public string NombreGerente { get; set; }
        public string ApellidoGerente { get; set; }


        public List<Reportes> Informes {  get; set; }

    }
 

}
