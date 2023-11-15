using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Trabajo_Final
{
    public partial class FormularioStock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TipoInsumoNegocio tipo = new TipoInsumoNegocio();
                List<TipoInsumo> lista = tipo.Listar();

                ddlTipo.DataSource = lista;
                ddlTipo.DataValueField = "Id_TI";
                ddlTipo.DataTextField = "DescripcionTipoInsumo";

                ddlTipo.DataBind();

                CategoriaNegocio categoria = new CategoriaNegocio();
                List<Categoria> list = categoria.Listar();


                ddlCategoria.DataSource = list;
                ddlCategoria.DataValueField = "Id_Categoria";
                ddlCategoria.DataTextField = "Descripcion_Categoria";

                ddlCategoria.DataBind();
            }
        }
        protected void btnAceptar_Click(object sender, EventArgs e)

        {


            Insumo nuevoInsumo = new Insumo();


            nuevoInsumo.NombreInsumo = txtNombreInsumo.Text;
            nuevoInsumo.CantidadStock = int.Parse(textCantidadStock.Text);
            nuevoInsumo.PrecioUnitario = decimal.Parse(textPrecioUnitario.Text);




            InsumoNegocio negocioInsumo = new InsumoNegocio();
            negocioInsumo.AgregarInsumo(nuevoInsumo);


            Response.Redirect("StockDeInsumos.aspx", false);


        }
    }
}