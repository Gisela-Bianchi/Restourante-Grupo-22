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

        }

        protected void btnIngresar4_Click(object sender, EventArgs e)
        {
            Session.Add("Mesa 4", 4);
            LlenarLista(ddlMesa4);
        }

        protected void btnIngresar3_Click(object sender, EventArgs e)
        {
            Session.Add("Mesa 3", 3);
            LlenarLista(ddlMesa3);
        }

        protected void btnIngresar2_Click(object sender, EventArgs e)
        {
            Session.Add("Mesa 2", 2);
            LlenarLista(ddlMesa2);

        }

        protected void btnIngresar1_Click(object sender, EventArgs e)
        {
            Session.Add("Mesa 1", 1);
            LlenarLista(ddlMesa1);
        }
        public void LlenarLista(DropDownList Lista)
        {
            InsumoNegocio insumoNegocio = new InsumoNegocio();
            DataTable dataTable = insumoNegocio.ObtenerNombreInsumo();
            Lista.DataSource = dataTable;
            Lista.DataTextField = "Nombre_Insumo";
            Lista.DataValueField = "PrecioUnitario_Insumo";
            Lista.DataBind();
        }

        protected void btnAgregarMesa1_Click(object sender, EventArgs e)
        {
            if (txtMesa1.Text == "") { return; }
            string PrecioUnitario = ddlMesa1.SelectedValue;
            string Insumo = ddlMesa1.SelectedItem.Text;
            string Cantidad = txtMesa1.Text;

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
            totalmesa1.Text = $"El total recaudado por la mesa 1 es: {totRecaudado1}";

        }

        protected void btnAgregarMesa2_Click(object sender, EventArgs e)
        {
            if (txtMesa2.Text == "") { return; }
            string PrecioUnitario = ddlMesa2.SelectedValue;
            string Insumo = ddlMesa2.SelectedItem.Text;
            string Cantidad = txtMesa2.Text;

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
            totalmesa2.Text = $"El total recaudado por la mesa 2 es: {totRecaudado2}";
        }

        protected void btnAgregarMesa3_Click(object sender, EventArgs e)
        {
            if (txtMesa3.Text == "") { return; }
            string PrecioUnitario = ddlMesa3.SelectedValue;
            string Insumo = ddlMesa3.SelectedItem.Text;
            string Cantidad = txtMesa3.Text;

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
            totalmesa3.Text = $"El total recaudado por la mesa 3 es: {totRecaudado3}";
        }

        protected void btnAgregarMesa4_Click(object sender, EventArgs e)
        {
            if (txtMesa4.Text == "") { return; }
            string PrecioUnitario = ddlMesa4.SelectedValue;
            string Insumo = ddlMesa4.SelectedItem.Text;
            string Cantidad = txtMesa4.Text;

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
            totalmesa4.Text = $"El total recaudado por la mesa 4 es: {totRecaudado4}";
        }

        protected void btnPagarmesa1_Click(object sender, EventArgs e)
        {
            PedidoNegocio crearPedido=new PedidoNegocio();
            if(crearPedido.CrearPedido(1)==false) 
            {
                return;
            }
            PedidosXInsumo regPXI = new PedidosXInsumo();
            regPXI.NumeroPedido = new Pedido();
            regPXI.NumeroPedido.NumeroPedido = crearPedido.ultimoNumPedido();
            if(regPXI.NumeroPedido.NumeroPedido == -1) { return; }
            
            string Nombre1;
            double precio;
            for (int i = 0; i < gdvMesa1.Rows.Count; i++)
            {
                regPXI.CantVendida = Convert.ToInt32(gdvMesa1.Rows[i].Cells[1].Text);
               precio = Convert.ToDouble(gdvMesa1.Rows[i].Cells[2].Text);
                regPXI.PrecioUnitario=Math.Round(precio,2);
                Nombre1 = gdvMesa1.Rows[i].Cells[0].Text;

                regPXI.IdInsumo = new Insumo();
                regPXI.IdInsumo.Idinsumo = crearPedido.BuscarIdInsumo(Nombre1);
                
                crearPedido.ingresarInsumoXPedido(regPXI);
            }
            Session["Mesa 1"] = null;
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
            Session["Mesa 2"] = null;
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
            Session["Mesa 3"] = null;
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
            Session["Mesa 4"] = null;
        }

      
    }
}