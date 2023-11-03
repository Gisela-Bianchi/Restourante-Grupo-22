using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AccesoDatos
    {   private const string rutaDB= "Data Source=localhost\\sqlexpress; Initial Catalog = Restaurante-Grupo22; Integrated Security = True";
        public SqlConnection ObtenerConnection()
        {
            SqlConnection cn = new SqlConnection(rutaDB);

            try
            {
                cn.Open();
                return cn;
            }
            catch { 
            
                return null;
            }

        }
        

        
        public bool Loguear(Usuario usuario)
        {
            string Consulta = $"select Usuario from Usuarios where Usuario = '{usuario.NombreUsuario }' and Contraseña = '{usuario.Contraseña}'";
            
            try
            {bool Agrego=false;
                SqlConnection Cn = ObtenerConnection();
                SqlCommand sqlCommand= new SqlCommand(Consulta,Cn);
                SqlDataReader rd = sqlCommand.ExecuteReader();//nos devuelve filas
                if(rd.HasRows) {
                    Agrego= true;
                }
                else
                {
                    Agrego= false;
                }
                Cn.Close();
                return Agrego;  
               
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }



    }
}
