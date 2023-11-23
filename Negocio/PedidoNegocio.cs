using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class PedidoNegocio

    {
        public PedidoNegocio() { }

        public bool CrearPedido(int NumMesa)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            return accesoDatos.CrearPedido(NumMesa);
        }

        public int ultimoNumPedido()
        {
            AccesoDatos accesodatos = new AccesoDatos();
            return accesodatos.ultimoNumPedido();
        }

        public int BuscarIdInsumo(string NombreInsumo)
        {

            AccesoDatos acc = new AccesoDatos();
            return acc.BuscarIdInsumo(NombreInsumo);

        }

        public bool ingresarInsumoXPedido(PedidosXInsumo reg)
        {
            AccesoDatos acc = new AccesoDatos();
            return acc.ingresarInsumoXPedido(reg);
        }
    }
}