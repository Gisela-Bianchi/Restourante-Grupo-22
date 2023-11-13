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
       

        public List<Insumo> Listar()
        {
            List<Insumo> lista = new List<Insumo>();
            AccesoDatos datos = new AccesoDatos();


            try
            {

                datos.SetearConsulta(@"SELECT Id_Insumo, Nombre_Insumo, PrecioUnitario_Insumo, CantidadEnStock_Insumo, Id_TI AS Id_TipoInsumo, Nombre_TI AS NombreTipo, Descripcion_TI AS DescripcionTipo, Estado_TI AS EstadoTipo, Id_Categoria FROM Insumo INNER JOIN TipoInsumo ON Insumo.Id_Insumo = TipoInsumo.Id_TI INNER JOIN  Categoria ON Insumo.Id_Categoria_Insumo = Categoria.Id_Categoria");

                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    Insumo aux = new Insumo();
                    if (!(datos.Lector["Id_Insumo"] is DBNull))
                        aux.Idinsumo = (int)datos.Lector["Id_Insumo"];
                    aux.NombreInsumo = (string)datos.Lector["Nombre_Insumo"];
                    aux.PrecioUnitario = (decimal)datos.Lector["PrecioUnitario_insumo"];
                    aux.CantidadStock = (int)datos.Lector["CantidadEnStock_Insumo"];

                    aux.Tipo = new TipoInsumo();
                    if (!(datos.Lector["Id_TipoInsumo"] is DBNull))
                        aux.Tipo.Id = (int)datos.Lector["Id_TipoInsumo"];
                    aux.Tipo.Nombre = (string)datos.Lector["NombreTipo"];
                    aux.Tipo.Descripcion = (string)datos.Lector["DescripcionTipo"];
                    aux.Tipo.Estado = (bool)datos.Lector["EstadoTipo"];

                    aux.Descripcion = new Categoria();
                    if (!(datos.Lector["Id_Categoria"] is DBNull))
                        aux.Descripcion.IdCategoria = (int)datos.Lector["Id_Categoria"];


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
                datos.SetearConsulta(@"INSERT INTO Insumo (Nombre_Insumo, PrecioUnitario_Insumo, CantidadEnStock_Insumo, Tipo_Insumo, Id_Categoria_Insumo) 
                       VALUES (@Nombre_Insumo, @PrecioUnitario, @CantidadEnStock, @Tipo_Insumo, @IdCategoria)");

                datos.setearParametro("@Nombre_Insumo", insumo.NombreInsumo);
                datos.setearParametro("@PrecioUnitario", insumo.PrecioUnitario);
                datos.setearParametro("@CantidadEnStock", insumo.CantidadStock);
                datos.setearParametro("@Tipo_Insumo", insumo.Tipo.Nombre);
                datos.setearParametro("@IdCategoria", insumo.Descripcion.IdCategoria);


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