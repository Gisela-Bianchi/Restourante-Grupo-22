using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Negocio;
using Dominio;


namespace Dominio
{
    public class InsumoNegocio
    {
        //public List<Insumo> listar()
        //{
        //    List<Insumo> lista = new List<Insumo>();
        //    AccesoDatos datos = new AccesoDatos();


        //    try
        //    {

        //        datos.SetearConsulta(" ");
        //        datos.EjecutarLectura();


        //        while (datos.Lector.Read())
        //        {
        //            Insumo aux = new Insumo();
        //            if (!(datos.Lector["Id"] is DBNull))

        //                aux.NombreInsumo = (string)datos.Lector["NombreInsumo"];
                    



        //            lista.Add(aux);

        //        }

        //        return lista;
        //    }
        //    catch (Exception ex)

        //    {
        //        throw ex;
        //    }

        //    finally
        //    {
        //        datos.CerrarConexion();

        //    }
        //}
    }
}