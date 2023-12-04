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
        {   //modificado
            Usuario usuario = new Usuario();
            usuario.Usuarios=TxtNombreUsuario.Text;
            usuario.Contraseña=TxtContraseña.Text;
            UsuarioNegocio us=new UsuarioNegocio();
            Usuario regUsuario = us.Loguear(usuario);
            if (regUsuario.Activo==true)
            {
                Session.Add("Usuario", regUsuario);
                Response.Redirect("Home.aspx");
            }
            else
            {
                TxtNombreUsuario.Text = "";
                TxtContraseña.Text ="";
            }
        }
    }
}////prueba