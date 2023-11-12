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
            //if (!IsPostBack)
            //{
            //    ddlTipoInsumo.Items.Add("Bebida");
            //    ddlTipoInsumo.Items.Add("Plato");
            //}
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            Insumo  nuevoInsumo = new Insumo();

            Insumo insumo = new Insumo();
            //insumo.Tipo.Nombre = ddlTipoInsumo.SelectedValue;
            insumo.Idinsumo = int.Parse(txtIdInsumo.Text);
            insumo.NombreInsumo = txtNombreInsumo.Text;
            insumo.CantidadStock= int.Parse(textCantidadStock.Text);
            insumo.PrecioUnitario = decimal.Parse(textPrecioUnitario.Text);
            insumo.Tipo.Id= int.Parse(txtIdTipo.Text);
            insumo.Tipo.Nombre=(string)txtNombreTipo.Text;
            insumo.Tipo.Descripcion= txtDescripcion.Text;
            insumo.Descripcion.IdCategoria=int.Parse(txtIdCategoria.Text);
           

            InsumoNegocio negocioInsumo = new InsumoNegocio();

      
            negocioInsumo.AgregarInsumo(nuevoInsumo);

        }
    }
}