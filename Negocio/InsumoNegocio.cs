﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
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
            SqlCommand comando = new SqlCommand();

            try
            {

                datos.SetearConsulta(@"SELECT Id_Insumo as Id_Insumo, Nombre_Insumo as Nombre_Insumo, PrecioUnitario_Insumo as Precio_Unitario_Insumo, CantidadEnStock_Insumo as Cantidad_Stock_Insumo, Id_TI AS Id_TipoInsumo, Nombre_TI AS NombreTipo, Descripcion_TI AS DescripcionTipo, Estado_TI AS EstadoTipo, Id_Categoria , Descripcion_Categoria AS Descripcion_Categoria FROM Insumo INNER JOIN TipoInsumo ON Insumo.Id_Insumo = TipoInsumo.Id_TI INNER JOIN  Categoria ON Insumo.Id_Categoria_Insumo = Categoria.Id_Categoria");
            

                    

                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    Insumo aux = new Insumo();
                    if (!(datos.Lector["Id_Insumo"] is DBNull))
                        aux.Idinsumo = (int)datos.Lector["Id_Insumo"];
                    aux.NombreInsumo = (string)datos.Lector["Nombre_Insumo"];
                    aux.PrecioUnitario = (decimal)datos.Lector["Precio_Unitario_Insumo"];
                    aux.CantidadStock = (int)datos.Lector["Cantidad_Stock_Insumo"];

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

        public List<Insumo> ListaXid(string id= "")
        {
            List<Insumo> seleccionado = new List<Insumo>();
            AccesoDatos datos = new AccesoDatos();
            SqlCommand comando = new SqlCommand();

            try
            {

                datos.SetearConsulta(@"SELECT Id_Insumo as Id_Insumo, Nombre_Insumo as Nombre_Insumo, PrecioUnitario_Insumo as Precio_Unitario_Insumo, CantidadEnStock_Insumo as Cantidad_Stock_Insumo, Id_TI AS Id_TipoInsumo, Nombre_TI AS NombreTipo, Descripcion_TI AS DescripcionTipo, Estado_TI AS EstadoTipo, Id_Categoria , Descripcion_Categoria AS Descripcion_Categoria FROM Insumo INNER JOIN TipoInsumo ON Insumo.Id_Insumo = TipoInsumo.Id_TI INNER JOIN  Categoria ON Insumo.Id_Categoria_Insumo = Categoria.Id_Categoria where Id_Insumo= " + id);




                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    Insumo aux = new Insumo();
                    if (!(datos.Lector["Id_Insumo"] is DBNull))
                        aux.Idinsumo = (int)datos.Lector["Id_Insumo"];
                    aux.NombreInsumo = (string)datos.Lector["Nombre_Insumo"];
                    aux.PrecioUnitario = (decimal)datos.Lector["Precio_Unitario_Insumo"];
                    aux.CantidadStock = (int)datos.Lector["Cantidad_Stock_Insumo"];

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


                    seleccionado.Add(aux);

                }

                return seleccionado;
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
                datos.SetearConsulta(@"INSERT INTO Insumo (Id_Insumo, Nombre_Insumo, PrecioUnitario_Insumo, CantidadEnStock_Insumo, Tipo_Insumo, Id_Categoria_Insumo)" +
              "VALUES (@Id_Insumo,@Nombre_Insumo, @PrecioUnitario_Insumo, @CantidadEnStock_Insumo, @Tipo_Insumo, @Id_Categoria_Insumo)");
                datos.setearParametro(@"Id_Insumo", insumo.Idinsumo);
                datos.setearParametro("@Nombre_Insumo", insumo.NombreInsumo);
                datos.setearParametro("@PrecioUnitario_Insumo", insumo.PrecioUnitario);
                datos.setearParametro("@CantidadEnStock_Insumo", insumo.CantidadStock);
                datos.setearParametro("@Tipo_Insumo", insumo.Tipo.Id_TI);
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
        public void MofidicarInsumo(Insumo insumo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.SetearConsulta("update Insumo set Nombre_Insumo=@NombreInsumo, PrecioUnitario_Insumo=@PrecioUnitario,  CantidadEnStock_Insumo=@CantidadStock, Tipo_Insumo=@TipoInsumo, Id_Categoria_Insumo=@Id_Categoria where Id_Insumo=@Idinsumo  ");

                datos.setearParametro("@Idinsumo", insumo.Idinsumo);
                datos.setearParametro("@NombreInsumo", insumo.NombreInsumo);
                datos.setearParametro("@PrecioUnitario", insumo.PrecioUnitario);

                datos.setearParametro("@CantidadStock", insumo.CantidadStock);
                datos.setearParametro("@TipoInsumo", insumo.Tipo.Id_TI);
                datos.setearParametro("@Id_Categoria", insumo.Descripcion.Id_Categoria);

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

        public void EliminarInsumo(int id)
        {


            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetearConsulta("delete from Insumo where Id_Insumo = @Idinsumo");
                datos.setearParametro("@Idinsumo", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ObtenerNombreInsumo(string nomCat)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            return accesoDatos.ObtenerNombreInsumos(nomCat);
        }

        public DataTable DevolverGrillaInsumo(string Id)
        {
            AccesoDatos acc = new AccesoDatos();
            return acc.TraerInfoInsumos(Id);
        }


        public int ObtenerStockDisponiblePorId(int idInsumo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
               
                datos.SetearConsulta("SELECT CantidadEnStock_Insumo FROM Insumo WHERE Id_Insumo = @IdInsumo");
                datos.setearParametro("@IdInsumo", idInsumo);

                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    return (int)datos.Lector["CantidadEnStock_Insumo"];
                }
                
                return 0; // O algún valor predeterminado si el insumo no se encuentra
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
        public int ObtenerIdInsumoPorNombre(string nombreInsumo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
               
                datos.SetearConsulta("SELECT Id_Insumo FROM Insumo WHERE Nombre_Insumo = @NombreInsumo");
                datos.setearParametro("@NombreInsumo", nombreInsumo);

                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    return (int)datos.Lector["Id_Insumo"];
                }

                return 0; // O algún valor predeterminado si el insumo no se encuentra
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


    }

}