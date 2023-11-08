using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Trabajo_Final
{
    public partial class FormularioStock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Insumo insumo = new Insumo();
            insumo.NombreInsumo = txtNombreInsumo.Text;
            insumo.CantidadStock= int.Parse(textCantidadStock.Text);
            insumo.PrecioUnitario = decimal.Parse(textPrecioUnitario.Text);

            //Lo mando a la base de datos con algun metodo

        }
    }
}