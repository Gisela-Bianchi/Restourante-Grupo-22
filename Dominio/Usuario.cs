﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int  Id {  get; set; }
        public string Usuarios { get; set;}
        public string Contraseña { get; set;}
        public string Email { get; set; }

        public string TipoUsuario { get; set; }
        public bool Activo { get; set; }
    }
}
