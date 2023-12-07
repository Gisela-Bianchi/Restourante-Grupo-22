using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public Usuario Loguear(Usuario usuario)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            return accesoDatos.Loguear(usuario);//lo q nos devuelva la funcion lo retornamos 
        }


        public void AgregarUsuario(Usuario usuario)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("insert into Usuario(ContraseÑa,Email,TipoUsuario) VALUES(@Contra, @Email, 'Mesero') ");

                datos.setearParametro("@Contra", usuario.Contraseña);
                datos.setearParametro("@Email", usuario.Email);


                datos.EjecutarAccion();
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

        public int buscarIdUsuario(string Email)
        {


            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select Id from Usuario WHERE Email = @Email");
                datos.setearParametro("@Email", Email);
                datos.EjecutarLectura();
                datos.Lector.Read();
                int aux = (int)datos.Lector["Id"];


                return aux;
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


        public int traerIDusuario(string dni)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            return accesoDatos.traerIDusuario(dni);
        }

    }


}
