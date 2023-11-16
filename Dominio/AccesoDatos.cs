using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
             conexion = new SqlConnection("Data Source=localhost\\sqlexpress; Initial Catalog = Restaurante-Grupo22; Integrated Security = True");
             comando = new SqlCommand();
         }
        /*public AccesoDatos()
        {
            conexion = new SqlConnection("Data Source=Arii; Initial Catalog = Restaurante-Grupo22; Integrated Security = True");
            comando = new SqlCommand();
        }*/
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

    }
}
