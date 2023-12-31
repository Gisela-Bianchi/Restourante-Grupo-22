﻿using System;
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
   


        /* public int PedidosDelDia()
         {
             AccesoDatos acc = new AccesoDatos();
             return acc.PedidosDelDia();
         }*/

        public List<int> NumerosPedidosDia()
        {
            AccesoDatos acc = new AccesoDatos();
            return acc.NumerosPedidosDia();
        }

        public List<Insumo> traerNombreInsumo(int numPedido)
        {
            AccesoDatos acc = new AccesoDatos();
            return acc.traerNombreInsumo(numPedido);
        }
        public int traeNumeroMesa(int numPedido)
        {
            AccesoDatos acc = new AccesoDatos();
            return acc.traeNumeroMesa(numPedido);
        }
        public DateTime traeHoraPedido(int numPedido)
        {
            AccesoDatos acc = new AccesoDatos();
            return acc.traeHoraPedido(numPedido);

        }
        public bool traeEstadoPedido(int numPedido)
        {
            AccesoDatos acc = new AccesoDatos();
            return acc.traeEstadoPedido(numPedido);

        }
        public bool ActualizarEstadoPedido(int numPedido, bool estado)
        {
            AccesoDatos acc = new AccesoDatos();
            return acc.ActualizarEstadoPedido(numPedido, estado);

        }
        public bool ActualizarFacturacion(int numPedido, bool estado)
        {
            AccesoDatos acc = new AccesoDatos();
            return acc.ActualizarFacturacion(numPedido, estado);

        }
        public bool TraerSiEstaFacturado(int numPedido)
        {
            AccesoDatos acc = new AccesoDatos();
            return acc.TraerSiEstaFacturado(numPedido);

        }
        public decimal TraerTotal(int numPedido)
        {
            AccesoDatos acc = new AccesoDatos();
            return acc.TraerTotal(numPedido);

        }

    }
}