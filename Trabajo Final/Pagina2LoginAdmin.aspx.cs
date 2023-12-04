using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{
    public partial class Pagina2LoginAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Session["Usuario"] != null && ((Dominio.Usuario)Session["Usuario"]).TipoUsuario == 2))
            {
                Session.Add("error", "No tienen permisos para ingresar a esta pantalla.Necesitas nivel admin.");
                Response.Redirect("Error.aspx",false);
            }
        }
    }
}