using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{
    public partial class Ingreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //nuevo boton mozo
        protected void btnMozo_Click(object sender, EventArgs e)
        {
            if (Session["Usuario" ]!= null)
            {
                Session.Add("TipoUsuario", "Mozo");
                Response.Write("Botón Mozo clickeado. Redireccionando...");
                Response.Redirect("Gerente.aspx");
            }
            else
            {
                Response.Write("La sesión de usuario no está configurada correctamente.");
            }
        }
           //nuevo boton gerente
        protected void btnGerente_Click(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                Usuario regUsuario = (Usuario)Session["Usuario"];
                if (regUsuario.TipoUsuario == 2)
                {
                    Session.Add("TipoUsuario", "Gerente");
                    Response.Write("Botón Gerente clickeado. Redireccionando...");
                    Response.Redirect("Gerente.aspx");
                }
               /* else
                {
                    Response.Write("El usuario no es de tipo Gerente.");
                }*/
            }
            else
            {
                Response.Write("La sesión de usuario no está configurada correctamente.");
            }
        }
    }
}