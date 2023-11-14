using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{
    public partial class FormularioTipoDeInsumo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            TipoInsumo Tipo = new TipoInsumo();


            Tipo.Id_TI = int.Parse(txtIdTipoInsumo.Text);
            Tipo.NombreTipoInsumo = txtNombreTipo.Text;
            Tipo.DescripcionTipoInsumo= txtDescripcionTipo.Text;
            Tipo.EstadoTipoInsumo = true;


            TipoInsumoNegocio TipoNegocio = new TipoInsumoNegocio();

            TipoNegocio.AgregarTipoInsumo(Tipo);


            Response.Redirect("AdmiCategoria.aspx", false);
        }
    }
}