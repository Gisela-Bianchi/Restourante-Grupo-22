using System;
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

        public int TipoUsuario { get; set; }//**
        public bool Activo { get; set; }
    }
}
