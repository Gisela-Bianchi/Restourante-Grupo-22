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
       

        public List<Insumo> listar()
        {
            List<Insumo> lista = new List<Insumo>();
            AccesoDatos datos = new AccesoDatos();


            try
            {

                datos.SetearConsulta(@"SELECT Id_Insumo,Nombre_Insumo,PrecioUnitario_Insumo,Id_TI,Nombre_TI AS NombreTipo,Descripcion_TI AS DescripcionTipo,Estado_TI AS EstadoTipo,\r\nId_Categoria, Descripcion_Categoria AS DescripcionCategoria FROM Insumo INNER JOIN TipoInsumo ON Insumo.Id_Insumo = TipoInsumo.Id_TI INNER JOIN Categoria ON Insumo.Id_Categoria_Insumo = Categoria.Id_Categoria");
          

                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    Insumo aux = new Insumo();
                    if (!(datos.Lector["Id"] is DBNull))
                        aux.Idinsumo = (int)datos.Lector["Id"];
                    aux.NombreInsumo = (string)datos.Lector["NombreInsumo"];
                    aux.PrecioUnitario = (decimal)datos.Lector["PrecioUnitario"];

                    aux.Tipo = new TipoInsumo();
                    if (!(datos.Lector["Id"] is DBNull))
                        aux.Tipo.Id = (int)datos.Lector["Id"];
                    aux.Tipo.Nombre = (string)datos.Lector["Nombre"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Tipo.Estado = (bool)datos.Lector["Estado"];

                    aux.Descripcion = new Categoria();
                    if (!(datos.Lector["Id"] is DBNull))
                        aux.Descripcion.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Descripcion.Descripcion = (string)datos.Lector["Descripcion"];

                 
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



        public void AgregarInsumo(Insumo insumo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("INSERT INTO Insumo (Nombre_Insumo, PrecioUnitario_Insumo, CantidadEnStock_Insumo, Tipo_Insumo, Id_Categoria_Insumo) " +
                 "VALUES (@Nombre_Insumo, @PrecioUnitario, @CantidadEnStock, @TipoInsumo, @IdCategoria)");
                datos.setearParametro("@IdInsumo", insumo.Idinsumo);
                datos.setearParametro("@Nombre_Insumo", insumo.NombreInsumo);
                datos.setearParametro("@PrecioUnitario", insumo.PrecioUnitario);
                datos.setearParametro("@CantidadEnStock", insumo.CantidadStock);
                datos.setearParametro("@Id", insumo.Tipo.Id);
                datos.setearParametro("@Nombre", insumo.Tipo.Nombre);
                datos.setearParametro("@Descripcion", insumo.Tipo.Descripcion);
                datos.setearParametro("@Estado", insumo.Tipo.Estado);
                datos.setearParametro("@IdCategoria", insumo.Descripcion.IdCategoria);
                datos.setearParametro("@Descripcion", insumo.Descripcion.Descripcion);
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