using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoInsumoNegocio
    {


        public List<TipoInsumo> Listar( string id="")
        {
            List<TipoInsumo> lista = new List<TipoInsumo>();
            AccesoDatos datos = new AccesoDatos();
            SqlCommand comando = new SqlCommand();


            try
            {

                datos.SetearConsulta(@"select Id_TI as Id_TI, Nombre_TI as Nombre_Tipo_Insumo,Descripcion_TI as Descripcion_Tipo_Insumo,Estado_TI as Estado_Tipo_Insumo from TipoInsumo  ");

                if (id != "")
                    comando.CommandText += " and Id_TI = " + id;

                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    TipoInsumo aux = new TipoInsumo();
                    if (!(datos.Lector["Id_TI"] is DBNull))
                        aux.Id_TI = (int)datos.Lector["Id_TI"];
                    aux.NombreTipoInsumo = (string)datos.Lector["Nombre_Tipo_Insumo"];
                    aux.DescripcionTipoInsumo = (string)datos.Lector["Descripcion_Tipo_Insumo"];
                    aux.EstadoTipoInsumo = (bool)datos.Lector["Estado_Tipo_Insumo"];






                    lista.Add(aux);

                }

                return lista;
            }
            catch (Exception ex)

            {
                throw ex;
            }

            finally
            {
                datos.CerrarConexion();

            }
        }



        public void AgregarTipoInsumo(TipoInsumo tipoinsumo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("INSERT INTO TipoInsumo (Id_TI,Nombre_TI, Descripcion_TI,Estado_TI) " +
                 "VALUES (@Id_TI,@Nombre_TI, @Descripcion_TI, @Estado_TI)");
                datos.setearParametro("@Id_TI", tipoinsumo.Id_TI);
                datos.setearParametro("@Nombre_TI", tipoinsumo.NombreTipoInsumo);
                datos.setearParametro("@Descripcion_TI", tipoinsumo.DescripcionTipoInsumo);
                datos.setearParametro("@Estado_TI", tipoinsumo.EstadoTipoInsumo);

                datos.EjecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                datos.CerrarConexion();
            }
        }


        public void MofidicarTipoInsumo(TipoInsumo tipo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.SetearConsulta("update TipoInsumo set Nombre_TI=@Nombre_TI, Descripcion_TI=@Descripcion_TI, Estado_TI=@Estado_TI where Id_TI=@Id_TI  ");

                datos.setearParametro("@Id_TI", tipo.Id_TI);
                datos.setearParametro("@Nombre_TI", tipo.NombreTipoInsumo);
                datos.setearParametro("@Descripcion_TI", tipo.DescripcionTipoInsumo);
                datos.setearParametro("@Estado_TI", tipo.EstadoTipoInsumo);


                datos.EjecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}

