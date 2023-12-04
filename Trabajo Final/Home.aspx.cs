using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Final
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Usuario"] == null)
                {
                    Session.Add("error", "Debes Loguearte para ingresar");
                    Response.Redirect("Error.aspx");
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", "Error durante la verificación de la sesión: " + ex.Message);
                Response.Redirect("Error.aspx");
            }
        }
        //nuevo boton mozo
        protected void btnMozo_Click(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                Session.Add("TipoUsuario", "Mozo");
                Response.Write("Botón Mozo clickeado. Redireccionando...");
                Response.Redirect("Home.aspx");
            }
            /*  else
              {
                  Response.Write("La sesión de usuario no está configurada correctamente.");

              }*/
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
                    Response.Redirect("Home.aspx");
                }
                /* else
                 {
                     Response.Write("El usuario no es de tipo Gerente.");
                 }*/
            }
            else
            {
                //Response.Write("La sesión de usuario no está configurada correctamente.");
                Session.Add("error", "user o pass incorrectos");
                Response.Redirect("Error.aspx");

            }
        }
    }
}