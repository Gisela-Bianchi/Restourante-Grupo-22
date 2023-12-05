using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mesero
    {
        public int IdMesero { get; set; }
        public int IdUsuario { get; set; }
        public int DNI { get; set; }
        public string NombreMesero { get; set; }
        public string ApellidoMesero { get; set; }
        public List<int> MesasAsignadas { get; set; }
        public Mesero()
        {

            MesasAsignadas = new List<int>();
        }

    }
}