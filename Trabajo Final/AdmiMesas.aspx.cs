using Dominio;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Trabajo_Final
{
    public partial class Mesas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rellenarListaSessionCategorias(ddlCategoria1);
                rellenarListaSessionCategorias(ddlCategoria2);
                rellenarListaSessionCategorias(ddlCategoria3);
                rellenarListaSessionCategorias(ddlCategoria4);
                rellenarListaSessionCategorias(ddlCategoria5);
                rellenarListaSessionCategorias(ddlCategoria6);
                rellenarListaSessionInsumos(ddlMesa1, "ListaInsumos1");
                rellenarListaSessionInsumos(ddlMesa2, "ListaInsumos2");
                rellenarListaSessionInsumos(ddlMesa3, "ListaInsumos3");
                rellenarListaSessionInsumos(ddlMesa4, "ListaInsumos4");
                rellenarListaSessionInsumos(ddlMesa5, "ListaInsumos5");
                rellenarListaSessionInsumos(ddlMesa6, "ListaInsumos6");
                rellenarGrillaSession(gdvMesa1, "Datos");
                rellenarGrillaSession(gdvMesa2, "Datos2");
                rellenarGrillaSession(gdvMesa3, "Datos3");
                rellenarGrillaSession(gdvMesa4, "Datos4");
                rellenarGrillaSession(gdvMesa5, "Datos5");
                rellenarGrillaSession(gdvMesa6, "Datos6");
                rellenarTotRecaudadoSession(totalmesa1, "totRecaudado1", 1);
                rellenarTotRecaudadoSession(totalmesa2, "totRecaudado2", 2);
                rellenarTotRecaudadoSession(totalmesa3, "totRecaudado3", 3);
                rellenarTotRecaudadoSession(totalmesa4, "totRecaudado4", 4);
                rellenarTotRecaudadoSession(totalmesa5, "totRecaudado5", 5);
                rellenarTotRecaudadoSession(totalmesa6, "totRecaudado6", 6);
            }

        }
        protected void btnIngresar6_Click(object sender, EventArgs e)
        {
            Session.Add("Mesa 6", 6);
            //LlenarLista(ddlMesa4);
            cargarNombreCategoria(ddlCategoria6);
        }
        protected void btnIngresar5_Click(object sender, EventArgs e)
        {
            Session.Add("Mesa 5", 5);
            //LlenarLista(ddlMesa4);
            cargarNombreCategoria(ddlCategoria5);
        }
        protected void btnIngresar4_Click(object sender, EventArgs e)
        {
            Session.Add("Mesa 4", 4);
            //LlenarLista(ddlMesa4);
            cargarNombreCategoria(ddlCategoria4);
        }

        protected void btnIngresar3_Click(object sender, EventArgs e)
        {
            Session.Add("Mesa 3", 3);
            // LlenarLista(ddlMesa3);
            cargarNombreCategoria(ddlCategoria3);
        }

        protected void btnIngresar2_Click(object sender, EventArgs e)
        {
            Session.Add("Mesa 2", 2);
            // LlenarLista(ddlMesa2);
            cargarNombreCategoria(ddlCategoria2);

        }

        protected void btnIngresar1_Click(object sender, EventArgs e)
        {
            Session.Add("Mesa 1", 1);
            // LlenarLista(ddlMesa1);
            cargarNombreCategoria(ddlCategoria1);
        }
        public void LlenarLista(DropDownList Lista, string nomCat, string NombreSession)
        {
            InsumoNegocio insumoNegocio = new InsumoNegocio();
            DataTable dataTable = insumoNegocio.ObtenerNombreInsumo(nomCat);
            Session.Add(NombreSession, dataTable);
            Lista.DataSource = dataTable;
            Lista.DataTextField = "Nombre_Insumo";
            Lista.DataValueField = "PrecioUnitario_Insumo";
            Lista.DataBind();
        }

        protected void btnAgregarMesa1_Click(object sender, EventArgs e)
        {

            InsumoNegocio insumoneg = new InsumoNegocio();

            if (txtMesa1.Text == "") { return; }
            string PrecioUnitario = ddlMesa1.SelectedValue;
            string Insumo = ddlMesa1.SelectedItem.Text;
            string Cantidad = txtMesa1.Text;
            if (!int.TryParse(Cantidad, out int cantidadInt) || cantidadInt <= 0)
            {

                lblErrorMesa1.Text = "La cantidad ingresada no es válida.";
                return;
            }


            int idInsumo = insumoneg.ObtenerIdInsumoPorNombre(Insumo);

            if (idInsumo != 0)
            {
                int stockDisponible = insumoneg.ObtenerStockDisponiblePorId(idInsumo);

                if (cantidadInt <= 0 || cantidadInt > stockDisponible)
                {
                    lblErrorMesa1.Text = "El stock disponible es: " + stockDisponible; ;
                    return;
                }


            }
            else
            {
                lblErrorMesa1.Text = "No se pudo obtener el Id del insumo.";
                return;
            }



            DataTable Datos;
            if (Session["Datos"] != null)
            {
                Datos = (DataTable)Session["Datos"];
            }
            else
            {
                Datos = new DataTable();
                Datos.Columns.Add("Insumo");
                Datos.Columns.Add("Cantidad");
                Datos.Columns.Add("Precio Unitario");
            }

            DataRow nuevafila = Datos.NewRow();
            nuevafila["Insumo"] = Insumo;
            nuevafila["Cantidad"] = Cantidad;
            nuevafila["Precio Unitario"] = PrecioUnitario;
            Datos.Rows.Add(nuevafila);

            Session["Datos"] = Datos;
            gdvMesa1.DataSource = Datos;
            gdvMesa1.DataBind();
            txtMesa1.Text = "";
            int cant1;
            decimal prec1;
            decimal totRecaudado1 = 0;
            //problema
            for (int i = 0; i < gdvMesa1.Rows.Count; i++)

            {

                cant1 = Convert.ToInt32(gdvMesa1.Rows[i].Cells[1].Text);
                prec1 = Convert.ToDecimal(gdvMesa1.Rows[i].Cells[2].Text);
                totRecaudado1 += prec1 * cant1;

            }
            Session.Add("totRecaudado1", totRecaudado1);
            totalmesa1.Text = $"El total recaudado por la mesa 1 es: {totRecaudado1}";

        }

        protected void btnAgregarMesa2_Click(object sender, EventArgs e)
        {

            InsumoNegocio insumoneg = new InsumoNegocio();

            if (txtMesa2.Text == "") { return; }
            string PrecioUnitario = ddlMesa2.SelectedValue;
            string Insumo = ddlMesa2.SelectedItem.Text;
            string Cantidad = txtMesa2.Text;
            if (!int.TryParse(Cantidad, out int cantidadInt) || cantidadInt <= 0)
            {

                lblErrorMesa2.Text = "La cantidad ingresada no es válida.";
                return;
            }


            int idInsumo = insumoneg.ObtenerIdInsumoPorNombre(Insumo);

            if (idInsumo != 0)
            {
                int stockDisponible = insumoneg.ObtenerStockDisponiblePorId(idInsumo);

                if (cantidadInt <= 0 || cantidadInt > stockDisponible)
                {
                    lblErrorMesa2.Text = "El stock disponible es: " + stockDisponible; ;
                    return;
                }


            }
            else
            {
                lblErrorMesa2.Text = "No se pudo obtener el Id del insumo.";
                return;
            }



            DataTable Datos;
            if (Session["Datos2"] != null)
            {
                Datos = (DataTable)Session["Datos2"];
            }
            else
            {
                Datos = new DataTable();
                Datos.Columns.Add("Insumo");
                Datos.Columns.Add("Cantidad");
                Datos.Columns.Add("Precio Unitario");
            }

            DataRow nuevafila = Datos.NewRow();
            nuevafila["Insumo"] = Insumo;
            nuevafila["Cantidad"] = Cantidad;
            nuevafila["Precio Unitario"] = PrecioUnitario;
            Datos.Rows.Add(nuevafila);

            Session["Datos2"] = Datos;
            gdvMesa2.DataSource = Datos;
            gdvMesa2.DataBind();
            txtMesa2.Text = "";
            int cant2;
            decimal prec2;
            decimal totRecaudado2 = 0;
            for (int i = 0; i < gdvMesa2.Rows.Count; i++)
            {
                cant2 = Convert.ToInt32(gdvMesa2.Rows[i].Cells[1].Text);
                prec2 = Convert.ToDecimal(gdvMesa2.Rows[i].Cells[2].Text);
                totRecaudado2 += prec2 * cant2;

            }
            Session.Add("totRecaudado2", totRecaudado2);
            totalmesa2.Text = $"El total recaudado por la mesa 2 es: {totRecaudado2}";
        }

        protected void btnAgregarMesa3_Click(object sender, EventArgs e)
        {


            InsumoNegocio insumoneg = new InsumoNegocio();

            if (txtMesa3.Text == "") { return; }
            string PrecioUnitario = ddlMesa3.SelectedValue;
            string Insumo = ddlMesa3.SelectedItem.Text;
            string Cantidad = txtMesa3.Text;
            if (!int.TryParse(Cantidad, out int cantidadInt) || cantidadInt <= 0)
            {

                lblErrorMesa3.Text = "La cantidad ingresada no es válida.";
                return;
            }


            int idInsumo = insumoneg.ObtenerIdInsumoPorNombre(Insumo);

            if (idInsumo != 0)
            {
                int stockDisponible = insumoneg.ObtenerStockDisponiblePorId(idInsumo);

                if (cantidadInt <= 0 || cantidadInt > stockDisponible)
                {
                    lblErrorMesa3.Text = "El stock disponible es: " + stockDisponible; ;
                    return;
                }


            }
            else
            {
                lblErrorMesa3.Text = "No se pudo obtener el Id del insumo.";
                return;
            }



            DataTable Datos;
            if (Session["Datos3"] != null)
            {
                Datos = (DataTable)Session["Datos3"];
            }
            else
            {
                Datos = new DataTable();
                Datos.Columns.Add("Insumo");
                Datos.Columns.Add("Cantidad");
                Datos.Columns.Add("Precio Unitario");
            }

            DataRow nuevafila = Datos.NewRow();
            nuevafila["Insumo"] = Insumo;
            nuevafila["Cantidad"] = Cantidad;
            nuevafila["Precio Unitario"] = PrecioUnitario;
            Datos.Rows.Add(nuevafila);

            Session["Datos3"] = Datos;
            gdvMesa3.DataSource = Datos;
            gdvMesa3.DataBind();
            txtMesa3.Text = "";
            int cant3;
            decimal prec3;
            decimal totRecaudado3 = 0;
            for (int i = 0; i < gdvMesa3.Rows.Count; i++)
            {
                cant3 = Convert.ToInt32(gdvMesa3.Rows[i].Cells[1].Text);
                prec3 = Convert.ToDecimal(gdvMesa3.Rows[i].Cells[2].Text);
                totRecaudado3 += prec3 * cant3;

            }
            Session.Add("totRecaudado3", totRecaudado3);
            totalmesa3.Text = $"El total recaudado por la mesa 3 es: {totRecaudado3}";
        }

        protected void btnAgregarMesa4_Click(object sender, EventArgs e)
        {


            InsumoNegocio insumoneg = new InsumoNegocio();

            if (txtMesa4.Text == "") { return; }
            string PrecioUnitario = ddlMesa4.SelectedValue;
            string Insumo = ddlMesa4.SelectedItem.Text;
            string Cantidad = txtMesa4.Text;

            if (!int.TryParse(Cantidad, out int cantidadInt) || cantidadInt <= 0)
            {

                lblErrorMesa4.Text = "La cantidad ingresada no es válida.";
                return;
            }


            int idInsumo = insumoneg.ObtenerIdInsumoPorNombre(Insumo);

            if (idInsumo != 0)
            {
                int stockDisponible = insumoneg.ObtenerStockDisponiblePorId(idInsumo);

                if (cantidadInt <= 0 || cantidadInt > stockDisponible)
                {
                    lblErrorMesa4.Text = "El stock disponible es: " + stockDisponible; 
                    return;
                }


            }
            else
            {
                lblErrorMesa4.Text = "No se pudo obtener el Id del insumo.";
                return;
            }





            DataTable Datos;
            if (Session["Datos4"] != null)
            {
                Datos = (DataTable)Session["Datos4"];
            }
            else
            {
                Datos = new DataTable();
                Datos.Columns.Add("Insumo");
                Datos.Columns.Add("Cantidad");
                Datos.Columns.Add("Precio Unitario");
            }

            DataRow nuevafila = Datos.NewRow();
            nuevafila["Insumo"] = Insumo;
            nuevafila["Cantidad"] = Cantidad;
            nuevafila["Precio Unitario"] = PrecioUnitario;
            Datos.Rows.Add(nuevafila);

            Session["Datos4"] = Datos;
            gdvMesa4.DataSource = Datos;
            gdvMesa4.DataBind();
            txtMesa4.Text = "";
            int cant4;
            decimal prec4;
            decimal totRecaudado4 = 0;
            for (int i = 0; i < gdvMesa4.Rows.Count; i++)
            {
                cant4 = Convert.ToInt32(gdvMesa4.Rows[i].Cells[1].Text);
                prec4 = Convert.ToDecimal(gdvMesa4.Rows[i].Cells[2].Text);
                totRecaudado4 += prec4 * cant4;

            }
            Session.Add("totRecaudado4", totRecaudado4);
            totalmesa4.Text = $"El total recaudado por la mesa 4 es: {totRecaudado4}";
        }
        protected void btnAgregarMesa5_Click(object sender, EventArgs e)
        {


            InsumoNegocio insumoneg = new InsumoNegocio();

            if (txtMesa5.Text == "") { return; }
            string PrecioUnitario = ddlMesa5.SelectedValue;
            string Insumo = ddlMesa5.SelectedItem.Text;
            string Cantidad = txtMesa5.Text;

            if (!int.TryParse(Cantidad, out int cantidadInt) || cantidadInt <= 0)
            {

                lblErrorMesa5.Text = "La cantidad ingresada no es válida.";
                return;
            }


            int idInsumo = insumoneg.ObtenerIdInsumoPorNombre(Insumo);

            if (idInsumo != 0)
            {
                int stockDisponible = insumoneg.ObtenerStockDisponiblePorId(idInsumo);

                if (cantidadInt <= 0 || cantidadInt > stockDisponible)
                {
                    lblErrorMesa5.Text = "El stock disponible es: " + stockDisponible;
                    return;
                }


            }
            else
            {
                lblErrorMesa5.Text = "No se pudo obtener el Id del insumo.";
                return;
            }

            DataTable Datos;
            if (Session["Datos5"] != null)
            {
                Datos = (DataTable)Session["Datos5"];
            }
            else
            {
                Datos = new DataTable();
                Datos.Columns.Add("Insumo");
                Datos.Columns.Add("Cantidad");
                Datos.Columns.Add("Precio Unitario");
            }

            DataRow nuevafila = Datos.NewRow();
            nuevafila["Insumo"] = Insumo;
            nuevafila["Cantidad"] = Cantidad;
            nuevafila["Precio Unitario"] = PrecioUnitario;
            Datos.Rows.Add(nuevafila);

            Session["Datos5"] = Datos;
            gdvMesa5.DataSource = Datos;
            gdvMesa5.DataBind();
            txtMesa5.Text = "";
            int cant5;
            decimal prec5;
            decimal totRecaudado5 = 0;
            for (int i = 0; i < gdvMesa5.Rows.Count; i++)
            {
                cant5 = Convert.ToInt32(gdvMesa5.Rows[i].Cells[1].Text);
                prec5 = Convert.ToDecimal(gdvMesa5.Rows[i].Cells[2].Text);
                totRecaudado5 += prec5 * cant5;

            }
            Session.Add("totRecaudado5", totRecaudado5);
            totalmesa5.Text = $"El total recaudado por la mesa 5 es: {totRecaudado5}";
        }
        protected void btnAgregarMesa6_Click(object sender, EventArgs e)
        {


            InsumoNegocio insumoneg = new InsumoNegocio();

            if (txtMesa6.Text == "") { return; }
            string PrecioUnitario = ddlMesa6.SelectedValue;
            string Insumo = ddlMesa6.SelectedItem.Text;
            string Cantidad = txtMesa6.Text;

            if (!int.TryParse(Cantidad, out int cantidadInt) || cantidadInt <= 0)
            {

                lblErrorMesa6.Text = "La cantidad ingresada no es válida.";
                return;
            }


            int idInsumo = insumoneg.ObtenerIdInsumoPorNombre(Insumo);

            if (idInsumo != 0)
            {
                int stockDisponible = insumoneg.ObtenerStockDisponiblePorId(idInsumo);

                if (cantidadInt <= 0 || cantidadInt > stockDisponible)
                {
                    lblErrorMesa6.Text = "El stock disponible es: " + stockDisponible;
                    return;
                }


            }
            else
            {
                lblErrorMesa6.Text = "No se pudo obtener el Id del insumo.";
                return;
            }

            DataTable Datos;
            if (Session["Datos6"] != null)
            {
                Datos = (DataTable)Session["Datos6"];
            }
            else
            {
                Datos = new DataTable();
                Datos.Columns.Add("Insumo");
                Datos.Columns.Add("Cantidad");
                Datos.Columns.Add("Precio Unitario");
            }

            DataRow nuevafila = Datos.NewRow();
            nuevafila["Insumo"] = Insumo;
            nuevafila["Cantidad"] = Cantidad;
            nuevafila["Precio Unitario"] = PrecioUnitario;
            Datos.Rows.Add(nuevafila);

            Session["Datos6"] = Datos;
            gdvMesa6.DataSource = Datos;
            gdvMesa6.DataBind();
            txtMesa6.Text = "";
            int cant6;
            decimal prec6;
            decimal totRecaudado6 = 0;
            for (int i = 0; i < gdvMesa6.Rows.Count; i++)
            {
                cant6 = Convert.ToInt32(gdvMesa6.Rows[i].Cells[1].Text);
                prec6 = Convert.ToDecimal(gdvMesa6.Rows[i].Cells[2].Text);
                totRecaudado6 += prec6 * cant6;

            }
            Session.Add("totRecaudado6", totRecaudado6);
            totalmesa6.Text = $"El total recaudado por la mesa 5 es: {totRecaudado6}";
        }

        protected void btnPagarmesa1_Click(object sender, EventArgs e)
        {
            PedidoNegocio crearPedido = new PedidoNegocio();
            if (crearPedido.CrearPedido(1) == false)
            {
                return;
            }

            PedidosXInsumo regPXI = new PedidosXInsumo();
            regPXI.NumeroPedido = new Pedido();
            regPXI.NumeroPedido.NumeroPedido = crearPedido.ultimoNumPedido();
            if (regPXI.NumeroPedido.NumeroPedido == -1) { return; }

            string Nombre1;
            double precio;

            for (int i = 0; i < gdvMesa1.Rows.Count; i++)
            {
                regPXI.CantVendida = Convert.ToInt32(gdvMesa1.Rows[i].Cells[1].Text);
                precio = Convert.ToDouble(gdvMesa1.Rows[i].Cells[2].Text);
                regPXI.PrecioUnitario = Math.Round(precio, 2);
                Nombre1 = gdvMesa1.Rows[i].Cells[0].Text;

                regPXI.IdInsumo = new Insumo();
                regPXI.IdInsumo.Idinsumo = crearPedido.BuscarIdInsumo(Nombre1);

                crearPedido.ingresarInsumoXPedido(regPXI);
            }

            int numeroPedido = regPXI.NumeroPedido.NumeroPedido;

            // Actualiza el estado del pedido a "Pedido Cerrado"
            crearPedido.ActualizarEstadoPedido(numeroPedido, false);
            crearPedido.ActualizarFacturacion(numeroPedido, false);
           

            Session["Mesa 1"] = null;
            Session["ListaInsumos1"] = null;
            Session["Datos"] = null;
            Session["totRecaudado1"] = null;
            Session["MostrarPlatos1"] = null;
        }
        protected void btnPagarmesa2_Click(object sender, EventArgs e)
        {
            PedidoNegocio crearPedido = new PedidoNegocio();
            if (crearPedido.CrearPedido(2) == false)
            {
                return;
            }
            PedidosXInsumo regPXI = new PedidosXInsumo();
            regPXI.NumeroPedido = new Pedido();
            regPXI.NumeroPedido.NumeroPedido = crearPedido.ultimoNumPedido();
            if (regPXI.NumeroPedido.NumeroPedido == -1) { return; }

            string Nombre1;
            double precio;
            for (int i = 0; i < gdvMesa2.Rows.Count; i++)
            {
                regPXI.CantVendida = Convert.ToInt32(gdvMesa2.Rows[i].Cells[1].Text);
                precio = Convert.ToDouble(gdvMesa2.Rows[i].Cells[2].Text);
                regPXI.PrecioUnitario = Math.Round(precio, 2);
                Nombre1 = gdvMesa2.Rows[i].Cells[0].Text;

                regPXI.IdInsumo = new Insumo();
                regPXI.IdInsumo.Idinsumo = crearPedido.BuscarIdInsumo(Nombre1);

                crearPedido.ingresarInsumoXPedido(regPXI);
            }
            int numeroPedido = regPXI.NumeroPedido.NumeroPedido;

            // Actualiza el estado del pedido a "Pedido Cerrado"
            crearPedido.ActualizarEstadoPedido(numeroPedido, false);
            crearPedido.ActualizarFacturacion(numeroPedido, false);

            Session["Mesa 2"] = null;
            Session["ListaInsumos2"] = null;
            Session["Datos2"] = null;
            Session["totRecaudado2"] = null;
            Session["MostrarPlatos2"] = null;

        }
        protected void btnPagarmesa3_Click(object sender, EventArgs e)
        {
            PedidoNegocio crearPedido = new PedidoNegocio();
            if (crearPedido.CrearPedido(3) == false)
            {
                return;
            }
            PedidosXInsumo regPXI = new PedidosXInsumo();
            regPXI.NumeroPedido = new Pedido();
            regPXI.NumeroPedido.NumeroPedido = crearPedido.ultimoNumPedido();
            if (regPXI.NumeroPedido.NumeroPedido == -1) { return; }

            string Nombre1;
            double precio;
            for (int i = 0; i < gdvMesa3.Rows.Count; i++)
            {
                regPXI.CantVendida = Convert.ToInt32(gdvMesa3.Rows[i].Cells[1].Text);
                precio = Convert.ToDouble(gdvMesa3.Rows[i].Cells[2].Text);
                regPXI.PrecioUnitario = Math.Round(precio, 2);
                Nombre1 = gdvMesa3.Rows[i].Cells[0].Text;

                regPXI.IdInsumo = new Insumo();
                regPXI.IdInsumo.Idinsumo = crearPedido.BuscarIdInsumo(Nombre1);

                crearPedido.ingresarInsumoXPedido(regPXI);
            }
            int numeroPedido = regPXI.NumeroPedido.NumeroPedido;

            // Actualiza el estado del pedido a "Pedido Cerrado"
            crearPedido.ActualizarEstadoPedido(numeroPedido, false);
            crearPedido.ActualizarFacturacion(numeroPedido, false);

            Session["Mesa 3"] = null;
            Session["ListaInsumos3"] = null;
            Session["Datos3"] = null;
            Session["totRecaudado3"] = null;
            Session["MostrarPlatos3"] = null;

        }
        protected void btnPagarmesa4_Click(object sender, EventArgs e)
        {
            PedidoNegocio crearPedido = new PedidoNegocio();
            if (crearPedido.CrearPedido(4) == false)
            {
                return;
            }
            PedidosXInsumo regPXI = new PedidosXInsumo();
            regPXI.NumeroPedido = new Pedido();
            regPXI.NumeroPedido.NumeroPedido = crearPedido.ultimoNumPedido();
            if (regPXI.NumeroPedido.NumeroPedido == -1) { return; }

            string Nombre1;
            double precio;
            for (int i = 0; i < gdvMesa4.Rows.Count; i++)
            {
                regPXI.CantVendida = Convert.ToInt32(gdvMesa4.Rows[i].Cells[1].Text);
                precio = Convert.ToDouble(gdvMesa4.Rows[i].Cells[2].Text);
                regPXI.PrecioUnitario = Math.Round(precio, 2);
                Nombre1 = gdvMesa4.Rows[i].Cells[0].Text;

                regPXI.IdInsumo = new Insumo();
                regPXI.IdInsumo.Idinsumo = crearPedido.BuscarIdInsumo(Nombre1);

                crearPedido.ingresarInsumoXPedido(regPXI);
            }
            int numeroPedido = regPXI.NumeroPedido.NumeroPedido;

            // Actualiza el estado del pedido a "Pedido Cerrado"
            crearPedido.ActualizarEstadoPedido(numeroPedido, false);
            crearPedido.ActualizarFacturacion(numeroPedido, true);

            Session["Mesa 4"] = null;
            Session["ListaInsumos4"] = null;
            Session["Datos4"] = null;
            Session["totRecaudado4"] = null;
            Session["MostrarPlatos4"] = null;
        }

        protected void btnPagarmesa5_Click(object sender, EventArgs e)
        {
            PedidoNegocio crearPedido = new PedidoNegocio();
            if (crearPedido.CrearPedido(5) == false)
            {
                return;
            }
            PedidosXInsumo regPXI = new PedidosXInsumo();
            regPXI.NumeroPedido = new Pedido();
            regPXI.NumeroPedido.NumeroPedido = crearPedido.ultimoNumPedido();
            if (regPXI.NumeroPedido.NumeroPedido == -1) { return; }

            string Nombre1;
            double precio;
            for (int i = 0; i < gdvMesa5.Rows.Count; i++)
            {
                regPXI.CantVendida = Convert.ToInt32(gdvMesa5.Rows[i].Cells[1].Text);
                precio = Convert.ToDouble(gdvMesa5.Rows[i].Cells[2].Text);
                regPXI.PrecioUnitario = Math.Round(precio, 2);
                Nombre1 = gdvMesa5.Rows[i].Cells[0].Text;

                regPXI.IdInsumo = new Insumo();
                regPXI.IdInsumo.Idinsumo = crearPedido.BuscarIdInsumo(Nombre1);

                crearPedido.ingresarInsumoXPedido(regPXI);
            }
            int numeroPedido = regPXI.NumeroPedido.NumeroPedido;

            // Actualiza el estado del pedido a "Pedido Cerrado"
            crearPedido.ActualizarEstadoPedido(numeroPedido, false);
            crearPedido.ActualizarFacturacion(numeroPedido, true);

            Session["Mesa 5"] = null;
            Session["ListaInsumos5"] = null;
            Session["Datos5"] = null;
            Session["totRecaudado5"] = null;
            Session["MostrarPlatos5"] = null;
        }
        protected void btnPagarmesa6_Click(object sender, EventArgs e)
        {
            PedidoNegocio crearPedido = new PedidoNegocio();
            if (crearPedido.CrearPedido(6) == false)
            {
                return;
            }
            PedidosXInsumo regPXI = new PedidosXInsumo();
            regPXI.NumeroPedido = new Pedido();
            regPXI.NumeroPedido.NumeroPedido = crearPedido.ultimoNumPedido();
            if (regPXI.NumeroPedido.NumeroPedido == -1) { return; }

            string Nombre1;
            double precio;
            for (int i = 0; i < gdvMesa6.Rows.Count; i++)
            {
                regPXI.CantVendida = Convert.ToInt32(gdvMesa6.Rows[i].Cells[1].Text);
                precio = Convert.ToDouble(gdvMesa6.Rows[i].Cells[2].Text);
                regPXI.PrecioUnitario = Math.Round(precio, 2);
                Nombre1 = gdvMesa6.Rows[i].Cells[0].Text;

                regPXI.IdInsumo = new Insumo();
                regPXI.IdInsumo.Idinsumo = crearPedido.BuscarIdInsumo(Nombre1);

                crearPedido.ingresarInsumoXPedido(regPXI);
            }
            int numeroPedido = regPXI.NumeroPedido.NumeroPedido;

            // Actualiza el estado del pedido a "Pedido Cerrado"
            crearPedido.ActualizarEstadoPedido(numeroPedido, false);
            crearPedido.ActualizarFacturacion(numeroPedido, true);

            Session["Mesa 6"] = null;
            Session["ListaInsumos6"] = null;
            Session["Datos6"] = null;
            Session["totRecaudado6"] = null;
            Session["MostrarPlatos6"] = null;
        }

        public void cargarNombreCategoria(DropDownList lista)
        {
            CategoriaNegocio NC = new CategoriaNegocio();

            Session.Add("NombreCategoria", NC.traerNombreCategoria());
            lista.DataSource = Session["NombreCategoria"];

            lista.DataBind();
        }

        protected void ddlCategoria1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["MostrarPlatos1"] == null)
            {
                Session.Add("MostrarPlatos1", true);

            }
            string nomCat = ddlCategoria1.SelectedValue;
            LlenarLista(ddlMesa1, nomCat, "ListaInsumos1");
        }

        protected void ddlCategoria2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["MostrarPlatos2"] == null)
            {
                Session.Add("MostrarPlatos2", true);

            }
            string nomCat = ddlCategoria2.SelectedValue;
            LlenarLista(ddlMesa2, nomCat, "ListaInsumos2");
        }

        protected void ddlCategoria3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["MostrarPlatos3"] == null)
            {
                Session.Add("MostrarPlatos3", true);

            }
            string nomCat = ddlCategoria3.SelectedValue;
            LlenarLista(ddlMesa3, nomCat, "ListaInsumos3");
        }
        protected void ddlCategoria4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["MostrarPlatos4"] == null)
            {
                Session.Add("MostrarPlatos4", true);

            }
            string nomCat = ddlCategoria4.SelectedValue;
            LlenarLista(ddlMesa4, nomCat, "ListaInsumos4");
        }
        protected void ddlCategoria5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["MostrarPlatos5"] == null)
            {
                Session.Add("MostrarPlatos5", true);

            }
            string nomCat = ddlCategoria5.SelectedValue;
            LlenarLista(ddlMesa5, nomCat, "ListaInsumos5");
        }
        protected void ddlCategoria6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["MostrarPlatos6"] == null)
            {
                Session.Add("MostrarPlatos6", true);

            }
            string nomCat = ddlCategoria6.SelectedValue;
            LlenarLista(ddlMesa6, nomCat, "ListaInsumos6");
        }

        public void rellenarListaSessionCategorias(DropDownList listaCategoria)
        {
            if (Session["NombreCategoria"] != null)
            {
                listaCategoria.DataSource = Session["NombreCategoria"];
                listaCategoria.DataBind();
            }
        }

        public void rellenarListaSessionInsumos(DropDownList listaInsumos, string NombreSession)
        {
            if (Session[NombreSession] != null)
            {
                listaInsumos.DataSource = Session[NombreSession];
                listaInsumos.DataTextField = "Nombre_Insumo";
                listaInsumos.DataValueField = "PrecioUnitario_Insumo";
                listaInsumos.DataBind();
            }
        }
        public void rellenarGrillaSession(GridView grilla, string NombreSessionGrilla)
        {
            if (Session[NombreSessionGrilla] != null)
            {
                grilla.DataSource = Session[NombreSessionGrilla];
                grilla.DataBind();
            }
        }

        public void rellenarTotRecaudadoSession(Label lbl, string NombreSessionRecaudacion, int NumMesa)
        {
            if (Session[NombreSessionRecaudacion] != null)
            {
                lbl.Text = $"El total recaudado por la mesa {NumMesa} es: {Session[NombreSessionRecaudacion]}";
            }
        }

    }
}