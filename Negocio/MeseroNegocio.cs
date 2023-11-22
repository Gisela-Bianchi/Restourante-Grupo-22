using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                datos.SetearConsulta(@"select Id_M as Id_Mesero, Dni_M as Dni_Mesero, MesasAsignadas_M as Mesas_Asignadas_Mesero, Nombre_M as Nombre_Mesero, Apellido_M as Apellido_Mesero from Mesero");

                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    Mesero aux = new Mesero();
                    if (!(datos.Lector["Id_Mesero"] is DBNull))
                    aux.IdMesero = (int)datos.Lector["Id_Mesero"];

                    if (int.TryParse(datos.Lector["Dni_Mesero"].ToString(), out int dni))
                        aux.DNI = dni;
                    aux.NombreMesero = (string)datos.Lector["Nombre_Mesero"];
                    aux.ApellidoMesero = (string)datos.Lector["Apellido_Mesero"];
                    aux.MesasAsignadas = (int)datos.Lector["Mesas_Asignadas_Mesero"];


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


        public void AgregarMesero(Mesero mesero)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("INSERT INTO Mesero (Id_Mesero,Dni_Mesero, Mesas_Asignadas_Mesero, Nombre_Mesero, Apellido_Mesero) " +
                 "VALUES (@Id_Mesero,@Dni_Mesero, @Mesas_Asignadas_Mesero, @Nombre_Mesero, @Apellido_Mesero");

                datos.setearParametro("@Id_Mesero", mesero.IdMesero);
                datos.setearParametro("@Dni_Mesero", mesero.DNI);
                datos.setearParametro("@Mesas_Asignadas_Mesero", mesero.MesasAsignadas);
                datos.setearParametro("@Nombre_Mesero", mesero.NombreMesero);
                datos.setearParametro("@Apellido_Mesero", mesero.ApellidoMesero);

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
