﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Dominio
{
    public class AccesoDatos
    {


        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos()
        {
            conexion = new SqlConnection("Data Source=localhost\\sqlexpress; Initial Catalog = Restaurante; Integrated Security = True");
            comando = new SqlCommand();
        }
        //public AccesoDatos()
        //{
        //    conexion = new SqlConnection("Data Source=Arii; Initial Catalog = Restaurante-Grupo22; Integrated Security = True");
        //    comando = new SqlCommand();
        //}
        public SqlConnection ObtenerConnection()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                return conexion;
            }
            catch
            {

                return null;
            }

        }
        public void SetearConsulta(string consulta)
        {

            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }

        public void EjecutarLectura()
        {

            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Usuario Loguear(Usuario usuario)
        {
            string Consulta = $"select Id,Usuario,Contraseña,TipoUsuario from Usuario where Usuario = '{usuario.Usuarios}' and Contraseña = '{usuario.Contraseña}'";

            try
            {

                SqlConnection conexion = ObtenerConnection();
                SqlCommand sqlCommand = new SqlCommand(Consulta, conexion);
                SqlDataReader rd = sqlCommand.ExecuteReader();//nos devuelve filas
                Usuario regUsuario = new Usuario();

                if (rd.HasRows)
                {
                    //nuevo
                    while (rd.Read())
                    {

                        regUsuario.Id = Int32.Parse(rd["Id"].ToString());
                        regUsuario.Usuarios = rd["Usuario"].ToString();
                        regUsuario.Contraseña = rd["Contraseña"].ToString();
                        regUsuario.TipoUsuario = Int32.Parse(rd["TipoUsuario"].ToString());
                        regUsuario.Activo = true;
                    }
                }
                else
                {
                    regUsuario.Activo = false;
                }
                conexion.Close();
                return regUsuario;


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void EjecutarAccion()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void CerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
                conexion.Close();
            }

        }


        public DataTable ObtenerNombreInsumos()
        {
            const string consulta = "select Nombre_Insumo,PrecioUnitario_Insumo from Insumo";
            SqlConnection conexion = ObtenerConnection();

            SqlCommand comand = new SqlCommand(consulta, conexion);

            SqlDataReader rd = comand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            conexion.Close();
            return dt;
        }

        public DataTable TraerInfoInsumos(string Id)
        {
            string consulta = $"select Nombre_Insumo,PrecioUnitario_Insumo from Insumo where Id_Insumo='{Id}'";
            SqlConnection conexion = ObtenerConnection();

            SqlCommand comand = new SqlCommand(consulta, conexion);
            SqlDataAdapter rd = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            rd.Fill(dt);
            conexion.Close();
            return dt;
        }

        public bool CrearPedido(int NumMesa)
        {
            bool creo;
            SqlConnection conexion = ObtenerConnection();
            string consulta = $"insert into Pedido(NumeroMesa_Pe) select ' {NumMesa} '";
            SqlCommand comand = new SqlCommand( consulta, conexion);
            int filasAfectadas=comand.ExecuteNonQuery();
            if (filasAfectadas == 0) { creo= false; } 
            else { creo= true; }
            conexion.Close ();
            return creo;
        }

        public int ultimoNumPedido()
        {
            SqlConnection conexion = ObtenerConnection();
            string consulta = "select top 1 NumeroPedido_Pe from Pedido order by NumeroPedido_Pe desc";
            SqlCommand comand = new SqlCommand(consulta , conexion);
            SqlDataReader rd = comand.ExecuteReader();
            int ultimoid = -1;
            while (rd.Read())
            {
                ultimoid=Convert.ToInt32(rd.GetValue(0).ToString());
            }
            conexion.Close();
            return ultimoid;
        }

        public int BuscarIdInsumo(string NombreInsumo)
        {
            SqlConnection conexion = ObtenerConnection();
            string consulta = $"select top 1 Id_Insumo from Insumo where Nombre_Insumo='{NombreInsumo}'";
            SqlCommand comand = new SqlCommand(consulta, conexion);
            SqlDataReader rd = comand.ExecuteReader();
            int id = -1;
            while (rd.Read())
            {
                id = Convert.ToInt32(rd.GetValue(0).ToString());
            }
            conexion.Close();
            return id;
        }

        public bool ingresarInsumoXPedido(PedidosXInsumo reg)
        {
            bool creo;
            SqlConnection conexion = ObtenerConnection();
            string consulta = $"INSERT INTO PedidoXInsumo (NumeroPedido_PXI, IdInsumo_PXI, CantVendida_PXI, PrecioUnitario_PXI) VALUES ({reg.NumeroPedido.NumeroPedido}, {reg.IdInsumo.Idinsumo}, {reg.CantVendida}, {reg.PrecioUnitario})";

            SqlCommand comand = new SqlCommand(consulta, conexion);
            int filasAfectadas = comand.ExecuteNonQuery();
            if (filasAfectadas == 0) { creo = false; }
            else { creo = true; }
            conexion.Close();
            return creo;
        }

    }
}
