using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CategoriaNegocio
    {


        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();


            try
            {

                datos.SetearConsulta(@"select Id_Categoria as Id_Categoria , Descripcion_Categoria as Descripcion_Categoria from Categoria;");

                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    if (!(datos.Lector["Id_Categoria"] is DBNull))
                        aux.Id_Categoria = (int)datos.Lector["Id_Categoria"];

                    aux.Descripcion_Categoria = (string)datos.Lector["Descripcion_Categoria"];




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



        public void AgregarCategoria(Categoria categoria)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into Categoria(Id_Categoria,Descripcion_Categoria)" +
                 "VALUES (@Id_Categoria,@Descripcion_Categoria)");

                datos.setearParametro("@Id_Categoria", categoria.Id_Categoria);
                datos.setearParametro("@Descripcion_Categoria", categoria.Descripcion_Categoria);
             

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


