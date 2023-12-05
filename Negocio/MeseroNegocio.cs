using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;


namespace Dominio

{
    public class MeseroNegocio
    {

        public List<Mesero> Listar()
        {
            List<Mesero> lista = new List<Mesero>();
            AccesoDatos datos = new AccesoDatos();


            try
            {

                datos.SetearConsulta(@"select IdUsuario_M,Id_M, Dni_M as Dni_Mesero, Nombre_M as Nombre_Mesero, Apellido_M as Apellido_Mesero from Mesero");

                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    Mesero aux = new Mesero();
                    aux.IdMesero = (int)datos.Lector["Id_M"];
                    if (int.TryParse(datos.Lector["Dni_Mesero"].ToString(), out int dni))
                        aux.DNI = dni;
                    aux.NombreMesero = (string)datos.Lector["Nombre_Mesero"];
                    aux.ApellidoMesero = (string)datos.Lector["Apellido_Mesero"];
                    aux.IdUsuario = (int)datos.Lector["IdUsuario_M"];
                    aux.MesasAsignadas = traerMesasMesero(aux.IdMesero);
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



        public Mesero traerMeseroPorId(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            Mesero aux = new Mesero();

            try
            {

                datos.SetearConsulta(@"select Id_M, Dni_M as Dni_Mesero, Nombre_M as Nombre_Mesero, Apellido_M as Apellido_Mesero from Mesero where IdUsuario_M=@Id ");
                datos.setearParametro("@Id", id);
                datos.EjecutarLectura();


                if (datos.Lector.HasRows)
                {
                    datos.Lector.Read();
                    aux.IdMesero = (int)datos.Lector["Id_M"];
                    if (int.TryParse(datos.Lector["Dni_Mesero"].ToString(), out int dni))
                        aux.DNI = dni;
                    aux.NombreMesero = (string)datos.Lector["Nombre_Mesero"];
                    aux.ApellidoMesero = (string)datos.Lector["Apellido_Mesero"];
                    aux.IdUsuario = id;
                    aux.MesasAsignadas = traerMesasMesero(aux.IdMesero);
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

        public List<int> traerMesasMesero(int idMesero)
        {
            AccesoDatos datos = new AccesoDatos();
            List<int> mesas = new List<int>();

            try
            {
                int aux;
                datos.SetearConsulta(@"SELECT NumeroMesa_Mesa  from Mesas where Id_MeseroMesa=@Id ");
                datos.setearParametro("@Id", idMesero);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {

                    aux = (int)datos.Lector["NumeroMesa_Mesa"];
                    mesas.Add(aux);
                }


                return mesas;
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


        public void AgregarMesero(Mesero mesero, Usuario usuario)
        {

            AccesoDatos datos = new AccesoDatos();
            UsuarioNegocio uNegocio = new UsuarioNegocio();
            uNegocio.AgregarUsuario(usuario);
            mesero.IdUsuario = uNegocio.buscarIdUsuario(usuario.Email);

            try
            {
                datos.SetearConsulta("INSERT INTO Mesero (Dni_M, Nombre_M, Apellido_M, IdUsuario_M) VALUES (@Dni_Mesero, @Nombre_Mesero, @Apellido_Mesero, @IdUsuario)");

                datos.setearParametro("@Dni_Mesero", mesero.DNI);
                datos.setearParametro("@Nombre_Mesero", mesero.NombreMesero);
                datos.setearParametro("@Apellido_Mesero", mesero.ApellidoMesero);
                datos.setearParametro("@IdUsuario", mesero.IdUsuario);

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
