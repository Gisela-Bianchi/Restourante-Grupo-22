using Dominio;
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


        }

        protected void btnAgregarMesa2_Click(object sender, EventArgs e)
        {
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
        }

        protected void btnAgregarMesa3_Click(object sender, EventArgs e)
        {
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
        }

        protected void btnAgregarMesa4_Click(object sender, EventArgs e)
        {
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
        }
    }
}