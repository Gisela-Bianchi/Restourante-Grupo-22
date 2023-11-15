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

                datos.SetearConsulta(@"SELECT Id_Insumo, Nombre_Insumo, PrecioUnitario_Insumo, CantidadEnStock_Insumo, Id_TI AS Id_TipoInsumo, Nombre_TI AS NombreTipo, Descripcion_TI AS DescripcionTipo, Estado_TI AS EstadoTipo, Id_Categoria , Descripcion_Categoria AS Descripcion_Categoria FROM Insumo INNER JOIN TipoInsumo ON Insumo.Id_Insumo = TipoInsumo.Id_TI INNER JOIN  Categoria ON Insumo.Id_Categoria_Insumo = Categoria.Id_Categoria");

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
                        aux.Tipo.Id_TI = (int)datos.Lector["Id_TipoInsumo"];
                    aux.Tipo.NombreTipoInsumo = (string)datos.Lector["NombreTipo"];
                    aux.Tipo.DescripcionTipoInsumo = (string)datos.Lector["DescripcionTipo"];
                    aux.Tipo.EstadoTipoInsumo = (bool)datos.Lector["EstadoTipo"];

                    aux.Descripcion = new Categoria();
                    if (!(datos.Lector["Id_Categoria"] is DBNull))
                        aux.Descripcion.Id_Categoria = (int)datos.Lector["Id_Categoria"];
                    aux.Descripcion.Descripcion_Categoria = (string)datos.Lector["Descripcion_Categoria"];


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
                datos.SetearConsulta(@"INSERT INTO Insumo (Id_Insumo, Nombre_Insumo, PrecioUnitario_Insumo, CantidadEnStock_Insumo, Id_TI, Id_Categoria_Insumo) 
             VALUES (@Id_Insumo,@Nombre_Insumo, @PrecioUnitario_Insumo, @CantidadEnStock_Insumo, @Tipo_Insumo, @Id_Categoria_Insumo)");
                datos.setearParametro(@"Id_Insumo", insumo.Idinsumo);
                datos.setearParametro("@Nombre_Insumo", insumo.NombreInsumo);
                datos.setearParametro("@PrecioUnitario_Insumo", insumo.PrecioUnitario);
                datos.setearParametro("@CantidadEnStock_Insumo", insumo.CantidadStock);
                datos.setearParametro("@Id_TI", insumo.Tipo.Id_TI);
                datos.setearParametro("@Id_Categoria_Insumo", insumo.Descripcion.Id_Categoria); 





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