using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class GerenteNegocio
    {
        public Gerente traerGerentePorId(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            Gerente aux = new Gerente();

            try
            {

                datos.SetearConsulta(@"select G.Id_G, G.Nombre_G,G.Apellido_G,G.Dni_G from Gerente G WHERE G.IdUsuario_G=@Id ");
                datos.setearParametro("@Id", id);
                datos.EjecutarLectura();


                if (datos.Lector.HasRows)
                {
                    datos.Lector.Read();
                    aux.IdGerente = (int)datos.Lector["Id_G"];
                    if (int.TryParse(datos.Lector["Dni_G"].ToString(), out int dni))
                        aux.DNI = dni;
                    aux.NombreGerente = (string)datos.Lector["Nombre_G"];
                    aux.ApellidoGerente = (string)datos.Lector["Apellido_G"];
                    aux.IdUsuario = id;
                }

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

    }
}
