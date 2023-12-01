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
        public bool ConfirmarEliminacion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                txtIdInsumo.Enabled = false;

                ConfirmarEliminacion = false;

                if (!IsPostBack)
                {
                    TipoInsumoNegocio tipo = new TipoInsumoNegocio();

                    List<TipoInsumo> listaTipo = tipo.Listar();

                    ddlTipo.DataSource = listaTipo;
                    ddlTipo.DataValueField = "Id_TI";
                    ddlTipo.DataTextField = "NombreTipoInsumo";
                    ddlTipo.DataBind();

                    CategoriaNegocio categoria = new CategoriaNegocio();

                    List<Categoria> listaCategoria = categoria.Listar();

                    ddlCategoria.DataSource = listaCategoria;
                    ddlCategoria.DataValueField = "Id_Categoria";
                    ddlCategoria.DataTextField = "Descripcion_Categoria";
                    ddlCategoria.DataBind();

                    // ModificacionInsumo
                    string id = Request.QueryString["id"];
                    if (!string.IsNullOrEmpty(id))
                    {
                        InsumoNegocio negocio = new InsumoNegocio();
                        List<Insumo> listaInsumos = negocio.ListaXid(id);

                        if (listaInsumos.Count > 0)
                        {
                            Insumo seleccionado = listaInsumos[0];

                            // Cargamos los campos nuevos
                            txtIdInsumo.Text = id;
                            txtNombreInsumo.Text = seleccionado.NombreInsumo;
                            textPrecioUnitario.Text = seleccionado.PrecioUnitario.ToString();
                            textCantidadStock.Text = seleccionado.CantidadStock.ToString();

                            // Seleccionamos los valores en los desplegables
                            ddlTipo.SelectedValue = seleccionado.Tipo.Id_TI.ToString();
                            ddlCategoria.SelectedValue = seleccionado.Descripcion.Id_Categoria.ToString();
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                Session.Add("error ", ex);
                throw;
            }




        }

        protected void btnAceptar_Click(object sender, EventArgs e)

        {
            Insumo nuevoInsumo = new Insumo();

            nuevoInsumo.Idinsumo = int.Parse(txtIdInsumo.Text);
            nuevoInsumo.NombreInsumo = txtNombreInsumo.Text;
                    /* nuevoInsumo.CantidadStock = int.Parse(textCantidadStock.Text);
                     if (nuevoInsumo.CantidadStock < 0)
                     {

                         lblError.Text = "La cantidad no puede ser menor a cero.";
                         return;
                     }
                     nuevoInsumo.PrecioUnitario = decimal.Parse(textPrecioUnitario.Text);*/
                    if (!int.TryParse(textCantidadStock.Text, out int cantidadStock) || cantidadStock < 0)
                    {
                        lblError.Text = "La cantidad no puede ser menor a cero y debe ser un valor numérico.";
                        return;
                    }

                    nuevoInsumo.CantidadStock = cantidadStock;

                    if (!decimal.TryParse(textPrecioUnitario.Text, out decimal precioUnitario) || precioUnitario < 0)
                    {
                        lblError.Text = "El precio unitario no puede ser menor a cero y debe ser un valor numérico.";//ult
                        return;
                    }

            nuevoInsumo.PrecioUnitario = precioUnitario;

            nuevoInsumo.Tipo = new TipoInsumo();
            nuevoInsumo.Tipo.Id_TI = int.Parse(ddlTipo.SelectedValue);

            nuevoInsumo.Descripcion = new Categoria();
            nuevoInsumo.Descripcion.Id_Categoria = int.Parse(ddlCategoria.SelectedValue);

            InsumoNegocio negocioInsumo = new InsumoNegocio();

            if (Request.QueryString["id"] != null)
            {
                nuevoInsumo.Idinsumo = int.Parse(Request.QueryString["id"].ToString());
                negocioInsumo.MofidicarInsumo(nuevoInsumo);

            }

            else
            {
                negocioInsumo.AgregarInsumo(nuevoInsumo);
            }






            Response.Redirect("StockDeInsumos.aspx", false);



        }

        protected void btnConfirmarEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChkConfirmarEliminar.Checked)
                {
                    InsumoNegocio insumo = new InsumoNegocio();
                    insumo.EliminarInsumo(int.Parse(txtIdInsumo.Text));
                    Response.Redirect("StockDeInsumos.aspx", false);

                }
            }

            catch (Exception ex)
            {

                Session.Add("error", ex);
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ConfirmarEliminacion = true;
        }
    }
}