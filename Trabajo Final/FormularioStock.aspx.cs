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
           txtIdInsumo.Enabled = false;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            
                   
                    Insumo nuevoInsumo = new Insumo();
                  
                    nuevoInsumo.NombreInsumo = txtNombreInsumo.Text;
                    nuevoInsumo.CantidadStock = int.Parse(textCantidadStock.Text);
                    nuevoInsumo.PrecioUnitario = decimal.Parse(textPrecioUnitario.Text);

                    nuevoInsumo.Tipo = new TipoInsumo();
                    nuevoInsumo.Tipo.Id_TI = int.Parse(txtIdTipo.Text);
                    nuevoInsumo.Tipo.NombreTipoInsumo = txtNombreTipo.Text;
                    nuevoInsumo.Tipo.DescripcionTipoInsumo = txtDescripcion.Text;

                    nuevoInsumo.Descripcion = new Categoria();
                    nuevoInsumo.Descripcion.Id_Categoria = int.Parse(txtIdCategoria.Text);

                    
                    InsumoNegocio negocioInsumo = new InsumoNegocio();
                    negocioInsumo.AgregarInsumo(nuevoInsumo);


            Response.Redirect("StockDeInsumos.aspx", false);


        }
    }
}