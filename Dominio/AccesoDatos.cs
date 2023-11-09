using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AccesoDatos { 


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
       /* public AccesoDatos()
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
            catch { 
            
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
            string Consulta = $"select Usuario from Usuarios where Usuario = '{usuario.NombreUsuario }' and Contraseña = '{usuario.Contraseña}'";
            
            try
            {
                bool Agrego=false;
                SqlConnection conexion = ObtenerConnection();
                SqlCommand sqlCommand= new SqlCommand(Consulta, conexion);
                SqlDataReader rd = sqlCommand.ExecuteReader();//nos devuelve filas
                Usuario regUsuario= new Usuario();
                if(rd.HasRows) {
                    //nuevo
                    while (rd.Read()) {
                        
                        regUsuario.Id = Int32.Parse(rd["Id"].ToString());
                        regUsuario.NombreUsuario = rd["Usuario"].ToString();
                        regUsuario.Contraseña = rd["Contraseña"].ToString() ;
                        regUsuario.TipoUsuario = Int32.Parse(rd["TipoUsuario"].ToString());
                        regUsuario.ingreso = true;
                    }
                }
                else
                {   regUsuario.ingreso=false;
                }
                conexion.Close();
                return regUsuario;  
               
               
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

    }
}
