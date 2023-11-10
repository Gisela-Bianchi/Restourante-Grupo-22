using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AsignacionesMesa
    {
        public int Id { get; set; }
        public Mesa NumeroMesa { get; set; }
        public int? NombreMesero { get; set; }
        public DateTime FechaAsignacion {  get; set; }
        public int  Idgerente { get; set; }

    }
}
