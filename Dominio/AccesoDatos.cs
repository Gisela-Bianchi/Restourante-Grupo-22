using System;
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
        //public AccesoDatos()
        //{
        //    conexion = new SqlConnection("Data Source=localhost\\sqlexpress; Initial Catalog = Restaurante; Integrated Security = True");
        //    comando = new SqlCommand();
        //}
        public AccesoDatos()
        {
            conexion = new SqlConnection("Data Source=Arii; Initial Catalog = Restaurante; Integrated Security = True");
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


        public DataTable ObtenerNombreInsumos(string nomCat)
        {
            string consulta = $"select Nombre_Insumo,PrecioUnitario_Insumo from Insumo inner join Categoria on Id_Categoria=Id_Categoria_Insumo where Descripcion_Categoria='{nomCat}'";
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
        public bool ActualizarEstadoPedido(int numeroPedido, bool nuevoEstado)
        {
            bool creo;
            SqlConnection conexion = ObtenerConnection();
            string consulta = $"UPDATE Pedido SET EstadoPedido_Pe = '{(nuevoEstado ? 1 : 0)}' WHERE NumeroPedido_Pe = {numeroPedido}";
            SqlCommand comand = new SqlCommand(consulta, conexion);
            int filasAfectadas = comand.ExecuteNonQuery();
            if (filasAfectadas == 0) { creo = false; }
            else { creo = true; }
            conexion.Close();
            return creo;
        }
        public bool ActualizarFacturacion(int numeroPedido, bool nuevoEstado)
        {
            bool creo;
            SqlConnection conexion = ObtenerConnection();
            string consulta = $"UPDATE Pedido SET Facturado_Pe = '{(nuevoEstado ? 1 : 0)}' WHERE NumeroPedido_Pe = {numeroPedido}";
            SqlCommand comand = new SqlCommand(consulta, conexion);
            int filasAfectadas = comand.ExecuteNonQuery();
            if (filasAfectadas == 0) { creo = false; }
            else { creo = true; }
            conexion.Close();
            return creo;
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

   
        public List<int> NumerosPedidosDia()
        { 
            SqlConnection sqlConnection = ObtenerConnection();
            string consulta = "select NumeroPedido_Pe from Pedido where CAST(Fechapedido_Pe as date)=CAST(GETDATE() as date)";
;
            SqlCommand comand = new SqlCommand(consulta, sqlConnection);
            SqlDataReader sqlDataReader = comand.ExecuteReader();
            List<int> numerosPed=new List<int>();
            while (sqlDataReader.Read())
            {
                int NP=sqlDataReader.GetInt32(0);
                numerosPed.Add(NP);
            }
            return numerosPed;
        }

        public List<Insumo> traerNombreInsumo(int numPedido)
        {
            SqlConnection sqlConnection = ObtenerConnection();
            string consulta = $"select Nombre_Insumo from (PedidoXInsumo inner join Insumo on IdInsumo_PXI=Id_Insumo) where NumeroPedido_PXI={numPedido}";
            
            SqlCommand comand = new SqlCommand(consulta, sqlConnection);
            SqlDataReader sqlDataReader = comand.ExecuteReader();
            List<Insumo> nombresInsumos = new List<Insumo>();
            while (sqlDataReader.Read())
            {
                Insumo nombreI = new Insumo();
                nombreI.NombreInsumo = sqlDataReader.GetString(0);
                nombresInsumos.Add(nombreI);
            }
            sqlConnection.Close();
            return nombresInsumos;
        } 

        public int traeNumeroMesa(int numPedido)
        {
            SqlConnection sqlConnection = ObtenerConnection();
            string consulta = $"select NumeroMesa_Pe from Pedido where NumeroPedido_Pe='{numPedido}'";
            
            SqlCommand comand = new SqlCommand(consulta, sqlConnection);
            SqlDataReader sqlDataReader = comand.ExecuteReader();
            int numMesa = -1;
            while (sqlDataReader.Read())
            {
                numMesa = sqlDataReader.GetInt32(0);
            }
            sqlConnection.Close();
                return numMesa;
        }
        public DateTime traeHoraPedido(int numPedido)
        {
            SqlConnection sqlConnection = ObtenerConnection();
            string consulta = $"select FechaPedido_Pe from Pedido where NumeroPedido_Pe='{numPedido}'";

            SqlCommand comand = new SqlCommand(consulta, sqlConnection);
            SqlDataReader sqlDataReader = comand.ExecuteReader();
            DateTime fechaPedido = DateTime.MinValue;

            while (sqlDataReader.Read())
            {
                fechaPedido = sqlDataReader.GetDateTime(0);
            }
            sqlConnection.Close();
            return fechaPedido;
        }
        

             public bool  traeEstadoPedido(int numPedido )
        {
            SqlConnection sqlConnection = ObtenerConnection();
            string consulta = $"select EstadoPedido_Pe from Pedido where NumeroPedido_Pe='{numPedido}'";

            SqlCommand comand = new SqlCommand(consulta, sqlConnection);
            SqlDataReader sqlDataReader = comand.ExecuteReader();
            bool EstadoPedido = false;

            while (sqlDataReader.Read())
            {
                EstadoPedido = sqlDataReader.GetBoolean(0);
            }
            sqlConnection.Close();
            return EstadoPedido;
         }
      

            public bool TraerSiEstaFacturado(int numPedido)
            {
            SqlConnection sqlConnection = ObtenerConnection();
            string consulta = $"select Facturado_Pe from Pedido where NumeroPedido_Pe='{numPedido}'";

            SqlCommand comand = new SqlCommand(consulta, sqlConnection);
            SqlDataReader sqlDataReader = comand.ExecuteReader();
            bool Facturado = false;

            while (sqlDataReader.Read())
            {
                Facturado = sqlDataReader.GetBoolean(0);
            }
            sqlConnection.Close();
            return Facturado;
        }

        public List<string> todosNumMesa()
        {
            SqlConnection sqlConnection = ObtenerConnection();
            string consulta = "select NumeroMesa_Mesa from Mesas";

            SqlCommand comand = new SqlCommand(consulta, sqlConnection);
            SqlDataReader sqlDataReader = comand.ExecuteReader();
            List<string> list = new List<string>();
            string agregar;
            while (sqlDataReader.Read())
            {
                agregar = $"Mesa {sqlDataReader.GetInt32(0)}";
                list.Add(agregar);
            }
            sqlConnection.Close();
            return list;
        }
        public decimal recTotXMesa(int NumMesa)

        {
            SqlConnection sqlConnection = ObtenerConnection();
            string consulta = $"  select sum(RecaudacionTotal_Pe) from Pedido where NumeroMesa_Pe = '{NumMesa}'";

            SqlCommand comand = new SqlCommand(consulta, sqlConnection);
            SqlDataReader sqlDataReader = comand.ExecuteReader();
            decimal recTotXMesa = 0;
            while (sqlDataReader.Read())
            {
                if (sqlDataReader != null)
                {
                    recTotXMesa = sqlDataReader.GetDecimal(0);
                }
            }
            sqlConnection.Close();
            return recTotXMesa;
        }

        public List<string> traerNombreCategoria()
        {
            
            SqlConnection sqlConnection = ObtenerConnection();
            string consulta = $"select Descripcion_Categoria from Categoria";

            SqlCommand comand = new SqlCommand(consulta, sqlConnection);
            SqlDataReader sqlDataReader = comand.ExecuteReader();
            List<string> list = new List<string>();
            string regCat;

            while (sqlDataReader.Read())
            {
                regCat = sqlDataReader["Descripcion_Categoria"].ToString();
                list.Add(regCat);
            }
            sqlConnection.Close();
            return list;
        }

        //PRUEBA PARA QUE EL GERENTE AGREGUE MESAS

        public List<int> CantMesas()
        {
            
            SqlConnection sqlConnection = ObtenerConnection();
            string consulta = "select NumeroMesa_Mesa from Mesas";
            SqlCommand comand = new SqlCommand(consulta, sqlConnection);
            SqlDataReader sqlDataReader = comand.ExecuteReader();
            List<int> lista = new List<int>();
            int NumMesa = -1; 
            while (sqlDataReader.Read())
            {
                if (sqlDataReader != null)
                {
                   NumMesa = sqlDataReader.GetInt32(0);
                    lista.Add(NumMesa);
                }
            }
            sqlConnection.Close();
            return lista;
        }
        
    }
}
