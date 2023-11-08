using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AccesoDatos { 

    //  private const string rutaDB= "Data Source=Arii; Initial Catalog = Restaurante-Grupo22; Integrated Security = True"

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos()
        {
            conexion = new SqlConnection("Data Source=Arii; Initial Catalog = Restaurante-Grupo22; Integrated Security = True");
            comando = new SqlCommand();
        }
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
        public bool Loguear(Usuario usuario)
        {
            string Consulta = $"select Usuario from Usuarios where Usuario = '{usuario.NombreUsuario }' and Contraseña = '{usuario.Contraseña}'";
            
            try
            {
                bool Agrego=false;
                SqlConnection conexion = ObtenerConnection();
                SqlCommand sqlCommand= new SqlCommand(Consulta, conexion);
                SqlDataReader rd = sqlCommand.ExecuteReader();//nos devuelve filas
                if(rd.HasRows) {
                    Agrego= true;
                }
                else
                {
                    Agrego= false;
                }
                conexion.Close();
                return Agrego;  
               
               
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
