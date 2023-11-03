using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{   
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.NombreUsuario=TxtNombreUsuario.Text;
            usuario.Contraseña=TxtContraseña.Text;
            UsuarioNegocio us=new UsuarioNegocio();
            if (us.Loguear(usuario)==true)
            {
                Response.Redirect("Gerente.aspx");
            }
            else
            {
                TxtNombreUsuario.Text = "";
                TxtContraseña.Text ="";
            }
        }
    }
}