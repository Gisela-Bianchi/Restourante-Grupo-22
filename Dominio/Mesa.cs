﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mesa
    {
        public int NumeroMesa { get; set; }
        public int  IdMesero_mesa { get; set; }
       
        public int Capacidad { get; set; }

        public bool Estado {  get; set; }

        public Mesero NombreMesero {  get; set; } 
    }
}
