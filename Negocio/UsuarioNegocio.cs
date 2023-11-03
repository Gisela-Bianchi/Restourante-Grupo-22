using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public bool Loguear(Usuario usuario)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            return accesoDatos.Loguear(usuario);//lo q nos devuelva la funcion lo retornamos 
        }

    }
}
