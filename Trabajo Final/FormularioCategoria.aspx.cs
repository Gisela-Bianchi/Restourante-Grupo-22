using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{
    public partial class FormularioCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            Categoria categoria= new Categoria();

           
            categoria.Id_Categoria = int.Parse(txtIdCategoria.Text);
            categoria.Descripcion_Categoria = txtDescripcion.Text;


            CategoriaNegocio negocioCategoria = new CategoriaNegocio();
            negocioCategoria.AgregarCategoria(categoria);


            Response.Redirect("AdmiCategoria.aspx", false);

        }
    }
}